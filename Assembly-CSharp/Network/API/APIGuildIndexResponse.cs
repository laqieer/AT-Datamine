// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildIndexResponse
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
  [Token(Token = "0x2001CD8")]
  [Serializable]
  public class APIGuildIndexResponse : ICommonApiResult
  {
    [Token(Token = "0x4007B43")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007B44")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildType guild;
    [Token(Token = "0x4007B45")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GuildMemberType> members;
    [Token(Token = "0x4007B46")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<GuildFacilityType> guild_facilities;
    [Token(Token = "0x4007B47")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<int> guild_emblem_ids;
    [Token(Token = "0x4007B48")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<int> guild_title_ids;
    [Token(Token = "0x4007B49")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private bool exists_any_new_join_requests;
    [Token(Token = "0x4007B4A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<int> level_changed_facility_ids;
    [Token(Token = "0x4007B4B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private bool is_today_attended;

    [Token(Token = "0x170020AC")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A9F5"), Address(RVA = "0x19172B4", Offset = "0x19172B4", VA = "0x19172B4", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170020AD")]
    public GuildType Guild
    {
      [Token(Token = "0x600A9F6"), Address(RVA = "0x19172BC", Offset = "0x19172BC", VA = "0x19172BC")] get
      {
        return (GuildType) null;
      }
    }

    [Token(Token = "0x170020AE")]
    public List<GuildMemberType> Members
    {
      [Token(Token = "0x600A9F7"), Address(RVA = "0x19172C4", Offset = "0x19172C4", VA = "0x19172C4")] get
      {
        return (List<GuildMemberType>) null;
      }
    }

    [Token(Token = "0x170020AF")]
    public List<GuildFacilityType> GuildFacilities
    {
      [Token(Token = "0x600A9F8"), Address(RVA = "0x19172CC", Offset = "0x19172CC", VA = "0x19172CC")] get
      {
        return (List<GuildFacilityType>) null;
      }
    }

    [Token(Token = "0x170020B0")]
    public List<int> GuildEmblemIds
    {
      [Token(Token = "0x600A9F9"), Address(RVA = "0x19172D4", Offset = "0x19172D4", VA = "0x19172D4")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x170020B1")]
    public List<int> GuildTitleIds
    {
      [Token(Token = "0x600A9FA"), Address(RVA = "0x19172DC", Offset = "0x19172DC", VA = "0x19172DC")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x170020B2")]
    public bool ExistsAnyNewJoinRequests
    {
      [Token(Token = "0x600A9FB"), Address(RVA = "0x19172E4", Offset = "0x19172E4", VA = "0x19172E4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020B3")]
    public List<int> LevelChangedFacilityIds
    {
      [Token(Token = "0x600A9FC"), Address(RVA = "0x19172EC", Offset = "0x19172EC", VA = "0x19172EC")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x170020B4")]
    public bool IsTodayAttended
    {
      [Token(Token = "0x600A9FD"), Address(RVA = "0x19172F4", Offset = "0x19172F4", VA = "0x19172F4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600A9FE")]
    [Address(RVA = "0x19172FC", Offset = "0x19172FC", VA = "0x19172FC")]
    public APIGuildIndexResponse()
    {
    }
  }
}
