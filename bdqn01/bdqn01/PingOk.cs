using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace bdqn01
{
    public partial class PingOk : Form
    {
        public PingOk()
        {
            InitializeComponent();
        }

        private void btn_ping_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            string mypingstr = ipstr.Text.Trim();
            PingReply pingRep = ping.Send(mypingstr);
            if (pingRep.Status == IPStatus.Success)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("不通！");
            }
        }
    }
}
