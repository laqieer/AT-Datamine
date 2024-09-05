// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionPartyStageChangeResponse
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
  [Token(Token = "0x2001C28")]
  [Serializable]
  public class APIExpeditionPartyStageChangeResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007885")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007886")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007887")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007888")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x4007889")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerType before_player;
    [Token(Token = "0x400788A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerExpeditionPartyType> player_expedition_parties;
    [Token(Token = "0x400788B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerExpeditionSoulTankType> player_expedition_soul_tanks;
    [Token(Token = "0x400788C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerExpeditionSoulSpotType> player_expedition_soul_spots;
    [Token(Token = "0x400788D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<int> player_expedition_box_reward_ids;

    [Token(Token = "0x17001F1A")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A5A3"), Address(RVA = "0x1908564", Offset = "0x1908564", VA = "0x1908564", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001F1B")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A5A4"), Address(RVA = "0x190856C", Offset = "0x190856C", VA = "0x190856C", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001F1C")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A5A5"), Address(RVA = "0x1908574", Offset = "0x1908574", VA = "0x1908574", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001F1D")]
    public PlayerType Player
    {
      [Token(Token = "0x600A5A6"), Address(RVA = "0x190857C", Offset = "0x190857C", VA = "0x190857C")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001F1E")]
    public PlayerType BeforePlayer
    {
      [Token(Token = "0x600A5A7"), Address(RVA = "0x1908584", Offset = "0x1908584", VA = "0x1908584")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001F1F")]
    public List<PlayerExpeditionPartyType> PlayerExpeditionParties
    {
      [Token(Token = "0x600A5A8"), Address(RVA = "0x190858C", Offset = "0x190858C", VA = "0x190858C")] get
      {
        return (List<PlayerExpeditionPartyType>) null;
      }
    }

    [Token(Token = "0x17001F20")]
    public List<PlayerExpeditionSoulTankType> PlayerExpeditionSoulTanks
    {
      [Token(Token = "0x600A5A9"), Address(RVA = "0x1908594", Offset = "0x1908594", VA = "0x1908594")] get
      {
        return (List<PlayerExpeditionSoulTankType>) null;
      }
    }

    [Token(Token = "0x17001F21")]
    public List<PlayerExpeditionSoulSpotType> PlayerExpeditionSoulSpots
    {
      [Token(Token = "0x600A5AA"), Address(RVA = "0x190859C", Offset = "0x190859C", VA = "0x190859C")] get
      {
        return (List<PlayerExpeditionSoulSpotType>) null;
      }
    }

    [Token(Token = "0x17001F22")]
    public List<int> PlayerExpeditionBoxRewardIds
    {
      [Token(Token = "0x600A5AB"), Address(RVA = "0x19085A4", Offset = "0x19085A4", VA = "0x19085A4")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600A5AC")]
    [Address(RVA = "0x19085AC", Offset = "0x19085AC", VA = "0x19085AC")]
    public APIExpeditionPartyStageChangeResponse()
    {
    }
  }
}
