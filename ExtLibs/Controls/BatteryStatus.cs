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
    public partial class BatteryStatus : MyUserControl
    {
        public BatteryStatus()
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

        float _batt1temp = 0;
        float _batt2temp = 0;
        float _batt1charge = 0;
        float _batt2charge = 0;
        float _batt1volt = 0;
        float _batt2volt = 0;

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Batt1temp { get { return _batt1temp; } set { if (_batt1temp == value) return; _batt1temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Batt2temp { get { return _batt2temp; } set { if (_batt2temp == value) return; _batt2temp = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Batt1charge { get { return _batt1charge; } set { if (_batt1charge == value) return; _batt1charge = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Batt2charge { get { return _batt2charge; } set { if (_batt2charge == value) return; _batt2charge = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Batt1volt { get { return _batt1volt; } set { if (_batt1volt == value) return; _batt1volt = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float Batt2volt { get { return _batt2volt; } set { if (_batt2volt == value) return; _batt2volt = value; this.Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_batt1temp == 32767)
            {
                temp1.Text = "--";
                volt1.Text = "--";
            }
            else
            {
                temp1.Text = _batt1temp.ToString("F0");
                volt1.Text = _batt1volt.ToString("F1");
            }
            if (_batt2temp == 32767)
            {
                temp2.Text = "--";
                volt2.Text = "--";
            }
            else
            {
                temp2.Text = _batt2temp.ToString("F0");
                volt2.Text = _batt2volt.ToString("F1");
            }

            if (_batt1charge == -1)
            {
                charge1.Text = "--";
            }
            else
            {
                charge1.Text = _batt1charge.ToString("F0");
            }
            if (_batt2charge == -1)
            {
                charge2.Text = "--";
            }
            else
            {
                charge2.Text = _batt2charge.ToString("F0");
            }

            if (temp_low_warn <= _batt1temp && _batt1temp <= temp_high_warn)
            {
                temp1.ForeColor = normal;
            }
            else if (temp_low_crt <= _batt1temp && _batt1temp <= temp_high_crt)
            {
                temp1.ForeColor = caution;
            }
            else
            {
                temp1.ForeColor = error;
            }
            if (temp_low_warn <= _batt2temp && _batt2temp <= temp_high_warn)
            {
                temp2.ForeColor = normal;
            }
            else if (temp_low_crt <= _batt2temp && _batt2temp <= temp_high_crt)
            {
                temp2.ForeColor = caution;
            }
            else
            {
                temp2.ForeColor = error;
            }

            if (charge_warn <= _batt1charge )
            {
                charge1.ForeColor = normal;
            }
            else if (charge_crt <= _batt1charge)
            {
                charge1.ForeColor = caution;
            }
            else
            {
                charge1.ForeColor = error;
            }
            if (charge_warn < _batt2charge)
            {
                charge2.ForeColor = normal;
            }
            else if (charge_crt <= _batt2charge)
            {
                charge2.ForeColor = caution;
            }
            else
            {
                charge2.ForeColor = error;
            }

            if (volt_warn <= _batt1volt)
            {
                volt1.ForeColor = normal;
            }
            else if (volt_crt <= _batt1volt)
            {
                volt1.ForeColor = caution;
            }
            else
            {
                volt1.ForeColor = error;
            }
            if (volt_warn <= _batt2volt)
            {
                volt2.ForeColor = normal;
            }
            if (volt_crt <= _batt2volt)
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
