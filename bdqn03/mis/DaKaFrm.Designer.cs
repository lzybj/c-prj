namespace mis
{
    partial class DaKaFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qianDaoTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qianTuiTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empCode,
            this.empName,
            this.qianDaoTime,
            this.qianTuiTime});
            this.dataGridView1.Location = new System.Drawing.Point(79, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // empCode
            // 
            this.empCode.DataPropertyName = "empCode";
            this.empCode.HeaderText = "员工编号";
            this.empCode.Name = "empCode";
            this.empCode.ReadOnly = true;
            // 
            // empName
            // 
            this.empName.DataPropertyName = "empName";
            this.empName.HeaderText = "员工姓名";
            this.empName.Name = "empName";
            this.empName.ReadOnly = true;
            // 
            // qianDaoTime
            // 
            this.qianDaoTime.DataPropertyName = "qianDaoTime";
            this.qianDaoTime.HeaderText = "签到时间";
            this.qianDaoTime.Name = "qianDaoTime";
            this.qianDaoTime.ReadOnly = true;
            // 
            // qianTuiTime
            // 
            this.qianTuiTime.DataPropertyName = "qianTuiTime";
            this.qianTuiTime.HeaderText = "签退时间";
            this.qianTuiTime.Name = "qianTuiTime";
            this.qianTuiTime.ReadOnly = true;
            // 
            // DaKaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 273);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DaKaFrm";
            this.Text = "DaKaFrm";
            this.Load += new System.EventHandler(this.DaKaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qianDaoTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn qianTuiTime;
    }
}