using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;


namespace FirstFBApp
{
    public partial class UI_EditPhoto : Form
    {

        private int m_brightness = 0;
        private int m_contrast = 0;
        private int m_blur = 0;

        Image m_originalImage;
        Image m_presentedImage;

        public UI_EditPhoto(Image i_chosenImage)
        {
            InitializeComponent();
            radioFilters.Checked = true;
            panel2.Enabled = false;
            m_originalImage = i_chosenImage;
            pictureBox.Image = m_originalImage;
        }


        private void slider_Scroll(object sender, EventArgs e)
        {

            if(radioBrightness.Checked)
            {
                m_brightness = slider.Value;
            } else if (radioContrast.Checked)
            {
                m_contrast = slider.Value;
            } else if (radioBlur.Checked)
            {
                m_blur = slider.Value;
            }

            m_presentedImage = Logic_EditPhoto.changeAndPresentFilters(m_originalImage , m_brightness, m_contrast, m_blur);

            pictureBox.Image = m_presentedImage;
        }

        private void radioBrightness_CheckedChanged(object sender, EventArgs e)
        {
            slider.Value = m_brightness;
        }

        private void radioContrast_CheckedChanged(object sender, EventArgs e)
        {
            slider.Value = m_contrast;
        }

        private void radioBlur_CheckedChanged(object sender, EventArgs e)
        {
            slider.Value = m_blur;
        }

        private void radioFilters_CheckedChanged(object sender, EventArgs e)
        {
            if(radioFilters.Checked)
            {
                panel3.Enabled = true;
                slider.Enabled = false;
            } else
            {
                panel3.Enabled = false;
            }
        }

        private void Manual_CheckedChanged(object sender, EventArgs e)
        {
            if (radioManual.Checked)
            {
                panel2.Enabled = true;
                slider.Enabled = true;
            }
            else
            {
                panel2.Enabled = false;
                slider.Enabled = false;
            }
        }


        private void radioBlackAndWhite_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlackAndWhite.Checked)
            {
                m_presentedImage = Logic_EditPhoto.blackWhiteFilter(m_originalImage);
                pictureBox.Image = m_presentedImage;
            }
        }

        private void Comic_CheckedChanged(object sender, EventArgs e)
        {
            if (radioComic.Checked)
            {
                m_presentedImage = Logic_EditPhoto.comicFilter(m_originalImage);
                pictureBox.Image = m_presentedImage;
            }
        }

        private void radioGotham_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGotham.Checked)
            {
                m_presentedImage = Logic_EditPhoto.gothamFilter(m_originalImage);
                pictureBox.Image = m_presentedImage;
            }
        }

        private void radioPolaroid_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPolaroid.Checked)
            {
                m_presentedImage = Logic_EditPhoto.polaroidFilter(m_originalImage);
                pictureBox.Image = m_presentedImage;
            }
        }

        private void radioSepia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSepia.Checked)
            {
                m_presentedImage = Logic_EditPhoto.sepiaFilter(m_originalImage);
                pictureBox.Image = m_presentedImage;
            }
        }

        private void returnHomeButtonButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void downloadPictureButton_Click(object sender, EventArgs e)
        {
            Logic_CollageView.saveCollage(m_presentedImage);
        }
    }
}
