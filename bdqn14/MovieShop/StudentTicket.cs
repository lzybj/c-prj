using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieShop
{
    public class StudentTicket : Ticket
    {
        /// <summary>
        /// 折扣
        /// </summary>
        private float discount;

        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public StudentTicket()
        {
        }

        public StudentTicket(ScheduleItem item,Seat seat,float discount)
            :base(item,seat)
        {
            this.discount = discount;
        }

        public override float culPrice()
        {
            return this.ScheduleItem.Movie.Price * discount;
        }

        public override void printTicket()
        {
            Console.WriteLine("学生票");
        }

    }
}
