// Decompiled with JetBrains decompiler
// Type: StaqData.WeaponProficiency
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002111")]
  public class WeaponProficiency
  {
    [Token(Token = "0x4008C6C")]
    [FieldOffset(Offset = "0x10")]
    public Dictionary<WeaponTypeEnum, WeaponProficiency.LevelData> LevelMap;

    [Token(Token = "0x600CA38")]
    [Address(RVA = "0x1BA1D0C", Offset = "0x1BA1D0C", VA = "0x1BA1D0C")]
    public void SetData(
      ClassData classData,
      CharacterData characterData,
      List<PlayerUnitCharacterWeaponProficiencyType> playerUnitCharacterWeaponProficiencyType)
    {
    }

    [Token(Token = "0x600CA39")]
    [Address(RVA = "0x1BA246C", Offset = "0x1BA246C", VA = "0x1BA246C")]
    private void SetDictionary(
      WeaponTypeEnum weaponType,
      int exp,
      ProficiencyTypeEnum maxProficiencyType)
    {
    }

    [Token(Token = "0x600CA3A")]
    [Address(RVA = "0x1BA25AC", Offset = "0x1BA25AC", VA = "0x1BA25AC")]
    public void SetDataWithoutStyle(
      CharacterData characterData,
      IEnumerable<WeaponTypeEnum> needWeapons,
      List<PlayerUnitCharacterWeaponProficiencyType> playerUnitCharacterWeaponProficiencyType)
    {
    }

    [Token(Token = "0x600CA3B")]
    [Address(RVA = "0x1BA2C88", Offset = "0x1BA2C88", VA = "0x1BA2C88")]
    public void SetDataPlayableStyle(
      CharacterData characterData,
      IEnumerable<WeaponTypeEnum> needWeapons,
      List<PlayerUnitCharacterWeaponProficiencyType> playerUnitCharacterWeaponProficiencyType)
    {
    }

    [Token(Token = "0x600CA3C")]
    [Address(RVA = "0x1BA3724", Offset = "0x1BA3724", VA = "0x1BA3724")]
    public WeaponProficiency()
    {
    }

    [Token(Token = "0x2002112")]
    public class LevelData
    {
      [Token(Token = "0x17002C0A")]
      public int Exp
      {
        [Token(Token = "0x600CA3E"), Address(RVA = "0x1BA37A0", Offset = "0x1BA37A0", VA = "0x1BA37A0")] get
        {
          return new int();
        }
        [Token(Token = "0x600CA3F"), Address(RVA = "0x1BA37A8", Offset = "0x1BA37A8", VA = "0x1BA37A8")] private set
        {
        }
      }

      [Token(Token = "0x17002C0B")]
      public int TotalExp
      {
        [Token(Token = "0x600CA40"), Address(RVA = "0x1BA37B0", Offset = "0x1BA37B0", VA = "0x1BA37B0")] get
        {
          return new int();
        }
        [Token(Token = "0x600CA41"), Address(RVA = "0x1BA37B8", Offset = "0x1BA37B8", VA = "0x1BA37B8")] private set
        {
        }
      }

      [Token(Token = "0x17002C0C")]
      public int NextExp
      {
        [Token(Token = "0x600CA42"), Address(RVA = "0x1BA37C0", Offset = "0x1BA37C0", VA = "0x1BA37C0")] get
        {
          return new int();
        }
        [Token(Token = "0x600CA43"), Address(RVA = "0x1BA37C8", Offset = "0x1BA37C8", VA = "0x1BA37C8")] private set
        {
        }
      }

      [Token(Token = "0x17002C0D")]
      public float NextExpRate
      {
        [Token(Token = "0x600CA44"), Address(RVA = "0x1BA37D0", Offset = "0x1BA37D0", VA = "0x1BA37D0")] get
        {
          return new float();
        }
        [Token(Token = "0x600CA45"), Address(RVA = "0x1BA37D8", Offset = "0x1BA37D8", VA = "0x1BA37D8")] private set
        {
        }
      }

      [Token(Token = "0x17002C0E")]
      public ProficiencyTypeEnum ProficiencyType
      {
        [Token(Token = "0x600CA46"), Address(RVA = "0x1BA37E0", Offset = "0x1BA37E0", VA = "0x1BA37E0")] get
        {
          return new ProficiencyTypeEnum();
        }
        [Token(Token = "0x600CA47"), Address(RVA = "0x1BA37E8", Offset = "0x1BA37E8", VA = "0x1BA37E8")] private set
        {
        }
      }

      [Token(Token = "0x17002C0F")]
      public ProficiencyTypeEnum MaxProficiencyType
      {
        [Token(Token = "0x600CA48"), Address(RVA = "0x1BA37F0", Offset = "0x1BA37F0", VA = "0x1BA37F0")] get
        {
          return new ProficiencyTypeEnum();
        }
        [Token(Token = "0x600CA49"), Address(RVA = "0x1BA37F8", Offset = "0x1BA37F8", VA = "0x1BA37F8")] private set
        {
        }
      }

      [Token(Token = "0x17002C10")]
      public bool IsMax
      {
        [Token(Token = "0x600CA4A"), Address(RVA = "0x1BA3800", Offset = "0x1BA3800", VA = "0x1BA3800")] get
        {
          return new bool();
        }
        [Token(Token = "0x600CA4B"), Address(RVA = "0x1BA3808", Offset = "0x1BA3808", VA = "0x1BA3808")] private set
        {
        }
      }

      [Token(Token = "0x17002C11")]
      public WeaponProficiencyLevelData WeaponProficiencyLevel
      {
        [Token(Token = "0x600CA4C"), Address(RVA = "0x1BA3814", Offset = "0x1BA3814", VA = "0x1BA3814")] get
        {
          return (WeaponProficiencyLevelData) null;
        }
        [Token(Token = "0x600CA4D"), Address(RVA = "0x1BA381C", Offset = "0x1BA381C", VA = "0x1BA381C")] private set
        {
        }
      }

      [Token(Token = "0x600CA4E")]
      [Address(RVA = "0x1BA2578", Offset = "0x1BA2578", VA = "0x1BA2578")]
      public LevelData(int exp, ProficiencyTypeEnum maxProficiencyType)
      {
      }

      [Token(Token = "0x600CA4F")]
      [Address(RVA = "0x1BA3824", Offset = "0x1BA3824", VA = "0x1BA3824")]
      public void Set(int exp)
      {
      }

      [Token(Token = "0x600CA50")]
      [Address(RVA = "0x1BA371C", Offset = "0x1BA371C", VA = "0x1BA371C")]
      public void Set(ProficiencyTypeEnum maxProficiencyType)
      {
      }
    }
  }
}
