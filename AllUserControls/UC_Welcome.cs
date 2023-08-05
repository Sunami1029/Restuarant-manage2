using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRBs_Restuarant.AllUserControls
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                lblBanner.Location = new Point(263, 447);
                lblBanner.ForeColor = Color.Orange;
                num++;
            }
            else if (num == 1)
            {
                lblBanner.Location = new Point(126, 397);
                lblBanner.ForeColor = Color.RoyalBlue;
                num++;
            }
            else if (num == 2)
            {
                lblBanner.Location = new Point(575, 442);
                lblBanner.ForeColor = Color.Green;
                num = 0;
            }
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
