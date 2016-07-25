using Xunit;
using System;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    // [Fact]
    // public void GetWord_OneWordInput_true()
    // {
    //   string word1 = "hello";
    //   RepeatCounter testNewWord = new RepeatCounter(word1);
    //   string  testWord1 = testNewWord.GetWord1();
    //
    //   Assert.Equal(word1, testWord1);
    // }

    [Fact]
    public void GetWord_TwoWordInput_true()
    {
      string word1 = "hello";
      string word2 = "hi";
      RepeatCounter testNewWord = new RepeatCounter(word1, word2);
      string  testWord1 = testNewWord.GetWord1();
      string testWord2 = testNewWord.GetWord2();

      Assert.Equal(word1, testWord1);
      Assert.Equal(word2, testWord2);
    }

    [Fact]
    public void CompareWord_TwoWordCompare_true()
    {
      string word1 = "hello";
      string word2 = "hello";
      RepeatCounter testNewWord = new RepeatCounter(word1, word2);
      string CompareWord = testNewWord.CompareWord(word1, word2);
      Assert.Equal("Two words are the same", CompareWord);
    }

  }
}
