using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bdqn03.entity;
using bdqn03.service;

namespace bdqn03
{
    public partial class AddEmpFrm : Form
    {
        private List<Emp> data = null;
        private Form1 frm = null;
        public AddEmpFrm(Form1 frm,List<Emp> data)
        {
            this.frm = frm;
            this.data = data;
            InitializeComponent();
        }

        private void btn_addempaction_Click(object sender, EventArgs e)
        {
            string empcode = tx_empcode.Text;
            string empname = tx_empname.Text;
            string empsex = tx_empsex.Text;
            int empage = int.Parse(tx_empage.Text);
            EmpSerivce es = new EmpSerivce();
            es.AddEmp(data,new Emp(empcode,empname,empsex,empage));
            frm.BindingDataGrid(data);
            this.Close();
        }
    }
}
