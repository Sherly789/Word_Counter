using System;

namespace WordCounter.Objects
{
  // class object
  public class RepeatCounter
  {
    //properties
    private string _word1;

    //constructors, getters and setters
    public RepeatCounter(string word1)
    {
      _word1 = word1;
    }

    public string GetWord1()
    {
      return _word1;
    }

    public void SetWord1(string word1)
    {
      _word1 = word1;
    }
    //other methods

  }
}
