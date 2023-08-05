using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace PRBs_Restuarant.AllUserControls
{
    public partial class UC_PlaceOrder : UserControl
    {
        Function fn = new Function();
        String query;
        private int i;

        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void combocat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String category = combocat.Text;
            query = "Select name from items where category ='" + category + "'";
            showItemlist(query);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuntyupdown.ResetText();
            txttotal.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;
            query = "select price from items where name ='" + text + "'";
            DataSet ds = fn.GetData(query);

            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }
        }

        private void txtQuntyupdown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuntyupdown.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txttotal.Text = (quan * price).ToString();
        }
        protected int n, total = 0;
        private void BtnAddtocart_Click(object sender, EventArgs e)
        {
            if (txttotal.Text != "0" && txttotal.Text != "")
            {


                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtQuntyupdown.Value;
                dataGridView1.Rows[n].Cells[3].Value = txttotal.Text;

                total = total + int.Parse(txttotal.Text);
                lblTotalAmount.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("minimum Quantity need to be 1", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int amount;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }

        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index );
            }
            catch { }
            total -= amount;
            lblTotalAmount.Text = "Rs.  " + total;
            
            
        }

        private void Btnprint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Customer Bill"  + " "+  "Of " +"kummi's Kitchen";
             
            
            printer.SubTitle = String.Format("Date:{0}", DateTime.Now.ToLocalTime().ToString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PageText = String.Format("Welcome Again 🙏  ");
            
            printer.Footer = "Total Payable Amount :" + lblTotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
            


            total = 0;
            dataGridView1.Rows.Clear();
            lblTotalAmount.Text = "Rs. " + total;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            String category = combocat.Text;
            query = "Select name from items where category ='" + category + "' and name like '"+textBoxSearch.Text +"%'";
            showItemlist(query);
        }
        private void showItemlist(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

    }

}
