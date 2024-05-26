using FizzBuzz.Models;

Console.WriteLine("Welcome to FizzBuzz Game!");
Console.WriteLine("=========================\n\n");
Console.WriteLine(
    "The game is simple, you have to guess the result of the sequence of numbers from 1 to 100"
);
Console.WriteLine(
    @$"
    The game is simple, you have to guess the result of the sequence of numbers from MIN to MAX

    * FizzBuzz if the number is divisible by 3 and 5
    * Fizz if the number is divisible by 3
    * Buzz if the number is divisible by 5
    * The number if none of the above conditions are met

    This is an example:

    From 1 to 6 => {FizzBuzzGame.Play(1, 6)}
    From 4 to 10 => {FizzBuzzGame.Play(4, 10)}
"
);

bool keepPlaying = true;
do
{
    Console.WriteLine("Choose the interval of numbers to play the game:");
    Console.WriteLine("From:");
    if (!int.TryParse(Console.ReadLine(), out int minNumber))
    {
        Console.WriteLine("Invalid input for min number.");
        continue;
    }
    Console.WriteLine("To:");
    if (!int.TryParse(Console.ReadLine(), out int maxNumber))
    {
        Console.WriteLine("Invalid input for max number.");
        continue;
    }

    if (minNumber > maxNumber)
    {
        Console.WriteLine(
            @"
        We notice that the min number is greater than the max number so
        we will swap the numbers
        "
        );
        (maxNumber, minNumber) = (minNumber, maxNumber);
    }

    string result = FizzBuzzGame.Play(minNumber, maxNumber);

    Console.WriteLine($"Guess the result of {minNumber} to {maxNumber}:");
    string userInput = Console.ReadLine()!.ToLower();

    if (result.ToLower().Equals(userInput))
    {
        Console.WriteLine("Congratulations, you won!");
    }
    else
    {
        Console.WriteLine(
            @$"
        You lost!
        The result was: {result}
        "
        );
    }

    Console.WriteLine("Do you want to play again? (yes/no)");
    string playAgainResponse = Console.ReadLine()!.ToLower();
    if (playAgainResponse != "yes")
    {
        keepPlaying = false;
    }
} while (keepPlaying);
