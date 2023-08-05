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
    public partial class UC_Additems : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_Additems()
        {
            InitializeComponent();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into items(name,category,price) values ('"+txtitemname.Text+"','"+txtcategory.Text+"','"+txtprice.Text+"')";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            txtitemname.Clear();
            txtcategory.SelectedIndex = -1;
            
            txtprice.Clear();
          

        }
    }
}
