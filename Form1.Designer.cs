namespace PRBs_Restuarant
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            BtnGuest = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(0, 118, 225);
            BtnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(149, 405);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(137, 39);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(104, 245);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(104, 317);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(104, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(104, 277);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Enter Your User Name";
            txtUser.Size = new Size(238, 27);
            txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(104, 354);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Enter Your Password";
            txtPass.Size = new Size(238, 27);
            txtPass.TabIndex = 5;
            // 
            // BtnGuest
            // 
            BtnGuest.AutoSize = true;
            BtnGuest.ForeColor = Color.Yellow;
            BtnGuest.LinkColor = Color.Yellow;
            BtnGuest.Location = new Point(149, 476);
            BtnGuest.Name = "BtnGuest";
            BtnGuest.Size = new Size(129, 20);
            BtnGuest.TabIndex = 6;
            BtnGuest.TabStop = true;
            BtnGuest.Text = "Continue As Guest";
            BtnGuest.LinkClicked += BtnGuest_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 44, 41);
            ClientSize = new Size(448, 538);
            Controls.Add(BtnGuest);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnLogin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLogin;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox txtUser;
        private TextBox txtPass;
        private LinkLabel BtnGuest;
    }
}