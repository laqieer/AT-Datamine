﻿// Decompiled with JetBrains decompiler
// Type: Story.IFreeMapDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000560")]
  public interface IFreeMapDirection : IDirection
  {
    [Token(Token = "0x6001F04")]
    StoryChapterData GetChapter();

    [Token(Token = "0x6001F05")]
    StoryMainQuestSequenceData GetSequence();

    [Token(Token = "0x6001F06")]
    StoryFreeActionSettingData GetSetting();
  }
}
