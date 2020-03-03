namespace A20_Ex02_Ilan_302634654_Guy_310065362
{
    partial class UI_PhotoFeatureSearce
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

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_PhotoFeatureSearce));
            this.returnHomeButton = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.searchFeatureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.matchingPhotoList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // returnHomeButton
            // 
            this.returnHomeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.returnHomeButton.Location = new System.Drawing.Point(658, 12);
            this.returnHomeButton.Name = "returnHomeButton";
            this.returnHomeButton.Size = new System.Drawing.Size(104, 23);
            this.returnHomeButton.TabIndex = 2;
            this.returnHomeButton.Text = "Return Home";
            this.returnHomeButton.UseVisualStyleBackColor = false;
            this.returnHomeButton.Click += new System.EventHandler(this.returnHomeButton_Click);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(110, 115);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(432, 20);
            this.searchInput.TabIndex = 3;
            // 
            // searchFeatureButton
            // 
            this.searchFeatureButton.Location = new System.Drawing.Point(574, 114);
            this.searchFeatureButton.Name = "searchFeatureButton";
            this.searchFeatureButton.Size = new System.Drawing.Size(87, 21);
            this.searchFeatureButton.TabIndex = 4;
            this.searchFeatureButton.Text = "Search Photos";
            this.searchFeatureButton.UseVisualStyleBackColor = true;
            this.searchFeatureButton.Click += new System.EventHandler(this.searchFeatureButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search tagged photos for:";
            // 
            // matchingPhotoList
            // 
            this.matchingPhotoList.FormattingEnabled = true;
            this.matchingPhotoList.Location = new System.Drawing.Point(110, 157);
            this.matchingPhotoList.Name = "matchingPhotoList";
            this.matchingPhotoList.Size = new System.Drawing.Size(550, 225);
            this.matchingPhotoList.TabIndex = 6;
            // 
            // UI_PhotoFeatureSearce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.matchingPhotoList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchFeatureButton);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.returnHomeButton);
            this.Name = "UI_PhotoFeatureSearce";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button returnHomeButton;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Button searchFeatureButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox matchingPhotoList;
    }
}