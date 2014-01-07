using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MovieShop
{
    public class Ticket
    {
        private ScheduleItem scheduleItem;

        public ScheduleItem ScheduleItem
        {
            get { return scheduleItem; }
            set { scheduleItem = value; }
        }
        private Seat seat;

        public Seat Seat
        {
            get { return seat; }
            set { seat = value; }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public Ticket()
        {
        }

        public Ticket(ScheduleItem scheduleItem,Seat seat)
        {
            this.scheduleItem = scheduleItem;
            this.seat = seat;
        }

        public virtual float culPrice()
        {
            return this.scheduleItem.Movie.Price;
        }

        public virtual void printTicket()
        {
            FileStream fs = new FileStream("ticket.txt",FileMode.Create);
            StreamWriter sw = new StreamWriter(fs,Encoding.Default);
            sw.WriteLine("这是一个张票通票");
            sw.Close();
            fs.Close();
        }

    }
}
