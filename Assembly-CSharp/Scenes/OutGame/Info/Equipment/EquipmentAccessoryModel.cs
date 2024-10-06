// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Equipment.EquipmentAccessoryModel
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
  [Token(Token = "0x200359A")]
  public class EquipmentAccessoryModel : EquipmentAccessoryModelBase
  {
    [Token(Token = "0x400E90A")]
    [FieldOffset(Offset = "0xB0")]
    private Scenes.OutGame.Info.Skill.SkillModelList skillModelList;
    [Token(Token = "0x400E90B")]
    [FieldOffset(Offset = "0xB8")]
    private ParameterModel parameterModel;
    [Token(Token = "0x400E90C")]
    [FieldOffset(Offset = "0xC0")]
    private EquipmentCommonModel commonModel;

    [Token(Token = "0x170045D9")]
    public override SkillModelListBase SkillModelList
    {
      [Token(Token = "0x60150E3"), Address(RVA = "0x4AAA658", Offset = "0x4AAA658", VA = "0x4AAA658", Slot = "4")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x170045DA")]
    public override ParameterModelBase Parameter
    {
      [Token(Token = "0x60150E4"), Address(RVA = "0x4AAA660", Offset = "0x4AAA660", VA = "0x4AAA660", Slot = "5")] get
      {
        return (ParameterModelBase) null;
      }
    }

    [Token(Token = "0x170045DB")]
    public override EquipmentCommonModelBase Common
    {
      [Token(Token = "0x60150E5"), Address(RVA = "0x4AAA668", Offset = "0x4AAA668", VA = "0x4AAA668", Slot = "6")] get
      {
        return (EquipmentCommonModelBase) null;
      }
    }

    [Token(Token = "0x170045DC")]
    public StaqData.Equipment Equipment
    {
      [Token(Token = "0x60150E6"), Address(RVA = "0x4AAA670", Offset = "0x4AAA670", VA = "0x4AAA670")] get
      {
        return (StaqData.Equipment) null;
      }
      [Token(Token = "0x60150E7"), Address(RVA = "0x4AAA678", Offset = "0x4AAA678", VA = "0x4AAA678")] private set
      {
      }
    }

    [Token(Token = "0x170045DD")]
    public override bool IsUnknown
    {
      [Token(Token = "0x60150E8"), Address(RVA = "0x4AAA680", Offset = "0x4AAA680", VA = "0x4AAA680", Slot = "23")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60150E9")]
    [Address(RVA = "0x4AAA688", Offset = "0x4AAA688", VA = "0x4AAA688")]
    public void Set(UniqueID uniqueID)
    {
    }

    [Token(Token = "0x60150EA")]
    [Address(RVA = "0x4AAA8D8", Offset = "0x4AAA8D8", VA = "0x4AAA8D8")]
    public EquipmentAccessoryModel()
    {
    }
  }
}
