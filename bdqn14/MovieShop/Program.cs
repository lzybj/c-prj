using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Schedule s = new Schedule();
            Console.WriteLine(s.Items.Count);
        }
    }
}
