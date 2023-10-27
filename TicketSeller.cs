using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kid_s_Fair
{
    internal class TicketSeller
    {
        private string name;
        private double price = 100;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;
        private double childrenPrice; // Add on additional field price for children

        //Method to "collect all the other methods" to be invoke in Main method
        public void Start()
        { 
            ReadingInput_KidFair();
            FinalOutput_KidsFair();
        }

        private void ReadingInput_KidFair()
        {
            Console.WriteLine("Welcome to KIDS' FAIR!");
            Console.WriteLine("Children always get a 75% discount!\n"); // Using escape sequence to create a new line

            Console.Write("Your name please: ");
            name = Console.ReadLine();

            Console.Write("Number of adults: ");
            numOfAdults = int.Parse(Console.ReadLine()); //convert string input to integer datatype

            Console.Write("Number of children: ");
            numOfChildren = int.Parse(Console.ReadLine()); //convert string input to integer datatype
        }

        private void Calculation_KidsFair()
        {
            childrenPrice = price * 0.25; // set a children price where 100 / 0.25
           // groups together both price class so I can use "amountTopay" variable to display in final part
            amountToPay = (numOfAdults * price) + (numOfChildren * childrenPrice); 
        }
        private void FinalOutput_KidsFair()
        {
            Calculation_KidsFair();
            Console.WriteLine("\n+++ Your receipt +++");
            // Using ToString method to display the exact digit I want to be as an output
            Console.WriteLine($"+++ Amount to pay = {amountToPay.ToString("0.00")}\n"); 
            Console.WriteLine($"+++ Thank you {name} and please come back! +++");
            Console.Write("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
