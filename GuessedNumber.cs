using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class GuessedNumber
    {
        const int MIN_NUM = 1,
            MAX_NUM = 20;
        public int NumberToGuess { get; set;}


        public void RequestUserNum()
        {
            Console.WriteLine("Input number between {0} and {1} (inclusive to be guessed. >> ", MIN_NUM, MAX_NUM);
            string inputStr = Console.ReadLine();
            int inputNum;
            while(!(Int32.TryParse(inputStr, out inputNum) && inputNum >=MIN_NUM && inputNum <= MAX_NUM))
            {
                Console.WriteLine("Invalid entry. You must enter an integer between {0} and {1} inclusive. Please try again: ", MIN_NUM, MAX_NUM);
                inputStr = Console.ReadLine();
            }
            NumberToGuess = inputNum;
        }
    }

}
