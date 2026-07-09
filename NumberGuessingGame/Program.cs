namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximum = 0;
            Console.WriteLine("What Difficulty Would You Like?");
            string difficulty = Console.ReadLine();

            if (difficulty == "E")
            {
                maximum = 10;
            }
            else if (difficulty == "M") 
            {
                maximum = 50;
            }
               else if (difficulty == "H")
            {
                maximum = 1000;
            }

            NumberGuessing numberGuessing = new NumberGuessing(1, maximum);

            bool guessed = false;
            while (!guessed)

                Console.WriteLine("Please Enter Your Guess:");
            string guess = Console.ReadLine();
            GuessResult result = numberGuessing.MakeGuess(int.Parse(guess));

            if (result == GuessResult.TooLow)
            {
                Console.WriteLine("Your Guess is too LOW! Please try again.");
            }
            else if (result == GuessResult.TooHigh)
            {
                Console.WriteLine("Your Guess is too HIGH! Please try again.");
            }
            else if (result == GuessResult.Correct)
            {
                Console.WriteLine("Well Done! You are correct.");
                guessed = true;
            }
            else if (result == GuessResult.OutOflimits)
            {
                Console.WriteLine("Out of range, are you kidding me? Please try again");
            }
        }
    }
}
