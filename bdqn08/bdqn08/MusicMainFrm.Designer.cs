namespace bdqn08
{
    partial class MusicMainFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mp3Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mp3GeShou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mp3URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mp3Name,
            this.mp3GeShou,
            this.mp3URL});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(75, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(419, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // PlayToolStripMenuItem
            // 
            this.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem";
            this.PlayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PlayToolStripMenuItem.Text = "播放";
            this.PlayToolStripMenuItem.Click += new System.EventHandler(this.PlayToolStripMenuItem_Click);
            // 
            // mp3Name
            // 
            this.mp3Name.DataPropertyName = "mp3Name";
            this.mp3Name.HeaderText = "歌曲名";
            this.mp3Name.Name = "mp3Name";
            this.mp3Name.ReadOnly = true;
            // 
            // mp3GeShou
            // 
            this.mp3GeShou.DataPropertyName = "mp3GeShou";
            this.mp3GeShou.HeaderText = "歌手名";
            this.mp3GeShou.Name = "mp3GeShou";
            this.mp3GeShou.ReadOnly = true;
            // 
            // mp3URL
            // 
            this.mp3URL.DataPropertyName = "mp3URL";
            this.mp3URL.HeaderText = "播放地址";
            this.mp3URL.Name = "mp3URL";
            this.mp3URL.ReadOnly = true;
            // 
            // MusicMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 273);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MusicMainFrm";
            this.Text = "MusicMainFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PlayToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mp3Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn mp3GeShou;
        private System.Windows.Forms.DataGridViewTextBoxColumn mp3URL;
    }
}