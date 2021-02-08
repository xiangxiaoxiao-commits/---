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
    
    public partial class frmselectclass : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        protected void SetBind()
        {
            try
            {
                sql = "select distinct xiangx_course16.xx_ccname16 from xiangx_record16, xiangx_course16, xiangx_student16, xiangx_class16 where xiangx_class16.xx_cno16 = xiangx_student16.xx_cno16 and xiangx_student16.xx_sno16 = xiangx_record16.xx_sno16 and xiangx_record16.xx_ccno16 = xiangx_course16.xx_ccno16";
                ds = con.BindDataGridView(d1, sql);
                d1.Columns[0].ReadOnly = true;
                d1.AllowUserToAddRows = false;
            }
            catch
            {
                MessageBox.Show("不能执行该操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public frmselectclass()
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
                sql = "select distinct xiangx_course16.xx_ccname16 from xiangx_record16, xiangx_course16, xiangx_student16, xiangx_class16 where xiangx_class16.xx_cno16 = xiangx_student16.xx_cno16 and xiangx_student16.xx_sno16 = xiangx_record16.xx_sno16 and xiangx_record16.xx_ccno16 = xiangx_course16.xx_ccno16 and xiangx_class16.xx_cno16 = '"+textBox1.Text+"'";
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
    }
}
