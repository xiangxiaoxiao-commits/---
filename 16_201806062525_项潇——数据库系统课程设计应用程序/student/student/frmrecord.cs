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
    public partial class frmrecord : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select distinct * from xiangx_record16 ";
                ds = con.BindDataGridView(d1, sql);
                d1.Columns[0].ReadOnly = true;
                d1.Columns[1].ReadOnly = true;
                d1.Columns[2].ReadOnly = true;
                d1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能执行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmrecord()
        {
            InitializeComponent();
            SetBind();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into xiangx_record16 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
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
                    sql = "delete from xiangx_record16 where xx_ccno16='" + d1.CurrentRow.Cells[0].Value.ToString() + " ' and xx_tno16='" + d1.CurrentRow.Cells[1].Value.ToString() + " ' and xx_sno16='" + d1.CurrentRow.Cells[2].Value.ToString() + " '";
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
                sql = "update xiangx_record16 set xx_rresult ='" + d1.CurrentRow.Cells[3] + "' where xx_ccno16='" + d1.CurrentRow.Cells[0].Value.ToString() + " ' and xx_tno16='" + d1.CurrentRow.Cells[1].Value.ToString() + " ' and xx_sno16='" + d1.CurrentRow.Cells[2].Value.ToString() + " ' ";
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
    }
}
