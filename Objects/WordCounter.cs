using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    public string CheckForWord(string userInput)
    {
      string successCheck = "fail";
      if(userInput.GetType() == typeof(string))
      {
        if((userInput.Contains(" ") || userInput.Contains(",")) || userInput.Contains("."))
        {
          return successCheck = "Pass, is Sentence";
        }
        else
        {
          return successCheck = "Pass, is String";
        }
      }
      else
      {
        return successCheck;
      }
    }
    public string RemovePunctuation(string userInput)
    {
      string outputTest = userInput.Replace(",", "");
      return outputTest;
    }
    public bool DoesSentenceContainWord(string sentenceToCheck, string wordToFind)
    {
      if(sentenceToCheck.Contains(wordToFind))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public int CountRepeats(string sentenceToCheck, string wordToFind)
    {
      int count = 0;
      string modifiedSentence = this.RemovePunctuation(sentenceToCheck.ToLower());
      if(this.DoesSentenceContainWord(sentenceToCheck, wordToFind))
      {
        List<string> splitSentence = new List<string>(modifiedSentence.Split(' '));
        for(var i=0; i<splitSentence.Count; i++)
        {
          if(splitSentence[i] == wordToFind)
          count ++;
        }

      }
      return count;
    }
  }
}
