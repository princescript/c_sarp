using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    internal class Program
    {
        static void Main()
        {
            //string Name = null; // Reference Type
            //int Agee = null; // Value Type Null is not allowed
            //int? Age = null; // to make null value type use ?

            //bool? AreYouMajor = null;

            //if (AreYouMajor == true)
            //{
            //    Console.WriteLine("You are Major");
            //}
            //else if (AreYouMajor == false)
            //{
            //    Console.WriteLine("You are not Major");
            //}
            //else { 
            //    Console.WriteLine("You did not answer the question");
            //}

            //int? TicketOnSale = 20;
            //int AvailableTickets;
            //if (TicketOnSale == null) { 
            //    AvailableTickets = 0;
            //} else
            //{
            //    // AvailableTickets = TicketOnSale.GetValueOrDefault();
                 //AvailableTickets =TicketOnSale.Value;
            //     AvailableTickets = (int) TicketOnSale;

            //}
            //Console.WriteLine("Available Tickets = {0}", AvailableTickets);


            int? TicketOnSale = 20;
            int AvailableTickets = TicketOnSale ?? 0;

        }
    }
}
