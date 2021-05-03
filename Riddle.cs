using System;

namespace RiddleOfTheSphinx
{
  public class Riddle
  {
    public string Answer { get; set; }
    public string Question { get; set; }

    public Riddle(string answer, string question)
    {
      Answer = answer;
      Question = question;
    }
  }
}
