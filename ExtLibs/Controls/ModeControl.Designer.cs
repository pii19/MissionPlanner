namespace MissionPlanner.Controls
{
    partial class ModeControl
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
            this.btnLOITER = new System.Windows.Forms.Button();
            this.btnAUTO = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLOITER
            // 
            this.btnLOITER.BackColor = System.Drawing.Color.Transparent;
            this.btnLOITER.BackgroundImage = global::MissionPlanner.Controls.Properties.Resources.mode_loiter_off;
            this.btnLOITER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLOITER.FlatAppearance.BorderSize = 0;
            this.btnLOITER.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLOITER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLOITER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOITER.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.btnLOITER.ForeColor = System.Drawing.Color.Transparent;
            this.btnLOITER.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLOITER.Location = new System.Drawing.Point(229, 0);
            this.btnLOITER.Name = "btnLOITER";
            this.btnLOITER.Size = new System.Drawing.Size(121, 50);
            this.btnLOITER.TabIndex = 9;
            this.btnLOITER.TabStop = false;
            this.btnLOITER.Tag = "custom";
            this.btnLOITER.UseVisualStyleBackColor = false;
            this.btnLOITER.Click += new System.EventHandler(this.btnLOITER_Click);
            // 
            // btnAUTO
            // 
            this.btnAUTO.BackColor = System.Drawing.Color.Transparent;
            this.btnAUTO.BackgroundImage = global::MissionPlanner.Controls.Properties.Resources.mode_auto_on;
            this.btnAUTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAUTO.FlatAppearance.BorderSize = 0;
            this.btnAUTO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAUTO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAUTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAUTO.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.btnAUTO.ForeColor = System.Drawing.Color.Transparent;
            this.btnAUTO.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAUTO.Location = new System.Drawing.Point(108, 0);
            this.btnAUTO.Name = "btnAUTO";
            this.btnAUTO.Size = new System.Drawing.Size(121, 50);
            this.btnAUTO.TabIndex = 8;
            this.btnAUTO.TabStop = false;
            this.btnAUTO.Tag = "custom";
            this.btnAUTO.UseVisualStyleBackColor = false;
            this.btnAUTO.Click += new System.EventHandler(this.btnAUTO_Click);
            // 
            // labelMode
            // 
            this.labelMode.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.labelMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.labelMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelMode.Location = new System.Drawing.Point(5, 11);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(97, 29);
            this.labelMode.TabIndex = 7;
            this.labelMode.Tag = "custom";
            this.labelMode.Text = "ALTHOLD";
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModeControl
            // 
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.btnLOITER);
            this.Controls.Add(this.btnAUTO);
            this.Controls.Add(this.labelMode);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ModeControl";
            this.Size = new System.Drawing.Size(350, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLOITER;
        private System.Windows.Forms.Button btnAUTO;
        private System.Windows.Forms.Label labelMode;
    }
}
