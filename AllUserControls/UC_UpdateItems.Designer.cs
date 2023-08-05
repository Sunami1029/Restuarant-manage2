namespace PRBs_Restuarant.AllUserControls
{
    partial class UC_UpdateItems
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
            txtSearchItem = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtcatgory = new TextBox();
            txtIm = new TextBox();
            txtPricee = new TextBox();
            BtnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 118, 225);
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 11);
            label1.Name = "label1";
            label1.Size = new Size(261, 54);
            label1.TabIndex = 0;
            label1.Text = "Update Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(619, 27);
            label2.Name = "label2";
            label2.Size = new Size(164, 38);
            label2.TabIndex = 1;
            label2.Text = "Item Name";
            // 
            // txtSearchItem
            // 
            txtSearchItem.Location = new Point(634, 86);
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.PlaceholderText = "Start Typing...";
            txtSearchItem.Size = new Size(203, 27);
            txtSearchItem.TabIndex = 2;
            txtSearchItem.TextChanged += txtSearchItem_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(32, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(815, 224);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(65, 367);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(65, 422);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 5;
            label4.Text = "Item Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(498, 371);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 6;
            label5.Text = "Price";
            // 
            // txtcatgory
            // 
            txtcatgory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtcatgory.Location = new Point(199, 367);
            txtcatgory.Name = "txtcatgory";
            txtcatgory.PlaceholderText = "Category";
            txtcatgory.Size = new Size(203, 24);
            txtcatgory.TabIndex = 7;
            // 
            // txtIm
            // 
            txtIm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtIm.Location = new Point(199, 415);
            txtIm.Name = "txtIm";
            txtIm.PlaceholderText = "Item Name";
            txtIm.Size = new Size(203, 27);
            txtIm.TabIndex = 8;
            // 
            // txtPricee
            // 
            txtPricee.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPricee.Location = new Point(592, 371);
            txtPricee.Name = "txtPricee";
            txtPricee.PlaceholderText = "Item Price";
            txtPricee.Size = new Size(203, 24);
            txtPricee.TabIndex = 9;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.FromArgb(0, 118, 225);
            BtnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.Location = new Point(619, 442);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(197, 44);
            BtnUpdate.TabIndex = 10;
            BtnUpdate.Text = "Update";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // UC_UpdateItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(BtnUpdate);
            Controls.Add(txtPricee);
            Controls.Add(txtIm);
            Controls.Add(txtcatgory);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchItem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_UpdateItems";
            Size = new Size(877, 511);
            Load += UC_UpdateItems_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchItem;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtcatgory;
        private TextBox txtIm;
        private TextBox txtPricee;
        private Button BtnUpdate;
    }
}
