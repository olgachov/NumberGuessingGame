using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class GameStart
    {
        public enum StartGameResponse
        {
            N,
            Y
        }
        public void StartGame()
        {
            const string BORDER = "-------------------------------------------------------------------------";
            const char SP_CHAR = '*',
                SPACE = ' ';
            int size = BORDER.Length;
            Console.Clear();

            for (int j = 0; j < size; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write(SP_CHAR.ToString() + SPACE.ToString());
                }
            }
        }
        public StartGameResponse GetUserResponse()
        {
            bool validInput = false;
            string userInputStr = "";
            while(!validInput)
            {
                Console.Write("\nDO YOU ACCEPT THE CHALLENGE (Y/N)? >> ");
                userInputStr = Console.ReadLine();
                validInput = char.TryParse(userInputStr, out char userInputChar) && (userInputChar == 'Y' || userInputChar == 'N');
            }
                      
            return (StartGameResponse)Enum.Parse(typeof(StartGameResponse), userInputStr);
        }

    }
}
