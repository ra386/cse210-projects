using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine();

         Random number = new Random();
        int randomNumber = number.Next(1,101);
        int guess ;
        int userTries = 0;

        Console.WriteLine("Welcome to Guess My Number Game!");

        do 
        {
            Console.Write("What is the magic number ?  ");
            guess = int.Parse(Console.ReadLine());
            userTries++;

            if (guess < randomNumber)
            {
                Console.WriteLine("Higher");

            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessd it champ, You suceeded in {userTries} attempts");

                Console.WriteLine("Do you want to play again yes/no");
                string again = Console.ReadLine().ToUpper();

                if (again != "YES")
                {
                    break;
                }
                
                randomNumber = number.Next(1,101);
                userTries = 0;
                Console.WriteLine("New Game Started!");
            }

        } while (true);



       
   }
}