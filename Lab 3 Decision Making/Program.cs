using System;

namespace Lab_3_Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool goOn = true;
            Console.WriteLine("Please enter you name.");
            string name = Console.ReadLine();

            while (goOn == true)
            {
                
                Console.WriteLine($"{name} Enter a number between 1 and 100");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 != 0 && number <= 100 && number >=1)
                { 
                    Console.WriteLine($"{number} is odd");
                }
                else if (number >= 2 && number <= 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (number >= 26 && number <= 60)
                {
                    Console.WriteLine("Even");
                }
                else if (number >= 60 && number <= 100)
                {
                    Console.WriteLine($"{number} is even");
                }
                else if (number < 1 || number > 100)
                {
                    Console.WriteLine("Invalid input try again");
                    continue;
                }
                bool keepAsking = true;
                while (keepAsking)
                {
                    Console.WriteLine($"{name} Do you want to continue? y or n");
                    string decision = Console.ReadLine().ToLower();

                    if (decision == "y")
                    {
                        goOn = true;
                        keepAsking = false;
                        continue;
                    }
                    else if (decision == "n")
                    {
                        goOn = false;
                        keepAsking = false;
                        Console.WriteLine($"Exiting. Goodbye {name} ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{name} I don't understand, please try again");
                    }
                }
            }
            }
        }
    }

