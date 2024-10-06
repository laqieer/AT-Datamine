// Decompiled with JetBrains decompiler
// Type: Network.Param.EnemyArenaRankingDetailType
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
  [Token(Token = "0x2001A51")]
  [Serializable]
  public class EnemyArenaRankingDetailType
  {
    [Token(Token = "0x4007087")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int ranking;
    [Token(Token = "0x4007088")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerDeckSlotInfo> deck_units;
    [Token(Token = "0x4007089")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerOpenProfileType player_profile;
    [Token(Token = "0x400708A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerUnitType> player_units;
    [Token(Token = "0x400708B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitCharacterType> player_unit_characters;
    [Token(Token = "0x400708C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerGearWeaponType> player_gear_weapons;
    [Token(Token = "0x400708D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerGearAccessoryType> player_gear_accessories;
    [Token(Token = "0x400708E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerGearMindEquipmentType> player_mind_equipments;
    [Token(Token = "0x400708F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerGearUnitTrustType> player_unit_trusts;
    [Token(Token = "0x4007090")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayerUnitCustomSkillType> player_custom_skills;
    [Token(Token = "0x4007091")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<PlayerUnitSupportType> player_unit_supports;
    [Token(Token = "0x4007092")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private List<PlayerStyleMasterBonusType> player_style_master_bonuses;
    [Token(Token = "0x4007093")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private List<PlayerWeaponMasterBonusType> player_weapon_master_bonuses;
    [Token(Token = "0x4007094")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private List<GuildFacilityType> guild_facilities;
    [Token(Token = "0x4007095")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private List<PlayerCommunicationSkillType> player_communication_skills;

    [Token(Token = "0x170018BD")]
    public int Ranking
    {
      [Token(Token = "0x6009661"), Address(RVA = "0x48EF148", Offset = "0x48EF148", VA = "0x48EF148")] get
      {
        return new int();
      }
      [Token(Token = "0x6009662"), Address(RVA = "0x48EF150", Offset = "0x48EF150", VA = "0x48EF150")] set
      {
      }
    }

    [Token(Token = "0x170018BE")]
    public List<PlayerDeckSlotInfo> DeckUnits
    {
      [Token(Token = "0x6009663"), Address(RVA = "0x48EF158", Offset = "0x48EF158", VA = "0x48EF158")] get
      {
        return (List<PlayerDeckSlotInfo>) null;
      }
      [Token(Token = "0x6009664"), Address(RVA = "0x48EF160", Offset = "0x48EF160", VA = "0x48EF160")] set
      {
      }
    }

    [Token(Token = "0x170018BF")]
    public PlayerOpenProfileType PlayerProfile
    {
      [Token(Token = "0x6009665"), Address(RVA = "0x48EF168", Offset = "0x48EF168", VA = "0x48EF168")] get
      {
        return (PlayerOpenProfileType) null;
      }
      [Token(Token = "0x6009666"), Address(RVA = "0x48EF170", Offset = "0x48EF170", VA = "0x48EF170")] set
      {
      }
    }

    [Token(Token = "0x170018C0")]
    public List<PlayerUnitType> PlayerUnits
    {
      [Token(Token = "0x6009667"), Address(RVA = "0x48EF178", Offset = "0x48EF178", VA = "0x48EF178")] get
      {
        return (List<PlayerUnitType>) null;
      }
      [Token(Token = "0x6009668"), Address(RVA = "0x48EF180", Offset = "0x48EF180", VA = "0x48EF180")] set
      {
      }
    }

    [Token(Token = "0x170018C1")]
    public List<PlayerUnitCharacterType> PlayerUnitCharacters
    {
      [Token(Token = "0x6009669"), Address(RVA = "0x48EF188", Offset = "0x48EF188", VA = "0x48EF188")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
      [Token(Token = "0x600966A"), Address(RVA = "0x48EF190", Offset = "0x48EF190", VA = "0x48EF190")] set
      {
      }
    }

    [Token(Token = "0x170018C2")]
    public List<PlayerGearWeaponType> PlayerGearWeapons
    {
      [Token(Token = "0x600966B"), Address(RVA = "0x48EF198", Offset = "0x48EF198", VA = "0x48EF198")] get
      {
        return (List<PlayerGearWeaponType>) null;
      }
      [Token(Token = "0x600966C"), Address(RVA = "0x48EF1A0", Offset = "0x48EF1A0", VA = "0x48EF1A0")] set
      {
      }
    }

    [Token(Token = "0x170018C3")]
    public List<PlayerGearAccessoryType> PlayerGearAccessories
    {
      [Token(Token = "0x600966D"), Address(RVA = "0x48EF1A8", Offset = "0x48EF1A8", VA = "0x48EF1A8")] get
      {
        return (List<PlayerGearAccessoryType>) null;
      }
      [Token(Token = "0x600966E"), Address(RVA = "0x48EF1B0", Offset = "0x48EF1B0", VA = "0x48EF1B0")] set
      {
      }
    }

    [Token(Token = "0x170018C4")]
    public List<PlayerGearMindEquipmentType> PlayerMindEquipments
    {
      [Token(Token = "0x600966F"), Address(RVA = "0x48EF1B8", Offset = "0x48EF1B8", VA = "0x48EF1B8")] get
      {
        return (List<PlayerGearMindEquipmentType>) null;
      }
      [Token(Token = "0x6009670"), Address(RVA = "0x48EF1C0", Offset = "0x48EF1C0", VA = "0x48EF1C0")] set
      {
      }
    }

    [Token(Token = "0x170018C5")]
    public List<PlayerGearUnitTrustType> PlayerUnitTrusts
    {
      [Token(Token = "0x6009671"), Address(RVA = "0x48EF1C8", Offset = "0x48EF1C8", VA = "0x48EF1C8")] get
      {
        return (List<PlayerGearUnitTrustType>) null;
      }
      [Token(Token = "0x6009672"), Address(RVA = "0x48EF1D0", Offset = "0x48EF1D0", VA = "0x48EF1D0")] set
      {
      }
    }

    [Token(Token = "0x170018C6")]
    public List<PlayerUnitCustomSkillType> PlayerCustomSkills
    {
      [Token(Token = "0x6009673"), Address(RVA = "0x48EF1D8", Offset = "0x48EF1D8", VA = "0x48EF1D8")] get
      {
        return (List<PlayerUnitCustomSkillType>) null;
      }
      [Token(Token = "0x6009674"), Address(RVA = "0x48EF1E0", Offset = "0x48EF1E0", VA = "0x48EF1E0")] set
      {
      }
    }

    [Token(Token = "0x170018C7")]
    public List<PlayerUnitSupportType> PlayerUnitSupports
    {
      [Token(Token = "0x6009675"), Address(RVA = "0x48EF1E8", Offset = "0x48EF1E8", VA = "0x48EF1E8")] get
      {
        return (List<PlayerUnitSupportType>) null;
      }
      [Token(Token = "0x6009676"), Address(RVA = "0x48EF1F0", Offset = "0x48EF1F0", VA = "0x48EF1F0")] set
      {
      }
    }

    [Token(Token = "0x170018C8")]
    public List<PlayerStyleMasterBonusType> PlayerStyleMasterBonuses
    {
      [Token(Token = "0x6009677"), Address(RVA = "0x48EF1F8", Offset = "0x48EF1F8", VA = "0x48EF1F8")] get
      {
        return (List<PlayerStyleMasterBonusType>) null;
      }
      [Token(Token = "0x6009678"), Address(RVA = "0x48EF200", Offset = "0x48EF200", VA = "0x48EF200")] set
      {
      }
    }

    [Token(Token = "0x170018C9")]
    public List<PlayerWeaponMasterBonusType> PlayerWeaponMasterBonuses
    {
      [Token(Token = "0x6009679"), Address(RVA = "0x48EF208", Offset = "0x48EF208", VA = "0x48EF208")] get
      {
        return (List<PlayerWeaponMasterBonusType>) null;
      }
      [Token(Token = "0x600967A"), Address(RVA = "0x48EF210", Offset = "0x48EF210", VA = "0x48EF210")] set
      {
      }
    }

    [Token(Token = "0x170018CA")]
    public List<GuildFacilityType> GuildFacilities
    {
      [Token(Token = "0x600967B"), Address(RVA = "0x48EF218", Offset = "0x48EF218", VA = "0x48EF218")] get
      {
        return (List<GuildFacilityType>) null;
      }
      [Token(Token = "0x600967C"), Address(RVA = "0x48EF220", Offset = "0x48EF220", VA = "0x48EF220")] set
      {
      }
    }

    [Token(Token = "0x170018CB")]
    public List<PlayerCommunicationSkillType> PlayerCommunicationSkills
    {
      [Token(Token = "0x600967D"), Address(RVA = "0x48EF228", Offset = "0x48EF228", VA = "0x48EF228")] get
      {
        return (List<PlayerCommunicationSkillType>) null;
      }
      [Token(Token = "0x600967E"), Address(RVA = "0x48EF230", Offset = "0x48EF230", VA = "0x48EF230")] set
      {
      }
    }

    [Token(Token = "0x600967F")]
    [Address(RVA = "0x48EF238", Offset = "0x48EF238", VA = "0x48EF238")]
    public EnemyArenaRankingDetailType()
    {
    }
  }
}
