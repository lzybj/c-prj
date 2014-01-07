using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace bdqn08
{
    public partial class PlayFrm : Form
    {
        private static PlayFrm player = null;
        private PlayFrm()
        {
            InitializeComponent();
        }
        public static PlayFrm getPlayFrm()
        {
            if (player == null)
            {
                player = new PlayFrm();
                return player;
            }
            return player;
        }
        public bool playerOK(string url)
        {
            if (!File.Exists(url))
            {
                return false;
            }
            this.wmp.URL = url;
            return true;
        }


    }
}
