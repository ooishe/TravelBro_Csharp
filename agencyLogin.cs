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
    public partial class agencyLogin : Form
    {
        string con = "Data Source=LAPTOP-FS3OVK5Q\\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False";

        public agencyLogin()
        {
            InitializeComponent();
        }

        private void agencyLogin_Load(object sender, EventArgs e)
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
            string userId = txt_id.Text;
            string password = txt_pass.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both ID and password.");
                return;
            }

            // Check credentials against the database
            if (AuthenticateUser(userId, password))
            {
                MessageBox.Show("Login successful!");
                // Proceed to the next form or functionality
                // Example: new MainForm().Show(); this.Hide();
                
                agency_home agh = new agency_home(userId);
                
                agh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid ID or password.");
            }
        }

        private bool AuthenticateUser(string userId, string password)
        {
            bool isAuthenticated = false;
            //This part of the query is used to count the number of rows that meet the specified criteria.
            //COUNT(1) counts the number of rows returned by the query.
            //The 1 is a constant and doesn't change the result;
            //it just tells SQL Server to count the rows.
            string query = $"SELECT COUNT(1) FROM agency_info WHERE ag_id = '{userId}' AND ag_pass = '{password}'";
            Console.WriteLine(query);

            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@password", password); // Adjust if passwords are hashed

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        isAuthenticated = (count > 0);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            return isAuthenticated;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            agencysignup ags = new agencysignup();
            ags.Show();
            this.Hide();
        }
    }
}
