using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelectManage
{
    public partial class FrmCourse : Form
    {
        DBHelper db = new DBHelper();
        public FrmCourse()
        {
            InitializeComponent();
        }

        private void BindData()
        {
            string sql = "select * from Course";
            db.PrepareSql(sql);
            this.lbCourse.DataSource = db.ExecQuery();
            this.lbCourse.DisplayMember = "CourseName";
            this.lbCourse.ValueMember = "CourseId";          
        }

        private void FrmCourse_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (this.txtCourse.Text.Trim().Length == 0)
            {
                this.lblInfo.Text = "提示信息：课程名称不能为空!";
                return;
            }
            string sql = "insert into Course(CourseName) values(@CourseName)";
            db.PrepareSql(sql);
            db.SetParameter("CourseName",this.txtCourse.Text);
            if (db.ExecNonQuery() == 1)
            {
                this.lblInfo.Text = "提示信息：新增成功!";
                this.txtCourse.Text = "";
            }
            else
            {
                this.lblInfo.Text = "提示信息：新增失败!";
            }
            BindData();
        }

        private void lbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbCourse_Click(object sender, EventArgs e)
        {
            this.txtCourse.Text = this.lbCourse.Text;
            this.lblID.Text = this.lbCourse.SelectedValue.ToString();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            //string sql = string.Format("update Course set CourseName='{0}' where CourseId={1}",
            //    this.txtCourse.Text,
            //    this.lbCourse.SelectedValue.ToString());
            string sql = "update Course set CourseName=@CourseName where CourseId=@CourseId";
            db.PrepareSql(sql);
            db.SetParameter("CourseName",this.txtCourse.Text);
            db.SetParameter("CourseId", this.lbCourse.SelectedValue.ToString());
            if (db.ExecNonQuery() == 1)
            {
                this.lblInfo.Text = "提示信息：修改成功!";
            }
            else
            {
                this.lblInfo.Text = "提示信息：修改失败!";
            }
            BindData();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string CourseId = this.lbCourse.SelectedValue.ToString();
            string sql = "select count(*) from Timu where CourseId = " + CourseId;
            db.PrepareSql(sql);
            int timuCount = (int)db.ExecScalar();
            if (timuCount > 0)
            {
                MessageBox.Show("课程下有题目,不能删除");
                return;
            }
            sql = "delete from Course where CourseId = " + CourseId;
            db.PrepareSql(sql);
            if (db.ExecNonQuery() == 1)
            {
                this.lblInfo.Text = "提示信息：删除成功!";
                this.txtCourse.Text = "";
            }
            else
            {
                this.lblInfo.Text = "提示信息：删除失败!";
                this.txtCourse.Text = "";
            }
            BindData();
        }
    }
}
