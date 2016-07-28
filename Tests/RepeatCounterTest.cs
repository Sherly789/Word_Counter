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




    // [Fact]
    // public void GetWord_OneWordInput_true()
    // {
    //   string word1 = "hello";
    //   RepeatCounter testNewWord = new RepeatCounter(word1,"");
    //   string  testWord1 = testNewWord.GetWord1();
    //
    //   Assert.Equal(word1, testWord1);
    // }
    //
    // [Fact]
    // public void GetWordandphrase_OnewordandOnePhraseInput_true()
    // {
    //   string word1 = "hello";
    //   string phrase = "This is a cat";
    //   RepeatCounter testNewWord = new RepeatCounter(word1, phrase);
    //   string  testWord1 = testNewWord.GetWord1();
    //   string testphrase = testNewWord.GetPhrase();
    //
    //   Assert.Equal(word1, testWord1);
    //   Assert.Equal(phrase, testphrase );
    // }
    //
    // [Fact]
    // public void  CountRepeats_CountWordRepeatation_true()
    // {
    //   string phrase = "We are going really really fast";
    //   string word = "really";
    //   RepeatCounter testNewWord = new RepeatCounter(word, phrase);
    //   int wordCount = testNewWord.CountRepeats();
    //
    //   Assert.Equal(2, wordCount);
    // }
  }
}
