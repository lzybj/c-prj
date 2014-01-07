using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using mis.service;
using mis.entity;

namespace mis
{
    public partial class UpEmp : Form
    {
        private Emp emp = null;
        private List<Emp> data = null;
        private Form1 frm = null;
        public UpEmp(Emp emp,List<Emp> data,Form1 frm)
        {
            this.emp = emp;
            this.data = data;
            this.frm = frm;
            InitializeComponent();
        }

        private void UpEmp_Load(object sender, EventArgs e)
        {
            tx_empcode.Text = emp.EmpCode;
            tx_empname.Text = emp.EmpName;
        }

        private void btn_upemp_Click(object sender, EventArgs e)
        {
            //1.获取修改的内容，并生成EMP对象
            //2.调用业务逻辑
            //3.调用FORM1中更新GRIDVIEW方法
            //4.关闭
            string empcode = tx_empcode.Text;
            string empname = tx_empname.Text;
            Emp empx = new Emp(empcode,empname);
            EmpSerivce es = new EmpSerivce();
            es.UpdataEmp(data,empx);
            frm.UpdataGridView(data);
            this.Close();
        }
    }
}
