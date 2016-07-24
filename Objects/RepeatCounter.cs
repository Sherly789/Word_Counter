using System;

namespace WordCounter
{
  // class object
  public class RepeatCounter
  {
    //properties
    private string _word1;
    private string _word2;

    //constructors, getters and setters
    public RepeatCounter(string word1, string word2)
    {
      _word1 = word1;
      _word2 = word2;
    }

    public string GetWord1()
    {
      return "hello";
    }

    public void SetWord1(string word1)
    {
      _word1 = word1;
    }

    public string GetWord2()
    {
      return "hi";
    }

    public void SetWord2(string word2)
    {
      _word2 = word2;
    }
    //other methods

  }
}
