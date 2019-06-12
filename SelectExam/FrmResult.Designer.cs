namespace SelectExam
{
    partial class FrmResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResult));
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.TiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CouName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiStuAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblScore.ForeColor = System.Drawing.Color.Maroon;
            this.lblScore.Location = new System.Drawing.Point(12, 58);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(75, 28);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "label1";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.BackColor = System.Drawing.Color.Transparent;
            this.lblCourseName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCourseName.ForeColor = System.Drawing.Color.Black;
            this.lblCourseName.Location = new System.Drawing.Point(12, 15);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(71, 26);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "label1";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TiId,
            this.CouName,
            this.TiStuAnswer,
            this.TiAnswer});
            this.dgvResult.Location = new System.Drawing.Point(17, 137);
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(836, 314);
            this.dgvResult.TabIndex = 1;
            // 
            // TiId
            // 
            this.TiId.DataPropertyName = "TiId";
            this.TiId.HeaderText = "题目编号";
            this.TiId.Name = "TiId";
            this.TiId.ReadOnly = true;
            this.TiId.Width = 80;
            // 
            // CouName
            // 
            this.CouName.DataPropertyName = "CourseName";
            this.CouName.HeaderText = "课程名称";
            this.CouName.Name = "CouName";
            this.CouName.ReadOnly = true;
            this.CouName.Width = 300;
            // 
            // TiStuAnswer
            // 
            this.TiStuAnswer.DataPropertyName = "TiStuAnswer";
            this.TiStuAnswer.HeaderText = "您的选择";
            this.TiStuAnswer.Name = "TiStuAnswer";
            this.TiStuAnswer.ReadOnly = true;
            this.TiStuAnswer.Width = 80;
            // 
            // TiAnswer
            // 
            this.TiAnswer.DataPropertyName = "TiAnswer";
            this.TiAnswer.HeaderText = "参考答案";
            this.TiAnswer.Name = "TiAnswer";
            this.TiAnswer.ReadOnly = true;
            this.TiAnswer.Width = 80;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.Maroon;
            this.lblTime.Location = new System.Drawing.Point(12, 101);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 28);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            // 
            // FrmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 463);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScore);
            this.Name = "FrmResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考试结果";
            this.Load += new System.EventHandler(this.FrmResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CouName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiStuAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiAnswer;
        private System.Windows.Forms.Label lblTime;
    }
}