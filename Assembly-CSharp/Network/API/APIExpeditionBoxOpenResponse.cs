// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionBoxOpenResponse
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
  [Token(Token = "0x2001C1C")]
  [Serializable]
  public class APIExpeditionBoxOpenResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007846")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007847")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007848")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007849")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x400784A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerType before_player;
    [Token(Token = "0x400784B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PlayerExpeditionType player_expedition;
    [Token(Token = "0x400784C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerExpeditionBoxType> player_expedition_boxes;
    [Token(Token = "0x400784D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<int> stage_item_drop_description_ids;
    [Token(Token = "0x400784E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerExpeditionSoulSpotType> player_expedition_soul_spots;
    [Token(Token = "0x400784F")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;
    [Token(Token = "0x4007850")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<PlayerUnitType> player_units;

    [Token(Token = "0x17001EEE")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A547"), Address(RVA = "0x19074B0", Offset = "0x19074B0", VA = "0x19074B0", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001EEF")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A548"), Address(RVA = "0x19074B8", Offset = "0x19074B8", VA = "0x19074B8", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001EF0")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A549"), Address(RVA = "0x19074C0", Offset = "0x19074C0", VA = "0x19074C0", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001EF1")]
    public PlayerType Player
    {
      [Token(Token = "0x600A54A"), Address(RVA = "0x19074C8", Offset = "0x19074C8", VA = "0x19074C8")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001EF2")]
    public PlayerType BeforePlayer
    {
      [Token(Token = "0x600A54B"), Address(RVA = "0x19074D0", Offset = "0x19074D0", VA = "0x19074D0")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001EF3")]
    public PlayerExpeditionType PlayerExpedition
    {
      [Token(Token = "0x600A54C"), Address(RVA = "0x19074D8", Offset = "0x19074D8", VA = "0x19074D8")] get
      {
        return (PlayerExpeditionType) null;
      }
    }

    [Token(Token = "0x17001EF4")]
    public List<PlayerExpeditionBoxType> PlayerExpeditionBoxes
    {
      [Token(Token = "0x600A54D"), Address(RVA = "0x19074E0", Offset = "0x19074E0", VA = "0x19074E0")] get
      {
        return (List<PlayerExpeditionBoxType>) null;
      }
    }

    [Token(Token = "0x17001EF5")]
    public List<int> StageItemDropDescriptionIds
    {
      [Token(Token = "0x600A54E"), Address(RVA = "0x19074E8", Offset = "0x19074E8", VA = "0x19074E8")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x17001EF6")]
    public List<PlayerExpeditionSoulSpotType> PlayerExpeditionSoulSpots
    {
      [Token(Token = "0x600A54F"), Address(RVA = "0x19074F0", Offset = "0x19074F0", VA = "0x19074F0")] get
      {
        return (List<PlayerExpeditionSoulSpotType>) null;
      }
    }

    [Token(Token = "0x17001EF7")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600A550"), Address(RVA = "0x19074F8", Offset = "0x19074F8", VA = "0x19074F8")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x17001EF8")]
    public List<PlayerUnitType> PlayerUnits
    {
      [Token(Token = "0x600A551"), Address(RVA = "0x1907500", Offset = "0x1907500", VA = "0x1907500")] get
      {
        return (List<PlayerUnitType>) null;
      }
    }

    [Token(Token = "0x600A552")]
    [Address(RVA = "0x1907508", Offset = "0x1907508", VA = "0x1907508")]
    public APIExpeditionBoxOpenResponse()
    {
    }
  }
}
