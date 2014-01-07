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
    public partial class ViewMyPcFrm : Form
    {
        public ViewMyPcFrm()
        {
            InitializeComponent();
        }

        private void ViewMyPcFrm_Load(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode();
            tn.Text = "c:\\";
            tn.Tag = "c:\\";
            this.treeView1.Nodes.Add(tn);

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode mysel = this.treeView1.SelectedNode;

            DirectoryInfo dirs = new DirectoryInfo(mysel.Tag.ToString());

            //获得该目录下所有子目录

            DirectoryInfo[] dis =  dirs.GetDirectories();

            foreach (DirectoryInfo item in dis)
            {
                TreeNode temp = new TreeNode();
                temp.Text = item.Name;//目录名
                temp.Tag = item.FullName;//目录全路径

                this.treeView1.SelectedNode.Nodes.Add(temp);
            }

            //获得该目录下的所有子文件

            FileInfo[] fileinfos = dirs.GetFiles();
            //文件集合
            List<MyFile> data = new List<MyFile>();


            foreach (FileInfo item in fileinfos)
            {
                string fileName = item.Name;
                string fileType = item.Extension;//扩展名
                float fileSize = item.Length;
                string filePath = item.FullName;
                MyFile my = new MyFile(fileName,fileType,fileSize,filePath);
                data.Add(my);
            }
            BindingList<MyFile> bl = new BindingList<MyFile>(data);
            this.dataGridView1.DataSource = bl;



        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow == null)
            {
                return;
            }

            //打开选择复制目标地址的对话框

            FolderBrowserDialog fbd = new FolderBrowserDialog(); ;
            DialogResult res = fbd.ShowDialog();
            if (res == DialogResult.OK)
            {
                //获取目标复制地址
                string descPath = fbd.SelectedPath;
                //获得源地址
                string sourcePath = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                //拼接目标地址(目标地址+源文件名)
                descPath = descPath + "\\" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                File.Copy(sourcePath,descPath);

                MessageBox.Show("复制成功！");


            }
        }

        private void BindDataGrid(List<MyFile> data)
        {
            BindingList<MyFile> bl = new BindingList<MyFile>(data);
            this.dataGridView1.DataSource = bl;
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string delPath = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            File.Delete(delPath);
            MessageBox.Show("删除成功！");
            //this.dataGridView1.Refresh();
        }
    }
}
