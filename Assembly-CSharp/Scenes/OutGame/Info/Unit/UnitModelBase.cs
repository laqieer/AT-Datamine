// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Unit.UnitModelBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common;
using Scenes.OutGame.Info.Equipment;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Info.Style;
using System;

#nullable disable
namespace Scenes.OutGame.Info.Unit
{
  [Token(Token = "0x2003540")]
  public abstract class UnitModelBase
  {
    [Token(Token = "0x400E794")]
    [FieldOffset(Offset = "0x48")]
    public Action OnChange;

    [Token(Token = "0x17004529")]
    public abstract StyleModelBase Style { [Token(Token = "0x6014E0D")] get; }

    [Token(Token = "0x1700452A")]
    public abstract EquipmentWeaponModelBase MainWeapon { [Token(Token = "0x6014E0E")] get; }

    [Token(Token = "0x1700452B")]
    public abstract EquipmentWeaponModelBase SubWeapon1 { [Token(Token = "0x6014E0F")] get; }

    [Token(Token = "0x1700452C")]
    public abstract EquipmentWeaponModelBase SubWeapon2 { [Token(Token = "0x6014E10")] get; }

    [Token(Token = "0x1700452D")]
    public abstract EquipmentAccessoryModelBase Accessory { [Token(Token = "0x6014E11")] get; }

    [Token(Token = "0x1700452E")]
    public abstract EquipmentTrustModelBase Trust { [Token(Token = "0x6014E12")] get; }

    [Token(Token = "0x1700452F")]
    public abstract EquipmentMindEquipmentModelBase MindEquipment { [Token(Token = "0x6014E13")] get; }

    [Token(Token = "0x17004530")]
    public abstract SkillModelListBase SkillList { [Token(Token = "0x6014E14")] get; }

    [Token(Token = "0x17004531")]
    public abstract ParameterModelBase UnitParameter { [Token(Token = "0x6014E15")] get; }

    [Token(Token = "0x17004532")]
    public abstract AdditionalParameterModelBase AdditionalParameter { [Token(Token = "0x6014E16")] get; }

    [Token(Token = "0x17004533")]
    public int HP
    {
      [Token(Token = "0x6014E17"), Address(RVA = "0x1B4747C", Offset = "0x1B4747C", VA = "0x1B4747C")] get
      {
        return new int();
      }
      [Token(Token = "0x6014E18"), Address(RVA = "0x1B47484", Offset = "0x1B47484", VA = "0x1B47484")] set
      {
      }
    }

    [Token(Token = "0x17004534")]
    public int HPMax
    {
      [Token(Token = "0x6014E19"), Address(RVA = "0x1B4748C", Offset = "0x1B4748C", VA = "0x1B4748C")] get
      {
        return new int();
      }
      [Token(Token = "0x6014E1A"), Address(RVA = "0x1B47494", Offset = "0x1B47494", VA = "0x1B47494")] set
      {
      }
    }

    [Token(Token = "0x17004535")]
    public int HPStock
    {
      [Token(Token = "0x6014E1B"), Address(RVA = "0x1B4749C", Offset = "0x1B4749C", VA = "0x1B4749C")] get
      {
        return new int();
      }
      [Token(Token = "0x6014E1C"), Address(RVA = "0x1B474A4", Offset = "0x1B474A4", VA = "0x1B474A4")] set
      {
      }
    }

    [Token(Token = "0x17004536")]
    public int LP
    {
      [Token(Token = "0x6014E1D"), Address(RVA = "0x1B474AC", Offset = "0x1B474AC", VA = "0x1B474AC")] get
      {
        return new int();
      }
      [Token(Token = "0x6014E1E"), Address(RVA = "0x1B474B4", Offset = "0x1B474B4", VA = "0x1B474B4")] set
      {
      }
    }

    [Token(Token = "0x17004537")]
    public int LPMax
    {
      [Token(Token = "0x6014E1F"), Address(RVA = "0x1B474BC", Offset = "0x1B474BC", VA = "0x1B474BC")] get
      {
        return new int();
      }
      [Token(Token = "0x6014E20"), Address(RVA = "0x1B474C4", Offset = "0x1B474C4", VA = "0x1B474C4")] set
      {
      }
    }

    [Token(Token = "0x17004538")]
    public BarrierContainer Barrier
    {
      [Token(Token = "0x6014E21"), Address(RVA = "0x1B474CC", Offset = "0x1B474CC", VA = "0x1B474CC")] get
      {
        return (BarrierContainer) null;
      }
      [Token(Token = "0x6014E22"), Address(RVA = "0x1B474D4", Offset = "0x1B474D4", VA = "0x1B474D4")] set
      {
      }
    }

    [Token(Token = "0x17004539")]
    public int BarrierStock
    {
      [Token(Token = "0x6014E23"), Address(RVA = "0x1B474DC", Offset = "0x1B474DC", VA = "0x1B474DC")] get
      {
        return new int();
      }
      [Token(Token = "0x6014E24"), Address(RVA = "0x1B474E4", Offset = "0x1B474E4", VA = "0x1B474E4")] set
      {
      }
    }

    [Token(Token = "0x1700453A")]
    public int BarrierStockMax
    {
      [Token(Token = "0x6014E25"), Address(RVA = "0x1B474EC", Offset = "0x1B474EC", VA = "0x1B474EC")] get
      {
        return new int();
      }
      [Token(Token = "0x6014E26"), Address(RVA = "0x1B474F4", Offset = "0x1B474F4", VA = "0x1B474F4")] set
      {
      }
    }

    [Token(Token = "0x1700453B")]
    public int BarrierCurrentHp
    {
      [Token(Token = "0x6014E27"), Address(RVA = "0x1B474FC", Offset = "0x1B474FC", VA = "0x1B474FC")] get
      {
        return new int();
      }
      [Token(Token = "0x6014E28"), Address(RVA = "0x1B47504", Offset = "0x1B47504", VA = "0x1B47504")] set
      {
      }
    }

    [Token(Token = "0x1700453C")]
    public int BarrierMaxHp
    {
      [Token(Token = "0x6014E29"), Address(RVA = "0x1B4750C", Offset = "0x1B4750C", VA = "0x1B4750C")] get
      {
        return new int();
      }
      [Token(Token = "0x6014E2A"), Address(RVA = "0x1B47514", Offset = "0x1B47514", VA = "0x1B47514")] set
      {
      }
    }

    [Token(Token = "0x1700453D")]
    public int BarrierIndex
    {
      [Token(Token = "0x6014E2B"), Address(RVA = "0x1B4751C", Offset = "0x1B4751C", VA = "0x1B4751C")] get
      {
        return new int();
      }
      [Token(Token = "0x6014E2C"), Address(RVA = "0x1B47524", Offset = "0x1B47524", VA = "0x1B47524")] set
      {
      }
    }

    [Token(Token = "0x1700453E")]
    public bool ExistStyleSkill
    {
      [Token(Token = "0x6014E2D"), Address(RVA = "0x1B4752C", Offset = "0x1B4752C", VA = "0x1B4752C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700453F")]
    public virtual bool ExistEquipmentSkill
    {
      [Token(Token = "0x6014E2E"), Address(RVA = "0x1B47560", Offset = "0x1B47560", VA = "0x1B47560", Slot = "14")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004540")]
    public bool ExistFierceSkill
    {
      [Token(Token = "0x6014E2F"), Address(RVA = "0x1B4769C", Offset = "0x1B4769C", VA = "0x1B4769C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004541")]
    public bool ExistLatentSkill
    {
      [Token(Token = "0x6014E30"), Address(RVA = "0x1B476D0", Offset = "0x1B476D0", VA = "0x1B476D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004542")]
    public bool ExistCommunicationSkill
    {
      [Token(Token = "0x6014E31"), Address(RVA = "0x1B47704", Offset = "0x1B47704", VA = "0x1B47704")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004543")]
    public bool IsForExpendition
    {
      [Token(Token = "0x6014E32"), Address(RVA = "0x1B47738", Offset = "0x1B47738", VA = "0x1B47738")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014E33"), Address(RVA = "0x1B47740", Offset = "0x1B47740", VA = "0x1B47740")] set
      {
      }
    }

    [Token(Token = "0x6014E34")]
    [Address(RVA = "0x1B4774C", Offset = "0x1B4774C", VA = "0x1B4774C")]
    protected UnitModelBase()
    {
    }
  }
}
