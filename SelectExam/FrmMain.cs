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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region 练习模式
        private void button1_Click(object sender, EventArgs e)
        {
            FrmLianxi frm = new FrmLianxi();
            frm.Show();
        }
        #endregion

        #region 单科考试
        private void button2_Click(object sender, EventArgs e)
        {
            FrmKaoshi frm = new FrmKaoshi();
            frm.Show();
        }
        #endregion

        #region 综合考试
        private void btZonghe_Click(object sender, EventArgs e)
        {
            FrmZonghe frm = new FrmZonghe();
            frm.Show();
        }
        #endregion


    }
}
