using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PingFenSystem.entity;

namespace PingFenSystem
{
    public partial class Details : Form
    {
        private Emp emp = null;
        private Form1 frm1 = null;

        public Form1 Frm1
        {
            get { return frm1; }
            set { frm1 = value; }
        }

        public Details(Emp emp)
        {
            this.emp = emp;
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            tx_empname.Text = emp.EmpName;
            tx_empcontent.Text = emp.EmpContent;
            tx_emptotal.Text = emp.EmpTotal.ToString();
        }

        private void btn_pingfenaction_Click(object sender, EventArgs e)
        {
            //获得修改后的评价和评分
            emp.EmpContent = tx_empcontent.Text;
            emp.EmpTotal = int.Parse(tx_emptotal.Text);
            //调用Form1类updateEmp方法
            
            
            
            frm1.updateEmp(emp);
            //关闭此窗体
            this.Close();

        }
    }
}
