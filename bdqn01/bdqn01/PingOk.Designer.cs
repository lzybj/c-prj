namespace bdqn01
{
    partial class PingOk
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
            this.ipstr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipstr
            // 
            this.ipstr.Location = new System.Drawing.Point(132, 78);
            this.ipstr.Name = "ipstr";
            this.ipstr.Size = new System.Drawing.Size(100, 21);
            this.ipstr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入IP地址：";
            // 
            // btn_ping
            // 
            this.btn_ping.Location = new System.Drawing.Point(132, 179);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(75, 23);
            this.btn_ping.TabIndex = 2;
            this.btn_ping.Text = "检测";
            this.btn_ping.UseVisualStyleBackColor = true;
            this.btn_ping.Click += new System.EventHandler(this.btn_ping_Click);
            // 
            // PingOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 273);
            this.Controls.Add(this.btn_ping);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipstr);
            this.Name = "PingOk";
            this.Text = "PingOk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipstr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ping;
    }
}