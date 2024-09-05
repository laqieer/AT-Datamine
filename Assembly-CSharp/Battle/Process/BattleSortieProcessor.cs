// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleSortieProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x20026A2")]
  public class BattleSortieProcessor
  {
    [Token(Token = "0x400A5B0")]
    [FieldOffset(Offset = "0x10")]
    private StoryBattleConfig config;
    [Token(Token = "0x400A5B1")]
    [FieldOffset(Offset = "0x18")]
    private BoardData board;
    [Token(Token = "0x400A5B2")]
    [FieldOffset(Offset = "0x20")]
    private IDirector mainDirector;
    [Token(Token = "0x400A5B3")]
    [FieldOffset(Offset = "0x28")]
    private bool isReinforceDirectionEnd;

    [Token(Token = "0x600EF58")]
    [Address(RVA = "0x40D6C24", Offset = "0x40D6C24", VA = "0x40D6C24")]
    private BattleSortieProcessor()
    {
    }

    [Token(Token = "0x600EF59")]
    [Address(RVA = "0x40D6C2C", Offset = "0x40D6C2C", VA = "0x40D6C2C")]
    public BattleSortieProcessor(StoryBattleConfig config, BoardData board, IDirector mainDirector)
    {
    }

    [Token(Token = "0x600EF5A")]
    [Address(RVA = "0x40D6C68", Offset = "0x40D6C68", VA = "0x40D6C68")]
    public void ApplyBoard(BoardData board)
    {
    }

    [Token(Token = "0x600EF5B")]
    [Address(RVA = "0x40D6C70", Offset = "0x40D6C70", VA = "0x40D6C70")]
    public UniTask<IReadOnlyList<UnitParameterData>> SortieTroops(int playerId, int troopsNum)
    {
      return new UniTask<IReadOnlyList<UnitParameterData>>();
    }

    [Token(Token = "0x600EF5C")]
    [Address(RVA = "0x40D6D4C", Offset = "0x40D6D4C", VA = "0x40D6D4C")]
    private Stack<GridData> CreateRouteGrid(
      UnitParameterData targetUnit,
      GridData from,
      GridData to)
    {
      return (Stack<GridData>) null;
    }
  }
}
