// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitCharacterType
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
  [Token(Token = "0x2001AF5")]
  [Serializable]
  public class PlayerUnitCharacterType
  {
    [Token(Token = "0x40073AB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x40073AC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int character_id;
    [Token(Token = "0x40073AD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string created_at;
    [Token(Token = "0x40073AE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string updated_at;
    [Token(Token = "0x40073AF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<string> player_unit_support_ids;
    [Token(Token = "0x40073B0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string expedition_player_unit_id;
    [Token(Token = "0x40073B1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private int release_state;
    [Token(Token = "0x40073B2")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private int parara_life;
    [Token(Token = "0x40073B3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private int parara_strength;
    [Token(Token = "0x40073B4")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private int parara_intelligence;
    [Token(Token = "0x40073B5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private int parara_vitality;
    [Token(Token = "0x40073B6")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private int parara_mind;
    [Token(Token = "0x40073B7")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private int parara_agility;
    [Token(Token = "0x40073B8")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private int parara_dexterity;
    [Token(Token = "0x40073B9")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private int parara_lucky;
    [Token(Token = "0x40073BA")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private List<PlayerUnitCharacterWeaponProficiencyType> player_unit_character_weapon_proficiencies;
    [Token(Token = "0x40073BB")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private int lp;
    [Token(Token = "0x40073BC")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private string last_lost_at;

    [Token(Token = "0x17001C0D")]
    public string Id
    {
      [Token(Token = "0x6009D7A"), Address(RVA = "0x48F2C80", Offset = "0x48F2C80", VA = "0x48F2C80")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D7B"), Address(RVA = "0x48F2C88", Offset = "0x48F2C88", VA = "0x48F2C88")] set
      {
      }
    }

    [Token(Token = "0x17001C0E")]
    public int CharacterId
    {
      [Token(Token = "0x6009D7C"), Address(RVA = "0x48F2C90", Offset = "0x48F2C90", VA = "0x48F2C90")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D7D"), Address(RVA = "0x48F2C98", Offset = "0x48F2C98", VA = "0x48F2C98")] set
      {
      }
    }

    [Token(Token = "0x17001C0F")]
    public string CreatedAt
    {
      [Token(Token = "0x6009D7E"), Address(RVA = "0x48F2CA0", Offset = "0x48F2CA0", VA = "0x48F2CA0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D7F"), Address(RVA = "0x48F2CA8", Offset = "0x48F2CA8", VA = "0x48F2CA8")] set
      {
      }
    }

    [Token(Token = "0x17001C10")]
    public string UpdatedAt
    {
      [Token(Token = "0x6009D80"), Address(RVA = "0x48F2CB0", Offset = "0x48F2CB0", VA = "0x48F2CB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D81"), Address(RVA = "0x48F2CB8", Offset = "0x48F2CB8", VA = "0x48F2CB8")] set
      {
      }
    }

    [Token(Token = "0x17001C11")]
    public List<string> PlayerUnitSupportIds
    {
      [Token(Token = "0x6009D82"), Address(RVA = "0x48F2CC0", Offset = "0x48F2CC0", VA = "0x48F2CC0")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x6009D83"), Address(RVA = "0x48F2CC8", Offset = "0x48F2CC8", VA = "0x48F2CC8")] set
      {
      }
    }

    [Token(Token = "0x17001C12")]
    public string ExpeditionPlayerUnitId
    {
      [Token(Token = "0x6009D84"), Address(RVA = "0x48F2CD0", Offset = "0x48F2CD0", VA = "0x48F2CD0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D85"), Address(RVA = "0x48F2CD8", Offset = "0x48F2CD8", VA = "0x48F2CD8")] set
      {
      }
    }

    [Token(Token = "0x17001C13")]
    public int ReleaseState
    {
      [Token(Token = "0x6009D86"), Address(RVA = "0x48F2CE0", Offset = "0x48F2CE0", VA = "0x48F2CE0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D87"), Address(RVA = "0x48F2CE8", Offset = "0x48F2CE8", VA = "0x48F2CE8")] set
      {
      }
    }

    [Token(Token = "0x17001C14")]
    public int PararaLife
    {
      [Token(Token = "0x6009D88"), Address(RVA = "0x48F2CF0", Offset = "0x48F2CF0", VA = "0x48F2CF0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D89"), Address(RVA = "0x48F2CF8", Offset = "0x48F2CF8", VA = "0x48F2CF8")] set
      {
      }
    }

    [Token(Token = "0x17001C15")]
    public int PararaStrength
    {
      [Token(Token = "0x6009D8A"), Address(RVA = "0x48F2D00", Offset = "0x48F2D00", VA = "0x48F2D00")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D8B"), Address(RVA = "0x48F2D08", Offset = "0x48F2D08", VA = "0x48F2D08")] set
      {
      }
    }

    [Token(Token = "0x17001C16")]
    public int PararaIntelligence
    {
      [Token(Token = "0x6009D8C"), Address(RVA = "0x48F2D10", Offset = "0x48F2D10", VA = "0x48F2D10")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D8D"), Address(RVA = "0x48F2D18", Offset = "0x48F2D18", VA = "0x48F2D18")] set
      {
      }
    }

    [Token(Token = "0x17001C17")]
    public int PararaVitality
    {
      [Token(Token = "0x6009D8E"), Address(RVA = "0x48F2D20", Offset = "0x48F2D20", VA = "0x48F2D20")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D8F"), Address(RVA = "0x48F2D28", Offset = "0x48F2D28", VA = "0x48F2D28")] set
      {
      }
    }

    [Token(Token = "0x17001C18")]
    public int PararaMind
    {
      [Token(Token = "0x6009D90"), Address(RVA = "0x48F2D30", Offset = "0x48F2D30", VA = "0x48F2D30")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D91"), Address(RVA = "0x48F2D38", Offset = "0x48F2D38", VA = "0x48F2D38")] set
      {
      }
    }

    [Token(Token = "0x17001C19")]
    public int PararaAgility
    {
      [Token(Token = "0x6009D92"), Address(RVA = "0x48F2D40", Offset = "0x48F2D40", VA = "0x48F2D40")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D93"), Address(RVA = "0x48F2D48", Offset = "0x48F2D48", VA = "0x48F2D48")] set
      {
      }
    }

    [Token(Token = "0x17001C1A")]
    public int PararaDexterity
    {
      [Token(Token = "0x6009D94"), Address(RVA = "0x48F2D50", Offset = "0x48F2D50", VA = "0x48F2D50")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D95"), Address(RVA = "0x48F2D58", Offset = "0x48F2D58", VA = "0x48F2D58")] set
      {
      }
    }

    [Token(Token = "0x17001C1B")]
    public int PararaLucky
    {
      [Token(Token = "0x6009D96"), Address(RVA = "0x48F2D60", Offset = "0x48F2D60", VA = "0x48F2D60")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D97"), Address(RVA = "0x48F2D68", Offset = "0x48F2D68", VA = "0x48F2D68")] set
      {
      }
    }

    [Token(Token = "0x17001C1C")]
    public List<PlayerUnitCharacterWeaponProficiencyType> PlayerUnitCharacterWeaponProficiencies
    {
      [Token(Token = "0x6009D98"), Address(RVA = "0x48F2D70", Offset = "0x48F2D70", VA = "0x48F2D70")] get
      {
        return (List<PlayerUnitCharacterWeaponProficiencyType>) null;
      }
      [Token(Token = "0x6009D99"), Address(RVA = "0x48F2D78", Offset = "0x48F2D78", VA = "0x48F2D78")] set
      {
      }
    }

    [Token(Token = "0x17001C1D")]
    public int Lp
    {
      [Token(Token = "0x6009D9A"), Address(RVA = "0x48F2D80", Offset = "0x48F2D80", VA = "0x48F2D80")] get
      {
        return new int();
      }
      [Token(Token = "0x6009D9B"), Address(RVA = "0x48F2D88", Offset = "0x48F2D88", VA = "0x48F2D88")] set
      {
      }
    }

    [Token(Token = "0x17001C1E")]
    public string LastLostAt
    {
      [Token(Token = "0x6009D9C"), Address(RVA = "0x48F2D90", Offset = "0x48F2D90", VA = "0x48F2D90")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009D9D"), Address(RVA = "0x48F2D98", Offset = "0x48F2D98", VA = "0x48F2D98")] set
      {
      }
    }

    [Token(Token = "0x6009D9E")]
    [Address(RVA = "0x48F2DA0", Offset = "0x48F2DA0", VA = "0x48F2DA0")]
    public PlayerUnitCharacterType()
    {
    }
  }
}
