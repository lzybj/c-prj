using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pplive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.InitTreeView();
        }

        public void InitTreeView()
        {
            /**
             * 1.创建四个节点对象
             * 2.将其中娱乐，电影两个节点设为根节点
             * 3.将另外两个节点（动作，爱情），添加到电影根节点上
             */
            TreeNode yule = new TreeNode("娱乐");
            TreeNode dianying = new TreeNode("电影");
            TreeNode dongzuo = new TreeNode("动作");
            TreeNode aiqing = new TreeNode("爱情");
            this.treeView1.Nodes.Add(yule);
            this.treeView1.Nodes.Add(dianying);
            this.treeView1.Nodes[1].Nodes.Add(dongzuo);
            this.treeView1.Nodes[1].Nodes.Add(aiqing);
            this.treeView1.ExpandAll(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**
             *1.获得节点名称
             *2.创建一个节点类
             *3.将此节点添加到节点树上
             */
            string nodestr = tx_node.Text;
            TreeNode tn = new TreeNode();
            tn.Text = nodestr;

            this.treeView1.Nodes.Add(tn);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /**
             *1.获得节点名称
             *2.创建一个节点类
             *3.获得一个选择节点对象
             *4.将新添加的节点添加到选择节点对象上
             */
            string nodestr = tx_node.Text;
            TreeNode tn = new TreeNode(nodestr);
            TreeNode mysel = this.treeView1.SelectedNode;
            if (mysel == null)
            {
                MessageBox.Show("请选择一个节点");
                return;
            }
            mysel.Nodes.Add(tn);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.treeView1.SelectedNode.Remove();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nodestr = tx_node.Text;
            TreeNode tn = this.treeView1.SelectedNode;
            tn.Text = nodestr;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TreeNode dianying = this.treeView1.Nodes[1];
            TreeNode second = dianying.Nodes[1];
            MessageBox.Show(second.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /**
             *1.克隆一个二级节点
             *2.将二级节点克隆对象添加到娱乐节点上
             */
            TreeNode mysel = this.treeView1.SelectedNode;
            TreeNode cTn = mysel.Clone() as TreeNode;
            TreeNode tn = this.treeView1.Nodes[0];
            if (tn.Text.Equals("娱乐"))
            {
                tn.Nodes.Add(cTn);
            }
            else
            {
                MessageBox.Show("放错地方了！");
            }
        }

        private void CloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode mysel = this.treeView1.SelectedNode;
            TreeNode cTn = mysel.Clone() as TreeNode;
            TreeNode tn = this.treeView1.Nodes[0];
            tn.Nodes.Add(cTn);
        }

        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.treeView1.SelectedNode.Remove();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(this.treeView1.SelectedNode.Text);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode mysel = this.treeView1.SelectedNode;
            int nodeLevel = e.Node.Level;
            if (mysel != null && nodeLevel != 0)
            {
                if (e.Node.Parent.Text.Equals("娱乐"))
                {
                    this.contextMenuStrip1.Items[0].Visible = false;
                    this.contextMenuStrip1.Items[1].Visible = true;
                }

                if (e.Node.Parent.Text.Equals("电影"))
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
