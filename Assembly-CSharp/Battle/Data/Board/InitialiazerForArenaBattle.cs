// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.InitialiazerForArenaBattle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002763")]
  public class InitialiazerForArenaBattle : IBoardInitializer
  {
    [Token(Token = "0x400A85B")]
    [FieldOffset(Offset = "0x10")]
    protected ArenaBattleConfig config;
    [Token(Token = "0x400A85C")]
    [FieldOffset(Offset = "0x18")]
    protected MapEditorData mapEditorData;

    [Token(Token = "0x600F640")]
    [Address(RVA = "0x1ED434C", Offset = "0x1ED434C", VA = "0x1ED434C")]
    public InitialiazerForArenaBattle(ArenaBattleConfig config, MapEditorData mapEditorData)
    {
    }

    [Token(Token = "0x600F641")]
    [Address(RVA = "0x1ED4378", Offset = "0x1ED4378", VA = "0x1ED4378", Slot = "5")]
    public virtual void Initialize(BoardData board)
    {
    }

    [Token(Token = "0x600F642")]
    [Address(RVA = "0x1ED44C4", Offset = "0x1ED44C4", VA = "0x1ED44C4")]
    protected List<GridData> GenerateGridMap(
      BattleData battleData,
      Vector2Int mapSize,
      Vector2Int offset)
    {
      return (List<GridData>) null;
    }
  }
}
