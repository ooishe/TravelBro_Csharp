using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel;

namespace TravelBro
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void adminLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adminId = textBox1.Text.Trim();
            string adminPass = textBox2.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(adminId) || string.IsNullOrEmpty(adminPass))
            {
                MessageBox.Show("Please enter both Admin ID and Password.");
                return;
            }

            // Database connection
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FS3OVK5Q\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    con.Open();

                    // Prepare the query to check admin credentials
                    string query = "SELECT COUNT(*) FROM admin_info WHERE ad_id = @adId AND ad_pass = @adPass";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@adId", adminId);
                        cmd.Parameters.AddWithValue("@adPass", adminPass);

                        // Execute the query
                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            MessageBox.Show("Login Successful!");
                            // Proceed to the next form or admin dashboard
                            AdminDashboard ad = new AdminDashboard();
                            ad.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Admin ID or Password. Please try again.");

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
