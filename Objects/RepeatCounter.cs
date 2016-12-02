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
      string sentenceLower = this.Sentence.ToLower();
      string wordLower = this.Word.ToLower();
      
      if(sentenceLower == wordLower)
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
