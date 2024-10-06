// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerGearAccessoryType
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
  [Token(Token = "0x2001AB9")]
  [Serializable]
  public class PlayerGearAccessoryType
  {
    [Token(Token = "0x4007285")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x4007286")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int accessory_id;
    [Token(Token = "0x4007287")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int experience;
    [Token(Token = "0x4007288")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int limit_break_count;
    [Token(Token = "0x4007289")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private bool is_favorite;
    [Token(Token = "0x400728A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerGearAccessorySkillType> player_gear_accessory_skills;
    [Token(Token = "0x400728B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerGearOptionType> player_gear_accessory_options;
    [Token(Token = "0x400728C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string created_at;

    [Token(Token = "0x17001ADB")]
    public string Id
    {
      [Token(Token = "0x6009AE6"), Address(RVA = "0x48F1734", Offset = "0x48F1734", VA = "0x48F1734")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009AE7"), Address(RVA = "0x48F173C", Offset = "0x48F173C", VA = "0x48F173C")] set
      {
      }
    }

    [Token(Token = "0x17001ADC")]
    public int AccessoryId
    {
      [Token(Token = "0x6009AE8"), Address(RVA = "0x48F1744", Offset = "0x48F1744", VA = "0x48F1744")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AE9"), Address(RVA = "0x48F174C", Offset = "0x48F174C", VA = "0x48F174C")] set
      {
      }
    }

    [Token(Token = "0x17001ADD")]
    public int Experience
    {
      [Token(Token = "0x6009AEA"), Address(RVA = "0x48F1754", Offset = "0x48F1754", VA = "0x48F1754")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AEB"), Address(RVA = "0x48F175C", Offset = "0x48F175C", VA = "0x48F175C")] set
      {
      }
    }

    [Token(Token = "0x17001ADE")]
    public int LimitBreakCount
    {
      [Token(Token = "0x6009AEC"), Address(RVA = "0x48F1764", Offset = "0x48F1764", VA = "0x48F1764")] get
      {
        return new int();
      }
      [Token(Token = "0x6009AED"), Address(RVA = "0x48F176C", Offset = "0x48F176C", VA = "0x48F176C")] set
      {
      }
    }

    [Token(Token = "0x17001ADF")]
    public bool IsFavorite
    {
      [Token(Token = "0x6009AEE"), Address(RVA = "0x48F1774", Offset = "0x48F1774", VA = "0x48F1774")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009AEF"), Address(RVA = "0x48F177C", Offset = "0x48F177C", VA = "0x48F177C")] set
      {
      }
    }

    [Token(Token = "0x17001AE0")]
    public List<PlayerGearAccessorySkillType> PlayerGearAccessorySkills
    {
      [Token(Token = "0x6009AF0"), Address(RVA = "0x48F1788", Offset = "0x48F1788", VA = "0x48F1788")] get
      {
        return (List<PlayerGearAccessorySkillType>) null;
      }
      [Token(Token = "0x6009AF1"), Address(RVA = "0x48F1790", Offset = "0x48F1790", VA = "0x48F1790")] set
      {
      }
    }

    [Token(Token = "0x17001AE1")]
    public List<PlayerGearOptionType> PlayerGearAccessoryOptions
    {
      [Token(Token = "0x6009AF2"), Address(RVA = "0x48F1798", Offset = "0x48F1798", VA = "0x48F1798")] get
      {
        return (List<PlayerGearOptionType>) null;
      }
      [Token(Token = "0x6009AF3"), Address(RVA = "0x48F17A0", Offset = "0x48F17A0", VA = "0x48F17A0")] set
      {
      }
    }

    [Token(Token = "0x17001AE2")]
    public string CreatedAt
    {
      [Token(Token = "0x6009AF4"), Address(RVA = "0x48F17A8", Offset = "0x48F17A8", VA = "0x48F17A8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009AF5"), Address(RVA = "0x48F17B0", Offset = "0x48F17B0", VA = "0x48F17B0")] set
      {
      }
    }

    [Token(Token = "0x6009AF6")]
    [Address(RVA = "0x48F17B8", Offset = "0x48F17B8", VA = "0x48F17B8")]
    public PlayerGearAccessoryType()
    {
    }
  }
}
