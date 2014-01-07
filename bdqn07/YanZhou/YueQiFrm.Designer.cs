namespace YanZhou
{
    partial class YueQiFrm
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
            this.radio_gq = new System.Windows.Forms.RadioButton();
            this.radio_xtq = new System.Windows.Forms.RadioButton();
            this.radio_sks = new System.Windows.Forms.RadioButton();
            this.btn_yzaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio_gq
            // 
            this.radio_gq.AutoSize = true;
            this.radio_gq.Location = new System.Drawing.Point(59, 49);
            this.radio_gq.Name = "radio_gq";
            this.radio_gq.Size = new System.Drawing.Size(47, 16);
            this.radio_gq.TabIndex = 0;
            this.radio_gq.TabStop = true;
            this.radio_gq.Text = "钢琴";
            this.radio_gq.UseVisualStyleBackColor = true;
            // 
            // radio_xtq
            // 
            this.radio_xtq.AutoSize = true;
            this.radio_xtq.Location = new System.Drawing.Point(59, 109);
            this.radio_xtq.Name = "radio_xtq";
            this.radio_xtq.Size = new System.Drawing.Size(59, 16);
            this.radio_xtq.TabIndex = 1;
            this.radio_xtq.TabStop = true;
            this.radio_xtq.Text = "小提琴";
            this.radio_xtq.UseVisualStyleBackColor = true;
            // 
            // radio_sks
            // 
            this.radio_sks.AutoSize = true;
            this.radio_sks.Location = new System.Drawing.Point(59, 164);
            this.radio_sks.Name = "radio_sks";
            this.radio_sks.Size = new System.Drawing.Size(59, 16);
            this.radio_sks.TabIndex = 2;
            this.radio_sks.TabStop = true;
            this.radio_sks.Text = "萨克斯";
            this.radio_sks.UseVisualStyleBackColor = true;
            // 
            // btn_yzaction
            // 
            this.btn_yzaction.Location = new System.Drawing.Point(116, 210);
            this.btn_yzaction.Name = "btn_yzaction";
            this.btn_yzaction.Size = new System.Drawing.Size(75, 23);
            this.btn_yzaction.TabIndex = 3;
            this.btn_yzaction.Text = "演奏";
            this.btn_yzaction.UseVisualStyleBackColor = true;
            this.btn_yzaction.Click += new System.EventHandler(this.btn_yzaction_Click);
            // 
            // YueQiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 273);
            this.Controls.Add(this.btn_yzaction);
            this.Controls.Add(this.radio_sks);
            this.Controls.Add(this.radio_xtq);
            this.Controls.Add(this.radio_gq);
            this.Name = "YueQiFrm";
            this.Text = "YueQiFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_gq;
        private System.Windows.Forms.RadioButton radio_xtq;
        private System.Windows.Forms.RadioButton radio_sks;
        private System.Windows.Forms.Button btn_yzaction;
    }
}