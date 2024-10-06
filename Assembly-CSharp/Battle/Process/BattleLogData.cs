// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleLogData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200269D")]
  public class BattleLogData
  {
    [Token(Token = "0x400A599")]
    [FieldOffset(Offset = "0x10")]
    public BattleLogTextTypeEnum LogType;
    [Token(Token = "0x400A59A")]
    [FieldOffset(Offset = "0x14")]
    public int TextFormatDataID;
    [Token(Token = "0x400A59B")]
    [FieldOffset(Offset = "0x18")]
    public List<string> ReplaceTextList;
    [Token(Token = "0x400A59C")]
    [FieldOffset(Offset = "0x20")]
    public int ActionUnitId;
    [Token(Token = "0x400A59D")]
    [FieldOffset(Offset = "0x24")]
    public int TargetUnitId;
    [Token(Token = "0x400A59E")]
    [FieldOffset(Offset = "0x28")]
    public int Turn;
    [Token(Token = "0x400A59F")]
    [FieldOffset(Offset = "0x2C")]
    public int ParamNum;
    [Token(Token = "0x400A5A0")]
    [FieldOffset(Offset = "0x30")]
    public bool IsDelay;

    [Token(Token = "0x600EF10")]
    [Address(RVA = "0x40D12A0", Offset = "0x40D12A0", VA = "0x40D12A0")]
    public BattleLogData(
      BattleLogTextTypeEnum type,
      int textFormatDataID,
      List<string> replaceTextList,
      int actionUnitId,
      int targetUnitId,
      int turn,
      int paramNum,
      bool isDelay = false)
    {
    }

    [Token(Token = "0x600EF11")]
    [Address(RVA = "0x40D1430", Offset = "0x40D1430", VA = "0x40D1430")]
    public string ToString(BoardData board) => (string) null;

    [Token(Token = "0x600EF12")]
    [Address(RVA = "0x40D1968", Offset = "0x40D1968", VA = "0x40D1968")]
    public string ToStringExceptUnit(BoardData board) => (string) null;

    [Token(Token = "0x600EF13")]
    [Address(RVA = "0x40D1840", Offset = "0x40D1840", VA = "0x40D1840")]
    public string SetColorUnitName(UnitParameterData unit) => (string) null;
  }
}
