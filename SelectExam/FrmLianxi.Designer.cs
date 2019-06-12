namespace SelectExam
{
    partial class FrmLianxi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.btStart = new System.Windows.Forms.Button();
            this.dgvTimu = new System.Windows.Forms.DataGridView();
            this.TiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btUp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择课程：";
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(77, 10);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(196, 20);
            this.cmbSearch.TabIndex = 3;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(284, 9);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "开始练习";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // dgvTimu
            // 
            this.dgvTimu.AllowUserToAddRows = false;
            this.dgvTimu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TiId,
            this.TiTitle});
            this.dgvTimu.Location = new System.Drawing.Point(11, 38);
            this.dgvTimu.MultiSelect = false;
            this.dgvTimu.Name = "dgvTimu";
            this.dgvTimu.ReadOnly = true;
            this.dgvTimu.RowTemplate.Height = 23;
            this.dgvTimu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimu.Size = new System.Drawing.Size(1112, 204);
            this.dgvTimu.TabIndex = 5;
            this.dgvTimu.Click += new System.EventHandler(this.dgvTimu_Click);
            // 
            // TiId
            // 
            this.TiId.DataPropertyName = "TiId";
            this.TiId.HeaderText = "编号";
            this.TiId.Name = "TiId";
            this.TiId.ReadOnly = true;
            this.TiId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TiId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TiId.Width = 60;
            // 
            // TiTitle
            // 
            this.TiTitle.DataPropertyName = "TiTitle";
            this.TiTitle.HeaderText = "标题";
            this.TiTitle.Name = "TiTitle";
            this.TiTitle.ReadOnly = true;
            this.TiTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TiTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TiTitle.Width = 1000;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.Location = new System.Drawing.Point(55, 516);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(1068, 142);
            this.txtContent.TabIndex = 11;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.Location = new System.Drawing.Point(55, 252);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTitle.Size = new System.Drawing.Size(1068, 258);
            this.txtTitle.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "选项：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "标题：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 672);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "请输入答案：";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAnswer.Location = new System.Drawing.Point(131, 665);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 29);
            this.txtAnswer.TabIndex = 14;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(241, 667);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 15;
            this.btOk.Text = "确定答题";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btUp
            // 
            this.btUp.Location = new System.Drawing.Point(322, 667);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(75, 23);
            this.btUp.TabIndex = 15;
            this.btUp.Text = "上一题";
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 667);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "下一题";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo.Location = new System.Drawing.Point(497, 671);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(80, 16);
            this.lblInfo.TabIndex = 16;
            this.lblInfo.Text = "提示信息:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblCount.Location = new System.Drawing.Point(370, 14);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(23, 12);
            this.lblCount.TabIndex = 17;
            this.lblCount.Text = "...";
            // 
            // FrmLianxi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 706);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTimu);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.label1);
            this.Name = "FrmLianxi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "练习模式";
            this.Load += new System.EventHandler(this.FrmLianxi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.DataGridView dgvTimu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCount;
    }
}