// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBattleSkipResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A91")]
  [Serializable]
  public class PlayerBattleSkipResult
  {
    [Token(Token = "0x40071E3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerQuestBattleType player_quest;
    [Token(Token = "0x40071E4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerBattleRewardResult> reward_results;
    [Token(Token = "0x40071E5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x40071E6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerUnitSupportType> support_value_result_before;
    [Token(Token = "0x40071E7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitSupportType> support_value_result_after;
    [Token(Token = "0x40071E8")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerUnitType> before_player_units;
    [Token(Token = "0x40071E9")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerUnitType> after_player_units;
    [Token(Token = "0x40071EA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerUnitCharacterType> before_player_unit_characters;
    [Token(Token = "0x40071EB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerUnitCharacterType> after_player_unit_characters;
    [Token(Token = "0x40071EC")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayerGearWeaponType> weapons_before;
    [Token(Token = "0x40071ED")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<PlayerGearWeaponType> weapons_after;
    [Token(Token = "0x40071EE")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private List<PlayerGearAccessoryType> accessories_before;
    [Token(Token = "0x40071EF")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private List<PlayerGearAccessoryType> accessories_after;
    [Token(Token = "0x40071F0")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private List<PlayerWeaponMasterBonusType> player_weapon_master_bonuses;

    [Token(Token = "0x17001A27")]
    public PlayerQuestBattleType PlayerQuest
    {
      [Token(Token = "0x6009968"), Address(RVA = "0x48F0940", Offset = "0x48F0940", VA = "0x48F0940")] get
      {
        return (PlayerQuestBattleType) null;
      }
      [Token(Token = "0x6009969"), Address(RVA = "0x48F0948", Offset = "0x48F0948", VA = "0x48F0948")] set
      {
      }
    }

    [Token(Token = "0x17001A28")]
    public List<PlayerBattleRewardResult> RewardResults
    {
      [Token(Token = "0x600996A"), Address(RVA = "0x48F0950", Offset = "0x48F0950", VA = "0x48F0950")] get
      {
        return (List<PlayerBattleRewardResult>) null;
      }
      [Token(Token = "0x600996B"), Address(RVA = "0x48F0958", Offset = "0x48F0958", VA = "0x48F0958")] set
      {
      }
    }

    [Token(Token = "0x17001A29")]
    public PlayerType Player
    {
      [Token(Token = "0x600996C"), Address(RVA = "0x48F0960", Offset = "0x48F0960", VA = "0x48F0960")] get
      {
        return (PlayerType) null;
      }
      [Token(Token = "0x600996D"), Address(RVA = "0x48F0968", Offset = "0x48F0968", VA = "0x48F0968")] set
      {
      }
    }

    [Token(Token = "0x17001A2A")]
    public List<PlayerUnitSupportType> SupportValueResultBefore
    {
      [Token(Token = "0x600996E"), Address(RVA = "0x48F0970", Offset = "0x48F0970", VA = "0x48F0970")] get
      {
        return (List<PlayerUnitSupportType>) null;
      }
      [Token(Token = "0x600996F"), Address(RVA = "0x48F0978", Offset = "0x48F0978", VA = "0x48F0978")] set
      {
      }
    }

    [Token(Token = "0x17001A2B")]
    public List<PlayerUnitSupportType> SupportValueResultAfter
    {
      [Token(Token = "0x6009970"), Address(RVA = "0x48F0980", Offset = "0x48F0980", VA = "0x48F0980")] get
      {
        return (List<PlayerUnitSupportType>) null;
      }
      [Token(Token = "0x6009971"), Address(RVA = "0x48F0988", Offset = "0x48F0988", VA = "0x48F0988")] set
      {
      }
    }

    [Token(Token = "0x17001A2C")]
    public List<PlayerUnitType> BeforePlayerUnits
    {
      [Token(Token = "0x6009972"), Address(RVA = "0x48F0990", Offset = "0x48F0990", VA = "0x48F0990")] get
      {
        return (List<PlayerUnitType>) null;
      }
      [Token(Token = "0x6009973"), Address(RVA = "0x48F0998", Offset = "0x48F0998", VA = "0x48F0998")] set
      {
      }
    }

    [Token(Token = "0x17001A2D")]
    public List<PlayerUnitType> AfterPlayerUnits
    {
      [Token(Token = "0x6009974"), Address(RVA = "0x48F09A0", Offset = "0x48F09A0", VA = "0x48F09A0")] get
      {
        return (List<PlayerUnitType>) null;
      }
      [Token(Token = "0x6009975"), Address(RVA = "0x48F09A8", Offset = "0x48F09A8", VA = "0x48F09A8")] set
      {
      }
    }

    [Token(Token = "0x17001A2E")]
    public List<PlayerUnitCharacterType> BeforePlayerUnitCharacters
    {
      [Token(Token = "0x6009976"), Address(RVA = "0x48F09B0", Offset = "0x48F09B0", VA = "0x48F09B0")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
      [Token(Token = "0x6009977"), Address(RVA = "0x48F09B8", Offset = "0x48F09B8", VA = "0x48F09B8")] set
      {
      }
    }

    [Token(Token = "0x17001A2F")]
    public List<PlayerUnitCharacterType> AfterPlayerUnitCharacters
    {
      [Token(Token = "0x6009978"), Address(RVA = "0x48F09C0", Offset = "0x48F09C0", VA = "0x48F09C0")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
      [Token(Token = "0x6009979"), Address(RVA = "0x48F09C8", Offset = "0x48F09C8", VA = "0x48F09C8")] set
      {
      }
    }

    [Token(Token = "0x17001A30")]
    public List<PlayerGearWeaponType> WeaponsBefore
    {
      [Token(Token = "0x600997A"), Address(RVA = "0x48F09D0", Offset = "0x48F09D0", VA = "0x48F09D0")] get
      {
        return (List<PlayerGearWeaponType>) null;
      }
      [Token(Token = "0x600997B"), Address(RVA = "0x48F09D8", Offset = "0x48F09D8", VA = "0x48F09D8")] set
      {
      }
    }

    [Token(Token = "0x17001A31")]
    public List<PlayerGearWeaponType> WeaponsAfter
    {
      [Token(Token = "0x600997C"), Address(RVA = "0x48F09E0", Offset = "0x48F09E0", VA = "0x48F09E0")] get
      {
        return (List<PlayerGearWeaponType>) null;
      }
      [Token(Token = "0x600997D"), Address(RVA = "0x48F09E8", Offset = "0x48F09E8", VA = "0x48F09E8")] set
      {
      }
    }

    [Token(Token = "0x17001A32")]
    public List<PlayerGearAccessoryType> AccessoriesBefore
    {
      [Token(Token = "0x600997E"), Address(RVA = "0x48F09F0", Offset = "0x48F09F0", VA = "0x48F09F0")] get
      {
        return (List<PlayerGearAccessoryType>) null;
      }
      [Token(Token = "0x600997F"), Address(RVA = "0x48F09F8", Offset = "0x48F09F8", VA = "0x48F09F8")] set
      {
      }
    }

    [Token(Token = "0x17001A33")]
    public List<PlayerGearAccessoryType> AccessoriesAfter
    {
      [Token(Token = "0x6009980"), Address(RVA = "0x48F0A00", Offset = "0x48F0A00", VA = "0x48F0A00")] get
      {
        return (List<PlayerGearAccessoryType>) null;
      }
      [Token(Token = "0x6009981"), Address(RVA = "0x48F0A08", Offset = "0x48F0A08", VA = "0x48F0A08")] set
      {
      }
    }

    [Token(Token = "0x17001A34")]
    public List<PlayerWeaponMasterBonusType> PlayerWeaponMasterBonuses
    {
      [Token(Token = "0x6009982"), Address(RVA = "0x48F0A10", Offset = "0x48F0A10", VA = "0x48F0A10")] get
      {
        return (List<PlayerWeaponMasterBonusType>) null;
      }
      [Token(Token = "0x6009983"), Address(RVA = "0x48F0A18", Offset = "0x48F0A18", VA = "0x48F0A18")] set
      {
      }
    }

    [Token(Token = "0x6009984")]
    [Address(RVA = "0x48F0A20", Offset = "0x48F0A20", VA = "0x48F0A20")]
    public PlayerBattleSkipResult()
    {
    }
  }
}
