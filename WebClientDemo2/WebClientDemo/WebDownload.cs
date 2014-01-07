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

namespace WebClientDemo
{
    public partial class WebDownload : Form
    {
        public WebDownload()
        {
            InitializeComponent();
        }

        private void downloadbutton_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            if (!File.Exists("baidulog.jpg"))
            {
                wc.DownloadFile("http://192.168.1.116:8080/tomcat.gif","baidulog.jpg");
            }
            pictureshow.Image = Image.FromFile("baidulog.jpg");
        }
    }
}
