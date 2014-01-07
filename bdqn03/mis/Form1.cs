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
    public partial class Form1 : Form
    {
        //存员工对象的集合
        List<Emp> data = new List<Emp>();
        //打卡记录的集合
        Dictionary<string, DaKa> daKaData = new Dictionary<string, DaKa>();
        public Form1()
        {
            InitializeComponent();
            this.init();
        }
        public void init()
        {
            //绑定datagridview
            this.dataGridView1.DataSource = new BindingList<Emp>(this.data);
        }
        public void UpdataGridView(List<Emp> newData)
        {
            this.data = newData;
            this.init();
        }

        private void btn_addemp_Click(object sender, EventArgs e)
        {
            AddEmpFrm addFrm = new AddEmpFrm(data,this);
            addFrm.Show();
        }

        private void btn_delemp_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow == null)
            {
                return;
            }
           string empcode = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
           EmpSerivce es = new EmpSerivce();
           es.DelEmp(data,empcode);
           this.init();
        }

        private void btn_upemp_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow == null)
            {
                return;
            }
            string empcode = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string empname = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Emp oldEmp = new Emp(empcode,empname);
            UpEmp upfrm = new UpEmp(oldEmp,data,this);
            upfrm.Show();
        }

        private void btn_cxaction_Click(object sender, EventArgs e)
        {
            //1.获得要查询的条件值
            //2.调用业务逻辑
            //3.获得结果
            //4.更新DATAGRIDVIEW
            string empcode = tx_cxempcode.Text;
            EmpSerivce es = new EmpSerivce();
            List<Emp> myselectdata = es.FindByEmpCode(data,empcode);
            this.UpdataGridView(myselectdata);
        }

        private void empqiandao_Click(object sender, EventArgs e)
        {
            //1.判断是否选择一个员工进行签到
            //2.获得员工相关信息
            //3.调用业务逻辑
            //4.获得结果
            //5.根据结果响应
            if (this.dataGridView1.CurrentRow == null)
            {
                return;
            }
            string empCode = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string empName = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            Emp emp = new Emp(empCode,empName);

            DaKaService ds = new DaKaService();
            bool flag = ds.QianDao(daKaData, emp);

            if (flag)
            {
                MessageBox.Show("签到成功！");
            }
            else
            {
                MessageBox.Show("签到失败！");
            }
            

        }

        private void empqiantui_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow == null)
            {
                return;
            }
            string empCode = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string empName = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

            Emp emp = new Emp(empCode,empName);

            DaKaService ds = new DaKaService();

            bool flag = ds.QianTui(daKaData, emp);

            if (flag)
            {
                MessageBox.Show("签退成功！");
            }
            else
            {
                MessageBox.Show("还未签到，签退失败！");
            }

        }

        private void btn_views_Click(object sender, EventArgs e)
        {
            DaKaFrm dakafrm = new DaKaFrm(this.daKaData);
            dakafrm.Show();
        }
    }
}
