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
    public partial class MusicMainFrm : Form
    {
        List<MP3> data = new List<MP3>();
        public MusicMainFrm()
        {
            InitializeComponent();
            this.Init();
        }

        private void Init()
        {
            MP3 mp31 = new MP3("给你们","张宇","c:/给你们.mp3");
            MP3 mp32 = new MP3("世界唯一的你","萧敬腾","c:/世界唯一的你.mp3");
            data.Add(mp31);
            data.Add(mp32);
            this.bindDataGrid(data);
        }
        private void bindDataGrid(List<MP3> data){
            BindingList<MP3> bl = new BindingList<MP3>(data);
            this.dataGridView1.DataSource = bl;
        }

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /**
             * 1.获得用户选择的歌曲地址
             * 2.获得播放窗体的实例
             * 3.调用playerOK()方法获得结果
             * 4.显示播放窗体
             */
            if (this.dataGridView1.CurrentRow == null)
            {
                return;
            }
            string url = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            PlayFrm player = PlayFrm.getPlayFrm();
            bool isOK = player.playerOK(url);
            if (isOK)
            {
                player.Show();
            }
            else
            {
                MessageBox.Show("对不起，该文件不存在！");
            }
        }

    }
}
