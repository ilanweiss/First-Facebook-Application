namespace FirstFBApp
{
    partial class UI_CollageViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_CollageViewForm));
            this.downloadPictureButton = new System.Windows.Forms.Button();
            this.returnHomeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadPictureButton
            // 
            this.downloadPictureButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.downloadPictureButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.downloadPictureButton.Location = new System.Drawing.Point(390, 649);
            this.downloadPictureButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downloadPictureButton.Name = "downloadPictureButton";
            this.downloadPictureButton.Size = new System.Drawing.Size(207, 46);
            this.downloadPictureButton.TabIndex = 0;
            this.downloadPictureButton.Text = "Download Collage Picture";
            this.downloadPictureButton.UseVisualStyleBackColor = false;
            this.downloadPictureButton.Click += new System.EventHandler(this.downloadPictureButton_Click);
            // 
            // returnHomeButton
            // 
            this.returnHomeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnHomeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.returnHomeButton.Location = new System.Drawing.Point(882, 18);
            this.returnHomeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnHomeButton.Name = "returnHomeButton";
            this.returnHomeButton.Size = new System.Drawing.Size(141, 50);
            this.returnHomeButton.TabIndex = 2;
            this.returnHomeButton.Text = "Return HomePage";
            this.returnHomeButton.UseVisualStyleBackColor = false;
            this.returnHomeButton.Click += new System.EventHandler(this.returnHomeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(982, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UI_CollageViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 706);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.returnHomeButton);
            this.Controls.Add(this.downloadPictureButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "UI_CollageViewForm";
            this.Text = "CollageView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button downloadPictureButton;
        private System.Windows.Forms.Button returnHomeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}