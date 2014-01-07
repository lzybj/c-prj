using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bdqn10;

namespace wfpptv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.InitTree();
        }

        public void InitTree()
        {
            TreeNode tn = new TreeNode("我的电视台");
            this.treeView1.Nodes.Add(tn);
            tn.ImageIndex = 0;
            TreeNode tn2 = new TreeNode("所有电视台");
            this.treeView1.Nodes.Add(tn2);
            TVManager tvmanager = new TVManager();
            List<TV> tvs = tvmanager.FindByAllTV();
            foreach (TV item in tvs)
            {
                TreeNode temptn = new TreeNode(item.TvName);
                temptn.Tag = item;
                this.treeView1.Nodes[1].Nodes.Add(temptn);
            }
            this.treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level != 0)
            {
                TV mytv = (TV)e.Node.Tag;
                if (mytv.JieMus != null)
                {
                    mytv.JieMus.Clear();
                }
                mytv.GetJieMuData();
                List<JieMu> jieMus = mytv.JieMus;
                //MessageBox.Show("" + jieMus.Count);
                BindingList<JieMu> bl = new BindingList<JieMu>(jieMus);
                this.dataGridView1.DataSource = bl;
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;
            if (node != null && e.Node.Level != 0)
            {
                if (e.Node.Parent.Text.Equals("我的电视台"))
                {
                    this.contextMenuStrip1.Items[0].Visible = false;
                    this.contextMenuStrip1.Items[1].Visible = true;
                }
                if (e.Node.Parent.Text.Equals("所有电视台"))
                {
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

        private void ShouCangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;
            this.treeView1.Nodes[0].Nodes.Add((TreeNode)node.Clone());
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.treeView1.SelectedNode.Remove();
        }
    }
}
