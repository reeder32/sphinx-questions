using System;

namespace RiddleOfTheSphinx
{
  class Sphinx
  {
    static void Main()
    {
      Console.WriteLine("WELCOME TO THE RIDDLE OF THE SPHINX");
      Riddles riddles = new Riddles();
      Console.Write("How many questions today? ");
      int num = int.Parse(Console.ReadLine());
      if (num <= riddles.getRiddleCount())
      {
        for (int index = 0; index < num; index += 1)
        {
          Riddle currentRiddle = riddles.returnCurrentRiddle();
          Console.WriteLine(currentRiddle.Question);
          string guess = Console.ReadLine();
          if (riddles.checkGuess(guess))
          {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Well done! That is the correct answer.");
            Console.ForegroundColor = ConsoleColor.White;
          }
          else
          {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("That is not the correct answer! You lose...");
            break;
          }
        }
      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You have to choose a number less than {0}", riddles.getRiddleCount());
        Console.ForegroundColor = ConsoleColor.White;
      }
    }
  }
}
