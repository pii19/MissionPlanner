using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class ModeControl : MyUserControl
    {
        public ModeControl()
        {
            InitializeComponent();
            //this.BackColor = Color.Transparent;
            //this.DoubleBuffered = true;
        }

        Color normal = Color.FromArgb(0, 176, 107);
        Color caution = Color.FromArgb(246, 170, 0);
        Color error = Color.FromArgb(255, 75, 0);

        string _mode = "";

        public event EventHandler AutoClick;
        public event EventHandler LoiterClick;

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public string Mode { get { return _mode; } set { if (_mode == value) return; _mode = value; this.Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            switch (_mode.ToUpper())
            {
                case "AUTO":
                    btnAUTO.BackgroundImage = Properties.Resources.mode_auto_on;
                    btnLOITER.BackgroundImage = Properties.Resources.mode_loiter_off;
                    labelMode.Text = "";
                    break;
                case "LOITER":
                    btnAUTO.BackgroundImage = Properties.Resources.mode_auto_off;
                    btnLOITER.BackgroundImage = Properties.Resources.mode_loiter_on;
                    labelMode.Text = "";
                    break;
                case "ALTHOLD":
                    btnAUTO.BackgroundImage = Properties.Resources.mode_auto_off;
                    btnLOITER.BackgroundImage = Properties.Resources.mode_loiter_off;
                    labelMode.Text = "ALTHOLD";
                    break;
                case "RTL":
                    btnAUTO.BackgroundImage = Properties.Resources.mode_auto_off;
                    btnLOITER.BackgroundImage = Properties.Resources.mode_loiter_off;
                    labelMode.Text = "RTL";
                    break;
                default:
                    btnAUTO.BackgroundImage = Properties.Resources.mode_auto_off;
                    btnLOITER.BackgroundImage = Properties.Resources.mode_loiter_off;
                    labelMode.Text = "";
                    break;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            
            base.OnPaintBackground(e);
            //e.Graphics.Clear(Color.Transparent);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        private void btnAUTO_Click(object sender, EventArgs e)
        {
            if (AutoClick != null)
                AutoClick(this, e);
        }

        private void btnLOITER_Click(object sender, EventArgs e)
        {
            if (LoiterClick != null)
                LoiterClick(this, e);
        }
    }
}
