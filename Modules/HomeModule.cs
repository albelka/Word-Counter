using Nancy;
using System.Collections.Generic;
using System;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/sentence"] = _ => {
        string sentence = Request.Form["sentence"];
        string word = Request.Form["word"];
        if(sentence=="" || word=="")
        {
          return View["error.cshtml"];
        }
        RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);
        return View["sentence.cshtml", newRepeatCounter];
      };
    }
  }
}
