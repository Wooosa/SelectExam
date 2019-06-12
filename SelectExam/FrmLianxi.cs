using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SelectExam
{
    public partial class FrmLianxi : Form
    {
        DBHelper db = new DBHelper();
        DataTable dtTimu = new DataTable();
        int rowIndex = 0;

        public FrmLianxi()
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

        #region 绑定题目
        private void BindData()
        {
            string sql = "select * from Timu where 1 = 1 ";
            if (this.cmbSearch.SelectedIndex != 0)
                sql += " and CourseId = " + this.cmbSearch.SelectedValue.ToString();
            sql += " order by TiId asc ";
            db.PrepareSql(sql);
            dtTimu = db.ExecQuery();
            this.dgvTimu.AutoGenerateColumns = false;
            this.dgvTimu.DataSource = dtTimu;
            this.lblCount.Text = "共" + dtTimu.Rows.Count.ToString() + "题";
        }
        #endregion

        private void FrmLianxi_Load(object sender, EventArgs e)
        {
            bindCourseSearch();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (this.cmbSearch.SelectedIndex == 0)
            {
                MessageBox.Show("请选择课程!");
                return;
            }
            BindData();
            rowIndex = 0;
        }

        private void dgvTimu_Click(object sender, EventArgs e)
        {
            if (this.dgvTimu.SelectedRows.Count == 0 || this.dgvTimu.SelectedRows[0].Cells[1].Value == DBNull.Value)
                return;
            string timuId = this.dgvTimu.SelectedRows[0].Cells[0].Value.ToString();
            string sql = "select * from Timu where TiId = " + timuId;
            DataTable dt = new DataTable();
            db.PrepareSql(sql);
            dt = db.ExecQuery();
            if (dt.Rows.Count == 0)
                return;
            this.txtContent.Text = dt.Rows[0]["TiContent"].ToString();
            this.txtTitle.Text = dt.Rows[0]["TiTitle"].ToString();
            this.lblInfo.Text = "提示信息：";
            this.rowIndex = this.dgvTimu.SelectedRows[0].Index;
            this.lblCount.Text = (rowIndex + 1).ToString() + "/" + dtTimu.Rows.Count.ToString();
        }

        #region 上一题
        private void btUp_Click(object sender, EventArgs e)
        {
            if (this.rowIndex == 0)
            {
                MessageBox.Show("已经是第一题了!");
                return;
            }
            this.txtAnswer.Text = "";
            this.txtAnswer.Focus(); 
            rowIndex--;
            this.txtTitle.Text = dtTimu.Rows[rowIndex]["TiTitle"].ToString();
            this.txtContent.Text = dtTimu.Rows[rowIndex]["TiContent"].ToString();
            this.lblInfo.Text = "提示信息：";
            this.lblCount.Text = (rowIndex + 1).ToString() + "/" + dtTimu.Rows.Count.ToString();
        }
        #endregion

        #region 下一题
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.rowIndex == dtTimu.Rows.Count - 1)
            {
                MessageBox.Show("已经是最后一题了!");
                return;
            }
            this.txtAnswer.Text = "";
            this.txtAnswer.Focus(); 
            rowIndex++;
            this.txtTitle.Text = dtTimu.Rows[rowIndex]["TiTitle"].ToString();
            this.txtContent.Text = dtTimu.Rows[rowIndex]["TiContent"].ToString();
            this.lblInfo.Text = "提示信息：";
            this.lblCount.Text = (rowIndex + 1).ToString() + "/" + dtTimu.Rows.Count.ToString();
        }
        #endregion

        #region 确定答题
        private void btOk_Click(object sender, EventArgs e)
        {
            if (this.txtAnswer.Text.Trim().ToUpper().Equals(dtTimu.Rows[rowIndex]["TiAnswer"].ToString().ToUpper()))
            {
                this.lblInfo.Text = "提示信息：回答正确!";
            }
            else
            {
                this.lblInfo.Text = "提示信息：回答错误,正确答案为:" + dtTimu.Rows[rowIndex]["TiAnswer"].ToString().ToUpper();
            }
        }
        #endregion

    }
}
