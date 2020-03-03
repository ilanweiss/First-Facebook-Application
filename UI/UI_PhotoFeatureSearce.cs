using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_Ex02_Ilan_302634654_Guy_310065362
{
    public partial class UI_PhotoFeatureSearce : Form
    {
        public UI_PhotoFeatureSearce(User i_user)
        {
            m_user = i_user;
            InitializeComponent();
        }

        User m_user;
        string m_searctTerm;


        private void returnHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchFeatureButton_Click(object sender, EventArgs e)
        {
            // proxy to send the url to the microsoft service
            m_searctTerm = searchInput.Text;

        }
    }
}
