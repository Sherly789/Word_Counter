using Nancy;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];

      Post["/result"] = _ => {
        RepeatCounter testNewWord = new RepeatCounter (
          Request.Form["new-word"],
          Request.Form["new-phrase"]
        );
        return View["result.cshtml", testNewWord];
      };

    }
  }
}
