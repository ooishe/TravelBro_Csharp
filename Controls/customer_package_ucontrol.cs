using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelBro.Controls
{
    public partial class customer_package_ucontrol : UserControl
    {
        private string userid;
        private float price;
        private string packid;
        private string dest;
        private string count;
        public customer_package_ucontrol(string userId, string packid, string dest, string count)
        {
            InitializeComponent(); 
            this.userid = userId;
            this.packid = packid;
            this.dest = dest;
            this.count = count;
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

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
        public void SetImage(Image img)
        {
            pack_picbox.Image = img; // Assuming your user control has a PictureBox named pictureBox
        }
        public void SetPackageDetails(string destination, float price, int count, string hotel,string duration)
        {
            lab_dest.Text = destination; // Assuming you have a Label for destination
            lab_price.Text = $"{price}"; // Assuming you have a Label for price
            lab_person.Text = $"{count}"; // Assuming you have a Label for count
            lab_hotel.Text = hotel;
            lab_duration.Text = duration;
            this.price = price;
            this.count = $"{count}";
        }
        private void customer_package_Load(object sender, EventArgs e)
        {

        }

        
       
        private void button1_Click(object sender, EventArgs e)
        {
            PaymentPage pp = new PaymentPage(userid, price, packid, dest, count);
            pp.Show();

            Form parentForm = this.FindForm(); // main form will be here where the ucontrol calls

            if (parentForm != null)
            {
                // Hide the parent form (Form1)
                parentForm.Hide();
            }

        }
    }
}
