using System;

namespace RNGStart
{
    class Program
    {
        static Random rnd = new Random();
        static int rng1;
        static int rng2;
        static int guess1;
        static int guess2;
        static string name;


        static void Main(string[] args)
        {
            GenerateNumbers();
            Console.WriteLine($"{rng1}, {rng2}");

            Console.WriteLine("Hello what is your name?");
            name = Console.ReadLine();

            Console.WriteLine("ROUND 1");
            Console.WriteLine($"Hi {name}, Guess a number between 1 and 10");

            int maxGuesses = 0;

            // Loop for round 1
            while (maxGuesses < 3)
            {
                int.TryParse(Console.ReadLine(), out guess1);

                if(guess1== rng1)
                {
                    Console.WriteLine("You guessed it right");
                    maxGuesses = 3;
                }
                else if(maxGuesses == 2)
                {
                    Console.WriteLine("Sorry, you failed 3 guesses. Better luck next time");
                    Console.WriteLine($"The correct number was {guess1}");
                    return;
                }
                else if(guess1 > rng1)
                {
                    Console.WriteLine("Too high!");
                }
                else if(guess1 < rng1) 
                {
                    Console.WriteLine("Too Low");
                }

                maxGuesses++;
            }

            Console.WriteLine("Congratulations you made it to...\n");


            maxGuesses = 0;

            Console.WriteLine("\nROUND 2");
            Console.WriteLine("Guess a number between 1 and 100");

            while (maxGuesses < 3)
            {
                int.TryParse(Console.ReadLine(), out guess2);

                if (guess2 == rng2)
                {
                    Console.WriteLine("You guessed it right");
                    maxGuesses = 3;
                }
                else if (maxGuesses == 2)
                {
                    Console.WriteLine("Sorry, you failed 3 guesses. Better luck next time");
                    Console.WriteLine($"The correct number was {guess2}");
                    return;
                }
                else if (guess2 > rng2)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guess2 < rng2)
                {
                    Console.WriteLine("Too Low");
                }

                maxGuesses++;
            }

            Console.WriteLine("You have read a computers mind! Go get 'em!");
        }

        public static void GenerateNumbers() 
        {
            rng1 = rnd.Next(1, 11);
            rng2 = rnd.Next(1, 101);
        }

    }
}
