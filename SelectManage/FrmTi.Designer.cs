namespace SelectManage
{
    partial class FrmTi
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
            this.dgvTimu = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.llAllSelect = new System.Windows.Forms.LinkLabel();
            this.llCancleSelect = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEdit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimu
            // 
            this.dgvTimu.AllowUserToAddRows = false;
            this.dgvTimu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.TiId,
            this.TiTitle});
            this.dgvTimu.Location = new System.Drawing.Point(12, 42);
            this.dgvTimu.MultiSelect = false;
            this.dgvTimu.Name = "dgvTimu";
            this.dgvTimu.RowTemplate.Height = 23;
            this.dgvTimu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimu.Size = new System.Drawing.Size(894, 245);
            this.dgvTimu.TabIndex = 0;
            this.dgvTimu.Click += new System.EventHandler(this.dgvTimu_Click);
            // 
            // select
            // 
            this.select.HeaderText = "选择";
            this.select.Name = "select";
            this.select.Width = 60;
            // 
            // TiId
            // 
            this.TiId.DataPropertyName = "TiId";
            this.TiId.HeaderText = "编号";
            this.TiId.Name = "TiId";
            this.TiId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TiId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TiId.Width = 60;
            // 
            // TiTitle
            // 
            this.TiTitle.DataPropertyName = "TiTitle";
            this.TiTitle.HeaderText = "标题";
            this.TiTitle.Name = "TiTitle";
            this.TiTitle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TiTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TiTitle.Width = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "课程：";
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(56, 10);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(196, 20);
            this.cmbSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "关键字：";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(312, 9);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(192, 21);
            this.txtKey.TabIndex = 4;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(517, 7);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 5;
            this.btSearch.Text = "搜  索";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(598, 7);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "删  除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // llAllSelect
            // 
            this.llAllSelect.AutoSize = true;
            this.llAllSelect.Location = new System.Drawing.Point(680, 13);
            this.llAllSelect.Name = "llAllSelect";
            this.llAllSelect.Size = new System.Drawing.Size(29, 12);
            this.llAllSelect.TabIndex = 6;
            this.llAllSelect.TabStop = true;
            this.llAllSelect.Text = "全选";
            this.llAllSelect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAllSelect_LinkClicked);
            // 
            // llCancleSelect
            // 
            this.llCancleSelect.AutoSize = true;
            this.llCancleSelect.Location = new System.Drawing.Point(715, 13);
            this.llCancleSelect.Name = "llCancleSelect";
            this.llCancleSelect.Size = new System.Drawing.Size(53, 12);
            this.llCancleSelect.TabIndex = 6;
            this.llCancleSelect.TabStop = true;
            this.llCancleSelect.Text = "取消全选";
            this.llCancleSelect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCancleSelect_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "课程：";
            // 
            // cmbEdit
            // 
            this.cmbEdit.FormattingEnabled = true;
            this.cmbEdit.Location = new System.Drawing.Point(56, 301);
            this.cmbEdit.Name = "cmbEdit";
            this.cmbEdit.Size = new System.Drawing.Size(196, 20);
            this.cmbEdit.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "答案：";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(313, 300);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(185, 21);
            this.txtAnswer.TabIndex = 9;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(517, 298);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "新  增";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(598, 298);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.Text = "修  改";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "标题：";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.Location = new System.Drawing.Point(56, 335);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTitle.Size = new System.Drawing.Size(850, 151);
            this.txtTitle.TabIndex = 8;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtContent.Location = new System.Drawing.Point(56, 502);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(850, 164);
            this.txtContent.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "选项：";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo.Location = new System.Drawing.Point(680, 304);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(59, 12);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "提示信息:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.Maroon;
            this.lblCount.Location = new System.Drawing.Point(774, 13);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(23, 12);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "...";
            // 
            // FrmTi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 678);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.llCancleSelect);
            this.Controls.Add(this.llAllSelect);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEdit);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTimu);
            this.Name = "FrmTi";
            this.Text = "题目管理";
            this.Load += new System.EventHandler(this.FrmTi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.LinkLabel llAllSelect;
        private System.Windows.Forms.LinkLabel llCancleSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiTitle;
    }
}