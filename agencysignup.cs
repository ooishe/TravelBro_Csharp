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
    public partial class agencysignup : Form
    {
        public agencysignup()
        {
            InitializeComponent();
        }

        private void agencysignup_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            agencyLogin al = new agencyLogin();
            al.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string agencyId = text_id.Text.Trim();
            string agencyName = text_name.Text.Trim();
            string contact = text_contact.Text.Trim();
            string email = text_mail.Text.Trim();
            string address = text_address.Text.Trim();
            string password = textBox1.Text.Trim(); 

            // Validate input

            if (string.IsNullOrEmpty(agencyId) || string.IsNullOrEmpty(agencyName) ||

                 string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(email) ||

                 string.IsNullOrEmpty(address) || string.IsNullOrEmpty(password))

            {

                MessageBox.Show("Please fill in all fields.");

                return;

            }

            // Check if agency ID already exists

            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-FS3OVK5Q\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False"))

            {

                try

                {

                    con.Open();

                    // Check for existing agency ID

                    string checkQuery = "SELECT COUNT(*) FROM agency_info WHERE ag_id = @agId";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))

                    {

                        checkCmd.Parameters.AddWithValue("@agId", agencyId);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)

                        {

                            MessageBox.Show("Agency ID already exists. Please use a different ID.");

                            return;

                        }

                    }

                    // Insert new agency info

                    string insertQuery = @"

             INSERT INTO agency_info (ag_id, ag_name, ag_phone, ag_mail, ag_loc, ag_pass, ad_id)

             VALUES (@agId, @agName, @agPhone, @agMail, @agLoc, @agPass, @adid)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))

                    {

                        insertCmd.Parameters.AddWithValue("@agId", agencyId);

                        insertCmd.Parameters.AddWithValue("@agName", agencyName);

                        insertCmd.Parameters.AddWithValue("@agPhone", contact);

                        insertCmd.Parameters.AddWithValue("@agMail", email);

                        insertCmd.Parameters.AddWithValue("@agLoc", address);

                        insertCmd.Parameters.AddWithValue("@adid", "a1");

                        insertCmd.Parameters.AddWithValue("@agPass", password); 

                        insertCmd.ExecuteNonQuery();

                    }

                    MessageBox.Show("Signup successful!");

                    // Clear fields after signup

                    text_id.Clear();

                    text_name.Clear();

                    text_contact.Clear();

                    text_mail.Clear();

                    text_address.Clear();
                    textBox1.Clear();

                    agencyLogin ah = new agencyLogin();
                    ah.Show();
                    this.Hide();

                }

                catch (Exception ex)

                {

                    MessageBox.Show("Error: " + ex.Message);

                }

            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
