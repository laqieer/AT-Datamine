// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGuildRelationSync
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AC3")]
  [Serializable]
  public class PlayerGuildRelationSync
  {
    [Token(Token = "0x40072B2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string join_cool_time_end_at;
    [Token(Token = "0x40072B3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string guild_id;
    [Token(Token = "0x40072B4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GuildFacilityType> guild_facilities;

    [Token(Token = "0x17001B08")]
    public string JoinCoolTimeEndAt
    {
      [Token(Token = "0x6009B4A"), Address(RVA = "0x48F1A64", Offset = "0x48F1A64", VA = "0x48F1A64")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009B4B"), Address(RVA = "0x48F1A6C", Offset = "0x48F1A6C", VA = "0x48F1A6C")] set
      {
      }
    }

    [Token(Token = "0x17001B09")]
    public string GuildId
    {
      [Token(Token = "0x6009B4C"), Address(RVA = "0x48F1A74", Offset = "0x48F1A74", VA = "0x48F1A74")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009B4D"), Address(RVA = "0x48F1A7C", Offset = "0x48F1A7C", VA = "0x48F1A7C")] set
      {
      }
    }

    [Token(Token = "0x17001B0A")]
    public List<GuildFacilityType> GuildFacilities
    {
      [Token(Token = "0x6009B4E"), Address(RVA = "0x48F1A84", Offset = "0x48F1A84", VA = "0x48F1A84")] get
      {
        return (List<GuildFacilityType>) null;
      }
      [Token(Token = "0x6009B4F"), Address(RVA = "0x48F1A8C", Offset = "0x48F1A8C", VA = "0x48F1A8C")] set
      {
      }
    }

    [Token(Token = "0x6009B50")]
    [Address(RVA = "0x48F1A94", Offset = "0x48F1A94", VA = "0x48F1A94")]
    public PlayerGuildRelationSync()
    {
    }
  }
}
