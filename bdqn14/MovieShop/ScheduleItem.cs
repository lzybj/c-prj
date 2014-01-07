using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieShop
{
    public class ScheduleItem
    {
        public ScheduleItem()
        {
            movie = new Movie();
        }
        /// <summary>
        /// 放映时间
        /// </summary>
        private string time;
        public string Time
        {
            get { return time; }
            set { time = value; }
        }
        /// <summary>
        /// 要放映的电影对象
        /// </summary>
        private Movie movie;
        public Movie Movie
        {
            get { return movie; }
            set { movie = value; }
        }
    }
}
