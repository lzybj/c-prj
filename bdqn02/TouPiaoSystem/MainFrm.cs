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
    public partial class MainFrm : Form
    {
        private Emp[] emps = new Emp[3];
        public MainFrm()
        {
            InitializeComponent();
            this.CBInit();
        }
        private void CBInit()
        {
            emps[0] = new Emp("1001", "老郑", "男", 33, 0);
            emps[1] = new Emp("1002", "老李", "男", 33, 0);
            emps[2] = new Emp("1003", "老王", "男", 33, 0);
            cb_emps.Items.Add(emps[0]);
            cb_emps.Items.Add(emps[1]);
            cb_emps.Items.Add(emps[2]);
            cb_emps.DisplayMember = "empName";
            cb_emps.ValueMember = "empCode";
            cb_emps.SelectedIndex = 0;
        }

        private void btn_toupiaoaction_Click(object sender, EventArgs e)
        {
            VoteService vs = new VoteService();
            foreach (Emp emp in emps)
            {
                if (emp.EmpName.Equals(cb_emps.Text))
                {
                    vs.vote(emp);
                }
            }
            lb_nownum.Text = (5 - VoteService.ticketNum).ToString();
            lb_synum.Text = VoteService.ticketNum.ToString();
            if (VoteService.ticketNum == 0)
            {
                btn_toupiaoaction.Enabled = false;
            }
        }

        private void btn_viewresaction_Click(object sender, EventArgs e)
        {
            ResFrm res = new ResFrm(emps);
            res.Show();
        }
    }
}
