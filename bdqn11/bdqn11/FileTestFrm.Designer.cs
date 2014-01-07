namespace bdqn11
{
    partial class FileTestFrm
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
            this.tx_source = new System.Windows.Forms.TextBox();
            this.tx_desc = new System.Windows.Forms.TextBox();
            this.tx_path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_source
            // 
            this.tx_source.Location = new System.Drawing.Point(58, 62);
            this.tx_source.Name = "tx_source";
            this.tx_source.Size = new System.Drawing.Size(306, 21);
            this.tx_source.TabIndex = 0;
            // 
            // tx_desc
            // 
            this.tx_desc.Location = new System.Drawing.Point(58, 124);
            this.tx_desc.Name = "tx_desc";
            this.tx_desc.Size = new System.Drawing.Size(306, 21);
            this.tx_desc.TabIndex = 1;
            // 
            // tx_path
            // 
            this.tx_path.Location = new System.Drawing.Point(58, 228);
            this.tx_path.Name = "tx_path";
            this.tx_path.Size = new System.Drawing.Size(306, 21);
            this.tx_path.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "复制";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FileTestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 340);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_path);
            this.Controls.Add(this.tx_desc);
            this.Controls.Add(this.tx_source);
            this.Name = "FileTestFrm";
            this.Text = "FileTestFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_source;
        private System.Windows.Forms.TextBox tx_desc;
        private System.Windows.Forms.TextBox tx_path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}