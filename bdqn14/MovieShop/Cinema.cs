using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieShop
{
    public class Cinema
    {
        private Schedule schedule;

        public Schedule Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }
        private Dictionary<string, Seat> seats;

        public Dictionary<string, Seat> Seats
        {
            get { return seats; }
            set { seats = value; }
        }
        private List<Ticket> soldTickets;

        public List<Ticket> SoldTickets
        {
            get { return soldTickets; }
            set { soldTickets = value; }
        }

        public Cinema()
        {
            schedule = new Schedule();
            seats = new Dictionary<string, Seat>();
            soldTickets = new List<Ticket>();
        }

    }
}
