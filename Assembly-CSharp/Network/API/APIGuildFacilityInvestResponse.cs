// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildFacilityInvestResponse
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
  [Token(Token = "0x2001CC4")]
  [Serializable]
  public class APIGuildFacilityInvestResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007AF9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007AFA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007AFB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007AFC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<GuildFacilityType> guild_facilities;
    [Token(Token = "0x4007AFD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<int> new_title_ids;

    [Token(Token = "0x17002082")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A97B"), Address(RVA = "0x19157D8", Offset = "0x19157D8", VA = "0x19157D8", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002083")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A97C"), Address(RVA = "0x19157E0", Offset = "0x19157E0", VA = "0x19157E0", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002084")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A97D"), Address(RVA = "0x19157E8", Offset = "0x19157E8", VA = "0x19157E8", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002085")]
    public List<GuildFacilityType> GuildFacilities
    {
      [Token(Token = "0x600A97E"), Address(RVA = "0x19157F0", Offset = "0x19157F0", VA = "0x19157F0")] get
      {
        return (List<GuildFacilityType>) null;
      }
    }

    [Token(Token = "0x17002086")]
    public List<int> NewTitleIds
    {
      [Token(Token = "0x600A97F"), Address(RVA = "0x19157F8", Offset = "0x19157F8", VA = "0x19157F8")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600A980")]
    [Address(RVA = "0x1915800", Offset = "0x1915800", VA = "0x1915800")]
    public APIGuildFacilityInvestResponse()
    {
    }
  }
}
