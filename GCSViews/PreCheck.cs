using MissionPlanner.Controls;
using MissionPlanner.Properties;
using MissionPlanner.Utilities;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class PreCheck : MyUserControl, IActivate
    {
        public PreCheck()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            try
            {
                ;
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
            ;
            //ThemeManager.ApplyThemeTo(richTextBox1);
        }
    }
}