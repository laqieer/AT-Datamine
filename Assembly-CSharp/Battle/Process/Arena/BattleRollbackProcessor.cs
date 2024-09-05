// Decompiled with JetBrains decompiler
// Type: Battle.Process.Arena.BattleRollbackProcessor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process.Arena
{
  [Token(Token = "0x20026DA")]
  public class BattleRollbackProcessor : IRollbackProcessor, IDisposable
  {
    [Token(Token = "0x400A640")]
    [FieldOffset(Offset = "0x10")]
    private BattleCore core;

    [Token(Token = "0x170032BC")]
    public BoardData initialBoard
    {
      [Token(Token = "0x600F05B"), Address(RVA = "0x41A5320", Offset = "0x41A5320", VA = "0x41A5320")] get
      {
        return (BoardData) null;
      }
      [Token(Token = "0x600F05C"), Address(RVA = "0x41A5328", Offset = "0x41A5328", VA = "0x41A5328")] private set
      {
      }
    }

    [Token(Token = "0x170032BD")]
    public int RollbackCount
    {
      [Token(Token = "0x600F05D"), Address(RVA = "0x41A5330", Offset = "0x41A5330", VA = "0x41A5330", Slot = "5")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170032BE")]
    public List<BoardData> BackupBoard
    {
      [Token(Token = "0x600F05E"), Address(RVA = "0x41A5338", Offset = "0x41A5338", VA = "0x41A5338", Slot = "4")] get
      {
        return (List<BoardData>) null;
      }
    }

    [Token(Token = "0x600F05F")]
    [Address(RVA = "0x41A5418", Offset = "0x41A5418", VA = "0x41A5418")]
    public BattleRollbackProcessor(BattleCore core)
    {
    }

    [Token(Token = "0x600F060")]
    [Address(RVA = "0x41A5440", Offset = "0x41A5440", VA = "0x41A5440", Slot = "10")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600F061")]
    [Address(RVA = "0x41A5448", Offset = "0x41A5448", VA = "0x41A5448", Slot = "6")]
    public void BackupCurrentBoard(Queue<UnitCommandBase> executedCommand = null)
    {
    }

    [Token(Token = "0x600F062")]
    [Address(RVA = "0x41A5480", Offset = "0x41A5480", VA = "0x41A5480", Slot = "9")]
    public void ApplyBoard(int index)
    {
    }

    [Token(Token = "0x600F063")]
    [Address(RVA = "0x41A54B8", Offset = "0x41A54B8", VA = "0x41A54B8", Slot = "7")]
    public void RollbackBoard(int index)
    {
    }

    [Token(Token = "0x600F064")]
    [Address(RVA = "0x41A54BC", Offset = "0x41A54BC", VA = "0x41A54BC", Slot = "8")]
    public void RollbackOne()
    {
    }
  }
}
