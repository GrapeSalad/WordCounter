using Xunit;
using System;

namespace WordCounter
{
  public class WordCounterTest
  {
    [Fact]
    public void Is_CheckForWordEntered_false()
    {
      string userInput = "B1rd";
      RepeatCounter newSingleWord = new RepeatCounter(userInput);
      Assert.Equal(false, newSingleWord.CheckForWord(userInput));
    }
    [Fact]
    public void Is_CheckForSentenceEntered_true()
    {
      string userInput = "Bird, bird, bird, bird is the word";
      RepeatCounter newSentence = new RepeatCounter(userInput);
      Assert.Equal("Pass, is Sentence", newSentence.CheckForWord(userInput));
    }
    [Fact]
    public void Is_RemovedPunctuation_true()
    {
      string userInput = "Bird, bird, bird, bird is the word";
      string expectedOutput = "Bird bird bird bird is the word";
      RepeatCounter newTestPunctuation = new RepeatCounter(userInput);
      Assert.Equal(expectedOutput, newTestPunctuation.RemovePunctuation(userInput));
    }
    [Fact]
    public void Is_DoesSentenceContainWord_true()
    {
      string wordToFind = "bird";
      string sentenceToCheck = "Bird, bird, bird, bird is the word";
      RepeatCounter newTestFindWord = new RepeatCounter(sentenceToCheck, wordToFind);
      Assert.Equal(true, newTestFindWord.DoesSentenceContainWord(sentenceToCheck, wordToFind));
    }
    [Fact]
    public void Is_CountRepeatsReturningTheRightValue_true()
    {
      string wordToFind = "bird";
      string sentenceToCheck = "Bird, bird, bird, bird is the word";
      RepeatCounter newTestCountingWord = new RepeatCounter(sentenceToCheck, wordToFind);
      Assert.Equal(4, newTestCountingWord.CountRepeats(sentenceToCheck, wordToFind));
    }
  }
}
