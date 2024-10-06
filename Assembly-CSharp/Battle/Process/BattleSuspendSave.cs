// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleSuspendSave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x20026AD")]
  public class BattleSuspendSave
  {
    [Token(Token = "0x400A5DC")]
    public const string FileName = "board_data.dat";
    [Token(Token = "0x400A5DD")]
    public const string RollbackFileName = "roll_data.dat";
    [Token(Token = "0x400A5DE")]
    public const string BattleLogFileName = "log_data.dat";
    [Token(Token = "0x400A5DF")]
    [FieldOffset(Offset = "0x10")]
    private BoardData boardData;

    [Token(Token = "0x600EF7E")]
    [Address(RVA = "0x40D9D04", Offset = "0x40D9D04", VA = "0x40D9D04")]
    private BattleSuspendSave()
    {
    }

    [Token(Token = "0x600EF7F")]
    [Address(RVA = "0x40D9D0C", Offset = "0x40D9D0C", VA = "0x40D9D0C")]
    public BattleSuspendSave(BoardData board)
    {
    }

    [Token(Token = "0x600EF80")]
    [Address(RVA = "0x40D9D34", Offset = "0x40D9D34", VA = "0x40D9D34")]
    public void ApplyBoard(BoardData board)
    {
    }

    [Token(Token = "0x600EF81")]
    [Address(RVA = "0x40D9D3C", Offset = "0x40D9D3C", VA = "0x40D9D3C")]
    public void SaveBoard(PhaseCode resumePhase, Queue<UnitCommandBase> commands = null)
    {
    }

    [Token(Token = "0x600EF82")]
    [Address(RVA = "0x40D9E4C", Offset = "0x40D9E4C", VA = "0x40D9E4C")]
    public void SaveRollbackData(IRollbackProcessor rollback)
    {
    }

    [Token(Token = "0x600EF83")]
    [Address(RVA = "0x40D9F54", Offset = "0x40D9F54", VA = "0x40D9F54")]
    public void SaveBattleLogData(BattleLogProcessor battleLog)
    {
    }

    [Token(Token = "0x600EF84")]
    [Address(RVA = "0x40DA00C", Offset = "0x40DA00C", VA = "0x40DA00C")]
    public void LoadRollbackData(ref IRollbackProcessor rollback)
    {
    }

    [Token(Token = "0x600EF85")]
    [Address(RVA = "0x40DA1A0", Offset = "0x40DA1A0", VA = "0x40DA1A0")]
    public void LoadBattleLogData(ref BattleLogProcessor battleLog)
    {
    }
  }
}
