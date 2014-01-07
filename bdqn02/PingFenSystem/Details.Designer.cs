namespace PingFenSystem
{
    partial class Details
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
            this.tx_empname = new System.Windows.Forms.TextBox();
            this.tx_empcontent = new System.Windows.Forms.TextBox();
            this.tx_emptotal = new System.Windows.Forms.TextBox();
            this.btn_pingfenaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工评价";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "员工评分";
            // 
            // tx_empname
            // 
            this.tx_empname.Location = new System.Drawing.Point(135, 51);
            this.tx_empname.Name = "tx_empname";
            this.tx_empname.ReadOnly = true;
            this.tx_empname.Size = new System.Drawing.Size(100, 21);
            this.tx_empname.TabIndex = 3;
            // 
            // tx_empcontent
            // 
            this.tx_empcontent.Location = new System.Drawing.Point(135, 94);
            this.tx_empcontent.Multiline = true;
            this.tx_empcontent.Name = "tx_empcontent";
            this.tx_empcontent.Size = new System.Drawing.Size(100, 21);
            this.tx_empcontent.TabIndex = 4;
            // 
            // tx_emptotal
            // 
            this.tx_emptotal.Location = new System.Drawing.Point(135, 149);
            this.tx_emptotal.Name = "tx_emptotal";
            this.tx_emptotal.Size = new System.Drawing.Size(100, 21);
            this.tx_emptotal.TabIndex = 5;
            // 
            // btn_pingfenaction
            // 
            this.btn_pingfenaction.Location = new System.Drawing.Point(115, 214);
            this.btn_pingfenaction.Name = "btn_pingfenaction";
            this.btn_pingfenaction.Size = new System.Drawing.Size(75, 23);
            this.btn_pingfenaction.TabIndex = 6;
            this.btn_pingfenaction.Text = "评分";
            this.btn_pingfenaction.UseVisualStyleBackColor = true;
            this.btn_pingfenaction.Click += new System.EventHandler(this.btn_pingfenaction_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 273);
            this.Controls.Add(this.btn_pingfenaction);
            this.Controls.Add(this.tx_emptotal);
            this.Controls.Add(this.tx_empcontent);
            this.Controls.Add(this.tx_empname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Details";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_empname;
        private System.Windows.Forms.TextBox tx_empcontent;
        private System.Windows.Forms.TextBox tx_emptotal;
        private System.Windows.Forms.Button btn_pingfenaction;
    }
}