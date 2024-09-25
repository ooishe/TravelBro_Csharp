using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelBro
{
    public partial class agency_home : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FS3OVK5Q\\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False");
        string id = null;
        string agid = null;
        public agency_home(string agid= "ag1")
        {
            this.agid = agid;
            InitializeComponent();
            BindData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }


        private bool IsPrIdExists(string pr_id)
        {
            try
            {
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM prepack_info WHERE pr_id = @id", con);
                checkCmd.Parameters.AddWithValue("@id", pr_id);

                con.Open();
                int count = (int)checkCmd.ExecuteScalar();

                return count > 0; // If count is greater than 0, the pr_id exists
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while checking pr_id: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_p_id.Text) ||
        string.IsNullOrWhiteSpace(txt_p_dest.Text) ||
        string.IsNullOrWhiteSpace(txt_p_hotel.Text) ||
        string.IsNullOrWhiteSpace(txt_p_person.Text) ||
        string.IsNullOrWhiteSpace(txt_p_price.Text) ||
        string.IsNullOrWhiteSpace(txt_duration.Text) ||
        agency_picbox.Image == null)
            {
                // Show error
                MessageBox.Show("Please fill in all fields and select an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsPrIdExists(txt_p_id.Text))
            {
                MessageBox.Show("This Package ID already exists. Please use a different ID.", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();
                
                byte[] imageData = ImageToByteArray(agency_picbox.Image);

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO prepack_info (pr_id, pr_dest, pr_hotel, pr_price, pr_pcount, ad_id, pr_image,pr_duration) VALUES (@id, @dest, @hotel, @price, @count, @adid, @image, @duration)", con);

                cmd.Parameters.AddWithValue("@id", txt_p_id.Text);
                cmd.Parameters.AddWithValue("@dest", txt_p_dest.Text);
                cmd.Parameters.AddWithValue("@hotel", txt_p_hotel.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txt_p_price.Text)); // Assuming price is a float
                cmd.Parameters.AddWithValue("@count", Convert.ToInt32(txt_p_person.Text)); // Assuming person count is an integer
                cmd.Parameters.AddWithValue("@adid", "a1"); // Replace with actual ad_id if necessary
                cmd.Parameters.AddWithValue("@image", imageData);
                cmd.Parameters.AddWithValue("@duration", txt_duration.Text);

                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("INSERT INTO prepack_agency_id (pr_id, ag_id) VALUES (@pr_id, @ag_id)", con);

                // Assuming pr_id is already available from the package insertion or elsewhere
                cmd1.Parameters.AddWithValue("@pr_id", txt_p_id.Text);  // Using the same pr_id from the previous insertion
                cmd1.Parameters.AddWithValue("@ag_id", agid.ToString());  // Replace with actual ag_id if necessary (e.g., from a dropdown or other input)

                cmd1.ExecuteNonQuery();


                MessageBox.Show("Record inserted successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            // Refresh data
            BindData();
        }

        void BindData()
        {
            SqlCommand cmd2 = new SqlCommand($"SELECT * FROM prepack_info where pr_id in (select pr_id from prepack_agency_id where ag_id = '{agid}')", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            dataAdapter.Fill(dt2);
            if (dt2.Rows.Count > 0)
                dataGridView1.DataSource = dt2;
        }

        


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                agency_picbox.Image = new Bitmap(openFileDialog.FileName);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Retrieve values from the selected row and populate the textboxes
                txt_p_id.Text = row.Cells["pr_id"].Value.ToString();
                id = txt_p_id.Text;
                txt_p_dest.Text = row.Cells["pr_dest"].Value.ToString();
                txt_p_hotel.Text = row.Cells["pr_hotel"].Value.ToString();
                txt_p_price.Text = row.Cells["pr_price"].Value.ToString();
                txt_p_person.Text = row.Cells["pr_pcount"].Value.ToString();
                txt_duration.Text = row.Cells["pr_duration"].Value.ToString();

                // Retrieve image data from the selected row
                byte[] imageData = row.Cells["pr_image"].Value as byte[];

                // Convert the byte array to an Image and display it in the PictureBox
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        agency_picbox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    agency_picbox.Image = null; // Clear the PictureBox if no image is found
                }
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            txt_p_id.Text = "";
            txt_p_dest.Text = "";
            txt_p_hotel.Text = "";
            txt_p_price.Text = "";
            txt_p_person.Text = "";
            txt_duration.Text = "";
            agency_picbox.Image = null;

        }

        /*private void update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Convert the image from PictureBox to byte array
                byte[] imageData = ImageToByteArray(agency_picbox.Image);

                // SQL Update command for prepack_info table
                SqlCommand cmd = new SqlCommand(
                    "UPDATE prepack_info SET pr_dest = @dest, pr_hotel = @hotel, pr_price = @price, pr_pcount = @count, pr_image = @image, pr_duration = @duration WHERE pr_id = @id", con);

                // Add parameters for the update query
                cmd.Parameters.AddWithValue("@dest", txt_p_dest.Text);
                cmd.Parameters.AddWithValue("@hotel", txt_p_hotel.Text);
                cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txt_p_price.Text)); // Ensure price is a double
                cmd.Parameters.AddWithValue("@count", Convert.ToInt32(txt_p_person.Text)); // Ensure person count is an integer
                cmd.Parameters.AddWithValue("@image", imageData); // Image in byte array format
                cmd.Parameters.AddWithValue("@id", txt_p_id.Text); // Use pr_id for the where condition
                cmd.Parameters.AddWithValue("@duration", txt_duration.Text);

                // Execute the query
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection and refresh the data
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                BindData(); // Refresh the grid view
            }

        }*/


        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Ensure the image is not null
                if (agency_picbox.Image != null)
                {
                    // Create a clone of the image to avoid locking issues
                    Image cloneImage = (Image)agency_picbox.Image.Clone();

                    // Convert the cloned image from PictureBox to byte array
                    byte[] imageData = ImageToByteArray(cloneImage);

                    // SQL Update command for prepack_info table
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE prepack_info SET pr_dest = @dest, pr_hotel = @hotel, pr_price = @price, pr_pcount = @count, pr_image = @image, pr_duration = @duration WHERE pr_id = @id", con);

                    // Add parameters for the update query
                    cmd.Parameters.AddWithValue("@dest", txt_p_dest.Text);
                    cmd.Parameters.AddWithValue("@hotel", txt_p_hotel.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDouble(txt_p_price.Text)); // Ensure price is a double
                    cmd.Parameters.AddWithValue("@count", Convert.ToInt32(txt_p_person.Text)); // Ensure person count is an integer
                    cmd.Parameters.AddWithValue("@image", imageData); // Image in byte array format
                    cmd.Parameters.AddWithValue("@id", txt_p_id.Text); // Use pr_id for the where condition
                    cmd.Parameters.AddWithValue("@duration", txt_duration.Text);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record successfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No image selected for update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection and refresh the data
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                BindData(); // Refresh the grid view
            }
        }

        private void agency_home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelBroDataSet.prepack_info' table. You can move, or remove it, as needed.
            //this.prepack_infoTableAdapter.Fill(this.travelBroDataSet.prepack_info);

        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // SQL Delete command for prepack_info table using pr_id
                SqlCommand cmd1 = new SqlCommand($"DELETE FROM prepack_agency_id WHERE pr_id = '{id}'", con);
                SqlCommand cmd2 = new SqlCommand($"DELETE FROM prepack_info WHERE pr_id = '{id}'", con);
               // cmd.Parameters.AddWithValue("@id", txt_p_id.Text); // pr_id is used to identify the record to delete

                // Execute the delete query
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                // Clear the textboxes after deletion
                txt_p_id.Text = "";
                txt_p_dest.Text = "";
                txt_p_hotel.Text = "";
                txt_p_price.Text = "";
                txt_p_person.Text = "";
                txt_duration.Text = "";
                agency_picbox.Image = null; // Clear the PictureBox

                MessageBox.Show("Record Deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection and refresh the data
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                BindData(); // Refresh the data grid view
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void home_DoubleClick(object sender, EventArgs e)
        {

        }

        private void cus_view_lab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            agency_customer_view agc = new agency_customer_view(agid);
            this.Hide();
            agc.Show();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartPage sp = new StartPage();
            sp.Show();
            this.Hide();

        }

        private void agency_picbox_Click(object sender, EventArgs e)
        {

        }
    }
    
}
