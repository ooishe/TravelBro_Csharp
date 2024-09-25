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
    public partial class forgotPass : Form
    {
        public forgotPass()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchId = txt_search_id.Text;

            if (string.IsNullOrEmpty(searchId))
            {
                MessageBox.Show("Please enter a User ID to search.");
                return;
            }

            // SQL connection string (replace with your actual connection details)
            string connectionString = "Data Source=LAPTOP-FS3OVK5Q\\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Query to search for the user ID
                    string query = "SELECT u_pass FROM user_info WHERE u_id = @userId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@userId", searchId);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // If user ID is found, display it in the txt_get_id text box
                            txt_get_id.Text = reader["u_pass"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("User ID not found.");
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Close();
        }
    }
}
