namespace PingFenSystem
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
            this.lv_content = new System.Windows.Forms.ListView();
            this.empcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emptotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.empcontent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_content
            // 
            this.lv_content.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.empcode,
            this.empname,
            this.empage,
            this.emptotal,
            this.empcontent});
            this.lv_content.FullRowSelect = true;
            this.lv_content.GridLines = true;
            this.lv_content.Location = new System.Drawing.Point(81, 45);
            this.lv_content.Name = "lv_content";
            this.lv_content.Size = new System.Drawing.Size(372, 137);
            this.lv_content.TabIndex = 0;
            this.lv_content.UseCompatibleStateImageBehavior = false;
            this.lv_content.View = System.Windows.Forms.View.Details;
            this.lv_content.DoubleClick += new System.EventHandler(this.lv_content_DoubleClick);
            // 
            // empcode
            // 
            this.empcode.Text = "工号";
            // 
            // empname
            // 
            this.empname.Text = "姓名";
            // 
            // empage
            // 
            this.empage.Text = "年龄";
            // 
            // emptotal
            // 
            this.emptotal.Text = "评分";
            // 
            // empcontent
            // 
            this.empcontent.Text = "评价";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 308);
            this.Controls.Add(this.lv_content);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_content;
        private System.Windows.Forms.ColumnHeader empcode;
        private System.Windows.Forms.ColumnHeader empname;
        private System.Windows.Forms.ColumnHeader empage;
        private System.Windows.Forms.ColumnHeader emptotal;
        private System.Windows.Forms.ColumnHeader empcontent;
    }
}

