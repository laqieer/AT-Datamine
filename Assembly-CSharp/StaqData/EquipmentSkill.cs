// Decompiled with JetBrains decompiler
// Type: StaqData.EquipmentSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002021")]
  public abstract class EquipmentSkill
  {
    [Token(Token = "0x40088DD")]
    [FieldOffset(Offset = "0x30")]
    private SkillData baseData;
    [Token(Token = "0x40088DE")]
    [FieldOffset(Offset = "0x38")]
    private int baseSkillId;
    [Token(Token = "0x40088DF")]
    [FieldOffset(Offset = "0x40")]
    private SkillDetailData detailData;
    [Token(Token = "0x40088E0")]
    [FieldOffset(Offset = "0x48")]
    private int detailSkillId;
    [Token(Token = "0x40088E1")]
    [FieldOffset(Offset = "0x4C")]
    private int detailSkillLeve;
    [Token(Token = "0x40088E2")]
    [FieldOffset(Offset = "0x50")]
    private int maxLevel;

    [Token(Token = "0x17002808")]
    public UniqueID UniqueID
    {
      [Token(Token = "0x600BFFF"), Address(RVA = "0x20099F4", Offset = "0x20099F4", VA = "0x20099F4")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600C000"), Address(RVA = "0x20099FC", Offset = "0x20099FC", VA = "0x20099FC")] protected set
      {
      }
    }

    [Token(Token = "0x17002809")]
    public int ID
    {
      [Token(Token = "0x600C001"), Address(RVA = "0x2009A04", Offset = "0x2009A04", VA = "0x2009A04")] get
      {
        return new int();
      }
      [Token(Token = "0x600C002"), Address(RVA = "0x2009A0C", Offset = "0x2009A0C", VA = "0x2009A0C")] protected set
      {
      }
    }

    [Token(Token = "0x1700280A")]
    public virtual int SkillID
    {
      [Token(Token = "0x600C003"), Address(RVA = "0x2009A14", Offset = "0x2009A14", VA = "0x2009A14", Slot = "4")] get
      {
        return new int();
      }
      [Token(Token = "0x600C004"), Address(RVA = "0x2009A1C", Offset = "0x2009A1C", VA = "0x2009A1C", Slot = "5")] protected set
      {
      }
    }

    [Token(Token = "0x1700280B")]
    public int Level
    {
      [Token(Token = "0x600C005"), Address(RVA = "0x2009A24", Offset = "0x2009A24", VA = "0x2009A24", Slot = "6")] get
      {
        return new int();
      }
      [Token(Token = "0x600C006"), Address(RVA = "0x2009A2C", Offset = "0x2009A2C", VA = "0x2009A2C")] protected set
      {
      }
    }

    [Token(Token = "0x1700280C")]
    public int EnhanceEnergy
    {
      [Token(Token = "0x600C007"), Address(RVA = "0x2009A34", Offset = "0x2009A34", VA = "0x2009A34")] get
      {
        return new int();
      }
      [Token(Token = "0x600C008"), Address(RVA = "0x2009A3C", Offset = "0x2009A3C", VA = "0x2009A3C")] protected set
      {
      }
    }

    [Token(Token = "0x1700280D")]
    public virtual RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C009"), Address(RVA = "0x2009A44", Offset = "0x2009A44", VA = "0x2009A44", Slot = "7")] get
      {
        return new RarityTypeEnum();
      }
      [Token(Token = "0x600C00A"), Address(RVA = "0x2009A4C", Offset = "0x2009A4C", VA = "0x2009A4C", Slot = "8")] protected set
      {
      }
    }

    [Token(Token = "0x1700280E")]
    public virtual EquipmentSkill.EnhanceTypeEnum EnhanceType
    {
      [Token(Token = "0x600C00B"), Address(RVA = "0x2009A54", Offset = "0x2009A54", VA = "0x2009A54", Slot = "9")] get
      {
        return new EquipmentSkill.EnhanceTypeEnum();
      }
    }

    [Token(Token = "0x1700280F")]
    public SkillData BaseData
    {
      [Token(Token = "0x600C00C"), Address(RVA = "0x2009A5C", Offset = "0x2009A5C", VA = "0x2009A5C")] get
      {
        return (SkillData) null;
      }
      [Token(Token = "0x600C00D"), Address(RVA = "0x2008AAC", Offset = "0x2008AAC", VA = "0x2008AAC")] set
      {
      }
    }

    [Token(Token = "0x17002810")]
    public SkillDetailData DetailData
    {
      [Token(Token = "0x600C00E"), Address(RVA = "0x2009B50", Offset = "0x2009B50", VA = "0x2009B50")] get
      {
        return (SkillDetailData) null;
      }
      [Token(Token = "0x600C00F"), Address(RVA = "0x2008ACC", Offset = "0x2008ACC", VA = "0x2008ACC")] set
      {
      }
    }

    [Token(Token = "0x17002811")]
    public int MaxLevel
    {
      [Token(Token = "0x600C010"), Address(RVA = "0x2009D18", Offset = "0x2009D18", VA = "0x2009D18")] get
      {
        return new int();
      }
      [Token(Token = "0x600C011"), Address(RVA = "0x2009E9C", Offset = "0x2009E9C", VA = "0x2009E9C")] set
      {
      }
    }

    [Token(Token = "0x600C012")]
    [Address(RVA = "0x2009EA4", Offset = "0x2009EA4", VA = "0x2009EA4")]
    public void UpdateEnhance(int level, int energy)
    {
    }

    [Token(Token = "0x600C013")]
    [Address(RVA = "0x2008E44", Offset = "0x2008E44", VA = "0x2008E44")]
    protected EquipmentSkill()
    {
    }

    [Token(Token = "0x2002022")]
    public enum EnhanceTypeEnum
    {
      [Token(Token = "0x40088E4")] None,
      [Token(Token = "0x40088E5")] AccessorySkill,
      [Token(Token = "0x40088E6")] CustomSkill,
      [Token(Token = "0x40088E7")] TrustSkill,
      [Token(Token = "0x40088E8")] WeaponSkill,
    }
  }
}
