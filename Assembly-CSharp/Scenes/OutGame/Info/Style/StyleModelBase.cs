// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Style.StyleModelBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Character;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Skill;
using System;
using System.Collections.Generic;
using TeamOrganization;

#nullable disable
namespace Scenes.OutGame.Info.Style
{
  [Token(Token = "0x2003553")]
  public abstract class StyleModelBase
  {
    [Token(Token = "0x400E7F2")]
    [FieldOffset(Offset = "0x70")]
    protected HashSet<int> UnlockedSlot;

    [Token(Token = "0x17004568")]
    public ICharacterModel Character
    {
      [Token(Token = "0x6014ECD"), Address(RVA = "0x1B4BA30", Offset = "0x1B4BA30", VA = "0x1B4BA30")] get
      {
        return (ICharacterModel) null;
      }
      [Token(Token = "0x6014ECE"), Address(RVA = "0x1B4BA38", Offset = "0x1B4BA38", VA = "0x1B4BA38")] protected set
      {
      }
    }

    [Token(Token = "0x17004569")]
    public int StyleID
    {
      [Token(Token = "0x6014ECF"), Address(RVA = "0x1B4BA40", Offset = "0x1B4BA40", VA = "0x1B4BA40")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700456A")]
    public StyleData StyleData
    {
      [Token(Token = "0x6014ED0"), Address(RVA = "0x1B4BA5C", Offset = "0x1B4BA5C", VA = "0x1B4BA5C")] get
      {
        return (StyleData) null;
      }
      [Token(Token = "0x6014ED1"), Address(RVA = "0x1B4BA64", Offset = "0x1B4BA64", VA = "0x1B4BA64")] protected set
      {
      }
    }

    [Token(Token = "0x1700456B")]
    public MoveTypeEnum MoveType
    {
      [Token(Token = "0x6014ED2"), Address(RVA = "0x1B4BA6C", Offset = "0x1B4BA6C", VA = "0x1B4BA6C")] get
      {
        return new MoveTypeEnum();
      }
      [Token(Token = "0x6014ED3"), Address(RVA = "0x1B4BA74", Offset = "0x1B4BA74", VA = "0x1B4BA74")] protected set
      {
      }
    }

    [Token(Token = "0x1700456C")]
    public ArmorTypeEnum ArmorType
    {
      [Token(Token = "0x6014ED4"), Address(RVA = "0x1B4BA7C", Offset = "0x1B4BA7C", VA = "0x1B4BA7C")] get
      {
        return new ArmorTypeEnum();
      }
      [Token(Token = "0x6014ED5"), Address(RVA = "0x1B4BA84", Offset = "0x1B4BA84", VA = "0x1B4BA84")] protected set
      {
      }
    }

    [Token(Token = "0x1700456D")]
    public RideTypeEnum RideType
    {
      [Token(Token = "0x6014ED6"), Address(RVA = "0x1B4BA8C", Offset = "0x1B4BA8C", VA = "0x1B4BA8C")] get
      {
        return new RideTypeEnum();
      }
      [Token(Token = "0x6014ED7"), Address(RVA = "0x1B4BA94", Offset = "0x1B4BA94", VA = "0x1B4BA94")] protected set
      {
      }
    }

    [Token(Token = "0x1700456E")]
    public int Level
    {
      [Token(Token = "0x6014ED8"), Address(RVA = "0x1B4BA9C", Offset = "0x1B4BA9C", VA = "0x1B4BA9C")] get
      {
        return new int();
      }
      [Token(Token = "0x6014ED9"), Address(RVA = "0x1B4BAA4", Offset = "0x1B4BAA4", VA = "0x1B4BAA4")] protected set
      {
      }
    }

    [Token(Token = "0x1700456F")]
    public int LevelMax
    {
      [Token(Token = "0x6014EDA"), Address(RVA = "0x1B4BAAC", Offset = "0x1B4BAAC", VA = "0x1B4BAAC")] get
      {
        return new int();
      }
      [Token(Token = "0x6014EDB"), Address(RVA = "0x1B4BAB4", Offset = "0x1B4BAB4", VA = "0x1B4BAB4")] protected set
      {
      }
    }

    [Token(Token = "0x17004570")]
    public int RarityStar
    {
      [Token(Token = "0x6014EDC"), Address(RVA = "0x1B4BABC", Offset = "0x1B4BABC", VA = "0x1B4BABC")] get
      {
        return new int();
      }
      [Token(Token = "0x6014EDD"), Address(RVA = "0x1B4BAC4", Offset = "0x1B4BAC4", VA = "0x1B4BAC4")] protected set
      {
      }
    }

    [Token(Token = "0x17004571")]
    public int LimitBreak
    {
      [Token(Token = "0x6014EDE"), Address(RVA = "0x1B4BACC", Offset = "0x1B4BACC", VA = "0x1B4BACC")] get
      {
        return new int();
      }
      [Token(Token = "0x6014EDF"), Address(RVA = "0x1B4BAD4", Offset = "0x1B4BAD4", VA = "0x1B4BAD4")] protected set
      {
      }
    }

    [Token(Token = "0x17004572")]
    public int LimitBreakMax
    {
      [Token(Token = "0x6014EE0"), Address(RVA = "0x1B4BADC", Offset = "0x1B4BADC", VA = "0x1B4BADC")] get
      {
        return new int();
      }
      [Token(Token = "0x6014EE1"), Address(RVA = "0x1B4BAE4", Offset = "0x1B4BAE4", VA = "0x1B4BAE4")] protected set
      {
      }
    }

    [Token(Token = "0x17004573")]
    public string CharacterName
    {
      [Token(Token = "0x6014EE2"), Address(RVA = "0x1B4BAEC", Offset = "0x1B4BAEC", VA = "0x1B4BAEC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6014EE3"), Address(RVA = "0x1B4BAF4", Offset = "0x1B4BAF4", VA = "0x1B4BAF4")] protected set
      {
      }
    }

    [Token(Token = "0x17004574")]
    public string StyleName
    {
      [Token(Token = "0x6014EE4"), Address(RVA = "0x1B4BAFC", Offset = "0x1B4BAFC", VA = "0x1B4BAFC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6014EE5"), Address(RVA = "0x1B4BB04", Offset = "0x1B4BB04", VA = "0x1B4BB04")] protected set
      {
      }
    }

    [Token(Token = "0x17004575")]
    public string ClassName
    {
      [Token(Token = "0x6014EE6"), Address(RVA = "0x1B4BB0C", Offset = "0x1B4BB0C", VA = "0x1B4BB0C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6014EE7"), Address(RVA = "0x1B4BB14", Offset = "0x1B4BB14", VA = "0x1B4BB14")] protected set
      {
      }
    }

    [Token(Token = "0x17004576")]
    public string[] Group
    {
      [Token(Token = "0x6014EE8"), Address(RVA = "0x1B4BB1C", Offset = "0x1B4BB1C", VA = "0x1B4BB1C")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x6014EE9"), Address(RVA = "0x1B4BB24", Offset = "0x1B4BB24", VA = "0x1B4BB24")] protected set
      {
      }
    }

    [Token(Token = "0x17004577")]
    public SpeciesTypeEnum[] SpeciesType
    {
      [Token(Token = "0x6014EEA"), Address(RVA = "0x1B4BB2C", Offset = "0x1B4BB2C", VA = "0x1B4BB2C")] get
      {
        return (SpeciesTypeEnum[]) null;
      }
      [Token(Token = "0x6014EEB"), Address(RVA = "0x1B4BB34", Offset = "0x1B4BB34", VA = "0x1B4BB34")] protected set
      {
      }
    }

    [Token(Token = "0x17004578")]
    public string Flavor
    {
      [Token(Token = "0x6014EEC"), Address(RVA = "0x1B4BB3C", Offset = "0x1B4BB3C", VA = "0x1B4BB3C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6014EED"), Address(RVA = "0x1B4BB44", Offset = "0x1B4BB44", VA = "0x1B4BB44")] protected set
      {
      }
    }

    [Token(Token = "0x17004579")]
    public abstract AdditionalParameterModelBase AdditionalParameter { [Token(Token = "0x6014EEE")] get; }

    [Token(Token = "0x1700457A")]
    public abstract SkillModelListBase StyleSkills { [Token(Token = "0x6014EEF")] get; }

    [Token(Token = "0x1700457B")]
    public abstract SkillModelListBase UnlockedStyleSkills { [Token(Token = "0x6014EF0")] get; }

    [Token(Token = "0x1700457C")]
    public abstract SkillModelListBase CommuSkills { [Token(Token = "0x6014EF1")] get; }

    [Token(Token = "0x1700457D")]
    public abstract SkillModelListBase UnlockedCommuSkills { [Token(Token = "0x6014EF2")] get; }

    [Token(Token = "0x1400020C")]
    public abstract event Action OnChange;

    [Token(Token = "0x6014EF5")]
    [Address(RVA = "0x1B4BB4C", Offset = "0x1B4BB4C", VA = "0x1B4BB4C", Slot = "11")]
    public virtual (string, string) GetStyleThumbnailAssetInfo() => ();

    [Token(Token = "0x6014EF6")]
    [Address(RVA = "0x1B4BBE0", Offset = "0x1B4BBE0", VA = "0x1B4BBE0", Slot = "12")]
    public virtual (string, string) GetStyleDotAssetInfo() => ();

    [Token(Token = "0x6014EF7")]
    [Address(RVA = "0x1B4BC74", Offset = "0x1B4BC74", VA = "0x1B4BC74")]
    public bool IsUnlocked(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return new bool();
    }

    [Token(Token = "0x6014EF8")]
    [Address(RVA = "0x1B4BCCC", Offset = "0x1B4BCCC", VA = "0x1B4BCCC")]
    public bool IsUnlockedSkill(int skillID) => new bool();

    [Token(Token = "0x6014EF9")]
    [Address(RVA = "0x1B4BE44", Offset = "0x1B4BE44", VA = "0x1B4BE44")]
    protected StyleModelBase()
    {
    }
  }
}
