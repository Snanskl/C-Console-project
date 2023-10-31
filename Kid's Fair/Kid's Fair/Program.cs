using System;

namespace Kid_s_Fair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet1 = new Pet(); //Instantiated an objetc from Pet class
            pet1.Start(); //Invoke methods that we've collected in "Start"

            Album album1 = new Album(); //Instantiated an object from Album class
            album1.Start(); // Invoke methods that we've collected in "Start"
            
            TicketSeller ticket = new TicketSeller(); //Instantiated an object from TicketSeller class
            ticket.Start(); //Invoke methods that we've collected in "Start"
        }
    }
}