namespace PingDemo
{
    partial class IpTest
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
            this.ipaddress = new System.Windows.Forms.TextBox();
            this.testip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipaddress
            // 
            this.ipaddress.Location = new System.Drawing.Point(76, 81);
            this.ipaddress.Name = "ipaddress";
            this.ipaddress.Size = new System.Drawing.Size(130, 21);
            this.ipaddress.TabIndex = 0;
            // 
            // testip
            // 
            this.testip.Location = new System.Drawing.Point(108, 162);
            this.testip.Name = "testip";
            this.testip.Size = new System.Drawing.Size(75, 23);
            this.testip.TabIndex = 1;
            this.testip.Text = "测试";
            this.testip.UseVisualStyleBackColor = true;
            this.testip.Click += new System.EventHandler(this.testip_Click);
            // 
            // IpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.testip);
            this.Controls.Add(this.ipaddress);
            this.Name = "IpTest";
            this.Text = "测试IP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipaddress;
        private System.Windows.Forms.Button testip;
    }
}

