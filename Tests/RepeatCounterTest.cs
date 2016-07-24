using Xunit;
using System;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void GetWord_OneWordInput_true()
    {
      string word1 = "hello";
      RepeatCounter testNewWord = new RepeatCounter(word1);
      string  testWord1 = testNewWord.GetWord1();

      Assert.Equal(word1, testWord1);
    }
  }
}
