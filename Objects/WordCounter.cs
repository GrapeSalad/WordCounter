using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _singleWord;
    private string _sentence;

    public RepeatCounter(string userInputWord, string userInputSentence=null)
    {
      _singleWord = userInputWord;
      if(userInputSentence!=null)
      {
        _sentence = userInputSentence;
      }
    }

    public string GetSingleWord()
    {
      return _singleWord;
    }

    public string GetSentence()
    {
      return _sentence;
    }
//TESTED METHODS
    public bool CheckForWord(string userInput)
    {
      char[] userInputToArray = userInput.ToCharArray();
      bool isWord = false;
      for(var i=0; i<userInputToArray.Length; i++)
      {
        int numberToTestAgainst;
        if(int.TryParse(userInputToArray[i].ToString(), out numberToTestAgainst))
        {
          isWord = false;
          break;
        }
        else
        {
          isWord = true;
        }
      }
      return isWord;
    }
    public string CheckForSentence(string userInput)
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
          return successCheck;
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
