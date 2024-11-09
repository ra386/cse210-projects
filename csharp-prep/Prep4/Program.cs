using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine();

        Console.WriteLine("Welcome to list exercise");
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int number;
        List<int> numbers = new List<int>();

        do 
        {
            Console.Write("Enter a number  ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while (number != 0);
        {
            Console.WriteLine("You are done");
           
        }
            // Getting the sum
        int sum = numbers.Sum();
        Console.WriteLine("The tolal is  " + sum);

        // Getting average

        double average = 0;

        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }
        Console.WriteLine("The average is  " + average);

        // largest number

        int largestNumber = numbers.Max();
        Console.WriteLine("The largest number is:  " + largestNumber);

        numbers.Sort();
        Console.WriteLine("The sorted list:  " + string.Join("," , numbers));



    }
}




       