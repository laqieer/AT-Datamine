// Decompiled with JetBrains decompiler
// Type: StaqData.PlayingStoryInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020C3")]
  public class PlayingStoryInfo : SpecifiedStory
  {
    [Token(Token = "0x600C670")]
    [Address(RVA = "0x1CD6E6C", Offset = "0x1CD6E6C", VA = "0x1CD6E6C")]
    public PlayingStoryInfo()
    {
    }

    [Token(Token = "0x17002A81")]
    public StoryID PlayingStoryID
    {
      [Token(Token = "0x600C671"), Address(RVA = "0x1CD6EB0", Offset = "0x1CD6EB0", VA = "0x1CD6EB0")] get
      {
        return new StoryID();
      }
      [Token(Token = "0x600C672"), Address(RVA = "0x1CD6EB8", Offset = "0x1CD6EB8", VA = "0x1CD6EB8")] private set
      {
      }
    }

    [Token(Token = "0x17002A82")]
    public StoryID LastPlayingStoryID
    {
      [Token(Token = "0x600C673"), Address(RVA = "0x1CD6EC0", Offset = "0x1CD6EC0", VA = "0x1CD6EC0")] get
      {
        return new StoryID();
      }
      [Token(Token = "0x600C674"), Address(RVA = "0x1CD6EC8", Offset = "0x1CD6EC8", VA = "0x1CD6EC8")] set
      {
      }
    }

    [Token(Token = "0x600C675")]
    [Address(RVA = "0x1CD6ED0", Offset = "0x1CD6ED0", VA = "0x1CD6ED0")]
    public void AppendLog(ref List<int> storySequenceList)
    {
    }

    [Token(Token = "0x600C676")]
    [Address(RVA = "0x1CD6FD0", Offset = "0x1CD6FD0", VA = "0x1CD6FD0")]
    public void PlayStory(StoryID storyID)
    {
    }

    [Token(Token = "0x600C677")]
    [Address(RVA = "0x1CD6FD8", Offset = "0x1CD6FD8", VA = "0x1CD6FD8")]
    public void StopStory()
    {
    }

    [Token(Token = "0x600C678")]
    [Address(RVA = "0x1CD6FE4", Offset = "0x1CD6FE4", VA = "0x1CD6FE4")]
    public void EndStory()
    {
    }
  }
}
