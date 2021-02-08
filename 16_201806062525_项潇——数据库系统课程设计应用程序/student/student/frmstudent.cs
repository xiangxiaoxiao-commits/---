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
    public partial class frmstudent : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select xx_sno16 as 学号,xx_cno16 as 班级号,xx_sname16 as 学生姓名,xx_ssex16 as 性别,xx_sage16 as 年龄,xx_sbp as 出生地,xx_scredit as 已修学分 from xiangx_student16;";
                ds = con.BindDataGridView(d1, sql);
                d1.Columns[0].ReadOnly = true;
                d1.AllowUserToAddRows = false;
            }catch
            {
                MessageBox.Show("不能执行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmstudent()
        {
            InitializeComponent();
            SetBind();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into xiangx_student16 values('" + t1.Text + "','" + t2.Text + "','" + t3.Text + "','" + t4.Text + "','" + t5.Text + "','" + t6.Text + "','" + t7.Text + "')";
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
                    sql = "delete from xiangx_student16 where xx_sno16='" + d1.CurrentRow.Cells[0].Value.ToString() + " '";
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
                 sql = "update xiangx_student16 set xx_cno16 ='" + d1.CurrentRow.Cells[1] + "',xx_sname16 ='" + d1.CurrentRow.Cells[2] + "',xx_ssex16 ='" + d1.CurrentRow.Cells[3] + "',xx_sage16 ='" + d1.CurrentRow.Cells[4] + "',xx_sbp ='" + d1.CurrentRow.Cells[5] + "',xx_scredit ='" + d1.CurrentRow.Cells[6] + "' where xx_sno16='"+d1.CurrentRow.Cells[0]+"'";
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
