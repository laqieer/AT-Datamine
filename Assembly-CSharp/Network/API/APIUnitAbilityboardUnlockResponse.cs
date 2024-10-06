// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardUnlockResponse
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
  [Token(Token = "0x2001EA0")]
  [Serializable]
  public class APIUnitAbilityboardUnlockResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x400839B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400839C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x400839D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x400839E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerUnitType player_unit;
    [Token(Token = "0x400839F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerUnitCharacterType player_unit_character;
    [Token(Token = "0x40083A0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private UpdatedPlayerItems update_player_items;
    [Token(Token = "0x40083A1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerStyleMasterBonusType> player_style_master_bonuses;
    [Token(Token = "0x40083A2")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerUnitCustomSkillType> player_custom_skills;

    [Token(Token = "0x1700256C")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B5D5"), Address(RVA = "0x22EA7F0", Offset = "0x22EA7F0", VA = "0x22EA7F0", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700256D")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B5D6"), Address(RVA = "0x22EA7F8", Offset = "0x22EA7F8", VA = "0x22EA7F8", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700256E")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B5D7"), Address(RVA = "0x22EA800", Offset = "0x22EA800", VA = "0x22EA800", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x1700256F")]
    public PlayerUnitType PlayerUnit
    {
      [Token(Token = "0x600B5D8"), Address(RVA = "0x22EA808", Offset = "0x22EA808", VA = "0x22EA808")] get
      {
        return (PlayerUnitType) null;
      }
    }

    [Token(Token = "0x17002570")]
    public PlayerUnitCharacterType PlayerUnitCharacter
    {
      [Token(Token = "0x600B5D9"), Address(RVA = "0x22EA810", Offset = "0x22EA810", VA = "0x22EA810")] get
      {
        return (PlayerUnitCharacterType) null;
      }
    }

    [Token(Token = "0x17002571")]
    public UpdatedPlayerItems UpdatePlayerItems
    {
      [Token(Token = "0x600B5DA"), Address(RVA = "0x22EA818", Offset = "0x22EA818", VA = "0x22EA818")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x17002572")]
    public List<PlayerStyleMasterBonusType> PlayerStyleMasterBonuses
    {
      [Token(Token = "0x600B5DB"), Address(RVA = "0x22EA820", Offset = "0x22EA820", VA = "0x22EA820")] get
      {
        return (List<PlayerStyleMasterBonusType>) null;
      }
    }

    [Token(Token = "0x17002573")]
    public List<PlayerUnitCustomSkillType> PlayerCustomSkills
    {
      [Token(Token = "0x600B5DC"), Address(RVA = "0x22EA828", Offset = "0x22EA828", VA = "0x22EA828")] get
      {
        return (List<PlayerUnitCustomSkillType>) null;
      }
    }

    [Token(Token = "0x600B5DD")]
    [Address(RVA = "0x22EA830", Offset = "0x22EA830", VA = "0x22EA830")]
    public APIUnitAbilityboardUnlockResponse()
    {
    }
  }
}
