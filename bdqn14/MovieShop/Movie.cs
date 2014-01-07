using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieShop
{
    public class Movie
    {
        public Movie() { }
        public Movie(string movieName, string poster, string director, string actor, string movieType, int price)
        {
            this.MovieName = movieName;
            this.Poster = poster;
            this.Director = director;
            this.Actor = actor;
            this.MovieType = movieType;
            this.Price = price;
        }

        /// <summary>
        /// 电影名称
        /// </summary>
        private string movieName;
        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }

        /// <summary>
        /// 海报图片名
        /// </summary>
        private string poster;
        public string Poster
        {
            get { return poster; }
            set { poster = value; }
        }

        /// <summary>
        /// 导演名
        /// </summary>
        private string director;
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        /// <summary>
        /// 主演
        /// </summary>
        private string actor;
        public string Actor
        {
            get { return actor; }
            set { actor = value; }
        }

        /// <summary>
        /// 电影类型
        /// </summary>
        private string movieType;
        public string MovieType
        {
            get { return movieType; }
            set { movieType = value; }
        }

        /// <summary>
        /// 电影定价
        /// </summary>
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
