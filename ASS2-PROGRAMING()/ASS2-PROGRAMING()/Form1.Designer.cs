namespace ASS2_PROGRAMING__
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcalculate = new System.Windows.Forms.Button();
            this.txtreset = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.NumericUpDown();
            this.txttype = new System.Windows.Forms.ComboBox();
            this.txtthismonth = new System.Windows.Forms.TextBox();
            this.txtlastmonth = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbill = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtdelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(25, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Month\'s Reading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(25, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "This Month\'s Reading";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtcalculate);
            this.groupBox1.Controls.Add(this.txtreset);
            this.groupBox1.Controls.Add(this.txtnum);
            this.groupBox1.Controls.Add(this.txttype);
            this.groupBox1.Controls.Add(this.txtthismonth);
            this.groupBox1.Controls.Add(this.txtlastmonth);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(83, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1072, 345);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(444, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "m3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(444, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "m3";
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtphone.Location = new System.Drawing.Point(713, 50);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(234, 46);
            this.txtphone.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(519, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Phone number";
            // 
            // txtcalculate
            // 
            this.txtcalculate.Location = new System.Drawing.Point(924, 295);
            this.txtcalculate.Name = "txtcalculate";
            this.txtcalculate.Size = new System.Drawing.Size(135, 44);
            this.txtcalculate.TabIndex = 12;
            this.txtcalculate.Text = "Calculate";
            this.txtcalculate.UseVisualStyleBackColor = true;
            this.txtcalculate.Click += new System.EventHandler(this.txtcalculate_Click);
            // 
            // txtreset
            // 
            this.txtreset.Location = new System.Drawing.Point(769, 295);
            this.txtreset.Name = "txtreset";
            this.txtreset.Size = new System.Drawing.Size(135, 44);
            this.txtreset.TabIndex = 11;
            this.txtreset.Text = "Reset";
            this.txtreset.UseVisualStyleBackColor = true;
            this.txtreset.Click += new System.EventHandler(this.txtreset_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(713, 238);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(220, 31);
            this.txtnum.TabIndex = 10;
            // 
            // txttype
            // 
            this.txttype.FormattingEnabled = true;
            this.txttype.Items.AddRange(new object[] {
            "Household",
            "Administrative agency",
            "Public services",
            "Production units",
            "Business services"});
            this.txttype.Location = new System.Drawing.Point(713, 149);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(220, 33);
            this.txttype.TabIndex = 8;
            this.txttype.SelectedIndexChanged += new System.EventHandler(this.txttype_SelectedIndexChanged_1);
            // 
            // txtthismonth
            // 
            this.txtthismonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtthismonth.Location = new System.Drawing.Point(251, 222);
            this.txtthismonth.Multiline = true;
            this.txtthismonth.Name = "txtthismonth";
            this.txtthismonth.Size = new System.Drawing.Size(234, 47);
            this.txtthismonth.TabIndex = 7;
            // 
            // txtlastmonth
            // 
            this.txtlastmonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtlastmonth.Location = new System.Drawing.Point(251, 134);
            this.txtlastmonth.Multiline = true;
            this.txtlastmonth.Name = "txtlastmonth";
            this.txtlastmonth.Size = new System.Drawing.Size(234, 48);
            this.txtlastmonth.TabIndex = 6;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtname.Location = new System.Drawing.Point(251, 50);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(234, 46);
            this.txtname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(519, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Type";
            // 
            // txtnumber
            // 
            this.txtnumber.AutoSize = true;
            this.txtnumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtnumber.Location = new System.Drawing.Point(519, 238);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(188, 25);
            this.txtnumber.TabIndex = 3;
            this.txtnumber.Text = "Number Of People";
            this.txtnumber.Click += new System.EventHandler(this.txtnumber_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(78, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Result";
            // 
            // txtbill
            // 
            this.txtbill.BackColor = System.Drawing.Color.White;
            this.txtbill.Location = new System.Drawing.Point(83, 404);
            this.txtbill.Multiline = true;
            this.txtbill.Name = "txtbill";
            this.txtbill.Size = new System.Drawing.Size(416, 126);
            this.txtbill.TabIndex = 7;
            // 
            // listView2
            // 
            this.listView2.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.HotTracking = true;
            this.listView2.HoverSelection = true;
            this.listView2.Location = new System.Drawing.Point(83, 555);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1072, 192);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stt";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Customer Type";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total";
            this.columnHeader7.Width = 120;
            // 
            // txtdelete
            // 
            this.txtdelete.Location = new System.Drawing.Point(495, 127);
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(135, 44);
            this.txtdelete.TabIndex = 13;
            this.txtdelete.Text = "Delete";
            this.txtdelete.UseVisualStyleBackColor = true;
            this.txtdelete.Click += new System.EventHandler(this.txtdelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(996, 753);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btSort);
            this.groupBox2.Controls.Add(this.txtSearchPhone);
            this.groupBox2.Controls.Add(this.txtSearchName);
            this.groupBox2.Controls.Add(this.txtdelete);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btSearch);
            this.groupBox2.Location = new System.Drawing.Point(501, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 175);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Finding customers";
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchPhone.Location = new System.Drawing.Point(196, 120);
            this.txtSearchPhone.Multiline = true;
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(234, 46);
            this.txtSearchPhone.TabIndex = 17;
            this.txtSearchPhone.TextChanged += new System.EventHandler(this.txtSearchPhone_TextChanged);
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchName.Location = new System.Drawing.Point(196, 56);
            this.txtSearchName.Multiline = true;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(234, 46);
            this.txtSearchName.TabIndex = 15;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(21, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(21, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Custom name";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(495, 19);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(135, 44);
            this.btSearch.TabIndex = 12;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btSort
            // 
            this.btSort.Location = new System.Drawing.Point(495, 72);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(135, 44);
            this.btSort.TabIndex = 18;
            this.btSort.Text = "Arrange";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::ASS2_PROGRAMING__.Properties.Resources.water;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 809);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.txtbill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Water bill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtnumber;
        private System.Windows.Forms.ComboBox txttype;
        private System.Windows.Forms.TextBox txtthismonth;
        private System.Windows.Forms.TextBox txtlastmonth;
        private System.Windows.Forms.NumericUpDown txtnum;
        private System.Windows.Forms.Button txtcalculate;
        private System.Windows.Forms.Button txtreset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbill;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button txtdelete;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btSort;
    }
}

