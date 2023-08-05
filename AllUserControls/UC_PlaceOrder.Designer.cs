namespace PRBs_Restuarant.AllUserControls
{
    partial class UC_PlaceOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblTotalAmount = new Label();
            listBox1 = new ListBox();
            txtItemName = new TextBox();
            txtPrice = new TextBox();
            txttotal = new TextBox();
            combocat = new ComboBox();
            txtQuntyupdown = new NumericUpDown();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            BtnAddtocart = new Button();
            BtnRemove = new Button();
            Btnprint = new Button();
            textBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtQuntyupdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 118, 225);
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 17);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 0;
            label1.Text = "Place To Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 65);
            label2.Name = "label2";
            label2.Size = new Size(68, 18);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(310, 45);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 2;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(591, 45);
            label4.Name = "label4";
            label4.Size = new Size(42, 18);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(328, 109);
            label5.Name = "label5";
            label5.Size = new Size(62, 18);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(592, 112);
            label6.Name = "label6";
            label6.Size = new Size(41, 18);
            label6.TabIndex = 5;
            label6.Text = "Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(517, 388);
            label7.Name = "label7";
            label7.Size = new Size(117, 22);
            label7.TabIndex = 6;
            label7.Text = "Grand Total";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.BackColor = Color.RosyBrown;
            lblTotalAmount.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalAmount.Location = new Point(499, 421);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(168, 55);
            lblTotalAmount.TabIndex = 7;
            lblTotalAmount.Text = "Rs. 00";
            lblTotalAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(59, 195);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(157, 290);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(400, 45);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(150, 27);
            txtItemName.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(665, 45);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 11;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(665, 105);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(125, 27);
            txttotal.TabIndex = 12;
            // 
            // combocat
            // 
            combocat.FormattingEnabled = true;
            combocat.Items.AddRange(new object[] { "South Indian", "North Indian", "Soft Drinks", "Cocktails", "Icecreams", "Chats" });
            combocat.Location = new Point(59, 99);
            combocat.Name = "combocat";
            combocat.Size = new Size(151, 28);
            combocat.TabIndex = 13;
            combocat.SelectedIndexChanged += combocat_SelectedIndexChanged;
            // 
            // txtQuntyupdown
            // 
            txtQuntyupdown.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuntyupdown.Location = new Point(411, 109);
            txtQuntyupdown.Name = "txtQuntyupdown";
            txtQuntyupdown.Size = new Size(150, 27);
            txtQuntyupdown.TabIndex = 14;
            txtQuntyupdown.ValueChanged += txtQuntyupdown_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(258, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(592, 163);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "item Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Unit Price";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // BtnAddtocart
            // 
            BtnAddtocart.BackColor = Color.FromArgb(0, 118, 225);
            BtnAddtocart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddtocart.ForeColor = Color.White;
            BtnAddtocart.Location = new Point(665, 150);
            BtnAddtocart.Name = "BtnAddtocart";
            BtnAddtocart.Size = new Size(125, 37);
            BtnAddtocart.TabIndex = 16;
            BtnAddtocart.Text = "Add To Cart";
            BtnAddtocart.UseVisualStyleBackColor = false;
            BtnAddtocart.Click += BtnAddtocart_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.BackColor = Color.FromArgb(0, 118, 225);
            BtnRemove.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRemove.ForeColor = Color.White;
            BtnRemove.Location = new Point(310, 421);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(125, 37);
            BtnRemove.TabIndex = 17;
            BtnRemove.Text = "Remove";
            BtnRemove.UseVisualStyleBackColor = false;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // Btnprint
            // 
            Btnprint.BackColor = Color.FromArgb(0, 118, 225);
            Btnprint.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btnprint.ForeColor = Color.White;
            Btnprint.Location = new Point(714, 421);
            Btnprint.Name = "Btnprint";
            Btnprint.Size = new Size(125, 37);
            Btnprint.TabIndex = 18;
            Btnprint.Text = "Print";
            Btnprint.UseVisualStyleBackColor = false;
            Btnprint.Click += Btnprint_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(76, 150);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Search";
            textBoxSearch.Size = new Size(125, 27);
            textBoxSearch.TabIndex = 19;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // UC_PlaceOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(textBoxSearch);
            Controls.Add(Btnprint);
            Controls.Add(BtnRemove);
            Controls.Add(BtnAddtocart);
            Controls.Add(dataGridView1);
            Controls.Add(txtQuntyupdown);
            Controls.Add(combocat);
            Controls.Add(txttotal);
            Controls.Add(txtPrice);
            Controls.Add(txtItemName);
            Controls.Add(listBox1);
            Controls.Add(lblTotalAmount);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_PlaceOrder";
            Size = new Size(955, 499);
            ((System.ComponentModel.ISupportInitialize)txtQuntyupdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblTotalAmount;
        private ListBox listBox1;
        private TextBox txtSearch;
        private TextBox txtItemName;
        private TextBox txtPrice;
        private TextBox txttotal;
        private ComboBox combocat;
        private NumericUpDown txtQuntyupdown;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button BtnAddtocart;
        private Button BtnRemove;
        private Button Btnprint;
        private TextBox textBoxSearch;
    }
}
