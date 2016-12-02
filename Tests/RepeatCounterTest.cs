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
      Assert.Equal(true, newRepeatCounter.CompareTwoWords());
    }
  }
}
