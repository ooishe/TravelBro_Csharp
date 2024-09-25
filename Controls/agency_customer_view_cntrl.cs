using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelBro.Controls
{
    public partial class agency_customer_view_cntrl : UserControl
    {
        public agency_customer_view_cntrl()
        {
            InitializeComponent();
        }
        public void SetImage(Image img)
        {
            pack_picbox.Image = img; // Assuming your user control has a PictureBox named pictureBox
        }
        public void SetPackageDetails(string destination, double price, int count, string hotel, string duration)
        {
            lab_dest.Text = destination; // Assuming you have a Label for destination
            lab_price.Text = $"{price}"; // Assuming you have a Label for price
            lab_person.Text = $"{count}"; // Assuming you have a Label for count
            lab_hotel.Text = hotel;
            lab_duration.Text = duration;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
