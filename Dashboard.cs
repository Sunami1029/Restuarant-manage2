using PRBs_Restuarant.AllUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRBs_Restuarant
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String user)
        {
            InitializeComponent();

            if (user == "Guest")
            {
                BtnAddItem.Hide();
                BtnRm.Hide();
                BtnUpdate.Hide();
            }
            else if (user == "Admin")
            {
                BtnAddItem.Show();
                BtnUpdate.Show();
                BtnRm.Show();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnlogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            uC_Additems1.Visible = true;
            uC_Additems1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Additems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_Remove1.Visible = false;

        }

        private void BtnPTO_Click(object sender, EventArgs e)
        {
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
        }

        private void BtnRm_Click(object sender, EventArgs e)
        {
            uC_Remove1.Visible = true;
            uC_Remove1.BringToFront();
        }
    }
}
