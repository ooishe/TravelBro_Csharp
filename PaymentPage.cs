using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace TravelBro
{
    public partial class PaymentPage : Form
    {
        private string payment_id;
        private string u_id; // Store the user ID
        private float paymentAmount; // Store the payment amount
        private string packid;
        string destination;
        private string count;

        public PaymentPage(string userId, float amount, string packid, string destination , string count)
        {
            InitializeComponent();
            u_id = userId; // Assign the passed userId to the class-level variable
            paymentAmount = amount; // Assign the passed payment amount to the class-level variable
            this.packid = packid;
            this.destination = destination;
            this.count = count;
            //MessageBox.Show($"{count} and {destination}");
        }

        private void lable1_Click(object sender, EventArgs e)
        {

        }

        
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-FS3OVK5Q\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False");
        

        private void Cancel_Click(object sender, EventArgs e)
        {
            MnumbertextBox.Clear();
            PasstextBox.Clear();
            bkash.Checked = false;
            Nagad.Checked = false;
            Rocket.Checked = false;
            Upay.Checked = false;

        }


        private void PaymentPage_Load(object sender, EventArgs e)
        {


        }

        private void bkash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rocket_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Nagad_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Upay_CheckedChanged(object sender, EventArgs e)
        {


        }
        

        private void bkash_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        private string GeneratePaymentId()
        {
            int newPid = 1; // Default to 1 if no records exist
            try
            {
                // Ensure the connection is open
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                // Query to fetch the highest payment ID from the payment_info table
                string query = "SELECT MAX(CAST(pay_id AS INT)) FROM payment_info"; // Casting to INT ensures that pay_id is treated as a number

                SqlCommand cmd = new SqlCommand(query, Con);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        // Fetch the max ID from the first column
                        int lastPaymentId = reader.GetInt32(0); // Get the numeric value

                        // Increment the max ID
                        newPid = lastPaymentId + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating payment ID: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed after the operation
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }

            return newPid.ToString();
        }


        public char GetFirstLetter(string packid)
        {
            if (!string.IsNullOrEmpty(packid))
            {
                return packid[0]; // Returns the first character of the string
            }
            else
            {
                throw new ArgumentException("Input string cannot be null or empty.");
            }
        }

        private void Pay_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                string payThrough = string.Empty;
                if (bkash.Checked) payThrough = "bkash";
                else if (Nagad.Checked) payThrough = "Nagad";
                else if (Rocket.Checked) payThrough = "Rocket";
                else if (Upay.Checked) payThrough = "Upay";

                if (string.IsNullOrEmpty(payThrough))
                {
                    MessageBox.Show("Please select a payment method.");
                    return;
                }

                payment_id = GeneratePaymentId(); // Use GUID for unique pay_id
                //MessageBox.Show(payment_id);

                using (SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-FS3OVK5Q\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False"))
                {
                    Con.Open();
                    
                    string insertPaymentQuery = @"
                INSERT INTO payment_info (pay_id, pay_through, pay_amnt, ad_id) 
                VALUES (@payid, @payThrough, @payAmount, @adId);
                SELECT @payid;";

                    using (SqlCommand cmd = new SqlCommand(insertPaymentQuery, Con))
                    {
                        cmd.Parameters.AddWithValue("@payid", payment_id);
                        cmd.Parameters.AddWithValue("@payThrough", payThrough);
                        cmd.Parameters.AddWithValue("@payAmount", paymentAmount);
                        cmd.Parameters.AddWithValue("@adId", "a1");

                        object insertedId = cmd.ExecuteScalar();
                        //MessageBox.Show(insertedId.ToString());


                        if (insertedId != null && insertedId != DBNull.Value)
                        {
                            string payId = Convert.ToString(insertedId);
                            
                            // Insert into user_payment_id table
                            string insertUserPaymentQuery = "INSERT INTO user_payment_id (u_id, pay_id) VALUES (@uId, @payId)";
                            using (SqlCommand cmd2 = new SqlCommand(insertUserPaymentQuery, Con))
                            {
                                //MessageBox.Show(u_id+" "+payId);
                                cmd2.Parameters.AddWithValue("@uId", u_id);
                                cmd2.Parameters.AddWithValue("@payId", payId);
                                cmd2.ExecuteNonQuery();
                            }
                            char aa = GetFirstLetter(packid);
                            //MessageBox.Show("First Letter: " + aa);  // This helps confirm what 'aa' is before the if-else block

                            aa = GetFirstLetter(packid);
                            if (aa == 'c')
                            {
                                string insertUsertViewQuery = "INSERT INTO user_custompack_id (u_id, c_id) VALUES (@uId, @prId)";
                                using (SqlCommand cmd4 = new SqlCommand(insertUsertViewQuery, Con))
                                {
                                    //MessageBox.Show(u_id + "hjhjhjhjh " + packid);
                                    cmd4.Parameters.AddWithValue("@uId", u_id);
                                    cmd4.Parameters.AddWithValue("@prId", packid);
                                    cmd4.ExecuteNonQuery();
                                    Con.Close();
                                }

                            }

                           else
                            {
                                string insertUsertViewQuery1 = "INSERT INTO user_prepack_id (u_id, pr_id) VALUES (@uId, @prId)";
                                using (SqlCommand cmd3 = new SqlCommand(insertUsertViewQuery1, Con))
                                {
                                    //MessageBox.Show(u_id +  " Premade " + packid);
                                    cmd3.Parameters.AddWithValue("@uId", u_id);
                                    cmd3.Parameters.AddWithValue("@prId", packid);
                                    cmd3.ExecuteNonQuery();
                                    Con.Close();
                                }
                            }

                            
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve payment ID.");
                            return;
                        }
                    }
                }

                MessageBox.Show("Payment Successful!");

                // Clear fields after successful payment
                MnumbertextBox.Clear();
                PasstextBox.Clear();
                bkash.Checked = false;
                Nagad.Checked = false;
                Rocket.Checked = false;
                Upay.Checked = false;

                invoice inv= new invoice(u_id,payment_id,destination,count);
                inv.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-FS3OVK5Q\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False");
            conn.Open();    
            string query = "DELETE FROM custompack_info WHERE c_id = @c_id";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@c_id", packid);
                cmd.ExecuteNonQuery();
            }

            homePage hm = new homePage(u_id);
            hm.Show();
            this.Hide();
        }

        private void PaymentPage_Load_1(object sender, EventArgs e)
        {

        }
    }
}





