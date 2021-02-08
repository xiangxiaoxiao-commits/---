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
    public partial class frmstudentselectcredits : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select distinct xx_sno16 学号,xx_sname16 姓名,xx_ccname16 课程名,xx_cccredit 课程学分,xx_scredit 已修学分 from xiangx_studentselect16";
                ds = con.BindDataGridView(d1, sql);
                d1.Columns[0].ReadOnly = true;
                d1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能执行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public frmstudentselectcredits()
        {
            InitializeComponent();
            SetBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select distinct xx_sno16 学号,xx_sname16 姓名,xx_ccname16 课程名,xx_cccredit 课程学分,xx_scredit 已修学分 from xiangx_studentselect16 where xx_sname16 ='" + textBox1.Text + "'";
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

        private void d1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
