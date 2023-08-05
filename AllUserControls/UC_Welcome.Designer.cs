namespace PRBs_Restuarant.AllUserControls
{
    partial class UC_Welcome
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Welcome));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblBanner = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(717, 332);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 118, 225);
            label1.Location = new Point(526, 361);
            label1.Name = "label1";
            label1.Size = new Size(53, 38);
            label1.TabIndex = 1;
            label1.Text = "TO";
            // 
            // lblBanner
            // 
            lblBanner.AutoSize = true;
            lblBanner.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBanner.ForeColor = Color.Red;
            lblBanner.Location = new Point(575, 442);
            lblBanner.Name = "lblBanner";
            lblBanner.Size = new Size(253, 41);
            lblBanner.TabIndex = 2;
            lblBanner.Text = "Kummi's Kitchen";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // UC_Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblBanner);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "UC_Welcome";
            Size = new Size(887, 508);
            Load += UC_Welcome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblBanner;
        private System.Windows.Forms.Timer timer1;
    }
}
