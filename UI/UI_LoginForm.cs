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
    public partial class UI_LoginForm : Form
    {
        AppSettings m_AppSettings = new AppSettings();
        LoginResult m_LoginResult;
        private User m_LoggedInUser;

        public UI_LoginForm()
        {
            InitializeComponent();

            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkRemeberMe.Checked = m_AppSettings.RememberUser;

            if(m_AppSettings.RememberUser 
                && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
            {
                m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
            }

            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

       

        private void checkRemeberMe_CheckedChanged(object sender, EventArgs e)
        {
            m_AppSettings.RememberUser = checkRemeberMe.Checked;
        }

        private void loginAndInit()
        {

            fetchLoginResult();
                
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage);
            }
        }

        private void fetchLoginResult()
        {
            m_LoginResult = FacebookService.Login("2439554226313983", 
                "public_profile",
                "email",
                "publish_to_groups",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_videos",
                "publish_to_groups",
                "groups_access_member_info",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown"
                //"user_relationships"
            );

            m_LoggedInUser = m_LoginResult.LoggedInUser;
        }

        private void fetchUserInfo()
        {
            pictureBoxUserProfilePictur.LoadAsync(m_LoggedInUser.PictureNormalURL);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginAndInit();
            Form homeForm = new  UI_HomeForm(m_LoggedInUser);
            homeForm.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            homeForm.ShowDialog();
            this.Show();
        }
    }
}
