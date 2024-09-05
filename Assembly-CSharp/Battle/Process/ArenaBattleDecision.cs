// Decompiled with JetBrains decompiler
// Type: Battle.Process.ArenaBattleDecision
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200268D")]
  public class ArenaBattleDecision : BattleDecision
  {
    [Token(Token = "0x600EE9C")]
    [Address(RVA = "0x4449570", Offset = "0x4449570", VA = "0x4449570", Slot = "4")]
    public override BattleResult Check(BattleCore core) => new BattleResult();

    [Token(Token = "0x600EE9D")]
    [Address(RVA = "0x4449998", Offset = "0x4449998", VA = "0x4449998")]
    private bool CheckWin(BoardData board, BattlePlayerData player) => new bool();

    [Token(Token = "0x600EE9E")]
    [Address(RVA = "0x4449EB4", Offset = "0x4449EB4", VA = "0x4449EB4")]
    public ArenaBattleDecision()
    {
    }
  }
}
