using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompter();
            //PercentPassing();  (I don't understand)
            //OddSum();
            RandomNumbers();
        }

        static void Prompter()
        {
            string minAsString;
            string maxAsString;
            string numAsString;
            int min;
            int max;
            int num;
            Console.WriteLine("Prompter\n");

            Console.WriteLine("Please enter a number");
            minAsString = Console.ReadLine();
            while (!int.TryParse(minAsString, out min))
            {
                Console.WriteLine("Please enter a number");
                minAsString = Console.ReadLine();
            }

            Console.WriteLine($"Now please enter a number above {min}");
            maxAsString = Console.ReadLine();
            while ((!int.TryParse(maxAsString, out max)) || (min >= max))
            {
                Console.WriteLine($"Please enter a number above {min}");
                maxAsString = Console.ReadLine();
            }

            Console.WriteLine($"Please enter a number between {min} and {max}");
            numAsString = Console.ReadLine();
            while ((!int.TryParse(numAsString, out num)) || (min > num) && (num < max))
            {
                Console.WriteLine($"Please enter a number between {min} and {max}");
                numAsString = Console.ReadLine();
            }
            Console.WriteLine("Thank you!\n");
            Console.ReadLine();
        }
        static void PercentPassing()
        {       
            //string numAsString;
            //double num;
            //double num2;
            //double num3;
            //double num4;
            //double num5;
            //int percentage;
            //int i;

            //Console.WriteLine("Percent Passing\n");

            //Console.WriteLine("Please enter a score:");
            //numAsString = Console.ReadLine();
            //num = Convert.ToDouble(numAsString);
            //for (i = 1; i <= 4; i++)
            //{ 
            //    Console.WriteLine("Another one:");
            //    while ( i == 1)
            //    {
            //        numAsString = Console.ReadLine();
            //        num2 = Convert.ToDouble(numAsString);
            //    }
            //    while (i == 2)
            //    {
            //        numAsString = Console.ReadLine();
            //        num3 = Convert.ToDouble(numAsString);
            //    }
            //    while (i == 3)
            //    {
            //        numAsString = Console.ReadLine();
            //        num4 = Convert.ToDouble(numAsString);
            //    }
            //    while (i == 4)
            //    {
            //        numAsString = Console.ReadLine();
            //        num5 = Convert.ToDouble(numAsString);
            //    }
            //    percentage = (2 / 10) * 100
            //}
        }
        static void OddSum()
        {
            string numAsString;
            int num;
            int oddnums;

            Console.WriteLine("Please enter a number:");
            numAsString = Console.ReadLine();

            while (!int.TryParse(numAsString, out num))
            {
                Console.WriteLine("Please enter a number:");
                numAsString = Console.ReadLine();
            }

            oddnums = 0;
            if (int.TryParse(numAsString, out num))
            {
                for (int number1 = 1; number1 < (num + 1); number1++)
                {
                    if (number1 % 2 != 0)
                    {
                        oddnums = oddnums + number1;
                     }
                }
            }
            Console.WriteLine(oddnums);
            Console.ReadLine();
        }
        static void RandomNumbers()
        {
            int rando;
            string input;
            int min;
            int max;
            int i = 1;
            Random num = new Random();
            
            Console.WriteLine("Enter a number:");
            input = Console.ReadLine();
            //rando = num.Next();

            while (!Int32.TryParse(input, out min))
            {
                Console.WriteLine("That is not a valid number:");
                input = Console.ReadLine();
            }
            if (Int32.TryParse(input, out min)) 
            {
                Console.WriteLine("Please enter a number bigger than the previous one:");
                input = Console.ReadLine();
                if ((!Int32.TryParse(input, out max)) || (min >= max))
                {
                    Console.WriteLine($"The number entered is smaller than or equal to {min}, please enter a bigger number.");
                }
                else
                {
                    while (i <= 25)
                    {
                        rando = num.Next(min, max + 1);
                        Console.WriteLine(rando);
                        i += 1;
                    }
                }
                
            }
            Console.ReadLine();
        }

    
    }
}
