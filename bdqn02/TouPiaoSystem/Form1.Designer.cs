namespace TouPiaoSystem
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
            this.btn_content = new System.Windows.Forms.Button();
            this.btn_tpaction = new System.Windows.Forms.Button();
            this.lb_piaonum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_content
            // 
            this.btn_content.Location = new System.Drawing.Point(107, 87);
            this.btn_content.Name = "btn_content";
            this.btn_content.Size = new System.Drawing.Size(75, 23);
            this.btn_content.TabIndex = 0;
            this.btn_content.Text = "员工拉票";
            this.btn_content.UseVisualStyleBackColor = true;
            this.btn_content.Click += new System.EventHandler(this.btn_content_Click);
            // 
            // btn_tpaction
            // 
            this.btn_tpaction.Location = new System.Drawing.Point(107, 178);
            this.btn_tpaction.Name = "btn_tpaction";
            this.btn_tpaction.Size = new System.Drawing.Size(75, 23);
            this.btn_tpaction.TabIndex = 1;
            this.btn_tpaction.Text = "投票";
            this.btn_tpaction.UseVisualStyleBackColor = true;
            this.btn_tpaction.Click += new System.EventHandler(this.btn_tpaction_Click);
            // 
            // lb_piaonum
            // 
            this.lb_piaonum.AutoSize = true;
            this.lb_piaonum.Location = new System.Drawing.Point(125, 230);
            this.lb_piaonum.Name = "lb_piaonum";
            this.lb_piaonum.Size = new System.Drawing.Size(11, 12);
            this.lb_piaonum.TabIndex = 2;
            this.lb_piaonum.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "票";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_piaonum);
            this.Controls.Add(this.btn_tpaction);
            this.Controls.Add(this.btn_content);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_content;
        private System.Windows.Forms.Button btn_tpaction;
        private System.Windows.Forms.Label lb_piaonum;
        private System.Windows.Forms.Label label2;
    }
}

