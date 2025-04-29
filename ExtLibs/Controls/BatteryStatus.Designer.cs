namespace MissionPlanner.Controls
{
    partial class BatteryStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatteryStatus));
            this.label1 = new System.Windows.Forms.Label();
            this.temp1 = new System.Windows.Forms.Label();
            this.temp2 = new System.Windows.Forms.Label();
            this.charge2 = new System.Windows.Forms.Label();
            this.charge1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.volt1 = new System.Windows.Forms.Label();
            this.volt2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "BATTERY";
            // 
            // temp1
            // 
            this.temp1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp1.ForeColor = System.Drawing.Color.SpringGreen;
            this.temp1.Location = new System.Drawing.Point(24, 73);
            this.temp1.Name = "temp1";
            this.temp1.Size = new System.Drawing.Size(91, 46);
            this.temp1.TabIndex = 4;
            this.temp1.Tag = "custom";
            this.temp1.Text = "45.0";
            this.temp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temp2
            // 
            this.temp2.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp2.ForeColor = System.Drawing.Color.SpringGreen;
            this.temp2.Location = new System.Drawing.Point(159, 73);
            this.temp2.Name = "temp2";
            this.temp2.Size = new System.Drawing.Size(91, 46);
            this.temp2.TabIndex = 5;
            this.temp2.Tag = "custom";
            this.temp2.Text = "52.0";
            this.temp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charge2
            // 
            this.charge2.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charge2.ForeColor = System.Drawing.Color.SpringGreen;
            this.charge2.Location = new System.Drawing.Point(159, 123);
            this.charge2.Name = "charge2";
            this.charge2.Size = new System.Drawing.Size(91, 46);
            this.charge2.TabIndex = 11;
            this.charge2.Tag = "custom";
            this.charge2.Text = "83.3";
            this.charge2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // charge1
            // 
            this.charge1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charge1.ForeColor = System.Drawing.Color.SpringGreen;
            this.charge1.Location = new System.Drawing.Point(24, 123);
            this.charge1.Name = "charge1";
            this.charge1.Size = new System.Drawing.Size(91, 46);
            this.charge1.TabIndex = 10;
            this.charge1.Tag = "custom";
            this.charge1.Text = "88.8";
            this.charge1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(295, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 21);
            this.label14.TabIndex = 17;
            this.label14.Text = "[V]";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(293, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 21);
            this.label15.TabIndex = 16;
            this.label15.Text = "[%]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(292, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "[℃]";
            // 
            // volt1
            // 
            this.volt1.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volt1.ForeColor = System.Drawing.Color.SpringGreen;
            this.volt1.Location = new System.Drawing.Point(24, 173);
            this.volt1.Name = "volt1";
            this.volt1.Size = new System.Drawing.Size(91, 46);
            this.volt1.TabIndex = 19;
            this.volt1.Tag = "custom";
            this.volt1.Text = "48.7";
            this.volt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volt2
            // 
            this.volt2.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volt2.ForeColor = System.Drawing.Color.SpringGreen;
            this.volt2.Location = new System.Drawing.Point(159, 173);
            this.volt2.Name = "volt2";
            this.volt2.Size = new System.Drawing.Size(91, 46);
            this.volt2.TabIndex = 21;
            this.volt2.Tag = "custom";
            this.volt2.Text = "48.8";
            this.volt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(273, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 102);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(138, 40);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 200);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // BatteryStatus
            // 
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.volt2);
            this.Controls.Add(this.volt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.charge2);
            this.Controls.Add(this.charge1);
            this.Controls.Add(this.temp2);
            this.Controls.Add(this.temp1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BatteryStatus";
            this.Size = new System.Drawing.Size(349, 258);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label temp1;
        private System.Windows.Forms.Label temp2;
        private System.Windows.Forms.Label charge2;
        private System.Windows.Forms.Label charge1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label volt1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label volt2;
    }
}
