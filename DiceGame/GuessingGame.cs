using DiceRollGame.UserCommunication;

namespace DiceRollGame.DiceGame;

public class GuessingGame
{
    private readonly Dice _dice;
    private const int Chances = 3;

    public GuessingGame(Dice dice) => _dice = dice;

    public GameResult Play()
    {
        var diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice rolled. Guess what number it shows in {Chances} tries.");

        var chancesLeft = Chances;
        while(chancesLeft > 0)
        {
            var guessedNumber = ConsoleReader.ReadInteger("Enter a number from 1 to 6:");
            if (guessedNumber == diceRollResult)
            {
                return GameResult.Victory;
            }
            Console.WriteLine("Wrong Number.");
            chancesLeft--;
        }
        return GameResult.Loss;
    }

    public static void PrintResult(GameResult gameResult)
    {
        string message = gameResult == GameResult.Victory ? "You win!" : "You Lose :(";
        Console.WriteLine(message);
    }
}