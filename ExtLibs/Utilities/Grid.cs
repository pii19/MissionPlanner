using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MissionPlanner.Utilities;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;
using GeoAPI.CoordinateSystems;
using GeoAPI.CoordinateSystems.Transformations;

namespace MissionPlanner.Utilities
{
    public class Grid
    {
        const double rad2deg = (180 / Math.PI);
        const double deg2rad = (1.0 / rad2deg);

        public struct linelatlng
        {
            // start of line
            public utmpos p1;
            // end of line
            public utmpos p2;
            // used as a base for grid along line (initial setout)
            public utmpos basepnt;
        }

        public enum StartPosition
        {
            [EnumDisplayName("ホーム")]
            Home = 0,
            [EnumDisplayName("左下")]
            BottomLeft = 1,
            [EnumDisplayName("左上")]
            TopLeft = 2,
            [EnumDisplayName("右下")]
            BottomRight = 3,
            [EnumDisplayName("右上")]
            TopRight = 4,
            [EnumDisplayName("ポイント")]
            Point = 5
        }

        public static PointLatLngAlt StartPointLatLngAlt = PointLatLngAlt.Zero;

        static void addtomap(linelatlng pos)
        {

        }

        static void addtomap(utmpos pos, string tag)
        {

        }

        public static async Task<List<PointLatLngAlt>> CreateCorridorAsync(List<PointLatLngAlt> polygon, double altitude,
            double distance,
            double spacing, double angle, double overshoot1, double overshoot2, StartPosition startpos, bool shutter,
            float minLaneSeparation, double width, float leadin = 0)
        {
            return await Task.Run(() => CreateCorridor(polygon, altitude, distance, spacing, angle, overshoot1, overshoot2,
                startpos, shutter, minLaneSeparation, width, leadin));
        }

        public static List<PointLatLngAlt> CreateCorridor(List<PointLatLngAlt> polygon, double altitude, double distance,
            double spacing, double angle, double overshoot1, double overshoot2, StartPosition startpos, bool shutter,
            float minLaneSeparation, double width, float leadin = 0)
        {
            if (spacing < 4 && spacing != 0)
                spacing = 4;

            if (distance < 0.1)
                distance = 0.1;

            if (polygon.Count == 0)
                return new List<PointLatLngAlt>();

            List<PointLatLngAlt> ans = new List<PointLatLngAlt>();

            // utm zone distance calcs will be done in
            int utmzone = polygon[0].GetUTMZone();

            // utm position list
            List<utmpos> utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(utmzone, polygon), utmzone);

            var lanes = (width / distance);
            var start = (int)((lanes / 2) * -1);
            var end = start * -1;

            for (int lane = start; lane <= end; lane++)
            {
                // correct side of the line we are on because of list reversal
                int multi = 1;
                if ((lane - start) % 2 == 1)
                    multi = -1;

                GenerateOffsetPath(utmpositions, distance * multi * lane, spacing, utmzone)
                    .ForEach(pnt => { ans.Add(pnt); });

                utmpositions.Reverse();
            }

            // set the altitude on all points
            ans.ForEach(plla => { plla.Alt = altitude; });

            return ans;
        }

        private static List<utmpos> GenerateOffsetPath(List<utmpos> utmpositions, double distance, double spacing, int utmzone)
        {
            List<utmpos> ans = new List<utmpos>();

            utmpos oldpos = utmpos.Zero;

            for (int a = 0; a < utmpositions.Count - 2; a++)
            {
                var prevCenter = utmpositions[a];
                var currCenter = utmpositions[a + 1];
                var nextCenter = utmpositions[a + 2];

                var l1bearing = prevCenter.GetBearing(currCenter);
                var l2bearing = currCenter.GetBearing(nextCenter);

                var l1prev = newpos(prevCenter, l1bearing + 90, distance);
                var l1curr = newpos(currCenter, l1bearing + 90, distance);

                var l2curr = newpos(currCenter, l2bearing + 90, distance);
                var l2next = newpos(nextCenter, l2bearing + 90, distance);

                var l1l2center = FindLineIntersectionExtension(l1prev, l1curr, l2curr, l2next);

                //start
                if (a == 0)
                {
                    // add start
                    l1prev.Tag = "S";
                    ans.Add(l1prev);

                    // add start/trigger
                    l1prev.Tag = "SM";
                    ans.Add(l1prev);

                    oldpos = l1prev;
                }

                //spacing
                if (spacing > 0)
                {
                    for (int d = (int)((oldpos.GetDistance(l1l2center)) % spacing);
                        d < (oldpos.GetDistance(l1l2center));
                        d += (int)spacing)
                    {
                        double ax = oldpos.x;
                        double ay = oldpos.y;

                        newpos(ref ax, ref ay, l1bearing, d);
                        var utmpos2 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                        ans.Add(utmpos2);
                    }
                }

                //end of leg
                l1l2center.Tag = "S";
                ans.Add(l1l2center);
                oldpos = l1l2center;

                // last leg
                if ((a + 3) == utmpositions.Count)
                {
                    if (spacing > 0)
                    {
                        for (int d = (int)((l1l2center.GetDistance(l2next)) % spacing);
                            d < (l1l2center.GetDistance(l2next));
                            d += (int)spacing)
                        {
                            double ax = l1l2center.x;
                            double ay = l1l2center.y;

                            newpos(ref ax, ref ay, l2bearing, d);
                            var utmpos2 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                            ans.Add(utmpos2);
                        }
                    }

                    l2next.Tag = "ME";
                    ans.Add(l2next);

                    l2next.Tag = "E";
                    ans.Add(l2next);
                }
            }

            return ans;
        }

        public static async Task<List<PointLatLngAlt>> CreateGridAsync(List<PointLatLngAlt> polygon, double altitude,
            double distance, double spacing, double angle, double overshoot1, double overshoot2, StartPosition startpos,
            bool shutter, float minLaneSeparation, float leadin, PointLatLngAlt HomeLocation)
        {
            return await Task.Run((() => CreateGrid(polygon, altitude, distance, spacing, angle, overshoot1, overshoot2,
                startpos, shutter, minLaneSeparation, leadin, HomeLocation)));
        }

        public static List<PointLatLngAlt> CreateGrid(List<PointLatLngAlt> polygon, double altitude, double distance, double spacing, double angle,
            double overshoot1, double overshoot2, StartPosition startpos, bool shutter, float minLaneSeparation, float leadin, PointLatLngAlt HomeLocation)
        {
            return CreateGrid2(polygon, altitude, distance, spacing, ref angle, overshoot1, overshoot2,
                startpos, shutter, minLaneSeparation, leadin, HomeLocation, 0, false);
        }
        public static List<PointLatLngAlt> CreateGrid2(List<PointLatLngAlt> polygon, double altitude, double distance, double spacing, ref double angle,
            double overshoot1, double overshoot2, StartPosition startpos, bool shutter, float minLaneSeparation, float leadin, PointLatLngAlt HomeLocation, double offset, bool first)
        {
            //DoDebug();

            if (spacing < 0.1 && spacing != 0)
                spacing = 0.1;

            if (distance < 0.1)
                distance = 0.1;

            if (polygon.Count == 0)
                return new List<PointLatLngAlt>();

            // Make a non round number in case of corner cases
            if (minLaneSeparation != 0)
                minLaneSeparation += 0.5F;
            // Lane Separation in meters
            double minLaneSeparationINMeters = minLaneSeparation * distance;

            List<PointLatLngAlt> ans = new List<PointLatLngAlt>();

            // utm zone distance calcs will be done in
            int utmzone = polygon[0].GetUTMZone();

            // utm position list
            List<utmpos> utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(utmzone, polygon), utmzone);

            // close the loop if its not already
            if (utmpositions[0] != utmpositions[utmpositions.Count - 1])
                utmpositions.Add(utmpositions[0]); // make a full loop

            // get mins/maxs of coverage area
            Rect area = getPolyMinMax(utmpositions);

            // get initial grid

            // used to determine the size of the outer grid area
            double diagdist = area.DiagDistance();

            // somewhere to store out generated lines
            List<linelatlng> grid = new List<linelatlng>();
            // number of lines we need
            int lines = 0;

            // get start point middle
            double x = area.MidWidth;
            double y = area.MidHeight;

            addtomap(new utmpos(x, y, utmzone), "Base");

            //重心方向へポリゴンを縮小する @eams
            utmpos gravity = new utmpos(x, y, utmzone);
            for (int i = 0; i < utmpositions.Count(); i++)
            {
                double xp = utmpositions[i].x;
                double yp = utmpositions[i].y;
                double deg = utmpositions[i].GetBearing(gravity);
                newpos(ref xp, ref yp, deg, offset);
                utmpositions[i] = new utmpos(xp, yp, utmzone);
            }

            //初回のみポリゴンの最長辺に角度を自動的に合わせる @eams
            if (first)
            {
                double dist_max = 0.0;
                int index = 0;
                for (int i = 1; i < utmpositions.Count(); i++)
                {
                    double dist = utmpositions[i].GetDistance(utmpositions[i - 1]);
                    if (dist > dist_max)
                    {
                        dist_max = dist;
                        index = i - 1;
                    }
                    angle = utmpositions[index].GetBearing(utmpositions[index + 1]);
                }
            }

            // get left extent
            double xb1 = x;
            double yb1 = y;
            // to the left
            newpos(ref xb1, ref yb1, angle - 90, diagdist / 2 + distance);
            //            newpos(ref xb1, ref yb1, angle - 90, diagdist / 2);
            // backwards
            newpos(ref xb1, ref yb1, angle + 180, diagdist / 2 + distance);
            //            newpos(ref xb1, ref yb1, angle + 180, diagdist / 2);

            utmpos left = new utmpos(xb1, yb1, utmzone);

            addtomap(left, "left");

            // get right extent
            double xb2 = x;
            double yb2 = y;
            // to the right
            newpos(ref xb2, ref yb2, angle + 90, diagdist / 2 + distance);
            //            newpos(ref xb2, ref yb2, angle + 90, diagdist / 2);
            // backwards
            newpos(ref xb2, ref yb2, angle + 180, diagdist / 2 + distance);
            //            newpos(ref xb2, ref yb2, angle + 180, diagdist / 2);

            utmpos right = new utmpos(xb2, yb2, utmzone);

            addtomap(right, "right");

            // set start point to left hand side
            x = xb1;
            y = yb1;

            // draw the outergrid, this is a grid that cover the entire area of the rectangle plus more.
            while (lines < ((diagdist + distance * 2) / distance))
            //            while (lines < ((diagdist) / distance))
            {
                // copy the start point to generate the end point
                double nx = x;
                double ny = y;
                newpos(ref nx, ref ny, angle, diagdist + distance * 2);
                //                newpos(ref nx, ref ny, angle, diagdist);

                linelatlng line = new linelatlng();
                line.p1 = new utmpos(x, y, utmzone);
                line.p2 = new utmpos(nx, ny, utmzone);
                line.basepnt = new utmpos(x, y, utmzone);
                grid.Add(line);

                // addtomap(line);

                newpos(ref x, ref y, angle + 90, distance);
                lines++;
            }

            // find intersections with our polygon

            // store lines that dont have any intersections
            List<linelatlng> remove = new List<linelatlng>();

            int gridno = grid.Count;

            // cycle through our grid
            for (int a = 0; a < gridno; a++)
            {
                double closestdistance = double.MaxValue;
                double farestdistance = double.MinValue;

                utmpos closestpoint = utmpos.Zero;
                utmpos farestpoint = utmpos.Zero;

                // somewhere to store our intersections
                List<utmpos> matchs = new List<utmpos>();

                int b = -1;
                int crosses = 0;
                utmpos newutmpos = utmpos.Zero;
                foreach (utmpos pnt in utmpositions)
                {
                    b++;
                    if (b == 0)
                    {
                        continue;
                    }
                    newutmpos = FindLineIntersection(utmpositions[b - 1], utmpositions[b], grid[a].p1, grid[a].p2);
                    if (!newutmpos.IsZero)
                    {
                        crosses++;
                        matchs.Add(newutmpos);
                        if (closestdistance > grid[a].p1.GetDistance(newutmpos))
                        {
                            closestpoint.y = newutmpos.y;
                            closestpoint.x = newutmpos.x;
                            closestpoint.zone = newutmpos.zone;
                            closestdistance = grid[a].p1.GetDistance(newutmpos);
                        }
                        if (farestdistance < grid[a].p1.GetDistance(newutmpos))
                        {
                            farestpoint.y = newutmpos.y;
                            farestpoint.x = newutmpos.x;
                            farestpoint.zone = newutmpos.zone;
                            farestdistance = grid[a].p1.GetDistance(newutmpos);
                        }
                    }
                }
                if (crosses == 0) // outside our polygon
                {
                    if (!PointInPolygon(grid[a].p1, utmpositions) && !PointInPolygon(grid[a].p2, utmpositions))
                        remove.Add(grid[a]);
                }
                else if (crosses == 1) // bad - shouldnt happen
                {

                }
                else if (crosses == 2) // simple start and finish
                {
                    linelatlng line = grid[a];
                    line.p1 = closestpoint;
                    line.p2 = farestpoint;
                    grid[a] = line;
                }
                else // multiple intersections
                {
                    linelatlng line = grid[a];
                    remove.Add(line);

                    while (matchs.Count > 1)
                    {
                        linelatlng newline = new linelatlng();

                        closestpoint = findClosestPoint(closestpoint, matchs);
                        newline.p1 = closestpoint;
                        matchs.Remove(closestpoint);

                        closestpoint = findClosestPoint(closestpoint, matchs);
                        newline.p2 = closestpoint;
                        matchs.Remove(closestpoint);

                        newline.basepnt = line.basepnt;

                        grid.Add(newline);
                    }
                }
            }

            // cleanup and keep only lines that pass though our polygon
            foreach (linelatlng line in remove)
            {
                grid.Remove(line);
            }

            // debug
            foreach (linelatlng line in grid)
            {
                addtomap(line);
            }

            if (grid.Count == 0)
                return ans;

            // pick start positon based on initial point rectangle
            utmpos startposutm;

            switch (startpos)
            {
                default:
                case StartPosition.Home:
                    startposutm = new utmpos(HomeLocation);
                    break;
                case StartPosition.BottomLeft:
                    startposutm = new utmpos(area.Left, area.Bottom, utmzone);
                    break;
                case StartPosition.BottomRight:
                    startposutm = new utmpos(area.Right, area.Bottom, utmzone);
                    break;
                case StartPosition.TopLeft:
                    startposutm = new utmpos(area.Left, area.Top, utmzone);
                    break;
                case StartPosition.TopRight:
                    startposutm = new utmpos(area.Right, area.Top, utmzone);
                    break;
                case StartPosition.Point:
                    startposutm = new utmpos(StartPointLatLngAlt);
                    break;
            }

            // find the closes polygon point based from our startpos selection
            startposutm = findClosestPoint(startposutm, utmpositions);

            // find closest line point to startpos
            linelatlng closest = findClosestLine(startposutm, grid, 0 /*Lane separation does not apply to starting point*/, angle);

            //startposからclosestのどちらのポイントが近いかで角度を反転する。@eams add
            if (closest.p1.GetDistance(startposutm) > closest.p2.GetDistance(startposutm))
            {
                //p1のほうが遠かったら180度反転してp1とp2をすべて入れ替える。
                angle = AddAngle(angle, 180);

                linelatlng buf;
                for (int i = 0; i < grid.Count(); i++)
                {
                    buf = grid[i];
                    buf.p1 = grid[i].p2;
                    buf.p2 = grid[i].p1;
                    grid[i] = buf;
                }
                buf = closest;
                buf.p1 = closest.p2;
                buf.p2 = closest.p1;
                closest = buf;
            }

            utmpos lastpnt;

            // get the closes point from the line we picked
            if (closest.p1.GetDistance(startposutm) < closest.p2.GetDistance(startposutm))
            {
                lastpnt = closest.p1;
            }
            else
            {
                lastpnt = closest.p2;
            }

            // S =  start
            // E = end
            // ME = middle end
            // SM = start middle

            while (grid.Count > 0)
            {
                // for each line, check which end of the line is the next closest
                if (closest.p1.GetDistance(lastpnt) < closest.p2.GetDistance(lastpnt))
                {
                    utmpos newstart = newpos(closest.p1, angle, -leadin);
                    newstart.Tag = "S";
                    addtomap(newstart, "S");
                    ans.Add(newstart);

                    if (leadin < 0)
                    {
                        var p2 = new utmpos(newstart) { Tag = "SM" };
                        addtomap(p2, "SM");
                        ans.Add(p2);
                    }
                    else
                    {
                        closest.p1.Tag = "SM";
                        addtomap(closest.p1, "SM");
                        ans.Add(closest.p1);
                    }

                    if (spacing > 0)
                    {
                        for (double d = (spacing - ((closest.basepnt.GetDistance(closest.p1)) % spacing));
                            d < (closest.p1.GetDistance(closest.p2));
                            d += spacing)
                        {
                            double ax = closest.p1.x;
                            double ay = closest.p1.y;

                            newpos(ref ax, ref ay, angle, d);
                            var utmpos1 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                            addtomap(utmpos1, "M");
                            ans.Add(utmpos1);
                        }
                    }

                    utmpos newend = newpos(closest.p2, angle, overshoot1);

                    if (overshoot1 < 0)
                    {
                        var p2 = new utmpos(newend) { Tag = "ME" };
                        addtomap(p2, "ME");
                        ans.Add(p2);
                    }
                    else
                    {
                        closest.p2.Tag = "ME";
                        addtomap(closest.p2, "ME");
                        ans.Add(closest.p2);
                    }

                    newend.Tag = "E";
                    addtomap(newend, "E");
                    ans.Add(newend);

                    lastpnt = closest.p2;

                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;

                    closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                }
                else
                {
                    utmpos newstart = newpos(closest.p2, angle, leadin);
                    newstart.Tag = "S";
                    addtomap(newstart, "S");
                    ans.Add(newstart);

                    if (leadin < 0)
                    {
                        var p2 = new utmpos(newstart) { Tag = "SM" };
                        addtomap(p2, "SM");
                        ans.Add(p2);
                    }
                    else
                    {
                        closest.p2.Tag = "SM";
                        addtomap(closest.p2, "SM");
                        ans.Add(closest.p2);
                    }

                    if (spacing > 0)
                    {
                        for (double d = ((closest.basepnt.GetDistance(closest.p2)) % spacing);
                            d < (closest.p1.GetDistance(closest.p2));
                            d += spacing)
                        {
                            double ax = closest.p2.x;
                            double ay = closest.p2.y;

                            newpos(ref ax, ref ay, angle, -d);
                            var utmpos2 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                            addtomap(utmpos2, "M");
                            ans.Add(utmpos2);
                        }
                    }

                    utmpos newend = newpos(closest.p1, angle, -overshoot2);

                    if (overshoot2 < 0)
                    {
                        var p2 = new utmpos(newend) { Tag = "ME" };
                        addtomap(p2, "ME");
                        ans.Add(p2);
                    }
                    else
                    {
                        closest.p1.Tag = "ME";
                        addtomap(closest.p1, "ME");
                        ans.Add(closest.p1);
                    }

                    newend.Tag = "E";
                    addtomap(newend, "E");
                    ans.Add(newend);

                    lastpnt = closest.p1;

                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;
                    closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                }
            }

            // set the altitude on all points
            ans.ForEach(plla => { plla.Alt = altitude; });

            return ans;
        }

        public static List<PointLatLngAlt> CreateGrid22(List<PointLatLngAlt> polygon, double altitude, double distance, double spacing, ref double angle,
            double overshoot1, double overshoot2, StartPosition startpos, bool shutter, float minLaneSeparation, float leadin, PointLatLngAlt HomeLocation, double offset, bool first, ref int dist_max_ref)
        {
            //DoDebug();

            if (spacing < 0.1 && spacing != 0)
                spacing = 0.1;

            if (distance < 0.1)
                distance = 0.1;

            if (polygon.Count == 0)
                return new List<PointLatLngAlt>();

            // Make a non round number in case of corner cases
            if (minLaneSeparation != 0)
                minLaneSeparation += 0.5F;
            // Lane Separation in meters
            double minLaneSeparationINMeters = minLaneSeparation * distance;

            List<PointLatLngAlt> ans = new List<PointLatLngAlt>();

            // utm zone distance calcs will be done in
            int utmzone = polygon[0].GetUTMZone();

            // utm position list
            List<utmpos> utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(utmzone, polygon), utmzone);

            // close the loop if its not already
            if (utmpositions[0] != utmpositions[utmpositions.Count - 1])
                utmpositions.Add(utmpositions[0]); // make a full loop

            // get mins/maxs of coverage area
            Rect area = getPolyMinMax(utmpositions);

            // get initial grid

            // used to determine the size of the outer grid area
            double diagdist = area.DiagDistance();

            // somewhere to store out generated lines
            List<linelatlng> grid = new List<linelatlng>();
            // number of lines we need
            int lines = 0;

            // get start point middle
            double x = area.MidWidth;
            double y = area.MidHeight;

            addtomap(new utmpos(x, y, utmzone), "Base");

#if true
            //グリッドライン方向へポリゴンを縮小する @eams
            utmpos gravity = new utmpos(x, y, utmzone);
            for (int i = 0; i < utmpositions.Count(); i++)
            {
                double xp = utmpositions[i].x;
                double yp = utmpositions[i].y;
                double deg = utmpositions[i].GetBearing(gravity);
                newpos(ref xp, ref yp, deg, offset);
                utmpositions[i] = new utmpos(xp, yp, utmzone);
            }
#endif
            //初回のみポリゴンの最長辺に角度を自動的に合わせる @eams
            if (first)
            {
                double dist_max = 0.0;
                int index = 0;
                for (int i = 1; i < utmpositions.Count(); i++)
                {
                    double dist = utmpositions[i].GetDistance(utmpositions[i - 1]);
                    if (dist > dist_max)
                    {
                        dist_max = dist;
                        index = i - 1;
                    }
                    angle = utmpositions[index].GetBearing(utmpositions[index + 1]);
                }
                dist_max_ref = (int)dist_max;   // for a2.0
            }

            // get left extent
            double xb1 = x;
            double yb1 = y;
            // to the left
            newpos(ref xb1, ref yb1, angle - 90, diagdist / 2 + distance);
            //            newpos(ref xb1, ref yb1, angle - 90, diagdist / 2);
            // backwards
            newpos(ref xb1, ref yb1, angle + 180, diagdist / 2 + distance);
            //            newpos(ref xb1, ref yb1, angle + 180, diagdist / 2);

            utmpos left = new utmpos(xb1, yb1, utmzone);

            addtomap(left, "left");

            // get right extent
            double xb2 = x;
            double yb2 = y;
            // to the right
            newpos(ref xb2, ref yb2, angle + 90, diagdist / 2 + distance);
            //            newpos(ref xb2, ref yb2, angle + 90, diagdist / 2);
            // backwards
            newpos(ref xb2, ref yb2, angle + 180, diagdist / 2 + distance);
            //            newpos(ref xb2, ref yb2, angle + 180, diagdist / 2);

            utmpos right = new utmpos(xb2, yb2, utmzone);

            addtomap(right, "right");

            // set start point to left hand side
            x = xb1;
            y = yb1;

            // draw the outergrid, this is a grid that cover the entire area of the rectangle plus more.
            while (lines < ((diagdist + distance * 2) / distance))
            //            while (lines < ((diagdist) / distance))
            {
                // copy the start point to generate the end point
                double nx = x;
                double ny = y;
                newpos(ref nx, ref ny, angle, diagdist + distance * 2);
                //                newpos(ref nx, ref ny, angle, diagdist);

                linelatlng line = new linelatlng();
                line.p1 = new utmpos(x, y, utmzone);
                line.p2 = new utmpos(nx, ny, utmzone);
                line.basepnt = new utmpos(x, y, utmzone);
                grid.Add(line);

                // addtomap(line);

                newpos(ref x, ref y, angle + 90, distance);
                lines++;
            }

            // find intersections with our polygon

            // store lines that dont have any intersections
            List<linelatlng> remove = new List<linelatlng>();

            int gridno = grid.Count;

            // cycle through our grid
            for (int a = 0; a < gridno; a++)
            {
                double closestdistance = double.MaxValue;
                double farestdistance = double.MinValue;

                utmpos closestpoint = utmpos.Zero;
                utmpos farestpoint = utmpos.Zero;

                // somewhere to store our intersections
                List<utmpos> matchs = new List<utmpos>();

                int b = -1;
                int crosses = 0;
                utmpos newutmpos = utmpos.Zero;
                foreach (utmpos pnt in utmpositions)
                {
                    b++;
                    if (b == 0)
                    {
                        continue;
                    }
                    newutmpos = FindLineIntersection(utmpositions[b - 1], utmpositions[b], grid[a].p1, grid[a].p2);
                    if (!newutmpos.IsZero)
                    {
                        crosses++;
                        matchs.Add(newutmpos);
                        if (closestdistance > grid[a].p1.GetDistance(newutmpos))
                        {
                            closestpoint.y = newutmpos.y;
                            closestpoint.x = newutmpos.x;
                            closestpoint.zone = newutmpos.zone;
                            closestdistance = grid[a].p1.GetDistance(newutmpos);
                        }
                        if (farestdistance < grid[a].p1.GetDistance(newutmpos))
                        {
                            farestpoint.y = newutmpos.y;
                            farestpoint.x = newutmpos.x;
                            farestpoint.zone = newutmpos.zone;
                            farestdistance = grid[a].p1.GetDistance(newutmpos);
                        }
                    }
                }
                if (crosses == 0) // outside our polygon
                {
                    if (!PointInPolygon(grid[a].p1, utmpositions) && !PointInPolygon(grid[a].p2, utmpositions))
                        remove.Add(grid[a]);
                }
                else if (crosses == 1) // bad - shouldnt happen
                {

                }
                else if (crosses == 2) // simple start and finish
                {
                    linelatlng line = grid[a];
                    line.p1 = closestpoint;
                    line.p2 = farestpoint;
                    grid[a] = line;
                }
                else // multiple intersections
                {
                    linelatlng line = grid[a];
                    remove.Add(line);

                    while (matchs.Count > 1)
                    {
                        linelatlng newline = new linelatlng();

                        closestpoint = findClosestPoint(closestpoint, matchs);
                        newline.p1 = closestpoint;
                        matchs.Remove(closestpoint);

                        closestpoint = findClosestPoint(closestpoint, matchs);
                        newline.p2 = closestpoint;
                        matchs.Remove(closestpoint);

                        newline.basepnt = line.basepnt;

                        grid.Add(newline);
                    }
                }
            }

            // cleanup and keep only lines that pass though our polygon
            foreach (linelatlng line in remove)
            {
                grid.Remove(line);
            }

            // debug
            foreach (linelatlng line in grid)
            {
                addtomap(line);
            }

            if (grid.Count == 0)
                return ans;

            // pick start positon based on initial point rectangle
            utmpos startposutm;

            switch (startpos)
            {
                default:
                case StartPosition.Home:
                    startposutm = new utmpos(HomeLocation);
                    break;
                case StartPosition.BottomLeft:
                    startposutm = new utmpos(area.Left, area.Bottom, utmzone);
                    break;
                case StartPosition.BottomRight:
                    startposutm = new utmpos(area.Right, area.Bottom, utmzone);
                    break;
                case StartPosition.TopLeft:
                    startposutm = new utmpos(area.Left, area.Top, utmzone);
                    break;
                case StartPosition.TopRight:
                    startposutm = new utmpos(area.Right, area.Top, utmzone);
                    break;
                case StartPosition.Point:
                    startposutm = new utmpos(StartPointLatLngAlt);
                    break;
            }

            // find the closes polygon point based from our startpos selection
            startposutm = findClosestPoint(startposutm, utmpositions);

            // find closest line point to startpos
            linelatlng closest = findClosestLine(startposutm, grid, 0 /*Lane separation does not apply to starting point*/, angle);

            //startposからclosestのどちらのポイントが近いかで角度を反転する。@eams add
            if (closest.p1.GetDistance(startposutm) > closest.p2.GetDistance(startposutm))
            {
                //p1のほうが遠かったら180度反転してp1とp2をすべて入れ替える。
                angle = AddAngle(angle, 180);

                linelatlng buf;
                for (int i = 0; i < grid.Count(); i++)
                {
                    buf = grid[i];
                    buf.p1 = grid[i].p2;
                    buf.p2 = grid[i].p1;
                    grid[i] = buf;
                }
                buf = closest;
                buf.p1 = closest.p2;
                buf.p2 = closest.p1;
                closest = buf;
            }

            utmpos lastpnt;

            // get the closes point from the line we picked
            if (closest.p1.GetDistance(startposutm) < closest.p2.GetDistance(startposutm))
            {
                lastpnt = closest.p1;
            }
            else
            {
                lastpnt = closest.p2;
            }

            // S =  start
            // E = end
            // ME = middle end
            // SM = start middle

            bool first_S = true;
            while (grid.Count > 0)
            {
                // for each line, check which end of the line is the next closest
                if (closest.p1.GetDistance(lastpnt) < closest.p2.GetDistance(lastpnt))
                {
                    //utmpos newstart = newpos(closest.p1, angle, -leadin);
                    utmpos newstart = newpos(closest.p1, angle, leadin);
                    if (first_S)
                    {
                        newstart = newpos(closest.p1, angle, 0);
                        first_S = false;
                    }
                    newstart.Tag = "S";
                    addtomap(newstart, "S");
                    ans.Add(newstart);

                    if (leadin >= 0)
                    {
                        var p2 = new utmpos(newstart) { Tag = "SM" };
                        addtomap(p2, "SM");
                        ans.Add(p2);
                    }
                    else
                    {
                        closest.p1.Tag = "SM";
                        addtomap(closest.p1, "SM");
                        ans.Add(closest.p1);
                    }

                    if (spacing > 0)
                    {
                        for (double d = (spacing - ((closest.basepnt.GetDistance(closest.p1)) % spacing));
                            d < (closest.p1.GetDistance(closest.p2));
                            d += spacing)
                        {
                            double ax = closest.p1.x;
                            double ay = closest.p1.y;

                            newpos(ref ax, ref ay, angle, d);
                            var utmpos1 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                            addtomap(utmpos1, "M");
                            ans.Add(utmpos1);
                        }
                    }

                    utmpos newend = newpos(closest.p2, angle, overshoot1);

                    if (overshoot1 < 0)
                    {
                        var p2 = new utmpos(newend) { Tag = "ME" };
                        addtomap(p2, "ME");
                        ans.Add(p2);
                    }
                    else
                    {
                        closest.p2.Tag = "ME";
                        addtomap(closest.p2, "ME");
                        ans.Add(closest.p2);
                    }

                    newend.Tag = "E";
                    addtomap(newend, "E");
                    ans.Add(newend);

                    lastpnt = closest.p2;

                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;

                    closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                }
                else
                {
                    //utmpos newstart = newpos(closest.p2, angle, leadin);
                    utmpos newstart = newpos(closest.p2, angle, -leadin);
                    if (first_S)
                    {
                        newstart = newpos(closest.p2, angle, 0);
                        first_S = false;
                    }
                    newstart.Tag = "S";
                    addtomap(newstart, "S");
                    ans.Add(newstart);

                    if (leadin >= 0)
                    {
                        var p2 = new utmpos(newstart) { Tag = "SM" };
                        addtomap(p2, "SM");
                        ans.Add(p2);
                    }
                    else
                    {
                        closest.p2.Tag = "SM";
                        addtomap(closest.p2, "SM");
                        ans.Add(closest.p2);
                    }

                    if (spacing > 0)
                    {
                        for (double d = ((closest.basepnt.GetDistance(closest.p2)) % spacing);
                            d < (closest.p1.GetDistance(closest.p2));
                            d += spacing)
                        {
                            double ax = closest.p2.x;
                            double ay = closest.p2.y;

                            newpos(ref ax, ref ay, angle, -d);
                            var utmpos2 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                            addtomap(utmpos2, "M");
                            ans.Add(utmpos2);
                        }
                    }

                    utmpos newend = newpos(closest.p1, angle, -overshoot2);

                    if (overshoot2 < 0)
                    {
                        var p2 = new utmpos(newend) { Tag = "ME" };
                        addtomap(p2, "ME");
                        ans.Add(p2);
                    }
                    else
                    {
                        closest.p1.Tag = "ME";
                        addtomap(closest.p1, "ME");
                        ans.Add(closest.p1);
                    }

                    newend.Tag = "E";
                    addtomap(newend, "E");
                    ans.Add(newend);

                    lastpnt = closest.p1;

                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;
                    closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                }
            }

            // set the altitude on all points
            ans.ForEach(plla => { plla.Alt = altitude; });

            return ans;
        }

        public static List<PointLatLngAlt> CreateGrid3(List<PointLatLngAlt> polygon, double altitude, double distance, double spacing, ref double angle,
            double overshoot1, double overshoot2, StartPosition startpos, bool shutter, float minLaneSeparation, float leadin, PointLatLngAlt HomeLocation, double offset, bool first)
        {
            //DoDebug();

            if (spacing < 0.1 && spacing != 0)
                spacing = 0.1;

            if (distance < 0.1)
                distance = 0.1;

            if (polygon.Count == 0)
                return new List<PointLatLngAlt>();


            // Make a non round number in case of corner cases
            if (minLaneSeparation != 0)
                minLaneSeparation += 0.5F;
            // Lane Separation in meters
            double minLaneSeparationINMeters = minLaneSeparation * distance;

            List<PointLatLngAlt> ans = new List<PointLatLngAlt>();

            // utm zone distance calcs will be done in
            int utmzone = polygon[0].GetUTMZone();

            // utm position list
            List<utmpos> utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(utmzone, polygon), utmzone);

            // close the loop if its not already
            if (utmpositions[0] != utmpositions[utmpositions.Count - 1])
                utmpositions.Add(utmpositions[0]); // make a full loop

            // get mins/maxs of coverage area
            Rect area = getPolyMinMax(utmpositions);

            // get initial grid

            // used to determine the size of the outer grid area
            double diagdist = area.DiagDistance();

            // somewhere to store out generated lines
            List<linelatlng> grid = new List<linelatlng>();
            // number of lines we need
            int lines = 0;

            // get start point middle
            double x = area.MidWidth;
            double y = area.MidHeight;
            utmpos pos_base = new utmpos(x, y, utmzone);

            addtomap(new utmpos(x, y, utmzone), "Base");
#if true
            //重心方向へポリゴンを縮小する @eams
            if (offset > 0)
            {
                utmpos gravity = new utmpos(x, y, utmzone);
                for (int i = 0; i < utmpositions.Count(); i++)
                {
                    double xp = utmpositions[i].x;
                    double yp = utmpositions[i].y;
                    double deg = utmpositions[i].GetBearing(gravity);
                    newpos(ref xp, ref yp, deg, offset);
                    utmpositions[i] = new utmpos(xp, yp, utmzone);
                }
            }

            //初回のみポリゴンの最長辺に角度を自動的に合わせる @eams
            if (first)
            {
                double dist_max = 0.0;
                int index = 0;
                for (int i = 1; i < utmpositions.Count(); i++)
                {
                    double dist = utmpositions[i].GetDistance(utmpositions[i - 1]);
                    if (dist > dist_max)
                    {
                        dist_max = dist;
                        index = i - 1;
                    }
                    angle = utmpositions[index].GetBearing(utmpositions[index + 1]);
                }
            }
#endif
            //オフセットした後のポリゴンの面積を求める。
            var polygonarea = calcpolygonarea(utmpositions);
            //面積を五捨六入し、理想のポイント数を求める。
            int ideal_point_num = (int)Math.Floor(polygonarea / 1000 + 0.4);
            if (ideal_point_num <= 0)
            {
                ideal_point_num = 1;
            }

            // calc the number of lines
            lines = CalcLineNumber(pos_base, utmpositions, angle - 90, distance / 2);
            if (lines == 0)
            {
                lines = 1;
            }

            // calc new base point
            utmpos pos_base2 = newpos(pos_base, angle - 90, distance * ((lines - 1) / 2.0));

            // calc all center pos
            List<utmpos> pos_bases = new List<utmpos>();
            for (int i = 0; i < lines; i++)
            {
                utmpos pos = newpos(pos_base2, angle + 90, distance * i);
                pos_bases.Add(pos);
            }

            // calc points per line
            foreach (var item in pos_bases)
            {
                // set temporary both edges position in line
                utmpos edge_b = newpos(item, angle + 180, diagdist / 2 + distance);
                utmpos edge_t = newpos(edge_b, angle, diagdist + distance * 2);
                linelatlng line = new linelatlng();
                line.p1 = edge_b;
                line.p2 = edge_t;
                line.basepnt = edge_b;

                // find intersections with our polygon
                double closestdistance = double.MaxValue;
                double farestdistance = double.MinValue;

                utmpos closestpoint = utmpos.Zero;
                utmpos farestpoint = utmpos.Zero;

                // somewhere to store our intersections
                List<utmpos> matchs = new List<utmpos>();

                // find grid lines
                int b = -1;
                int crosses = 0;
                utmpos newutmpos = utmpos.Zero;
                foreach (utmpos pnt in utmpositions)
                {
                    b++;
                    if (b == 0)
                    {
                        continue;
                    }
                    newutmpos = FindLineIntersection(utmpositions[b - 1], utmpositions[b], line.p1, line.p2);
                    if (!newutmpos.IsZero)
                    {
                        crosses++;
                        matchs.Add(newutmpos);
                        if (closestdistance > line.p1.GetDistance(newutmpos))
                        {
                            closestpoint.y = newutmpos.y;
                            closestpoint.x = newutmpos.x;
                            closestpoint.zone = newutmpos.zone;
                            closestdistance = line.p1.GetDistance(newutmpos);
                        }
                        if (farestdistance < line.p1.GetDistance(newutmpos))
                        {
                            farestpoint.y = newutmpos.y;
                            farestpoint.x = newutmpos.x;
                            farestpoint.zone = newutmpos.zone;
                            farestdistance = line.p1.GetDistance(newutmpos);
                        }
                    }
                }
                if (crosses == 2) // simple start and finish
                {
                    line.p1 = closestpoint;
                    line.p2 = farestpoint;
                }
                else
                {
                    return ans;
                }
                grid.Add(line);
#if false
                // calc fixed center pos
                var dist = line.p1.GetDistance(line.p2);
                var pos_fix_center = newpos(line.p1, angle + 180, dist / 2);    // fixed center in this line
                int points = CalcLineNumber(pos_fix_center, utmpositions, angle, distance/2);
#endif
            }

            if (grid.Count == 0)
                return ans;

            // pick start positon based on initial point rectangle
            utmpos startposutm;

            switch (startpos)
            {
                default:
                case StartPosition.Home:
                    startposutm = new utmpos(HomeLocation);
                    break;
                case StartPosition.BottomLeft:
                    startposutm = new utmpos(area.Left, area.Bottom, utmzone);
                    break;
                case StartPosition.BottomRight:
                    startposutm = new utmpos(area.Right, area.Bottom, utmzone);
                    break;
                case StartPosition.TopLeft:
                    startposutm = new utmpos(area.Left, area.Top, utmzone);
                    break;
                case StartPosition.TopRight:
                    startposutm = new utmpos(area.Right, area.Top, utmzone);
                    break;
                case StartPosition.Point:
                    startposutm = new utmpos(StartPointLatLngAlt);
                    break;
            }

            // find the closes polygon point based from our startpos selection
            startposutm = findClosestPoint(startposutm, utmpositions);

            // find closest line point to startpos
            linelatlng closest = findClosestLine(startposutm, grid, 0 /*Lane separation does not apply to starting point*/, angle);

            //startposからclosestのどちらのポイントが近いかで角度を反転する。@eams add
            if (closest.p1.GetDistance(startposutm) > closest.p2.GetDistance(startposutm))
            {
                //p1のほうが遠かったら180度反転してp1とp2をすべて入れ替える。
                angle = AddAngle(angle, 180);

                linelatlng buf;
                for (int i = 0; i < grid.Count(); i++)
                {
                    buf = grid[i];
                    buf.p1 = grid[i].p2;
                    buf.p2 = grid[i].p1;
                    grid[i] = buf;
                }
                buf = closest;
                buf.p1 = closest.p2;
                buf.p2 = closest.p1;
                closest = buf;
            }

            utmpos lastpnt;

            // get the closes point from the line we picked
            if (closest.p1.GetDistance(startposutm) < closest.p2.GetDistance(startposutm))
            {
                lastpnt = closest.p1;
            }
            else
            {
                lastpnt = closest.p2;
            }

            // S =  start
            // E = end
            // ME = middle end
            // SM = start middle

            while (grid.Count > 0)
            {
                if (closest.p1.GetDistance(closest.p2) <= distance)
                {
                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;

                    closest = findClosestLine(startposutm, grid, minLaneSeparationINMeters, angle);
                    continue;
                }
                // calc offset per grid
                double grid_len = closest.p1.GetDistance(closest.p2);
                double inner = ((grid_len % distance) + distance) / 2;
                spacing = distance;

                // for each line, check which end of the line is the next closest
                if (closest.p1.GetDistance(lastpnt) < closest.p2.GetDistance(lastpnt))
                {
                    utmpos newstart = newpos(closest.p1, angle, inner);
                    utmpos newend = newpos(closest.p2, angle, -inner);
                    double dist = Math.Round(newstart.GetDistance(newend), MidpointRounding.AwayFromZero);

                    newstart.Tag = "S";
                    addtomap(newstart, "S");
                    ans.Add(newstart);

                    newstart.Tag = "SM";
                    addtomap(newstart, "SM");
                    ans.Add(newstart);

                    if (spacing > 0)
                    {
                        //                        for (double d = (spacing - ((newstart.GetDistance(newend)) % spacing));
                        for (double d = spacing;
                            d < dist;
                            d += spacing)
                        {
                            double ax = newstart.x;
                            double ay = newstart.y;

                            newpos(ref ax, ref ay, angle, d);
                            var utmpos1 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                            addtomap(utmpos1, "M");
                            ans.Add(utmpos1);
                        }
                    }

                    newend.Tag = "ME";
                    addtomap(newend, "ME");
                    ans.Add(newend);

                    newend.Tag = "E";
                    addtomap(newend, "E");
                    ans.Add(newend);

                    lastpnt = closest.p2;

                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;

                    closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                }
                else
                {
                    utmpos newstart = newpos(closest.p2, angle, -inner);
                    utmpos newend = newpos(closest.p1, angle, inner);
                    double dist = Math.Round(newstart.GetDistance(newend), MidpointRounding.AwayFromZero);

                    newstart.Tag = "S";
                    addtomap(newstart, "S");
                    ans.Add(newstart);

                    newstart.Tag = "SM";
                    addtomap(newstart, "SM");
                    ans.Add(newstart);

                    if (spacing > 0)
                    {
                        //                        for (double d = (spacing - ((newstart.GetDistance(newend)) % spacing));
                        for (double d = spacing;
                            d < dist;
                            d += spacing)
                        {
                            double ax = newstart.x;
                            double ay = newstart.y;

                            newpos(ref ax, ref ay, angle, -d);
                            var utmpos1 = new utmpos(ax, ay, utmzone) { Tag = "M" };
                            addtomap(utmpos1, "M");
                            ans.Add(utmpos1);
                        }
                    }

                    newend.Tag = "ME";
                    addtomap(newend, "ME");
                    ans.Add(newend);

                    newend.Tag = "E";
                    addtomap(newend, "E");
                    ans.Add(newend);

                    lastpnt = closest.p1;

                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;
                    closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                }
            }

            // set the altitude on all points
            ans.ForEach(plla => { plla.Alt = altitude; });

            return ans;
        }

        public static List<PointLatLngAlt> CreateGrid4(List<PointLatLngAlt> polygon, double altitude, double distance, double spacing, ref double angle,
            double overshoot1, double overshoot2, StartPosition startpos, bool shutter, float minLaneSeparation, float leadin, PointLatLngAlt HomeLocation, double offset, bool first, double area_unit)
        {
            //DoDebug();

            if (spacing < 0.1 && spacing != 0)
                spacing = 0.1;

            if (distance < 0.1)
                distance = 0.1;

            if (polygon.Count == 0)
                return new List<PointLatLngAlt>();


            // Make a non round number in case of corner cases
            if (minLaneSeparation != 0)
                minLaneSeparation += 0.5F;
            // Lane Separation in meters
            double minLaneSeparationINMeters = minLaneSeparation * distance;

            List<PointLatLngAlt> ans = new List<PointLatLngAlt>();

            // utm zone distance calcs will be done in
            int utmzone = polygon[0].GetUTMZone();

            // utm position list
            List<utmpos> utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(utmzone, polygon), utmzone);

            // close the loop if its not already
            if (utmpositions[0] != utmpositions[utmpositions.Count - 1])
                utmpositions.Add(utmpositions[0]); // make a full loop

            // get mins/maxs of coverage area
            Rect area = getPolyMinMax(utmpositions);

            // get initial grid

            // used to determine the size of the outer grid area
            double diagdist = area.DiagDistance();

            // somewhere to store out generated lines
            List<linelatlng> grid = new List<linelatlng>();
            // number of lines we need
            int lines = 0;

            // get start point middle
            double x = area.MidWidth;
            double y = area.MidHeight;
            utmpos pos_base = new utmpos(x, y, utmzone);

            addtomap(new utmpos(x, y, utmzone), "Base");

            //重心方向へポリゴンを縮小する @eams
            if (offset > 0)
            {
                utmpos gravity = new utmpos(x, y, utmzone);
                for (int i = 0; i < utmpositions.Count(); i++)
                {
                    double xp = utmpositions[i].x;
                    double yp = utmpositions[i].y;
                    double deg = utmpositions[i].GetBearing(gravity);
                    newpos(ref xp, ref yp, deg, offset);
                    utmpositions[i] = new utmpos(xp, yp, utmzone);
                }
            }

            //初回のみポリゴンの最長辺に角度を自動的に合わせる @eams
            linelatlng longest_line = new linelatlng();
            double dist_max = 0.0;
            int index = 0;
            for (int i = 1; i < utmpositions.Count(); i++)
            {
                double dist = utmpositions[i].GetDistance(utmpositions[i - 1]);
                if (dist > dist_max)
                {
                    dist_max = dist;
                    index = i - 1;
                }
            }

            longest_line.p1 = new utmpos(utmpositions[index].x, utmpositions[index].y, utmzone);
            longest_line.p2 = new utmpos(utmpositions[index + 1].x, utmpositions[index + 1].y, utmzone);
            longest_line.basepnt = new utmpos(utmpositions[index].x, utmpositions[index].y, utmzone);

            if (first)
            {
                angle = utmpositions[index].GetBearing(utmpositions[index + 1]);
            }

            //オフセットした後のポリゴンの面積を求める。
            var polygonarea = calcpolygonarea(utmpositions);
            //config指定面積から理想のポイント数を求める。
//            int ideal_point_num = (int)Math.Floor(polygonarea / 1000 + 0.4);  //旧：10a固定で五捨六入
            int ideal_point_num = (int)Math.Floor((polygonarea / (area_unit*100.0)) + 0.5);
            if (ideal_point_num <= 0)
            {
                ideal_point_num = 1;
            }

            // 短辺にラインが何本収まるかを算出
            lines = CalcLineNumber(pos_base, utmpositions, angle - 90, distance / 2);
            if (lines == 0)
            {
                lines = 1;
            }

            //長辺にサークルがいくつ収まるかを算出
            //理想ポイント数をライン数で割り切れない場合は不足分を加算しておく
            //この不足分は最終的なポイント設定時に減算する
            int ideal_point_num_per_line;
            var added_point_num = 0;
            if (ideal_point_num % lines != 0)
            {
                added_point_num = lines - (ideal_point_num % lines);
            }
            ideal_point_num_per_line = (ideal_point_num + added_point_num) / lines;

            // calc new base point
            utmpos pos_base2 = newpos(pos_base, angle - 90, distance * ((lines - 1) / 2.0));

            // calc all center pos
            List<utmpos> pos_bases = new List<utmpos>();
            for (int i = 0; i < lines; i++)
            {
                utmpos pos = newpos(pos_base2, angle + 90, distance * i);
                pos_bases.Add(pos);
            }

            // calc points per line
            foreach (var item in pos_bases)
            {
                // set temporary both edges position in line
                utmpos edge_b = newpos(item, angle + 180, diagdist / 2 + distance);
                utmpos edge_t = newpos(edge_b, angle, diagdist + distance * 2);
                linelatlng line = new linelatlng();
                line.p1 = edge_b;
                line.p2 = edge_t;
                line.basepnt = edge_b;

                // find intersections with our polygon
                double closestdistance = double.MaxValue;
                double farestdistance = double.MinValue;

                utmpos closestpoint = utmpos.Zero;
                utmpos farestpoint = utmpos.Zero;

                // somewhere to store our intersections
                List<utmpos> matchs = new List<utmpos>();

                // find grid lines
                int b = -1;
                int crosses = 0;
                utmpos newutmpos = utmpos.Zero;
                foreach (utmpos pnt in utmpositions)
                {
                    b++;
                    if (b == 0)
                    {
                        continue;
                    }
                    newutmpos = FindLineIntersection(utmpositions[b - 1], utmpositions[b], line.p1, line.p2);
                    if (!newutmpos.IsZero)
                    {
                        crosses++;
                        matchs.Add(newutmpos);
                        if (closestdistance > line.p1.GetDistance(newutmpos))
                        {
                            closestpoint.y = newutmpos.y;
                            closestpoint.x = newutmpos.x;
                            closestpoint.zone = newutmpos.zone;
                            closestdistance = line.p1.GetDistance(newutmpos);
                        }
                        if (farestdistance < line.p1.GetDistance(newutmpos))
                        {
                            farestpoint.y = newutmpos.y;
                            farestpoint.x = newutmpos.x;
                            farestpoint.zone = newutmpos.zone;
                            farestdistance = line.p1.GetDistance(newutmpos);
                        }
                    }
                }
                if (crosses == 2) // simple start and finish
                {
                    line.p1 = closestpoint;
                    line.p2 = farestpoint;
                }
                else
                {
                    return ans;
                }
                grid.Add(line);
#if false
                // calc fixed center pos
                var dist = line.p1.GetDistance(line.p2);
                var pos_fix_center = newpos(line.p1, angle + 180, dist / 2);    // fixed center in this line
                int points = CalcLineNumber(pos_fix_center, utmpositions, angle, distance/2);
#endif
            }

            if (grid.Count == 0)
            {
#if false
                //極小エリアでグリッドラインが一本も引けなかった場合は重心にポイント追加してリターン。
                pos_base.Tag = "M";
                addtomap(pos_base, "M");
                ans.Add(pos_base);
#endif
                return ans;
            }

            // pick start positon based on initial point rectangle
            utmpos startposutm;

            switch (startpos)
            {
                default:
                case StartPosition.Home:
                    startposutm = new utmpos(HomeLocation);
                    break;
                case StartPosition.BottomLeft:
                    startposutm = new utmpos(area.Left, area.Bottom, utmzone);
                    break;
                case StartPosition.BottomRight:
                    startposutm = new utmpos(area.Right, area.Bottom, utmzone);
                    break;
                case StartPosition.TopLeft:
                    startposutm = new utmpos(area.Left, area.Top, utmzone);
                    break;
                case StartPosition.TopRight:
                    startposutm = new utmpos(area.Right, area.Top, utmzone);
                    break;
                case StartPosition.Point:
                    startposutm = new utmpos(StartPointLatLngAlt);
                    break;
            }

            // find the closes polygon point based from our startpos selection
            startposutm = findClosestPoint(startposutm, utmpositions);
#if false
            //startposからポリゴン最長辺のどちらのポイントが近いかで角度を反転する。
            if (longest_line.p1.GetDistance(startposutm) > longest_line.p2.GetDistance(startposutm))
            {
                //p1のほうが遠かったら180度反転
                angle = AddAngle(angle, 180);
            }
#endif
            // find closest line point to startpos
            linelatlng closest = findClosestLine(startposutm, grid, 0 /*Lane separation does not apply to starting point*/, angle);

            //startposからclosestのどちらのポイントが近いかで角度を反転する。@eams add
            if (closest.p1.GetDistance(startposutm) > closest.p2.GetDistance(startposutm))
            {
                //p1のほうが遠かったら180度反転してp1とp2をすべて入れ替える。
                angle = AddAngle(angle, 180);

                linelatlng buf;
                for (int i = 0; i < grid.Count(); i++)
                {
                    buf = grid[i];
                    buf.p1 = grid[i].p2;
                    buf.p2 = grid[i].p1;
                    grid[i] = buf;
                }
                buf = closest;
                buf.p1 = closest.p2;
                buf.p2 = closest.p1;
                closest = buf;
            }

            utmpos lastpnt;

            // get the closes point from the line we picked
            if (closest.p1.GetDistance(startposutm) < closest.p2.GetDistance(startposutm))
            {
                lastpnt = closest.p1;
            }
            else
            {
                lastpnt = closest.p2;
            }

            // S =  start
            // E = end
            // ME = middle end
            // SM = start middle

            while (grid.Count > 0)
            {
                double grid_len = closest.p1.GetDistance(closest.p2);
#if false
                if (grid_len <= distance)
                {
                    //ライン毎のポイント数がある場合は、中間点にポイントを打つ
                    if (ideal_point_num_per_line > 0)
                    {
                        utmpos point = newpos(closest.p1, angle, grid_len / 2);
                        point.Tag = "S";
                        addtomap(point, "S");
                        ans.Add(point);

                        point.Tag = "SM";
                        addtomap(point, "SM");
                        ans.Add(point);
                    }
                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;

                    closest = findClosestLine(startposutm, grid, minLaneSeparationINMeters, angle);
                    continue;
                }
#endif
                int point_num_per_line = ideal_point_num_per_line;
                bool even_placement = false;

                //ポイント間引き処理
                if (added_point_num > 0)
                {
                    if (isshortgrid(closest, grid, added_point_num))
                    {
                        point_num_per_line -= 1;
                        added_point_num -= 1;
                        even_placement = true;
                    }
                }

                //グリッドごとの実質ポイント数が1の場合、グリッドの中間点にポイントを打つ
                if (point_num_per_line == 1)
                {
                    utmpos point = newpos(closest.p1, angle, grid_len / 2);
                    point.Tag = "S";
                    addtomap(point, "S");
                    ans.Add(point);

                    point.Tag = "SM";
                    addtomap(point, "SM");
                    ans.Add(point);

                    grid.Remove(closest);
                    if (grid.Count == 0)
                        break;

                    closest = findClosestLine(startposutm, grid, minLaneSeparationINMeters, angle);
                }
                else
                {
                    double inner = 0.0;
                    // calc offset per grid
                    if (even_placement)
                    {
#if true
                        //ポイント間引きがあった場合、グリッドラインに均等配置する
                        inner = grid_len / (point_num_per_line + 1);
                        spacing = inner;
#else
                        inner = distance / 2;
                        spacing = (grid_len - distance) / (point_num_per_line - 2);
#endif
                    }
                    else
                    {
                        inner = distance / 2;
                        spacing = (grid_len - distance) / (point_num_per_line - 1);
                    }

                    // for each line, check which end of the line is the next closest
                    if (closest.p1.GetDistance(lastpnt) < closest.p2.GetDistance(lastpnt))
                    {
                        utmpos newstart = newpos(closest.p1, angle, inner);
                        utmpos newend = newpos(closest.p2, angle, -inner);
                        //                    double dist = Math.Round(newstart.GetDistance(newend), MidpointRounding.AwayFromZero);
                        double dist = newstart.GetDistance(newend);

                        newstart.Tag = "S";
                        addtomap(newstart, "S");
                        ans.Add(newstart);

                        newstart.Tag = "SM";
                        addtomap(newstart, "SM");
                        ans.Add(newstart);

                        if (spacing > 0)
                        {
#if false
                            for (double d = spacing;
                                d < dist;
                                d += spacing)
#endif
                            for (int d = 1; d <= point_num_per_line - 2; d++)
                            {
                                double ax = newstart.x;
                                double ay = newstart.y;

//                                newpos(ref ax, ref ay, angle, d);
                                newpos(ref ax, ref ay, angle, d * spacing);
                                var utmpos1 = new utmpos(ax, ay, utmzone) { Tag = "SM" };
                                if (utmpos1 == newend)
                                {
                                    break;
                                }
                                addtomap(utmpos1, "SM");
                                ans.Add(utmpos1);
                            }
                        }

                        newend.Tag = "ME";
                        addtomap(newend, "ME");
                        ans.Add(newend);

                        newend.Tag = "E";
                        addtomap(newend, "E");
                        ans.Add(newend);

                        lastpnt = closest.p2;

                        grid.Remove(closest);
                        if (grid.Count == 0)
                            break;

                        closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                    }
                    else
                    {
                        utmpos newstart = newpos(closest.p2, angle, -inner);
                        utmpos newend = newpos(closest.p1, angle, inner);
                        //                    double dist = Math.Round(newstart.GetDistance(newend), MidpointRounding.AwayFromZero);
                        double dist = newstart.GetDistance(newend);

                        newstart.Tag = "S";
                        addtomap(newstart, "S");
                        ans.Add(newstart);

                        newstart.Tag = "SM";
                        addtomap(newstart, "SM");
                        ans.Add(newstart);

                        if (spacing > 0)
                        {
#if false
                            for (double d = spacing;
                                d < dist;
                                d += spacing)
                            {
#endif
                            for (int d = 1; d <= point_num_per_line - 2; d++)
                            {
                                double ax = newstart.x;
                                double ay = newstart.y;

                                newpos(ref ax, ref ay, angle, -d * spacing);
                                var utmpos1 = new utmpos(ax, ay, utmzone) { Tag = "SM" };
                                if (utmpos1 == newend)
                                {
                                    break;
                                }
                                addtomap(utmpos1, "SM");
                                ans.Add(utmpos1);
                            }
                        }

                        newend.Tag = "ME";
                        addtomap(newend, "ME");
                        ans.Add(newend);

                        newend.Tag = "E";
                        addtomap(newend, "E");
                        ans.Add(newend);

                        lastpnt = closest.p1;

                        grid.Remove(closest);
                        if (grid.Count == 0)
                            break;
                        closest = findClosestLine(newend, grid, minLaneSeparationINMeters, angle);
                    }
                }
            }

            // set the altitude on all points
            ans.ForEach(plla => { plla.Alt = altitude; });

            return ans;
        }

        static Rect getPolyMinMax(List<utmpos> utmpos)
        {
            if (utmpos.Count == 0)
                return new Rect();

            double minx, miny, maxx, maxy;

            minx = maxx = utmpos[0].x;
            miny = maxy = utmpos[0].y;

            foreach (utmpos pnt in utmpos)
            {
                minx = Math.Min(minx, pnt.x);
                maxx = Math.Max(maxx, pnt.x);

                miny = Math.Min(miny, pnt.y);
                maxy = Math.Max(maxy, pnt.y);
            }

            return new Rect(minx, maxy, maxx - minx, miny - maxy);
        }

        // polar to rectangular
        static void newpos(ref double x, ref double y, double bearing, double distance)
        {
            double degN = 90 - bearing;
            if (degN < 0)
                degN += 360;
            x = x + distance * Math.Cos(degN * deg2rad);
            y = y + distance * Math.Sin(degN * deg2rad);
        }

        // polar to rectangular
        static utmpos newpos(utmpos input, double bearing, double distance)
        {
            double degN = 90 - bearing;
            if (degN < 0)
                degN += 360;
            double x = input.x + distance * Math.Cos(degN * deg2rad);
            double y = input.y + distance * Math.Sin(degN * deg2rad);

            return new utmpos(x, y, input.zone);
        }

        /// <summary>
        /// from http://stackoverflow.com/questions/1119451/how-to-tell-if-a-line-intersects-a-polygon-in-c
        /// </summary>
        /// <param name="start1"></param>
        /// <param name="end1"></param>
        /// <param name="start2"></param>
        /// <param name="end2"></param>
        /// <returns></returns>
        public static utmpos FindLineIntersection(utmpos start1, utmpos end1, utmpos start2, utmpos end2)
        {
            double denom = ((end1.x - start1.x) * (end2.y - start2.y)) - ((end1.y - start1.y) * (end2.x - start2.x));
            //  AB & CD are parallel         
            if (denom == 0)
                return utmpos.Zero;
            double numer = ((start1.y - start2.y) * (end2.x - start2.x)) - ((start1.x - start2.x) * (end2.y - start2.y));
            double r = numer / denom;
            double numer2 = ((start1.y - start2.y) * (end1.x - start1.x)) - ((start1.x - start2.x) * (end1.y - start1.y));
            double s = numer2 / denom;
            if ((r < 0 || r > 1) || (s < 0 || s > 1))
                return utmpos.Zero;
            // Find intersection point      
            utmpos result = new utmpos();
            result.x = start1.x + (r * (end1.x - start1.x));
            result.y = start1.y + (r * (end1.y - start1.y));
            result.zone = start1.zone;
            return result;
        }

        /// <summary>
        /// from http://stackoverflow.com/questions/1119451/how-to-tell-if-a-line-intersects-a-polygon-in-c
        /// </summary>
        /// <param name="start1"></param>
        /// <param name="end1"></param>
        /// <param name="start2"></param>
        /// <param name="end2"></param>
        /// <returns></returns>
        public static utmpos FindLineIntersectionExtension(utmpos start1, utmpos end1, utmpos start2, utmpos end2)
        {
            double denom = ((end1.x - start1.x) * (end2.y - start2.y)) - ((end1.y - start1.y) * (end2.x - start2.x));
            //  AB & CD are parallel         
            if (denom == 0)
                return utmpos.Zero;
            double numer = ((start1.y - start2.y) * (end2.x - start2.x)) -
                           ((start1.x - start2.x) * (end2.y - start2.y));
            double r = numer / denom;
            double numer2 = ((start1.y - start2.y) * (end1.x - start1.x)) -
                            ((start1.x - start2.x) * (end1.y - start1.y));
            double s = numer2 / denom;
            if ((r < 0 || r > 1) || (s < 0 || s > 1))
            {
                // line intersection is outside our lines.
            }
            // Find intersection point      
            utmpos result = new utmpos();
            result.x = start1.x + (r * (end1.x - start1.x));
            result.y = start1.y + (r * (end1.y - start1.y));
            result.zone = start1.zone;
            return result;
        }

        static utmpos findClosestPoint(utmpos start, List<utmpos> list)
        {
            utmpos answer = utmpos.Zero;
            double currentbest = double.MaxValue;

            foreach (utmpos pnt in list)
            {
                double dist1 = start.GetDistance(pnt);

                if (dist1 < currentbest)
                {
                    answer = pnt;
                    currentbest = dist1;
                }
            }

            return answer;
        }

        // Add an angle while normalizing output in the range 0...360
        static double AddAngle(double angle, double degrees)
        {
            angle += degrees;

            angle = angle % 360;

            while (angle < 0)
            {
                angle += 360;
            }
            return angle;
        }

        static linelatlng findClosestLine(utmpos start, List<linelatlng> list, double minDistance, double angle)
        {
            if (minDistance == 0)
            {
                linelatlng answer = list[0];
                double shortest = double.MaxValue;

                foreach (linelatlng line in list)
                {
                    double ans1 = start.GetDistance(line.p1);
                    double ans2 = start.GetDistance(line.p2);
                    utmpos shorterpnt = ans1 < ans2 ? line.p1 : line.p2;

                    if (shortest > start.GetDistance(shorterpnt))
                    {
                        answer = line;
                        shortest = start.GetDistance(shorterpnt);
                    }
                }

                return answer;
            }


            // By now, just add 5.000 km to our lines so they are long enough to allow intersection
            double METERS_TO_EXTEND = 5000;

            double perperndicularOrientation = AddAngle(angle, 90);

            // Calculation of a perpendicular line to the grid lines containing the "start" point
            /*
             *  --------------------------------------|------------------------------------------
             *  --------------------------------------|------------------------------------------
             *  -------------------------------------start---------------------------------------
             *  --------------------------------------|------------------------------------------
             *  --------------------------------------|------------------------------------------
             *  --------------------------------------|------------------------------------------
             *  --------------------------------------|------------------------------------------
             *  --------------------------------------|------------------------------------------
             */
            utmpos start_perpendicular_line = newpos(start, perperndicularOrientation, -METERS_TO_EXTEND);
            utmpos stop_perpendicular_line = newpos(start, perperndicularOrientation, METERS_TO_EXTEND);

            // Store one intersection point per grid line
            Dictionary<utmpos, linelatlng> intersectedPoints = new Dictionary<utmpos, linelatlng>();
            // lets order distances from every intersected point per line with the "start" point
            Dictionary<double, utmpos> ordered_min_to_max = new Dictionary<double, utmpos>();

            foreach (linelatlng line in list)
            {
                // Calculate intersection point
                utmpos p = FindLineIntersectionExtension(line.p1, line.p2, start_perpendicular_line, stop_perpendicular_line);

                // Store it
                intersectedPoints[p] = line;

                // Calculate distances between interesected point and "start" (i.e. line and start)
                double distance_p = start.GetDistance(p);

                if (!ordered_min_to_max.ContainsKey(distance_p))
                    ordered_min_to_max.Add(distance_p, p);
            }

            // Acquire keys and sort them.
            List<double> ordered_keys = ordered_min_to_max.Keys.ToList();
            ordered_keys.Sort();

            // Lets select a line that is the closest to "start" point but "mindistance" away at least.
            // If we have only one line, return that line whatever the minDistance says
            double key = double.MaxValue;
            int i = 0;
            while (key == double.MaxValue && i < ordered_keys.Count)
            {
                if (ordered_keys[i] >= minDistance)
                    key = ordered_keys[i];
                i++;
            }

            // If no line is selected (because all of them are closer than minDistance, then get the farest one
            if (key == double.MaxValue)
                key = ordered_keys[ordered_keys.Count - 1];

            var filteredlist = intersectedPoints.Where(a => a.Key.GetDistance(start) >= key);

            return findClosestLine(start, filteredlist.Select(a => a.Value).ToList(), 0, angle);
        }

        static bool PointInPolygon(utmpos p, List<utmpos> poly)
        {
            utmpos p1, p2;
            bool inside = false;

            if (poly.Count < 3)
            {
                return inside;
            }
            utmpos oldPoint = new utmpos(poly[poly.Count - 1]);

            for (int i = 0; i < poly.Count; i++)
            {

                utmpos newPoint = new utmpos(poly[i]);

                if (newPoint.y > oldPoint.y)
                {
                    p1 = oldPoint;
                    p2 = newPoint;
                }
                else
                {
                    p1 = newPoint;
                    p2 = oldPoint;
                }

                if ((newPoint.y < p.y) == (p.y <= oldPoint.y)
                    && ((double)p.x - (double)p1.x) * (double)(p2.y - p1.y)
                    < ((double)p2.x - (double)p1.x) * (double)(p.y - p1.y))
                {
                    inside = !inside;
                }
                oldPoint = newPoint;
            }
            return inside;
        }

        static int CalcLineNumber(utmpos p, List<utmpos> poly, double angle, double distance)
        {
            int count = 0;
            while (true)
            {
                utmpos left = newpos(p, angle, distance * (count + 1));
                utmpos right = newpos(p, angle + 180, distance * (count + 1));
                if (!PointInPolygon(left, poly) && !PointInPolygon(right, poly))
                {
                    break;
                }
                count++;
            }
            return count;
        }

        // @eams add / calcpoly utm version port from GridUI.cs
        static double calcpolygonarea(List<utmpos> polygon)
        {
            // should be a closed polygon
            // coords are in utm

            if (polygon.Count == 0)
            {
                return 0;
            }
#if false
            // close the polygon
            if (polygon[0] != polygon[polygon.Count - 1])
                polygon.Add(polygon[0]); // make a full loop

            CoordinateTransformationFactory ctfac = new CoordinateTransformationFactory();

            IGeographicCoordinateSystem wgs84 = GeographicCoordinateSystem.WGS84;

            int utmzone = (int)((polygon[0].Lng - -186.0) / 6.0);

            IProjectedCoordinateSystem utm = ProjectedCoordinateSystem.WGS84_UTM(utmzone, polygon[0].Lat < 0 ? false : true);

            ICoordinateTransformation trans = ctfac.CreateFromCoordinateSystems(wgs84, utm);
#endif
            double prod1 = 0;
            double prod2 = 0;

            for (int a = 0; a < (polygon.Count - 1); a++)
            {
#if false
                double[] pll1 = { polygon[a].Lng, polygon[a].Lat };
                double[] pll2 = { polygon[a + 1].Lng, polygon[a + 1].Lat };

                double[] p1 = trans.MathTransform.Transform(pll1);
                double[] p2 = trans.MathTransform.Transform(pll2);

                prod1 += p1[0] * p2[1];
                prod2 += p1[1] * p2[0];
#endif
                prod1 += polygon[a].x * polygon[a + 1].y;
                prod2 += polygon[a].y * polygon[a + 1].x;
            }

            double answer = (prod1 - prod2) / 2;
#if false
            if (polygon[0] == polygon[polygon.Count - 1])
                polygon.RemoveAt(polygon.Count - 1); // unmake a full loop
#endif
            return Math.Abs(answer);
        }

        // @eams add
        static bool isshortgrid(linelatlng target, List<linelatlng> list, int check_count)
        {
            List<linelatlng> buf = new List<linelatlng>(list);

            //listから長いgridを一つずつ削除していき、残りがcheck_countになるまで繰り返す
            while (buf.Count() > check_count)
            {
                linelatlng answer = buf[0];
                double longest = 0.0;
                foreach (linelatlng line in buf)
                {
                    double len = line.p1.GetDistance(line.p2);

                    if (longest < len)
                    {
                        answer = line;
                        longest = len;
                    }
                }
                buf.Remove(answer);
            }
            return buf.Contains(target);
        }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class EnumDisplayNameAttribute : Attribute
    {
        /// <summary>表示名</summary>
        public string Name { get; set; }

        /// <summary>enum表示名属性</summary>
        /// <param name="name">表示名</param>
        public EnumDisplayNameAttribute(string name)
        {
            Name = name;
        }
    }

    public static class EnumExtension
    {
        public static string GetEnumDisplayName<T>(this T enumValue)
        {
            var field = typeof(T).GetField(enumValue.ToString());
            var attrType = typeof(EnumDisplayNameAttribute);
            var attribute = Attribute.GetCustomAttribute(field, attrType);
            return (attribute as EnumDisplayNameAttribute)?.Name;
        }
    }
}