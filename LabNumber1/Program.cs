using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            //
            double userLength;
            double userWidth;
            double area;
            double perimeter;
            bool Continue = true;

            while (Continue == true)
            {
                Console.WriteLine("Please enter room measurements in length:");
                userLength = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter room measurements in width:");
                userWidth = double.Parse(Console.ReadLine());

             //processing

                area = userLength * userWidth;
                Console.WriteLine("The area of the room is: " + " " + area);

                perimeter = userLength * 4;
                Console.WriteLine("The perimeter of the room is: " + " " + perimeter);

                //output

                string Choice;
                Console.WriteLine("Would you like to continue?");
                Choice = Console.ReadLine();

                if (Choice == "N" || Choice == "No" || Choice == "NO" || Choice == "no")
                {
                    Continue = false;
                }

            }
          

            



        }
    }
}
