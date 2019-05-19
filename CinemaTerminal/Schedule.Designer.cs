namespace CinemaTerminal
{
    partial class Schedule
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.scheduleIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleIcon
            // 
            this.scheduleIcon.Image = ((System.Drawing.Image)(resources.GetObject("scheduleIcon.Image")));
            this.scheduleIcon.Location = new System.Drawing.Point(1494, 11);
            this.scheduleIcon.Margin = new System.Windows.Forms.Padding(2);
            this.scheduleIcon.Name = "scheduleIcon";
            this.scheduleIcon.Size = new System.Drawing.Size(30, 30);
            this.scheduleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.scheduleIcon.TabIndex = 10;
            this.scheduleIcon.TabStop = false;
            this.scheduleIcon.Click += new System.EventHandler(this.scheduleIcon_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 884);
            this.Controls.Add(this.scheduleIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.scheduleIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox scheduleIcon;
    }
}