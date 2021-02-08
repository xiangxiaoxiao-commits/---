using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace student
{
    class sqlConnect
    {
        public SqlConnection conn = null;
        public sqlConnect() {
            if (conn == null) {
                conn = new SqlConnection("Data Source=LAPTOP-URTEH2UB\\SQL2014;Initial Catalog=xiangxiaoMIS16;Integrated Security=True");
                if (conn.State == ConnectionState.Closed) conn.Open();
            }
        }
        public void closeConnect()
        {
            if(conn.State==ConnectionState.Open)conn.Close();
        }
         public DataSet Getds(string sql){
              if( conn.State == ConnectionState.Closed )  conn.Open();
                 DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter( sql , conn);
                da.Fill(ds);
                conn.Close();
              return ds;
        }
           public int OperateData(string sql){
                if(conn.State==ConnectionState.Closed) conn.Open();
                 SqlCommand sqlcom = new SqlCommand();
                 sqlcom.CommandText= sql;
                 sqlcom.CommandType=CommandType.Text;
                 sqlcom.Connection=conn;
                 int x = sqlcom.ExecuteNonQuery();
                 conn.Close();
                return x;
                }
            public DataSet BindDataGridView(DataGridView dgv,string sql)
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgv.DataSource = ds.Tables[0];
            return ds;
            }
           
    }
}
