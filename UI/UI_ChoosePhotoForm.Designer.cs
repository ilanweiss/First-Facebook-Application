namespace FirstFBApp
{
    partial class UI_ChoosePhotoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_ChoosePhotoForm));
            this.buttonReturnHome = new System.Windows.Forms.Button();
            this.buttonEditPhoto = new System.Windows.Forms.Button();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.labelChoosePhoto = new System.Windows.Forms.Label();
            this.Photos = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelPhotoView = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonReturnHome
            // 
            this.buttonReturnHome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReturnHome.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnHome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonReturnHome.Location = new System.Drawing.Point(857, 12);
            this.buttonReturnHome.Name = "buttonReturnHome";
            this.buttonReturnHome.Size = new System.Drawing.Size(168, 47);
            this.buttonReturnHome.TabIndex = 0;
            this.buttonReturnHome.Text = "Return Home";
            this.buttonReturnHome.UseVisualStyleBackColor = false;
            this.buttonReturnHome.Click += new System.EventHandler(this.buttonReturnHome_Click);
            // 
            // buttonEditPhoto
            // 
            this.buttonEditPhoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEditPhoto.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditPhoto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditPhoto.Location = new System.Drawing.Point(408, 523);
            this.buttonEditPhoto.Name = "buttonEditPhoto";
            this.buttonEditPhoto.Size = new System.Drawing.Size(168, 47);
            this.buttonEditPhoto.TabIndex = 1;
            this.buttonEditPhoto.Text = "Edit Photo";
            this.buttonEditPhoto.UseVisualStyleBackColor = false;
            this.buttonEditPhoto.Click += new System.EventHandler(this.buttonEditPhoto_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 16;
            this.listBoxAlbums.Location = new System.Drawing.Point(37, 168);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(250, 276);
            this.listBoxAlbums.TabIndex = 2;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAlbums.Location = new System.Drawing.Point(37, 145);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(103, 17);
            this.labelAlbums.TabIndex = 3;
            this.labelAlbums.Text = "Choose Album:";
            // 
            // labelChoosePhoto
            // 
            this.labelChoosePhoto.AutoSize = true;
            this.labelChoosePhoto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelChoosePhoto.Location = new System.Drawing.Point(309, 145);
            this.labelChoosePhoto.Name = "labelChoosePhoto";
            this.labelChoosePhoto.Size = new System.Drawing.Size(101, 17);
            this.labelChoosePhoto.TabIndex = 5;
            this.labelChoosePhoto.Text = "Choose Photo:";
            // 
            // Photos
            // 
            this.Photos.HeaderText = "";
            this.Photos.Name = "Photos";
            // 
            // panelPhotoView
            // 
            this.panelPhotoView.AutoScroll = true;
            this.panelPhotoView.BackColor = System.Drawing.Color.AliceBlue;
            this.panelPhotoView.Location = new System.Drawing.Point(312, 168);
            this.panelPhotoView.Name = "panelPhotoView";
            this.panelPhotoView.Size = new System.Drawing.Size(655, 276);
            this.panelPhotoView.TabIndex = 6;
            // 
            // UI_ChoosePhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 577);
            this.Controls.Add(this.panelPhotoView);
            this.Controls.Add(this.labelChoosePhoto);
            this.Controls.Add(this.labelAlbums);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.buttonEditPhoto);
            this.Controls.Add(this.buttonReturnHome);
            this.Name = "UI_ChoosePhotoForm";
            this.Text = "Choose Photo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnHome;
        private System.Windows.Forms.Button buttonEditPhoto;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.Label labelChoosePhoto;
        private System.Windows.Forms.DataGridViewImageColumn Photos;
        private System.Windows.Forms.Panel panelPhotoView;
    }
}