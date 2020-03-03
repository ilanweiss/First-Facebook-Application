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
    public partial class UI_ChoosePhotoForm : Form
    {
        private User m_user;
        List<Album> m_album_list = new List<Album>();

        public UI_ChoosePhotoForm(User i_user)
        {
            InitializeComponent();

            m_user = i_user;
            foreach (Album album in m_user.Albums)
            {
                m_album_list.Add(album);
            }
            listBoxAlbums.DataSource = m_album_list;
        }

        private void buttonReturnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditPhoto_Click(object sender, EventArgs e)
        {
            int chosenImageIndex = panelPhotoView.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).TabIndex;
            LazyPictureBox chosenLazyPictureBox = panelPhotoView.Controls.OfType<LazyPictureBox>().ElementAt(chosenImageIndex);
            Image chosenImage = chosenLazyPictureBox.Image;
            Form picEditor = new UI_EditPhoto(chosenImage);
            this.Close();
            picEditor.ShowDialog();
        }
        
        private LazyPictureBox albumPhoto; 
        private RadioButton photoRadio;

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelPhotoView.Controls.Clear();
            int tabIdx = 0;
            int top = 3;
            int left = 3;
            Album m_SelectedAlbum = (Album)listBoxAlbums.SelectedItem;
            foreach (Photo photo in m_SelectedAlbum.Photos)
            {
                albumPhoto = new LazyPictureBox();
                photoRadio = new RadioButton();
                photoRadio.TabIndex = tabIdx;
               
                this.albumPhoto.Size = new System.Drawing.Size(85, 85);
                this.albumPhoto.Left = left;
                albumPhoto.Top = top;
                photoRadio.SetBounds(albumPhoto.Right + 7, (albumPhoto.Top + albumPhoto.Bottom) / 2, 15, 15);
                albumPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                albumPhoto.Load(photo.PictureNormalURL);
                albumPhoto.Paint += new PaintEventHandler(albumPhoto_Paint);
                photoRadio.CheckedChanged += new System.EventHandler(photoRadio_CheckedChanged);
                
                panelPhotoView.Controls.Add(albumPhoto);
                panelPhotoView.Controls.Add(photoRadio);

                if (left > 300)
                {
                    top = albumPhoto.Bottom + 5;
                    left = 3;
                }
                else
                {
                    left = albumPhoto.Right + 30;
                }
                photoRadio.Image = albumPhoto.Image;

                tabIdx++;
            }
        }

        private void photoRadio_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public class LazyPictureBox : PictureBox
        {
            public string URL { get; set; }

            public void Load(string i_UrlToLoad)
            {
                URL = i_UrlToLoad;
            }

            protected override void OnPaint(PaintEventArgs pe)
            {
                if(base.ImageLocation == null)
                {
                    base.Load(this.URL);
                }

                base.OnPaint(pe);
            }
        }
        void albumPhoto_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
