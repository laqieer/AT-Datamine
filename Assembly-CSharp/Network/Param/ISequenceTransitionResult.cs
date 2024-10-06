// Decompiled with JetBrains decompiler
// Type: Network.Param.ISequenceTransitionResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A74")]
  public interface ISequenceTransitionResult
  {
    [Token(Token = "0x170019B8")]
    PlayerStoryChapterType PlayerChapter { [Token(Token = "0x6009873")] get; }

    [Token(Token = "0x170019B9")]
    PlayerFreeActionSequenceStatus PlayerFreeaction { [Token(Token = "0x6009874")] get; }

    [Token(Token = "0x170019BA")]
    PlayerAreaMapObjectStatus PlayerAreaMap { [Token(Token = "0x6009875")] get; }

    [Token(Token = "0x170019BB")]
    List<PlayerStorySubQuestType> AbortedSubquests { [Token(Token = "0x6009876")] get; }

    [Token(Token = "0x170019BC")]
    List<string> ReleasedStoryGachaTitles { [Token(Token = "0x6009877")] get; }
  }
}
