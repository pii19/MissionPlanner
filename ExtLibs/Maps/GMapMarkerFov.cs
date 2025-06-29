using System;
using System.Drawing;
using GMap.NET;
using GMap.NET.WindowsForms;
using MissionPlanner.Utilities;
using Org.BouncyCastle.Crypto.Signers;

namespace MissionPlanner.Maps
{
    [Serializable]
    public class GMapMarkerFov : GMapMarkerBase
    {
        private readonly Bitmap icon = global::MissionPlanner.Maps.Resources.fov;

        float heading = 0;
        float yaw = 0;
        GMapMarker basemarker;

        public float Heading { get => heading; set => heading = value; }
        public float Yaw { get => yaw; set => yaw = value; }

        public GMapMarkerFov(PointLatLng p, float heading, float yaw, GMapMarker marker)
            : base(p)
        {
            this.Heading = heading;
            this.Yaw = yaw;
            this.basemarker = marker;

            Size = icon.Size;
            // for hitzone
            //Offset = new Point(-icon.Width / 2, -icon.Height / 2);
        }

        public override void OnRender(IGraphics g)
        {
            if (IsHidden)
            {
                return;
            }

            var length = basemarker.Size.Height / 2;
            var temp = g.Transform;
            g.TranslateTransform(LocalPosition.X, LocalPosition.Y);
            g.RotateTransform(-Overlay.Control.Bearing);

            // anti NaN
            try
            {
                g.RotateTransform(Heading);
            }
            catch
            {
            }

            g.TranslateTransform(-3, -length + 10);

            // anti NaN
            try
            {

            }
            catch
            {
                g.RotateTransform(Yaw);
            }

#if NET472_OR_GREATER
            var ia = new System.Drawing.Imaging.ImageAttributes();
            if (IsTransparent)
            {
                // Draw image with transparency using a color matrix
                var cm = new System.Drawing.Imaging.ColorMatrix { Matrix33 = 0.39f };
                ia.SetColorMatrix(cm, System.Drawing.Imaging.ColorMatrixFlag.Default, System.Drawing.Imaging.ColorAdjustType.Bitmap);
            }
            g.DrawImage(icon, new Rectangle(-icon.Width / 2, -icon.Height , icon.Width, icon.Height), 0, 0, icon.Width, icon.Height, GraphicsUnit.Pixel, ia);
            //g.DrawImage(icon, new Rectangle(-icon.Width / 2, -icon.Height / 2, icon.Width, icon.Height), 0, 0, icon.Width, icon.Height, GraphicsUnit.Pixel, ia);
#else
            g.DrawImageUnscaled(icon, icon.Width / -2 + 2, icon.Height / -2);
#endif
            g.Transform = temp;
        }
    }
}