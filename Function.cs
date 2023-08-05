using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PRBs_Restuarant
{
    internal class Function
    {
        protected SqlConnection getConnection()
       {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=siddu143;Initial Catalog=restu;Integrated Security=True";
            return con;
       }
       public DataSet GetData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Your Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
          } 
       }
    }
