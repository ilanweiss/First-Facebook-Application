using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FirstFBApp
{
    public partial class UI_HomeForm : Form
    {
        private User m_LoggedInUser;

        public UI_HomeForm(User i_user)
        {
            InitializeComponent();
            m_LoggedInUser = i_user;
            pictureBoxUserProfilePicHome.LoadAsync(m_LoggedInUser.PictureNormalURL);
            userBindingSource.DataSource = m_LoggedInUser;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(null);
            this.Close();
        }

        private void buttonCollageMaker_Click(object sender, EventArgs e)
        {
            Form collageMainView = new UI_CollageMainForm(m_LoggedInUser);
            collageMainView.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            collageMainView.ShowDialog();
            this.Show();
        }

        private void buttonPhotoEditor_Click(object sender, EventArgs e)
        {
            Form editPhotosForm = new UI_ChoosePhotoForm(m_LoggedInUser);
            this.Hide();
            editPhotosForm.ShowDialog();

            this.Show();
        }
        private void buttonFBExpiriance_Click(object sender, EventArgs e)
        {
           // TODO: Form that displays basic FB features 
        }
    }
}
