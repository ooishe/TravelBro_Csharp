using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelBro;

namespace Travel
{
    public partial class aboutus : Form
    {
        private string userId;
        public aboutus()
        {
            InitializeComponent();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string htmlFilePath = @"D:\AboutUs.html"; // Replace with your HTML file path

            if (File.Exists(htmlFilePath))
            {
                string htmlContent = File.ReadAllText(htmlFilePath);
                richTextBox1.Text = htmlContent;
            }
            else
            {
                richTextBox1.Text = "HTML file not found!";
            }

        }

        private void lblAboutUs_Click(object sender, EventArgs e)
        {

        }

        private void lblAboutUs_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            homePage hp = new homePage(userId);
            hp.Show();
            this.Hide();
        }
    }
}
