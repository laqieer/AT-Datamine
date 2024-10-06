// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionRapidResponse
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
  [Token(Token = "0x2001C2C")]
  [Serializable]
  public class APIExpeditionRapidResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x400789C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400789D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x400789E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x400789F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x40078A0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerExpeditionType player_expedition;
    [Token(Token = "0x40078A1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;
    [Token(Token = "0x40078A2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private PlayerExpeditionPartyType player_expedition_party;
    [Token(Token = "0x40078A3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerExpeditionBoxType> player_expedition_boxes;
    [Token(Token = "0x40078A4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerExpeditionSoulSpotType> player_expedition_soul_spots;

    [Token(Token = "0x17001F29")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A5C2"), Address(RVA = "0x1908AF8", Offset = "0x1908AF8", VA = "0x1908AF8", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001F2A")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A5C3"), Address(RVA = "0x1908B00", Offset = "0x1908B00", VA = "0x1908B00", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001F2B")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A5C4"), Address(RVA = "0x1908B08", Offset = "0x1908B08", VA = "0x1908B08", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001F2C")]
    public PlayerType Player
    {
      [Token(Token = "0x600A5C5"), Address(RVA = "0x1908B10", Offset = "0x1908B10", VA = "0x1908B10")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001F2D")]
    public PlayerExpeditionType PlayerExpedition
    {
      [Token(Token = "0x600A5C6"), Address(RVA = "0x1908B18", Offset = "0x1908B18", VA = "0x1908B18")] get
      {
        return (PlayerExpeditionType) null;
      }
    }

    [Token(Token = "0x17001F2E")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600A5C7"), Address(RVA = "0x1908B20", Offset = "0x1908B20", VA = "0x1908B20")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x17001F2F")]
    public PlayerExpeditionPartyType PlayerExpeditionParty
    {
      [Token(Token = "0x600A5C8"), Address(RVA = "0x1908B28", Offset = "0x1908B28", VA = "0x1908B28")] get
      {
        return (PlayerExpeditionPartyType) null;
      }
    }

    [Token(Token = "0x17001F30")]
    public List<PlayerExpeditionBoxType> PlayerExpeditionBoxes
    {
      [Token(Token = "0x600A5C9"), Address(RVA = "0x1908B30", Offset = "0x1908B30", VA = "0x1908B30")] get
      {
        return (List<PlayerExpeditionBoxType>) null;
      }
    }

    [Token(Token = "0x17001F31")]
    public List<PlayerExpeditionSoulSpotType> PlayerExpeditionSoulSpots
    {
      [Token(Token = "0x600A5CA"), Address(RVA = "0x1908B38", Offset = "0x1908B38", VA = "0x1908B38")] get
      {
        return (List<PlayerExpeditionSoulSpotType>) null;
      }
    }

    [Token(Token = "0x600A5CB")]
    [Address(RVA = "0x1908B40", Offset = "0x1908B40", VA = "0x1908B40")]
    public APIExpeditionRapidResponse()
    {
    }
  }
}
