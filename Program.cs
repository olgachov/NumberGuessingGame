// See https://aka.ms/new-console-template for more information
using NumberGuessingGame;

GuessedNumber num = new GuessedNumber();
num.RequestUserNum();
Console.WriteLine(num.NumberToGuess);

GameStart game = new GameStart();
game.StartGame();

var userResponse = game.GetUserResponse();

if (userResponse == GameStart.StartGameResponse.N)
{
    Console.WriteLine("\nNo worries... will see you next time!");
}

else
{
    Console.WriteLine("\nLet's see what you can do...");
}

