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
    public partial class FrmTi : Form
    {
        DBHelper db = new DBHelper();
        public FrmTi()
        {
            InitializeComponent();
        }

        #region 绑定搜索课程
        private void bindCourseSearch()
        {
            string sql = "select * from Course";
            DataTable dt = new DataTable();
            db.PrepareSql(sql);
            dt = db.ExecQuery();
            DataRow dr = dt.NewRow();
            dr["CourseId"] = 0;
            dr["CourseName"] = "--请选择--";
            dt.Rows.InsertAt(dr, 0);
            this.cmbSearch.DataSource = dt;
            this.cmbSearch.DisplayMember = "CourseName";
            this.cmbSearch.ValueMember = "CourseId";
        }
        #endregion

        #region 绑定编辑课程
        private void bindCourseEdit()
        {
            string sql = "select * from Course";
            DataTable dt = new DataTable();
            db.PrepareSql(sql);
            dt = db.ExecQuery();
            DataRow dr = dt.NewRow();
            dr["CourseId"] = 0;
            dr["CourseName"] = "--请选择--";
            dt.Rows.InsertAt(dr, 0);
            this.cmbEdit.DataSource = dt;
            this.cmbEdit.DisplayMember = "CourseName";
            this.cmbEdit.ValueMember = "CourseId";
        }
        #endregion

        #region 绑定题目
        private void BindData()
        {
            string sql = "select * from Timu where 1 = 1 ";
            if (this.cmbSearch.SelectedIndex != 0)
                sql += " and CourseId = " + this.cmbSearch.SelectedValue.ToString();
            if (this.txtKey.Text.Trim().Length != 0)
                sql += " and TiTitle like '%" + this.txtKey.Text + "%'";
            sql += " order by TiId asc ";
            DataTable dt = new DataTable();
            db.PrepareSql(sql);
            dt = db.ExecQuery();
            this.dgvTimu.AutoGenerateColumns = false;
            this.dgvTimu.DataSource = dt;
            this.lblCount.Text = "共"+dt.Rows.Count.ToString()+"题";
        }
        #endregion

        private void FrmTi_Load(object sender, EventArgs e)
        {
            bindCourseSearch();
            bindCourseEdit();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            BindData();
        }

        #region 添加
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (this.cmbEdit.SelectedIndex == 0 || this.txtTitle.Text.Trim().Length == 0 || this.txtContent.Text.Trim().Length == 0 || this.txtAnswer.Text.Trim().Length == 0)
            {
                MessageBox.Show("输入不完整!");
                return;
            }
            //string sql = string.Format("insert into Timu(CourseId,TiTitle,TiContent,TiAnswer,TiStuAnswer,rnd) values('{0}','{1}','{2}','{3}','{4}','{5}')",
            //    this.cmbEdit.SelectedValue.ToString(),
            //    this.txtTitle.Text.Replace("'","''"),
            //    this.txtContent.Text.Replace("'", "''"),
            //    this.txtAnswer.Text,
            //    "",
            //    "0");
            string sql = "insert into Timu(CourseId,TiTitle,TiContent,TiAnswer,TiStuAnswer,rnd) values(@CourseId,@TiTitle,@TiContent,@TiAnswer,@TiStuAnswer,@rnd)";
            db.PrepareSql(sql);
            db.SetParameter("CourseId", this.cmbEdit.SelectedValue.ToString());
            db.SetParameter("TiTitle", this.txtTitle.Text);
            db.SetParameter("TiContent", this.txtContent.Text);
            db.SetParameter("TiAnswer", this.txtAnswer.Text);
            db.SetParameter("TiStuAnswer", "");
            db.SetParameter("rnd", "0");
            
            if (db.ExecNonQuery() == 1)
            {
                this.lblInfo.Text = "提示信息：新增成功!";
                this.txtTitle.Text = "";
                this.txtAnswer.Text = "";
                this.txtContent.Text = "";
                BindData();
            }
            else
            {
                this.lblInfo.Text = "提示信息：新增失败!";
            }
        }
        #endregion

        private void dgvTimu_Click(object sender, EventArgs e)
        {
            if (this.dgvTimu.SelectedRows.Count == 0 || this.dgvTimu.SelectedRows[0].Cells[1].Value == DBNull.Value)
                return;
            string timuId = this.dgvTimu.SelectedRows[0].Cells[1].Value.ToString();
            string sql = "select * from Timu where TiId = " + timuId;
            DataTable dt = new DataTable();
            db.PrepareSql(sql);
            dt = db.ExecQuery();
            if (dt.Rows.Count == 0)
                return;
            this.cmbEdit.SelectedValue = dt.Rows[0]["CourseId"].ToString();
            this.txtAnswer.Text = dt.Rows[0]["TiAnswer"].ToString();
            this.txtContent.Text = dt.Rows[0]["TiContent"].ToString();
            this.txtTitle.Text = dt.Rows[0]["TiTitle"].ToString();
        }

        //修改
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvTimu.SelectedRows.Count == 0 || this.dgvTimu.SelectedRows[0].Cells[1].Value == DBNull.Value)
            {
                MessageBox.Show("没有选中行!");
                return;
            }
            if (this.cmbEdit.SelectedIndex == 0 || this.txtTitle.Text.Trim().Length == 0 || this.txtContent.Text.Trim().Length == 0 || this.txtAnswer.Text.Trim().Length == 0)
            {
                MessageBox.Show("输入不完整!");
                return;
            }
            string timuId = this.dgvTimu.SelectedRows[0].Cells[1].Value.ToString();
            //string sql = string.Format("update Timu set CourseId={0},TiTitle='{1}',TiContent='{2}',TiAnswer='{3}' where TiId =  {4}",
            //    this.cmbEdit.SelectedValue.ToString(),
            //    this.txtTitle.Text.Replace("'", "''"),
            //    this.txtContent.Text.Replace("'", "''"),
            //    this.txtAnswer.Text,
            //    timuId);
            string sql = "update Timu set CourseId=@CourseId,TiTitle=@TiTitle,TiContent=@TiContent,TiAnswer=@TiAnswer where TiId = @TiId";
            db.PrepareSql(sql);
            db.SetParameter("CourseId", this.cmbEdit.SelectedValue.ToString());
            db.SetParameter("TiTitle", this.txtTitle.Text);
            db.SetParameter("TiContent", this.txtContent.Text);
            db.SetParameter("TiAnswer", this.txtAnswer.Text);
            db.SetParameter("TiId", timuId);
            if (db.ExecNonQuery() == 1)
            {
                this.lblInfo.Text = "提示信息：修改成功!";
                this.txtTitle.Text = "";
                this.txtAnswer.Text = "";
                this.txtContent.Text = "";
                //BindData();
            }
            else
            {
                this.lblInfo.Text = "提示信息：修改失败!";
            }
        }

        #region 全选
        private void llAllSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < this.dgvTimu.Rows.Count; i++)
            {
                this.dgvTimu.Rows[i].Cells[0].Value = true;
            }
        }
        #endregion

        #region 取消全选
        private void llCancleSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < this.dgvTimu.Rows.Count; i++)
            {
                this.dgvTimu.Rows[i].Cells[0].Value = false;
            }
        }
        #endregion

        #region 删除
        private void btDelete_Click(object sender, EventArgs e)
        {
            string idList = "";
            for (int i = 0; i < this.dgvTimu.Rows.Count; i++)
            {
                if (this.dgvTimu.Rows[i].Cells[0].Value == null)
                    continue;
                if (this.dgvTimu.Rows[i].Cells[0].Value.ToString().Equals("False"))
                    continue;
                if (!idList.Equals(""))
                    idList += ",";
                idList += this.dgvTimu.Rows[i].Cells[1].Value.ToString();
            }
            if (idList.Equals(""))
            {
                MessageBox.Show("没有选中题目!");
                return;
            }
            string sql = "delete from Timu where TiId in (" + idList + ")";
            db.PrepareSql(sql);
            if (db.ExecNonQuery() > 0)
            {
                MessageBox.Show("删除成功!");
                BindData();
            }
            else
            {
                MessageBox.Show("删除失败!");
            }
        }
        #endregion
    }
}
