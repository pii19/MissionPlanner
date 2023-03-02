namespace MissionPlanner.GCSViews.ConfigurationView
{
    partial class ConfigHWKHI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigHWKHI));
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BUT_settings = new MissionPlanner.Controls.MyButton();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.txt_dist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // BUT_settings
            // 
            resources.ApplyResources(this.BUT_settings, "BUT_settings");
            this.BUT_settings.Name = "BUT_settings";
            this.BUT_settings.UseVisualStyleBackColor = true;
            this.BUT_settings.Click += new System.EventHandler(this.BUT_settings_Click);
            // 
            // txt_time
            // 
            resources.ApplyResources(this.txt_time, "txt_time");
            this.txt_time.Name = "txt_time";
            // 
            // txt_dist
            // 
            resources.ApplyResources(this.txt_dist, "txt_dist");
            this.txt_dist.Name = "txt_dist";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // ConfigHWKHI
            // 
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dist);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.BUT_settings);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox5);
            this.Name = "ConfigHWKHI";
            resources.ApplyResources(this, "$this");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private Controls.MyButton BUT_settings;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.TextBox txt_dist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
