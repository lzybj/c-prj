namespace bdqn05
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tx_tcname = new System.Windows.Forms.TextBox();
            this.btn_addtc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tclist = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_jianchalist = new System.Windows.Forms.ComboBox();
            this.btn_addjiancha = new System.Windows.Forms.Button();
            this.btn_removejiancha = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jianChaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jianChaContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jianChaPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "套餐名称：";
            // 
            // tx_tcname
            // 
            this.tx_tcname.Location = new System.Drawing.Point(178, 34);
            this.tx_tcname.Name = "tx_tcname";
            this.tx_tcname.Size = new System.Drawing.Size(100, 21);
            this.tx_tcname.TabIndex = 1;
            // 
            // btn_addtc
            // 
            this.btn_addtc.Location = new System.Drawing.Point(328, 32);
            this.btn_addtc.Name = "btn_addtc";
            this.btn_addtc.Size = new System.Drawing.Size(75, 23);
            this.btn_addtc.TabIndex = 2;
            this.btn_addtc.Text = "添加套餐";
            this.btn_addtc.UseVisualStyleBackColor = true;
            this.btn_addtc.Click += new System.EventHandler(this.btn_addtc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "套餐列表：";
            // 
            // cb_tclist
            // 
            this.cb_tclist.FormattingEnabled = true;
            this.cb_tclist.Location = new System.Drawing.Point(158, 102);
            this.cb_tclist.Name = "cb_tclist";
            this.cb_tclist.Size = new System.Drawing.Size(121, 20);
            this.cb_tclist.TabIndex = 4;
            this.cb_tclist.SelectedIndexChanged += new System.EventHandler(this.cb_tclist_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "检查项目列表：";
            // 
            // cb_jianchalist
            // 
            this.cb_jianchalist.FormattingEnabled = true;
            this.cb_jianchalist.Location = new System.Drawing.Point(432, 101);
            this.cb_jianchalist.Name = "cb_jianchalist";
            this.cb_jianchalist.Size = new System.Drawing.Size(121, 20);
            this.cb_jianchalist.TabIndex = 6;
            this.cb_jianchalist.SelectedIndexChanged += new System.EventHandler(this.cb_jianchalist_SelectedIndexChanged);
            // 
            // btn_addjiancha
            // 
            this.btn_addjiancha.Location = new System.Drawing.Point(328, 151);
            this.btn_addjiancha.Name = "btn_addjiancha";
            this.btn_addjiancha.Size = new System.Drawing.Size(75, 23);
            this.btn_addjiancha.TabIndex = 7;
            this.btn_addjiancha.Text = "添加检查";
            this.btn_addjiancha.UseVisualStyleBackColor = true;
            this.btn_addjiancha.Click += new System.EventHandler(this.btn_addjiancha_Click);
            // 
            // btn_removejiancha
            // 
            this.btn_removejiancha.Location = new System.Drawing.Point(432, 150);
            this.btn_removejiancha.Name = "btn_removejiancha";
            this.btn_removejiancha.Size = new System.Drawing.Size(75, 23);
            this.btn_removejiancha.TabIndex = 8;
            this.btn_removejiancha.Text = "删除检查";
            this.btn_removejiancha.UseVisualStyleBackColor = true;
            this.btn_removejiancha.Click += new System.EventHandler(this.btn_removejiancha_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jianChaName,
            this.jianChaContent,
            this.jianChaPrice});
            this.dataGridView1.Location = new System.Drawing.Point(129, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(346, 126);
            this.dataGridView1.TabIndex = 9;
            // 
            // jianChaName
            // 
            this.jianChaName.DataPropertyName = "ckName";
            this.jianChaName.HeaderText = "项目名称";
            this.jianChaName.Name = "jianChaName";
            this.jianChaName.ReadOnly = true;
            // 
            // jianChaContent
            // 
            this.jianChaContent.DataPropertyName = "ckContent";
            this.jianChaContent.HeaderText = "描述";
            this.jianChaContent.Name = "jianChaContent";
            this.jianChaContent.ReadOnly = true;
            // 
            // jianChaPrice
            // 
            this.jianChaPrice.DataPropertyName = "ckPrice";
            this.jianChaPrice.HeaderText = "价格";
            this.jianChaPrice.Name = "jianChaPrice";
            this.jianChaPrice.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "套餐名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "价格";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 365);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_removejiancha);
            this.Controls.Add(this.btn_addjiancha);
            this.Controls.Add(this.cb_jianchalist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_tclist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_addtc);
            this.Controls.Add(this.tx_tcname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_tcname;
        private System.Windows.Forms.Button btn_addtc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_tclist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_jianchalist;
        private System.Windows.Forms.Button btn_addjiancha;
        private System.Windows.Forms.Button btn_removejiancha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn jianChaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn jianChaContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn jianChaPrice;
    }
}

