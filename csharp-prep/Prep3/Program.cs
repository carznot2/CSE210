using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        while(true)
        {
            int magicNumber = randomGenerator.Next(1, 100);
            int guess = -1;
            int counter = 0;
            string answer = "";

            {
                Console.WriteLine("What is your guess (1-100)? ");
                guess = int.Parse(Console.ReadLine());

                if(guess==magicNumber)
                {
                    Console.WriteLine("You guessed it!!");
                }
                else if(guess > magicNumber)
                {
                    Console.WriteLine("Guess a lower number.");
                }
                else
                {
                    Console.WriteLine("Guess a higher number.");
                }
                counter ++;
            }

            Console.WriteLine($"It took you {counter} guesses.");
            while(answer.ToUpper() != "N" && answer.ToUpper() != "Y")
            {
                Console.WriteLine("Would you like to play again (Y/N)? ");
                answer = Console.ReadLine();
            }
            if (answer.ToUpper() == "N")
            {
                break;
            }
        }
    }
}