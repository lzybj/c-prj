using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bdqn08
{
    public class MP3
    {
        private string mp3Name;

        public string Mp3Name
        {
            get { return mp3Name; }
            set { mp3Name = value; }
        }
        private string mp3GeShou;

        public string Mp3GeShou
        {
            get { return mp3GeShou; }
            set { mp3GeShou = value; }
        }
        private string mp3URL;

        public string Mp3URL
        {
            get { return mp3URL; }
            set { mp3URL = value; }
        }

        public MP3(string mp3Name,string mp3GeShou,string mp3URL)
        {
            this.mp3Name = mp3Name;
            this.mp3GeShou = mp3GeShou;
            this.mp3URL = mp3URL;
        }

    }
}
