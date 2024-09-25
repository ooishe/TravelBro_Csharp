using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelBro;

namespace TravelBro
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminLogin adminForm = new adminLogin();
            adminForm.Show();
            Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            agencyLogin agencyForm1 = new agencyLogin();
            agencyForm1.Show();
            Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login user1 = new login();
            user1.Show();
            Visible=false;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup user2 = new signup();
            user2.Show();
            Visible=false;
        }
    }
}
