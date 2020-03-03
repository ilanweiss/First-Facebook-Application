using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FirstFBApp
{

    public partial class UI_CollageMainForm : Form
    {

       private User m_user;
        List<Album> m_album_list = new List<Album>();

        public UI_CollageMainForm(User i_user)
        {
            m_user = i_user;

            foreach (Album album in m_user.Albums)
            {
                m_album_list.Add(album);
            }
            
            InitializeComponent();
            AlbumListBox.DataSource = m_album_list;
            AlbumCollageBoolean.Checked = true;
        }

        private CollageData.eCollageType GetUserChoice()
        {
            return (CollageData.eCollageType)panelCollageTypeChoice.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).TabIndex;
        }


        private void makeCollageButton_Click(object sender, EventArgs e)
        {
            // gets the collage Image.
            Bitmap finalCollageBitmap = Logic_CollageMain.getCollagePicture(m_user, (Album) AlbumListBox.SelectedItem, AlbumCollageBoolean.Checked,((int)GetUserChoice()));

            // Displays the Image.
            Form collageViewFinalPhoto = new UI_CollageViewForm(finalCollageBitmap);
            collageViewFinalPhoto.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            collageViewFinalPhoto.ShowDialog();
            this.Close();
        }

        private void returnHomeButtonButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlbumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            albumBindingSource.DataSource = AlbumListBox.SelectedItem;
        }
    }
}
