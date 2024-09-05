// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.InitialiazerForStoryBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200275F")]
  public class InitialiazerForStoryBattle : IBoardInitializer
  {
    [Token(Token = "0x400A855")]
    [FieldOffset(Offset = "0x10")]
    protected StoryBattleConfig config;
    [Token(Token = "0x400A856")]
    [FieldOffset(Offset = "0x18")]
    protected MapEditorData mapEditorData;

    [Token(Token = "0x600F637")]
    [Address(RVA = "0x1ED39C8", Offset = "0x1ED39C8", VA = "0x1ED39C8")]
    public InitialiazerForStoryBattle(StoryBattleConfig config, MapEditorData mapEditorData)
    {
    }

    [Token(Token = "0x600F638")]
    [Address(RVA = "0x1ED39F4", Offset = "0x1ED39F4", VA = "0x1ED39F4", Slot = "5")]
    public virtual void Initialize(BoardData board)
    {
    }

    [Token(Token = "0x600F639")]
    [Address(RVA = "0x1ED3B7C", Offset = "0x1ED3B7C", VA = "0x1ED3B7C")]
    protected List<GridData> GenerateGridMap(
      BattleData battleData,
      Vector2Int mapSize,
      Vector2Int offset)
    {
      return (List<GridData>) null;
    }
  }
}
