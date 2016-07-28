using Xunit;
using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    [Fact]
    public void GetWord_OneLetterMatch_true()
    {
      string word1 = "a";
      string word2 = "a";
      RepeatCounter testNewWord = new RepeatCounter(word1,word2);
      int wordCount = testNewWord.CountRepeats();

      Assert.Equal(1, wordCount);
    }

    [Fact]
    public void GetWord_OneLetterNotMatch_true()
    {
      string word1 = "a";
      string word2 = "b";
      RepeatCounter testNewWord = new RepeatCounter(word1,word2);
      int wordCount = testNewWord.CountRepeats();

      Assert.Equal(0, wordCount);
    }

    [Fact]
    public void GetWord_TwoLetterMatch_true()
    {
      string word1 = "ab";
      string word2 = "ab";
      RepeatCounter testNewWord = new RepeatCounter(word1,word2);
      int wordCount = testNewWord.CountRepeats();

      Assert.Equal(1, wordCount);
    }

    [Fact]
    public void GetWord_TwoLetterNotMatch_true()
    {
      string word1 = "ab";
      string word2 = "ac";
      RepeatCounter testNewWord = new RepeatCounter(word1,word2);
      int wordCount = testNewWord.CountRepeats();

      Assert.Equal(0, wordCount);
    }

    [Fact]
    public void GetWord_AWordMatchInPhrase_true()
    {
      string word1 = "hi";
      string phrase = "hi Shokouh";
      RepeatCounter testNewWord = new RepeatCounter(word1,phrase);
      int wordCount = testNewWord.CountRepeats();

      Assert.Equal(1, wordCount);
    }

    [Fact]
    public void GetWord_AWordNotMatchInPhrase_true()
    {
      string word1 = "by";
      string phrase = "hi Shokouh";
      RepeatCounter testNewWord = new RepeatCounter(word1,phrase);
      int wordCount = testNewWord.CountRepeats();

      Assert.Equal(0, wordCount);
    }

    [Fact]
    public void GetWord_TowWordNotMatchInPhrase_true()
    {
      string word1 = "really";
      string phrase = "really really fast";
      RepeatCounter testNewWord = new RepeatCounter(word1,phrase);
      int wordCount = testNewWord.CountRepeats();

      Assert.Equal(2, wordCount);
    }

    [Fact]
    public void GetWord_NotCountEmptySpaceInPhrase_true()
    {
      string word1 = " ";
      string phrase = "hi  Shokouh";
      RepeatCounter testNewWord = new RepeatCounter(word1,phrase);
      int wordCount = testNewWord.CountRepeats();

      Assert.Equal(0, wordCount);
    }

    [Fact]
    public void GetWord_NotCaseSensitiveWordAndPhrase_true()
    {
      string word1 = "Hi ";
      string phrase = "hi  Shokouh";
      RepeatCounter testNewWord = new RepeatCounter(word1,phrase);
      int wordCount = testNewWord.CountRepeats();

      Assert.Equal(1, wordCount);
    }
  }
}
