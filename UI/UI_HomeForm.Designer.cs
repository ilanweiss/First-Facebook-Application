namespace FirstFBApp
{
    partial class UI_HomeForm
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
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_HomeForm));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonOpenPhotoEditor = new System.Windows.Forms.Button();
            this.buttonCollageMaker = new System.Windows.Forms.Button();
            this.buttonFBExpiriance = new System.Windows.Forms.Button();
            this.pictureBoxUserProfilePicHome = new System.Windows.Forms.PictureBox();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfilePicHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            birthdayLabel.Location = new System.Drawing.Point(164, 83);
            birthdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 11;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            emailLabel.Location = new System.Drawing.Point(164, 102);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            linkLabel.Location = new System.Drawing.Point(164, 120);
            linkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(30, 13);
            linkLabel.TabIndex = 15;
            linkLabel.Text = "Link:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            nameLabel.Location = new System.Drawing.Point(164, 64);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 17;
            nameLabel.Text = "Name:";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLogout.Location = new System.Drawing.Point(326, 9);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(88, 24);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonOpenPhotoEditor
            // 
            this.buttonOpenPhotoEditor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOpenPhotoEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOpenPhotoEditor.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonOpenPhotoEditor.Location = new System.Drawing.Point(296, 224);
            this.buttonOpenPhotoEditor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpenPhotoEditor.Name = "buttonOpenPhotoEditor";
            this.buttonOpenPhotoEditor.Size = new System.Drawing.Size(123, 56);
            this.buttonOpenPhotoEditor.TabIndex = 7;
            this.buttonOpenPhotoEditor.Text = "Edit Photos";
            this.buttonOpenPhotoEditor.UseVisualStyleBackColor = false;
            this.buttonOpenPhotoEditor.Click += new System.EventHandler(this.buttonPhotoEditor_Click);
            // 
            // buttonCollageMaker
            // 
            this.buttonCollageMaker.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCollageMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCollageMaker.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonCollageMaker.Location = new System.Drawing.Point(152, 224);
            this.buttonCollageMaker.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCollageMaker.Name = "buttonCollageMaker";
            this.buttonCollageMaker.Size = new System.Drawing.Size(124, 56);
            this.buttonCollageMaker.TabIndex = 6;
            this.buttonCollageMaker.Text = "Collage Maker";
            this.buttonCollageMaker.UseVisualStyleBackColor = false;
            this.buttonCollageMaker.Click += new System.EventHandler(this.buttonCollageMaker_Click);
            // 
            // buttonFBExpiriance
            // 
            this.buttonFBExpiriance.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonFBExpiriance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFBExpiriance.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonFBExpiriance.Location = new System.Drawing.Point(17, 224);
            this.buttonFBExpiriance.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFBExpiriance.Name = "buttonFBExpiriance";
            this.buttonFBExpiriance.Size = new System.Drawing.Size(116, 56);
            this.buttonFBExpiriance.TabIndex = 9;
            this.buttonFBExpiriance.Text = "Facebook  Experience";
            this.buttonFBExpiriance.UseVisualStyleBackColor = false;
            this.buttonFBExpiriance.Click += new System.EventHandler(this.buttonFBExpiriance_Click);
            // 
            // pictureBoxUserProfilePicHome
            // 
            this.pictureBoxUserProfilePicHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserProfilePicHome.BackgroundImage")));
            this.pictureBoxUserProfilePicHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUserProfilePicHome.Location = new System.Drawing.Point(17, 58);
            this.pictureBoxUserProfilePicHome.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUserProfilePicHome.Name = "pictureBoxUserProfilePicHome";
            this.pictureBoxUserProfilePicHome.Size = new System.Drawing.Size(140, 153);
            this.pictureBoxUserProfilePicHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUserProfilePicHome.TabIndex = 10;
            this.pictureBoxUserProfilePicHome.TabStop = false;
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(216, 83);
            this.birthdayLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(203, 19);
            this.birthdayLabel1.TabIndex = 12;
            this.birthdayLabel1.Text = "label1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLinkLabel.Location = new System.Drawing.Point(216, 102);
            this.emailLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(203, 19);
            this.emailLinkLabel.TabIndex = 14;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "linkLabel1";
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(216, 120);
            this.linkLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(203, 19);
            this.linkLinkLabel.TabIndex = 16;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "linkLabel1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(216, 64);
            this.nameLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(203, 19);
            this.nameLabel1.TabIndex = 18;
            this.nameLabel1.Text = "label1";
            // 
            // UI_HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 327);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayLabel1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailLinkLabel);
            this.Controls.Add(linkLabel);
            this.Controls.Add(this.linkLinkLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.pictureBoxUserProfilePicHome);
            this.Controls.Add(this.buttonFBExpiriance);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonOpenPhotoEditor);
            this.Controls.Add(this.buttonCollageMaker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "UI_HomeForm";
            this.Text = "UI_HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfilePicHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonOpenPhotoEditor;
        private System.Windows.Forms.Button buttonCollageMaker;
        private System.Windows.Forms.Button buttonFBExpiriance;
        private System.Windows.Forms.PictureBox pictureBoxUserProfilePicHome;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.LinkLabel emailLinkLabel;
        private System.Windows.Forms.LinkLabel linkLinkLabel;
        private System.Windows.Forms.Label nameLabel1;
    }
}