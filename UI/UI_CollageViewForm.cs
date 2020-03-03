using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using Facebook;

namespace FirstFBApp
{
    public partial class UI_CollageViewForm : Form
    {
      private Image m_collage;

        public UI_CollageViewForm(Image i_collage)
        {
            m_collage = i_collage;
            InitializeComponent();

            
            pictureBox1.Image = m_collage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }



        private void returnHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void downloadPictureButton_Click(object sender, EventArgs e)
        {
            Logic_CollageView.saveCollage(m_collage);
        }
    }
}
