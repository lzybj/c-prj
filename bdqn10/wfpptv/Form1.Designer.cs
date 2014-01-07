namespace wfpptv
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jieMuTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jieMuTimeDuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jieMuURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jieMuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShouCangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(34, 59);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(195, 344);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jieMuTime,
            this.jieMuTimeDuan,
            this.jieMuURL,
            this.jieMuName});
            this.dataGridView1.Location = new System.Drawing.Point(261, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(431, 344);
            this.dataGridView1.TabIndex = 1;
            // 
            // jieMuTime
            // 
            this.jieMuTime.DataPropertyName = "jieMuTime";
            this.jieMuTime.HeaderText = "播出时间";
            this.jieMuTime.Name = "jieMuTime";
            this.jieMuTime.ReadOnly = true;
            // 
            // jieMuTimeDuan
            // 
            this.jieMuTimeDuan.DataPropertyName = "jieMuTimeDuan";
            this.jieMuTimeDuan.HeaderText = "播出时间段";
            this.jieMuTimeDuan.Name = "jieMuTimeDuan";
            this.jieMuTimeDuan.ReadOnly = true;
            this.jieMuTimeDuan.Visible = false;
            // 
            // jieMuURL
            // 
            this.jieMuURL.DataPropertyName = "jieMuURL";
            this.jieMuURL.HeaderText = "节目地址";
            this.jieMuURL.Name = "jieMuURL";
            this.jieMuURL.ReadOnly = true;
            this.jieMuURL.Visible = false;
            // 
            // jieMuName
            // 
            this.jieMuName.DataPropertyName = "jieMuName";
            this.jieMuName.HeaderText = "节目名";
            this.jieMuName.Name = "jieMuName";
            this.jieMuName.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShouCangToolStripMenuItem,
            this.DelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // ShouCangToolStripMenuItem
            // 
            this.ShouCangToolStripMenuItem.Name = "ShouCangToolStripMenuItem";
            this.ShouCangToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ShouCangToolStripMenuItem.Text = "收藏";
            this.ShouCangToolStripMenuItem.Click += new System.EventHandler(this.ShouCangToolStripMenuItem_Click);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DelToolStripMenuItem.Text = "删除";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jieMuTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn jieMuTimeDuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn jieMuURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn jieMuName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShouCangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
    }
}

