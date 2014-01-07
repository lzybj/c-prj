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
    public partial class FileTestFrm : Form
    {
        public FileTestFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //文件源地址
            string sourcePath = tx_source.Text;
            //目标地址
            string descPath = tx_desc.Text;

            if (!File.Exists(sourcePath))
            {
                MessageBox.Show("对不起，源文件不存在！");
                return;
            }

            File.Copy(sourcePath, descPath);
            MessageBox.Show("复制成功！");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = tx_path.Text;
            if (!File.Exists(filePath))
            {
                MessageBox.Show("对不起，该文件不存在！");
                return;
            }

            File.Delete(filePath);
            MessageBox.Show("删除成功！");
        }
    }
}
