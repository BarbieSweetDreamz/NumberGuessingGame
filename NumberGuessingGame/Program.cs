namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;

            while (!gameOver)
            {
                int maximum = 0;
                string difficulty = string.Empty;

                bool inputValid = false;
                
                while (!inputValid)
                {
                    Console.WriteLine("What Difficulty Would You Like? (E), (M) or (H)");
                    difficulty = Console.ReadLine();
                     difficulty = difficulty.ToUpper();

                    if ((difficulty == "E") || (difficulty == "M") || (difficulty == "H"))
                    {
                        inputValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Please type (E), (M) or (H)");
                        inputValid = false;
                    }

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
                    {
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

                    inputValid = false;
                    while (inputValid)
                    {

                        Console.WriteLine("Do you want to play again? (Y) or (N):");
                        string playAgain = Console.ReadLine();

                        playAgain = playAgain.ToUpper();

                        if ((playAgain == Decision.Y.ToString()) || (playAgain == Decision.N.ToString()))
                        {
                            inputValid = true;
                        }
                        else
                        {
                            Console.WriteLine("Please type (Y) or (N):");
                            inputValid = false;
                        }
                        if (playAgain == "N")
                        {
                            gameOver = true;
                        }
                        else if (playAgain == "Y")
                        {
                            gameOver = false;
                        }

                    }
                }

            }





        }
    }
}
