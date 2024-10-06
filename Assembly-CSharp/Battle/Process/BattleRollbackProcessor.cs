// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleRollbackProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Il2CppDummyDll;
using staq.SaveSchema;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x20026A1")]
  public class BattleRollbackProcessor : IRollbackProcessor, IDisposable
  {
    [Token(Token = "0x400A5A9")]
    [FieldOffset(Offset = "0x10")]
    private BattleCore core;
    [Token(Token = "0x400A5AE")]
    [FieldOffset(Offset = "0x30")]
    private int maxSaveTurn;
    [Token(Token = "0x400A5AF")]
    [FieldOffset(Offset = "0x34")]
    public bool NeedSaveDirty;

    [Token(Token = "0x170032A1")]
    public List<Battle.Data.Board.BoardData> backupPerTurn
    {
      [Token(Token = "0x600EF44"), Address(RVA = "0x40D5644", Offset = "0x40D5644", VA = "0x40D5644")] get
      {
        return (List<Battle.Data.Board.BoardData>) null;
      }
      [Token(Token = "0x600EF45"), Address(RVA = "0x40D564C", Offset = "0x40D564C", VA = "0x40D564C")] private set
      {
      }
    }

    [Token(Token = "0x170032A2")]
    public List<Battle.Data.Board.BoardData> backupPerAction
    {
      [Token(Token = "0x600EF46"), Address(RVA = "0x40D5654", Offset = "0x40D5654", VA = "0x40D5654")] get
      {
        return (List<Battle.Data.Board.BoardData>) null;
      }
      [Token(Token = "0x600EF47"), Address(RVA = "0x40D565C", Offset = "0x40D565C", VA = "0x40D565C")] private set
      {
      }
    }

    [Token(Token = "0x170032A3")]
    public int InitialCount
    {
      [Token(Token = "0x600EF48"), Address(RVA = "0x40D5664", Offset = "0x40D5664", VA = "0x40D5664")] get
      {
        return new int();
      }
      [Token(Token = "0x600EF49"), Address(RVA = "0x40D566C", Offset = "0x40D566C", VA = "0x40D566C")] private set
      {
      }
    }

    [Token(Token = "0x170032A4")]
    public int RollbackCount
    {
      [Token(Token = "0x600EF4A"), Address(RVA = "0x40D5674", Offset = "0x40D5674", VA = "0x40D5674", Slot = "5")] get
      {
        return new int();
      }
      [Token(Token = "0x600EF4B"), Address(RVA = "0x40D567C", Offset = "0x40D567C", VA = "0x40D567C")] private set
      {
      }
    }

    [Token(Token = "0x170032A5")]
    public List<Battle.Data.Board.BoardData> BackupBoard
    {
      [Token(Token = "0x600EF4C"), Address(RVA = "0x40D5684", Offset = "0x40D5684", VA = "0x40D5684", Slot = "4")] get
      {
        return (List<Battle.Data.Board.BoardData>) null;
      }
    }

    [Token(Token = "0x600EF4D")]
    [Address(RVA = "0x40D56F0", Offset = "0x40D56F0", VA = "0x40D56F0")]
    public BattleRollbackProcessor(BattleCore core)
    {
    }

    [Token(Token = "0x600EF4E")]
    [Address(RVA = "0x40D5824", Offset = "0x40D5824", VA = "0x40D5824", Slot = "10")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600EF4F")]
    [Address(RVA = "0x40D582C", Offset = "0x40D582C", VA = "0x40D582C", Slot = "6")]
    public void BackupCurrentBoard(Queue<UnitCommandBase> executedCommand = null)
    {
    }

    [Token(Token = "0x600EF50")]
    [Address(RVA = "0x40D5998", Offset = "0x40D5998", VA = "0x40D5998")]
    private void BackupTheTurn(Battle.Data.Board.BoardData board)
    {
    }

    [Token(Token = "0x600EF51")]
    [Address(RVA = "0x40D58C0", Offset = "0x40D58C0", VA = "0x40D58C0")]
    private void BackupTheAction(Battle.Data.Board.BoardData board)
    {
    }

    [Token(Token = "0x600EF52")]
    [Address(RVA = "0x40D5DAC", Offset = "0x40D5DAC", VA = "0x40D5DAC", Slot = "9")]
    public void ApplyBoard(int index)
    {
    }

    [Token(Token = "0x600EF53")]
    [Address(RVA = "0x40D5E84", Offset = "0x40D5E84", VA = "0x40D5E84", Slot = "7")]
    public void RollbackBoard(int index)
    {
    }

    [Token(Token = "0x600EF54")]
    [Address(RVA = "0x40D5FE0", Offset = "0x40D5FE0", VA = "0x40D5FE0", Slot = "8")]
    public void RollbackOne()
    {
    }

    [Token(Token = "0x600EF55")]
    [Address(RVA = "0x40D6088", Offset = "0x40D6088", VA = "0x40D6088")]
    public void Resume()
    {
    }

    [Token(Token = "0x600EF56")]
    [Address(RVA = "0x40D6630", Offset = "0x40D6630", VA = "0x40D6630")]
    public byte[] Serialize() => (byte[]) null;

    [Token(Token = "0x600EF57")]
    [Address(RVA = "0x40D68E4", Offset = "0x40D68E4", VA = "0x40D68E4")]
    public void Deserialize(RollbackData schema)
    {
    }
  }
}
