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
    public partial class frmteacher : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select  xx_tno16 as 教师编号,xx_tname16 as 教师姓名,xx_tsex16 as 性别,xx_tage16 as 年龄,xx_tposition as 职位,xx_tcontact as 联系方式 from xiangx_teacher16;";
                ds = con.BindDataGridView(d1, sql);
                d1.Columns[0].ReadOnly = true;
                d1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能执行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmteacher()
        {
            InitializeComponent();
            SetBind();
        }

        private void frmteacher_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into xiangx_teacher16 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                con.OperateData(sql);
                SetBind();
                MessageBox.Show("插入成功！", "提示", MessageBoxButtons
                        .OK, MessageBoxIcon
                        .Information);
            }
            catch
            {
                MessageBox.Show("不能执行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from xiangx_teacher16 where xx_tno16='" + d1.CurrentRow.Cells[0].Value.ToString() + " '";
                    con.OperateData(sql);
                    SetBind();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons
                        .OK, MessageBoxIcon
                        .Information);
                }
                catch
                {
                    MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update xiangx_teacher16 set xx_tname16 ='" + d1.CurrentRow.Cells[1] + "',xx_tsex16 ='" + d1.CurrentRow.Cells[2] + "',xx_tage16 ='" + d1.CurrentRow.Cells[3] + "',xx_tposition ='" + d1.CurrentRow.Cells[4] + "',xx_tcontact ='" + d1.CurrentRow.Cells[5] + "' where xx_tno16='" + d1.CurrentRow.Cells[0] + "'";
                con.OperateData(sql);
                SetBind();
                MessageBox.Show("保存成功！", "提示", MessageBoxButtons
                        .OK, MessageBoxIcon
                        .Information);
            }
            catch
            {
                MessageBox.Show("不能作该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
