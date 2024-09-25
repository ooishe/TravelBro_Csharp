namespace TravelBro
{
    partial class agency_home
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
            this.components = new System.ComponentModel.Container();
            this.agency_picbox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.save = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.txt_p_id = new System.Windows.Forms.TextBox();
            this.txt_p_dest = new System.Windows.Forms.TextBox();
            this.txt_p_hotel = new System.Windows.Forms.TextBox();
            this.txt_p_person = new System.Windows.Forms.TextBox();
            this.txt_p_price = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.travelBroDataSet = new TravelBro.TravelBroDataSet();
            this.prepackinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prepack_infoTableAdapter = new TravelBro.TravelBroDataSetTableAdapters.prepack_infoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.cus_view_lab = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.agency_picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepackinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // agency_picbox
            // 
            this.agency_picbox.Location = new System.Drawing.Point(95, 113);
            this.agency_picbox.Name = "agency_picbox";
            this.agency_picbox.Size = new System.Drawing.Size(246, 142);
            this.agency_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.agency_picbox.TabIndex = 0;
            this.agency_picbox.TabStop = false;
            this.agency_picbox.Click += new System.EventHandler(this.agency_picbox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Package ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hotel :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Persons :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Price :";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Gold;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(262, 258);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(79, 14);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Browse Image";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.DarkOrange;
            this.save.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(266, 472);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.DarkOrange;
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(185, 472);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.DarkOrange;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(104, 472);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 5;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // txt_p_id
            // 
            this.txt_p_id.Location = new System.Drawing.Point(168, 288);
            this.txt_p_id.Name = "txt_p_id";
            this.txt_p_id.Size = new System.Drawing.Size(197, 20);
            this.txt_p_id.TabIndex = 6;
            this.txt_p_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_p_dest
            // 
            this.txt_p_dest.Location = new System.Drawing.Point(169, 318);
            this.txt_p_dest.Name = "txt_p_dest";
            this.txt_p_dest.Size = new System.Drawing.Size(197, 20);
            this.txt_p_dest.TabIndex = 6;
            this.txt_p_dest.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_p_hotel
            // 
            this.txt_p_hotel.Location = new System.Drawing.Point(168, 347);
            this.txt_p_hotel.Name = "txt_p_hotel";
            this.txt_p_hotel.Size = new System.Drawing.Size(197, 20);
            this.txt_p_hotel.TabIndex = 6;
            this.txt_p_hotel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_p_person
            // 
            this.txt_p_person.Location = new System.Drawing.Point(169, 371);
            this.txt_p_person.Name = "txt_p_person";
            this.txt_p_person.Size = new System.Drawing.Size(72, 20);
            this.txt_p_person.TabIndex = 6;
            this.txt_p_person.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_p_price
            // 
            this.txt_p_price.Location = new System.Drawing.Point(168, 430);
            this.txt_p_price.Name = "txt_p_price";
            this.txt_p_price.Size = new System.Drawing.Size(196, 20);
            this.txt_p_price.TabIndex = 6;
            this.txt_p_price.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 294);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkOrange;
            this.delete.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(878, 450);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // travelBroDataSet
            // 
            this.travelBroDataSet.DataSetName = "TravelBroDataSet";
            this.travelBroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prepackinfoBindingSource
            // 
            this.prepackinfoBindingSource.DataMember = "prepack_info";
            this.prepackinfoBindingSource.DataSource = this.travelBroDataSet;
            // 
            // prepack_infoTableAdapter
            // 
            this.prepack_infoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Duration :";
            // 
            // txt_duration
            // 
            this.txt_duration.Location = new System.Drawing.Point(168, 397);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(196, 20);
            this.txt_duration.TabIndex = 6;
            this.txt_duration.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cus_view_lab
            // 
            this.cus_view_lab.AutoSize = true;
            this.cus_view_lab.BackColor = System.Drawing.Color.Transparent;
            this.cus_view_lab.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cus_view_lab.LinkColor = System.Drawing.Color.Black;
            this.cus_view_lab.Location = new System.Drawing.Point(872, 24);
            this.cus_view_lab.Name = "cus_view_lab";
            this.cus_view_lab.Size = new System.Drawing.Size(108, 19);
            this.cus_view_lab.TabIndex = 8;
            this.cus_view_lab.TabStop = true;
            this.cus_view_lab.Text = "Customer View";
            this.cus_view_lab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cus_view_lab_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(788, 23);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 18);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // agency_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TravelBro.Properties.Resources.agency_home;
            this.ClientSize = new System.Drawing.Size(1009, 547);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cus_view_lab);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.txt_p_price);
            this.Controls.Add(this.txt_p_person);
            this.Controls.Add(this.txt_p_hotel);
            this.Controls.Add(this.txt_p_dest);
            this.Controls.Add(this.txt_p_id);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.agency_picbox);
            this.Name = "agency_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agency_home";
            this.Load += new System.EventHandler(this.agency_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agency_picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelBroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepackinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox agency_picbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox txt_p_id;
        private System.Windows.Forms.TextBox txt_p_dest;
        private System.Windows.Forms.TextBox txt_p_hotel;
        private System.Windows.Forms.TextBox txt_p_person;
        private System.Windows.Forms.TextBox txt_p_price;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private TravelBroDataSet travelBroDataSet;
        private System.Windows.Forms.BindingSource prepackinfoBindingSource;
        private TravelBroDataSetTableAdapters.prepack_infoTableAdapter prepack_infoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.LinkLabel cus_view_lab;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}