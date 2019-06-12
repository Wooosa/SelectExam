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
    public partial class FrmResult : Form
    {
        public int Score { get; set; }
        public string ErrList { get; set; }
        public string CourseName { get; set; }
        DBHelper db = new DBHelper();
        public FrmResult()
        {
            InitializeComponent();
        }

        private void FrmResult_Load(object sender, EventArgs e)
        {
            this.lblCourseName.Text = "考试科目为:" + this.CourseName;
            this.lblScore.Text = "您的分数为:" + this.Score.ToString();
            this.lblTime.Text = "提交时间:" + DateTime.Now.ToString("yyyy年MM月dd日 hh时mm分ss秒");
            //this.txtErrList.Text = "错题分布:\r\n" + this.ErrList;
            if (this.ErrList.Length != 0)  //如果满分,没有错题，则不需要绑定错题数据
            {
                string sql = "select * from Timu left join Course on Timu.CourseId=Course.CourseId where TiId in (" + this.ErrList + ")";
                sql += " order by TiId asc ";
                this.dgvResult.AutoGenerateColumns = false;
                db.PrepareSql(sql);
                this.dgvResult.DataSource = db.ExecQuery();
            }

        }
    }
}
