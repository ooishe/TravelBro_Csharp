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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Search = new Label();
            SearchTextBox = new TextBox();
            panel1 = new Panel();
            Tagency = new Label();
            Ttransaction = new Label();
            ucount = new Label();
            Tpackage = new Label();
            label8 = new Label();
            CustomerInfo = new Button();
            AgenciesInfo = new Button();
            PackageInfo = new Button();
            TransactionInfo = new Button();
            CustomerPackInfo = new Button();
            CustomizedPackInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.BlanchedAlmond;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(390, 21);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.BlanchedAlmond;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(603, 269);
            dataGridView1.TabIndex = 6;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.BackColor = Color.BlanchedAlmond;
            Search.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Search.Location = new Point(671, 192);
            Search.Name = "Search";
            Search.Size = new Size(64, 22);
            Search.TabIndex = 7;
            Search.Text = "Search";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(765, 190);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(182, 27);
            SearchTextBox.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(Tagency);
            panel1.Controls.Add(Ttransaction);
            panel1.Controls.Add(ucount);
            panel1.Controls.Add(Tpackage);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(625, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 269);
            panel1.TabIndex = 9;
            // 
            // Tagency
            // 
            Tagency.AutoSize = true;
            Tagency.BackColor = Color.BlanchedAlmond;
            Tagency.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tagency.Location = new Point(8, 211);
            Tagency.Name = "Tagency";
            Tagency.Size = new Size(167, 33);
            Tagency.TabIndex = 14;
            Tagency.Text = "Total Agency:";
            // 
            // Ttransaction
            // 
            Ttransaction.AutoSize = true;
            Ttransaction.BackColor = Color.BlanchedAlmond;
            Ttransaction.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Ttransaction.Location = new Point(8, 154);
            Ttransaction.Name = "Ttransaction";
            Ttransaction.Size = new Size(214, 33);
            Ttransaction.TabIndex = 13;
            Ttransaction.Text = "Total Transaction:";
            // 
            // ucount
            // 
            ucount.AutoSize = true;
            ucount.BackColor = Color.BlanchedAlmond;
            ucount.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucount.Location = new Point(3, 49);
            ucount.Name = "ucount";
            ucount.Size = new Size(150, 33);
            ucount.TabIndex = 12;
            ucount.Text = "User Count:";
            ucount.Click += label3_Click;
            // 
            // Tpackage
            // 
            Tpackage.AutoSize = true;
            Tpackage.BackColor = Color.BlanchedAlmond;
            Tpackage.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tpackage.Location = new Point(3, 105);
            Tpackage.Name = "Tpackage";
            Tpackage.Size = new Size(256, 33);
            Tpackage.TabIndex = 11;
            Tpackage.Text = "Total Offerd Package:";
            Tpackage.Click += label2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.BlanchedAlmond;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(103, 14);
            label8.Name = "label8";
            label8.Size = new Size(139, 25);
            label8.TabIndex = 10;
            label8.Text = "OVERVIEW";
            label8.Click += label8_Click;
            // 
            // CustomerInfo
            // 
            CustomerInfo.BackColor = Color.BlanchedAlmond;
            CustomerInfo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerInfo.Location = new Point(12, 137);
            CustomerInfo.Name = "CustomerInfo";
            CustomerInfo.Size = new Size(148, 29);
            CustomerInfo.TabIndex = 10;
            CustomerInfo.Text = "Customer Info";
            CustomerInfo.UseVisualStyleBackColor = false;
            // 
            // AgenciesInfo
            // 
            AgenciesInfo.BackColor = Color.BlanchedAlmond;
            AgenciesInfo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgenciesInfo.Location = new Point(12, 192);
            AgenciesInfo.Name = "AgenciesInfo";
            AgenciesInfo.Size = new Size(148, 29);
            AgenciesInfo.TabIndex = 11;
            AgenciesInfo.Text = "Agencies Info";
            AgenciesInfo.UseVisualStyleBackColor = false;
            // 
            // PackageInfo
            // 
            PackageInfo.BackColor = Color.BlanchedAlmond;
            PackageInfo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PackageInfo.Location = new Point(187, 144);
            PackageInfo.Name = "PackageInfo";
            PackageInfo.Size = new Size(148, 29);
            PackageInfo.TabIndex = 12;
            PackageInfo.Text = "Package Info";
            PackageInfo.UseVisualStyleBackColor = false;
            // 
            // TransactionInfo
            // 
            TransactionInfo.BackColor = Color.BlanchedAlmond;
            TransactionInfo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TransactionInfo.Location = new Point(187, 192);
            TransactionInfo.Name = "TransactionInfo";
            TransactionInfo.Size = new Size(148, 29);
            TransactionInfo.TabIndex = 13;
            TransactionInfo.Text = "Transaction Info";
            TransactionInfo.UseVisualStyleBackColor = false;
            // 
            // CustomerPackInfo
            // 
            CustomerPackInfo.BackColor = Color.BlanchedAlmond;
            CustomerPackInfo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerPackInfo.Location = new Point(390, 144);
            CustomerPackInfo.Name = "CustomerPackInfo";
            CustomerPackInfo.Size = new Size(195, 29);
            CustomerPackInfo.TabIndex = 14;
            CustomerPackInfo.Text = "Customer Pack. Info";
            CustomerPackInfo.UseVisualStyleBackColor = false;
            // 
            // CustomizedPackInfo
            // 
            CustomizedPackInfo.BackColor = Color.BlanchedAlmond;
            CustomizedPackInfo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomizedPackInfo.Location = new Point(390, 192);
            CustomizedPackInfo.Name = "CustomizedPackInfo";
            CustomizedPackInfo.Size = new Size(195, 29);
            CustomizedPackInfo.TabIndex = 15;
            CustomizedPackInfo.Text = "Customized Pack. Info";
            CustomizedPackInfo.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.AdminBackground;
            ClientSize = new Size(982, 516);
            Controls.Add(CustomizedPackInfo);
            Controls.Add(CustomerPackInfo);
            Controls.Add(TransactionInfo);
            Controls.Add(PackageInfo);
            Controls.Add(AgenciesInfo);
            Controls.Add(CustomerInfo);
            Controls.Add(panel1);
            Controls.Add(SearchTextBox);
            Controls.Add(Search);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label Tagency;
        private Label Ttransaction;
        private Label ucount;
        private Label Tpackage;
        private Button CustomizedPackInfo;
    }
}