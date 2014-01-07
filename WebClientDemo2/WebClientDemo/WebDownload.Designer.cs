namespace WebClientDemo
{
    partial class WebDownload
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureshow = new System.Windows.Forms.PictureBox();
            this.downloadbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureshow)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureshow
            // 
            this.pictureshow.Image = global::WebClientDemo.Properties.Resources.Koala;
            this.pictureshow.Location = new System.Drawing.Point(83, 45);
            this.pictureshow.Name = "pictureshow";
            this.pictureshow.Size = new System.Drawing.Size(127, 110);
            this.pictureshow.TabIndex = 0;
            this.pictureshow.TabStop = false;
            // 
            // downloadbutton
            // 
            this.downloadbutton.Location = new System.Drawing.Point(114, 198);
            this.downloadbutton.Name = "downloadbutton";
            this.downloadbutton.Size = new System.Drawing.Size(75, 23);
            this.downloadbutton.TabIndex = 1;
            this.downloadbutton.Text = "下载";
            this.downloadbutton.UseVisualStyleBackColor = true;
            this.downloadbutton.Click += new System.EventHandler(this.downloadbutton_Click);
            // 
            // WebDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.downloadbutton);
            this.Controls.Add(this.pictureshow);
            this.Name = "WebDownload";
            this.Text = "网络下载图片";
            ((System.ComponentModel.ISupportInitialize)(this.pictureshow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureshow;
        private System.Windows.Forms.Button downloadbutton;
    }
}

