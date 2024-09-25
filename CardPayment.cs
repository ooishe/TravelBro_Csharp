//using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TravelBro
{
    public partial class CardPayment : Form
    {
        private string u_id;
        private float price = 0;
      
        public CardPayment(string userId, float price)
        {
            InitializeComponent(); 
            this.u_id = userId;
            this.price = price;
            
            label1.Text = $"Welcome {u_id}!";

        }
        
        SqlConnection Con = new SqlConnection(@"Data Source=ANTU-DEB\SQLEXPRESS01;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CardPayment_Load(object sender, EventArgs e)
        {
            cardCb.SelectedIndex = -1;
            dateTimePicker1.MinDate = DateTime.Now;
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading form: {ex.Message}");
            }

        }

        private void Pay_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO payment_card_info (u_id,card_name,card_number,cpay_id) " +
               "VALUES (@u_id, @card_name, @card_number, @cpay_id)";
            string selectedCardType = cardCb.SelectedItem?.ToString();
            string cardNumber = this.cardNumber.Text;
            string cvv = cvvTb.Text;
            DateTime expirationDate = dateTimePicker1.Value;
            try
            {
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@u_id", u_id);
                cmd.Parameters.AddWithValue("@card_name", selectedCardType);
                cmd.Parameters.AddWithValue("@card_number", cardNumber);
                cmd.Parameters.AddWithValue("@cpay_id", cvv);
              
                Con.Open();
                cmd.ExecuteNonQuery();

                
               

                MessageBox.Show("Payment successful! Receipt saved to your desktop.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (string.IsNullOrEmpty(selectedCardType))
            {
                MessageBox.Show("Please select a card type.");
                return;
            }

            if (string.IsNullOrEmpty(cardNumber) || cardNumber.Length != 16)
            {
                MessageBox.Show("Please enter a valid 16-digit card number.");
                return;
            }

            if (string.IsNullOrEmpty(cvv) || cvv.Length != 3)
            {
                MessageBox.Show("Please enter a valid 3-digit CVV.");
                return;
            }

            if (expirationDate <= DateTime.Now)
            {
                MessageBox.Show("The expiration date must be a future date.");
                return;
            }

            MessageBox.Show($"Payment Successful! \nCard Type: {selectedCardType}\nCard Number: {cardNumber}\nExpiration Date: {expirationDate.ToShortDateString()}");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            cardCb.SelectedIndex = -1;
            cardNumber.Clear();
            cvvTb.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
