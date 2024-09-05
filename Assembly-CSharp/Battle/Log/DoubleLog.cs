// Decompiled with JetBrains decompiler
// Type: Battle.Log.DoubleLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x2002509")]
  public sealed class DoubleLog : ActionLog
  {
    [Token(Token = "0x4009F2A")]
    [FieldOffset(Offset = "0x18")]
    private WeakReference<UnitParameterData> targetUnitRef;
    [Token(Token = "0x4009F2B")]
    [FieldOffset(Offset = "0x20")]
    private WeakReference<IGridData> doubledGridRef;

    [Token(Token = "0x170030F7")]
    public override LogType LogType
    {
      [Token(Token = "0x600E4A3"), Address(RVA = "0x4788468", Offset = "0x4788468", VA = "0x4788468", Slot = "5")] get
      {
        return new LogType();
      }
    }

    [Token(Token = "0x170030F8")]
    public UnitParameterData TargetUnit
    {
      [Token(Token = "0x600E4A4"), Address(RVA = "0x4788470", Offset = "0x4788470", VA = "0x4788470")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x170030F9")]
    public IGridData DoubledGrid
    {
      [Token(Token = "0x600E4A5"), Address(RVA = "0x47884D0", Offset = "0x47884D0", VA = "0x47884D0")] get
      {
        return (IGridData) null;
      }
    }

    [Token(Token = "0x600E4A6")]
    [Address(RVA = "0x4788530", Offset = "0x4788530", VA = "0x4788530")]
    public DoubleLog(
      UnitParameterData unit,
      UnitParameterData targetUnit,
      IGridData moveFromGrid,
      IGridData doubledGrid)
    {
    }
  }
}
