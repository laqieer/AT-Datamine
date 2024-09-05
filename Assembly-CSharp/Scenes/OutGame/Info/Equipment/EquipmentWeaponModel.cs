// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentWeaponModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Skill;
using StaqData;

#nullable disable
namespace Scenes.OutGame.Info.Equipment
{
  [Token(Token = "0x20035A2")]
  public class EquipmentWeaponModel : EquipmentWeaponModelBase
  {
    [Token(Token = "0x400E95D")]
    [FieldOffset(Offset = "0xC8")]
    private Scenes.OutGame.Info.Skill.SkillModelList skillModelList;
    [Token(Token = "0x400E95E")]
    [FieldOffset(Offset = "0xD0")]
    private ParameterModel parameterModel;
    [Token(Token = "0x400E95F")]
    [FieldOffset(Offset = "0xD8")]
    private EquipmentCommonModel commonModel;

    [Token(Token = "0x17004637")]
    public override SkillModelListBase SkillModelList
    {
      [Token(Token = "0x601519C"), Address(RVA = "0x4AABA34", Offset = "0x4AABA34", VA = "0x4AABA34", Slot = "4")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17004638")]
    public override ParameterModelBase Parameter
    {
      [Token(Token = "0x601519D"), Address(RVA = "0x4AABA3C", Offset = "0x4AABA3C", VA = "0x4AABA3C", Slot = "5")] get
      {
        return (ParameterModelBase) null;
      }
    }

    [Token(Token = "0x17004639")]
    public override EquipmentCommonModelBase Common
    {
      [Token(Token = "0x601519E"), Address(RVA = "0x4AABA44", Offset = "0x4AABA44", VA = "0x4AABA44", Slot = "6")] get
      {
        return (EquipmentCommonModelBase) null;
      }
    }

    [Token(Token = "0x1700463A")]
    public StaqData.Equipment Equipment
    {
      [Token(Token = "0x601519F"), Address(RVA = "0x4AABA4C", Offset = "0x4AABA4C", VA = "0x4AABA4C")] get
      {
        return (StaqData.Equipment) null;
      }
      [Token(Token = "0x60151A0"), Address(RVA = "0x4AABA54", Offset = "0x4AABA54", VA = "0x4AABA54")] private set
      {
      }
    }

    [Token(Token = "0x1700463B")]
    public override bool IsUnknown
    {
      [Token(Token = "0x60151A1"), Address(RVA = "0x4AABA5C", Offset = "0x4AABA5C", VA = "0x4AABA5C", Slot = "23")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60151A2")]
    [Address(RVA = "0x4AABA64", Offset = "0x4AABA64", VA = "0x4AABA64")]
    public void Set(UniqueID uniqueID, Style style)
    {
    }

    [Token(Token = "0x60151A3")]
    [Address(RVA = "0x4AABB40", Offset = "0x4AABB40", VA = "0x4AABB40")]
    public void Set(Weapon weapon, Style style)
    {
    }

    [Token(Token = "0x60151A4")]
    [Address(RVA = "0x4AABE10", Offset = "0x4AABE10", VA = "0x4AABE10")]
    public EquipmentWeaponModel()
    {
    }
  }
}
