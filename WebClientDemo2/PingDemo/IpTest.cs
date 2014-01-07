using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace PingDemo
{
    public partial class IpTest : Form
    {
        public IpTest()
        {
            InitializeComponent();
        }

        private void testip_Click(object sender, EventArgs e)
        {
            Ping myPing = new Ping();
            string inputIp = ipaddress.Text.ToString();
            PingReply pr = myPing.Send(inputIp);
            if (pr.Status == IPStatus.Success)
            {
                string message = string.Format("测试，{0}ip成功发送！", inputIp);
                MessageBox.Show(message);
            }
            else
            {
                string message = string.Format("测试，{0}ip失败发送！", inputIp);
                MessageBox.Show(message);
            }
        }
    }
}
