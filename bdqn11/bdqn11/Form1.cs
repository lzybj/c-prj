using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace bdqn11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**
             *1.获取写入文件的地址
             *2.创建文件流
             *3.创建写入器
             *4.写入
             *5.关闭流
             *6.显示成功！
             */
            string path = tb_path.Text;
            FileStream fs = new FileStream(path,FileMode.Create);
            StreamWriter sw = new StreamWriter(fs,Encoding.Default);
            sw.Write(tx_content.Text);
            sw.Close();
            fs.Close();
            MessageBox.Show("写入成功！");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            tb_path.Text = this.openFileDialog1.FileName;

            if (!tb_path.Text.Equals(""))
            {
                string filePath = tb_path.Text;
                if (filePath.Substring(filePath.LastIndexOf(".")).Equals(".txt"))
                {
                    FileStream fs = new FileStream(tb_path.Text, FileMode.Open);
                    StreamReader sr = new StreamReader(fs, Encoding.Default);
                    tx_content.Text = sr.ReadToEnd();
                    sr.Close();
                    fs.Close();
                }
                else
                {
                    MessageBox.Show("对不起，必须是文本类型！");
                }
            }
            

        }
    }
}
