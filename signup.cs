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
    public partial class signup : Form
    {
        string con = "Data Source=LAPTOP-FS3OVK5Q\\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False";
        public signup()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||  // First Name
                string.IsNullOrWhiteSpace(textBox2.Text) ||  // Last Name
                string.IsNullOrWhiteSpace(textBox3.Text) ||  // Phone Number
                string.IsNullOrWhiteSpace(textBox4.Text) ||  // Email
                string.IsNullOrWhiteSpace(textBox5.Text) ||  // Password
                string.IsNullOrWhiteSpace(textBox6.Text)   // Confirm Password
                //!IsGenderSelected()
                )
            {
                MessageBox.Show("Invalid info. Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if passwords match
            if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }










            // Declare u_id for database insertion
            string u_id = "";
            string ad_id = "";

            // Prepare user data
            string u_name = textBox2.Text; // Last Name as u_name
            string u_phone = textBox3.Text;
            string u_mail = textBox4.Text;
            string u_pass = textBox5.Text;
            string u_gender = GetSelectedGender();

            // Insert into the database
            try
            {
                // Connection string (update with your actual database details)

                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();

                    // Step 1: Get the latest u_id from the database
                    string getMaxUidQuery = "SELECT MAX(CAST(SUBSTRING(u_id, 4, 2) AS INT)) FROM user_info";
                    int latestUidNum = 0;

                    using (SqlCommand getMaxUidCmd = new SqlCommand(getMaxUidQuery, conn))
                    {
                        object result = getMaxUidCmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            latestUidNum = Convert.ToInt32(result);
                        }
                    }

                    // Step 2: Generate new u_id
                    int newUidNum = latestUidNum + 1;
                    u_id = $"us_{newUidNum:D2}";  // D2 formats the number as two digits

                    // Step 3: Get an admin_id from the admin_info table (for this example, just getting the first available admin)
                    string getAdminIdQuery = "SELECT TOP 1 ad_id FROM admin_info";
                    using (SqlCommand getAdminIdCmd = new SqlCommand(getAdminIdQuery, conn))
                    {
                        object adminResult = getAdminIdCmd.ExecuteScalar();
                        if (adminResult != null)
                        {
                            ad_id = adminResult.ToString();
                        }
                        
                    }


                    // Step 4: Insert new user into the database
                    string insertQuery = "INSERT INTO user_info (u_id, u_name, u_phone, u_mail, u_pass, u_gender, ad_id) " +
                                         "VALUES (@id, @name, @phone, @mail, @pass, @gender, @adminid)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@id", u_id);
                        insertCmd.Parameters.AddWithValue("@name", u_name);
                        insertCmd.Parameters.AddWithValue("@phone", u_phone);
                        insertCmd.Parameters.AddWithValue("@mail", u_mail);
                        insertCmd.Parameters.AddWithValue("@pass", u_pass);
                        insertCmd.Parameters.AddWithValue("@gender", u_gender);
                        insertCmd.Parameters.AddWithValue("@adminid", ad_id);

                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sign up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open homePage.cs
                homePage home = new homePage(u_id);
                home.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to check if a gender is selected
        private bool IsGenderSelected()
        {
            return checkBox1.Checked || checkBox2.Checked || checkBox3.Checked;
        }

        // Method to get the selected gender
        private string GetSelectedGender()
        {
            if (checkBox1.Checked)
                return "Male";
            if (checkBox2.Checked)
                return "Female";
            if (checkBox3.Checked)
                return "Others";
            return string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.Show();
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
    }
}
