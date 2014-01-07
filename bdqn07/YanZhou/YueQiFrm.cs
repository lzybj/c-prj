using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YanZhou
{
    public partial class YueQiFrm : Form
    {
        private Emp emp;
        public YueQiFrm(Emp emp)
        {
            this.emp = emp;
            InitializeComponent();
        }

        private void btn_yzaction_Click(object sender, EventArgs e)
        {
            YueQi myYueQi = null;
            if (this.radio_gq.Checked)
            {
                myYueQi = new GQ();
            }
            if (this.radio_sks.Checked)
            {
                myYueQi = new SKS();
            }
            if (this.radio_xtq.Checked)
            {
                myYueQi = new XTQ();
            }
            string msg = this.emp.Play(myYueQi);
            MessageBox.Show(msg);
        }
    }
}
