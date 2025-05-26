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
                ParamRTLALT.Text = "";
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
                        ParamRTLALT.Text = str;
                    }
                }
            }
            else
            {
                ParamBattVolt.Text = "";
                ParamBattCharge.Text = "";
                ParamBattTemp.Text = "";
                ParamBattCell.Text = "";
                ParamSatCount1.Text = "";
                ParamSatCount2.Text = "";
                ParamGpsStatus.Text = "";
                ParamPitch.Text = "";
                ParamRoll.Text = "";
                ParamRTLALT.Text = "";
            }
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
    }
}