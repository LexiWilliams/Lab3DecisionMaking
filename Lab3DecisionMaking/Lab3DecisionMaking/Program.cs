using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            bool enterNumber = true, redo = true;
            while (enterNumber)
            {
                Console.WriteLine($"Hi {name}! Please enter an integer between 1 and 100.");
                string num1 = Console.ReadLine();

                if ((int.TryParse(num1, out int num2)) && num2 > 0)
                {
                    if ((num2 % 2 != 0) && (num2 <= 60)) //int is odd and less than or equal to 60
                    {
                        Console.WriteLine($"Okay {name}, {num2} is Odd");
                        enterNumber = false;
                    }
                    else if ((num2 % 2 == 0) && (num2 <= 25)) //int is even and less than or equal to 25
                    {
                        Console.WriteLine($"Okay {name}, {num2}  is even and less than or equal to 25");
                        enterNumber = false;
                    }
                    else if ((num2 % 2 == 0) && (num2 >= 26) && (60 >= num2)) //int is even and between 26 and 60
                    {
                        Console.WriteLine($"Okay {name}, {num2} is even");
                        enterNumber = false;
                    }
                    else if ((num2 % 2 == 0) && (num2 > 60)) //int is even and greater than 60
                    {
                        Console.WriteLine($"Okay {name}, {num2} is even");
                        enterNumber = false;
                    }
                    else if ((num2 % 2 != 0) && (num2 > 60)) //int is odd and greater than 60
                    {
                        Console.WriteLine($"Okay {name}, {num2} is Odd");
                        enterNumber = false;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry {name}, that input not understood. Please try again.");
                        enterNumber = true;
                    }
                }
                else
                {
                    Console.WriteLine($"Sorry {name}, that input was not understood. Please try again.");
                    enterNumber = true;
                }
                Console.ReadKey();
            }
        }
    }
}

