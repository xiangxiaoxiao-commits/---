
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{
    public partial class frmmajor : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select xx_Mno16 as 专业号,xx_Mname16 as 专业名 from xiangx_Major16";
                con.BindDataGridView(dataGridView1, sql);
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能执行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmmajor()
        {
            InitializeComponent();
            SetBind();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into xiangx_Major16 values('"+txtxx_Mno16.Text+"','"+txtxx_Mname16.Text+"')";
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

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from xiangx_Major16 where xx_Mno16='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " '";
                    con.OperateData(sql);
                    SetBind();
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons
                        .OK, MessageBoxIcon
                        .Information);
                }
                catch
                {
                    MessageBox.Show("不能作该操作！","提示",MessageBoxButtons.OK, MessageBoxIcon.Information);                }
            }
        }

        private void txtChange_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update xiangx_Major16 set xx_Mname16='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "' where xx_Mno16='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}







