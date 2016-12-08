using Xunit;
using System;
using System.Collections.Generic;

namespace  WordCounter.Objects
{
  public class CountRepeatsTest
  {
    [Fact]
    public void CountRepeats_ReturnsFalseWhenWordsAreDifferent_0()
    {
      //Arrange
      string sentence = "hello";
      string word = "yo";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);
      //Act
      //Assert
      Assert.Equal(0, newRepeatCounter.CountRepeats());
    }
    [Fact]
    public void CountRepeats_CompareTwoWords_1()
    {
      //Arrange
      string sentence = "hello";
      string word = "hello";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);
      //Act
      //Assert
      Assert.Equal(1, newRepeatCounter.CountRepeats());
    }
    [Fact]
    public void CountRepeats_CompareTwoWordsCaseInsensitive_1()
    {
      //Arrange
      string sentence = "Hello";
      string word = "hello";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);
      //Act
      //Assert
      Assert.Equal(1, newRepeatCounter.CountRepeats());
    }
    [Fact]
    public void CountRepeats_CompareTwoWordsPunctuation_1()
    {
      //Arrange
      string sentence = "Hello,";
      string word = "hello";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);
      //Act
      //Assert
      Assert.Equal(1, newRepeatCounter.CountRepeats());
    }
    [Fact]
    public void HelperToCountRepeats_FindWordInSentence_1()
    {
      //Arrange
      string sentence = "Hello, you";
      string word = "hello";
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);
      //Act
      //Assert
      Assert.Equal(1, newRepeatCounter.CountRepeats());
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
