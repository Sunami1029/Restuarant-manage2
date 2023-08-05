namespace PRBs_Restuarant.AllUserControls
{
    partial class UC_Remove
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
            txtSearchI = new TextBox();
            dataGridView1 = new DataGridView();
            lblDel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 118, 225);
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(245, 54);
            label1.TabIndex = 0;
            label1.Text = "Delete Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(482, 46);
            label2.Name = "label2";
            label2.Size = new Size(164, 38);
            label2.TabIndex = 1;
            label2.Text = "Item Name";
            // 
            // txtSearchI
            // 
            txtSearchI.Location = new Point(494, 97);
            txtSearchI.Name = "txtSearchI";
            txtSearchI.PlaceholderText = "Start Typing...";
            txtSearchI.Size = new Size(157, 27);
            txtSearchI.TabIndex = 2;
            txtSearchI.TextChanged += txtSearchI_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(20, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(834, 267);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblDel
            // 
            lblDel.AutoSize = true;
            lblDel.BackColor = Color.White;
            lblDel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDel.ForeColor = Color.FromArgb(0, 118, 225);
            lblDel.Location = new Point(667, 425);
            lblDel.Name = "lblDel";
            lblDel.Size = new Size(123, 28);
            lblDel.TabIndex = 4;
            lblDel.Text = "Delete Item";
            // 
            // UC_Remove
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblDel);
            Controls.Add(dataGridView1);
            Controls.Add(txtSearchI);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Remove";
            Size = new Size(878, 502);
            Load += UC_Remove_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchI;
        private DataGridView dataGridView1;
        private Label lblDel;
    }
}
