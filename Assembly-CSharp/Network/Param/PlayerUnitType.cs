// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitType
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
  [Token(Token = "0x2001B02")]
  [Serializable]
  public class PlayerUnitType
  {
    [Token(Token = "0x40073F6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x40073F7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int style_id;
    [Token(Token = "0x40073F8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string created_at;
    [Token(Token = "0x40073F9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string updated_at;
    [Token(Token = "0x40073FA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string player_unit_character_id;
    [Token(Token = "0x40073FB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int experience;
    [Token(Token = "0x40073FC")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private int level_up_life;
    [Token(Token = "0x40073FD")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private int level_up_strength;
    [Token(Token = "0x40073FE")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private int level_up_intelligence;
    [Token(Token = "0x40073FF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private int level_up_vitality;
    [Token(Token = "0x4007400")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private int level_up_mind;
    [Token(Token = "0x4007401")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private int level_up_agility;
    [Token(Token = "0x4007402")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private int level_up_dexterity;
    [Token(Token = "0x4007403")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private int level_up_lucky;
    [Token(Token = "0x4007404")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private int awake_count;
    [Token(Token = "0x4007405")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private int rarity_star;
    [Token(Token = "0x4007406")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private int ai_type;
    [Token(Token = "0x4007407")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private bool is_unit_trust_released;
    [Token(Token = "0x4007408")]
    [FieldOffset(Offset = "0x69")]
    [SerializeField]
    private bool is_favorite;
    [Token(Token = "0x4007409")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private List<PlayerUnitSkillType> player_unit_skills;
    [Token(Token = "0x400740A")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private List<PlayerUnitAbilityBoardParameterType> player_unit_ability_board_parameter;
    [Token(Token = "0x400740B")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private int ability_board_node_release_count;
    [Token(Token = "0x400740C")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private PlayerUnitEquipmentSetType player_unit_equipment_set;
    [Token(Token = "0x400740D")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private int increase_skill_cost;
    [Token(Token = "0x400740E")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private int reincarnation_count;

    [Token(Token = "0x17001C58")]
    public string Id
    {
      [Token(Token = "0x6009E1D"), Address(RVA = "0x48F319C", Offset = "0x48F319C", VA = "0x48F319C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009E1E"), Address(RVA = "0x48F31A4", Offset = "0x48F31A4", VA = "0x48F31A4")] set
      {
      }
    }

    [Token(Token = "0x17001C59")]
    public int StyleId
    {
      [Token(Token = "0x6009E1F"), Address(RVA = "0x48F31AC", Offset = "0x48F31AC", VA = "0x48F31AC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E20"), Address(RVA = "0x48F31B4", Offset = "0x48F31B4", VA = "0x48F31B4")] set
      {
      }
    }

    [Token(Token = "0x17001C5A")]
    public string CreatedAt
    {
      [Token(Token = "0x6009E21"), Address(RVA = "0x48F31BC", Offset = "0x48F31BC", VA = "0x48F31BC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009E22"), Address(RVA = "0x48F31C4", Offset = "0x48F31C4", VA = "0x48F31C4")] set
      {
      }
    }

    [Token(Token = "0x17001C5B")]
    public string UpdatedAt
    {
      [Token(Token = "0x6009E23"), Address(RVA = "0x48F31CC", Offset = "0x48F31CC", VA = "0x48F31CC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009E24"), Address(RVA = "0x48F31D4", Offset = "0x48F31D4", VA = "0x48F31D4")] set
      {
      }
    }

    [Token(Token = "0x17001C5C")]
    public string PlayerUnitCharacterId
    {
      [Token(Token = "0x6009E25"), Address(RVA = "0x48F31DC", Offset = "0x48F31DC", VA = "0x48F31DC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009E26"), Address(RVA = "0x48F31E4", Offset = "0x48F31E4", VA = "0x48F31E4")] set
      {
      }
    }

    [Token(Token = "0x17001C5D")]
    public int Experience
    {
      [Token(Token = "0x6009E27"), Address(RVA = "0x48F31EC", Offset = "0x48F31EC", VA = "0x48F31EC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E28"), Address(RVA = "0x48F31F4", Offset = "0x48F31F4", VA = "0x48F31F4")] set
      {
      }
    }

    [Token(Token = "0x17001C5E")]
    public int LevelUpLife
    {
      [Token(Token = "0x6009E29"), Address(RVA = "0x48F31FC", Offset = "0x48F31FC", VA = "0x48F31FC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E2A"), Address(RVA = "0x48F3204", Offset = "0x48F3204", VA = "0x48F3204")] set
      {
      }
    }

    [Token(Token = "0x17001C5F")]
    public int LevelUpStrength
    {
      [Token(Token = "0x6009E2B"), Address(RVA = "0x48F320C", Offset = "0x48F320C", VA = "0x48F320C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E2C"), Address(RVA = "0x48F3214", Offset = "0x48F3214", VA = "0x48F3214")] set
      {
      }
    }

    [Token(Token = "0x17001C60")]
    public int LevelUpIntelligence
    {
      [Token(Token = "0x6009E2D"), Address(RVA = "0x48F321C", Offset = "0x48F321C", VA = "0x48F321C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E2E"), Address(RVA = "0x48F3224", Offset = "0x48F3224", VA = "0x48F3224")] set
      {
      }
    }

    [Token(Token = "0x17001C61")]
    public int LevelUpVitality
    {
      [Token(Token = "0x6009E2F"), Address(RVA = "0x48F322C", Offset = "0x48F322C", VA = "0x48F322C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E30"), Address(RVA = "0x48F3234", Offset = "0x48F3234", VA = "0x48F3234")] set
      {
      }
    }

    [Token(Token = "0x17001C62")]
    public int LevelUpMind
    {
      [Token(Token = "0x6009E31"), Address(RVA = "0x48F323C", Offset = "0x48F323C", VA = "0x48F323C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E32"), Address(RVA = "0x48F3244", Offset = "0x48F3244", VA = "0x48F3244")] set
      {
      }
    }

    [Token(Token = "0x17001C63")]
    public int LevelUpAgility
    {
      [Token(Token = "0x6009E33"), Address(RVA = "0x48F324C", Offset = "0x48F324C", VA = "0x48F324C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E34"), Address(RVA = "0x48F3254", Offset = "0x48F3254", VA = "0x48F3254")] set
      {
      }
    }

    [Token(Token = "0x17001C64")]
    public int LevelUpDexterity
    {
      [Token(Token = "0x6009E35"), Address(RVA = "0x48F325C", Offset = "0x48F325C", VA = "0x48F325C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E36"), Address(RVA = "0x48F3264", Offset = "0x48F3264", VA = "0x48F3264")] set
      {
      }
    }

    [Token(Token = "0x17001C65")]
    public int LevelUpLucky
    {
      [Token(Token = "0x6009E37"), Address(RVA = "0x48F326C", Offset = "0x48F326C", VA = "0x48F326C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E38"), Address(RVA = "0x48F3274", Offset = "0x48F3274", VA = "0x48F3274")] set
      {
      }
    }

    [Token(Token = "0x17001C66")]
    public int AwakeCount
    {
      [Token(Token = "0x6009E39"), Address(RVA = "0x48F327C", Offset = "0x48F327C", VA = "0x48F327C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E3A"), Address(RVA = "0x48F3284", Offset = "0x48F3284", VA = "0x48F3284")] set
      {
      }
    }

    [Token(Token = "0x17001C67")]
    public int RarityStar
    {
      [Token(Token = "0x6009E3B"), Address(RVA = "0x48F328C", Offset = "0x48F328C", VA = "0x48F328C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E3C"), Address(RVA = "0x48F3294", Offset = "0x48F3294", VA = "0x48F3294")] set
      {
      }
    }

    [Token(Token = "0x17001C68")]
    public int AiType
    {
      [Token(Token = "0x6009E3D"), Address(RVA = "0x48F329C", Offset = "0x48F329C", VA = "0x48F329C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E3E"), Address(RVA = "0x48F32A4", Offset = "0x48F32A4", VA = "0x48F32A4")] set
      {
      }
    }

    [Token(Token = "0x17001C69")]
    public bool IsUnitTrustReleased
    {
      [Token(Token = "0x6009E3F"), Address(RVA = "0x48F32AC", Offset = "0x48F32AC", VA = "0x48F32AC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009E40"), Address(RVA = "0x48F32B4", Offset = "0x48F32B4", VA = "0x48F32B4")] set
      {
      }
    }

    [Token(Token = "0x17001C6A")]
    public bool IsFavorite
    {
      [Token(Token = "0x6009E41"), Address(RVA = "0x48F32C0", Offset = "0x48F32C0", VA = "0x48F32C0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009E42"), Address(RVA = "0x48F32C8", Offset = "0x48F32C8", VA = "0x48F32C8")] set
      {
      }
    }

    [Token(Token = "0x17001C6B")]
    public List<PlayerUnitSkillType> PlayerUnitSkills
    {
      [Token(Token = "0x6009E43"), Address(RVA = "0x48F32D4", Offset = "0x48F32D4", VA = "0x48F32D4")] get
      {
        return (List<PlayerUnitSkillType>) null;
      }
      [Token(Token = "0x6009E44"), Address(RVA = "0x48F32DC", Offset = "0x48F32DC", VA = "0x48F32DC")] set
      {
      }
    }

    [Token(Token = "0x17001C6C")]
    public List<PlayerUnitAbilityBoardParameterType> PlayerUnitAbilityBoardParameter
    {
      [Token(Token = "0x6009E45"), Address(RVA = "0x48F32E4", Offset = "0x48F32E4", VA = "0x48F32E4")] get
      {
        return (List<PlayerUnitAbilityBoardParameterType>) null;
      }
      [Token(Token = "0x6009E46"), Address(RVA = "0x48F32EC", Offset = "0x48F32EC", VA = "0x48F32EC")] set
      {
      }
    }

    [Token(Token = "0x17001C6D")]
    public int AbilityBoardNodeReleaseCount
    {
      [Token(Token = "0x6009E47"), Address(RVA = "0x48F32F4", Offset = "0x48F32F4", VA = "0x48F32F4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E48"), Address(RVA = "0x48F32FC", Offset = "0x48F32FC", VA = "0x48F32FC")] set
      {
      }
    }

    [Token(Token = "0x17001C6E")]
    public PlayerUnitEquipmentSetType PlayerUnitEquipmentSet
    {
      [Token(Token = "0x6009E49"), Address(RVA = "0x48F3304", Offset = "0x48F3304", VA = "0x48F3304")] get
      {
        return (PlayerUnitEquipmentSetType) null;
      }
      [Token(Token = "0x6009E4A"), Address(RVA = "0x48F330C", Offset = "0x48F330C", VA = "0x48F330C")] set
      {
      }
    }

    [Token(Token = "0x17001C6F")]
    public int IncreaseSkillCost
    {
      [Token(Token = "0x6009E4B"), Address(RVA = "0x48F3314", Offset = "0x48F3314", VA = "0x48F3314")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E4C"), Address(RVA = "0x48F331C", Offset = "0x48F331C", VA = "0x48F331C")] set
      {
      }
    }

    [Token(Token = "0x17001C70")]
    public int ReincarnationCount
    {
      [Token(Token = "0x6009E4D"), Address(RVA = "0x48F3324", Offset = "0x48F3324", VA = "0x48F3324")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E4E"), Address(RVA = "0x48F332C", Offset = "0x48F332C", VA = "0x48F332C")] set
      {
      }
    }

    [Token(Token = "0x6009E4F")]
    [Address(RVA = "0x48F3334", Offset = "0x48F3334", VA = "0x48F3334")]
    public PlayerUnitType()
    {
    }
  }
}
