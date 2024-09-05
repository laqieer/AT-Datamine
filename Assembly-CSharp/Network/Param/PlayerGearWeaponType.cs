// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGearWeaponType
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
  [Token(Token = "0x2001AC1")]
  [Serializable]
  public class PlayerGearWeaponType
  {
    [Token(Token = "0x40072A6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x40072A7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int weapon_id;
    [Token(Token = "0x40072A8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int experience;
    [Token(Token = "0x40072A9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool is_favorite;
    [Token(Token = "0x40072AA")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int brand_id;
    [Token(Token = "0x40072AB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerGearWeaponSkillType> player_gear_weapon_skills;
    [Token(Token = "0x40072AC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerGearOptionType> player_gear_weapon_options;
    [Token(Token = "0x40072AD")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PlayerGearWeaponAdditionalEffectType player_gear_weapon_additional_effect;
    [Token(Token = "0x40072AE")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private int limit_break_count;
    [Token(Token = "0x40072AF")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private string created_at;

    [Token(Token = "0x17001AFC")]
    public string Id
    {
      [Token(Token = "0x6009B30"), Address(RVA = "0x48F1990", Offset = "0x48F1990", VA = "0x48F1990")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009B31"), Address(RVA = "0x48F1998", Offset = "0x48F1998", VA = "0x48F1998")] set
      {
      }
    }

    [Token(Token = "0x17001AFD")]
    public int WeaponId
    {
      [Token(Token = "0x6009B32"), Address(RVA = "0x48F19A0", Offset = "0x48F19A0", VA = "0x48F19A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B33"), Address(RVA = "0x48F19A8", Offset = "0x48F19A8", VA = "0x48F19A8")] set
      {
      }
    }

    [Token(Token = "0x17001AFE")]
    public int Experience
    {
      [Token(Token = "0x6009B34"), Address(RVA = "0x48F19B0", Offset = "0x48F19B0", VA = "0x48F19B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B35"), Address(RVA = "0x48F19B8", Offset = "0x48F19B8", VA = "0x48F19B8")] set
      {
      }
    }

    [Token(Token = "0x17001AFF")]
    public bool IsFavorite
    {
      [Token(Token = "0x6009B36"), Address(RVA = "0x48F19C0", Offset = "0x48F19C0", VA = "0x48F19C0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009B37"), Address(RVA = "0x48F19C8", Offset = "0x48F19C8", VA = "0x48F19C8")] set
      {
      }
    }

    [Token(Token = "0x17001B00")]
    public int BrandId
    {
      [Token(Token = "0x6009B38"), Address(RVA = "0x48F19D4", Offset = "0x48F19D4", VA = "0x48F19D4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B39"), Address(RVA = "0x48F19DC", Offset = "0x48F19DC", VA = "0x48F19DC")] set
      {
      }
    }

    [Token(Token = "0x17001B01")]
    public List<PlayerGearWeaponSkillType> PlayerGearWeaponSkills
    {
      [Token(Token = "0x6009B3A"), Address(RVA = "0x48F19E4", Offset = "0x48F19E4", VA = "0x48F19E4")] get
      {
        return (List<PlayerGearWeaponSkillType>) null;
      }
      [Token(Token = "0x6009B3B"), Address(RVA = "0x48F19EC", Offset = "0x48F19EC", VA = "0x48F19EC")] set
      {
      }
    }

    [Token(Token = "0x17001B02")]
    public List<PlayerGearOptionType> PlayerGearWeaponOptions
    {
      [Token(Token = "0x6009B3C"), Address(RVA = "0x48F19F4", Offset = "0x48F19F4", VA = "0x48F19F4")] get
      {
        return (List<PlayerGearOptionType>) null;
      }
      [Token(Token = "0x6009B3D"), Address(RVA = "0x48F19FC", Offset = "0x48F19FC", VA = "0x48F19FC")] set
      {
      }
    }

    [Token(Token = "0x17001B03")]
    public PlayerGearWeaponAdditionalEffectType PlayerGearWeaponAdditionalEffect
    {
      [Token(Token = "0x6009B3E"), Address(RVA = "0x48F1A04", Offset = "0x48F1A04", VA = "0x48F1A04")] get
      {
        return (PlayerGearWeaponAdditionalEffectType) null;
      }
      [Token(Token = "0x6009B3F"), Address(RVA = "0x48F1A0C", Offset = "0x48F1A0C", VA = "0x48F1A0C")] set
      {
      }
    }

    [Token(Token = "0x17001B04")]
    public int LimitBreakCount
    {
      [Token(Token = "0x6009B40"), Address(RVA = "0x48F1A14", Offset = "0x48F1A14", VA = "0x48F1A14")] get
      {
        return new int();
      }
      [Token(Token = "0x6009B41"), Address(RVA = "0x48F1A1C", Offset = "0x48F1A1C", VA = "0x48F1A1C")] set
      {
      }
    }

    [Token(Token = "0x17001B05")]
    public string CreatedAt
    {
      [Token(Token = "0x6009B42"), Address(RVA = "0x48F1A24", Offset = "0x48F1A24", VA = "0x48F1A24")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009B43"), Address(RVA = "0x48F1A2C", Offset = "0x48F1A2C", VA = "0x48F1A2C")] set
      {
      }
    }

    [Token(Token = "0x6009B44")]
    [Address(RVA = "0x48F1A34", Offset = "0x48F1A34", VA = "0x48F1A34")]
    public PlayerGearWeaponType()
    {
    }
  }
}
