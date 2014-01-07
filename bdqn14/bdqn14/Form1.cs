using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MovieShop;


namespace bdqn14
{
    public partial class Form1 : Form
    {
        private Cinema cinema = new Cinema();
        private string key = "";
        public Form1()
        {
            InitializeComponent();
            this.InitTree(); 
            this.InitSeats();
            this.comboBox1.Enabled = false;
            this.textBox1.Enabled = false;
        }

        public void InitTree()
        {
            Schedule schedule = cinema.Schedule;
            Dictionary<string, ScheduleItem> data = schedule.Items;
            string mname = "";
            //获得根节点
            foreach (string mtime in data.Keys)
            {
                ScheduleItem myItem = data[mtime];
                if (mname.Equals(myItem.Movie.MovieName))
                {
                    continue;
                }
                TreeNode tn = new TreeNode();
                tn.Text = myItem.Movie.MovieName;
                this.treeView1.Nodes.Add(tn);
                mname = myItem.Movie.MovieName;
            }
            //添加根节点上子节点
            for (int i = 0; i < this.treeView1.Nodes.Count; i++)
            {
                foreach (string mtime in data.Keys)
                {
                    ScheduleItem item = data[mtime];
                    if (this.treeView1.Nodes[i].Text.Equals(item.Movie.MovieName))
                    {
                        TreeNode tn = new TreeNode();
                        tn.Text = item.Time;
                        tn.Tag = item.Movie;
                        this.treeView1.Nodes[i].Nodes.Add(tn);
                    }
                }
            }

        }

        /// <summary>
        /// 动态生成lable控件之座位
        /// </summary>
        private void InitSeats()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
            Label myLabel = new Label();
            //将控件大小设置代码设置
            myLabel.AutoSize = false;
            //设置控件大小
            myLabel.Size = new System.Drawing.Size(50,20);//第一参数是宽度，第二参数是高度
            //设置控件位置
            myLabel.Location = new Point(60+(i*90),60+(j*60));
            //设置控件背景颜色
            myLabel.BackColor = Color.Yellow;
            //设置控件显示文本
            string seatNumStr = "" + (j + 1) + "-" + (i + 1);
            myLabel.Text = seatNumStr;
            //绑定控件单击事件
            myLabel.Click += new System.EventHandler(label1_Click);


            //将控件添加到某一个容器中
            this.tabControl1.TabPages[0].Controls.Add(myLabel);
            
            Seat myseat = new Seat(seatNumStr,false);
            cinema.Seats.Add(seatNumStr, myseat);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            /**
             * 1.生成票
             * 2.锁定座位
             * 3.锁定票（即放入已卖出票集合中）
             * 4.打印票
             */
            Ticket myticket = null;
            if (this.radioButton1.Checked)
            {
                myticket = new Ticket();
            }
            if (this.radioButton2.Checked)
            {
                myticket = new FreeTicket();
                ((FreeTicket)myticket).CustomerName = this.textBox1.Text;
            }
            if (this.radioButton3.Checked)
            {
                myticket = new StudentTicket();
                ((StudentTicket)myticket).Discount = float.Parse(this.comboBox1.Text);
            }
            //获得场次
            ScheduleItem myitem = cinema.Schedule.Items[key];
            //获得座位对象
            Label mylabel = sender as Label;
            string seatNum = mylabel.Text;
            Seat myseat = cinema.Seats[seatNum];
            //票相关属性
            myticket.ScheduleItem = myitem;
            myticket.Seat = myseat;
            myticket.Price = myticket.culPrice();

            //锁定座位
            mylabel.BackColor = Color.Red;

            //锁定票

            cinema.SoldTickets.Add(myticket);

            //打印出票

            myticket.printTicket();

            MessageBox.Show("出票成功！");

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level <= 0)
            {
                return;
            }
            TreeNode mysel = this.treeView1.SelectedNode;
            key = mysel.Text;//场次时间
            Movie mymovie = mysel.Tag as Movie;
            label2.Text = mymovie.MovieName;
            this.pictureBox1.Load(mymovie.Poster);
            label9.Text = mymovie.Director;
            label10.Text = mymovie.Actor;
            label11.Text = mymovie.MovieType;
            label12.Text = key;
            label13.Text = mymovie.Price.ToString();
            label4.Text = mymovie.Price.ToString();
            cinema.Seats.Clear();
            this.tabControl1.TabPages[0].Controls.Clear();
            this.InitSeats();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = false;
            this.textBox1.Enabled = false;
            label4.Text = label13.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = false;
            this.textBox1.Enabled = true;
            label4.Text = "0";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = true;
            this.textBox1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string discountStr = this.comboBox1.Text;
            if (discountStr.Equals(""))
            {
                return;
            }
            float discount = float.Parse(discountStr);
            int price = int.Parse(label13.Text);
            label4.Text = (price * discount).ToString();
        }

    }
}
