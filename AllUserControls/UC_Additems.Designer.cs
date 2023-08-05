namespace PRBs_Restuarant.AllUserControls
{
    partial class UC_Additems
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
            BtnAddItem = new Button();
            txtcategory = new ComboBox();
            txtitemname = new TextBox();
            txtprice = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 118, 225);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(324, 44);
            label1.Name = "label1";
            label1.Size = new Size(207, 38);
            label1.TabIndex = 0;
            label1.Text = "Add New Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(228, 145);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(228, 229);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 2;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(228, 311);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 3;
            label4.Text = "Item Price";
            // 
            // BtnAddItem
            // 
            BtnAddItem.BackColor = Color.FromArgb(0, 118, 225);
            BtnAddItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddItem.ForeColor = Color.White;
            BtnAddItem.Location = new Point(289, 428);
            BtnAddItem.Name = "BtnAddItem";
            BtnAddItem.Size = new Size(197, 50);
            BtnAddItem.TabIndex = 4;
            BtnAddItem.Text = "Add Item";
            BtnAddItem.UseVisualStyleBackColor = false;
            BtnAddItem.Click += BtnAddItem_Click;
            // 
            // txtcategory
            // 
            txtcategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtcategory.FormattingEnabled = true;
            txtcategory.Items.AddRange(new object[] { "South Indian", "North Indian", "Soft Drinks", "Cocktails", "Icecreams", "Chats" });
            txtcategory.Location = new Point(228, 190);
            txtcategory.Name = "txtcategory";
            txtcategory.Size = new Size(359, 36);
            txtcategory.TabIndex = 5;
            // 
            // txtitemname
            // 
            txtitemname.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtitemname.Location = new Point(228, 274);
            txtitemname.Name = "txtitemname";
            txtitemname.Size = new Size(359, 34);
            txtitemname.TabIndex = 6;
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtprice.Location = new Point(228, 368);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(359, 34);
            txtprice.TabIndex = 7;
            // 
            // UC_Additems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            Controls.Add(txtprice);
            Controls.Add(txtitemname);
            Controls.Add(txtcategory);
            Controls.Add(BtnAddItem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Additems";
            Size = new Size(884, 510);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnAddItem;
        private ComboBox txtcategory;
        private TextBox txtitemname;
        private TextBox txtprice;
    }
}
