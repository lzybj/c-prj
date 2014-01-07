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
    public partial class Form1 : Form
    {
        Emp[] emps = new Emp[3];
        public Form1()
        {
            InitializeComponent();
            this.init();
        }
        public void init()
        {
            //清空LISTVIEW中的所有数据
            lv_content.Items.Clear();
            for (int i = 0; i < emps.Count(); i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = emps[i].EmpCode;
                lvi.SubItems.Add(emps[i].EmpName);
                lvi.SubItems.Add(emps[i].EmpAge.ToString());
                lvi.SubItems.Add(emps[i].EmpTotal.ToString());
                lvi.SubItems.Add(emps[i].EmpContent);
                lv_content.Items.Add(lvi);
            }
 
        }

        public void init2()
        {
            lv_content.Items.Clear();
            for (int i = 0; i < emps.Count(); i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = emps[i].EmpCode;
                lvi.SubItems.Add(emps[i].EmpName);
                lvi.SubItems.Add(emps[i].EmpAge.ToString());
                lvi.SubItems.Add(emps[i].EmpTotal.ToString());
                lvi.SubItems.Add(emps[i].EmpContent);
                lv_content.Items.Add(lvi);
            }
        }

        //更新员工对象数组
        public void updateEmp(Emp parEmp)
        {
            foreach (Emp myEmp in emps)
            {
                if (myEmp.EmpCode.Equals(parEmp.EmpCode))
                {
                    myEmp.EmpContent = parEmp.EmpContent;
                    myEmp.EmpTotal = parEmp.EmpTotal;
                    break;
                }
            }
            //更新LISTVIEW组件中的元素
            this.init2();
        }


        private void lv_content_DoubleClick(object sender, EventArgs e)
        {
            foreach (Emp emp in emps)
            {
                if (emp.EmpCode.Equals(lv_content.SelectedItems[0].Text))
                {
                    Details myDetail = new Details(emp);
                    myDetail.Frm1 = this;
                    myDetail.Show();
                }
            }
        }
    }
}
