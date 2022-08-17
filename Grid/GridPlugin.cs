using System;
using System.Windows.Forms;

namespace MissionPlanner.Grid
{
    public class GridPlugin : MissionPlanner.Plugin.Plugin
    {
        

        ToolStripMenuItem but;

        public override string Name
        {
            get { return "Grid"; }
        }

        public override string Version
        {
            get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }

        public override string Author
        {
            get { return "Michael Oborne"; }
        }

        public override bool Init()
        {
            return true;
        }

        public override bool Loaded()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridUI));
            var temp = (string)(resources.GetObject("$this.Text"));

            but = new ToolStripMenuItem(temp);
            but.Click += but_Click;

            bool hit = false;
            ToolStripItemCollection col = Host.FPMenuMap.Items;
            int index = col.Count;
            foreach (ToolStripItem item in col)
            {
                if (item.Text.Equals(Strings.AutoWP))
                {
                    index = col.IndexOf(item);
                    ((ToolStripMenuItem)item).DropDownItems.Add(but);
                    hit = true;
                    break;
                }
            }

            if (hit == false)
                col.Add(but);

            return true;
        }

        public void but_Click(object sender, EventArgs e)
        {
            using (var gridui = new GridUI(this))
            {
                MissionPlanner.Utilities.ThemeManager.ApplyThemeTo(gridui);

                if (Host.FPDrawnPolygon != null && Host.FPDrawnPolygon.Points.Count > 2)
                {
                    // @eams add / ndvi mesh
                    int mesh_type = 0;
                    if (Host.config["overlay_mesh"] != null)
                        mesh_type = int.Parse(Host.config["overlay_mesh"]);
                    if (mesh_type > 0)
                    {
                        gridui.WindowState = FormWindowState.Minimized;
                        gridui.Visible = false;
                        gridui.ShowDialog();
                    }
                    else
                    {
                        gridui.ShowDialog();
                    }
                }
                else
                {
#if false
                    if (
                        CustomMessageBox.Show("No polygon defined. Load a file?", "Load File", MessageBoxButtons.YesNo) ==
                        (int)DialogResult.Yes)
                    {
                        gridui.LoadGrid();
                        gridui.ShowDialog();
                    }
                    else
                    {
#endif
                        //CustomMessageBox.Show("Please define a polygon.", "Error");
                        CustomMessageBox.Show("ポリゴンを設定してください。", "Error");
                    //}
                }
            }
        }

        public override bool Exit()
        {
            return true;
        }
    }
}
