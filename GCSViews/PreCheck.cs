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
using System.Runtime.InteropServices;
using System.Threading.Tasks;

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
            tbRTLALT.AutoSize = false;
            tbRTLALT.Height = 38;
        }

        public void Activate()
        {
            try
            {
                timer1.Enabled = true;
#if false
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
#endif
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
                lblBattCharge.Text = cs.battery_remaining.ToString("0") + " %";
                lblBattCharge2.Text = cs.battery_remaining2.ToString("0") + " %";
                lblBattVolt.Text = cs.battery_voltage.ToString("0.00") + " V";
                lblBattVolt2.Text = cs.battery_voltage2.ToString("0.00") + " V";
                lblBattTemp.Text = cs.battery_temp.ToString("0") + " ℃";
                lblBattTemp2.Text = cs.battery_temp2.ToString("0") + " ℃";

                lblLink.Text = cs.linkqualitygcs.ToString("0") + " %";
                lblSatCount.Text = cs.satcount.ToString("0");
                lblSatCount2.Text = cs.satcount2.ToString("0");
                lblGpsHdop.Text = cs.gpshdop.ToString("0.0");
                lblGpsHdop2.Text = cs.gpshdop2.ToString("0.0");
                lblGpsStatus.Text = cs.gpsstatus.ToString("0");
                lblGpsStatus2.Text = cs.gpsstatus2.ToString("0");
                lblPitch.Text = cs.pitch.ToString("0") + " °";
                lblRoll.Text = cs.roll.ToString("0") + " ℃";
#if false
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
#endif
                double[] cells = { cs.battery_cell1, cs.battery_cell2, cs.battery_cell3, cs.battery_cell4,
                    cs.battery_cell5, cs.battery_cell6, cs.battery_cell7, cs.battery_cell8,
                    cs.battery_cell9, cs.battery_cell10, cs.battery_cell11, cs.battery_cell12
                };
                var max = this.Max(cells);
                double celldiff = this.Max(cells) - this.Min(cells);
                lblBattCell.Text = celldiff.ToString("0.00") + " V";

                double[] cells2 = { cs.battery_cell1, cs.battery_cell2, cs.battery_cell3, cs.battery_cell4,
                    cs.battery_cell5, cs.battery_cell6, cs.battery_cell7, cs.battery_cell8,
                    cs.battery_cell9, cs.battery_cell10, cs.battery_cell11, cs.battery_cell12
                };
                max = this.Max(cells2);
                celldiff = this.Max(cells2) - this.Min(cells2);
                lblBattCell2.Text = celldiff.ToString("0.00") + " V";


                if (MainV2.comPort.MAV.param["RTL_ALT"] != null)
                {
                    int value;
                    string str = MainV2.comPort.MAV.param["RTL_ALT"].ToString();
                    if (int.TryParse(str, out value))
                    {
                        str = ((int)(value / 100)).ToString();
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
                            tbRTLALT.ForeColor = Color.Black;
                        }
                    }
                }
            }
            else
            {
                tbRTLALT.Text = "";
                //ParamPropo.Text = "";
                //ParamMode.Text = "";

                lblBattCharge.Text = "";
                lblBattCharge2.Text = "";
                lblBattVolt.Text = "";
                lblBattVolt2.Text = "";
                lblBattTemp.Text = "";
                lblBattTemp2.Text = "";
                lblBattCell.Text = "";
                lblBattCell2.Text = "";
                lblLink.Text = "";
                lblSatCount.Text = "";
                lblSatCount2.Text = "";
                lblGpsHdop.Text = "";
                lblGpsHdop2.Text = "";
                lblGpsStatus.Text = "";
                lblGpsStatus2.Text = "";
                lblPitch.Text = "";
                lblRoll.Text = "";
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

        // https://qiita.com/kiki0817/items/d95bc2cc0ed50b0104a0
        // https://dobon.net/vb/dotnet/process/appactivate.html
        // https://qiita.com/tera1707/items/c6e2884d48248c8f3ba7
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FindWindow(
           string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        // ShowWindowAsync関数のパラメータに渡す定義値
        private const int SW_RESTORE = 9;  // 画面を元の大きさに戻す

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool OpenIcon(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool BringWindowToTop(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr hWnd,
            int hWndInsertAfter, int x, int y, int cx, int cy, int uFlags);

        private const int SWP_NOSIZE = 0x0001;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_NOZORDER = 0x0004;
        private const int SWP_SHOWWINDOW = 0x0040;
        private const int SWP_ASYNCWINDOWPOS = 0x4000;
        private const int HWND_TOP = 0;
        private const int HWND_BOTTOM = 1;
        private const int HWND_TOPMOST = -1;
        private const int HWND_NOTOPMOST = -2;

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        async private void buttonConnect_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = FindWindow(null, "SoftEther VPN クライアント接続マネージャ");
            if (hWnd != IntPtr.Zero)
            {
                //最小化されていれば元に戻す
                if (IsIconic(hWnd))
                {
                    ShowWindowAsync(hWnd, SW_RESTORE);
                }
                //最前面に表示する
                //SetForegroundWindow(hWnd);
                SetWindowPos(hWnd, HWND_TOP, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW | SWP_ASYNCWINDOWPOS);
                BringWindowToTop(hWnd);

                while (true)
                {
#if false
                    if (IsIconic(hWnd))     //この方法に反応せず
                    {
                        break;
                    }
                    if (IsWindowInTasktray(hWnd, 0))    //タスクトレイにアイコンが残存するのでこの方法はNG
                    {
                        break;
                    }
#endif
                    var h = GetForegroundWindow();
                    if (h == MainV2.instance.Handle)
                    {
                        break;
                    }
                    await Task.Delay(10);
                }
            }

            await Task.Delay(500);
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                MainV2.instance.Connect();
            }
        }

        // from Gemini Answer
        [DllImport("shell32.dll", SetLastError = true)]
        static extern bool Shell_NotifyIconGetRect(ref NOTIFYICONIDENTIFIER identifier, out RECT iconRect);

        [DllImport("shell32.dll", SetLastError = true)]
        static extern bool Shell_NotifyIconGetViewSize(ref NOTIFYICONIDENTIFIER identifier, out SIZE iconSize);

        [StructLayout(LayoutKind.Sequential)]
        public struct NOTIFYICONIDENTIFIER
        {
            public int cbSize;
            public IntPtr hWnd;
            public uint uID;
            public Guid guidItem;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SIZE
        {
            public int cx;
            public int cy;
        }

        // タスクトレイに常駐しているかをチェックするメソッド
        public static bool IsWindowInTasktray(IntPtr hWnd, uint uID)
        {
            NOTIFYICONIDENTIFIER identifier = new NOTIFYICONIDENTIFIER();
            identifier.cbSize = Marshal.SizeOf(identifier);
            identifier.hWnd = hWnd;
            identifier.uID = uID;

            RECT iconRect;
            SIZE iconSize;

            if (Shell_NotifyIconGetRect(ref identifier, out iconRect))
            {
                // アイコンの矩形が取得できれば、タスクトレイに存在するとみなす
                return true;
            }
            else if (Shell_NotifyIconGetViewSize(ref identifier, out iconSize))
            {
                return true;
            }
            else
            {
                // エラーが発生した場合（アイコンが存在しない場合も含む）
                return false;
            }
        }

        private void buttonMotorTest_Click(object sender, EventArgs e)
        {
            ;
        }

        private void buttonLoadPlan_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                CustomMessageBox.Show("フライトプランを読み込む前に機体に接続してください。", "フライトプラン読み込み");
                return;
            }

            if (mapBoxFrm != null && !mapBoxFrm.IsDisposed)
            {
                if (!mapBoxFrm.FileLoad())
                {
                    return;
                }
            }

            // おまじない
            // https://dobon.net/vb/bbs/log3-23/14296.html#google_vignette
            var h = MainV2.instance.FlightPlanner.Handle;

            MainV2.instance.FlightPlanner.updateHome();

            List<Locationwp> list;

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

            cbPlan.Checked = true;
        }

        private void buttonDispMap_Click(object sender, EventArgs e)
        {
            if (mapBoxFrm != null && !mapBoxFrm.IsDisposed)
            {
                DialogResult test = mapBoxFrm.ShowDialog();
                cbMap.AutoCheck = true;
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

        public void ResetAll()
        {
            cbBattCharge.Checked = false;
            cbBattCharge2.Checked = false;
            cbBattVolt.Checked = false;
            cbBattVolt2.Checked = false;
            cbBattTemp.Checked = false;
            cbBattTemp2.Checked = false;
            cbBattCell.Checked = false;
            cbBattCell2.Checked = false;

            cbLink.Checked = false;
            cbSatCount.Checked = false;
            cbSatCount2.Checked = false;
            cbGpsHdop.Checked = false;
            cbGpsHdop2.Checked = false;
            cbGpsStatus.Checked = false;
            cbGpsStatus2.Checked = false;
            cbPitch.Checked = false;
            cbRoll.Checked = false;

            cbCamFront.Checked = false;
            cbCamUnder.Checked = false;
            cbPlan.Checked = false;
            cbMap.Checked = false;
            cbMap.AutoCheck = false;

            cbRTLALT.Checked = false;
        }

        public void SetAll()
        {
            cbBattCharge.Checked = true;
            cbBattCharge2.Checked = true;
            cbBattVolt.Checked = true;
            cbBattVolt2.Checked = true;
            cbBattTemp.Checked = true;
            cbBattTemp2.Checked = true;
            cbBattCell.Checked = true;
            cbBattCell2.Checked = true;

            cbLink.Checked = true;
            cbSatCount.Checked = true;
            cbSatCount2.Checked = true;
            cbGpsHdop.Checked = true;
            cbGpsHdop2.Checked = true;
            cbGpsStatus.Checked = true;
            cbGpsStatus2.Checked = true;
            cbPitch.Checked = true;
            cbRoll.Checked = true;

            cbCamFront.Checked = true;
            cbCamUnder.Checked = true;
            cbPlan.Checked = true;
            cbMap.Checked = true;

            cbRTLALT.Checked = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
#if DEBUG
            if (keyData == (Keys.Control | Keys.A))
            {
                SetAll();
                return true;
            }
            if (keyData == (Keys.Control | Keys.Z))
            {
                ResetAll();
                return true;
            }
#endif
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}