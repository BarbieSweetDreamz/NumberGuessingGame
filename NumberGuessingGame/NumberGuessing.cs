using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingGame
{
    internal class NumberGuessing
    {
         int numberToGuess = 0;
        
        void GenerateRandomNumber(int minimum, int maximum)
        {
            Random rand = new Random();
            numberToGuess = rand.Next(minimum, maximum);
        }


    }
}