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
    public partial class MotorStatus : MyUserControl
    {
        public MotorStatus()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
        }

        const float rpm_max = 1800;
        const float rpm_min = 1300;
        const float temp_max = 80;
        const float temp_min = 0;
        Color normal = Color.SpringGreen;
        Color caution = Color.FromArgb(246, 170, 0);

        float _esc1rpm = 0;
        float _esc2rpm = 0;
        float _esc3rpm = 0;
        float _esc4rpm = 0;
        float _esc5rpm = 0;
        float _esc6rpm = 0;
        float _esc1temp = 0;
        float _esc2temp = 0;
        float _esc3temp = 0;
        float _esc4temp = 0;
        float _esc5temp = 0;
        float _esc6temp = 0;

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Options")]
        public float Esc1rpm { get { return _esc1rpm; } set { if (_esc1rpm == value) return; _esc1rpm = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Options")]
        public float Esc2rpm { get { return _esc2rpm; } set { if (_esc2rpm == value) return; _esc2rpm = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Options")]
        public float Esc3rpm { get { return _esc3rpm; } set { if (_esc3rpm == value) return; _esc3rpm = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Options")]
        public float Esc4rpm { get { return _esc4rpm; } set { if (_esc4rpm == value) return; _esc4rpm = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Options")]
        public float Esc5rpm { get { return _esc5rpm; } set { if (_esc5rpm == value) return; _esc5rpm = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Options")]
        public float Esc6rpm { get { return _esc6rpm; } set { if (_esc6rpm == value) return; _esc6rpm = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Options")]
        public float Esc1temp { get { return _esc1temp; } set { if (_esc1temp == value) return; _esc1temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Options")]
        public float Esc2temp { get { return _esc2temp; } set { if (_esc2temp == value) return; _esc2temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Options")]
        public float Esc3temp { get { return _esc3temp; } set { if (_esc3temp == value) return; _esc3temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Options")]
        public float Esc4temp { get { return _esc4temp; } set { if (_esc4temp == value) return; _esc4temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Options")]
        public float Esc5temp { get { return _esc5temp; } set { if (_esc5temp == value) return; _esc5temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Options")]
        public float Esc6temp { get { return _esc6temp; } set { if (_esc6temp == value) return; _esc6temp = value; this.Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            rpm1.Text = _esc1rpm.ToString("F0");
            rpm2.Text = _esc2rpm.ToString("F0");
            rpm3.Text = _esc3rpm.ToString("F0");
            rpm4.Text = _esc4rpm.ToString("F0");
            rpm5.Text = _esc5rpm.ToString("F0");
            rpm6.Text = _esc6rpm.ToString("F0");

            temp1.Text = _esc1temp.ToString("F0");
            temp2.Text = _esc2temp.ToString("F0");
            temp3.Text = _esc3temp.ToString("F0");
            temp4.Text = _esc4temp.ToString("F0");
            temp5.Text = _esc5temp.ToString("F0");
            temp6.Text = _esc6temp.ToString("F0");

            if (rpm_min <= _esc1rpm && _esc1rpm <= rpm_max)
            {
                rpm1.ForeColor = normal;
            }
            else
            {
                rpm1.ForeColor = caution;
            }
            if (rpm_min <= _esc2rpm && _esc2rpm <= rpm_max)
            {
                rpm2.ForeColor = normal;
            }
            else
            {
                rpm2.ForeColor = caution;
            }
            if (rpm_min <= _esc3rpm && _esc3rpm <= rpm_max)
            {
                rpm3.ForeColor = normal;
            }
            else
            {
                rpm3.ForeColor = caution;
            }
            if (rpm_min <= _esc4rpm && _esc4rpm <= rpm_max)
            {
                rpm4.ForeColor = normal;
            }
            else
            {
                rpm4.ForeColor = caution;
            }
            if (rpm_min <= _esc5rpm && _esc5rpm <= rpm_max)
            {
                rpm5.ForeColor = normal;
            }
            else
            {
                rpm5.ForeColor = caution;
            }
            if (rpm_min <= _esc6rpm && _esc6rpm <= rpm_max)
            {
                rpm6.ForeColor = normal;
            }
            else
            {
                rpm6.ForeColor = caution;
            }

            if (temp_min <= _esc1temp && _esc1temp <= temp_max)
            {
                temp1.ForeColor = normal;
            }
            else
            {
                temp1.ForeColor = caution;
            }
            if (temp_min <= _esc2temp && _esc2temp <= temp_max)
            {
                temp2.ForeColor = normal;
            }
            else
            {
                temp2.ForeColor = caution;
            }
            if (temp_min <= _esc3temp && _esc3temp <= temp_max)
            {
                temp3.ForeColor = normal;
            }
            else
            {
                temp3.ForeColor = caution;
            }
            if (temp_min <= _esc4temp && _esc4temp <= temp_max)
            {
                temp4.ForeColor = normal;
            }
            else
            {
                temp4.ForeColor = caution;
            }
            if (temp_min <= _esc5temp && _esc5temp <= temp_max)
            {
                temp5.ForeColor = normal;
            }
            else
            {
                temp5.ForeColor = caution;
            }
            if (temp_min <= _esc6temp && _esc6temp <= temp_max)
            {
                temp6.ForeColor = normal;
            }
            else
            {
                temp6.ForeColor = caution;
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
    }
}
