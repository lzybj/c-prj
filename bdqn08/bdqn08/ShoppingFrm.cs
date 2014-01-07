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
    public partial class ShoppingFrm : Form
    {
        public ShoppingFrm()
        {
            InitializeComponent();
        }

        private void btn_xuangou_Click(object sender, EventArgs e)
        {
            string strname = "";
            if (this.radioButton1.Checked)
            {
                strname = "意大利";
            }
            else
            {
                strname = "法国";
            }
            PiSa myPiSa = PiSaFactory.getInstance(strname);

            MessageBox.Show(myPiSa.Show());

        }
    }
}
