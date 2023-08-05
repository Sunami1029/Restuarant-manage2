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
    public partial class UC_UpdateItems : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {

            loadData();
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like'" + txtSearchItem.Text + "%'";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtcatgory.Text = category;
            txtIm.Text = name;
            txtPricee.Text = price.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            query = "update items set name='" + txtIm.Text + "',category = '" + txtcatgory.Text + "',price=" + txtPricee.Text + "where id=" + id + "";
            fn.setData(query);
            loadData();

            txtIm.Clear();
            txtcatgory.Clear();
            txtPricee.Clear();
        }
    }
}
