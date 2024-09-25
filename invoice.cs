using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelBro
{
      

    public partial class invoice : Form
    {
        private string u_id;
        private string payid;
        private string destination;
        private string amount;
        private string persons;
        public invoice(string userId,string payid, string destination,string count)
        {
            InitializeComponent();
            u_id = userId;  // Set the user ID passed when creating the invoice form
            this.payid = payid;
            this.destination = destination;
            this.persons = count;
            LoadInvoiceDetails();

            lbl_uid.Text = $"User ID: {u_id}";
        }
        private void LoadInvoiceDetails()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-FS3OVK5Q\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False"))
            {
                try
                {
                    conn.Open();

                    // Get user details
                    string userQuery = "SELECT u_name FROM user_info WHERE u_id = @u_id";
                    using (SqlCommand cmd = new SqlCommand(userQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@u_id", u_id);
                        lbl_userName.Text = $"Name: {cmd.ExecuteScalar()?.ToString() ?? "N/A"}";
                    }

                    // Get payment details
                    string paymentQuery = "SELECT pay_through, pay_amnt FROM payment_info WHERE pay_id = @payid";
                    using (SqlCommand cmd = new SqlCommand(paymentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@payid", payid);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lbl_paythrough.Text = $" {reader["pay_through"].ToString()}";
                                amount = reader["pay_amnt"].ToString();
                                lbl_totalCost.Text = $" {amount} BDT";
                            }
                        }
                    }

                    // Set additional details
                    lbl_destination.Text = $"{destination}";
                    lbl_person.Text = $"{persons}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading invoice details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ShowConfirmationMessage()
        {
            // Show a message box asking the user if they want to go to the home page
            DialogResult result = MessageBox.Show(
                "Do you want to go to the home page?",
                "Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            // Check the result of the message box
            if (result == DialogResult.OK)
            {
                // If OK is clicked, open the HomePage form
                homePage homePage = new homePage(u_id); // Assuming HomePage is your form class
                homePage.Show(); // Show the home page
                this.Hide(); // Hide the current form (optional)
            }
            else if (result == DialogResult.Cancel)
            {
                // If Cancel is clicked, close the application
                Application.Exit();
            }
        }

        // Add a class-level iterator variable to keep track of file numbers
        private void CaptureCroppedFormSnapshot()
        {
            // Refresh the form immediately to ensure it's up-to-date
            this.Refresh();
            Application.DoEvents(); // Process all pending UI events quickly

            try
            {
                // Define the amounts to crop from the top and bottom (e.g., 50 pixels each)
                int cropTop = 40;     // Amount to crop from the top
                int cropBottom = 100;  // Amount to crop from the bottom

                // Calculate the new height after cropping
                int newHeight = this.Height - cropTop - cropBottom;

                // Create a bitmap with the adjusted size
                Bitmap bitmap = new Bitmap(this.Width, newHeight);

                // Directly capture from the form's screen location
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Set the background color to a solid color (e.g., white) to prevent transparency issues
                    g.Clear(Color.White);

                    // Capture from the form's screen location, accounting for top cropping
                    g.CopyFromScreen(this.Location.X, this.Location.Y + cropTop, 0, 0, new Size(this.Width, newHeight));
                }

                // Define the directory where the files should be saved (e.g., Desktop or Documents folder)
                string folderPath = @"C:\Users\ASUS\Downloads\Invoices";  // Change this to any folder path you want

                // Use current timestamp and a GUID to create a unique file name
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string uniqueID = Guid.NewGuid().ToString(); // Generate a GUID
                string fileName = $"FormSnapshot_{timestamp}_{uniqueID}.png"; // Generate a unique file name using timestamp and GUID
                string fullPath = Path.Combine(folderPath, fileName);  // Combine the folder path and the file name

                // Save the image automatically as a PNG
                bitmap.Save(fullPath, ImageFormat.Png);

                // Optionally, inform the user that the snapshot is saved
                //MessageBox.Show($"Cropped form snapshot saved successfully to {fullPath}!");
                ShowConfirmationMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving the form snapshot: " + ex.Message);
            }
        }









        private void button1_Click(object sender, EventArgs e)
        {
            CaptureCroppedFormSnapshot();


        }
    }

    
}
