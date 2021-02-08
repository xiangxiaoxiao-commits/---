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
    public partial class frmclass : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select xx_cno16 as 班级号,xx_mno16 as 专业号,xx_classnum16 as 班级人数 from xiangx_class16;";
                ds = con.BindDataGridView(d1, sql);
                d1.Columns[0].ReadOnly = true;
                d1.Columns[1].ReadOnly = true;
                d1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能执行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmclass()
        {
            InitializeComponent();
            SetBind();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into xiangx_class16 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from xiangx_class16 where xx_cno16='" + d1.CurrentRow.Cells[0].Value.ToString() + " '";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update xiangx_class16 set xx_classnum16 ='" + d1.CurrentRow.Cells[2] + "'where xx_mno16='" + d1.CurrentRow.Cells[1] + "'and xx_cno16='" + d1.CurrentRow.Cells[0]+"'";
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
