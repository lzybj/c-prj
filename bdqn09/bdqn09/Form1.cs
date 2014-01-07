
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bdqn09
{
    public partial class Form1 : Form
    {
        //车库
        private List<Che> data = new List<Che>();
        List<Che> kongXianData = new List<Che>();
        List<Che> notKongXianData = new List<Che>();
        public Form1()
        {
            InitializeComponent();
            this.tx_cload.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                this.tx_cload.Enabled = true;
            }
            else
            {
                this.tx_cload.Enabled = false;
            }
        }

        private void btn_rukuaction_Click(object sender, EventArgs e)
        {
            Che newChe = null;
            string cNo = tx_cno.Text;
            string cName = tx_cname.Text;
            string cColor = tx_ccolor.Text;
            int cDayNum = int.Parse(tx_cdaynum.Text);
            float cUnitPrice = float.Parse(tx_cUnitPrice.Text);
            if (this.radioButton2.Checked)
            {
                int cLoad = int.Parse(tx_cload.Text);
                newChe = new KaChe(cNo,cName,cColor,cDayNum,cUnitPrice,cLoad);
            }
            else
            {
                newChe = new Car(cNo, cName, cColor, cDayNum, cUnitPrice,0);
            }
            data.Add(newChe);
            MessageBox.Show("入库成功！");

        }

        private void btn_getzcaction_Click(object sender, EventArgs e)
        {
            kongXianData.Clear();
            /**
             * 1.获得所有未被出租集合
             * 2.将集合绑定
             */
           

            foreach (Che item in data)
            {
                if (item.CUserName == null || item.CUserName.Equals(""))
                {
                    kongXianData.Add(item);
                }
            }

            BindingList<Che> bl = new BindingList<Che>(kongXianData);
            this.dataGridView1.DataSource = bl;

        }

        private void btn_zucheaction_Click(object sender, EventArgs e)
        {
            /**
             * 1.获得承租人信息
             * 2.将空闲车辆集合中选中车提取出来，并在集合中删除
             * 3.设置提取的车辆承租人属性
             * 4.将该车添加到非空闲车辆集合中
             */
            string cUserName = tx_cUserName.Text;
            string cNo = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Che selChe = null;
            foreach (Che item in kongXianData)
            {
                if (item.CNo.Equals(cNo))
                {
                    selChe = item;
                    kongXianData.Remove(item);
                    break;
                }
            }
            selChe.CUserName = cUserName;
            notKongXianData.Add(selChe);
            MessageBox.Show("成功租车！");  
        }

        private void btn_yczaction_Click(object sender, EventArgs e)
        {
            /**
             * 1.将已被出租集合绑定
             */



            BindingList<Che> bl2 = new BindingList<Che>(notKongXianData);
            this.dataGridView2.DataSource = bl2;
        }

        private void btn_jsaction_Click(object sender, EventArgs e)
        {
            /**
             * 1.获得实际使用天数
             * 2.获得选中车辆对象
             * 3.设置实际使用天数属性
             * 4.调用结算方法
             * 5.显示价格
             */
            int cDayNum2 = int.Parse(tx_cDayNum2.Text);
            string cNo = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Che selChe = null;
            foreach (Che item in notKongXianData)
            {
                if (item.CNo.Equals(cNo))
                {
                    selChe = item;
                    break;
                }
            }
            selChe.CDayNum = cDayNum2;
            float price = selChe.JieSuan();
            MessageBox.Show("您需要支付" + price);

        }
    }
}
