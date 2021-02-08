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
    
    public partial class frmcourse : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select xx_ccno16 as 课程号,xx_ccname16 as 课程名,xx_ccopen16 as 开课学期,xx_cchour16 as 课时,xx_ccway as 考查方式,xx_cccredit as 课程学分 from xiangx_course16;";
                ds = con.BindDataGridView(d1, sql);
                d1.Columns[0].ReadOnly = true;
                d1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能执行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmcourse()
        {
            InitializeComponent();
            SetBind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认要删除该条信息吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sql = "delete from xiangx_course16 where xx_ccno16='" + d1.CurrentRow.Cells[0].Value.ToString() + " '";
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

        private void b1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into xiangx_course16 values('"+textBox1.Text+"','"+textBox2.Text+ "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
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

        private void b3_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update xiangx_course16 set xx_ccname16 ='" + d1.CurrentRow.Cells[1] + "',xx_ccopen16 ='" + d1.CurrentRow.Cells[2] + "',xx_cchour16 ='" + d1.CurrentRow.Cells[3] + "',xx_ccway ='" + d1.CurrentRow.Cells[4] + "',xx_cccredit ='" + d1.CurrentRow.Cells[5] +  "' where xx_ccno16='" + d1.CurrentRow.Cells[0] + "'";
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

        private void frmcourse_Load(object sender, EventArgs e)
        {

        }
    }
}
