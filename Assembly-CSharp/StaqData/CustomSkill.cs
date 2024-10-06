// Decompiled with JetBrains decompiler
// Type: StaqData.CustomSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200201C")]
  public sealed class CustomSkill : EquipmentSkill
  {
    [Token(Token = "0x170027E3")]
    public override int SkillID
    {
      [Token(Token = "0x600BF91"), Address(RVA = "0x2008CB4", Offset = "0x2008CB4", VA = "0x2008CB4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170027E4")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600BF92"), Address(RVA = "0x2008CD0", Offset = "0x2008CD0", VA = "0x2008CD0", Slot = "7")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x170027E5")]
    public override EquipmentSkill.EnhanceTypeEnum EnhanceType
    {
      [Token(Token = "0x600BF93"), Address(RVA = "0x2008CEC", Offset = "0x2008CEC", VA = "0x2008CEC", Slot = "9")] get
      {
        return new EquipmentSkill.EnhanceTypeEnum();
      }
    }

    [Token(Token = "0x170027E6")]
    public CustomSkillData MasterData
    {
      [Token(Token = "0x600BF94"), Address(RVA = "0x2008CF4", Offset = "0x2008CF4", VA = "0x2008CF4")] get
      {
        return (CustomSkillData) null;
      }
      [Token(Token = "0x600BF95"), Address(RVA = "0x2008CFC", Offset = "0x2008CFC", VA = "0x2008CFC")] private set
      {
      }
    }

    [Token(Token = "0x170027E7")]
    public int SkillCost
    {
      [Token(Token = "0x600BF96"), Address(RVA = "0x2008D04", Offset = "0x2008D04", VA = "0x2008D04")] get
      {
        return new int();
      }
      [Token(Token = "0x600BF97"), Address(RVA = "0x2008D0C", Offset = "0x2008D0C", VA = "0x2008D0C")] private set
      {
      }
    }

    [Token(Token = "0x170027E8")]
    public bool IsFavorite
    {
      [Token(Token = "0x600BF98"), Address(RVA = "0x2008D14", Offset = "0x2008D14", VA = "0x2008D14")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BF99"), Address(RVA = "0x2008D1C", Offset = "0x2008D1C", VA = "0x2008D1C")] set
      {
      }
    }

    [Token(Token = "0x170027E9")]
    public DateTime CreateAt
    {
      [Token(Token = "0x600BF9A"), Address(RVA = "0x2008D28", Offset = "0x2008D28", VA = "0x2008D28")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x600BF9B"), Address(RVA = "0x2008D30", Offset = "0x2008D30", VA = "0x2008D30")] private set
      {
      }
    }

    [Token(Token = "0x600BF9C")]
    [Address(RVA = "0x2008D38", Offset = "0x2008D38", VA = "0x2008D38")]
    public CustomSkill(
      UniqueID uID,
      int id,
      int enhanceEnergy,
      int level,
      bool isFavorite,
      DateTime time)
    {
    }

    [Token(Token = "0x600BF9D")]
    [Address(RVA = "0x2008E60", Offset = "0x2008E60", VA = "0x2008E60")]
    public CustomSkill(CustomSkill other)
    {
    }

    [Token(Token = "0x600BF9E")]
    [Address(RVA = "0x2008E8C", Offset = "0x2008E8C", VA = "0x2008E8C")]
    public CustomSkill(PlayerUnitCustomSkillType entity)
    {
    }

    [Token(Token = "0x600BF9F")]
    [Address(RVA = "0x2008F50", Offset = "0x2008F50", VA = "0x2008F50")]
    public void Apply(PlayerUnitCustomSkillType entity)
    {
    }

    [Token(Token = "0x600BFA0")]
    [Address(RVA = "0x2009070", Offset = "0x2009070", VA = "0x2009070")]
    public static CustomSkill CreateByServerData(PlayerUnitCustomSkillType customSkillType)
    {
      return (CustomSkill) null;
    }

    [Token(Token = "0x600BFA1")]
    [Address(RVA = "0x20090D0", Offset = "0x20090D0", VA = "0x20090D0")]
    public static CustomSkill CreateByCustomSkillId(int customSkillId) => (CustomSkill) null;
  }
}
