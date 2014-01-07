using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using JiSuanQi.service;

namespace JiSuanQi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_jisuanaction_Click(object sender, EventArgs e)
        {
            //1.获得参数
            //2.调用业务逻辑
            //3.获得结果
            //4.选择相应视图显示
            int leftnum = int.Parse(tx_leftnum.Text);
            string fuhao = tx_fuhao.Text;
            int rightnum = int.Parse(tx_rightnum.Text);
            JiSuanQiService jqs = new JiSuanQiService();
            double res = jqs.JiSuan(leftnum,fuhao,rightnum);
            tx_res.Text = res.ToString();
            tx_res.ReadOnly = true;
        }
    }
}
