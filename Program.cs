using DiceRollGame.DiceGame;

Console.Title = "Dice Roll Game";
Console.WriteLine("=====Dice Roll Game=====");

var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResult(gameResult);

Console.WriteLine("Press any key to Exit");
Console.ReadKey();