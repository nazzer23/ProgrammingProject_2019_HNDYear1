namespace Assignment_Three.UI
{
    partial class Splash
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
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.appLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(12, 28);
            this.pbLoading.Maximum = 0;
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(581, 24);
            this.pbLoading.TabIndex = 0;
            // 
            // labelProgress
            // 
            this.labelProgress.Location = new System.Drawing.Point(12, 9);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(581, 17);
            this.labelProgress.TabIndex = 1;
            this.labelProgress.Text = "Progress Label";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // appLogo
            // 
            this.appLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.appLogo.Image = global::Assignment_Three.Properties.Resources.logo;
            this.appLogo.Location = new System.Drawing.Point(144, 58);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(319, 67);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.appLogo.TabIndex = 3;
            this.appLogo.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 162);
            this.ControlBox = false;
            this.Controls.Add(this.appLogo);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.pbLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.PictureBox appLogo;
    }
}

