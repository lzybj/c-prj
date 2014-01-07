using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieShop
{
    public class FreeTicket : Ticket
    {
        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public FreeTicket()
        {
        }

        public FreeTicket(ScheduleItem item,Seat seat,string customerName)
            :base(item,seat)
        {
            this.customerName = customerName;
        }

        public override float culPrice()
        {
            return 0.00f;
        }

        public override void printTicket()
        {
            Console.WriteLine("免费票");
        }

    }
}
