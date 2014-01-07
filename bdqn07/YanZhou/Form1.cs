using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace YanZhou
{
    public partial class Form1 : Form
    {
        private List<Emp> emps = new List<Emp>();
        public Form1()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            Emp emp1 = new Emp("001","王小苗",100);
            Emp emp2 = new Emp("002", "王小小", 100);
            Emp emp3 = new Emp("003", "王新月", 100);
            emps.Add(emp1);
            emps.Add(emp2);
            emps.Add(emp3);
            this.bindDataGird(emps);
        }
        public void bindDataGird(List<Emp> data)
        {
            BindingList<Emp> bl = new BindingList<Emp>(data);
            this.dataGridView1.DataSource = bl;
        }

        private void YanZouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /**
             * 1.获得用户选择的员工工号
             * 2.根据获得员工工号在员工集合中找到对应对象
             * 3.将员工对象传递给演奏窗体对象
             * 4.显示演奏窗体对象
             */
            if (this.dataGridView1.CurrentRow == null)
            {
                return;
            }
            string empCode = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Emp mySel = null;
            foreach (Emp item in emps)
            {
                if (item.EmpCode.Equals(empCode))
                {
                    mySel = item;
                }
            }
            YueQiFrm yueqifrm = new YueQiFrm(mySel);
            yueqifrm.Show();
        }
    }
}
