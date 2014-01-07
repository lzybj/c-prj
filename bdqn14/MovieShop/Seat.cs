using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieShop
{
    public class Seat
    {
        public Seat(string seatNum, bool isOK)
        {
            this.SeatNum = seatNum;
            this.isOK = isOK;
        }

        /// <summary>
        /// 座位号
        /// </summary>
        private string seatNum;
        public string SeatNum
        {
            get { return seatNum; }
            set { seatNum = value; }
        }

        /// <summary>
        /// 显示售出与否的颜色属性
        /// </summary>
        private bool isOK;
        public bool IsOK
        {
            get { return isOK; }
            set { isOK = value; }
        }
    }
}
