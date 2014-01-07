namespace TouPiaoSystem
{
    partial class MainFrm
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
            this.cb_emps = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_toupiaoaction = new System.Windows.Forms.Button();
            this.lb_nownum = new System.Windows.Forms.Label();
            this.lb_synum = new System.Windows.Forms.Label();
            this.btn_viewresaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_emps
            // 
            this.cb_emps.FormattingEnabled = true;
            this.cb_emps.Location = new System.Drawing.Point(115, 77);
            this.cb_emps.Name = "cb_emps";
            this.cb_emps.Size = new System.Drawing.Size(121, 20);
            this.cb_emps.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "候选人：";
            // 
            // btn_toupiaoaction
            // 
            this.btn_toupiaoaction.Location = new System.Drawing.Point(272, 73);
            this.btn_toupiaoaction.Name = "btn_toupiaoaction";
            this.btn_toupiaoaction.Size = new System.Drawing.Size(75, 23);
            this.btn_toupiaoaction.TabIndex = 2;
            this.btn_toupiaoaction.Text = "投票";
            this.btn_toupiaoaction.UseVisualStyleBackColor = true;
            this.btn_toupiaoaction.Click += new System.EventHandler(this.btn_toupiaoaction_Click);
            // 
            // lb_nownum
            // 
            this.lb_nownum.AutoSize = true;
            this.lb_nownum.Location = new System.Drawing.Point(80, 249);
            this.lb_nownum.Name = "lb_nownum";
            this.lb_nownum.Size = new System.Drawing.Size(11, 12);
            this.lb_nownum.TabIndex = 9;
            this.lb_nownum.Text = "0";
            // 
            // lb_synum
            // 
            this.lb_synum.AutoSize = true;
            this.lb_synum.Location = new System.Drawing.Point(185, 249);
            this.lb_synum.Name = "lb_synum";
            this.lb_synum.Size = new System.Drawing.Size(11, 12);
            this.lb_synum.TabIndex = 10;
            this.lb_synum.Text = "0";
            // 
            // btn_viewresaction
            // 
            this.btn_viewresaction.Location = new System.Drawing.Point(382, 73);
            this.btn_viewresaction.Name = "btn_viewresaction";
            this.btn_viewresaction.Size = new System.Drawing.Size(75, 23);
            this.btn_viewresaction.TabIndex = 11;
            this.btn_viewresaction.Text = "查看票数";
            this.btn_viewresaction.UseVisualStyleBackColor = true;
            this.btn_viewresaction.Click += new System.EventHandler(this.btn_viewresaction_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 273);
            this.Controls.Add(this.btn_viewresaction);
            this.Controls.Add(this.lb_synum);
            this.Controls.Add(this.lb_nownum);
            this.Controls.Add(this.btn_toupiaoaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_emps);
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_emps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_toupiaoaction;
        private System.Windows.Forms.Label lb_nownum;
        private System.Windows.Forms.Label lb_synum;
        private System.Windows.Forms.Button btn_viewresaction;
    }
}