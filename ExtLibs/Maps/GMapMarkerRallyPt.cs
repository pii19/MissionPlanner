using System;
using System.Drawing;
using System.Drawing.Imaging;
using GMap.NET;
using GMap.NET.WindowsForms;
using MissionPlanner.Utilities;

namespace MissionPlanner.Maps
{
    [Serializable]
    public class GMapMarkerRallyPt : GMapMarker
    {
        public float? Bearing;

        // WP と同じサイズのマーカーアイコンを利用（元画像をベースにする）
        static readonly Size SizeSt = new Size(Resources.marker_02.Width, Resources.marker_02.Height);

        // Resources.marker_02 をオレンジ色 (#F6AA00) に変換したビットマップ
        static Bitmap localcache2 = CreateOrangeMarker();

        public int Alt { get; set; }

        public GMapMarkerRallyPt(PointLatLng p)
            : base(p)
        {
            Size = SizeSt;
            Offset = new Point(-10, -40);
        }

        public GMapMarkerRallyPt(PointLatLngAlt plla, double altmultiplier = 1)
            : this(new PointLatLng(plla.Lat, plla.Lng))
        {
            Alt = (int)plla.Alt;
            ToolTipMode = MarkerTooltipMode.OnMouseOver;
            ToolTipText = "Rally Point" + "\nAlt: " + (int)(plla.Alt * altmultiplier);
        }

        // Resources.marker_02 をオレンジ色に変換する（初期化時のみ実施）
        private static Bitmap CreateOrangeMarker()
        {
            Bitmap original = Resources.marker_02;
            Bitmap newBmp = new Bitmap(original.Width, original.Height, PixelFormat.Format32bppArgb);
            Color orange = ColorTranslator.FromHtml("#F6AA00");

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    // 透過部分以外はオレンジ色に変更（アルファはそのまま）
                    if (pixel.A > 0)
                    {
                        Color newColor = Color.FromArgb(pixel.A, orange.R, orange.G, orange.B);
                        newBmp.SetPixel(x, y, newColor);
                    }
                    else
                    {
                        newBmp.SetPixel(x, y, pixel);
                    }
                }
            }
            return newBmp;
        }

        static readonly Point[] Arrow = new Point[]
        {
            new Point(-7, 7), new Point(0, -22), new Point(7, 7), new Point(0, 2)
        };

        public override void OnRender(IGraphics g)
        {
#if !PocketPC
            g.DrawImageUnscaled(localcache2, LocalPosition.X, LocalPosition.Y);
#else
            DrawImageUnscaled(g, Resources.marker, LocalPosition.X, LocalPosition.Y);
#endif
        }
    }
}
