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
    public partial class frmselectbyyear : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select distinct * from xiangx_selectbyyear16 order by xx_rresult desc";
                ds = con.BindDataGridView(d1, sql);
                d1.Columns[0].ReadOnly = true;
                d1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能执行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmselectbyyear()
        {
            InitializeComponent();
            SetBind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select distinct * from xiangx_selectbyyear16 where xx_ccopen16 ='" + textBox1.Text + "'order by xx_rresult desc";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
