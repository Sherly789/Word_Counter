using Nancy;


namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/hi"] = _ => "hello";
    }
  }
}
