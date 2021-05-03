using System;
using System.Collections.Generic;

namespace RiddleOfTheSphinx
{
  class Sphinx
  {
    static void Main()
    {
      Console.WriteLine("WELCOME TO THE RIDDLE OF THE SPHINX");
      Riddles riddles = new Riddles();
      Riddle random = riddles.getRandomRiddle();
     Console.WriteLine(random.Question);
    Riddle anotherRandom = riddles.getRandomRiddle();
    Console.WriteLine(anotherRandom.Question);
    }       
  }

}
