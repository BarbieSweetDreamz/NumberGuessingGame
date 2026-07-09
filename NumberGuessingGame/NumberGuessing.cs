using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Text;

namespace NumberGuessingGame
{
    internal class NumberGuessing
    {
        private int numberToGuess = 0;
        private int minimum;
        private int maximum;

        public NumberGuessing()
        {
            GenerateRandomNumber(minimum,maximum);

        }
       public void GenerateRandomNumber(int minimum, int maximum)
        {
            Random rand = new Random();
            numberToGuess = rand.Next(minimum, maximum);

            this.minimum = minimum;
            this.maximum = maximum;
        }

       public GuessResult MakeGuess(int guess)
        {
            if (guess > maximum )
            {
                return GuessResult.OutOflimits;
            }
            else if (guess < minimum)
            {
                return GuessResult.OutOflimits;
            }
            else if (guess == numberToGuess)
            {
                GuessResult result = GuessResult.Correct;
                return result;
            }
            else if (guess < numberToGuess)
            {
                return GuessResult.TooLow;
            }
            else
            {
                return GuessResult.TooHigh;
            }
        }

}
}