using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace cp01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ping send = new Ping();
            PingReply pr = send.Send(pingstr.Text.ToString());
            if (pr.Status == IPStatus.Success)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("not ok!");
            }
        }
    }
}
