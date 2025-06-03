using MissionPlanner.Controls;
using MissionPlanner.Properties;
using MissionPlanner.Utilities;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.CompilerServices;
using FlightPlanningSoftware;
using System.Collections.Generic;

namespace MissionPlanner.GCSViews
{
    public partial class PreCheck : MyUserControl, IActivate, IDeactivate
    {
        private bool CheckAll = false;
        private FlightPlanningSoftware.Form1 mapBoxFrm;

        public int th_rtl_alt { get; set; } = 80;

        Color normal = Color.FromArgb(0, 176, 107);
        Color caution = Color.FromArgb(246, 170, 0);
        Color error = Color.FromArgb(255, 75, 0);

        public PreCheck()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            try
            {
                timer1.Enabled = true;
                ParamRTLALT.Text = "";
                tbRTLALT.Text = "";
                ParamPropo.Text = "";
                ParamMode.Text = "";
                ParamBattVolt.Text = "";
                ParamBattCharge.Text = "";
                ParamBattTemp.Text = "";
                ParamBattCell.Text = "";
                ParamSatCount1.Text = "";
                ParamSatCount2.Text = "";
                ParamGpsStatus.Text = "";
                ParamPitch.Text = "";
                ParamRoll.Text = "";
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

            mapBoxFrm = new FlightPlanningSoftware.Form1
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.CenterParent,
                Text = "",
                MaximizeBox = false,
                MinimizeBox = false,
                Width = 1280,
                Height = 1000,
                TopMost = false,
                AutoScaleMode = AutoScaleMode.None,
            };
            mapBoxFrm.AdjustLayout();
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

                var propo = cs.ch12in;
                if (cs.ch12in == 1400)
                {
                    ParamPropo.Text = "CONT1";
                }
                else if (cs.ch12in == 1555)
                {
                    ParamPropo.Text = "CONT2";
                }
                else
                {
                    ParamPropo.Text = "";
                }

                ParamMode.Text = cs.mode;

                double[] cells = { cs.battery_cell1, cs.battery_cell2, cs.battery_cell3, cs.battery_cell4,
                    cs.battery_cell5, cs.battery_cell6, cs.battery_cell7, cs.battery_cell8,
                    cs.battery_cell9, cs.battery_cell10, cs.battery_cell11, cs.battery_cell12
                };
                var max = this.Max(cells);
                double celldiff = this.Max(cells) - this.Min(cells);
                ParamBattCell.Text = celldiff.ToString("0.00");

                if (MainV2.comPort.MAV.param["RTL_ALT"] != null)
                {
                    int value;
                    string str = MainV2.comPort.MAV.param["RTL_ALT"].ToString();
                    if (int.TryParse(str, out value))
                    {
                        str = ((int)(value / 100)).ToString();
                        ParamRTLALT.Text = str;
                        if (!tbRTLALT.Focused)
                        {
                            tbRTLALT.Text = str;
                        }

                        if ((int)(value / 100) < th_rtl_alt)
                        {
                            tbRTLALT.ForeColor = error;
                        }
                        else
                        {
                            tbRTLALT.ForeColor = Color.White;
                        }
                    }
                }
            }
            else
            {
                ParamRTLALT.Text = "";
                tbRTLALT.Text = "";
                ParamPropo.Text = "";
                ParamMode.Text = "";

                ParamBattVolt.Text = "";
                ParamBattCharge.Text = "";
                ParamBattTemp.Text = "";
                ParamBattCell.Text = "";
                ParamSatCount1.Text = "";
                ParamSatCount2.Text = "";
                ParamGpsStatus.Text = "";
                ParamPitch.Text = "";
                ParamRoll.Text = "";
            }

            cbConnect.Checked = MainV2.comPort.BaseStream.IsOpen;

        }

        // https://note.nkmk.me/c-sharp-max-min-params-generics/
        private T Max<T>(params T[] nums) where T : IComparable
        {
            if (nums.Length == 0) return default(T);

            T max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                max = max.CompareTo(nums[i]) > 0 ? max : nums[i];
            }
            return max;
        }

        private T Min<T>(params T[] nums) where T : IComparable
        {
            if (nums.Length == 0) return default(T);

            T max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                max = max.CompareTo(nums[i]) < 0 ? max : nums[i];
            }
            return max;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                MainV2.instance.Connect();
            }
        }

        private void buttonMotorTest_Click(object sender, EventArgs e)
        {
            ;
        }

        private void buttonLoadPlan_Click(object sender, EventArgs e)
        {
            if (mapBoxFrm != null && !mapBoxFrm.IsDisposed)
            {
                mapBoxFrm.FileLoad();
            }

            List<Locationwp> list;
            this.BeginInvoke((MethodInvoker)delegate
            {
                // save WP data
                list = mapBoxFrm.getWP();
                MainV2.instance.FlightPlanner.cmb_missiontype.SelectedIndex = (int)MAVLink.MAV_MISSION_TYPE.MISSION;
                MainV2.instance.FlightPlanner.WPtoScreen(list);
                MainV2.instance.FlightPlanner.BUT_write_Click(null, null);

                // save Fence data
                list = mapBoxFrm.getFence();
                MainV2.instance.FlightPlanner.cmb_missiontype.SelectedIndex = (int)MAVLink.MAV_MISSION_TYPE.FENCE;
                MainV2.instance.FlightPlanner.WPtoScreen(list);
                MainV2.instance.FlightPlanner.BUT_write_Click(null, null);

                // save Rally data
                list = mapBoxFrm.getRally();
                MainV2.instance.FlightPlanner.cmb_missiontype.SelectedIndex = (int)MAVLink.MAV_MISSION_TYPE.RALLY;
                MainV2.instance.FlightPlanner.WPtoScreen(list);
                MainV2.instance.FlightPlanner.BUT_write_Click(null, null);
            });
        }

        private void buttonDispMap_Click(object sender, EventArgs e)
        {
            if (mapBoxFrm != null && !mapBoxFrm.IsDisposed)
            {
                DialogResult test = mapBoxFrm.ShowDialog();
            }
        }

        private void tbRTLALT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int value = 0;
                if (int.TryParse(tbRTLALT.Text, out value))
                {
                    value *= 100;
                    MainV2.comPort.setParam("RTL_ALT", (double)value);
                }
                this.ActiveControl = null;
            }
        }
    }
}