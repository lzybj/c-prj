using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using bdqn13;

namespace pcshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.InitTreeView();
        }

        private void InitTreeView()
        {
            /**
             * 1.调用业务逻辑获得所有的品牌集合
             * 2.将集合中所有品牌生成节点，并添加到treeview树上
             */
            ComputerService cs = new ComputerService();
            List<string> brands = cs.getBrands();

            foreach (string item in brands)
            {
                TreeNode brand = new TreeNode();
                brand.Text = item;
                this.treeView1.Nodes.Add(brand);
            }
            ////////////////////////////////////////////////////////////
            for (int i = 0; i < brands.Count; i++)
			{
                List<string> computerNames = cs.findByBrand(brands[i]);
                foreach (string item in computerNames)
                {
                    TreeNode computerName = new TreeNode();
                    computerName.Text = item;
                    this.treeView1.Nodes[i].Nodes.Add(computerName);
                }
			}

            this.treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level <= 0)
            {
                return;
            }
            TreeNode mysel = this.treeView1.SelectedNode;
            string computerName = mysel.Text;
            ComputerService cs = new ComputerService();
            Computer myComputer = cs.findByComputerName(computerName);
            if (myComputer is PC)
            {
                PC myPc = (PC)myComputer;
                label1.Text = myPc.CpuType;
                label2.Text = myPc.HardDisk;
                label3.Text = myPc.HostType;
            }
            else
            {
                NoteBook myNoteBook = (NoteBook)myComputer;
                label1.Text = myNoteBook.CpuType;
                label2.Text = myNoteBook.HardDisk;
                label3.Text = myNoteBook.Battery;
            }


        }

    }
}
