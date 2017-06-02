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
    [Fact]
    public void Is_RemovedPunctuation_true()
    {
      string userInput = "Bird, bird, bird, bird is the word";
      string expectedOutput = "Bird bird bird bird is the word";
      RepeatCounter newTestPunctuation = new RepeatCounter();
      Assert.Equal(expectedOutput, newTestPunctuation.RemovePunctuation(userInput));
    }
    [Fact]
    public void Is_DoesSentenceContainWord_true()
    {
      string wordToFind = "bird";
      string sentenceToCheck = "Bird, bird, bird, bird is the word";
      RepeatCounter newTestFindWord = new RepeatCounter();
      Assert.Equal(true, newTestFindWord.DoesSentenceContainWord(sentenceToCheck, wordToFind));
    }
  }
}
