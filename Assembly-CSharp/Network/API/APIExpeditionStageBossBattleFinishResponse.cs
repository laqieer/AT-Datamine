// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionStageBossBattleFinishResponse
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
  [Token(Token = "0x2001C38")]
  [Serializable]
  public class APIExpeditionStageBossBattleFinishResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40078D3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40078D4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40078D5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40078D6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x40078D7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerType before_player;
    [Token(Token = "0x40078D8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PlayerExpeditionType player_expedition;
    [Token(Token = "0x40078D9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private PlayerExpeditionStageType player_expedition_stage;
    [Token(Token = "0x40078DA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerUnitCharacterType> player_unit_characters;
    [Token(Token = "0x40078DB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerUnitCharacterType> before_player_unit_characters;
    [Token(Token = "0x40078DC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayerUnitType> player_units;
    [Token(Token = "0x40078DD")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<PlayerUnitType> before_player_units;
    [Token(Token = "0x40078DE")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private List<PlayerExpeditionSoulSpotType> player_expedition_soul_spots;
    [Token(Token = "0x40078DF")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private List<int> stage_boss_rare_reward_ids;
    [Token(Token = "0x40078E0")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;

    [Token(Token = "0x17001F4C")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A615"), Address(RVA = "0x1909B64", Offset = "0x1909B64", VA = "0x1909B64", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001F4D")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A616"), Address(RVA = "0x1909B6C", Offset = "0x1909B6C", VA = "0x1909B6C", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001F4E")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A617"), Address(RVA = "0x1909B74", Offset = "0x1909B74", VA = "0x1909B74", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001F4F")]
    public PlayerType Player
    {
      [Token(Token = "0x600A618"), Address(RVA = "0x1909B7C", Offset = "0x1909B7C", VA = "0x1909B7C")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001F50")]
    public PlayerType BeforePlayer
    {
      [Token(Token = "0x600A619"), Address(RVA = "0x1909B84", Offset = "0x1909B84", VA = "0x1909B84")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x17001F51")]
    public PlayerExpeditionType PlayerExpedition
    {
      [Token(Token = "0x600A61A"), Address(RVA = "0x1909B8C", Offset = "0x1909B8C", VA = "0x1909B8C")] get
      {
        return (PlayerExpeditionType) null;
      }
    }

    [Token(Token = "0x17001F52")]
    public PlayerExpeditionStageType PlayerExpeditionStage
    {
      [Token(Token = "0x600A61B"), Address(RVA = "0x1909B94", Offset = "0x1909B94", VA = "0x1909B94")] get
      {
        return (PlayerExpeditionStageType) null;
      }
    }

    [Token(Token = "0x17001F53")]
    public List<PlayerUnitCharacterType> PlayerUnitCharacters
    {
      [Token(Token = "0x600A61C"), Address(RVA = "0x1909B9C", Offset = "0x1909B9C", VA = "0x1909B9C")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
    }

    [Token(Token = "0x17001F54")]
    public List<PlayerUnitCharacterType> BeforePlayerUnitCharacters
    {
      [Token(Token = "0x600A61D"), Address(RVA = "0x1909BA4", Offset = "0x1909BA4", VA = "0x1909BA4")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
    }

    [Token(Token = "0x17001F55")]
    public List<PlayerUnitType> PlayerUnits
    {
      [Token(Token = "0x600A61E"), Address(RVA = "0x1909BAC", Offset = "0x1909BAC", VA = "0x1909BAC")] get
      {
        return (List<PlayerUnitType>) null;
      }
    }

    [Token(Token = "0x17001F56")]
    public List<PlayerUnitType> BeforePlayerUnits
    {
      [Token(Token = "0x600A61F"), Address(RVA = "0x1909BB4", Offset = "0x1909BB4", VA = "0x1909BB4")] get
      {
        return (List<PlayerUnitType>) null;
      }
    }

    [Token(Token = "0x17001F57")]
    public List<PlayerExpeditionSoulSpotType> PlayerExpeditionSoulSpots
    {
      [Token(Token = "0x600A620"), Address(RVA = "0x1909BBC", Offset = "0x1909BBC", VA = "0x1909BBC")] get
      {
        return (List<PlayerExpeditionSoulSpotType>) null;
      }
    }

    [Token(Token = "0x17001F58")]
    public List<int> StageBossRareRewardIds
    {
      [Token(Token = "0x600A621"), Address(RVA = "0x1909BC4", Offset = "0x1909BC4", VA = "0x1909BC4")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x17001F59")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600A622"), Address(RVA = "0x1909BCC", Offset = "0x1909BCC", VA = "0x1909BCC")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600A623")]
    [Address(RVA = "0x1909BD4", Offset = "0x1909BD4", VA = "0x1909BD4")]
    public APIExpeditionStageBossBattleFinishResponse()
    {
    }
  }
}
