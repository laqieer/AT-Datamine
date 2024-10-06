// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionResponse
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
  [Token(Token = "0x2001C14")]
  [Serializable]
  public class APIExpeditionResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007823")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007824")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007825")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007826")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x4007827")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerType before_player;
    [Token(Token = "0x4007828")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PlayerExpeditionType player_expedition;
    [Token(Token = "0x4007829")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerExpeditionStageType> player_expedition_stages;
    [Token(Token = "0x400782A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerExpeditionPartyType> player_expedition_parties;
    [Token(Token = "0x400782B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerExpeditionSoulTankType> player_expedition_soul_tanks;
    [Token(Token = "0x400782C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayerExpeditionSoulSpotType> player_expedition_soul_spots;
    [Token(Token = "0x400782D")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<PlayerExpeditionBoxType> player_expedition_boxes;

    [Token(Token = "0x17001ED5")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A50E"), Address(RVA = "0x19069B0", Offset = "0x19069B0", VA = "0x19069B0", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001ED6")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A50F"), Address(RVA = "0x19069B8", Offset = "0x19069B8", VA = "0x19069B8", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001ED7")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A510"), Address(RVA = "0x19069C0", Offset = "0x19069C0", VA = "0x19069C0", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001ED8")]
    public PlayerType Player
    {
      [Token(Token = "0x600A511"), Address(RVA = "0x19069C8", Offset = "0x19069C8", VA = "0x19069C8")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001ED9")]
    public PlayerType BeforePlayer
    {
      [Token(Token = "0x600A512"), Address(RVA = "0x19069D0", Offset = "0x19069D0", VA = "0x19069D0")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001EDA")]
    public PlayerExpeditionType PlayerExpedition
    {
      [Token(Token = "0x600A513"), Address(RVA = "0x19069D8", Offset = "0x19069D8", VA = "0x19069D8")] get
      {
        return (PlayerExpeditionType) null;
      }
    }

    [Token(Token = "0x17001EDB")]
    public List<PlayerExpeditionStageType> PlayerExpeditionStages
    {
      [Token(Token = "0x600A514"), Address(RVA = "0x19069E0", Offset = "0x19069E0", VA = "0x19069E0")] get
      {
        return (List<PlayerExpeditionStageType>) null;
      }
    }

    [Token(Token = "0x17001EDC")]
    public List<PlayerExpeditionPartyType> PlayerExpeditionParties
    {
      [Token(Token = "0x600A515"), Address(RVA = "0x19069E8", Offset = "0x19069E8", VA = "0x19069E8")] get
      {
        return (List<PlayerExpeditionPartyType>) null;
      }
    }

    [Token(Token = "0x17001EDD")]
    public List<PlayerExpeditionSoulTankType> PlayerExpeditionSoulTanks
    {
      [Token(Token = "0x600A516"), Address(RVA = "0x19069F0", Offset = "0x19069F0", VA = "0x19069F0")] get
      {
        return (List<PlayerExpeditionSoulTankType>) null;
      }
    }

    [Token(Token = "0x17001EDE")]
    public List<PlayerExpeditionSoulSpotType> PlayerExpeditionSoulSpots
    {
      [Token(Token = "0x600A517"), Address(RVA = "0x19069F8", Offset = "0x19069F8", VA = "0x19069F8")] get
      {
        return (List<PlayerExpeditionSoulSpotType>) null;
      }
    }

    [Token(Token = "0x17001EDF")]
    public List<PlayerExpeditionBoxType> PlayerExpeditionBoxes
    {
      [Token(Token = "0x600A518"), Address(RVA = "0x1906A00", Offset = "0x1906A00", VA = "0x1906A00")] get
      {
        return (List<PlayerExpeditionBoxType>) null;
      }
    }

    [Token(Token = "0x600A519")]
    [Address(RVA = "0x1906A08", Offset = "0x1906A08", VA = "0x1906A08")]
    public APIExpeditionResponse()
    {
    }
  }
}
