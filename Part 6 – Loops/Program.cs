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
            PercentPassing();
            //OddSum();
            //RandomNumbers();
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
            string numOfPercentAsString;
            int numOfPercent;
            string inputAsString;
            double input;
            int passes;
            int fails;
            double output;

 
            passes = 0;

            Console.WriteLine("Please type in the amount of scores you want to enter:");
            numOfPercentAsString = Console.ReadLine();

            
            while(!int.TryParse(numOfPercentAsString, out numOfPercent))
            {
                
                Console.WriteLine("Please type in the amount of scores you want to enter:");
                numOfPercentAsString = Console.ReadLine();

            }
            if (int.TryParse(numOfPercentAsString, out numOfPercent))
            {
                for (int i = 1; i <= numOfPercent; i++)
                {
                    Console.WriteLine("Please enter a score:");
                    inputAsString = Console.ReadLine();

                    if (double.TryParse(inputAsString, out input))
                    {
                        if (input >= 70)
                        {
                            passes += 1;
                        }
                        else if (input < 0)
                        {
                            Console.WriteLine("That is not a valid score:");
                        }

                    }

                }
            }


            output = ((double)passes / numOfPercent) * 100;
            
            Console.WriteLine($"{Math.Round(output, 2)}% out of the {numOfPercent} scores were above 70.");
            Console.ReadLine();
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
