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

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float rpm_high_warn { get; set; } = 4800.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float rpm_high_crt { get; set; } = 5000.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float rpm_low_warn { get; set; } = 1500.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float rpm_low_crt { get; set; } = 1300.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float temp_warn { get; set; } = 50.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float temp_crt { get; set; } = 60.0f;

        Color normal = Color.FromArgb(0, 176, 107);
        Color caution = Color.FromArgb(246, 170, 0);
        Color error = Color.FromArgb(255, 75, 0);

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

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Esc1rpm { get { return _esc1rpm; } set { if (_esc1rpm == value) return; _esc1rpm = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Esc2rpm { get { return _esc2rpm; } set { if (_esc2rpm == value) return; _esc2rpm = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Esc3rpm { get { return _esc3rpm; } set { if (_esc3rpm == value) return; _esc3rpm = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Esc4rpm { get { return _esc4rpm; } set { if (_esc4rpm == value) return; _esc4rpm = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Esc5rpm { get { return _esc5rpm; } set { if (_esc5rpm == value) return; _esc5rpm = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Esc6rpm { get { return _esc6rpm; } set { if (_esc6rpm == value) return; _esc6rpm = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Esc1temp { get { return _esc1temp; } set { if (_esc1temp == value) return; _esc1temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Esc2temp { get { return _esc2temp; } set { if (_esc2temp == value) return; _esc2temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Esc3temp { get { return _esc3temp; } set { if (_esc3temp == value) return; _esc3temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Esc4temp { get { return _esc4temp; } set { if (_esc4temp == value) return; _esc4temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Esc5temp { get { return _esc5temp; } set { if (_esc5temp == value) return; _esc5temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
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

            if (rpm_low_warn <= _esc1rpm && _esc1rpm <= rpm_high_warn)
            {
                rpm1.ForeColor = normal;
            }
            else if (rpm_low_crt <= _esc1rpm && _esc1rpm <= rpm_high_crt)
            {
                rpm1.ForeColor = caution;
            }
            else
            {
                rpm1.ForeColor = error;
            }
            if (rpm_low_warn <= _esc2rpm && _esc2rpm <= rpm_high_warn)
            {
                rpm2.ForeColor = normal;
            }
            else if (rpm_low_crt <= _esc2rpm && _esc2rpm <= rpm_high_crt)
            {
                rpm2.ForeColor = normal;
            }
            else
            {
                rpm2.ForeColor = caution;
            }
            if (rpm_low_warn <= _esc3rpm && _esc3rpm <= rpm_high_warn)
            {
                rpm3.ForeColor = normal;
            }
            else if (rpm_low_crt <= _esc3rpm && _esc3rpm <= rpm_high_crt)
            {
                rpm3.ForeColor = normal;
            }
            else
            {
                rpm3.ForeColor = caution;
            }
            if (rpm_low_warn <= _esc4rpm && _esc4rpm <= rpm_high_warn)
            {
                rpm4.ForeColor = normal;
            }
            else if (rpm_low_crt <= _esc4rpm && _esc4rpm <= rpm_high_crt)
            {
                rpm4.ForeColor = normal;
            }
            else
            {
                rpm4.ForeColor = caution;
            }
            if (rpm_low_warn <= _esc5rpm && _esc5rpm <= rpm_high_warn)
            {
                rpm5.ForeColor = normal;
            }
            else if (rpm_low_crt <= _esc5rpm && _esc5rpm <= rpm_high_crt)
            {
                rpm5.ForeColor = normal;
            }
            else
            {
                rpm5.ForeColor = caution;
            }
            if (rpm_low_warn <= _esc6rpm && _esc6rpm <= rpm_high_warn)
            {
                rpm6.ForeColor = normal;
            }
            else if (rpm_low_crt <= _esc6rpm && _esc6rpm <= rpm_high_crt)
            {
                rpm6.ForeColor = normal;
            }
            else
            {
                rpm6.ForeColor = caution;
            }

            if (_esc1temp <= temp_warn)
            {
                temp1.ForeColor = normal;
            }
            else if (_esc1temp <= temp_crt)
            {
                temp1.ForeColor = caution;
            }
            else
            {
                temp1.ForeColor = error;
            }
            if (_esc2temp <= temp_warn)
            {
                temp2.ForeColor = normal;
            }
            else if (_esc2temp <= temp_crt)
            {
                temp2.ForeColor = caution;
            }
            else
            {
                temp2.ForeColor = error;
            }
            if (_esc3temp <= temp_warn)
            {
                temp3.ForeColor = normal;
            }
            else if (_esc3temp <= temp_crt)
            {
                temp3.ForeColor = caution;
            }
            else
            {
                temp3.ForeColor = error;
            }
            if (_esc4temp <= temp_warn)
            {
                temp4.ForeColor = normal;
            }
            else if (_esc4temp <= temp_crt)
            {
                temp4.ForeColor = caution;
            }
            else
            {
                temp4.ForeColor = error;
            }
            if (_esc5temp <= temp_warn)
            {
                temp5.ForeColor = normal;
            }
            else if (_esc5temp <= temp_crt)
            {
                temp5.ForeColor = caution;
            }
            else
            {
                temp5.ForeColor = error;
            }
            if (_esc6temp <= temp_warn)
            {
                temp6.ForeColor = normal;
            }
            else if (_esc6temp <= temp_crt)
            {
                temp6.ForeColor = caution;
            }
            else
            {
                temp6.ForeColor = error;
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
