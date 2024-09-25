using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelBro
{
    public partial class login : Form
    {
        string con = "Data Source=LAPTOP-FS3OVK5Q\\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False";
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||  // User ID
                string.IsNullOrWhiteSpace(textBox2.Text))    // Password
            {
                MessageBox.Show("Please enter data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get user input
            string u_id = textBox1.Text;
            string u_pass = textBox2.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();

                    // Query to check if the user exists with the given u_id and u_pass
                    string query = "SELECT COUNT(*) FROM user_info WHERE u_id = @id AND u_pass = @pass";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", u_id);
                        cmd.Parameters.AddWithValue("@pass", u_pass);

                        int userCount = (int)cmd.ExecuteScalar();

                        // If no user is found, show error
                        if (userCount == 0)
                        {
                            MessageBox.Show("Incorrect ID or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Login successful
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open homePage.cs
                            homePage home = new homePage(u_id);
                            home.Show();
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void button1_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgotPass forp = new forgotPass();
            forp.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
