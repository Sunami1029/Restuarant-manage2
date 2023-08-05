namespace PRBs_Restuarant
{
    partial class Dashboard
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
            BtnlogOut = new LinkLabel();
            BtnExit = new Button();
            BtnRm = new Button();
            BtnUpdate = new Button();
            BtnAddItem = new Button();
            BtnPTO = new Button();
            panel2 = new Panel();
            uC_UpdateItems1 = new AllUserControls.UC_UpdateItems();
            uC_PlaceOrder1 = new AllUserControls.UC_PlaceOrder();
            uC_Additems1 = new AllUserControls.UC_Additems();
            uC_Welcome1 = new AllUserControls.UC_Welcome();
            uC_Remove1 = new AllUserControls.UC_Remove();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 118, 225);
            panel1.Controls.Add(BtnlogOut);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnRm);
            panel1.Controls.Add(BtnUpdate);
            panel1.Controls.Add(BtnAddItem);
            panel1.Controls.Add(BtnPTO);
            panel1.Location = new Point(7, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 510);
            panel1.TabIndex = 0;
            // 
            // BtnlogOut
            // 
            BtnlogOut.AutoSize = true;
            BtnlogOut.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnlogOut.LinkColor = Color.White;
            BtnlogOut.Location = new Point(134, 448);
            BtnlogOut.Name = "BtnlogOut";
            BtnlogOut.Size = new Size(91, 31);
            BtnlogOut.TabIndex = 5;
            BtnlogOut.TabStop = true;
            BtnlogOut.Text = "Logout";
            BtnlogOut.LinkClicked += BtnlogOut_LinkClicked;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.Red;
            BtnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExit.ForeColor = Color.Yellow;
            BtnExit.Location = new Point(5, 3);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(35, 32);
            BtnExit.TabIndex = 4;
            BtnExit.Text = "X";
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // BtnRm
            // 
            BtnRm.BackColor = Color.FromArgb(0, 118, 225);
            BtnRm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRm.ForeColor = Color.White;
            BtnRm.Location = new Point(84, 263);
            BtnRm.Name = "BtnRm";
            BtnRm.Size = new Size(126, 29);
            BtnRm.TabIndex = 3;
            BtnRm.Text = "Remove items";
            BtnRm.UseVisualStyleBackColor = false;
            BtnRm.Click += BtnRm_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.FromArgb(0, 118, 225);
            BtnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.Location = new Point(84, 199);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(126, 29);
            BtnUpdate.TabIndex = 2;
            BtnUpdate.Text = "Update Item";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnAddItem
            // 
            BtnAddItem.BackColor = Color.FromArgb(0, 118, 225);
            BtnAddItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddItem.ForeColor = Color.White;
            BtnAddItem.Location = new Point(84, 134);
            BtnAddItem.Name = "BtnAddItem";
            BtnAddItem.Size = new Size(126, 29);
            BtnAddItem.TabIndex = 1;
            BtnAddItem.Text = "Add Item";
            BtnAddItem.UseVisualStyleBackColor = false;
            BtnAddItem.Click += BtnAddItem_Click;
            // 
            // BtnPTO
            // 
            BtnPTO.BackColor = Color.FromArgb(0, 118, 225);
            BtnPTO.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPTO.ForeColor = Color.White;
            BtnPTO.Location = new Point(81, 81);
            BtnPTO.Name = "BtnPTO";
            BtnPTO.Size = new Size(143, 29);
            BtnPTO.TabIndex = 0;
            BtnPTO.Text = "Place To Order";
            BtnPTO.UseVisualStyleBackColor = false;
            BtnPTO.Click += BtnPTO_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(uC_Remove1);
            panel2.Controls.Add(uC_UpdateItems1);
            panel2.Controls.Add(uC_PlaceOrder1);
            panel2.Controls.Add(uC_Additems1);
            panel2.Controls.Add(uC_Welcome1);
            panel2.Location = new Point(257, 18);
            panel2.Name = "panel2";
            panel2.Size = new Size(887, 508);
            panel2.TabIndex = 1;
            // 
            // uC_UpdateItems1
            // 
            uC_UpdateItems1.BackColor = Color.White;
            uC_UpdateItems1.BorderStyle = BorderStyle.Fixed3D;
            uC_UpdateItems1.Location = new Point(6, -6);
            uC_UpdateItems1.Name = "uC_UpdateItems1";
            uC_UpdateItems1.Size = new Size(881, 515);
            uC_UpdateItems1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            uC_PlaceOrder1.BackColor = Color.Silver;
            uC_PlaceOrder1.Location = new Point(-10, 1);
            uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            uC_PlaceOrder1.Size = new Size(920, 508);
            uC_PlaceOrder1.TabIndex = 2;
            // 
            // uC_Additems1
            // 
            uC_Additems1.BackColor = Color.LightSeaGreen;
            uC_Additems1.Location = new Point(6, 3);
            uC_Additems1.Name = "uC_Additems1";
            uC_Additems1.Size = new Size(881, 508);
            uC_Additems1.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            uC_Welcome1.BackColor = Color.White;
            uC_Welcome1.Location = new Point(0, -2);
            uC_Welcome1.Name = "uC_Welcome1";
            uC_Welcome1.Size = new Size(884, 510);
            uC_Welcome1.TabIndex = 0;
            // 
            // uC_Remove1
            // 
            uC_Remove1.Location = new Point(6, 3);
            uC_Remove1.Name = "uC_Remove1";
            uC_Remove1.Size = new Size(878, 502);
            uC_Remove1.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 538);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnExit;
        private Button BtnRm;
        private Button BtnUpdate;
        private Button BtnAddItem;
        private Button BtnPTO;
        private Panel panel2;
        private LinkLabel BtnlogOut;
        private AllUserControls.UC_Welcome uC_Welcome1;
        private AllUserControls.UC_Additems uC_Additems1;
        private AllUserControls.UC_PlaceOrder uC_PlaceOrder1;
        private AllUserControls.UC_UpdateItems uC_UpdateItems1;
        private AllUserControls.UC_Remove uC_Remove1;
    }
}