// Decompiled with JetBrains decompiler
// Type: Battle.Log.SwitchLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x200251F")]
  public sealed class SwitchLog : ActionLog
  {
    [Token(Token = "0x4009F72")]
    [FieldOffset(Offset = "0x18")]
    private WeakReference<UnitParameterData> targetUnitRef;

    [Token(Token = "0x17003128")]
    public override LogType LogType
    {
      [Token(Token = "0x600E527"), Address(RVA = "0x4790E5C", Offset = "0x4790E5C", VA = "0x4790E5C", Slot = "5")] get
      {
        return new LogType();
      }
    }

    [Token(Token = "0x17003129")]
    public UnitParameterData TargetUnit
    {
      [Token(Token = "0x600E528"), Address(RVA = "0x4790E64", Offset = "0x4790E64", VA = "0x4790E64")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x600E529")]
    [Address(RVA = "0x4790EC4", Offset = "0x4790EC4", VA = "0x4790EC4")]
    public SwitchLog(UnitParameterData unit, UnitParameterData targetUnit)
    {
    }
  }
}
