using System;
using System.Collections.Generic;

namespace RiddleOfTheSphinx
{

  public class Riddles
  {
    private List<Riddle> riddles = new List<Riddle>()
    {
      new Riddle("A barber".ToLower(), "I shave every day but my beard stays the same length. What am I?"),
      new Riddle("An envelope".ToLower(), "What begins with an 'e' and only contains one letter?"),
      new Riddle("Short".ToLower(), "What five-letter word becomes shorter when you add two letters to it?"),
      new Riddle("The letter 'r'".ToLower(), "Two in a corner, one in a room, zero in a house, but one in a shelter. What is it?"),
      new Riddle("A coin".ToLower(), "What has a head and a tail but no body?"),
      new Riddle("A fence ".ToLower(), "What runs all around a backyard, yet never moves?")
    };

public Riddle getRandomRiddle()
{
  var random = new Random();
  int index = random.Next(riddles.Count);
  return riddles[index];
}
    // Console.WriteLine("Riddle 1:");
    // Console.WriteLine(riddle[answer]);
    // string userAnswer = Console.ReadLine();

    // if (riddle.ContainsKey(userAnswer.ToLower())) {
    //   Console.WriteLine("Congrats! You got it!");
    // } else {
    //   Console.WriteLine("Please try again...");
    //   Main();
    // }
  }
}