// Decompiled with JetBrains decompiler
// Type: Network.Param.GuildFacilityType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A63")]
  [Serializable]
  public class GuildFacilityType
  {
    [Token(Token = "0x400710B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int facility_id;
    [Token(Token = "0x400710C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int experience;

    [Token(Token = "0x17001941")]
    public int FacilityId
    {
      [Token(Token = "0x600977B"), Address(RVA = "0x48EFA38", Offset = "0x48EFA38", VA = "0x48EFA38")] get
      {
        return new int();
      }
      [Token(Token = "0x600977C"), Address(RVA = "0x48EFA40", Offset = "0x48EFA40", VA = "0x48EFA40")] set
      {
      }
    }

    [Token(Token = "0x17001942")]
    public int Experience
    {
      [Token(Token = "0x600977D"), Address(RVA = "0x48EFA48", Offset = "0x48EFA48", VA = "0x48EFA48")] get
      {
        return new int();
      }
      [Token(Token = "0x600977E"), Address(RVA = "0x48EFA50", Offset = "0x48EFA50", VA = "0x48EFA50")] set
      {
      }
    }

    [Token(Token = "0x600977F")]
    [Address(RVA = "0x48EFA58", Offset = "0x48EFA58", VA = "0x48EFA58")]
    public GuildFacilityType()
    {
    }
  }
}
