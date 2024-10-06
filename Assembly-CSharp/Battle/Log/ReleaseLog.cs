// Decompiled with JetBrains decompiler
// Type: Battle.Log.ReleaseLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x200251A")]
  public sealed class ReleaseLog : ActionLog
  {
    [Token(Token = "0x4009F65")]
    [FieldOffset(Offset = "0x18")]
    private WeakReference<UnitParameterData> targetUnitRef;
    [Token(Token = "0x4009F66")]
    [FieldOffset(Offset = "0x20")]
    private WeakReference<IGridData> releaseToGridRef;

    [Token(Token = "0x1700311B")]
    public override LogType LogType
    {
      [Token(Token = "0x600E513"), Address(RVA = "0x47907D8", Offset = "0x47907D8", VA = "0x47907D8", Slot = "5")] get
      {
        return new LogType();
      }
    }

    [Token(Token = "0x1700311C")]
    public UnitParameterData TargetUnit
    {
      [Token(Token = "0x600E514"), Address(RVA = "0x47907E0", Offset = "0x47907E0", VA = "0x47907E0")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x1700311D")]
    public IGridData ReleaseToGrid
    {
      [Token(Token = "0x600E515"), Address(RVA = "0x4790840", Offset = "0x4790840", VA = "0x4790840")] get
      {
        return (IGridData) null;
      }
    }

    [Token(Token = "0x600E516")]
    [Address(RVA = "0x47908A0", Offset = "0x47908A0", VA = "0x47908A0")]
    public ReleaseLog(UnitParameterData unit, IGridData releaseToGrid)
    {
    }
  }
}
