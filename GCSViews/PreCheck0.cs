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
    }
}