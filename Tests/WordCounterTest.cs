using Xunit;
using System;

namespace WordCounter
{
  public class WordCounterTest
  {
    [Fact]
    public void Is_CheckForWordEntered_true()
    {
      string userInput = "Bird";
      RepeatCounter newSingleWord = new RepeatCounter();
      Assert.Equal("Pass, is String", newSingleWord.CheckForWord(userInput));
    }
    [Fact]
    public void Is_CheckForSentenceEntered_true()
    {
      string userInput = "Bird, bird, bird, bird is the word";
      RepeatCounter newSentence = new RepeatCounter();
      Assert.Equal("Pass, is Sentence", newSentence.CheckForWord(userInput));
    }
  }
}
