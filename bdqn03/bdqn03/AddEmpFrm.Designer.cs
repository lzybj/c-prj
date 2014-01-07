namespace bdqn03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_empcode = new System.Windows.Forms.TextBox();
            this.tx_empname = new System.Windows.Forms.TextBox();
            this.tx_empsex = new System.Windows.Forms.TextBox();
            this.tx_empage = new System.Windows.Forms.TextBox();
            this.btn_addempaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工编号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "员工性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "员工年龄";
            // 
            // tx_empcode
            // 
            this.tx_empcode.Location = new System.Drawing.Point(114, 46);
            this.tx_empcode.Name = "tx_empcode";
            this.tx_empcode.Size = new System.Drawing.Size(100, 21);
            this.tx_empcode.TabIndex = 4;
            // 
            // tx_empname
            // 
            this.tx_empname.Location = new System.Drawing.Point(114, 93);
            this.tx_empname.Name = "tx_empname";
            this.tx_empname.Size = new System.Drawing.Size(100, 21);
            this.tx_empname.TabIndex = 5;
            // 
            // tx_empsex
            // 
            this.tx_empsex.Location = new System.Drawing.Point(114, 158);
            this.tx_empsex.Name = "tx_empsex";
            this.tx_empsex.Size = new System.Drawing.Size(100, 21);
            this.tx_empsex.TabIndex = 6;
            // 
            // tx_empage
            // 
            this.tx_empage.Location = new System.Drawing.Point(114, 209);
            this.tx_empage.Name = "tx_empage";
            this.tx_empage.Size = new System.Drawing.Size(100, 21);
            this.tx_empage.TabIndex = 7;
            // 
            // btn_addempaction
            // 
            this.btn_addempaction.Location = new System.Drawing.Point(102, 266);
            this.btn_addempaction.Name = "btn_addempaction";
            this.btn_addempaction.Size = new System.Drawing.Size(75, 23);
            this.btn_addempaction.TabIndex = 8;
            this.btn_addempaction.Text = "添加员工";
            this.btn_addempaction.UseVisualStyleBackColor = true;
            this.btn_addempaction.Click += new System.EventHandler(this.btn_addempaction_Click);
            // 
            // AddEmpFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 330);
            this.Controls.Add(this.btn_addempaction);
            this.Controls.Add(this.tx_empage);
            this.Controls.Add(this.tx_empsex);
            this.Controls.Add(this.tx_empname);
            this.Controls.Add(this.tx_empcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmpFrm";
            this.Text = "AddEmpFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_empcode;
        private System.Windows.Forms.TextBox tx_empname;
        private System.Windows.Forms.TextBox tx_empsex;
        private System.Windows.Forms.TextBox tx_empage;
        private System.Windows.Forms.Button btn_addempaction;
    }
}