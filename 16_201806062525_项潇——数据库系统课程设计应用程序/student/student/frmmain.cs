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
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 学生信息插入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstudent fstudent = new frmstudent();
            fstudent.Show();

        }

        private void 课程信息插入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcourse fcourse = new frmcourse();
            fcourse.Show();

        }

        private void 专业信息插入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmajor fmajor = new frmmajor();
            fmajor.Show();
        }

        private void 教师信息插入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmteacher fteacher = new frmteacher();
            fteacher.Show();

        }

        private void 班级信息插入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmclass fclass = new frmclass();
            fclass.Show();
        }

        private void 班级排名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmselectclass fsc = new frmselectclass();
            fsc.Show();
        }

        private void 教师任课查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmselectteacher fst = new frmselectteacher();
            fst.Show();
        }

        private void 查询所学课程及学分统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstudentselectcredits fss = new frmstudentselectcredits();
            fss.Show();
        }

        private void 课程成绩排名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcourseselect fcse = new frmcourseselect();
            fcse.Show();
        }

        private void 按照课程排名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrankbycourse rank = new frmrankbycourse();
            rank.Show();
        }

        private void 学年学生成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmselectbyyear fsby = new frmselectbyyear();
            fsby.Show();
        }

        private void 地区人数统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmplace fp = new frmplace();
            fp.Show();
        }

        private void 学生名次查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrecord frd = new frmrecord();
            frd.Show();
        }
    }
}
