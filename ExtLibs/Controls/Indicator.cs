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
    public partial class Indicator : MyUserControl
    {
        public Indicator()
        {
            InitializeComponent();
            //this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;

            MOTOR.ForeColor = normal;
            BATTERY.ForeColor = normal;
            VIBE.ForeColor = normal;
            EKF.ForeColor = normal;
            LINK.ForeColor = normal;
            ATS.ForeColor = normal;
            DGPS.ForeColor = normal;
            GNSS1.ForeColor = normal;
            CONT1.ForeColor = normal;
        }

        public event PropertyChangedEventHandler PropertyChanged = (_, __) => { };

        private void NotifyPropertyChanged(string propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float motor_warn { get; set; } = 30.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float motor_crt { get; set; } = 60.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float battery_warn { get; set; } = 30.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float battery_crt { get; set; } = 60.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float vibe_warn { get; set; } = 30.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float vibe_crt { get; set; } = 60.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float ekf_warn { get; set; } = 0.5f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float ekf_crt { get; set; } = 0.8f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float link_warn { get; set; } = 80f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float link_crt { get; set; } = 50f;

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float satcount_warn { get; set; } = 15f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float satcount_crt { get; set; } = 10f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float gpshdop_warn { get; set; } = 0.7f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float gpshdop_crt { get; set; } = 1.0f;
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Settings")]
        public float gpsstatus_warn { get; set; } = 3.0f;

        Color normal = Color.FromArgb(0, 176, 107);
        Color caution = Color.FromArgb(246, 170, 0);
        Color error = Color.FromArgb(255, 75, 0);

        MasterStatus _motorstatus = MasterStatus.Normal;
        MasterStatus _batterystatus = MasterStatus.Normal;
        float _vibestatus = 0.0f;
        float _ekfstatus = 0.0f;
        float _linkstatus = 100.0f;
        float _satcount = 0.0f;
        float _satcount2 = 0.0f;
        float _gpshdop = 0.0f;
        float _gpshdop2 = 0.0f;
        float _gpsstatus = 0.0f;
        float _gpsstatus2 = 0.0f;
        MasterStatus _masterstatus = MasterStatus.Normal;


        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public MasterStatus motorstatus { get { return _motorstatus; } set { if (_motorstatus == value) return; _motorstatus = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public MasterStatus batterystatus {
            get { return _batterystatus; }
            set {
                if (_batterystatus == value) return;
                _batterystatus = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float vibestatus { get { return _vibestatus; } set { if (_vibestatus == value) return; _vibestatus = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float ekfstatus { get { return _ekfstatus; } set { if (_ekfstatus == value) return; _ekfstatus = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float linkstatus { get { return _linkstatus; } set { if (_linkstatus == value) return; _linkstatus = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float satcount { get { return _satcount; } set { if (_satcount == value) return; _satcount = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float satcount2 { get { return _satcount2; } set { if (_satcount2 == value) return; _satcount2 = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float gpshdop { get { return _gpshdop; } set { if (_gpshdop == value) return; _gpshdop = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float gpshdop2 { get { return _gpshdop2; } set { if (_gpshdop2 == value) return; _gpshdop2 = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float gpsstatus { get { return _gpsstatus; } set { if (_gpsstatus == value) return; _gpsstatus = value; this.Invalidate(); } }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float gpsstatus2 { get { return _gpsstatus2; } set { if (_gpsstatus2 == value) return; _gpsstatus2 = value; this.Invalidate(); } }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public MasterStatus masterstatus
        {
            get { return _masterstatus; }
            set
            {
                _masterstatus = value;
                NotifyPropertyChanged("masterstatus");
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            MasterStatus mst = MasterStatus.Normal; 

            // MOTOR
            if (_motorstatus == MasterStatus.Normal)
            {
                MOTOR.ForeColor = normal;
            }
            else if (_motorstatus == MasterStatus.Caution)
            {
                MOTOR.ForeColor = caution;
                if (mst == MasterStatus.Normal)
                {
                    mst = MasterStatus.Caution;
                }
            }
            else
            {
                MOTOR.ForeColor = error;
                mst = MasterStatus.Error;
            }

            // BATTERY
            if (_batterystatus == MasterStatus.Normal)
            {
                BATTERY.ForeColor = normal;
            }
            else if (_batterystatus == MasterStatus.Caution)
            {
                BATTERY.ForeColor = caution;
                if (mst == MasterStatus.Normal)
                {
                    mst = MasterStatus.Caution;
                }
            }
            else
            {
                BATTERY.ForeColor = error;
                mst = MasterStatus.Error;
            }

            // VIBE
            if (_vibestatus < vibe_warn)
            {
                VIBE.ForeColor = normal;
            }
            else if (_vibestatus < vibe_crt)
            {
                VIBE.ForeColor = caution;
                if (mst == MasterStatus.Normal)
                {
                    mst = MasterStatus.Caution;
                }
            }
            else
            {
                VIBE.ForeColor = error;
                mst = MasterStatus.Error;
            }

            // EKF
            if (_ekfstatus < ekf_warn)
            {
                EKF.ForeColor = normal;
            }
            else if (_ekfstatus < ekf_crt)
            {
                EKF.ForeColor = caution;
                if (mst == MasterStatus.Normal)
                {
                    mst = MasterStatus.Caution;
                }
            }
            else
            {
                EKF.ForeColor = error;
                mst = MasterStatus.Error;
            }

            // LINK
            if (_linkstatus >= link_warn)
            {
                LINK.ForeColor = normal;
            }
            else if (_ekfstatus >= link_crt)
            {
                LINK.ForeColor = caution;
                if (mst == MasterStatus.Normal)
                {
                    mst = MasterStatus.Caution;
                }
            }
            else
            {
                LINK.ForeColor = error;
                mst = MasterStatus.Error;
            }

            // GNSS1
            if (_satcount >= satcount_warn && _gpshdop < gpshdop_warn)
            {
                GNSS1.ForeColor = normal;
            }
            else if (_satcount >= satcount_crt && _gpshdop < gpshdop_crt)
            {
                GNSS1.ForeColor = caution;
                if (mst == MasterStatus.Normal)
                {
                    mst = MasterStatus.Caution;
                }
            }
            else
            {
                GNSS1.ForeColor = error;
                mst = MasterStatus.Error;
            }

            // GNSS2
            if (_satcount2 >= satcount_warn && _gpshdop2 < gpshdop_warn)
            {
                GNSS2.ForeColor = normal;
            }
            else if (_satcount2 >= satcount_crt && _gpshdop2 < gpshdop_crt)
            {
                GNSS2.ForeColor = caution;
                if (mst == MasterStatus.Normal)
                {
                    mst = MasterStatus.Caution;
                }
            }
            else
            {
                GNSS2.ForeColor = error;
                mst = MasterStatus.Error;
            }

            // DGPS
            if (_gpsstatus >= gpsstatus_warn && _gpsstatus2 >= gpsstatus_warn)
            {
                DGPS.ForeColor = normal;
            }
            else
            {
                DGPS.ForeColor = caution;
                if (mst == MasterStatus.Normal)
                {
                    mst = MasterStatus.Caution;
                }
            }

            // Master
            _masterstatus = mst;
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

    public enum MasterStatus
    {
        Normal,
        Caution,
        Error
    }
}
