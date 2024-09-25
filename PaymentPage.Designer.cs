using System.Drawing;
using System.Windows.Forms;


namespace TravelBro
{
    partial class PaymentPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Upay = new System.Windows.Forms.RadioButton();
            this.Rocket = new System.Windows.Forms.RadioButton();
            this.bkash = new System.Windows.Forms.RadioButton();
            this.Cancel = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.MnumbertextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nagad = new System.Windows.Forms.RadioButton();
            this.lable1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.Upay);
            this.panel1.Controls.Add(this.Rocket);
            this.panel1.Controls.Add(this.bkash);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Pay);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.PasstextBox);
            this.panel1.Controls.Add(this.MnumbertextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Nagad);
            this.panel1.Controls.Add(this.lable1);
            this.panel1.Location = new System.Drawing.Point(472, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 506);
            this.panel1.TabIndex = 0;
            // 
            // Upay
            // 
            this.Upay.AutoSize = true;
            this.Upay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upay.Location = new System.Drawing.Point(264, 148);
            this.Upay.Name = "Upay";
            this.Upay.Size = new System.Drawing.Size(70, 26);
            this.Upay.TabIndex = 20;
            this.Upay.TabStop = true;
            this.Upay.Text = "Upay";
            this.Upay.UseVisualStyleBackColor = true;
            // 
            // Rocket
            // 
            this.Rocket.AutoSize = true;
            this.Rocket.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rocket.Location = new System.Drawing.Point(264, 70);
            this.Rocket.Name = "Rocket";
            this.Rocket.Size = new System.Drawing.Size(87, 26);
            this.Rocket.TabIndex = 19;
            this.Rocket.TabStop = true;
            this.Rocket.Text = "Rocket";
            this.Rocket.UseVisualStyleBackColor = true;
            // 
            // bkash
            // 
            this.bkash.AutoSize = true;
            this.bkash.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkash.Location = new System.Drawing.Point(28, 70);
            this.bkash.Name = "bkash";
            this.bkash.Size = new System.Drawing.Size(77, 26);
            this.bkash.TabIndex = 18;
            this.bkash.TabStop = true;
            this.bkash.Text = "bkash";
            this.bkash.UseVisualStyleBackColor = true;
            this.bkash.CheckedChanged += new System.EventHandler(this.bkash_CheckedChanged_1);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.OrangeRed;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(225, 435);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(87, 31);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click_1);
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.Location = new System.Drawing.Point(353, 435);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(87, 31);
            this.Pay.TabIndex = 15;
            this.Pay.Text = "Pay";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(385, 133);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(146, 133);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(385, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PasstextBox
            // 
            this.PasstextBox.Location = new System.Drawing.Point(36, 363);
            this.PasstextBox.Multiline = true;
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.Size = new System.Drawing.Size(404, 46);
            this.PasstextBox.TabIndex = 8;
            // 
            // MnumbertextBox
            // 
            this.MnumbertextBox.Location = new System.Drawing.Point(36, 271);
            this.MnumbertextBox.Multiline = true;
            this.MnumbertextBox.Name = "MnumbertextBox";
            this.MnumbertextBox.Size = new System.Drawing.Size(404, 46);
            this.MnumbertextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "PIN code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mobile Number";
            // 
            // Nagad
            // 
            this.Nagad.AutoSize = true;
            this.Nagad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nagad.Location = new System.Drawing.Point(28, 148);
            this.Nagad.Name = "Nagad";
            this.Nagad.Size = new System.Drawing.Size(82, 26);
            this.Nagad.TabIndex = 3;
            this.Nagad.TabStop = true;
            this.Nagad.Text = "Nagad";
            this.Nagad.UseVisualStyleBackColor = true;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(202, 13);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(94, 25);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Payment";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.pictureBox5.Location = new System.Drawing.Point(12, 126);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(444, 316);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // PaymentPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 516);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel1);
            this.Name = "PaymentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentPage";
            this.Load += new System.EventHandler(this.PaymentPage_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private RadioButton Nagad;
        private Label lable1;
        private TextBox PasstextBox;
        private TextBox MnumbertextBox;
        private Label label2;
        private Label label1;
        private Button Cancel;
        private Button Pay;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private RadioButton Upay;
        private RadioButton Rocket;
        private RadioButton bkash;
    }
}