// Decompiled with JetBrains decompiler
// Type: Battle.Log.EffectLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x200250D")]
  public class EffectLog : ILog
  {
    [Token(Token = "0x4009F36")]
    [FieldOffset(Offset = "0x10")]
    protected WeakReference<UnitParameterData> targetRef;

    [Token(Token = "0x170030FF")]
    public virtual LogType LogType
    {
      [Token(Token = "0x600E4B4"), Address(RVA = "0x4788FF0", Offset = "0x4788FF0", VA = "0x4788FF0", Slot = "5")] get
      {
        return new LogType();
      }
    }

    [Token(Token = "0x17003100")]
    public UnitParameterData Target
    {
      [Token(Token = "0x600E4B5"), Address(RVA = "0x4788FF8", Offset = "0x4788FF8", VA = "0x4788FF8")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x17003101")]
    public UnitParameterChange BeginParam
    {
      [Token(Token = "0x600E4B6"), Address(RVA = "0x4789058", Offset = "0x4789058", VA = "0x4789058")] get
      {
        return (UnitParameterChange) null;
      }
      [Token(Token = "0x600E4B7"), Address(RVA = "0x4789060", Offset = "0x4789060", VA = "0x4789060")] protected set
      {
      }
    }

    [Token(Token = "0x17003102")]
    public UnitParameterChange EndParam
    {
      [Token(Token = "0x600E4B8"), Address(RVA = "0x4789068", Offset = "0x4789068", VA = "0x4789068")] get
      {
        return (UnitParameterChange) null;
      }
      [Token(Token = "0x600E4B9"), Address(RVA = "0x4789070", Offset = "0x4789070", VA = "0x4789070")] protected set
      {
      }
    }

    [Token(Token = "0x600E4BA")]
    [Address(RVA = "0x4789078", Offset = "0x4789078", VA = "0x4789078")]
    public EffectLog(UnitParameterData target, UnitParameterChange begin, UnitParameterChange end)
    {
    }
  }
}
