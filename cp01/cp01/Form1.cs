using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace cp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            if (!File.Exists("dingdang.jpg"))
            {
                wc.DownloadFile("http://localhost:8080/e/g.jpg","dingdang.jpg");
            }
            pictureBox1.Image = Image.FromFile("dingdang.jpg");
        }
    }
}
