using MissionPlanner.Controls;
using MissionPlanner.Properties;
using MissionPlanner.Utilities;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace MissionPlanner.GCSViews
{
    public partial class PreCheck : MyUserControl, IActivate, IDeactivate
    {
        private bool CheckAll = false;

        public PreCheck()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            try
            {
                timer1.Enabled = true;
                ParamBattVolt.Text = "";
                ParamBattCharge.Text = "";
                ParamBattTemp.Text = "";
                ParamSatCount1.Text = "";
                ParamSatCount2.Text = "";
                ParamGpsStatus.Text = "";
                ParamPitch.Text = "";
                ParamRoll.Text = "";
                ParamRTLALT.Text = "";
            }
            catch
            {
            }

            if (Program.WindowsStoreApp)
            {
                ;
            }
        }

        public void Deactivate()
        {
            try
            {
                timer1.Enabled = false;
            }
            catch
            {
            }

            if (Program.WindowsStoreApp)
            {
                ;
            }
        }

        private void PreCheck_Load(object sender, EventArgs e)
        {
            buttonOK.BackColor = Color.Black;
            buttonOK.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            cb.Text = cb.Checked ? "✔" : "";

            cbCheckAll();
        }

        private void cbCheckAll()
        {
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox)
                {
                    bool ret = ((CheckBox)control).Checked;
                    if (!ret)
                    {
                        CheckAll = false;
                        buttonOK.BackColor = Color.Black;
                        buttonOK.ForeColor = Color.FromArgb(64, 64, 64);
                        return;
                    }
                }
            }
            CheckAll = true;
            buttonOK.BackColor = Color.FromArgb(0, 176, 107);
            buttonOK.ForeColor = Color.White;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!CheckAll)
            {
                return;
            }

            MainV2.instance.FlightDataOpen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MainV2.comPort.BaseStream != null && MainV2.comPort.BaseStream.IsOpen)
            {
                var cs = MainV2.comPort.MAV.cs;
                ParamBattVolt.Text = cs.battery_voltage.ToString("0.0");
                ParamBattCharge.Text = cs.battery_remaining.ToString("0.0");
                ParamBattTemp.Text = cs.battery_temp.ToString("0.0");
                ParamSatCount1.Text = cs.satcount.ToString("0");
                ParamSatCount2.Text = cs.satcount2.ToString("0");
                ParamGpsStatus.Text = cs.gpsstatus.ToString("0");
                ParamPitch.Text = cs.pitch.ToString("0.00");
                ParamRoll.Text = cs.roll.ToString("0.00");

                if (MainV2.comPort.MAV.param["RTL_ALT"] != null)
                {
                    int value;
                    string str = MainV2.comPort.MAV.param["RTL_ALT"].ToString();
                    if (int.TryParse(str, out value))
                    {
                        ParamRTLALT.Text = str;
                    }
                }
            }
            else
            {
                ParamBattVolt.Text = "";
                ParamBattCharge.Text = "";
                ParamBattTemp.Text = "";
                ParamSatCount1.Text = "";
                ParamSatCount2.Text = "";
                ParamGpsStatus.Text = "";
                ParamPitch.Text = "";
                ParamRoll.Text = "";
                ParamRTLALT.Text = "";
            }
        }
    }
}