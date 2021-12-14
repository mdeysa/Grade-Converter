using System;

namespace Assignment2SyedAhmedISM240_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the variables used
            double score;

            //the user is entered into the program
            Console.WriteLine("Welcome to Grade Converter");
            Console.WriteLine("");
            Console.Write("Please enter your score: ");

            //check if the number is numeric or not
            if (double.TryParse(Console.ReadLine(), out score))
            {
                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    if (score >= 94)
                    {
                        Console.WriteLine("Your letter grade is a A");
                    }
                    else if (score >= 90 || score >= 93.9)
                    {
                        Console.WriteLine("Your letter grade is an A-");
                    }
                    else if (score >= 87 || score >= 89.9)
                    {
                        Console.WriteLine("Your letter grade is a B+");
                    }
                    else if (score >= 83 || score >= 86.9)
                    {
                        Console.WriteLine("Your letter grade is a B");
                    }
                    else if (score >= 80 || score >= 82.9)
                    {
                        Console.WriteLine("Your letter grade is a B-");
                    }
                    else if (score >= 77 || score >= 79.9)
                    {
                        Console.WriteLine("Your letter grade is a C+");
                    }
                    else if (score >= 73 || score >= 76.9)
                    {
                        Console.WriteLine("Your letter grade is a C");
                    }
                    else if (score >= 70 || score >= 72.9)
                    {
                        Console.WriteLine("Your letter grade is a C-");
                    }
                    else if (score >= 67 || score >= 69.9)
                    {
                        Console.WriteLine("Your letter grade is a D+");
                    }
                    else if (score >= 63 || score >= 66.9)
                    {
                        Console.WriteLine("Your letter grade is a D");
                    }
                    else if (score >= 60 || score >= 62.9)
                    {
                        Console.WriteLine("Your letter grade is a D-");
                    }
                    else if (score < 60)
                    {
                        Console.WriteLine("Your letter grade is an F");
                    }
                }
            }
            else
            {
                Console.WriteLine("Input is non-numeric");
            }


        }
    }
}
