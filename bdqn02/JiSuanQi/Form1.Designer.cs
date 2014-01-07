namespace JiSuanQi
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
            this.tx_leftnum = new System.Windows.Forms.TextBox();
            this.tx_rightnum = new System.Windows.Forms.TextBox();
            this.tx_fuhao = new System.Windows.Forms.TextBox();
            this.tx_res = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_jisuanaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_leftnum
            // 
            this.tx_leftnum.Location = new System.Drawing.Point(67, 89);
            this.tx_leftnum.Name = "tx_leftnum";
            this.tx_leftnum.Size = new System.Drawing.Size(79, 21);
            this.tx_leftnum.TabIndex = 0;
            // 
            // tx_rightnum
            // 
            this.tx_rightnum.Location = new System.Drawing.Point(315, 89);
            this.tx_rightnum.Name = "tx_rightnum";
            this.tx_rightnum.Size = new System.Drawing.Size(87, 21);
            this.tx_rightnum.TabIndex = 1;
            // 
            // tx_fuhao
            // 
            this.tx_fuhao.Location = new System.Drawing.Point(180, 89);
            this.tx_fuhao.Name = "tx_fuhao";
            this.tx_fuhao.Size = new System.Drawing.Size(87, 21);
            this.tx_fuhao.TabIndex = 2;
            // 
            // tx_res
            // 
            this.tx_res.Location = new System.Drawing.Point(466, 89);
            this.tx_res.Name = "tx_res";
            this.tx_res.Size = new System.Drawing.Size(100, 21);
            this.tx_res.TabIndex = 3;
            this.tx_res.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // btn_jisuanaction
            // 
            this.btn_jisuanaction.Location = new System.Drawing.Point(258, 185);
            this.btn_jisuanaction.Name = "btn_jisuanaction";
            this.btn_jisuanaction.Size = new System.Drawing.Size(75, 23);
            this.btn_jisuanaction.TabIndex = 5;
            this.btn_jisuanaction.Text = "计算";
            this.btn_jisuanaction.UseVisualStyleBackColor = true;
            this.btn_jisuanaction.Click += new System.EventHandler(this.btn_jisuanaction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 273);
            this.Controls.Add(this.btn_jisuanaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_res);
            this.Controls.Add(this.tx_fuhao);
            this.Controls.Add(this.tx_rightnum);
            this.Controls.Add(this.tx_leftnum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_leftnum;
        private System.Windows.Forms.TextBox tx_rightnum;
        private System.Windows.Forms.TextBox tx_fuhao;
        private System.Windows.Forms.TextBox tx_res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_jisuanaction;
    }
}

