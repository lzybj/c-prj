using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MovieShop
{
    public class Schedule
    {
        public Schedule()
        {
            items = new Dictionary<string, ScheduleItem>();
            this.Load();
        }
        /// <summary>
        /// 放映计划中的放映列表
        /// </summary>
        private Dictionary<string, ScheduleItem> items;
        /// <summary>
        /// 放映计划中的放映列表
        /// </summary>
        public Dictionary<string, ScheduleItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        /// <summary>
        /// 解析当天的播放计划
        /// </summary>
        private void Load()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../ShowList.xml");
            XmlNodeList movies = doc.GetElementsByTagName("Movie");
            foreach (XmlNode node in movies)
            {
                string movieName = node["Name"].InnerText;
                string moviePoster = "../../image/" + node["Poster"].InnerText;
                string director = node["Director"].InnerText;
                string actor = node["Actor"].InnerText;
                string movieType = node["Type"].InnerText;
                int moivePrice = int.Parse(node["Price"].InnerText);
                XmlNodeList sitem =  node["Schedule"].ChildNodes;
                foreach (XmlNode ssitem in sitem)
                {
                    Movie myMovie = new Movie();
                    myMovie.MovieName = movieName;
                    myMovie.Poster = moviePoster;
                    myMovie.Director = director;
                    myMovie.Actor = actor;
                    myMovie.MovieType = movieType;
                    myMovie.Price = moivePrice;
                    ScheduleItem scheduleItem = new ScheduleItem();
                    scheduleItem.Movie = myMovie;
                    scheduleItem.Time = ssitem.InnerText;
                    items.Add(ssitem.InnerText, scheduleItem);
                }
            }
        }
    }
}
