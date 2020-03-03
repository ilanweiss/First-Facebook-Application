namespace FirstFBApp
{
    partial class UI_LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_LoginForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.checkRemeberMe = new System.Windows.Forms.CheckBox();
            this.pictureBoxUserProfilePictur = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfilePictur)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.loginButton.ForeColor = System.Drawing.Color.FloralWhite;
            this.loginButton.Location = new System.Drawing.Point(107, 225);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(171, 42);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // checkRemeberMe
            // 
            this.checkRemeberMe.AutoSize = true;
            this.checkRemeberMe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkRemeberMe.Location = new System.Drawing.Point(120, 273);
            this.checkRemeberMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkRemeberMe.Name = "checkRemeberMe";
            this.checkRemeberMe.Size = new System.Drawing.Size(111, 21);
            this.checkRemeberMe.TabIndex = 1;
            this.checkRemeberMe.Text = "Remeber Me";
            this.checkRemeberMe.UseVisualStyleBackColor = false;
            this.checkRemeberMe.CheckedChanged += new System.EventHandler(this.checkRemeberMe_CheckedChanged);
            // 
            // pictureBoxUserProfilePictur
            // 
            this.pictureBoxUserProfilePictur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUserProfilePictur.BackgroundImage")));
            this.pictureBoxUserProfilePictur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUserProfilePictur.Location = new System.Drawing.Point(125, 86);
            this.pictureBoxUserProfilePictur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxUserProfilePictur.Name = "pictureBoxUserProfilePictur";
            this.pictureBoxUserProfilePictur.Size = new System.Drawing.Size(125, 114);
            this.pictureBoxUserProfilePictur.TabIndex = 2;
            this.pictureBoxUserProfilePictur.TabStop = false;
            // 
            // UI_LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(383, 359);
            this.Controls.Add(this.pictureBoxUserProfilePictur);
            this.Controls.Add(this.checkRemeberMe);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "UI_LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfilePictur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox checkRemeberMe;
        private System.Windows.Forms.PictureBox pictureBoxUserProfilePictur;
    }
}