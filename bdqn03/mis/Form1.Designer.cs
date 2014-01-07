namespace mis
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
            this.components = new System.ComponentModel.Container();
            this.btn_addemp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delemp = new System.Windows.Forms.Button();
            this.btn_upemp = new System.Windows.Forms.Button();
            this.tx_cxempcode = new System.Windows.Forms.TextBox();
            this.btn_cxaction = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.empqiandao = new System.Windows.Forms.ToolStripMenuItem();
            this.empqiantui = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_views = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addemp
            // 
            this.btn_addemp.Location = new System.Drawing.Point(33, 28);
            this.btn_addemp.Name = "btn_addemp";
            this.btn_addemp.Size = new System.Drawing.Size(75, 23);
            this.btn_addemp.TabIndex = 0;
            this.btn_addemp.Text = "新增员工";
            this.btn_addemp.UseVisualStyleBackColor = true;
            this.btn_addemp.Click += new System.EventHandler(this.btn_addemp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empCode,
            this.empName});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(102, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // empCode
            // 
            this.empCode.DataPropertyName = "empCode";
            this.empCode.HeaderText = "员工工号";
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
            // btn_delemp
            // 
            this.btn_delemp.Location = new System.Drawing.Point(151, 27);
            this.btn_delemp.Name = "btn_delemp";
            this.btn_delemp.Size = new System.Drawing.Size(75, 23);
            this.btn_delemp.TabIndex = 2;
            this.btn_delemp.Text = "删除员工";
            this.btn_delemp.UseVisualStyleBackColor = true;
            this.btn_delemp.Click += new System.EventHandler(this.btn_delemp_Click);
            // 
            // btn_upemp
            // 
            this.btn_upemp.Location = new System.Drawing.Point(267, 27);
            this.btn_upemp.Name = "btn_upemp";
            this.btn_upemp.Size = new System.Drawing.Size(75, 23);
            this.btn_upemp.TabIndex = 3;
            this.btn_upemp.Text = "修改";
            this.btn_upemp.UseVisualStyleBackColor = true;
            this.btn_upemp.Click += new System.EventHandler(this.btn_upemp_Click);
            // 
            // tx_cxempcode
            // 
            this.tx_cxempcode.Location = new System.Drawing.Point(126, 75);
            this.tx_cxempcode.Name = "tx_cxempcode";
            this.tx_cxempcode.Size = new System.Drawing.Size(100, 21);
            this.tx_cxempcode.TabIndex = 4;
            // 
            // btn_cxaction
            // 
            this.btn_cxaction.Location = new System.Drawing.Point(277, 73);
            this.btn_cxaction.Name = "btn_cxaction";
            this.btn_cxaction.Size = new System.Drawing.Size(75, 23);
            this.btn_cxaction.TabIndex = 5;
            this.btn_cxaction.Text = "查询";
            this.btn_cxaction.UseVisualStyleBackColor = true;
            this.btn_cxaction.Click += new System.EventHandler(this.btn_cxaction_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empqiandao,
            this.empqiantui});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // empqiandao
            // 
            this.empqiandao.Name = "empqiandao";
            this.empqiandao.Size = new System.Drawing.Size(94, 22);
            this.empqiandao.Text = "签到";
            this.empqiandao.Click += new System.EventHandler(this.empqiandao_Click);
            // 
            // empqiantui
            // 
            this.empqiantui.Name = "empqiantui";
            this.empqiantui.Size = new System.Drawing.Size(94, 22);
            this.empqiantui.Text = "签退";
            this.empqiantui.Click += new System.EventHandler(this.empqiantui_Click);
            // 
            // btn_views
            // 
            this.btn_views.Location = new System.Drawing.Point(381, 27);
            this.btn_views.Name = "btn_views";
            this.btn_views.Size = new System.Drawing.Size(75, 23);
            this.btn_views.TabIndex = 7;
            this.btn_views.Text = "打卡记录";
            this.btn_views.UseVisualStyleBackColor = true;
            this.btn_views.Click += new System.EventHandler(this.btn_views_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 273);
            this.Controls.Add(this.btn_cxaction);
            this.Controls.Add(this.btn_views);
            this.Controls.Add(this.tx_cxempcode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_upemp);
            this.Controls.Add(this.btn_delemp);
            this.Controls.Add(this.btn_addemp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addemp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn empName;
        private System.Windows.Forms.Button btn_delemp;
        private System.Windows.Forms.Button btn_upemp;
        private System.Windows.Forms.TextBox tx_cxempcode;
        private System.Windows.Forms.Button btn_cxaction;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empqiandao;
        private System.Windows.Forms.ToolStripMenuItem empqiantui;
        private System.Windows.Forms.Button btn_views;
    }
}

