using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket(150);
            ticket.ShowTicket();
            Console.ReadKey();
        }
    }
}
