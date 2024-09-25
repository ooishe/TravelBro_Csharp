using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelBro.Controls;

namespace TravelBro
{
    public partial class customer_prepack : Form
    {
        
        private string userId;
        private string prepack = "";
        private string destination;
        private string count;

        public customer_prepack(string UserId)
        {
            InitializeComponent();
            userId = UserId;
            label3.Text = $"User {userId}";
            Controls.customer_package_ucontrol pac = new Controls.customer_package_ucontrol(userId, prepack, destination, count);
            // Attach event handlers for radio buttons to filter packages by price
            radibtn_prange1.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radibtn_prange2.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radibtn_prange3.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radibtn_prange4.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radibtn_prange5.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radibtn_prange6.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);

            // Load initial data
            show_pack_Data();
            
        }
        
        public void show_pack_Data()
        {
            string conString = "Data Source=LAPTOP-FS3OVK5Q\\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            customer_pack_flowPanel.Controls.Clear();

            string qry = "select * from prepack_info";

            if (radibtn_prange1.Checked)
            {
                qry += " WHERE pr_price BETWEEN 0 AND 1000";
            }
            else if (radibtn_prange2.Checked)
            {
                qry += " WHERE pr_price BETWEEN 1000 AND 2000";
            }
            else if (radibtn_prange3.Checked)
            {
                qry += " WHERE pr_price BETWEEN 2000 AND 3500";
            }
            else if (radibtn_prange4.Checked)
            {
                qry += " WHERE pr_price BETWEEN 3500 AND 5000";
            }
            else if (radibtn_prange5.Checked)
            {
                qry += " WHERE pr_price BETWEEN 5000 AND 6500";
            }
            else if (radibtn_prange6.Checked)
            {
                qry += " WHERE pr_price > 6500";
            }

            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                prepack = reader["pr_id"].ToString();
                destination = reader["pr_dest"].ToString();
                float price = float.Parse(reader["pr_price"].ToString());
                int count = Convert.ToInt32(reader["pr_pcount"]);
                string hotel = reader["pr_hotel"].ToString();
                string duration = reader["pr_duration"].ToString();

                Controls.customer_package_ucontrol newPac = new Controls.customer_package_ucontrol(userId, prepack, destination,$"{count}");

                // Set the package details
                newPac.SetPackageDetails(destination, price, count, hotel, duration);

                if (!reader.IsDBNull(reader.GetOrdinal("pr_image")))
                {
                    byte[] imageData = (byte[])reader["pr_image"];

                    // Convert the byte array into an image
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        newPac.SetImage(Image.FromStream(ms)); // Assuming you have a method in your package control to set the image
                    }
                }

                // Set the size and add the control to the FlowLayoutPanel
                newPac.Size = new Size(220, 299);
                customer_pack_flowPanel.Controls.Add(newPac);

            }
            customer_pack_flowPanel.Refresh();

        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Re-fetch the data when a different price range is selected
            show_pack_Data();
        }
        private void customer_prepack_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            homePage hp = new homePage(userId);
            hp.Show();
            this.Hide();
        }
    }
}
