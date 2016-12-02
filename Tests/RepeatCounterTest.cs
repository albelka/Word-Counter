using Xunit;
using System;
using System.Collections.Generic;

namespace  WordCounter.Objects
{
  public class CountRepeatsTest
  {
    [Fact]
    public void HelperToCountRepeats_CompareTwoWords_true()
    {
      //Arrange
      string sentence = "hello";
      string word = "hello";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);
      //Act
      //Assert
      Assert.Equal(true, newRepeatCounter.Compare());
    }
    [Fact]
    public void HelperToCountRepeats_CompareTwoWordsCaseInsensitive_true()
    {
      //Arrange
      string sentence = "Hello";
      string word = "hello";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);
      //Act
      //Assert
      Assert.Equal(true, newRepeatCounter.Compare());
    }
    [Fact]
    public void HelperToCountRepeats_CompareTwoWordsPunctuation_true()
    {
      //Arrange
      string sentence = "Hello,";
      string word = "hello";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);
      //Act
      //Assert
      Assert.Equal(true, newRepeatCounter.Compare());
    }
    [Fact]
    public void HelperToCountRepeats_FindWordInSentence_true()
    {
      //Arrange
      string sentence = "Hello, you";
      string word = "hello";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);
      //Act
      //Assert
      Assert.Equal(true, newRepeatCounter.Compare());
    }
    [Fact]
    public void CountRepeats_FindWordInSentence_number()
    {
      //Arrange
      string sentence = "Hello, you! I love to say hello to friends!";
      string word = "hello";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);
      //Act
      //Assert
      Assert.Equal(2, newRepeatCounter.CountRepeats());
    }
  }
}
