using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace SelectExam
{
    public partial class FrmZonghe : Form
    {
        DBHelper db = new DBHelper();
        DataTable dtTimu = new DataTable();  //保存抽取的考试题目
        int rowIndex = 0;

        public FrmZonghe()
        {
            InitializeComponent();
        }

        #region 绑定考试科目
        private void BindCourse()
        {
            string strCourse = ConfigurationManager.AppSettings["CourseList"].ToString();
            string sql = "";
            //修改考试随机数字段
            sql = "select * from Course where 1 = 1 ";
            sql += " and CourseId in (" + strCourse + ")";
            DataTable dt = new DataTable();
            db.PrepareSql(sql);
            dt = db.ExecQuery();
            string str = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!str.Equals(""))
                    str += ",";
                str += dt.Rows[i]["CourseName"].ToString();
            }
            this.lblCourse.Text = str;
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

        #region 绑定题目
        private void BindData()
        {
            string sql = "";
            sql = "select * from Timu where 1=2";
            db.PrepareSql(sql);
            dtTimu = db.ExecQuery();
            string strCourse = ConfigurationManager.AppSettings["CourseList"].ToString();
            string[] arrCourse = strCourse.Split(',');
            string strCount = ConfigurationManager.AppSettings["CountList"].ToString();
            string[] arrCount = strCount.Split(',');
            if (arrCourse.Length != arrCount.Length)
            {
                MessageBox.Show("配置文件错误,请联系管理员");
                Application.Exit();
            }
            
            //修改考试随机数字段
            sql = "select * from Timu where 1 = 1 ";
            sql += " and CourseId in (" + strCourse + ")";
            DataTable dt = new DataTable();
            db.PrepareSql(sql);
            dt = db.ExecQuery();
            Random rd = new Random();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["rnd"] = rd.Next(1, 9999);
            }

            for (int i = 0; i < arrCourse.Length; i++)
            {
                DataTable dtTemp = new DataTable();
                dtTemp = dt.Select("CourseId=" + arrCourse[i]).CopyToDataTable();
                DataView dv = dtTemp.DefaultView;
                dv.Sort = "rnd Asc";
                dtTemp = dv.ToTable();
                for (int j = 0; j < int.Parse(arrCount[i]); j++)
                {
                    if (j > dtTemp.Rows.Count - 1)
                        break;
                    dtTimu.ImportRow(dtTemp.Rows[j]);
                }
                DataView dv1 = dtTimu.DefaultView;
                dv1.Sort = "CourseId Asc";
                dtTimu = dv1.ToTable();
                //dtTemp.Rows.Add(
                //if (dtTimu.Rows.Count == 0)
                //{
                //    db.PrepareSql(sql);
                //    dtTimu = db.ExecQuery();
                //}
                //else
                //{
                //    DataTable dtTemp = new DataTable();
                //    db.PrepareSql(sql);
                //    dtTemp = db.ExecQuery();
                //    foreach (DataRow item in dtTemp.Rows)
                //    {
                //        dtTimu.ImportRow(item);
                //    }
                //}

                //DataView dv = dt.DefaultView;
                //dv.Sort = "rnd Asc";
                //dtTimu = dv.ToTable();

                //sql = "select top " + arrCount[i] + " * from Timu where CourseId = " + arrCourse[i];
                //sql += " order by Timu.rnd asc ";
                //if (dtTimu.Rows.Count == 0)
                //{
                //    db.PrepareSql(sql);
                //    dtTimu = db.ExecQuery();
                //}
                //else
                //{
                //    DataTable dtTemp = new DataTable();
                //    db.PrepareSql(sql);
                //    dtTemp = db.ExecQuery();
                //    foreach (DataRow item in dtTemp.Rows)
                //    {
                //        dtTimu.ImportRow(item);
                //    }
                //}
            }
            this.lblCount.Text = "共" + dtTimu.Rows.Count.ToString() + "题";
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

        private void btStart_Click(object sender, EventArgs e)
        {
            ClearAnswer();  //清除所有学生答题
            BindCourse();  //显示考试科目
            BindData();
            if (dtTimu.Rows.Count == 0)
            {
                MessageBox.Show("没有生成题目!");
                return;
            }
            rowIndex = 0;
            this.txtTitle.Text = dtTimu.Rows[rowIndex]["TiTitle"].ToString();
            this.txtContent.Text = dtTimu.Rows[rowIndex]["TiContent"].ToString();
            this.lblCount.Text = (rowIndex + 1).ToString() + "/" + dtTimu.Rows.Count.ToString();
        }

        private void FrmZonghe_Load(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            frm.CourseName = "综合测试：" + this.lblCourse.Text;
            frm.Show();
            this.Close();
        }
        #endregion

    }
}
