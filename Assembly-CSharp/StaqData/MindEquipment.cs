// Decompiled with JetBrains decompiler
// Type: StaqData.MindEquipment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.Utility;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002025")]
  public sealed class MindEquipment : Equipment, IGrowable
  {
    [Token(Token = "0x40088EA")]
    private const float ExpRateMax = 1f;
    [Token(Token = "0x40088EE")]
    [FieldOffset(Offset = "0xB0")]
    public MindEquipmentSkill[] MindEquipmentSkills;

    [Token(Token = "0x17002819")]
    public int Exp
    {
      [Token(Token = "0x600C020"), Address(RVA = "0x2009F3C", Offset = "0x2009F3C", VA = "0x2009F3C", Slot = "69")] get
      {
        return new int();
      }
      [Token(Token = "0x600C021"), Address(RVA = "0x2009F44", Offset = "0x2009F44", VA = "0x2009F44")] private set
      {
      }
    }

    [Token(Token = "0x1700281A")]
    public MindEquipmentData MasterData
    {
      [Token(Token = "0x600C022"), Address(RVA = "0x2009F4C", Offset = "0x2009F4C", VA = "0x2009F4C")] get
      {
        return (MindEquipmentData) null;
      }
      [Token(Token = "0x600C023"), Address(RVA = "0x2009F54", Offset = "0x2009F54", VA = "0x2009F54")] private set
      {
      }
    }

    [Token(Token = "0x1700281B")]
    public int Level
    {
      [Token(Token = "0x600C024"), Address(RVA = "0x2009F5C", Offset = "0x2009F5C", VA = "0x2009F5C", Slot = "70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700281C")]
    public int LimitLevel
    {
      [Token(Token = "0x600C025"), Address(RVA = "0x2009FF8", Offset = "0x2009FF8", VA = "0x2009FF8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700281D")]
    public bool IsLevelLimit
    {
      [Token(Token = "0x600C026"), Address(RVA = "0x200A09C", Offset = "0x200A09C", VA = "0x200A09C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700281E")]
    public int MaxLevel
    {
      [Token(Token = "0x600C027"), Address(RVA = "0x200A0CC", Offset = "0x200A0CC", VA = "0x200A0CC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700281F")]
    public bool IsLevelMax
    {
      [Token(Token = "0x600C028"), Address(RVA = "0x200A21C", Offset = "0x200A21C", VA = "0x200A21C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002820")]
    public int NextLevelExp
    {
      [Token(Token = "0x600C029"), Address(RVA = "0x200A24C", Offset = "0x200A24C", VA = "0x200A24C", Slot = "71")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002821")]
    public float NextLevelExpRate
    {
      [Token(Token = "0x600C02A"), Address(RVA = "0x200A2E8", Offset = "0x200A2E8", VA = "0x200A2E8", Slot = "72")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002822")]
    public int LimitBreakCount
    {
      [Token(Token = "0x600C02B"), Address(RVA = "0x200A3A4", Offset = "0x200A3A4", VA = "0x200A3A4")] get
      {
        return new int();
      }
      [Token(Token = "0x600C02C"), Address(RVA = "0x200A3AC", Offset = "0x200A3AC", VA = "0x200A3AC")] private set
      {
      }
    }

    [Token(Token = "0x17002823")]
    public int LimitBreakCountMax
    {
      [Token(Token = "0x600C02D"), Address(RVA = "0x200A17C", Offset = "0x200A17C", VA = "0x200A17C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002824")]
    public int SkillLevel
    {
      [Token(Token = "0x600C02E"), Address(RVA = "0x200A3B4", Offset = "0x200A3B4", VA = "0x200A3B4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002825")]
    public MindEquipmentSkill PartySkill
    {
      [Token(Token = "0x600C02F"), Address(RVA = "0x200A3C0", Offset = "0x200A3C0", VA = "0x200A3C0")] get
      {
        return (MindEquipmentSkill) null;
      }
    }

    [Token(Token = "0x17002826")]
    public int CombatPower
    {
      [Token(Token = "0x600C030"), Address(RVA = "0x200A3F4", Offset = "0x200A3F4", VA = "0x200A3F4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002827")]
    public bool IsPossessing
    {
      [Token(Token = "0x600C031"), Address(RVA = "0x200A4A8", Offset = "0x200A4A8", VA = "0x200A4A8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C032")]
    [Address(RVA = "0x200A510", Offset = "0x200A510", VA = "0x200A510")]
    private MindEquipment()
    {
    }

    [Token(Token = "0x600C033")]
    [Address(RVA = "0x200A568", Offset = "0x200A568", VA = "0x200A568", Slot = "73")]
    public (int, int) GetPredictExperience(int value) => ();

    [Token(Token = "0x600C034")]
    [Address(RVA = "0x200A67C", Offset = "0x200A67C", VA = "0x200A67C", Slot = "29")]
    public override int GetElementReinforceValue(ElementTypeEnum type) => new int();

    [Token(Token = "0x600C035")]
    [Address(RVA = "0x200A6B4", Offset = "0x200A6B4", VA = "0x200A6B4", Slot = "32")]
    public override int GetElementResistValue(ElementTypeEnum type) => new int();

    [Token(Token = "0x600C036")]
    [Address(RVA = "0x200A6EC", Offset = "0x200A6EC", VA = "0x200A6EC", Slot = "30")]
    public override int GetAttackReinforceValue(AttackTypeEnum type) => new int();

    [Token(Token = "0x600C037")]
    [Address(RVA = "0x200A724", Offset = "0x200A724", VA = "0x200A724", Slot = "33")]
    public override int GetAttackResistValue(AttackTypeEnum type) => new int();

    [Token(Token = "0x600C038")]
    [Address(RVA = "0x200A75C", Offset = "0x200A75C", VA = "0x200A75C", Slot = "31")]
    public override int GetBadStatusReinforceValue(BattleBadStatusTypeEnum type) => new int();

    [Token(Token = "0x600C039")]
    [Address(RVA = "0x200A794", Offset = "0x200A794", VA = "0x200A794", Slot = "34")]
    public override int GetBadStatusResistValue(BattleBadStatusTypeEnum type) => new int();

    [Token(Token = "0x600C03A")]
    [Address(RVA = "0x200A7CC", Offset = "0x200A7CC", VA = "0x200A7CC", Slot = "41")]
    public override bool IsAddedStatusElementReinforceValue(ElementTypeEnum elementType)
    {
      return new bool();
    }

    [Token(Token = "0x600C03B")]
    [Address(RVA = "0x200A7E8", Offset = "0x200A7E8", VA = "0x200A7E8", Slot = "42")]
    public override bool IsAddedStatusAttackReinforceValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x600C03C")]
    [Address(RVA = "0x200A804", Offset = "0x200A804", VA = "0x200A804", Slot = "43")]
    public override bool IsAddedStatusBadStatusReinforceValue(
      BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x600C03D")]
    [Address(RVA = "0x200A820", Offset = "0x200A820", VA = "0x200A820", Slot = "44")]
    public override bool IsAddedStatusElementResistValue(ElementTypeEnum elementType) => new bool();

    [Token(Token = "0x600C03E")]
    [Address(RVA = "0x200A83C", Offset = "0x200A83C", VA = "0x200A83C", Slot = "45")]
    public override bool IsAddedStatusAttackResistValue(AttackTypeEnum attackType) => new bool();

    [Token(Token = "0x600C03F")]
    [Address(RVA = "0x200A858", Offset = "0x200A858", VA = "0x200A858", Slot = "46")]
    public override bool IsAddedStatusBadStatusResistValue(
      BattleBadStatusTypeEnum battleBadStatusType)
    {
      return new bool();
    }

    [Token(Token = "0x600C040")]
    [Address(RVA = "0x200A874", Offset = "0x200A874", VA = "0x200A874")]
    public void Apply(PlayerGearMindEquipmentType entity)
    {
    }

    [Token(Token = "0x600C041")]
    [Address(RVA = "0x200AD10", Offset = "0x200AD10", VA = "0x200AD10")]
    public MindEquipment CreateAssumptionFromLevel(int level) => (MindEquipment) null;

    [Token(Token = "0x600C042")]
    [Address(RVA = "0x200AE38", Offset = "0x200AE38", VA = "0x200AE38")]
    public static MindEquipment CreateByServerData(PlayerGearMindEquipmentType entity)
    {
      return (MindEquipment) null;
    }

    [Token(Token = "0x600C043")]
    [Address(RVA = "0x200B0E4", Offset = "0x200B0E4", VA = "0x200B0E4")]
    public static MindEquipment CreateMaxTemplateByMasterId(int id) => (MindEquipment) null;

    [Token(Token = "0x600C044")]
    [Address(RVA = "0x200B370", Offset = "0x200B370", VA = "0x200B370")]
    public static MindEquipment CreateByNpcData(int masterId) => (MindEquipment) null;

    [Token(Token = "0x600C045")]
    [Address(RVA = "0x200B654", Offset = "0x200B654", VA = "0x200B654")]
    public static MindEquipment CreateByArmouryViewData(int masterId) => (MindEquipment) null;

    [Token(Token = "0x600C046")]
    [Address(RVA = "0x200ABF8", Offset = "0x200ABF8", VA = "0x200ABF8")]
    private void UpdateBattleParameters()
    {
    }

    [Token(Token = "0x600C047")]
    [Address(RVA = "0x200B8C8", Offset = "0x200B8C8", VA = "0x200B8C8")]
    public int CalcCombatPower(MindStandardStatus assumption) => new int();

    [Token(Token = "0x600C048")]
    [Address(RVA = "0x200BA14", Offset = "0x200BA14", VA = "0x200BA14", Slot = "47")]
    public override bool CheckEnhancedBadge() => new bool();

    [Token(Token = "0x600C049")]
    [Address(RVA = "0x200BAD8", Offset = "0x200BAD8", VA = "0x200BAD8")]
    public bool IsLimitBreakMax() => new bool();

    [Token(Token = "0x600C04A")]
    [Address(RVA = "0x200BB7C", Offset = "0x200BB7C", VA = "0x200BB7C")]
    public bool IsDuplicate() => new bool();

    [Token(Token = "0x600C04B")]
    [Address(RVA = "0x200BB8C", Offset = "0x200BB8C", VA = "0x200BB8C")]
    public bool CanConversion() => new bool();
  }
}
