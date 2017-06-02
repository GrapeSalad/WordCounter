using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    public bool CheckForWord(string userInput)
    {
      if(userInput.GetType() == typeof(string))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
