// Decompiled with JetBrains decompiler
// Type: Battle.Log.MoveLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x2002519")]
  public sealed class MoveLog : ActionLog
  {
    [Token(Token = "0x4009F62")]
    [FieldOffset(Offset = "0x18")]
    private WeakReference<IGridData> preGridRef;
    [Token(Token = "0x4009F63")]
    [FieldOffset(Offset = "0x20")]
    private WeakReference<IGridData> moveTargetGridRef;
    [Token(Token = "0x4009F64")]
    [FieldOffset(Offset = "0x28")]
    private WeakReference<IGridData> postGridRef;

    [Token(Token = "0x17003117")]
    public override LogType LogType
    {
      [Token(Token = "0x600E50E"), Address(RVA = "0x4790584", Offset = "0x4790584", VA = "0x4790584", Slot = "5")] get
      {
        return new LogType();
      }
    }

    [Token(Token = "0x17003118")]
    public IGridData PreGrid
    {
      [Token(Token = "0x600E50F"), Address(RVA = "0x479058C", Offset = "0x479058C", VA = "0x479058C")] get
      {
        return (IGridData) null;
      }
    }

    [Token(Token = "0x17003119")]
    public IGridData MoveTargetGrid
    {
      [Token(Token = "0x600E510"), Address(RVA = "0x47905EC", Offset = "0x47905EC", VA = "0x47905EC")] get
      {
        return (IGridData) null;
      }
    }

    [Token(Token = "0x1700311A")]
    public IGridData PostGrid
    {
      [Token(Token = "0x600E511"), Address(RVA = "0x479064C", Offset = "0x479064C", VA = "0x479064C")] get
      {
        return (IGridData) null;
      }
    }

    [Token(Token = "0x600E512")]
    [Address(RVA = "0x47906AC", Offset = "0x47906AC", VA = "0x47906AC")]
    public MoveLog(
      UnitParameterData unit,
      IGridData preGrid,
      IGridData moveTargetGrid,
      IGridData postGrid)
    {
    }
  }
}
