// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionPartyEditResponse
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
  [Token(Token = "0x2001C20")]
  [Serializable]
  public class APIExpeditionPartyEditResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x400785D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400785E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x400785F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007860")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x4007861")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerType before_player;
    [Token(Token = "0x4007862")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerExpeditionPartyType> player_expedition_parties;
    [Token(Token = "0x4007863")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerExpeditionSoulTankType> player_expedition_soul_tanks;
    [Token(Token = "0x4007864")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerExpeditionSoulSpotType> player_expedition_soul_spots;
    [Token(Token = "0x4007865")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<int> player_expedition_box_reward_ids;
    [Token(Token = "0x4007866")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayerUnitType> player_units;
    [Token(Token = "0x4007867")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<PlayerUnitCharacterType> player_unit_characters;

    [Token(Token = "0x17001EFF")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A568"), Address(RVA = "0x1907A54", Offset = "0x1907A54", VA = "0x1907A54", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001F00")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A569"), Address(RVA = "0x1907A5C", Offset = "0x1907A5C", VA = "0x1907A5C", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001F01")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A56A"), Address(RVA = "0x1907A64", Offset = "0x1907A64", VA = "0x1907A64", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001F02")]
    public PlayerType Player
    {
      [Token(Token = "0x600A56B"), Address(RVA = "0x1907A6C", Offset = "0x1907A6C", VA = "0x1907A6C")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001F03")]
    public PlayerType BeforePlayer
    {
      [Token(Token = "0x600A56C"), Address(RVA = "0x1907A74", Offset = "0x1907A74", VA = "0x1907A74")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001F04")]
    public List<PlayerExpeditionPartyType> PlayerExpeditionParties
    {
      [Token(Token = "0x600A56D"), Address(RVA = "0x1907A7C", Offset = "0x1907A7C", VA = "0x1907A7C")] get
      {
        return (List<PlayerExpeditionPartyType>) null;
      }
    }

    [Token(Token = "0x17001F05")]
    public List<PlayerExpeditionSoulTankType> PlayerExpeditionSoulTanks
    {
      [Token(Token = "0x600A56E"), Address(RVA = "0x1907A84", Offset = "0x1907A84", VA = "0x1907A84")] get
      {
        return (List<PlayerExpeditionSoulTankType>) null;
      }
    }

    [Token(Token = "0x17001F06")]
    public List<PlayerExpeditionSoulSpotType> PlayerExpeditionSoulSpots
    {
      [Token(Token = "0x600A56F"), Address(RVA = "0x1907A8C", Offset = "0x1907A8C", VA = "0x1907A8C")] get
      {
        return (List<PlayerExpeditionSoulSpotType>) null;
      }
    }

    [Token(Token = "0x17001F07")]
    public List<int> PlayerExpeditionBoxRewardIds
    {
      [Token(Token = "0x600A570"), Address(RVA = "0x1907A94", Offset = "0x1907A94", VA = "0x1907A94")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x17001F08")]
    public List<PlayerUnitType> PlayerUnits
    {
      [Token(Token = "0x600A571"), Address(RVA = "0x1907A9C", Offset = "0x1907A9C", VA = "0x1907A9C")] get
      {
        return (List<PlayerUnitType>) null;
      }
    }

    [Token(Token = "0x17001F09")]
    public List<PlayerUnitCharacterType> PlayerUnitCharacters
    {
      [Token(Token = "0x600A572"), Address(RVA = "0x1907AA4", Offset = "0x1907AA4", VA = "0x1907AA4")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
    }

    [Token(Token = "0x600A573")]
    [Address(RVA = "0x1907AAC", Offset = "0x1907AAC", VA = "0x1907AAC")]
    public APIExpeditionPartyEditResponse()
    {
    }
  }
}
