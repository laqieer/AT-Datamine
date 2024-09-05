// Decompiled with JetBrains decompiler
// Type: Story.Chart.INodeStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006CD")]
  public interface INodeStatus
  {
    [Token(Token = "0x600267A")]
    bool IsLock(StoryMainQuestSequenceData sequence);

    [Token(Token = "0x600267B")]
    bool IsInactive(StoryMainQuestSequenceData sequence);

    [Token(Token = "0x600267C")]
    bool IsHighlight(StoryMainQuestSequenceData sequence);

    [Token(Token = "0x600267D")]
    bool IsHighlight(StoryMainQuestSequenceData from, StoryMainQuestSequenceData to);

    [Token(Token = "0x600267E")]
    bool IsHere(StoryMainQuestSequenceData sequence);
  }
}
