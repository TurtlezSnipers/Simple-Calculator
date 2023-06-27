using System;

namespace Visual_Studio_Code
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Title = ("Multiplication Calculator");
            NewProblem:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Random numbergenerator = new Random();
            double num01 = numbergenerator.Next(1,13);
            double num02 = numbergenerator.Next(1,13);
            
            Start:
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("What is " + num02 + " + x = " + num01 + "?");
            double answer = Convert.ToDouble (Console.ReadLine());
            
            if (answer == num01-num02) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(answer);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" is correct.");

                goto NewProblem;
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Try again dumbass.");
                goto Start;
            }
            
        }
    }
}
