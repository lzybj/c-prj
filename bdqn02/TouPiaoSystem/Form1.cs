using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TouPiaoSystem.entity;
using TouPiaoSystem.service;

namespace TouPiaoSystem
{
    public partial class Form1 : Form
    {
        private Emp myEmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_content_Click(object sender, EventArgs e)
        {
            myEmp = new Emp("1001","laozheng","man",32,0);
            //MessageBox.Show(myEmp.EmpName);
            MessageBox.Show(myEmp.EmpName+"感谢你投票！");
        }

        private void btn_tpaction_Click(object sender, EventArgs e)
        {
            VoteService vs = new VoteService();
            if (myEmp == null)
            {
                MessageBox.Show("兄弟，太热情，还是先拉票！");
                return;
            }
            vs.vote(myEmp);
            MessageBox.Show("老郑在这里谢过了！");
            //填充票数
            lb_piaonum.Text = myEmp.EmpNum.ToString();
            if (myEmp.EmpNum >= 2)
            {
                btn_tpaction.Enabled = false;
            }
        }
    }
}
