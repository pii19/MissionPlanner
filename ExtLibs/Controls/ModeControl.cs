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
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float temp_high_warn { get; set; } = 50.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float temp_high_crt { get; set; } = 60.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float temp_low_warn { get; set; } = 0.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float temp_low_crt { get; set; } = -10.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float charge_warn { get; set; } = 30.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float charge_crt { get; set; } = 10.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float volt_warn { get; set; } = 43.4f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float volt_crt { get; set; } = 42.0f;

        Color normal = Color.FromArgb(0, 176, 107);
        Color caution = Color.FromArgb(246, 170, 0);
        Color error = Color.FromArgb(255, 75, 0);

        float _motor1temp = 0;
        float _motor2temp = 0;
        float _motor1charge = 0;
        float _motor2charge = 0;
        float _motor1volt = 0;
        float _motor2volt = 0;

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Batt1temp { get { return _motor1temp; } set { if (_motor1temp == value) return; _motor1temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Batt2temp { get { return _motor2temp; } set { if (_motor2temp == value) return; _motor2temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Batt1charge { get { return _motor1charge; } set { if (_motor1charge == value) return; _motor1charge = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Batt2charge { get { return _motor2charge; } set { if (_motor2charge == value) return; _motor2charge = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Batt1volt { get { return _motor1volt; } set { if (_motor1volt == value) return; _motor1volt = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Batt2volt { get { return _motor2volt; } set { if (_motor2volt == value) return; _motor2volt = value; this.Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            temp1.Text = _motor1temp.ToString("F0");
            temp2.Text = _motor2temp.ToString("F0");

            charge1.Text = _motor1charge.ToString("F0");
            charge2.Text = _motor2charge.ToString("F0");

            volt1.Text = _motor1volt.ToString("F1");
            volt2.Text = _motor2volt.ToString("F1");

            if (temp_low_warn <= _motor1temp && _motor1temp <= temp_high_warn)
            {
                temp1.ForeColor = normal;
            }
            else if (temp_low_crt <= _motor1temp && _motor1temp <= temp_high_crt)
            {
                temp1.ForeColor = caution;
            }
            else
            {
                temp1.ForeColor = error;
            }
            if (temp_low_warn <= _motor2temp && _motor2temp <= temp_high_warn)
            {
                temp2.ForeColor = normal;
            }
            else if (temp_low_crt <= _motor2temp && _motor2temp <= temp_high_crt)
            {
                temp2.ForeColor = caution;
            }
            else
            {
                temp2.ForeColor = error;
            }

            if (charge_warn <= _motor1charge )
            {
                charge1.ForeColor = normal;
            }
            else if (charge_crt <= _motor1charge)
            {
                charge1.ForeColor = caution;
            }
            else
            {
                charge1.ForeColor = error;
            }
            if (charge_warn < _motor2charge)
            {
                charge2.ForeColor = normal;
            }
            else if (charge_crt <= _motor2charge)
            {
                charge2.ForeColor = caution;
            }
            else
            {
                charge2.ForeColor = error;
            }

            if (volt_warn <= _motor1volt)
            {
                volt1.ForeColor = normal;
            }
            else if (volt_crt <= _motor1volt)
            {
                volt1.ForeColor = caution;
            }
            else
            {
                volt1.ForeColor = error;
            }
            if (volt_warn <= _motor2volt)
            {
                volt2.ForeColor = normal;
            }
            if (volt_crt <= _motor2volt)
            {
                volt2.ForeColor = caution;
            }
            else
            {
                volt2.ForeColor = error;
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
