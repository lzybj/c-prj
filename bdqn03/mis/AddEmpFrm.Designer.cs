namespace mis
{
    partial class AddEmpFrm
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
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_empcode
            // 
            this.tx_empcode.Location = new System.Drawing.Point(97, 65);
            this.tx_empcode.Name = "tx_empcode";
            this.tx_empcode.Size = new System.Drawing.Size(100, 21);
            this.tx_empcode.TabIndex = 0;
            // 
            // tx_empname
            // 
            this.tx_empname.Location = new System.Drawing.Point(97, 151);
            this.tx_empname.Name = "tx_empname";
            this.tx_empname.Size = new System.Drawing.Size(100, 21);
            this.tx_empname.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(107, 215);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AddEmpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tx_empname);
            this.Controls.Add(this.tx_empcode);
            this.Name = "AddEmpFrm";
            this.Text = "AddEmpFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_empcode;
        private System.Windows.Forms.TextBox tx_empname;
        private System.Windows.Forms.Button btn_add;
    }
}