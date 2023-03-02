using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigHWKHI : MyUserControl, IActivate
    {
        private int _time;
        public int time
        {
            get { return _time; }
            set
            {
                if (0 <= value && value <= 127)
                {
                    _time = value;
                }
            }
        }
        private int _dist;
        public int dist
        {
            get { return _dist; }
            set
            {
                if (0 <= value && value <= 255)
                {
                    _dist = value;
                }
            }
        }

        private int ch = 0;


        public ConfigHWKHI()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            if (MainV2.comPort.BaseStream.IsOpen)
            {
                ch = MainV2.recwp_servo_ch;
                var now = GetServoValue(ch);
                var rectime = (now & 0x7f00) >> 8;
                txt_time.Text = rectime.ToString();
                var recdist = (now & 0x00ff);
                txt_dist.Text = recdist.ToString();
                //Enabled = false;
                Enabled = true;
            }
            else
            {
                Enabled = false;
            }
        }

        private void BUT_settings_Click(object sender, EventArgs e)
        {
            int value;

            if (int.TryParse(txt_time.Text, out value))
            {
                if (0 <= value && value <= 127)
                {
                    _time = value;
                }
                else
                {
                    CustomMessageBox.Show("記録時間間隔の設定値が範囲外です。", Strings.ERROR);
                    return;
                }
            }
            else
            {
                CustomMessageBox.Show("記録時間間隔の設定値の書式が不正です。", Strings.ERROR);
                return;
            }

            if (int.TryParse(txt_dist.Text, out value))
            {
                if (0 <= value && value <= 255)
                {
                    _dist = value;
                }
                else
                {
                    CustomMessageBox.Show("記録距離間隔の設定値が範囲外です。", Strings.ERROR);
                    return;
                }
            }
            else
            {
                CustomMessageBox.Show("記録距離間隔の設定値の書式が不正です。", Strings.ERROR);
                return;
            }

            MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_SET_SERVO, ch, (_time << 8) + _dist, 0, 0, 0, 0, 0);
            Settings.Instance["khi_recwp_time"] = _time.ToString();
            Settings.Instance["khi_recwp_dist"] = _dist.ToString();
            CustomMessageBox.Show("記録間隔を設定しました", "WPロギング設定");
        }

        private int GetServoValue(int ch)
        {
            int value = 0;
            switch (ch)
            {
                case 1:
                    value = (int)MainV2.comPort.MAV.cs.ch1out;
                    break;
                case 2:
                    value = (int)MainV2.comPort.MAV.cs.ch2out;
                    break;
                case 3:
                    value = (int)MainV2.comPort.MAV.cs.ch3out;
                    break;
                case 4:
                    value = (int)MainV2.comPort.MAV.cs.ch4out;
                    break;
                case 5:
                    value = (int)MainV2.comPort.MAV.cs.ch5out;
                    break;
                case 6:
                    value = (int)MainV2.comPort.MAV.cs.ch6out;
                    break;
                case 7:
                    value = (int)MainV2.comPort.MAV.cs.ch7out;
                    break;
                case 8:
                    value = (int)MainV2.comPort.MAV.cs.ch8out;
                    break;
                default:
                    break;
            }

            return value;
        }
    }
}