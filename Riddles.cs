using System;
using System.Collections.Generic;

namespace RiddleOfTheSphinx
{

  public class Riddles
  {
    private static List<Riddle> riddles = new List<Riddle>()
    {
      new Riddle("A barber".ToLower(), "I shave every day but my beard stays the same length. What am I?"),
      new Riddle("An envelope".ToLower(), "What begins with an 'e' and only contains one letter?"),
      new Riddle("Short".ToLower(), "What five-letter word becomes shorter when you add two letters to it?"),
      new Riddle("The letter r".ToLower(), "Two in a corner, one in a room, zero in a house, but one in a shelter. What is it?"),
      new Riddle("A coin".ToLower(), "What has a head and a tail but no body?"),
      new Riddle("A fence".ToLower(), "What runs all around a backyard, yet never moves?")
    };

    private Riddle currentRiddle = getRandomRiddle();

    public Riddle returnCurrentRiddle()
    {
      return currentRiddle;
    }

    public int getRiddleCount()
    {
      return riddles.Count;
    }

    private static Riddle getRandomRiddle()
    {
      var random = new Random();
      int index = random.Next(riddles.Count);
      return riddles[index];
    }
    public bool checkGuess(string guess)
    {
      if (guess.ToLower() == currentRiddle.Answer.ToLower())
      {
        riddles.Remove(currentRiddle);
        currentRiddle = getRandomRiddle();
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
