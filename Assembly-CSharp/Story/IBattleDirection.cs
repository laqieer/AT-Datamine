// Decompiled with JetBrains decompiler
// Type: Story.IBattleDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Story
{
  [Token(Token = "0x200055F")]
  public interface IBattleDirection : IDirection
  {
    [Token(Token = "0x6001F02")]
    QuestTypeEnum GetTypeEnum();

    [Token(Token = "0x6001F03")]
    List<int> GetTargetQuestIDs();
  }
}
