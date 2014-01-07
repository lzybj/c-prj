namespace bdqn09
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_cno = new System.Windows.Forms.TextBox();
            this.tx_cname = new System.Windows.Forms.TextBox();
            this.tx_ccolor = new System.Windows.Forms.TextBox();
            this.tx_cdaynum = new System.Windows.Forms.TextBox();
            this.tx_cUnitPrice = new System.Windows.Forms.TextBox();
            this.tx_cload = new System.Windows.Forms.TextBox();
            this.btn_rukuaction = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_cUserName = new System.Windows.Forms.TextBox();
            this.btn_zucheaction = new System.Windows.Forms.Button();
            this.btn_getzcaction = new System.Windows.Forms.Button();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDayNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLoad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_yczaction = new System.Windows.Forms.Button();
            this.cNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cColor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDayNum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUnitPrice2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLoad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUserName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_cDayNum2 = new System.Windows.Forms.TextBox();
            this.btn_jsaction = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(24, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_getzcaction);
            this.tabPage1.Controls.Add(this.btn_zucheaction);
            this.tabPage1.Controls.Add(this.tx_cUserName);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(578, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "出租";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_jsaction);
            this.tabPage2.Controls.Add(this.tx_cDayNum2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btn_yczaction);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(578, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "还车";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(253, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "车辆租赁系统";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_rukuaction);
            this.tabPage3.Controls.Add(this.tx_cload);
            this.tabPage3.Controls.Add(this.tx_cUnitPrice);
            this.tabPage3.Controls.Add(this.tx_cdaynum);
            this.tabPage3.Controls.Add(this.tx_ccolor);
            this.tabPage3.Controls.Add(this.tx_cname);
            this.tabPage3.Controls.Add(this.tx_cno);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.radioButton2);
            this.tabPage3.Controls.Add(this.radioButton1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(578, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "新车入库";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(145, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "小轿车";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(288, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "卡车";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "车牌号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "车名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "车颜色";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "使用天数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "日租金";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "载重";
            // 
            // tx_cno
            // 
            this.tx_cno.Location = new System.Drawing.Point(209, 35);
            this.tx_cno.Name = "tx_cno";
            this.tx_cno.Size = new System.Drawing.Size(100, 21);
            this.tx_cno.TabIndex = 8;
            // 
            // tx_cname
            // 
            this.tx_cname.Location = new System.Drawing.Point(209, 75);
            this.tx_cname.Name = "tx_cname";
            this.tx_cname.Size = new System.Drawing.Size(100, 21);
            this.tx_cname.TabIndex = 9;
            // 
            // tx_ccolor
            // 
            this.tx_ccolor.Location = new System.Drawing.Point(209, 109);
            this.tx_ccolor.Name = "tx_ccolor";
            this.tx_ccolor.Size = new System.Drawing.Size(100, 21);
            this.tx_ccolor.TabIndex = 10;
            // 
            // tx_cdaynum
            // 
            this.tx_cdaynum.Location = new System.Drawing.Point(209, 140);
            this.tx_cdaynum.Name = "tx_cdaynum";
            this.tx_cdaynum.Size = new System.Drawing.Size(100, 21);
            this.tx_cdaynum.TabIndex = 11;
            // 
            // tx_cUnitPrice
            // 
            this.tx_cUnitPrice.Location = new System.Drawing.Point(209, 182);
            this.tx_cUnitPrice.Name = "tx_cUnitPrice";
            this.tx_cUnitPrice.Size = new System.Drawing.Size(100, 21);
            this.tx_cUnitPrice.TabIndex = 12;
            // 
            // tx_cload
            // 
            this.tx_cload.Location = new System.Drawing.Point(209, 220);
            this.tx_cload.Name = "tx_cload";
            this.tx_cload.Size = new System.Drawing.Size(100, 21);
            this.tx_cload.TabIndex = 13;
            // 
            // btn_rukuaction
            // 
            this.btn_rukuaction.Location = new System.Drawing.Point(190, 272);
            this.btn_rukuaction.Name = "btn_rukuaction";
            this.btn_rukuaction.Size = new System.Drawing.Size(75, 23);
            this.btn_rukuaction.TabIndex = 14;
            this.btn_rukuaction.Text = "入库";
            this.btn_rukuaction.UseVisualStyleBackColor = true;
            this.btn_rukuaction.Click += new System.EventHandler(this.btn_rukuaction_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNo,
            this.cName,
            this.cColor,
            this.cDayNum,
            this.cUnitPrice,
            this.cLoad,
            this.cUserName});
            this.dataGridView1.Location = new System.Drawing.Point(6, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(555, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "承租人";
            // 
            // tx_cUserName
            // 
            this.tx_cUserName.Location = new System.Drawing.Point(188, 249);
            this.tx_cUserName.Name = "tx_cUserName";
            this.tx_cUserName.Size = new System.Drawing.Size(100, 21);
            this.tx_cUserName.TabIndex = 2;
            // 
            // btn_zucheaction
            // 
            this.btn_zucheaction.Location = new System.Drawing.Point(267, 300);
            this.btn_zucheaction.Name = "btn_zucheaction";
            this.btn_zucheaction.Size = new System.Drawing.Size(75, 23);
            this.btn_zucheaction.TabIndex = 3;
            this.btn_zucheaction.Text = "租车";
            this.btn_zucheaction.UseVisualStyleBackColor = true;
            this.btn_zucheaction.Click += new System.EventHandler(this.btn_zucheaction_Click);
            // 
            // btn_getzcaction
            // 
            this.btn_getzcaction.Location = new System.Drawing.Point(132, 300);
            this.btn_getzcaction.Name = "btn_getzcaction";
            this.btn_getzcaction.Size = new System.Drawing.Size(75, 23);
            this.btn_getzcaction.TabIndex = 4;
            this.btn_getzcaction.Text = "刷新";
            this.btn_getzcaction.UseVisualStyleBackColor = true;
            this.btn_getzcaction.Click += new System.EventHandler(this.btn_getzcaction_Click);
            // 
            // cNo
            // 
            this.cNo.DataPropertyName = "cNo";
            this.cNo.HeaderText = "车牌";
            this.cNo.Name = "cNo";
            this.cNo.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "cName";
            this.cName.HeaderText = "车名";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cColor
            // 
            this.cColor.DataPropertyName = "cColor";
            this.cColor.HeaderText = "颜色";
            this.cColor.Name = "cColor";
            this.cColor.ReadOnly = true;
            // 
            // cDayNum
            // 
            this.cDayNum.DataPropertyName = "cDayNum";
            this.cDayNum.HeaderText = "预使用天数";
            this.cDayNum.Name = "cDayNum";
            this.cDayNum.ReadOnly = true;
            // 
            // cUnitPrice
            // 
            this.cUnitPrice.DataPropertyName = "cUnitPrice";
            this.cUnitPrice.HeaderText = "日租金";
            this.cUnitPrice.Name = "cUnitPrice";
            this.cUnitPrice.ReadOnly = true;
            // 
            // cLoad
            // 
            this.cLoad.DataPropertyName = "cLoad";
            this.cLoad.HeaderText = "载重";
            this.cLoad.Name = "cLoad";
            this.cLoad.ReadOnly = true;
            // 
            // cUserName
            // 
            this.cUserName.DataPropertyName = "cUserName";
            this.cUserName.HeaderText = "承租人";
            this.cUserName.Name = "cUserName";
            this.cUserName.ReadOnly = true;
            this.cUserName.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNo2,
            this.cName2,
            this.cColor2,
            this.cDayNum2,
            this.cUnitPrice2,
            this.cLoad2,
            this.cUserName2});
            this.dataGridView2.Location = new System.Drawing.Point(18, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(543, 203);
            this.dataGridView2.TabIndex = 0;
            // 
            // btn_yczaction
            // 
            this.btn_yczaction.Location = new System.Drawing.Point(177, 301);
            this.btn_yczaction.Name = "btn_yczaction";
            this.btn_yczaction.Size = new System.Drawing.Size(75, 23);
            this.btn_yczaction.TabIndex = 1;
            this.btn_yczaction.Text = "刷新";
            this.btn_yczaction.UseVisualStyleBackColor = true;
            this.btn_yczaction.Click += new System.EventHandler(this.btn_yczaction_Click);
            // 
            // cNo2
            // 
            this.cNo2.DataPropertyName = "cNo";
            this.cNo2.HeaderText = "车牌";
            this.cNo2.Name = "cNo2";
            this.cNo2.ReadOnly = true;
            // 
            // cName2
            // 
            this.cName2.DataPropertyName = "cName";
            this.cName2.HeaderText = "车名";
            this.cName2.Name = "cName2";
            this.cName2.ReadOnly = true;
            // 
            // cColor2
            // 
            this.cColor2.DataPropertyName = "cColor";
            this.cColor2.HeaderText = "颜色";
            this.cColor2.Name = "cColor2";
            this.cColor2.ReadOnly = true;
            // 
            // cDayNum2
            // 
            this.cDayNum2.DataPropertyName = "cDayNum";
            this.cDayNum2.HeaderText = "预期使用时间";
            this.cDayNum2.Name = "cDayNum2";
            this.cDayNum2.ReadOnly = true;
            // 
            // cUnitPrice2
            // 
            this.cUnitPrice2.DataPropertyName = "cUnitPrice";
            this.cUnitPrice2.HeaderText = "日租金";
            this.cUnitPrice2.Name = "cUnitPrice2";
            this.cUnitPrice2.ReadOnly = true;
            // 
            // cLoad2
            // 
            this.cLoad2.DataPropertyName = "cLoad";
            this.cLoad2.HeaderText = "载重";
            this.cLoad2.Name = "cLoad2";
            this.cLoad2.ReadOnly = true;
            // 
            // cUserName2
            // 
            this.cUserName2.DataPropertyName = "cUserName";
            this.cUserName2.HeaderText = "承租人";
            this.cUserName2.Name = "cUserName2";
            this.cUserName2.ReadOnly = true;
            this.cUserName2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "实际使用天数：";
            // 
            // tx_cDayNum2
            // 
            this.tx_cDayNum2.Location = new System.Drawing.Point(239, 233);
            this.tx_cDayNum2.Name = "tx_cDayNum2";
            this.tx_cDayNum2.Size = new System.Drawing.Size(100, 21);
            this.tx_cDayNum2.TabIndex = 3;
            // 
            // btn_jsaction
            // 
            this.btn_jsaction.Location = new System.Drawing.Point(291, 300);
            this.btn_jsaction.Name = "btn_jsaction";
            this.btn_jsaction.Size = new System.Drawing.Size(75, 23);
            this.btn_jsaction.TabIndex = 4;
            this.btn_jsaction.Text = "结算";
            this.btn_jsaction.UseVisualStyleBackColor = true;
            this.btn_jsaction.Click += new System.EventHandler(this.btn_jsaction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_rukuaction;
        private System.Windows.Forms.TextBox tx_cload;
        private System.Windows.Forms.TextBox tx_cUnitPrice;
        private System.Windows.Forms.TextBox tx_cdaynum;
        private System.Windows.Forms.TextBox tx_ccolor;
        private System.Windows.Forms.TextBox tx_cname;
        private System.Windows.Forms.TextBox tx_cno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_getzcaction;
        private System.Windows.Forms.Button btn_zucheaction;
        private System.Windows.Forms.TextBox tx_cUserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDayNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserName;
        private System.Windows.Forms.Button btn_yczaction;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cColor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDayNum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUnitPrice2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLoad2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUserName2;
        private System.Windows.Forms.Button btn_jsaction;
        private System.Windows.Forms.TextBox tx_cDayNum2;
        private System.Windows.Forms.Label label9;
    }
}

