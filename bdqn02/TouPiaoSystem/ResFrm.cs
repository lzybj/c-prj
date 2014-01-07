using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TouPiaoSystem.entity;

namespace TouPiaoSystem
{
    public partial class ResFrm : Form
    {
        private Emp[] emps = new Emp[3];
        public ResFrm(Emp[] data)
        {
            this.emps = data;
            InitializeComponent();
        }

        private void ResFrm_Load(object sender, EventArgs e)
        {
            //初始化进度条相关值
            label3.AutoSize = false;
            label3.BackColor = Color.Red;

            label4.AutoSize = false;
            label4.BackColor = Color.Red;

            label5.AutoSize = false;
            label5.BackColor = Color.Red;

            lb_emp0.Text = emps[0].EmpNum.ToString();
            lb_emp1.Text = emps[1].EmpNum.ToString();
            lb_emp2.Text = emps[2].EmpNum.ToString();
            
            //用lable控件的width属性与票数配合

            label3.Width = emps[0].EmpNum * 10;
            label4.Width = emps[1].EmpNum * 10;
            label5.Width = emps[2].EmpNum * 10;

        }
    }
}
