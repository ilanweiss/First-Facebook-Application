namespace FirstFBApp
{
    partial class UI_CollageMainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imageAlbumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_CollageMainForm));
            this.makeCollageButton = new System.Windows.Forms.Button();
            this.returnHomeButtonButton = new System.Windows.Forms.Button();
            this.AlbumListBox = new System.Windows.Forms.ListBox();
            this.AlbumCollageBoolean = new System.Windows.Forms.RadioButton();
            this.taggedRadioButton = new System.Windows.Forms.RadioButton();
            this.albumPictureBox = new System.Windows.Forms.PictureBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelCollageTypeChoice = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton6pic = new System.Windows.Forms.RadioButton();
            this.radioButton4pic = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            imageAlbumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.panelCollageTypeChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageAlbumLabel
            // 
            resources.ApplyResources(imageAlbumLabel, "imageAlbumLabel");
            imageAlbumLabel.Name = "imageAlbumLabel";
            // 
            // makeCollageButton
            // 
            this.makeCollageButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.makeCollageButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.makeCollageButton, "makeCollageButton");
            this.makeCollageButton.Name = "makeCollageButton";
            this.makeCollageButton.UseVisualStyleBackColor = false;
            this.makeCollageButton.Click += new System.EventHandler(this.makeCollageButton_Click);
            // 
            // returnHomeButtonButton
            // 
            this.returnHomeButtonButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.returnHomeButtonButton, "returnHomeButtonButton");
            this.returnHomeButtonButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.returnHomeButtonButton.Name = "returnHomeButtonButton";
            this.returnHomeButtonButton.UseVisualStyleBackColor = false;
            this.returnHomeButtonButton.Click += new System.EventHandler(this.returnHomeButtonButton_Click);
            // 
            // AlbumListBox
            // 
            this.AlbumListBox.FormattingEnabled = true;
            resources.ApplyResources(this.AlbumListBox, "AlbumListBox");
            this.AlbumListBox.Name = "AlbumListBox";
            this.AlbumListBox.SelectedIndexChanged += new System.EventHandler(this.AlbumListBox_SelectedIndexChanged);
            // 
            // AlbumCollageBoolean
            // 
            resources.ApplyResources(this.AlbumCollageBoolean, "AlbumCollageBoolean");
            this.AlbumCollageBoolean.Name = "AlbumCollageBoolean";
            this.AlbumCollageBoolean.TabStop = true;
            this.AlbumCollageBoolean.UseVisualStyleBackColor = true;
            // 
            // taggedRadioButton
            // 
            resources.ApplyResources(this.taggedRadioButton, "taggedRadioButton");
            this.taggedRadioButton.Name = "taggedRadioButton";
            this.taggedRadioButton.TabStop = true;
            this.taggedRadioButton.UseVisualStyleBackColor = true;
            // 
            // albumPictureBox
            // 
            this.albumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            resources.ApplyResources(this.albumPictureBox, "albumPictureBox");
            this.albumPictureBox.Name = "albumPictureBox";
            this.albumPictureBox.TabStop = false;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // panelCollageTypeChoice
            // 
            this.panelCollageTypeChoice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelCollageTypeChoice.Controls.Add(this.radioButton3);
            this.panelCollageTypeChoice.Controls.Add(this.radioButton6pic);
            this.panelCollageTypeChoice.Controls.Add(this.radioButton4pic);
            resources.ApplyResources(this.panelCollageTypeChoice, "panelCollageTypeChoice");
            this.panelCollageTypeChoice.Name = "panelCollageTypeChoice";
            // 
            // radioButton3
            // 
            resources.ApplyResources(this.radioButton3, "radioButton3");
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton6pic
            // 
            resources.ApplyResources(this.radioButton6pic, "radioButton6pic");
            this.radioButton6pic.Name = "radioButton6pic";
            this.radioButton6pic.UseVisualStyleBackColor = true;
            // 
            // radioButton4pic
            // 
            resources.ApplyResources(this.radioButton4pic, "radioButton4pic");
            this.radioButton4pic.Checked = true;
            this.radioButton4pic.Name = "radioButton4pic";
            this.radioButton4pic.TabStop = true;
            this.radioButton4pic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // UI_CollageMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelCollageTypeChoice);
            this.Controls.Add(this.albumPictureBox);
            this.Controls.Add(imageAlbumLabel);
            this.Controls.Add(this.taggedRadioButton);
            this.Controls.Add(this.AlbumCollageBoolean);
            this.Controls.Add(this.AlbumListBox);
            this.Controls.Add(this.returnHomeButtonButton);
            this.Controls.Add(this.makeCollageButton);
            this.MaximizeBox = false;
            this.Name = "UI_CollageMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.panelCollageTypeChoice.ResumeLayout(false);
            this.panelCollageTypeChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeCollageButton;
        private System.Windows.Forms.Button returnHomeButtonButton;
        private System.Windows.Forms.ListBox AlbumListBox;
        private System.Windows.Forms.RadioButton AlbumCollageBoolean;
        private System.Windows.Forms.RadioButton taggedRadioButton;
        private System.Windows.Forms.PictureBox albumPictureBox;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.Panel panelCollageTypeChoice;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton6pic;
        private System.Windows.Forms.RadioButton radioButton4pic;
        private System.Windows.Forms.Label label1;
    }
}