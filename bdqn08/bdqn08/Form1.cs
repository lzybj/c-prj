using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bdqn08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_resaction_Click(object sender, EventArgs e)
        {
            int first = int.Parse(tx_first.Text);
            int second = int.Parse(tx_second.Text);
            string stroper = tx_oper.Text;
            Opertion oper = OperationFactory.getInstance(stroper);
            oper.First = first;
            oper.Second = second;
            tx_res.Text = oper.GetRes().ToString();

        }
    }
}
