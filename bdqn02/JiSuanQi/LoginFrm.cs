using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JiSuanQi.service;

namespace JiSuanQi
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btn_loginaction_Click(object sender, EventArgs e)
        {
            //获得参数
            string userName = tx_username.Text;
            string passWord = tx_password.Text;
            //调用业务类
            UsersService us = new UsersService();
            bool succ = us.IsLogin(userName,passWord);
            if (succ)
            {
                MessageBox.Show("登陆成功！");
            }
            else
            {
                MessageBox.Show("登陆失败！");
            }
        }
    }
}
