using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace workdemo
{
    public partial class Form1 : Form
    {
        private Emp emp = new Emp();
        public Form1()
        {
            InitializeComponent();
            this.Init();
            this.label1.Text = emp.EmpName;
        }

        private void Init()
        {
            emp = new Emp();
            emp.EmpName = "老郑";
            List<Job> jobs = new List<Job>();
            Job job1 = new CodeJob("编码","编码工作","登陆",30,1,3);
            Job job2 = new TestJob("测试","测试工作","压力测试",15,5,3);
            Job job3 = new CodeJob("编码2","编码工作","查询",100,3,5);
            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);
            emp.MyJob = jobs;
            this.bindGridView(jobs);
        }
        public void bindGridView(List<Job> jobs)
        {
            BindingList<Job> bl = new BindingList<Job>(jobs);
            this.dataGridView1.DataSource = bl;
        }

        private void ExecWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //1.获得用户选择工作类型
            //2.根据选择工作类型到工作集合中找到工作对象
            //3.调用工作对象中execute()方法
            if (this.dataGridView1.CurrentRow == null)
            {
                return;
            }
            string workType = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string workContent = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            List<Job> myjobs = emp.MyJob;
            Job selJob = null;
            foreach (Job item in myjobs)
            {
                if (item.WorkName.Equals(workType) && item.WorkContent.Equals(workContent))
                {
                    selJob = item;
                }
            }
            if (selJob == null)
            {
                MessageBox.Show("EERRR");
                return;
            }
            selJob.Execute();
        }

        private void ViewWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow == null)
            {
                return;
            }
            string workType = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string workContent = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

            List<Job> myjobs = emp.MyJob;
            Job selJob = null;
            foreach (Job item in myjobs)
            {
                if (item.WorkName.Equals(workType) && item.WorkContent.Equals(workContent))
                {
                    selJob = item;


                }
            }
            if (selJob == null)
            {
                MessageBox.Show("EERRR");
                return;
            }
            MessageBox.Show(selJob.Show());
        }
    }
}
