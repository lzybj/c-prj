using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using bdqn03.entity;
using bdqn03.service;

namespace bdqn03
{
    public partial class Form1 : Form
    {
        private List<Emp> data = new List<Emp>();
        public Form1()
        {
            InitializeComponent();
        }
        public void BindingDataGrid(List<Emp> data)
        {
            this.data = data;
            this.dg_allemps.DataSource = new BindingList<Emp>(this.data);
        }
        private void btn_addemp_Click(object sender, EventArgs e)
        {
            AddEmpFrm addfrm = new AddEmpFrm(this,data);
            addfrm.Show();
        }
    }
}
