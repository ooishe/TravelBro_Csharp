using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelBro
{
    public partial class agency_customer_view : Form
    {
        string agid = null;
        public agency_customer_view(string agid)
        {
            this.agid = agid;
            InitializeComponent();
            show_pack_Data();
        }
        public void show_pack_Data()
        {
            string conString = "Data Source=LAPTOP-FS3OVK5Q\\SQLEXPRESS;Initial Catalog=TravelBro;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            cust_view_flowpanel.Controls.Clear();

            SqlCommand cmd = new SqlCommand($"SELECT * FROM prepack_info where pr_id in (select pr_id from prepack_agency_id where ag_id = '{agid}')", con);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string destination = reader["pr_dest"].ToString();
                double price = Convert.ToDouble(reader["pr_price"]);
                int count = Convert.ToInt32(reader["pr_pcount"]);
                string hotel = reader["pr_hotel"].ToString();
                string duration = reader["pr_duration"].ToString();

                Controls.agency_customer_view_cntrl newPac = new Controls.agency_customer_view_cntrl();

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
                cust_view_flowpanel.Controls.Add(newPac);

            }
            cust_view_flowpanel.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            agency_home agh = new agency_home(agid);
            agh.Show();
        }
    }
}
