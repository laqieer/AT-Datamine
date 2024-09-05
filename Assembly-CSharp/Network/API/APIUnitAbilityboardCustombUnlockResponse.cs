// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardCustombUnlockResponse
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
  [Token(Token = "0x2001E98")]
  [Serializable]
  public class APIUnitAbilityboardCustombUnlockResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4008376")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008377")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4008378")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4008379")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerUnitType player_unit;
    [Token(Token = "0x400837A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerUnitCharacterType player_unit_character;
    [Token(Token = "0x400837B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UpdatedPlayerItems update_player_items;
    [Token(Token = "0x400837C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerUnitAbilityBoardType> release_nodes;
    [Token(Token = "0x400837D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerUnitAbilityBoardCustomBNodeType> customB_data;
    [Token(Token = "0x400837E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerStyleMasterBonusType> player_style_master_bonuses;

    [Token(Token = "0x17002554")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B59D"), Address(RVA = "0x22E9CF8", Offset = "0x22E9CF8", VA = "0x22E9CF8", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002555")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B59E"), Address(RVA = "0x22E9D00", Offset = "0x22E9D00", VA = "0x22E9D00", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002556")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B59F"), Address(RVA = "0x22E9D08", Offset = "0x22E9D08", VA = "0x22E9D08", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002557")]
    public PlayerUnitType PlayerUnit
    {
      [Token(Token = "0x600B5A0"), Address(RVA = "0x22E9D10", Offset = "0x22E9D10", VA = "0x22E9D10")] get
      {
        return (PlayerUnitType) null;
      }
    }

    [Token(Token = "0x17002558")]
    public PlayerUnitCharacterType PlayerUnitCharacter
    {
      [Token(Token = "0x600B5A1"), Address(RVA = "0x22E9D18", Offset = "0x22E9D18", VA = "0x22E9D18")] get
      {
        return (PlayerUnitCharacterType) null;
      }
    }

    [Token(Token = "0x17002559")]
    public UpdatedPlayerItems UpdatePlayerItems
    {
      [Token(Token = "0x600B5A2"), Address(RVA = "0x22E9D20", Offset = "0x22E9D20", VA = "0x22E9D20")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x1700255A")]
    public List<PlayerUnitAbilityBoardType> ReleaseNodes
    {
      [Token(Token = "0x600B5A3"), Address(RVA = "0x22E9D28", Offset = "0x22E9D28", VA = "0x22E9D28")] get
      {
        return (List<PlayerUnitAbilityBoardType>) null;
      }
    }

    [Token(Token = "0x1700255B")]
    public List<PlayerUnitAbilityBoardCustomBNodeType> CustombData
    {
      [Token(Token = "0x600B5A4"), Address(RVA = "0x22E9D30", Offset = "0x22E9D30", VA = "0x22E9D30")] get
      {
        return (List<PlayerUnitAbilityBoardCustomBNodeType>) null;
      }
    }

    [Token(Token = "0x1700255C")]
    public List<PlayerStyleMasterBonusType> PlayerStyleMasterBonuses
    {
      [Token(Token = "0x600B5A5"), Address(RVA = "0x22E9D38", Offset = "0x22E9D38", VA = "0x22E9D38")] get
      {
        return (List<PlayerStyleMasterBonusType>) null;
      }
    }

    [Token(Token = "0x600B5A6")]
    [Address(RVA = "0x22E9D40", Offset = "0x22E9D40", VA = "0x22E9D40")]
    public APIUnitAbilityboardCustombUnlockResponse()
    {
    }
  }
}
