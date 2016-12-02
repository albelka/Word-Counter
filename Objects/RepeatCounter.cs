using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
  public class RepeatCounter
  {
    public string Sentence {get; set;}
    public string Word {get; set;}

    public RepeatCounter(string sentence, string word)
    {
      this.Sentence = sentence;
      this.Word = word;
    }

    public bool CompareTwoWords()
    {
      if(this.Sentence == this.Word)
      {
        return true;
      }
      return false;
    }

    public int CountRepeats(string sentence, string word)
    {
      return 0;
    }
  }
}
