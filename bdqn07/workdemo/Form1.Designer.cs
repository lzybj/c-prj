namespace workdemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExecWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewWorkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "王小苗";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workType,
            this.workName,
            this.workContent});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(52, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(389, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExecWorkToolStripMenuItem,
            this.ViewWorkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // ExecWorkToolStripMenuItem
            // 
            this.ExecWorkToolStripMenuItem.Name = "ExecWorkToolStripMenuItem";
            this.ExecWorkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExecWorkToolStripMenuItem.Text = "执行工作";
            this.ExecWorkToolStripMenuItem.Click += new System.EventHandler(this.ExecWorkToolStripMenuItem_Click);
            // 
            // ViewWorkToolStripMenuItem
            // 
            this.ViewWorkToolStripMenuItem.Name = "ViewWorkToolStripMenuItem";
            this.ViewWorkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ViewWorkToolStripMenuItem.Text = "查看完成情况";
            this.ViewWorkToolStripMenuItem.Click += new System.EventHandler(this.ViewWorkToolStripMenuItem_Click);
            // 
            // workType
            // 
            this.workType.DataPropertyName = "workType";
            this.workType.HeaderText = "工作类型";
            this.workType.Name = "workType";
            this.workType.ReadOnly = true;
            // 
            // workName
            // 
            this.workName.DataPropertyName = "workName";
            this.workName.HeaderText = "工作名称";
            this.workName.Name = "workName";
            this.workName.ReadOnly = true;
            // 
            // workContent
            // 
            this.workContent.DataPropertyName = "workContent";
            this.workContent.HeaderText = "工作描述";
            this.workContent.Name = "workContent";
            this.workContent.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 291);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ExecWorkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewWorkToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn workType;
        private System.Windows.Forms.DataGridViewTextBoxColumn workName;
        private System.Windows.Forms.DataGridViewTextBoxColumn workContent;
    }
}

