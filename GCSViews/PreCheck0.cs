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
using ExifLibrary;
using System.Reactive.Joins;

namespace MissionPlanner.GCSViews
{
    public partial class PreCheck0 : MyUserControl, IActivate, IDeactivate
    {
        private bool CheckAll = false;

        Color normal = Color.FromArgb(0, 176, 107);
        Color caution = Color.FromArgb(246, 170, 0);
        Color error = Color.FromArgb(255, 75, 0);

        public PreCheck0()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            try
            {
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
            }
            catch
            {
            }

            if (Program.WindowsStoreApp)
            {
                ;
            }
        }

        private void PreCheck0_Load(object sender, EventArgs e)
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

            MainV2.instance.PreCheckOpen();
        }

        public void ResetAll()
        {
            cbBody1.Checked = false;
            cbBody2.Checked = false;
            cbBody3.Checked = false;
            cbBody4.Checked = false;
            cbBody5.Checked = false;
            cbBody6.Checked = false;
            cbBody7.Checked = false;
            cbBody8.Checked = false;
            cbBody9.Checked = false;
            cbBody10.Checked = false;
            cbBody11.Checked = false;
            cbBody12.Checked = false;
            cbBody13.Checked = false;
            cbBody14.Checked = false;
            cbBody15.Checked = false;
            cbBody16.Checked = false;
            cbBody17.Checked = false;
            cbBody18.Checked = false;
            cbBody19.Checked = false;
            cbBody20.Checked = false;
            cbBody21.Checked = false;
            cbBody22.Checked = false;

            cbPropo1.Checked = false;
            cbPropo2.Checked = false;
            cbPropo3.Checked = false;
            cbPropo4.Checked = false;
            cbPropo5.Checked = false;
        }

        public void SetAll()
        {
            cbBody1.Checked = true;
            cbBody2.Checked = true;
            cbBody3.Checked = true;
            cbBody4.Checked = true;
            cbBody5.Checked = true;
            cbBody6.Checked = true;
            cbBody7.Checked = true;
            cbBody8.Checked = true;
            cbBody9.Checked = true;
            cbBody10.Checked = true;
            cbBody11.Checked = true;
            cbBody12.Checked = true;
            cbBody13.Checked = true;
            cbBody14.Checked = true;
            cbBody15.Checked = true;
            cbBody16.Checked = true;
            cbBody17.Checked = true;
            cbBody18.Checked = true;
            cbBody19.Checked = true;
            cbBody20.Checked = true;
            cbBody21.Checked = true;
            cbBody22.Checked = true;

            cbPropo1.Checked = true;
            cbPropo2.Checked = true;
            cbPropo3.Checked = true;
            cbPropo4.Checked = true;
            cbPropo5.Checked = true;
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