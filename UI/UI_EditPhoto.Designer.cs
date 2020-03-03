namespace FirstFBApp
{
    partial class UI_EditPhoto
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.slider = new System.Windows.Forms.TrackBar();
            this.radioBrightness = new System.Windows.Forms.RadioButton();
            this.radioContrast = new System.Windows.Forms.RadioButton();
            this.radioBlur = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioManual = new System.Windows.Forms.RadioButton();
            this.radioFilters = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioSepia = new System.Windows.Forms.RadioButton();
            this.radioPolaroid = new System.Windows.Forms.RadioButton();
            this.radioGotham = new System.Windows.Forms.RadioButton();
            this.radioComic = new System.Windows.Forms.RadioButton();
            this.radioBlackAndWhite = new System.Windows.Forms.RadioButton();
            this.returnHomeButtonButton = new System.Windows.Forms.Button();
            this.downloadPictureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(503, 94);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(732, 436);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.SystemColors.Window;
            this.slider.Location = new System.Drawing.Point(503, 533);
            this.slider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slider.Maximum = 100;
            this.slider.Minimum = -100;
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(732, 56);
            this.slider.TabIndex = 1;
            this.slider.Scroll += new System.EventHandler(this.slider_Scroll);
            // 
            // radioBrightness
            // 
            this.radioBrightness.AutoSize = true;
            this.radioBrightness.Location = new System.Drawing.Point(20, 26);
            this.radioBrightness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBrightness.Name = "radioBrightness";
            this.radioBrightness.Size = new System.Drawing.Size(96, 21);
            this.radioBrightness.TabIndex = 2;
            this.radioBrightness.TabStop = true;
            this.radioBrightness.Text = "Brightness";
            this.radioBrightness.UseVisualStyleBackColor = true;
            this.radioBrightness.CheckedChanged += new System.EventHandler(this.radioBrightness_CheckedChanged);
            // 
            // radioContrast
            // 
            this.radioContrast.AutoSize = true;
            this.radioContrast.Location = new System.Drawing.Point(20, 113);
            this.radioContrast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioContrast.Name = "radioContrast";
            this.radioContrast.Size = new System.Drawing.Size(82, 21);
            this.radioContrast.TabIndex = 3;
            this.radioContrast.TabStop = true;
            this.radioContrast.Text = "Contrast";
            this.radioContrast.UseVisualStyleBackColor = true;
            this.radioContrast.CheckedChanged += new System.EventHandler(this.radioContrast_CheckedChanged);
            // 
            // radioBlur
            // 
            this.radioBlur.AutoSize = true;
            this.radioBlur.Location = new System.Drawing.Point(20, 199);
            this.radioBlur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBlur.Name = "radioBlur";
            this.radioBlur.Size = new System.Drawing.Size(54, 21);
            this.radioBlur.TabIndex = 4;
            this.radioBlur.TabStop = true;
            this.radioBlur.Text = "Blur";
            this.radioBlur.UseVisualStyleBackColor = true;
            this.radioBlur.CheckedChanged += new System.EventHandler(this.radioBlur_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioManual);
            this.panel1.Controls.Add(this.radioFilters);
            this.panel1.Location = new System.Drawing.Point(57, 134);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 59);
            this.panel1.TabIndex = 5;
            // 
            // radioManual
            // 
            this.radioManual.AutoSize = true;
            this.radioManual.Location = new System.Drawing.Point(241, 18);
            this.radioManual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioManual.Name = "radioManual";
            this.radioManual.Size = new System.Drawing.Size(75, 21);
            this.radioManual.TabIndex = 1;
            this.radioManual.TabStop = true;
            this.radioManual.Text = "Manual";
            this.radioManual.UseVisualStyleBackColor = true;
            this.radioManual.CheckedChanged += new System.EventHandler(this.Manual_CheckedChanged);
            // 
            // radioFilters
            // 
            this.radioFilters.AutoSize = true;
            this.radioFilters.Location = new System.Drawing.Point(19, 18);
            this.radioFilters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioFilters.Name = "radioFilters";
            this.radioFilters.Size = new System.Drawing.Size(67, 21);
            this.radioFilters.TabIndex = 0;
            this.radioFilters.TabStop = true;
            this.radioFilters.Text = "Filters";
            this.radioFilters.UseVisualStyleBackColor = true;
            this.radioFilters.CheckedChanged += new System.EventHandler(this.radioFilters_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioBlur);
            this.panel2.Controls.Add(this.radioContrast);
            this.panel2.Controls.Add(this.radioBrightness);
            this.panel2.Location = new System.Drawing.Point(279, 223);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 253);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.radioSepia);
            this.panel3.Controls.Add(this.radioPolaroid);
            this.panel3.Controls.Add(this.radioGotham);
            this.panel3.Controls.Add(this.radioComic);
            this.panel3.Controls.Add(this.radioBlackAndWhite);
            this.panel3.Location = new System.Drawing.Point(57, 223);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 253);
            this.panel3.TabIndex = 7;
            // 
            // radioSepia
            // 
            this.radioSepia.AutoSize = true;
            this.radioSepia.Location = new System.Drawing.Point(21, 199);
            this.radioSepia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioSepia.Name = "radioSepia";
            this.radioSepia.Size = new System.Drawing.Size(65, 21);
            this.radioSepia.TabIndex = 4;
            this.radioSepia.TabStop = true;
            this.radioSepia.Text = "Sepia";
            this.radioSepia.UseVisualStyleBackColor = true;
            this.radioSepia.CheckedChanged += new System.EventHandler(this.radioSepia_CheckedChanged);
            // 
            // radioPolaroid
            // 
            this.radioPolaroid.AutoSize = true;
            this.radioPolaroid.Location = new System.Drawing.Point(21, 154);
            this.radioPolaroid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioPolaroid.Name = "radioPolaroid";
            this.radioPolaroid.Size = new System.Drawing.Size(81, 21);
            this.radioPolaroid.TabIndex = 3;
            this.radioPolaroid.TabStop = true;
            this.radioPolaroid.Text = "Polaroid";
            this.radioPolaroid.UseVisualStyleBackColor = true;
            this.radioPolaroid.CheckedChanged += new System.EventHandler(this.radioPolaroid_CheckedChanged);
            // 
            // radioGotham
            // 
            this.radioGotham.AutoSize = true;
            this.radioGotham.Location = new System.Drawing.Point(21, 113);
            this.radioGotham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioGotham.Name = "radioGotham";
            this.radioGotham.Size = new System.Drawing.Size(79, 21);
            this.radioGotham.TabIndex = 2;
            this.radioGotham.TabStop = true;
            this.radioGotham.Text = "Gotham";
            this.radioGotham.UseVisualStyleBackColor = true;
            this.radioGotham.CheckedChanged += new System.EventHandler(this.radioGotham_CheckedChanged);
            // 
            // radioComic
            // 
            this.radioComic.AutoSize = true;
            this.radioComic.Location = new System.Drawing.Point(21, 68);
            this.radioComic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioComic.Name = "radioComic";
            this.radioComic.Size = new System.Drawing.Size(67, 21);
            this.radioComic.TabIndex = 1;
            this.radioComic.TabStop = true;
            this.radioComic.Text = "Comic";
            this.radioComic.UseVisualStyleBackColor = true;
            this.radioComic.CheckedChanged += new System.EventHandler(this.Comic_CheckedChanged);
            // 
            // radioBlackAndWhite
            // 
            this.radioBlackAndWhite.AutoSize = true;
            this.radioBlackAndWhite.Location = new System.Drawing.Point(21, 26);
            this.radioBlackAndWhite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBlackAndWhite.Name = "radioBlackAndWhite";
            this.radioBlackAndWhite.Size = new System.Drawing.Size(131, 21);
            this.radioBlackAndWhite.TabIndex = 0;
            this.radioBlackAndWhite.TabStop = true;
            this.radioBlackAndWhite.Text = "Black and White";
            this.radioBlackAndWhite.UseVisualStyleBackColor = true;
            this.radioBlackAndWhite.CheckedChanged += new System.EventHandler(this.radioBlackAndWhite_CheckedChanged);
            // 
            // returnHomeButtonButton
            // 
            this.returnHomeButtonButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnHomeButtonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.returnHomeButtonButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.returnHomeButtonButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.returnHomeButtonButton.Location = new System.Drawing.Point(1099, 14);
            this.returnHomeButtonButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnHomeButtonButton.Name = "returnHomeButtonButton";
            this.returnHomeButtonButton.Size = new System.Drawing.Size(136, 43);
            this.returnHomeButtonButton.TabIndex = 8;
            this.returnHomeButtonButton.Text = "Return Home";
            this.returnHomeButtonButton.UseVisualStyleBackColor = false;
            this.returnHomeButtonButton.Click += new System.EventHandler(this.returnHomeButtonButton_Click);
            // 
            // downloadPictureButton
            // 
            this.downloadPictureButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.downloadPictureButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.downloadPictureButton.Location = new System.Drawing.Point(105, 506);
            this.downloadPictureButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downloadPictureButton.Name = "downloadPictureButton";
            this.downloadPictureButton.Size = new System.Drawing.Size(276, 57);
            this.downloadPictureButton.TabIndex = 9;
            this.downloadPictureButton.Text = "Download Picture";
            this.downloadPictureButton.UseVisualStyleBackColor = false;
            this.downloadPictureButton.Click += new System.EventHandler(this.downloadPictureButton_Click);
            // 
            // UI_EditPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A20_Ex01_Ilan_302634654_Guy_310065362.Properties.Resources.background_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1271, 658);
            this.Controls.Add(this.downloadPictureButton);
            this.Controls.Add(this.returnHomeButtonButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UI_EditPhoto";
            this.Text = "UI_EditPhoto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.RadioButton radioBrightness;
        private System.Windows.Forms.RadioButton radioContrast;
        private System.Windows.Forms.RadioButton radioBlur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioFilters;
        private System.Windows.Forms.RadioButton radioManual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioSepia;
        private System.Windows.Forms.RadioButton radioPolaroid;
        private System.Windows.Forms.RadioButton radioGotham;
        private System.Windows.Forms.RadioButton radioComic;
        private System.Windows.Forms.RadioButton radioBlackAndWhite;
        private System.Windows.Forms.Button returnHomeButtonButton;
        private System.Windows.Forms.Button downloadPictureButton;
    }
}