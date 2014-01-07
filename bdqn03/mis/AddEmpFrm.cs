using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using mis.entity;
using mis.service;

namespace mis
{
    public partial class AddEmpFrm : Form
    {
        private List<Emp> jdata = null;
        private Form1 jfrm = null;
        public AddEmpFrm(List<Emp> cdata,Form1 frm)
        {
            this.jdata = cdata;
            this.jfrm = frm;
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //1.获得用户输入的员工编码和员工名
            //2.调用业务逻辑
            //3.调用form1类中更新datagrid方法
            //4.关闭窗体
            string empcode = tx_empcode.Text;
            string empname = tx_empname.Text;
            EmpSerivce es = new EmpSerivce();
            if (es.AddEmp(jdata, new Emp(empcode, empname)))
            {
                jfrm.UpdataGridView(jdata);
                this.Close();
            }
            else
            {
                MessageBox.Show("重了！");
            }
        }
    }
}
