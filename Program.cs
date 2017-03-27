using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labOne
{
    class Program
    {
        static void Main(string[] args)
        {
            float length = 0;
            float width = 0;
            float area = 0;
            float perimeter = 0;
            string result = "y"; 
            bool keepGoing = true;
            //Keep running as long as user wishes

            while (keepGoing)
            {
                //Prompt the user for length.
                 Console.WriteLine("Enter length: ");
                   string lenEnter = Console.ReadLine();

                System.Console.WriteLine("Enter width: ");
                   string widEnter = Console.ReadLine();

                System.Console.WriteLine("Area: ");
                
            

                                //Get user dimensions.
               

                int lengthOne = int.Parse(lenEnter);
                int widthOne = int.Parse(widEnter);
               

                area = lengthOne * widthOne;
                perimeter = (2*lengthOne) + 2*widthOne;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);

                //App asks user if they would like to keep measuring rooms.
                Console.WriteLine("Continue? (y/n)");

                result = System.Console.ReadLine();
            }
            //Get user result answer yes or no.
            if (result == "y")
            {
                keepGoing = true;
            }
            else { }

        }
    }
}
    

