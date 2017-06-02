using Xunit;
using System;

namespace WordCounter
{
  public class WordCounterTest
  {
    [Fact]
    public void Is_CheckForWordEntered_True()
    {
      string userInput = "Bird";
      RepeatCounter newSingleWord = new RepeatCounter();
      Assert.Equal(true, newSingleWord.CheckForWord(userInput));
    }
  }
}
