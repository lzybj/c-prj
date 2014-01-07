using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using bdqn06test.entity;

namespace bdqn06test
{
    public partial class Form1 : Form
    {
        private List<BankCard> data = new List<BankCard>();
        BankCard selBankCard = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化虚拟银行卡数据库
            BankCard card1 = new BenBankCard();
            //本行卡以10开头，非本行不以10开头
            card1.Cardid = "1001";
            card1.Cardpwd = "qaz123";
            card1.CardAcc = "老郑";
            card1.YMoney = 10000;
            BankCard card2 = new BenBankCard();
            //本行卡以10开头，非本行不以10开头
            card2.Cardid = "1002";
            card2.Cardpwd = "qaz345";
            card2.CardAcc = "老李";
            card2.YMoney = 100;
            BankCard card3 = new BenBankCard();
            //本行卡以10开头，非本行不以10开头
            card3.Cardid = "1003";
            card3.Cardpwd = "q12123";
            card3.CardAcc = "老王";
            card3.YMoney = 1000;

            BankCard card4 = new OtherBankCard();
            card4.Cardid = "2001";
            card4.Cardpwd = "111111";
            card4.CardAcc = "小岳";
            card4.YMoney = 1100;

            BankCard card5 = new OtherBankCard();
            card5.Cardid = "2002";
            card5.Cardpwd = "222222";
            card5.CardAcc = "小赵";
            card5.YMoney = 1200;

            data.Add(card1);
            data.Add(card2);
            data.Add(card3);
            data.Add(card4);
            data.Add(card5);

            //未插卡时，查询，取款，转账全部不可用
            cxye_action.Enabled = false;
            qukuan_action.Enabled = false;
            btn_zhuanzhang.Enabled = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            /**
             * 1.获得用户输入的卡号和密码
             * 2.到虚拟银行卡虚拟数据库中查询对应是否账号(list)
             * 3.如果成功，则获得银行卡对象
             * 4.填写详细信息
             * 5.判断是否是本行或非本行卡，将查询，取款，转账相关按钮可用
             * 6.插卡按钮不可用
             */
            string cardid = tx_logincard.Text;
            string cardpwd = tx_loginpwd.Text;
            foreach (BankCard item in data)
            {
                if (item.Cardid.Equals(cardid) && item.Cardpwd.Equals(cardpwd))
                {
                    selBankCard = item;
                }
            }
            if (selBankCard == null)
            {
                MessageBox.Show("对不起，卡号或密码错误！");
                return;
            }
            label7.Text = cardid;
            label8.Text = selBankCard.CardAcc;
            cxye_action.Enabled = true;
            qukuan_action.Enabled = true;
            if (selBankCard is BenBankCard)
            {
                btn_zhuanzhang.Enabled = true;
            }
            btn_login.Enabled = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            /**
             * 1.将插卡置为可用，查询，取款，转账，退卡未不可用
             */
            btn_login.Enabled = true;
            cxye_action.Enabled = false;
            qukuan_action.Enabled = false;
            btn_zhuanzhang.Enabled = false;
            label11.Text = "";
            tb_qukuan.Text = "";
            tx_zzje.Text = "";
            tb_zhanghao.Text = "";
            label7.Text = "";
            label8.Text = "";
            tx_logincard.Text = "";
            tx_loginpwd.Text = "";
            
        }

        private void btn_exiton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cxye_action_Click(object sender, EventArgs e)
        {
              float yuEr = selBankCard.QuEr();
              label11.Text = yuEr.ToString();
              selBankCard.YMoney = yuEr;

        }

        private void qukuan_action_Click(object sender, EventArgs e)
        {
            /**
             * 1.获得用户要取款的金额
             * 2.判断用户余额是否充足
             * 3.显示取款成功
             */
            float jinEr = float.Parse(tb_qukuan.Text);
            if (selBankCard.YMoney < jinEr)
            {
                MessageBox.Show("对不起，余额不足！");
                return;
            }
            float yuEr = selBankCard.QuKuan(jinEr);
            label11.Text = yuEr.ToString();
            selBankCard.YMoney = yuEr;
            MessageBox.Show("取款成功！");
        }

        private void btn_zhuanzhang_Click(object sender, EventArgs e)
        {
            /**
             * 1.获得要转账的账号和转账金额
             * 2.判断目标账号是否存在
             * 3.如果存在获得目标账号对象
             * 4.转账
             * 5.判断是否成功，显示提示
             */
            string zhanghao = tb_zhanghao.Text;
            float jinEr = float.Parse(tx_zzje.Text);
            BankCard mubiao = null;
            foreach (BankCard item in data)
            {
                if (item.Cardid.Equals(zhanghao))
                {
                    mubiao = item;
                    break;
                }
            }
            if (mubiao == null)
            {
                MessageBox.Show("对不起，账号不存在！");
            }
            bool isSucc = (selBankCard as BenBankCard).ZhuanZhang(mubiao, jinEr);
            if (isSucc)
            {
                MessageBox.Show("转账成功！");
            }
            else
            {
                MessageBox.Show("转账失败！");
            }
        }
    }
}
