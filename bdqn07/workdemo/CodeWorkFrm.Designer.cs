namespace workdemo
{
    partial class CodeWorkFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.tx_wday = new System.Windows.Forms.TextBox();
            this.tx_bugnum = new System.Windows.Forms.TextBox();
            this.tx_codingnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "提交";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tx_wday
            // 
            this.tx_wday.Location = new System.Drawing.Point(151, 163);
            this.tx_wday.Name = "tx_wday";
            this.tx_wday.Size = new System.Drawing.Size(100, 21);
            this.tx_wday.TabIndex = 12;
            // 
            // tx_bugnum
            // 
            this.tx_bugnum.Location = new System.Drawing.Point(151, 99);
            this.tx_bugnum.Name = "tx_bugnum";
            this.tx_bugnum.Size = new System.Drawing.Size(100, 21);
            this.tx_bugnum.TabIndex = 11;
            // 
            // tx_codingnum
            // 
            this.tx_codingnum.Location = new System.Drawing.Point(151, 34);
            this.tx_codingnum.Name = "tx_codingnum";
            this.tx_codingnum.Size = new System.Drawing.Size(100, 21);
            this.tx_codingnum.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "工作日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "遗留问题";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "编写代码行数";
            // 
            // CodeWorkFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_wday);
            this.Controls.Add(this.tx_bugnum);
            this.Controls.Add(this.tx_codingnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CodeWorkFrm";
            this.Text = "CodeWorkFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_wday;
        private System.Windows.Forms.TextBox tx_bugnum;
        private System.Windows.Forms.TextBox tx_codingnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}