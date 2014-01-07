namespace mis
{
    partial class UpEmp
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
            this.tx_empcode = new System.Windows.Forms.TextBox();
            this.tx_empname = new System.Windows.Forms.TextBox();
            this.btn_upemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_empcode
            // 
            this.tx_empcode.Location = new System.Drawing.Point(92, 53);
            this.tx_empcode.Name = "tx_empcode";
            this.tx_empcode.ReadOnly = true;
            this.tx_empcode.Size = new System.Drawing.Size(100, 21);
            this.tx_empcode.TabIndex = 0;
            // 
            // tx_empname
            // 
            this.tx_empname.Location = new System.Drawing.Point(92, 144);
            this.tx_empname.Name = "tx_empname";
            this.tx_empname.Size = new System.Drawing.Size(100, 21);
            this.tx_empname.TabIndex = 1;
            // 
            // btn_upemp
            // 
            this.btn_upemp.Location = new System.Drawing.Point(105, 208);
            this.btn_upemp.Name = "btn_upemp";
            this.btn_upemp.Size = new System.Drawing.Size(75, 23);
            this.btn_upemp.TabIndex = 2;
            this.btn_upemp.Text = "修改";
            this.btn_upemp.UseVisualStyleBackColor = true;
            this.btn_upemp.Click += new System.EventHandler(this.btn_upemp_Click);
            // 
            // UpEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btn_upemp);
            this.Controls.Add(this.tx_empname);
            this.Controls.Add(this.tx_empcode);
            this.Name = "UpEmp";
            this.Text = "UpEmp";
            this.Load += new System.EventHandler(this.UpEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_empcode;
        private System.Windows.Forms.TextBox tx_empname;
        private System.Windows.Forms.Button btn_upemp;
    }
}