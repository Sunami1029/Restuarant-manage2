namespace PRBs_Restuarant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Admin" && txtPass.Text == "2580")
            {
                Dashboard ds = new Dashboard("Admin");
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}