// Decompiled with JetBrains decompiler
// Type: Battle.Log.Team
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x200250B")]
  public class Team
  {
    [Token(Token = "0x4009F33")]
    [FieldOffset(Offset = "0x10")]
    private WeakReference<UnitParameterData> frontRef;
    [Token(Token = "0x4009F34")]
    [FieldOffset(Offset = "0x18")]
    private WeakReference<UnitParameterData> rearRef;
    [Token(Token = "0x4009F35")]
    [FieldOffset(Offset = "0x20")]
    private List<WeakReference<UnitParameterData>> supportsRef;

    [Token(Token = "0x170030FD")]
    public UnitParameterData Front
    {
      [Token(Token = "0x600E4AD"), Address(RVA = "0x478879C", Offset = "0x478879C", VA = "0x478879C")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x170030FE")]
    public UnitParameterData Rear
    {
      [Token(Token = "0x600E4AE"), Address(RVA = "0x47887FC", Offset = "0x47887FC", VA = "0x47887FC")] get
      {
        return (UnitParameterData) null;
      }
    }

    [Token(Token = "0x600E4AF")]
    [Address(RVA = "0x478885C", Offset = "0x478885C", VA = "0x478885C")]
    public IReadOnlyList<UnitParameterData> GetSupports()
    {
      return (IReadOnlyList<UnitParameterData>) null;
    }

    [Token(Token = "0x600E4B0")]
    [Address(RVA = "0x4788C10", Offset = "0x4788C10", VA = "0x4788C10")]
    public Team(
      UnitParameterData front,
      UnitParameterData rear,
      IReadOnlyList<UnitParameterData> supports)
    {
    }

    [Token(Token = "0x600E4B1")]
    [Address(RVA = "0x4788F20", Offset = "0x4788F20", VA = "0x4788F20")]
    public Team(UnitParameterData front, IReadOnlyList<UnitParameterData> supports)
    {
    }
  }
}
