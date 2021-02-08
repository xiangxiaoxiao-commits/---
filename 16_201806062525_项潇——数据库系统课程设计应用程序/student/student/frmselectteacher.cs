using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{
    public partial class frmselectteacher : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select * from xiangx_teacherselect16";
                ds = con.BindDataGridView(d1, sql);
                d1.Columns[0].ReadOnly = true;
                d1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能执行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmselectteacher()
        {
            InitializeComponent();
            SetBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select distinct * from xiangx_teacherselect16 where xiangx_teacherselect16.xx_tname16 ='"+textBox1.Text+"'";
                //con.OperateData(sql);
                // SetBind();
                con.BindDataGridView(d1, sql);

                MessageBox.Show("查询成功！", "提示", MessageBoxButtons
                        .OK, MessageBoxIcon
                        .Information);
            }
            catch
            {
                MessageBox.Show("查询失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
