using System;
using System.Collections.Generic;

namespace WordCounter
{
  // class object
  public class RepeatCounter
  {
    //properties
    private string _word1;
    private string _phrase;

    //constructors, getters and setters
    public RepeatCounter(string word1, string phrase)
    {
      _word1 = word1;
      _phrase = phrase;
    }

    public string GetWord1()
    {
      return _word1;
    }

    public void SetWord1(string word1)
    {
      _word1 = word1;
    }

    public string GetPhrase()
    {
      return _phrase;
    }

    public void SetPhrase(string phrase)
    {
      _phrase = phrase;
    }

    //other methods
    public int CountRepeats()
    {
      if (this._word1 == this._phrase)
      {
        return 1;
      } else {
        return 0;
      }
      // string[] splitPhrase = this._phrase.ToLower().Trim().Split(' ');
      // string newWord1 = this._word1.Trim().ToLower();
      // if (this._word1 == "")
      // {
      //   return 0;
      // }
      //
      // int count = 0;
      // foreach (string word in splitPhrase)
    	// {
  	  //   if (word == newWord1)
      //   {
      //     count++;
      //   }
    	// }

    }
  }
}
