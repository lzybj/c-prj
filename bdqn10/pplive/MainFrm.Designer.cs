namespace pplive
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShouCangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jieMuTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jieMuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jieMuTimeDuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jieMuURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.到时提醒ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分钟提醒ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分钟提醒ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.分钟提醒ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jieMuName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jieMuTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remindTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.取消提醒ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(31, 72);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(205, 329);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShouCangToolStripMenuItem,
            this.DelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jieMuTime,
            this.jieMuName,
            this.jieMuTimeDuan,
            this.jieMuURL});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.Location = new System.Drawing.Point(242, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(331, 329);
            this.dataGridView1.TabIndex = 1;
            // 
            // jieMuTime
            // 
            this.jieMuTime.DataPropertyName = "jieMuTime";
            this.jieMuTime.HeaderText = "播出时间";
            this.jieMuTime.Name = "jieMuTime";
            this.jieMuTime.ReadOnly = true;
            // 
            // jieMuName
            // 
            this.jieMuName.DataPropertyName = "jieMuName";
            this.jieMuName.HeaderText = "节目名";
            this.jieMuName.Name = "jieMuName";
            this.jieMuName.ReadOnly = true;
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
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.到时提醒ToolStripMenuItem,
            this.分钟提醒ToolStripMenuItem,
            this.分钟提醒ToolStripMenuItem1,
            this.分钟提醒ToolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(153, 114);
            // 
            // 到时提醒ToolStripMenuItem
            // 
            this.到时提醒ToolStripMenuItem.Name = "到时提醒ToolStripMenuItem";
            this.到时提醒ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.到时提醒ToolStripMenuItem.Text = "到时提醒";
            this.到时提醒ToolStripMenuItem.Click += new System.EventHandler(this.到时提醒ToolStripMenuItem_Click);
            // 
            // 分钟提醒ToolStripMenuItem
            // 
            this.分钟提醒ToolStripMenuItem.Name = "分钟提醒ToolStripMenuItem";
            this.分钟提醒ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.分钟提醒ToolStripMenuItem.Text = "10分钟提醒";
            // 
            // 分钟提醒ToolStripMenuItem1
            // 
            this.分钟提醒ToolStripMenuItem1.Name = "分钟提醒ToolStripMenuItem1";
            this.分钟提醒ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.分钟提醒ToolStripMenuItem1.Text = "20分钟提醒";
            // 
            // 分钟提醒ToolStripMenuItem2
            // 
            this.分钟提醒ToolStripMenuItem2.Name = "分钟提醒ToolStripMenuItem2";
            this.分钟提醒ToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.分钟提醒ToolStripMenuItem2.Text = "30分钟提醒";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tvName,
            this.jieMuName2,
            this.jieMuTime2,
            this.remindTime});
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip3;
            this.dataGridView2.Location = new System.Drawing.Point(242, 93);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(331, 308);
            this.dataGridView2.TabIndex = 2;
            // 
            // tvName
            // 
            this.tvName.DataPropertyName = "tvName";
            this.tvName.HeaderText = "电视台";
            this.tvName.Name = "tvName";
            this.tvName.ReadOnly = true;
            // 
            // jieMuName2
            // 
            this.jieMuName2.DataPropertyName = "jieMuName";
            this.jieMuName2.HeaderText = "节目名";
            this.jieMuName2.Name = "jieMuName2";
            this.jieMuName2.ReadOnly = true;
            // 
            // jieMuTime2
            // 
            this.jieMuTime2.DataPropertyName = "jieMuTime";
            this.jieMuTime2.HeaderText = "播出时间";
            this.jieMuTime2.Name = "jieMuTime2";
            this.jieMuTime2.ReadOnly = true;
            // 
            // remindTime
            // 
            this.remindTime.DataPropertyName = "remindTime";
            this.remindTime.HeaderText = "提醒时间";
            this.remindTime.Name = "remindTime";
            this.remindTime.ReadOnly = true;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.取消提醒ToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(119, 26);
            // 
            // 取消提醒ToolStripMenuItem
            // 
            this.取消提醒ToolStripMenuItem.Name = "取消提醒ToolStripMenuItem";
            this.取消提醒ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.取消提醒ToolStripMenuItem.Text = "取消提醒";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "提醒管理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn jieMuTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn jieMuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jieMuTimeDuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn jieMuURL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShouCangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jieMuName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn jieMuTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn remindTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 到时提醒ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分钟提醒ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分钟提醒ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 分钟提醒ToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem 取消提醒ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}