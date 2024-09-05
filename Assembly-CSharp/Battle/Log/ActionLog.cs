// Decompiled with JetBrains decompiler
// Type: Battle.Log.ActionLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x2002506")]
  public abstract class ActionLog : ILog
  {
    [Token(Token = "0x4009F27")]
    [FieldOffset(Offset = "0x10")]
    protected WeakReference<UnitParameterData> activeUnitRef;

    [Token(Token = "0x170030F1")]
    public abstract LogType LogType { [Token(Token = "0x600E499")] get; }

    [Token(Token = "0x170030F2")]
    public UnitParameterData ActiveUnit
    {
      [Token(Token = "0x600E49A"), Address(RVA = "0x47882C8", Offset = "0x47882C8", VA = "0x47882C8")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x600E49B")]
    [Address(RVA = "0x4788328", Offset = "0x4788328", VA = "0x4788328")]
    protected ActionLog()
    {
    }
  }
}
