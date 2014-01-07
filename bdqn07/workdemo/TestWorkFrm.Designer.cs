namespace workdemo
{
    partial class TestWorkFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_casenum = new System.Windows.Forms.TextBox();
            this.tx_fbug = new System.Windows.Forms.TextBox();
            this.tx_wday = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "测试用例个数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "发现BUG数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "工作日";
            // 
            // tx_casenum
            // 
            this.tx_casenum.Location = new System.Drawing.Point(154, 43);
            this.tx_casenum.Name = "tx_casenum";
            this.tx_casenum.Size = new System.Drawing.Size(100, 21);
            this.tx_casenum.TabIndex = 3;
            // 
            // tx_fbug
            // 
            this.tx_fbug.Location = new System.Drawing.Point(154, 108);
            this.tx_fbug.Name = "tx_fbug";
            this.tx_fbug.Size = new System.Drawing.Size(100, 21);
            this.tx_fbug.TabIndex = 4;
            // 
            // tx_wday
            // 
            this.tx_wday.Location = new System.Drawing.Point(154, 172);
            this.tx_wday.Name = "tx_wday";
            this.tx_wday.Size = new System.Drawing.Size(100, 21);
            this.tx_wday.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestWorkFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_wday);
            this.Controls.Add(this.tx_fbug);
            this.Controls.Add(this.tx_casenum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TestWorkFrm";
            this.Text = "TestWorkFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_casenum;
        private System.Windows.Forms.TextBox tx_fbug;
        private System.Windows.Forms.TextBox tx_wday;
        private System.Windows.Forms.Button button1;
    }
}