using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using bdqn10;

namespace pplive
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            this.InitTreeView();
        }

        public void InitTreeView()
        {
            //创建我的电视台以及所有电视台节点
            TreeNode tn = new TreeNode("我的电视台");
            TreeNode tn2 = new TreeNode("所有电视台");
            //挂根节点
            this.treeView1.Nodes.Add(tn);
            this.treeView1.Nodes.Add(tn2);

            this.getSaves();

            //调用业务逻辑

            TVManager tvm = new TVManager();

            List<TV> tvs = tvm.FindByAllTV();

            foreach (TV item in tvs)
            {
                TreeNode mytvnode = new TreeNode();
                mytvnode.Text = item.TvName;
                mytvnode.Tag = item;
                this.treeView1.Nodes[1].Nodes.Add(mytvnode);
            }

            this.treeView1.ExpandAll();

        }

        private void getSaves()
        {
            List<TV> saves = new List<TV>();
            if (File.Exists("../../save.txt"))
            {
                try
                {
                    FileStream fs = new FileStream("../../save.txt",FileMode.Open);
                    StreamReader sr = new StreamReader(fs,Encoding.Default);
                    while (!sr.EndOfStream)
                    {
                        string[] arr = sr.ReadLine().Split('|');
                        TV mytv = TVFactory.getInstances(arr[1]);
                        mytv.TvType = arr[0];
                        mytv.TvName = arr[1];
                        mytv.JieMusURL = arr[2];
                        saves.Add(mytv);

                    }
                    sr.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                foreach (TV item in saves)
                {
                    TreeNode mytvnode = new TreeNode();
                    mytvnode.Text = item.TvName;
                    mytvnode.Tag = item;
                    this.treeView1.Nodes[0].Nodes.Add(mytvnode);
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.IsShowDataGrid(true);
            TreeNode mysel = this.treeView1.SelectedNode;
            if (e.Node.Level != 0)
            {
                TV mytv = (TV)mysel.Tag;
                if (mytv.JieMus.Count != 0)
                {
                    mytv.JieMus.Clear();
                }

                mytv.GetJieMuData();
                List<JieMu> jieMus = mytv.JieMus;
                BindingList<JieMu> bl = new BindingList<JieMu>(jieMus);
                this.dataGridView1.DataSource = bl;
                this.dataGridView1.Tag = mysel.Text;
            }
        }

        private void ShouCangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode mysel = this.treeView1.SelectedNode;

            TreeNode cloneTN = mysel.Clone() as TreeNode;

            this.treeView1.Nodes[0].Nodes.Add(cloneTN);

        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.treeView1.SelectedNode.Remove();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode mysel = this.treeView1.SelectedNode;
            int nodeLevel = e.Node.Level;

            if (mysel != null && nodeLevel != 0)
            {
                if (e.Node.Parent.Text.Equals("我的电视台"))
                {
                    this.contextMenuStrip1.Items[0].Visible = false;
                    this.contextMenuStrip1.Items[1].Visible = true;

                }

                if(e.Node.Parent.Text.Equals("所有电视台")){
                    this.contextMenuStrip1.Items[0].Visible = true;
                    this.contextMenuStrip1.Items[1].Visible = false;

                }
            }
            else
            {
                this.contextMenuStrip1.Items[0].Visible = false;
                this.contextMenuStrip1.Items[1].Visible = false;
            }
        }

        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
             TreeNodeCollection tns = this.treeView1.Nodes[0].Nodes;

             List<TV> saves = new List<TV>();
             foreach (TreeNode item in tns)
             {
                 TV myTv = item.Tag as TV;
                 saves.Add(myTv);
             }

             try
             {
                 FileStream fs = new FileStream("../../save.txt", FileMode.Create);
                 StreamWriter sw = new StreamWriter(fs,Encoding.Default);
                 foreach (TV item in saves)
                 {
                     sw.WriteLine(item.TvType + "|" + item.TvName + "|" + item.JieMusURL);
                 }
                 sw.Close();
                 fs.Close();

             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

             
        }
        private void IsShowDataGrid(bool visable)
        {
            this.dataGridView1.Visible = visable;
            this.dataGridView2.Visible = !visable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.IsShowDataGrid(false);
            FileStream fs = new FileStream("../../remind.bin",FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            RemindData rd = (RemindData)bf.Deserialize(fs);
            fs.Close();
            BindingList<Remind> bl = new BindingList<Remind>(rd.Data);
            this.dataGridView2.DataSource = bl;

        }

        private void 到时提醒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow == null)
            {
                return;
            }

            string tvName = this.dataGridView1.Tag.ToString();
            string jieMuName = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DateTime jieMuTime = DateTime.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int remind = 0;

            Remind my = new Remind(tvName,jieMuName,jieMuTime,remind);

            if (File.Exists("../../remind.bin"))
            {
                FileStream fs = new FileStream("../../remind.bin",FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                RemindData rd = (RemindData)bf.Deserialize(fs);
                rd.Data.Add(my);
                fs.Close();
                FileStream fs2 = new FileStream("../../remind.bin",FileMode.Create);
                BinaryFormatter bf2 = new BinaryFormatter();
                bf2.Serialize(fs2,rd);
                fs2.Close();
            }
            else
            {
                FileStream fs = new FileStream("../../remind.bin",FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                RemindData rd = new RemindData();
                rd.Data.Add(my);
                bf.Serialize(fs,rd);
                fs.Close();
            }




        }

    }
}
