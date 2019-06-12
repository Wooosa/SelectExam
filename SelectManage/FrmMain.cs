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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //试题管理
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmTi frm = new FrmTi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmCourse frm = new FrmCourse();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
