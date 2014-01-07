namespace bdqn08
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
            this.tx_first = new System.Windows.Forms.TextBox();
            this.tx_oper = new System.Windows.Forms.TextBox();
            this.tx_second = new System.Windows.Forms.TextBox();
            this.tx_res = new System.Windows.Forms.TextBox();
            this.btn_resaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_first
            // 
            this.tx_first.Location = new System.Drawing.Point(47, 80);
            this.tx_first.Name = "tx_first";
            this.tx_first.Size = new System.Drawing.Size(100, 21);
            this.tx_first.TabIndex = 0;
            // 
            // tx_oper
            // 
            this.tx_oper.Location = new System.Drawing.Point(213, 79);
            this.tx_oper.Name = "tx_oper";
            this.tx_oper.Size = new System.Drawing.Size(100, 21);
            this.tx_oper.TabIndex = 1;
            // 
            // tx_second
            // 
            this.tx_second.Location = new System.Drawing.Point(395, 79);
            this.tx_second.Name = "tx_second";
            this.tx_second.Size = new System.Drawing.Size(100, 21);
            this.tx_second.TabIndex = 2;
            // 
            // tx_res
            // 
            this.tx_res.Location = new System.Drawing.Point(159, 161);
            this.tx_res.Name = "tx_res";
            this.tx_res.Size = new System.Drawing.Size(100, 21);
            this.tx_res.TabIndex = 3;
            // 
            // btn_resaction
            // 
            this.btn_resaction.Location = new System.Drawing.Point(320, 158);
            this.btn_resaction.Name = "btn_resaction";
            this.btn_resaction.Size = new System.Drawing.Size(75, 23);
            this.btn_resaction.TabIndex = 4;
            this.btn_resaction.Text = "计算";
            this.btn_resaction.UseVisualStyleBackColor = true;
            this.btn_resaction.Click += new System.EventHandler(this.btn_resaction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 273);
            this.Controls.Add(this.btn_resaction);
            this.Controls.Add(this.tx_res);
            this.Controls.Add(this.tx_second);
            this.Controls.Add(this.tx_oper);
            this.Controls.Add(this.tx_first);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_first;
        private System.Windows.Forms.TextBox tx_oper;
        private System.Windows.Forms.TextBox tx_second;
        private System.Windows.Forms.TextBox tx_res;
        private System.Windows.Forms.Button btn_resaction;
    }
}

