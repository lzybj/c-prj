namespace JiSuanQi
{
    partial class LoginFrm
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
            this.tx_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_password = new System.Windows.Forms.TextBox();
            this.btn_loginaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // tx_username
            // 
            this.tx_username.Location = new System.Drawing.Point(174, 86);
            this.tx_username.Name = "tx_username";
            this.tx_username.Size = new System.Drawing.Size(100, 21);
            this.tx_username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // tx_password
            // 
            this.tx_password.Location = new System.Drawing.Point(174, 179);
            this.tx_password.Name = "tx_password";
            this.tx_password.PasswordChar = '*';
            this.tx_password.Size = new System.Drawing.Size(100, 21);
            this.tx_password.TabIndex = 3;
            // 
            // btn_loginaction
            // 
            this.btn_loginaction.Location = new System.Drawing.Point(137, 227);
            this.btn_loginaction.Name = "btn_loginaction";
            this.btn_loginaction.Size = new System.Drawing.Size(75, 23);
            this.btn_loginaction.TabIndex = 4;
            this.btn_loginaction.Text = "提交";
            this.btn_loginaction.UseVisualStyleBackColor = true;
            this.btn_loginaction.Click += new System.EventHandler(this.btn_loginaction_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 273);
            this.Controls.Add(this.btn_loginaction);
            this.Controls.Add(this.tx_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_username);
            this.Controls.Add(this.label1);
            this.Name = "LoginFrm";
            this.Text = "LoginFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_password;
        private System.Windows.Forms.Button btn_loginaction;
    }
}