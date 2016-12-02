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
        
      }

    }
  }
}
