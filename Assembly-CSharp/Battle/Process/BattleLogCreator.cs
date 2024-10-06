// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleLogCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200269A")]
  public class BattleLogCreator
  {
    [Token(Token = "0x400A58D")]
    [FieldOffset(Offset = "0x10")]
    protected IReadOnlyDictionary<int, BattleLogTextFormatData> TextformatDataList;
    [Token(Token = "0x400A58E")]
    [FieldOffset(Offset = "0x18")]
    protected int turn;
    [Token(Token = "0x400A58F")]
    [FieldOffset(Offset = "0x20")]
    protected List<BattleLogData> battleLogDataList;
    [Token(Token = "0x400A590")]
    [FieldOffset(Offset = "0x28")]
    protected BoardData board;
    [Token(Token = "0x400A592")]
    [FieldOffset(Offset = "0x38")]
    protected bool IsDelay;
    [Token(Token = "0x400A593")]
    [FieldOffset(Offset = "0x39")]
    private bool IsFirstCommand;
    [Token(Token = "0x400A594")]
    [FieldOffset(Offset = "0x40")]
    protected Func<string> CRITICAL_TEXT;

    [Token(Token = "0x1700329E")]
    public BattleLogData BoardDataDescriptionData
    {
      [Token(Token = "0x600EF05"), Address(RVA = "0x40D0E80", Offset = "0x40D0E80", VA = "0x40D0E80")] get
      {
        return (BattleLogData) null;
      }
      [Token(Token = "0x600EF06"), Address(RVA = "0x40D0E88", Offset = "0x40D0E88", VA = "0x40D0E88")] private set
      {
      }
    }

    [Token(Token = "0x600EF07")]
    [Address(RVA = "0x40D0E90", Offset = "0x40D0E90", VA = "0x40D0E90")]
    public BattleLogCreator(
      IReadOnlyDictionary<int, BattleLogTextFormatData> dic,
      BoardData boardData)
    {
    }

    [Token(Token = "0x600EF08")]
    [Address(RVA = "0x40D0FD8", Offset = "0x40D0FD8", VA = "0x40D0FD8")]
    protected BattleLogTextFormatData GetFormatText(BattleLogTextTypeEnum logType, int ParamNum)
    {
      return (BattleLogTextFormatData) null;
    }

    [Token(Token = "0x600EF09")]
    [Address(RVA = "0x40D1138", Offset = "0x40D1138", VA = "0x40D1138")]
    protected void CreateLog(
      BattleLogTextTypeEnum logType,
      List<string> replace = null,
      int unitId1 = 0,
      int unitId2 = 0,
      int turn = 0,
      int paramNum = 0,
      bool isCommand = false)
    {
    }

    [Token(Token = "0x600EF0A")]
    [Address(RVA = "0x40D1310", Offset = "0x40D1310", VA = "0x40D1310")]
    private void CreateBoardDataDescription(BattleLogData battleLogData, bool isCommand)
    {
    }
  }
}
