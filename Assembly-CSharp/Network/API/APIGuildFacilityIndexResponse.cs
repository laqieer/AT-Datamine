// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildFacilityIndexResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CC0")]
  [Serializable]
  public class APIGuildFacilityIndexResponse
  {
    [Token(Token = "0x4007AE7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GuildFacilityType> guild_facilities;
    [Token(Token = "0x4007AE8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int invest_count;
    [Token(Token = "0x4007AE9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<int> level_changed_facility_ids;

    [Token(Token = "0x17002079")]
    public List<GuildFacilityType> GuildFacilities
    {
      [Token(Token = "0x600A962"), Address(RVA = "0x1915274", Offset = "0x1915274", VA = "0x1915274")] get
      {
        return (List<GuildFacilityType>) null;
      }
    }

    [Token(Token = "0x1700207A")]
    public int InvestCount
    {
      [Token(Token = "0x600A963"), Address(RVA = "0x191527C", Offset = "0x191527C", VA = "0x191527C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700207B")]
    public List<int> LevelChangedFacilityIds
    {
      [Token(Token = "0x600A964"), Address(RVA = "0x1915284", Offset = "0x1915284", VA = "0x1915284")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600A965")]
    [Address(RVA = "0x191528C", Offset = "0x191528C", VA = "0x191528C")]
    public APIGuildFacilityIndexResponse()
    {
    }
  }
}
