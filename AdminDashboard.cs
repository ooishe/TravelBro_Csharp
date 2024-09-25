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
using TravelBro;


namespace Travel
{
    public partial class AdminDashboard : Form
    {

        public AdminDashboard()
        {
            InitializeComponent();

        }
        
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-FS3OVK5Q\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False");

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void CustomerInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void PackageInfo_Click(object sender, EventArgs e)
        {
            


        }

        private void AgenciesInfo_Click(object sender, EventArgs e)
        {
           
        }

        private void CustomerPackInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void TransactionInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void CustomizedPackInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void AdminDashboard_Load_1(object sender, EventArgs e)
        {
            Con.Open();

            // 1. Get the total user count from the user_info table
            SqlCommand cmdUserCount = new SqlCommand("SELECT COUNT(*) FROM user_info", Con);
            int userCount = (int)cmdUserCount.ExecuteScalar();
            lab_ucount.Text = userCount.ToString();  // Set the label text to user count

            // 2. Get the total transaction amount from the payment_info table
            SqlCommand cmdTotalTrans = new SqlCommand("SELECT SUM(pay_amnt) FROM payment_info", Con);
            object totalTrans = cmdTotalTrans.ExecuteScalar();
            lab_totaltrans.Text = totalTrans != DBNull.Value ? totalTrans.ToString() : "0";  // Handle NULLs

            // 3. Get the total package count from the prepack_info table
            SqlCommand cmdPackCount = new SqlCommand("SELECT COUNT(*) FROM prepack_info", Con);
            int packCount = (int)cmdPackCount.ExecuteScalar();
            lab_opackcount.Text = packCount.ToString();  // Set the label text to package count

            // 4. Get the agency count from the agency_info table
            SqlCommand cmdAgCount = new SqlCommand("SELECT COUNT(*) FROM agency_info", Con);
            int agCount = (int)cmdAgCount.ExecuteScalar();
            lab_agcount.Text = agCount.ToString();  // Set the label text to agency count

            // Close the SQL connection
            Con.Close();
        }

        private void ucount_Click(object sender, EventArgs e)
        {

        }

        private void CustomerInfo_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from user_info", Con);
            DataTable dt1 = new DataTable();
            sqlda.Fill(dt1);
            dataGridView1.DataSource = dt1;
            Con.Close();
        }

        private void PackageInfo_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from prepack_info", Con);
            DataTable dt1 = new DataTable();
            sqlda.Fill(dt1);
            dataGridView1.DataSource = dt1;
            Con.Close();
        }

        private void CustomerPackInfo_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            //created a view here
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from CustomerPrepackInfoView", Con);
            DataTable dt1 = new DataTable();
            sqlda.Fill(dt1);
            dataGridView1.DataSource = dt1;
            Con.Close();
        }

        private void AgenciesInfo_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from agency_info", Con);
            DataTable dt1 = new DataTable();
            sqlda.Fill(dt1);
            dataGridView1.DataSource = dt1;
            Con.Close();
        }

        private void TransactionInfo_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from payment_info", Con);
            DataTable dt1 = new DataTable();
            sqlda.Fill(dt1);
            dataGridView1.DataSource = dt1;
            Con.Close();
        }

        private void CustomizedPackInfo_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from custompack_info", Con);
            DataTable dt1 = new DataTable();
            sqlda.Fill(dt1);
            dataGridView1.DataSource = dt1;
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear previous results in the DataGridView
            dataGridView1.DataSource = null;

            // Ensure the search text is a valid integer (ID)
            string searchId = SearchTextBox.Text.Trim();

            // Check if searchId is empty
            if (string.IsNullOrEmpty(searchId))
            {
                MessageBox.Show("Please enter a valid search value.");
                return;
            }

            // Open the SQL connection
            Con.Open();

            // Create a query string based on the selected radio button
            string query = "";

            if (rad_customer.Checked)
            {
                // If the customer radio button is selected
                query = "SELECT * FROM user_info WHERE u_id = @searchId";
            }
            else if (rad_agency.Checked)
            {
                // If the agency radio button is selected
                query = "SELECT * FROM agency_info WHERE ag_id = @searchId";
            }
            else if (rad_pack.Checked)
            {
                // If the package radio button is selected
                query = "SELECT * FROM prepack_info WHERE pr_id = @searchId";
            }
            else if (rad_payment.Checked)
            {
                // If the payment radio button is selected
                query = "SELECT * FROM payment_info WHERE pay_id = @searchId";
            }
            else
            {
                // If no radio button is selected, show an error message
                MessageBox.Show("Please select a category to search.");
                Con.Close();
                return;
            }

            // Create an SQL command with a parameter for the ID search
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@searchId", searchId);

            // Execute the command and fill the DataTable
            SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);

            // Bind the results to the DataGridView
            dataGridView1.DataSource = dt;

            // Close the SQL connection
            Con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Show();
            this.Hide();
        }
    }
}
