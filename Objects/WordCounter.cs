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
        if(userInput.Contains(" ") || userInput.Contains(",") || userInput.Contains("."))
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
      return false;
    }
  }
}
