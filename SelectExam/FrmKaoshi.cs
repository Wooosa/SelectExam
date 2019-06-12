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
    public partial class FrmKaoshi : Form
    {
        DataTable dtTimu = new DataTable();
        int rowIndex = 0;
        int courseId = 0;
        string courseName = "";
        DBHelper db = new DBHelper();

        public FrmKaoshi()
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
            dtTimu.Clear();
            string sql = "";
            //修改考试随机数字段
            sql = "select * from Timu where 1 = 1 ";
            sql += " and CourseId = " + this.cmbSearch.SelectedValue.ToString();
            DataTable dt = new DataTable();
            db.PrepareSql(sql);
            dt = db.ExecQuery();
            Random rd = new Random();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["rnd"] = rd.Next(1, 1000);
            }

            DataView dv = dt.DefaultView;
            dv.Sort = "rnd Asc";
            dtTimu = dv.ToTable();

            this.lblCount.Text = "共" + dtTimu.Rows.Count.ToString() + "题";
        }
        #endregion

        #region 清空所有题目的学生答题
        private void ClearAnswer()
        {
            string sql = "update Timu set TiStuAnswer=''";
            db.PrepareSql(sql);
            db.ExecNonQuery();
        }
        #endregion

        #region 提交当前考试题目答案
        private void Dati()
        {
            if (this.txtAnswer.Text.Trim().Length == 0)
                return;
            //string sql = "update Timu set TiStuAnswer = '" + this.txtAnswer.Text.Trim().ToUpper() + "' where TiId = " + dtTimu.Rows[rowIndex]["TiId"].ToString();
            //DBHelper.ExecNonQuery(sql);
            string sql = "update Timu set TiStuAnswer = @TiStuAnswer where TiId = @TiId";
            db.PrepareSql(sql);
            db.SetParameter("TiStuAnswer", this.txtAnswer.Text.Trim().ToUpper());
            db.SetParameter("TiId", dtTimu.Rows[rowIndex]["TiId"].ToString());
            db.ExecNonQuery();
            dtTimu.Rows[rowIndex]["TiStuAnswer"] = this.txtAnswer.Text.Trim().ToUpper();
        }
        #endregion

        private void FrmKaoshi_Load(object sender, EventArgs e)
        {
            bindCourseSearch();
        }

        #region 提交试卷
        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (dtTimu == null || dtTimu.Rows.Count == 0)
            {
                MessageBox.Show("还没有开始考试或者没有答题!");
                return;
            }
            Dati(); //保存当前题目答题
            //判断是否有题目没有作答
            for (int i = 0; i < dtTimu.Rows.Count; i++)
            {
                if (dtTimu.Rows[i]["TiStuAnswer"].ToString().Equals(""))
                {
                    DialogResult r = MessageBox.Show("还有题目没有作答，是否继续提交", "答题系统", MessageBoxButtons.YesNo);
                    if (r == System.Windows.Forms.DialogResult.No)
                        return;
                    else
                        break;
                }
            }
            //查询答题错误的题目
            string errList = ""; //错题序号
            double yesCount = 0;
            for (int i = 0; i < dtTimu.Rows.Count; i++)
            {
                if (!dtTimu.Rows[i]["TiStuAnswer"].ToString().Trim().Equals(dtTimu.Rows[i]["TiAnswer"].ToString().Trim()))
                {
                    if (!errList.Equals(""))
                        errList += ",";
                    errList += dtTimu.Rows[i]["TiId"].ToString();
                }
                else
                    yesCount++;
            }

            double allCount = (double)dtTimu.Rows.Count;
            int score = (int)((yesCount / allCount) * 100);

            FrmResult frm = new FrmResult();
            frm.Score = score;
            frm.ErrList = errList;
            frm.CourseName = this.courseName;
            frm.Show();
            this.Close();

        }
        #endregion

        #region 开始考试
        private void btStart_Click(object sender, EventArgs e)
        {
            if (this.cmbSearch.SelectedIndex == 0)
            {
                MessageBox.Show("请选择课程!");
                return;
            }
            ClearAnswer();   //清空所有学生答题答案
            BindData();  //绑定数据(题目随机顺序)
            if (dtTimu.Rows.Count == 0)
            {
                MessageBox.Show("该科目下没有题目!");
                return;
            }
            this.courseId = int.Parse(this.cmbSearch.SelectedValue.ToString());
            this.courseName = this.cmbSearch.Text;
            rowIndex = 0;
            this.txtTitle.Text = dtTimu.Rows[rowIndex]["TiTitle"].ToString();
            this.txtContent.Text = dtTimu.Rows[rowIndex]["TiContent"].ToString();
            this.lblCount.Text = (rowIndex + 1).ToString() + "/" + dtTimu.Rows.Count.ToString();
        }
        #endregion

        #region 退出考试
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 上一题
        private void btUp_Click(object sender, EventArgs e)
        {
            if (rowIndex == 0)
            {
                MessageBox.Show("已经是第一题了!");
                return;
            }
            Dati();  //提交当前答案
            //this.txtAnswer.Text = "";
            this.txtAnswer.Focus();
            rowIndex--;
            this.txtTitle.Text = dtTimu.Rows[rowIndex]["TiTitle"].ToString();
            this.txtContent.Text = dtTimu.Rows[rowIndex]["TiContent"].ToString();
            this.txtAnswer.Text = dtTimu.Rows[rowIndex]["TiStuAnswer"].ToString();
            this.lblCount.Text = (rowIndex + 1).ToString() + "/" + dtTimu.Rows.Count.ToString();
        }
        #endregion

        #region 下一题
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.rowIndex >= dtTimu.Rows.Count - 1)
            {
                MessageBox.Show("已经是最后一题了!");
                return;
            }
            Dati();  //提交当前答案
            //this.txtAnswer.Text = "";
            this.txtAnswer.Focus();
            rowIndex++;
            this.txtTitle.Text = dtTimu.Rows[rowIndex]["TiTitle"].ToString();
            this.txtContent.Text = dtTimu.Rows[rowIndex]["TiContent"].ToString();
            this.txtAnswer.Text = dtTimu.Rows[rowIndex]["TiStuAnswer"].ToString();
            this.lblCount.Text = (rowIndex + 1).ToString() + "/" + dtTimu.Rows.Count.ToString();
        }
        #endregion
    }
}
