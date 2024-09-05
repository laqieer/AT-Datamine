// Decompiled with JetBrains decompiler
// Type: Battle.Process.StoryBattleDecision
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002686")]
  public class StoryBattleDecision : BattleDecision
  {
    [Token(Token = "0x600EE7C")]
    [Address(RVA = "0x4447918", Offset = "0x4447918", VA = "0x4447918", Slot = "4")]
    public override BattleResult Check(BattleCore core) => new BattleResult();

    [Token(Token = "0x600EE7D")]
    [Address(RVA = "0x4448250", Offset = "0x4448250", VA = "0x4448250")]
    private bool CheckWin(BoardData board, BattlePlayerData player) => new bool();

    [Token(Token = "0x600EE7E")]
    [Address(RVA = "0x444797C", Offset = "0x444797C", VA = "0x444797C")]
    private bool CheckLose(BoardData board, BattlePlayerData player) => new bool();

    [Token(Token = "0x600EE7F")]
    [Address(RVA = "0x4448774", Offset = "0x4448774", VA = "0x4448774")]
    public StoryBattleDecision()
    {
    }
  }
}
