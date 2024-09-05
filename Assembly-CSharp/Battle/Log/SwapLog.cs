// Decompiled with JetBrains decompiler
// Type: Battle.Log.SwapLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x200251E")]
  public sealed class SwapLog : ActionLog
  {
    [Token(Token = "0x4009F71")]
    [FieldOffset(Offset = "0x18")]
    private WeakReference<UnitParameterData> targetUnitRef;

    [Token(Token = "0x17003126")]
    public override LogType LogType
    {
      [Token(Token = "0x600E524"), Address(RVA = "0x4790D38", Offset = "0x4790D38", VA = "0x4790D38", Slot = "5")] get
      {
        return new LogType();
      }
    }

    [Token(Token = "0x17003127")]
    public UnitParameterData TargetUnit
    {
      [Token(Token = "0x600E525"), Address(RVA = "0x4790D40", Offset = "0x4790D40", VA = "0x4790D40")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x600E526")]
    [Address(RVA = "0x4790DA0", Offset = "0x4790DA0", VA = "0x4790DA0")]
    public SwapLog(UnitParameterData unit, UnitParameterData targetUnit)
    {
    }
  }
}
