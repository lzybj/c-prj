using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using mis.entity;

namespace mis
{
    public partial class DaKaFrm : Form
    {
        private Dictionary<string, DaKa> daKaData = null;
        public DaKaFrm(Dictionary<string,DaKa> daKaData)
        {
            this.daKaData = daKaData;
            InitializeComponent();
        }

        private void DaKaFrm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            BindingSource bs = new BindingSource();
            bs.DataSource = this.daKaData.Values;
            this.dataGridView1.DataSource = bs;
            
        }
    }
}
