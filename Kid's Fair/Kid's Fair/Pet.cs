using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kid_s_Fair
{
    internal class Pet
    {
        //Declaring needed fields that will be used within the class
        private string petName;
        private int petAge;
        private bool petIsFemale;

        //A method that "collect" all the other method to be invoke in Main method
        public void Start()
        {
            Readinginput_Pet();
            FinalOutput_Pet();
        }

        //A method for reading user's input on fields 
        private void Readinginput_Pet()
        {
            Console.WriteLine("Greeting from MyPet class\n"); //using excape sequence "new line" to create space
            

            Console.Write("What is the name of your pet? ");
            petName = Console.ReadLine(); // The answer will be stored in "petName" variable

            // I like using string literal "$" for make the code more readable.
            Console.Write($"What is {petName}'s age? ");
            //Using int.Parse conversion because the input value is a string datatype.
            petAge = int.Parse(Console.ReadLine()); 

            Console.Write($"Is {petName} a female (y/n)? ");
            string answer = Console.ReadLine().ToLower(); // Using "ToLower" method to to control user's input.

            if (answer == "y") //if the input is "Y" or "y", bollean will turn to true.
            {petIsFemale = true;}

            else
            { petIsFemale = false; }
            Console.WriteLine();
        }
        //A method to display value
        private void FinalOutput_Pet()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine($"Name: {petName} Age: {petAge}");
            Console.WriteLine($"{petName} is a good girl!");
            Console.WriteLine("+++++++++++++++++++++++++++++\n"); // using escape sequence "new line" to create space
            Console.WriteLine("Pess Enter to start the next part!");
            Console.ReadLine();
        }
    }
}
