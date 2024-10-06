// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.NpcUnitDataData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E5A")]
  [Serializable]
  public sealed class NpcUnitDataData : IMasterDataEntity
  {
    [Token(Token = "0x4004529")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400452A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int StyleID;
    [Token(Token = "0x400452B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int Level;
    [Token(Token = "0x400452C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int ClassID;
    [Token(Token = "0x400452D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int AutoTypeID;
    [Token(Token = "0x400452E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int Life;
    [Token(Token = "0x400452F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int Strength;
    [Token(Token = "0x4004530")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int Intelligence;
    [Token(Token = "0x4004531")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int Vitality;
    [Token(Token = "0x4004532")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int Mind;
    [Token(Token = "0x4004533")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int Agility;
    [Token(Token = "0x4004534")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int Dexterity;
    [Token(Token = "0x4004535")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int Lucky;
    [Token(Token = "0x4004536")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int OverrideHPStock1;
    [Token(Token = "0x4004537")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int OverrideHPStock2;
    [Token(Token = "0x4004538")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int OverrideHPStock3;
    [Token(Token = "0x4004539")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int OverrideHPStock4;
    [Token(Token = "0x400453A")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int OverrideHPStock5;
    [Token(Token = "0x400453B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int OverrideHPStock6;
    [Token(Token = "0x400453C")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int OverrideHPStock7;
    [Token(Token = "0x400453D")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int OverrideHPStock8;
    [Token(Token = "0x400453E")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int OverrideHPStock9;
    [Token(Token = "0x400453F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public ProficiencyTypeEnum MainWeaponProficiency;
    [Token(Token = "0x4004540")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    public ProficiencyTypeEnum SubWeaponProficiency;
    [Token(Token = "0x4004541")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public int MainWeaponID;
    [Token(Token = "0x4004542")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    public int MainWeaponLevel;
    [Token(Token = "0x4004543")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public int MainWeaponSkillLevel;
    [Token(Token = "0x4004544")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    public int MainWeaponOption;
    [Token(Token = "0x4004545")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    public int SubWeaponID;
    [Token(Token = "0x4004546")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    public int SubWeaponLevel;
    [Token(Token = "0x4004547")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    public int SubWeaponSkillLevel;
    [Token(Token = "0x4004548")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    public int SubWeaponOption;
    [Token(Token = "0x4004549")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    public int SubWeapon2ID;
    [Token(Token = "0x400454A")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    public int SubWeapon2Level;
    [Token(Token = "0x400454B")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    public int SubWeapon2SkillLevel;
    [Token(Token = "0x400454C")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    public int SubWeapon2Option;
    [Token(Token = "0x400454D")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    public int AccessoryID1;
    [Token(Token = "0x400454E")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    public int AccessoryLevel1;
    [Token(Token = "0x400454F")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    public int AccessoryID2;
    [Token(Token = "0x4004550")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    public int AccessoryLevel2;
    [Token(Token = "0x4004551")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    public int AccessoryID3;
    [Token(Token = "0x4004552")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    public int AccessoryLevel3;
    [Token(Token = "0x4004553")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    public int MindEquipmentID;
    [Token(Token = "0x4004554")]
    [FieldOffset(Offset = "0xBC")]
    [SerializeField]
    public int MindEquipmentLevel;
    [Token(Token = "0x4004555")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    public int UnitSkillID1;
    [Token(Token = "0x4004556")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    public int UnitSkillLevel1;
    [Token(Token = "0x4004557")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    public int UnitSkillID2;
    [Token(Token = "0x4004558")]
    [FieldOffset(Offset = "0xCC")]
    [SerializeField]
    public int UnitSkillLevel2;
    [Token(Token = "0x4004559")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    public int UnitSkillID3;
    [Token(Token = "0x400455A")]
    [FieldOffset(Offset = "0xD4")]
    [SerializeField]
    public int UnitSkillLevel3;
    [Token(Token = "0x400455B")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    public int UnitSkillID4;
    [Token(Token = "0x400455C")]
    [FieldOffset(Offset = "0xDC")]
    [SerializeField]
    public int UnitSkillLevel4;
    [Token(Token = "0x400455D")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    public int UnitSkillID5;
    [Token(Token = "0x400455E")]
    [FieldOffset(Offset = "0xE4")]
    [SerializeField]
    public int UnitSkillLevel5;
    [Token(Token = "0x400455F")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    public int UnitSkillID6;
    [Token(Token = "0x4004560")]
    [FieldOffset(Offset = "0xEC")]
    [SerializeField]
    public int UnitSkillLevel6;
    [Token(Token = "0x4004561")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    public int CustomSkill1;
    [Token(Token = "0x4004562")]
    [FieldOffset(Offset = "0xF4")]
    [SerializeField]
    public int CustomSkillLevel1;
    [Token(Token = "0x4004563")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    public int CustomSkill2;
    [Token(Token = "0x4004564")]
    [FieldOffset(Offset = "0xFC")]
    [SerializeField]
    public int CustomSkillLevel2;
    [Token(Token = "0x4004565")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    public int CustomSkill3;
    [Token(Token = "0x4004566")]
    [FieldOffset(Offset = "0x104")]
    [SerializeField]
    public int CustomSkillLevel3;
    [Token(Token = "0x4004567")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    public int CustomSkill4;
    [Token(Token = "0x4004568")]
    [FieldOffset(Offset = "0x10C")]
    [SerializeField]
    public int CustomSkillLevel4;
    [Token(Token = "0x4004569")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    public int CustomSkill5;
    [Token(Token = "0x400456A")]
    [FieldOffset(Offset = "0x114")]
    [SerializeField]
    public int CustomSkillLevel5;
    [Token(Token = "0x400456B")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    public int CustomSkill6;
    [Token(Token = "0x400456C")]
    [FieldOffset(Offset = "0x11C")]
    [SerializeField]
    public int CustomSkillLevel6;
    [Token(Token = "0x400456D")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    public int CustomSkill7;
    [Token(Token = "0x400456E")]
    [FieldOffset(Offset = "0x124")]
    [SerializeField]
    public int CustomSkillLevel7;
    [Token(Token = "0x400456F")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    public int CustomSkill8;
    [Token(Token = "0x4004570")]
    [FieldOffset(Offset = "0x12C")]
    [SerializeField]
    public int CustomSkillLevel8;
    [Token(Token = "0x4004571")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    public int CustomSkill9;
    [Token(Token = "0x4004572")]
    [FieldOffset(Offset = "0x134")]
    [SerializeField]
    public int CustomSkillLevel9;
    [Token(Token = "0x4004573")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    public int CustomSkill10;
    [Token(Token = "0x4004574")]
    [FieldOffset(Offset = "0x13C")]
    [SerializeField]
    public int CustomSkillLevel10;

    [Token(Token = "0x17000CDB")]
    public int Key
    {
      [Token(Token = "0x6005775"), Address(RVA = "0x3E3EF78", Offset = "0x3E3EF78", VA = "0x3E3EF78", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005776")]
    [Address(RVA = "0x3E3EF80", Offset = "0x3E3EF80", VA = "0x3E3EF80", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005777")]
    [Address(RVA = "0x3E40C4C", Offset = "0x3E40C4C", VA = "0x3E40C4C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000CDC")]
    public IReadOnlyList<int> OverrideHPStocks
    {
      [Token(Token = "0x6005778"), Address(RVA = "0x3E41170", Offset = "0x3E41170", VA = "0x3E41170")] get
      {
        return (IReadOnlyList<int>) null;
      }
      [Token(Token = "0x6005779"), Address(RVA = "0x3E41178", Offset = "0x3E41178", VA = "0x3E41178")] private set
      {
      }
    }

    [Token(Token = "0x17000CDD")]
    public bool IsOverrideHP
    {
      [Token(Token = "0x600577A"), Address(RVA = "0x3E41180", Offset = "0x3E41180", VA = "0x3E41180")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000CDE")]
    public IReadOnlyList<(int id, int level)> Accessories
    {
      [Token(Token = "0x600577B"), Address(RVA = "0x3E41230", Offset = "0x3E41230", VA = "0x3E41230")] get
      {
        return (IReadOnlyList<(int, int)>) null;
      }
      [Token(Token = "0x600577C"), Address(RVA = "0x3E41238", Offset = "0x3E41238", VA = "0x3E41238")] private set
      {
      }
    }

    [Token(Token = "0x17000CDF")]
    public IReadOnlyList<(int id, int level)> CustomSkills
    {
      [Token(Token = "0x600577D"), Address(RVA = "0x3E41240", Offset = "0x3E41240", VA = "0x3E41240")] get
      {
        return (IReadOnlyList<(int, int)>) null;
      }
      [Token(Token = "0x600577E"), Address(RVA = "0x3E41248", Offset = "0x3E41248", VA = "0x3E41248")] private set
      {
      }
    }

    [Token(Token = "0x17000CE0")]
    public IReadOnlyList<(int id, int level)> UnitSkills
    {
      [Token(Token = "0x600577F"), Address(RVA = "0x3E41250", Offset = "0x3E41250", VA = "0x3E41250")] get
      {
        return (IReadOnlyList<(int, int)>) null;
      }
      [Token(Token = "0x6005780"), Address(RVA = "0x3E41258", Offset = "0x3E41258", VA = "0x3E41258")] private set
      {
      }
    }

    [Token(Token = "0x6005781")]
    [Address(RVA = "0x3E3E174", Offset = "0x3E3E174", VA = "0x3E3E174")]
    public void OnCompletedLoad()
    {
    }

    [Token(Token = "0x6005782")]
    [Address(RVA = "0x3E41260", Offset = "0x3E41260", VA = "0x3E41260")]
    public NpcUnitDataData()
    {
    }
  }
}
