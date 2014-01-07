using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using bdqn05.entity;

namespace bdqn05
{
    public partial class Form1 : Form
    {
        private List<TC> tcs = new List<TC>();//套餐集合
        private List<CheckItem> citems = new List<CheckItem>();//全部检查项目的集合

        public Form1()
        {
            InitializeComponent();
            this.InitData();
        }
        /// <summary>
        /// 初始化所有数据
        /// </summary>
        private void InitData()
        {
            CheckItem ck1 = new CheckItem("身高","检查身高",5);
            CheckItem ck2 = new CheckItem("体重", "检查体重", 10);
            CheckItem ck3 = new CheckItem("视力", "检查视力", 15);
            CheckItem ck4 = new CheckItem("听力", "检查听力", 50);
            CheckItem ck5 = new CheckItem("肝功能", "检查肝功能", 25);
            CheckItem ck6 = new CheckItem("B超", "检查B超", 35);
            CheckItem ck7 = new CheckItem("血压", "检查心血压", 45);
            CheckItem ck8 = new CheckItem("血常规", "检查血常规", 55);
            CheckItem ck9 = new CheckItem("心电图", "检查心电图", 45);
            citems.Add(ck1);
            citems.Add(ck2);
            citems.Add(ck3);
            citems.Add(ck4);
            citems.Add(ck5);
            citems.Add(ck6);
            citems.Add(ck7);
            citems.Add(ck8);
            citems.Add(ck9);

            /***初始化套餐代码开始****/
            TC tc = new TC();
            tc.TcName = "入学体检";

            List<CheckItem> ruXueTc = new List<CheckItem>();
            ruXueTc.Add(ck1);
            ruXueTc.Add(ck2);
            ruXueTc.Add(ck3);
            tc.CkItems = ruXueTc;
            /***********结束****************/
            tcs.Add(tc);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_jianchalist.Items.Add("请选择");
            foreach (CheckItem item in citems)
            {
                cb_jianchalist.Items.Add(item);
            }
            cb_jianchalist.SelectedIndex = 0;
            cb_jianchalist.DisplayMember = "ckName";
            cb_jianchalist.ValueMember = "ckName";
            /**以下开始绑定套餐数据***/

            cb_tclist.Items.Add("请选择");
            foreach (TC tc in tcs)
            {
                cb_tclist.Items.Add(tc.TcName);
            }
            cb_tclist.SelectedIndex = 0;

            //初始化时，不允许用户点击“添加”，“删除”检查项目

            this.btn_addjiancha.Enabled = false;
            this.btn_removejiancha.Enabled = false;
            
        }

        private void cb_tclist_SelectedIndexChanged(object sender, EventArgs e)
        {

            string tcName = cb_tclist.Text.ToString();
            if (tcName.Equals("请选择"))
            {
                this.btn_addjiancha.Enabled = false;
                this.btn_removejiancha.Enabled = false;
                return;
            }
            else
            {
                string jcName = this.cb_jianchalist.Text.ToString();
                if (jcName.Equals("请选择"))
                {
                    this.btn_addjiancha.Enabled = false;
                }
                else
                {
                    this.btn_addjiancha.Enabled = true;
                }
                this.btn_removejiancha.Enabled = true;
            }


            /**根据选择套餐名，在套餐集合中(tcs),找到对应套餐，获得套餐对象相关属性**/
            foreach (TC tc in tcs)
            {
                if (tc.TcName.Equals(tcName))
                {
                    label5.Text = tc.TcName;
                    label7.Text = tc.TcPrice.ToString();
                    this.BindDataGrid(tc.CkItems);
                    break;
                }
            }
            
        }
        private void BindDataGrid(List<CheckItem> data)
        {
            BindingList<CheckItem> bl = new BindingList<CheckItem>(data);
            this.dataGridView1.DataSource = bl;
        }

        private void btn_addjiancha_Click(object sender, EventArgs e)
        {
            /**
             * 1.获取用户选择的套餐名称
             * 2.获取用户选择的新添加的检查项目名称
             * 3.遍历套餐集合，从套餐集合中找到套餐名是用户选择的套餐名的套餐对象
             * 4.遍历检查项目集合，从检查项目集合中找到对应检查项目对象
             * 5.将套餐对象中检查项目集合属性添加一个检查项目对象
             * 6.重新计算价格，赋值给控件
             * 7.重新绑定DataGridView
             */
            string tcName = this.cb_tclist.Text.ToString();
            string jcName = this.cb_jianchalist.Text.ToString();
            CheckItem mySelectCKItem = null;//用户选择的检查项目对象
            foreach (CheckItem item in citems)
            {
                if (item.CkName.Equals(jcName))
                {
                    mySelectCKItem = item;
                }
            }
            TC mySelectTC = null;//用户选择的套餐对象
            foreach (TC item in tcs)
            {
                if (item.TcName.Equals(tcName))
                {
                    mySelectTC = item;
                }
            }
            bool isSucc = true;
            //判断现有套餐中是否含有用户添加的套餐

            foreach (CheckItem item in mySelectTC.CkItems)
            {
                if (item.CkName.Equals(jcName))
                {
                    isSucc = false;
                    break;
                }
            }
            if (isSucc)
            {
                mySelectTC.CkItems.Add(mySelectCKItem);
                label7.Text = mySelectTC.TcPrice.ToString();
                this.BindDataGrid(mySelectTC.CkItems);
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("对不起，该检查项目已存在！");
            }


        }

        private void cb_jianchalist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jcName = this.cb_jianchalist.Text.ToString();
            if (jcName.Equals("请选择"))
            {
                this.btn_addjiancha.Enabled = false;
            }
            else
            {
                this.btn_addjiancha.Enabled = true;
            }
        }

        private void btn_removejiancha_Click(object sender, EventArgs e)
        {
            /**
             * 1.获得用户要删除的行数据（检查项目名）
             * 2.获得用户要删除套餐名称
             * 3.遍历集合获得要删除的套餐对象
             * 4.删除套餐对象中检查项目集合的一个元素
             * 5.更新价格
             * 6.重新绑定DataGridView
             */
            if (this.dataGridView1.CurrentRow == null)
            {
                return;
            }
            string jcName = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string tcName = this.cb_tclist.Text.ToString();
            TC mySelectTC = null;
            foreach (TC item in tcs)
            {
                if (item.TcName.Equals(tcName))
                {
                    mySelectTC = item;
                }
            }

            foreach (CheckItem item in mySelectTC.CkItems)
            {
                if (item.CkName.Equals(jcName))
                {
                    mySelectTC.CkItems.Remove(item);
                    break;
                }
            }
            label7.Text = mySelectTC.TcPrice.ToString();
            this.BindDataGrid(mySelectTC.CkItems);

        }

        private void btn_addtc_Click(object sender, EventArgs e)
        {
            /**
             * 1.获得用户要添加的套餐名字
             * 2.生成套餐对象
             * 3.将套餐对象添加到套餐集合中
             * 4.将新的套餐名绑定到套餐列表组件中
             */
            string tcName = tx_tcname.Text.ToString();
            //判断用户新创建的套餐是否在原套餐列表中存在
            bool isNotExists = true;

            foreach (TC item in tcs)
            {
                if (item.TcName.Equals(tcName))
                {
                    isNotExists = false;
                }
            }

            if (isNotExists)
            {
                TC newTc = new TC();
                newTc.TcName = tcName;
                tcs.Add(newTc);
                this.cb_tclist.Items.Add(newTc.TcName);
                MessageBox.Show("创建成功！");
            }
            else
            {
                MessageBox.Show("对不起，该套餐已存在");
            }
        }
    }
}
