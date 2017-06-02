using Nancy;
using System;
using WordCounter;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = parameters => {
        RepeatCounter newInstance = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
        string userInputWord = newInstance.GetSingleWord();
        string userInputSentence = newInstance.GetSentence();
        if((newInstance.CheckForWord(userInputWord) == "Pass, is String") && (newInstance.CheckForWord(userInputSentence) == "Pass, is Sentence"))
        {
          if(newInstance.DoesSentenceContainWord(userInputSentence, userInputWord))
          {
            int instancesOfWord = newInstance.CountRepeats(userInputSentence, userInputWord);
            return View["result.cshtml", instancesOfWord];
          }
          else
          {
            return View["ohSnap.cshtml"];
          }
        }
        else
        {
          return View["ohSnap.cshtml"];
        }
      };
    }
  }
}
