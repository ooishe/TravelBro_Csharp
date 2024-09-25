
using System.Drawing;
using System.Windows.Forms;

namespace Travel
{
    partial class AdminDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_totaltrans = new System.Windows.Forms.Label();
            this.lab_opackcount = new System.Windows.Forms.Label();
            this.lab_agcount = new System.Windows.Forms.Label();
            this.lab_ucount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerInfo = new System.Windows.Forms.Button();
            this.AgenciesInfo = new System.Windows.Forms.Button();
            this.PackageInfo = new System.Windows.Forms.Button();
            this.TransactionInfo = new System.Windows.Forms.Button();
            this.CustomerPackInfo = new System.Windows.Forms.Button();
            this.CustomizedPackInfo = new System.Windows.Forms.Button();
            this.rad_customer = new System.Windows.Forms.RadioButton();
            this.rad_agency = new System.Windows.Forms.RadioButton();
            this.rad_pack = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rad_payment = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 223);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(907, 420);
            this.dataGridView1.TabIndex = 6;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.Search.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(9, 108);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(51, 19);
            this.Search.TabIndex = 7;
            this.Search.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(15, 137);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(145, 22);
            this.SearchTextBox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lab_totaltrans);
            this.panel1.Controls.Add(this.lab_opackcount);
            this.panel1.Controls.Add(this.lab_agcount);
            this.panel1.Controls.Add(this.lab_ucount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ucount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(927, 223);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 215);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Transaction:";
            this.label4.Click += new System.EventHandler(this.ucount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Offered Package Count:";
            this.label3.Click += new System.EventHandler(this.ucount_Click);
            // 
            // lab_totaltrans
            // 
            this.lab_totaltrans.AutoSize = true;
            this.lab_totaltrans.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lab_totaltrans.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_totaltrans.Location = new System.Drawing.Point(255, 166);
            this.lab_totaltrans.Name = "lab_totaltrans";
            this.lab_totaltrans.Size = new System.Drawing.Size(28, 21);
            this.lab_totaltrans.TabIndex = 12;
            this.lab_totaltrans.Text = "##";
            this.lab_totaltrans.Click += new System.EventHandler(this.ucount_Click);
            // 
            // lab_opackcount
            // 
            this.lab_opackcount.AutoSize = true;
            this.lab_opackcount.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lab_opackcount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_opackcount.Location = new System.Drawing.Point(255, 124);
            this.lab_opackcount.Name = "lab_opackcount";
            this.lab_opackcount.Size = new System.Drawing.Size(28, 21);
            this.lab_opackcount.TabIndex = 12;
            this.lab_opackcount.Text = "##";
            this.lab_opackcount.Click += new System.EventHandler(this.ucount_Click);
            // 
            // lab_agcount
            // 
            this.lab_agcount.AutoSize = true;
            this.lab_agcount.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lab_agcount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_agcount.Location = new System.Drawing.Point(255, 80);
            this.lab_agcount.Name = "lab_agcount";
            this.lab_agcount.Size = new System.Drawing.Size(28, 21);
            this.lab_agcount.TabIndex = 12;
            this.lab_agcount.Text = "##";
            this.lab_agcount.Click += new System.EventHandler(this.ucount_Click);
            // 
            // lab_ucount
            // 
            this.lab_ucount.AutoSize = true;
            this.lab_ucount.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lab_ucount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ucount.Location = new System.Drawing.Point(255, 38);
            this.lab_ucount.Name = "lab_ucount";
            this.lab_ucount.Size = new System.Drawing.Size(28, 21);
            this.lab_ucount.TabIndex = 12;
            this.lab_ucount.Text = "##";
            this.lab_ucount.Click += new System.EventHandler(this.ucount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Agency Count:";
            this.label2.Click += new System.EventHandler(this.ucount_Click);
            // 
            // ucount
            // 
            this.ucount.AutoSize = true;
            this.ucount.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ucount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucount.Location = new System.Drawing.Point(4, 38);
            this.ucount.Name = "ucount";
            this.ucount.Size = new System.Drawing.Size(91, 21);
            this.ucount.TabIndex = 12;
            this.ucount.Text = "User Count:";
            this.ucount.Click += new System.EventHandler(this.ucount_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "OVERVIEW";
            // 
            // CustomerInfo
            // 
            this.CustomerInfo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.CustomerInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfo.Location = new System.Drawing.Point(239, 135);
            this.CustomerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerInfo.Name = "CustomerInfo";
            this.CustomerInfo.Size = new System.Drawing.Size(148, 39);
            this.CustomerInfo.TabIndex = 10;
            this.CustomerInfo.Text = "Customer Info";
            this.CustomerInfo.UseVisualStyleBackColor = false;
            this.CustomerInfo.Click += new System.EventHandler(this.CustomerInfo_Click_1);
            // 
            // AgenciesInfo
            // 
            this.AgenciesInfo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.AgenciesInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgenciesInfo.Location = new System.Drawing.Point(239, 181);
            this.AgenciesInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgenciesInfo.Name = "AgenciesInfo";
            this.AgenciesInfo.Size = new System.Drawing.Size(148, 36);
            this.AgenciesInfo.TabIndex = 11;
            this.AgenciesInfo.Text = "Agencies Info";
            this.AgenciesInfo.UseVisualStyleBackColor = false;
            this.AgenciesInfo.Click += new System.EventHandler(this.AgenciesInfo_Click_1);
            // 
            // PackageInfo
            // 
            this.PackageInfo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.PackageInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageInfo.Location = new System.Drawing.Point(392, 135);
            this.PackageInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PackageInfo.Name = "PackageInfo";
            this.PackageInfo.Size = new System.Drawing.Size(148, 41);
            this.PackageInfo.TabIndex = 12;
            this.PackageInfo.Text = "Package Info";
            this.PackageInfo.UseVisualStyleBackColor = false;
            this.PackageInfo.Click += new System.EventHandler(this.PackageInfo_Click_1);
            // 
            // TransactionInfo
            // 
            this.TransactionInfo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.TransactionInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionInfo.Location = new System.Drawing.Point(392, 181);
            this.TransactionInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransactionInfo.Name = "TransactionInfo";
            this.TransactionInfo.Size = new System.Drawing.Size(148, 36);
            this.TransactionInfo.TabIndex = 13;
            this.TransactionInfo.Text = "Transaction Info";
            this.TransactionInfo.UseVisualStyleBackColor = false;
            this.TransactionInfo.Click += new System.EventHandler(this.TransactionInfo_Click_1);
            // 
            // CustomerPackInfo
            // 
            this.CustomerPackInfo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.CustomerPackInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPackInfo.Location = new System.Drawing.Point(545, 137);
            this.CustomerPackInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerPackInfo.Name = "CustomerPackInfo";
            this.CustomerPackInfo.Size = new System.Drawing.Size(195, 39);
            this.CustomerPackInfo.TabIndex = 14;
            this.CustomerPackInfo.Text = "Customer Pack. Info";
            this.CustomerPackInfo.UseVisualStyleBackColor = false;
            this.CustomerPackInfo.Click += new System.EventHandler(this.CustomerPackInfo_Click_1);
            // 
            // CustomizedPackInfo
            // 
            this.CustomizedPackInfo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.CustomizedPackInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomizedPackInfo.Location = new System.Drawing.Point(545, 181);
            this.CustomizedPackInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomizedPackInfo.Name = "CustomizedPackInfo";
            this.CustomizedPackInfo.Size = new System.Drawing.Size(195, 36);
            this.CustomizedPackInfo.TabIndex = 15;
            this.CustomizedPackInfo.Text = "Customized Pack. Info";
            this.CustomizedPackInfo.UseVisualStyleBackColor = false;
            this.CustomizedPackInfo.Click += new System.EventHandler(this.CustomizedPackInfo_Click_1);
            // 
            // rad_customer
            // 
            this.rad_customer.AutoSize = true;
            this.rad_customer.Location = new System.Drawing.Point(15, 167);
            this.rad_customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rad_customer.Name = "rad_customer";
            this.rad_customer.Size = new System.Drawing.Size(82, 20);
            this.rad_customer.TabIndex = 16;
            this.rad_customer.TabStop = true;
            this.rad_customer.Text = "Customer";
            this.rad_customer.UseVisualStyleBackColor = true;
            // 
            // rad_agency
            // 
            this.rad_agency.AutoSize = true;
            this.rad_agency.Location = new System.Drawing.Point(115, 165);
            this.rad_agency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rad_agency.Name = "rad_agency";
            this.rad_agency.Size = new System.Drawing.Size(71, 20);
            this.rad_agency.TabIndex = 16;
            this.rad_agency.TabStop = true;
            this.rad_agency.Text = "Agency";
            this.rad_agency.UseVisualStyleBackColor = true;
            // 
            // rad_pack
            // 
            this.rad_pack.AutoSize = true;
            this.rad_pack.Location = new System.Drawing.Point(15, 196);
            this.rad_pack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rad_pack.Name = "rad_pack";
            this.rad_pack.Size = new System.Drawing.Size(80, 20);
            this.rad_pack.TabIndex = 16;
            this.rad_pack.TabStop = true;
            this.rad_pack.Text = "Package";
            this.rad_pack.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(115, 196);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 20);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Agency";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rad_payment
            // 
            this.rad_payment.AutoSize = true;
            this.rad_payment.Location = new System.Drawing.Point(115, 196);
            this.rad_payment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rad_payment.Name = "rad_payment";
            this.rad_payment.Size = new System.Drawing.Size(78, 20);
            this.rad_payment.TabIndex = 16;
            this.rad_payment.TabStop = true;
            this.rad_payment.Text = "Payment";
            this.rad_payment.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(168, 137);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(64, 28);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "....";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(1148, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 19);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 645);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.rad_payment);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.rad_pack);
            this.Controls.Add(this.rad_agency);
            this.Controls.Add(this.rad_customer);
            this.Controls.Add(this.CustomizedPackInfo);
            this.Controls.Add(this.CustomerPackInfo);
            this.Controls.Add(this.TransactionInfo);
            this.Controls.Add(this.PackageInfo);
            this.Controls.Add(this.AgenciesInfo);
            this.Controls.Add(this.CustomerInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label Search;
        private TextBox SearchTextBox;
        private Panel panel1;
        private Label label8;
        private Button CustomerInfo;
        private Button AgenciesInfo;
        private Button PackageInfo;
        private Button TransactionInfo;
        private Button CustomerPackInfo;
        private Label ucount;
        private Button CustomizedPackInfo;
        private RadioButton rad_customer;
        private RadioButton rad_agency;
        private RadioButton rad_pack;
        private RadioButton radioButton4;
        private RadioButton rad_payment;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lab_ucount;
        private Label lab_totaltrans;
        private Label lab_opackcount;
        private Label lab_agcount;
        private Button btn_search;
        private LinkLabel linkLabel1;
    }
}