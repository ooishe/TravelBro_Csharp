using System.Drawing;
using System.Windows.Forms;

namespace TravelBro
{
    partial class CardPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            Cancel = new Button();
            Pay = new Button();
            cvvTb = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            cardNumber = new TextBox();
            label3 = new Label();
            cardCb = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(Cancel);
            panel1.Controls.Add(Pay);
            panel1.Controls.Add(cvvTb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cardNumber);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cardCb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(502, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 500);
            panel1.TabIndex = 0;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.FromArgb(255, 128, 0);
            Cancel.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel.Location = new Point(243, 424);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(101, 45);
            Cancel.TabIndex = 11;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // Pay
            // 
            Pay.BackColor = Color.FromArgb(192, 0, 192);
            Pay.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pay.Location = new Point(98, 424);
            Pay.Name = "Pay";
            Pay.Size = new Size(101, 45);
            Pay.TabIndex = 10;
            Pay.Text = "Pay";
            Pay.UseVisualStyleBackColor = false;
            Pay.Click += Pay_Click;
            // 
            // cvvTb
            // 
            cvvTb.Location = new Point(47, 357);
            cvvTb.Multiline = true;
            cvvTb.Name = "cvvTb";
            cvvTb.Size = new Size(378, 38);
            cvvTb.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 331);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 8;
            label5.Text = "CVV";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.ImeMode = ImeMode.Katakana;
            dateTimePicker1.Location = new Point(47, 290);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 251);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 6;
            label4.Text = "Valid";
            // 
            // cardNumber
            // 
            cardNumber.Location = new Point(47, 197);
            cardNumber.Multiline = true;
            cardNumber.Name = "cardNumber";
            cardNumber.Size = new Size(378, 38);
            cardNumber.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 69);
            label3.Name = "label3";
            label3.Size = new Size(152, 23);
            label3.TabIndex = 4;
            label3.Text = "Select Your Card";
            // 
            // cardCb
            // 
            cardCb.FormattingEnabled = true;
            cardCb.Items.AddRange(new object[] { "American Express", "Discover", "Diners Club International", "Master Card", "Maestro", "Union Pay", "Visa " });
            cardCb.Location = new Point(47, 105);
            cardCb.Name = "cardCb";
            cardCb.Size = new Size(378, 28);
            cardCb.TabIndex = 3;
            cardCb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 161);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 2;
            label2.Text = "Card Number";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 18);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 1;
            label1.Text = "Pay With Card";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.BlanchedAlmond;
           // pictureBox1.Image = Properties.Resources.WhatsApp_Image_2024_09_14_at_16_22_09_4a1c95ab_removebg_preview;
            pictureBox1.Location = new Point(31, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 372);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CardPayment
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 516);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "CardPayment";
            Text = "CardPayment";
            Load += CardPayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cardCb;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox cardNumber;
        private Button Cancel;
        private Button Pay;
        private TextBox cvvTb;
        private Label label5;
        private PictureBox pictureBox1;
    }
}