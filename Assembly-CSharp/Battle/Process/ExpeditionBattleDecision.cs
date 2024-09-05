// Decompiled with JetBrains decompiler
// Type: Battle.Process.ExpeditionBattleDecision
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200268A")]
  public class ExpeditionBattleDecision : BattleDecision
  {
    [Token(Token = "0x600EE91")]
    [Address(RVA = "0x4448E38", Offset = "0x4448E38", VA = "0x4448E38", Slot = "4")]
    public override BattleResult Check(BattleCore core) => new BattleResult();

    [Token(Token = "0x600EE92")]
    [Address(RVA = "0x4449278", Offset = "0x4449278", VA = "0x4449278")]
    private bool CheckWin(BoardData board, BattlePlayerData player) => new bool();

    [Token(Token = "0x600EE93")]
    [Address(RVA = "0x44491DC", Offset = "0x44491DC", VA = "0x44491DC")]
    private bool CheckUserLose(BoardData board) => new bool();

    [Token(Token = "0x600EE94")]
    [Address(RVA = "0x444938C", Offset = "0x444938C", VA = "0x444938C")]
    public ExpeditionBattleDecision()
    {
    }
  }
}
