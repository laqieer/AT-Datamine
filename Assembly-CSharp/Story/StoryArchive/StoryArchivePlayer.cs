// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.StoryArchivePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Story.StoryArchive
{
  [Token(Token = "0x2000616")]
  public class StoryArchivePlayer
  {
    [Token(Token = "0x4001DD7")]
    [FieldOffset(Offset = "0x10")]
    private List<int> advIdList;
    [Token(Token = "0x4001DD8")]
    [FieldOffset(Offset = "0x18")]
    private StoryReplayCategoryTypeEnum categoryType;
    [Token(Token = "0x4001DD9")]
    [FieldOffset(Offset = "0x1C")]
    private int replayId;

    [Token(Token = "0x6002339")]
    [Address(RVA = "0x2DA40D0", Offset = "0x2DA40D0", VA = "0x2DA40D0")]
    public StoryArchivePlayer(int replayId)
    {
    }

    [Token(Token = "0x600233A")]
    [Address(RVA = "0x2DA44BC", Offset = "0x2DA44BC", VA = "0x2DA44BC")]
    public void Start()
    {
    }

    [Token(Token = "0x600233B")]
    [Address(RVA = "0x2DA4574", Offset = "0x2DA4574", VA = "0x2DA4574")]
    private IEnumerator Execute() => (IEnumerator) null;

    [Token(Token = "0x600233C")]
    [Address(RVA = "0x2DA4604", Offset = "0x2DA4604", VA = "0x2DA4604")]
    private void ToStoryArchive()
    {
    }

    [Token(Token = "0x600233D")]
    [Address(RVA = "0x2DA47A0", Offset = "0x2DA47A0", VA = "0x2DA47A0")]
    private void ToHome()
    {
    }

    [Token(Token = "0x2000617")]
    public class StoryArchivePlayingInfo
    {
      [Token(Token = "0x4001DDA")]
      [FieldOffset(Offset = "0x10")]
      public StoryReplayCategoryTypeEnum CategoryTypeEnum;
      [Token(Token = "0x4001DDB")]
      [FieldOffset(Offset = "0x14")]
      public int ArchiveId;

      [Token(Token = "0x6002340")]
      [Address(RVA = "0x2DA4898", Offset = "0x2DA4898", VA = "0x2DA4898")]
      public StoryArchivePlayingInfo()
      {
      }
    }
  }
}
