using System;
using System.Text;
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

    public static string TrimPunctuation(string sentence)
    {
      StringBuilder myStringBuilder = new StringBuilder();
      foreach (char c in sentence)
      {
        if (!char.IsPunctuation(c))
          myStringBuilder.Append(c);
      }
      string newString = myStringBuilder.ToString();
      return newString;
    }

    public bool Compare()
    {
      string sentenceLower = this.Sentence.ToLower();
      string wordLower = this.Word.ToLower();
      sentenceLower = TrimPunctuation(sentenceLower);
      wordLower = TrimPunctuation(wordLower);
      Console.WriteLine(wordLower);
      Console.WriteLine(sentenceLower);
      string[] sentenceArray = sentenceLower.Split(' ');

      foreach(string word in sentenceArray)
      if(word == wordLower)
      {
        return true;
      }
      return false;
    }



    public int CountRepeats()
    {
      string sentenceLower = this.Sentence.ToLower();
      string wordLower = this.Word.ToLower();
      int count = 0;
      sentenceLower = TrimPunctuation(sentenceLower);
      wordLower = TrimPunctuation(wordLower);
      Console.WriteLine(wordLower);
      Console.WriteLine(sentenceLower);
      string[] sentenceArray = sentenceLower.Split(' ');

      foreach(string word in sentenceArray)
      if(word == wordLower)
      {
        count ++;
      }
      return count;
    }
  }
}
