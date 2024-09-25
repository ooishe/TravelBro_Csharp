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
using Travel;

namespace TravelBro
{
    public partial class customPack : Form
    {
        string con = "Data Source=LAPTOP-FS3OVK5Q\\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False";
        private string userId;
        private float totalPrice;
        private string packid;
        private string destination;
        private string count;
        public customPack(string UserId)
        {
            InitializeComponent();
            userId = UserId;
            label6.Text = $"User {userId}";
        }

        // Prices for each option
        private readonly float[] destinationPrices = { 5000, 4500, 4000, 6000 }; // for Bandarban, Rangamati, Sajek, Cox's Bazar
        private readonly float[] accommodationPrices = { 4000, 8000 }; // 4 star, 5 star
        private readonly float[] commutePrices = { 1500, 5000 }; // Bus, Plane

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        // Method to generate c_id 
        private string GenerateCustomPackId()
        {
            string newId = "c_001"; // Default if no records found
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                string query = "SELECT TOP 1 c_id FROM custompack_info ORDER BY c_id DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        string lastId = result.ToString();
                        int idNumber = int.Parse(lastId.Substring(2)); // Get the number part after "c_"
                        idNumber++;
                        newId = $"c_{idNumber:D3}"; // Convert to 3-digit format

                    }
                }
            }
            return newId;
        }

        // Method to retrieve ad_id from the admin_info table
        private string GetAdminId()
        {
            string ad_id = "a1"; // Default admin ID

            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                string query = "SELECT TOP 1 ad_id FROM admin_info"; // Assuming the admin ID you need is from here

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        ad_id = result.ToString();
                    }
                }
            }

            return ad_id;
        }
        private void SaveCustomPack()
        {
            string destination = comboBox1.SelectedItem.ToString();
            int personCount = comboBox4.SelectedIndex + 1; // 1-5 persons

            // Generate custom pack ID and retrieve admin ID
            string c_id = GenerateCustomPackId();
            string ad_id = GetAdminId();

            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                string query = "INSERT INTO custompack_info (c_id, c_dest, c_price, c_pcount, ad_id) VALUES (@c_id, @c_dest, @c_price, @c_pcount, @ad_id)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@c_id", c_id);
                    cmd.Parameters.AddWithValue("@c_dest", destination);
                    cmd.Parameters.AddWithValue("@c_price", totalPrice);
                    cmd.Parameters.AddWithValue("@c_pcount", personCount);
                    cmd.Parameters.AddWithValue("@ad_id", ad_id);
                    cmd.ExecuteNonQuery();
                    packid = c_id;
                }
            }

            //MessageBox.Show("Custom pack saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Incomplete fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get values from comboboxes
            int destinationIndex = comboBox1.SelectedIndex;
            destination = comboBox1.SelectedItem.ToString();
             
            int accommodationIndex = comboBox2.SelectedIndex;
            int commuteIndex = comboBox3.SelectedIndex;
            int personCount = comboBox4.SelectedIndex + 1; // 1-5 persons
            count = $"{personCount}";
            //MessageBox.Show($"{destination} and {count}");

            // Calculate total price
            totalPrice = (destinationPrices[destinationIndex] + accommodationPrices[accommodationIndex] + commutePrices[commuteIndex]) * personCount;

            label5.Text = $"Total Price: {totalPrice} BDT";
            //MessageBox.Show($"Total price calculated: {totalPrice} BDT", "Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Incomplete fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(label5.Text) || totalPrice == 0)
            {
                MessageBox.Show("Please check the price before proceeding to payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Insert data into the custompack_info table
            SaveCustomPack();

            // Open payment form
            PaymentPage pp = new PaymentPage(userId, totalPrice ,packid, destination,count);
            pp.Show();
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            homePage hp = new homePage(userId);
            hp.Show();
            this.Hide();
        }


    }
}
