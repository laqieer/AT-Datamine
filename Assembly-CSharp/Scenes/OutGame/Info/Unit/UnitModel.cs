// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Unit.UnitModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Equipment;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Info.Style;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Info.Unit
{
  [Token(Token = "0x2003541")]
  public class UnitModel : UnitModelBase
  {
    [Token(Token = "0x400E79D")]
    [FieldOffset(Offset = "0x90")]
    private StyleModel styleModel;
    [Token(Token = "0x400E79E")]
    [FieldOffset(Offset = "0x98")]
    private ParameterModel parameterModel;
    [Token(Token = "0x400E79F")]
    [FieldOffset(Offset = "0xA0")]
    private EquipmentWeaponModel mainWeapon;
    [Token(Token = "0x400E7A0")]
    [FieldOffset(Offset = "0xA8")]
    private EquipmentWeaponModel subWeapon1;
    [Token(Token = "0x400E7A1")]
    [FieldOffset(Offset = "0xB0")]
    private EquipmentWeaponModel subWeapon2;
    [Token(Token = "0x400E7A2")]
    [FieldOffset(Offset = "0xB8")]
    private EquipmentAccessoryModel accessory;
    [Token(Token = "0x400E7A3")]
    [FieldOffset(Offset = "0xC0")]
    private EquipmentTrustModel trust;
    [Token(Token = "0x400E7A4")]
    [FieldOffset(Offset = "0xC8")]
    private EquipmentMindEquipmentModel mindEquipment;
    [Token(Token = "0x400E7A5")]
    [FieldOffset(Offset = "0xD0")]
    private SkillModelList skillList;

    [Token(Token = "0x17004544")]
    public UniqueID StyleUniqueID
    {
      [Token(Token = "0x6014E35"), Address(RVA = "0x1B47754", Offset = "0x1B47754", VA = "0x1B47754")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x6014E36"), Address(RVA = "0x1B4775C", Offset = "0x1B4775C", VA = "0x1B4775C")] private set
      {
      }
    }

    [Token(Token = "0x17004545")]
    public UniqueID MainWeaponUniqueID
    {
      [Token(Token = "0x6014E37"), Address(RVA = "0x1B47764", Offset = "0x1B47764", VA = "0x1B47764")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x6014E38"), Address(RVA = "0x1B4776C", Offset = "0x1B4776C", VA = "0x1B4776C")] private set
      {
      }
    }

    [Token(Token = "0x17004546")]
    public UniqueID SubWeapon1UniqueID
    {
      [Token(Token = "0x6014E39"), Address(RVA = "0x1B47774", Offset = "0x1B47774", VA = "0x1B47774")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x6014E3A"), Address(RVA = "0x1B4777C", Offset = "0x1B4777C", VA = "0x1B4777C")] private set
      {
      }
    }

    [Token(Token = "0x17004547")]
    public UniqueID SubWeapon2UniqueID
    {
      [Token(Token = "0x6014E3B"), Address(RVA = "0x1B47784", Offset = "0x1B47784", VA = "0x1B47784")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x6014E3C"), Address(RVA = "0x1B4778C", Offset = "0x1B4778C", VA = "0x1B4778C")] private set
      {
      }
    }

    [Token(Token = "0x17004548")]
    public UniqueID AccessoryUniqueID
    {
      [Token(Token = "0x6014E3D"), Address(RVA = "0x1B47794", Offset = "0x1B47794", VA = "0x1B47794")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x6014E3E"), Address(RVA = "0x1B4779C", Offset = "0x1B4779C", VA = "0x1B4779C")] private set
      {
      }
    }

    [Token(Token = "0x17004549")]
    public UniqueID UnitTrustUniqueID
    {
      [Token(Token = "0x6014E3F"), Address(RVA = "0x1B477A4", Offset = "0x1B477A4", VA = "0x1B477A4")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x6014E40"), Address(RVA = "0x1B477AC", Offset = "0x1B477AC", VA = "0x1B477AC")] private set
      {
      }
    }

    [Token(Token = "0x1700454A")]
    public UniqueID MindEquipmentUniqueID
    {
      [Token(Token = "0x6014E41"), Address(RVA = "0x1B477B4", Offset = "0x1B477B4", VA = "0x1B477B4")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x6014E42"), Address(RVA = "0x1B477BC", Offset = "0x1B477BC", VA = "0x1B477BC")] private set
      {
      }
    }

    [Token(Token = "0x1700454B")]
    public List<UniqueID> CustomSkillUniqueIDs
    {
      [Token(Token = "0x6014E43"), Address(RVA = "0x1B477C4", Offset = "0x1B477C4", VA = "0x1B477C4")] get
      {
        return (List<UniqueID>) null;
      }
      [Token(Token = "0x6014E44"), Address(RVA = "0x1B477CC", Offset = "0x1B477CC", VA = "0x1B477CC")] private set
      {
      }
    }

    [Token(Token = "0x1700454C")]
    public override StyleModelBase Style
    {
      [Token(Token = "0x6014E45"), Address(RVA = "0x1B477D4", Offset = "0x1B477D4", VA = "0x1B477D4", Slot = "4")] get
      {
        return (StyleModelBase) null;
      }
    }

    [Token(Token = "0x1700454D")]
    public override EquipmentWeaponModelBase MainWeapon
    {
      [Token(Token = "0x6014E46"), Address(RVA = "0x1B477DC", Offset = "0x1B477DC", VA = "0x1B477DC", Slot = "5")] get
      {
        return (EquipmentWeaponModelBase) null;
      }
    }

    [Token(Token = "0x1700454E")]
    public override EquipmentWeaponModelBase SubWeapon1
    {
      [Token(Token = "0x6014E47"), Address(RVA = "0x1B477E4", Offset = "0x1B477E4", VA = "0x1B477E4", Slot = "6")] get
      {
        return (EquipmentWeaponModelBase) null;
      }
    }

    [Token(Token = "0x1700454F")]
    public override EquipmentWeaponModelBase SubWeapon2
    {
      [Token(Token = "0x6014E48"), Address(RVA = "0x1B477EC", Offset = "0x1B477EC", VA = "0x1B477EC", Slot = "7")] get
      {
        return (EquipmentWeaponModelBase) null;
      }
    }

    [Token(Token = "0x17004550")]
    public override EquipmentAccessoryModelBase Accessory
    {
      [Token(Token = "0x6014E49"), Address(RVA = "0x1B477F4", Offset = "0x1B477F4", VA = "0x1B477F4", Slot = "8")] get
      {
        return (EquipmentAccessoryModelBase) null;
      }
    }

    [Token(Token = "0x17004551")]
    public override EquipmentTrustModelBase Trust
    {
      [Token(Token = "0x6014E4A"), Address(RVA = "0x1B477FC", Offset = "0x1B477FC", VA = "0x1B477FC", Slot = "9")] get
      {
        return (EquipmentTrustModelBase) null;
      }
    }

    [Token(Token = "0x17004552")]
    public override EquipmentMindEquipmentModelBase MindEquipment
    {
      [Token(Token = "0x6014E4B"), Address(RVA = "0x1B47804", Offset = "0x1B47804", VA = "0x1B47804", Slot = "10")] get
      {
        return (EquipmentMindEquipmentModelBase) null;
      }
    }

    [Token(Token = "0x17004553")]
    public override SkillModelListBase SkillList
    {
      [Token(Token = "0x6014E4C"), Address(RVA = "0x1B4780C", Offset = "0x1B4780C", VA = "0x1B4780C", Slot = "11")] get
      {
        return (SkillModelListBase) null;
      }
    }

    [Token(Token = "0x17004554")]
    public override ParameterModelBase UnitParameter
    {
      [Token(Token = "0x6014E4D"), Address(RVA = "0x1B47814", Offset = "0x1B47814", VA = "0x1B47814", Slot = "12")] get
      {
        return (ParameterModelBase) null;
      }
    }

    [Token(Token = "0x17004555")]
    public override AdditionalParameterModelBase AdditionalParameter
    {
      [Token(Token = "0x6014E4E"), Address(RVA = "0x1B4781C", Offset = "0x1B4781C", VA = "0x1B4781C", Slot = "13")] get
      {
        return (AdditionalParameterModelBase) null;
      }
    }

    [Token(Token = "0x6014E4F")]
    [Address(RVA = "0x1B41E60", Offset = "0x1B41E60", VA = "0x1B41E60")]
    public void SetUnit(
      UniqueID styleUniqueID,
      UniqueID mainweaponUniqueID,
      UniqueID subweapon1UniqueID,
      UniqueID subweapon2UniqueID,
      UniqueID accessoryUniqueID,
      UniqueID unitTrustUniqueID,
      UniqueID mindEquipmentUniqueID,
      List<UniqueID> customSkillIds)
    {
    }

    [Token(Token = "0x6014E50")]
    [Address(RVA = "0x1B4692C", Offset = "0x1B4692C", VA = "0x1B4692C")]
    public void CalculateUnitParameter()
    {
    }

    [Token(Token = "0x6014E51")]
    [Address(RVA = "0x1B4255C", Offset = "0x1B4255C", VA = "0x1B4255C")]
    public void SetUnitForExpedition(UniqueID styleUniqueID)
    {
    }

    [Token(Token = "0x6014E52")]
    [Address(RVA = "0x1B47B58", Offset = "0x1B47B58", VA = "0x1B47B58")]
    private void CalculateUnitParameterForExpedition()
    {
    }

    [Token(Token = "0x6014E53")]
    [Address(RVA = "0x1B4783C", Offset = "0x1B4783C", VA = "0x1B4783C")]
    public void SetCustomSkills(List<UniqueID> customSkillIds)
    {
    }

    [Token(Token = "0x6014E54")]
    [Address(RVA = "0x1B42CBC", Offset = "0x1B42CBC", VA = "0x1B42CBC")]
    public UnitModel()
    {
    }
  }
}
