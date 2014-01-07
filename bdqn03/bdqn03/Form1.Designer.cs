namespace bdqn03
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addemp = new System.Windows.Forms.ToolStrip();
            this.btn_addemp = new System.Windows.Forms.ToolStripButton();
            this.btn_updateemp = new System.Windows.Forms.ToolStripButton();
            this.btn_delemp = new System.Windows.Forms.ToolStripButton();
            this.btn_viewdata = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_empcode = new System.Windows.Forms.TextBox();
            this.btn_chaxunaction = new System.Windows.Forms.Button();
            this.dg_allemps = new System.Windows.Forms.DataGridView();
            this.empCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_allemps)).BeginInit();
            this.SuspendLayout();
            // 
            // addemp
            // 
            this.addemp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_addemp,
            this.btn_updateemp,
            this.btn_delemp,
            this.btn_viewdata});
            this.addemp.Location = new System.Drawing.Point(0, 0);
            this.addemp.Name = "addemp";
            this.addemp.Size = new System.Drawing.Size(593, 25);
            this.addemp.TabIndex = 0;
            this.addemp.Text = "新增员工";
            // 
            // btn_addemp
            // 
            this.btn_addemp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_addemp.Image = ((System.Drawing.Image)(resources.GetObject("btn_addemp.Image")));
            this.btn_addemp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_addemp.Name = "btn_addemp";
            this.btn_addemp.Size = new System.Drawing.Size(23, 22);
            this.btn_addemp.Text = "新增员工";
            this.btn_addemp.Click += new System.EventHandler(this.btn_addemp_Click);
            // 
            // btn_updateemp
            // 
            this.btn_updateemp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_updateemp.Image = ((System.Drawing.Image)(resources.GetObject("btn_updateemp.Image")));
            this.btn_updateemp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_updateemp.Name = "btn_updateemp";
            this.btn_updateemp.Size = new System.Drawing.Size(23, 22);
            this.btn_updateemp.Text = "修改员工";
            // 
            // btn_delemp
            // 
            this.btn_delemp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_delemp.Image = ((System.Drawing.Image)(resources.GetObject("btn_delemp.Image")));
            this.btn_delemp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_delemp.Name = "btn_delemp";
            this.btn_delemp.Size = new System.Drawing.Size(23, 22);
            this.btn_delemp.Text = "删除员工";
            // 
            // btn_viewdata
            // 
            this.btn_viewdata.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_viewdata.Image = ((System.Drawing.Image)(resources.GetObject("btn_viewdata.Image")));
            this.btn_viewdata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_viewdata.Name = "btn_viewdata";
            this.btn_viewdata.Size = new System.Drawing.Size(23, 22);
            this.btn_viewdata.Text = "查看打卡记录";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "员工编号";
            // 
            // tx_empcode
            // 
            this.tx_empcode.Location = new System.Drawing.Point(199, 46);
            this.tx_empcode.Name = "tx_empcode";
            this.tx_empcode.Size = new System.Drawing.Size(100, 21);
            this.tx_empcode.TabIndex = 2;
            // 
            // btn_chaxunaction
            // 
            this.btn_chaxunaction.Location = new System.Drawing.Point(342, 44);
            this.btn_chaxunaction.Name = "btn_chaxunaction";
            this.btn_chaxunaction.Size = new System.Drawing.Size(75, 23);
            this.btn_chaxunaction.TabIndex = 3;
            this.btn_chaxunaction.Text = "查询";
            this.btn_chaxunaction.UseVisualStyleBackColor = true;
            // 
            // dg_allemps
            // 
            this.dg_allemps.AllowUserToAddRows = false;
            this.dg_allemps.AllowUserToDeleteRows = false;
            this.dg_allemps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_allemps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empCode,
            this.empName,
            this.empSex,
            this.empAge});
            this.dg_allemps.Location = new System.Drawing.Point(59, 97);
            this.dg_allemps.Name = "dg_allemps";
            this.dg_allemps.ReadOnly = true;
            this.dg_allemps.RowTemplate.Height = 23;
            this.dg_allemps.Size = new System.Drawing.Size(444, 150);
            this.dg_allemps.TabIndex = 4;
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
            // empSex
            // 
            this.empSex.DataPropertyName = "empSex";
            this.empSex.HeaderText = "员工性别";
            this.empSex.Name = "empSex";
            this.empSex.ReadOnly = true;
            // 
            // empAge
            // 
            this.empAge.DataPropertyName = "empAge";
            this.empAge.HeaderText = "员工年龄";
            this.empAge.Name = "empAge";
            this.empAge.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 273);
            this.Controls.Add(this.dg_allemps);
            this.Controls.Add(this.btn_chaxunaction);
            this.Controls.Add(this.tx_empcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addemp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.addemp.ResumeLayout(false);
            this.addemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_allemps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip addemp;
        private System.Windows.Forms.ToolStripButton btn_addemp;
        private System.Windows.Forms.ToolStripButton btn_updateemp;
        private System.Windows.Forms.ToolStripButton btn_delemp;
        private System.Windows.Forms.ToolStripButton btn_viewdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_empcode;
        private System.Windows.Forms.Button btn_chaxunaction;
        private System.Windows.Forms.DataGridView dg_allemps;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn empAge;
    }
}

