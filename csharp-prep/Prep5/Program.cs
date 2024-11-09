using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Console.WriteLine();

        DisplayWelcomeMessage();
        {
            string UserName = PromptUserName();
            int UserNumber = PromptUserNumber();

            int squaredNumber = squareNumber(UserNumber);

             DisplayResult(UserName, squaredNumber);
        }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name  ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your favourite number  ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int squareNumber(int number)
        {
            int sqaure = number * number;
            return sqaure;

        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

       




       
         
    }
}