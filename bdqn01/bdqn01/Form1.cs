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


namespace bdqn01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            if (!File.Exists("mypic.jpg"))
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://localhost:8080/e/g.jpg","mypic.jpg");

            }
            imgBox.Image = Image.FromFile("mypic.jpg");
        }
    }
}
