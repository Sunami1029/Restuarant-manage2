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
    public partial class UC_Remove : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_Remove()
        {
            InitializeComponent();
        }

        private void UC_Remove_Load(object sender, EventArgs e)
        {
            lblDel.Text = "How to Delete";
            lblDel.ForeColor = Color.OrangeRed;
            loadData();

        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchI_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like'" + txtSearchI.Text + "%'";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete item?", "important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query ="delete from items Where id="+id+"";
                fn.setData(query);
                loadData();
            }
        }
    }
}
