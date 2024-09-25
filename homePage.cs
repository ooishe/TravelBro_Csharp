using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel;

namespace TravelBro
{
    public partial class homePage : Form
    {
        private string userId;  // Store the logged-in user's ID
        public homePage(string userId)
        {
            InitializeComponent();
            this.userId = userId;

            // Display a welcome message with the user's ID
            label1.Text = $"Welcome {userId}!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Show();
            this.Hide();
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customer_prepack prePack = new customer_prepack(userId);  // Pass userId to CustomPack
            prePack.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customPack cusPack = new customPack(userId);  // Pass userId to CustomPack
            cusPack.Show();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            aboutus ab = new aboutus();
            ab.Show();
            this.Hide();
        }
    }
}
