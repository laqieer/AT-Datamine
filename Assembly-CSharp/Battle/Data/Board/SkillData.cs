// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.SkillData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.UI;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027F9")]
  public abstract class SkillData
  {
    [Token(Token = "0x400AA1F")]
    [FieldOffset(Offset = "0x53")]
    public bool IsItemSkill;

    [Token(Token = "0x17003634")]
    public int Id
    {
      [Token(Token = "0x600F9F0"), Address(RVA = "0x44C5E34", Offset = "0x44C5E34", VA = "0x44C5E34")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9F1"), Address(RVA = "0x44C5E3C", Offset = "0x44C5E3C", VA = "0x44C5E3C")] private set
      {
      }
    }

    [Token(Token = "0x17003635")]
    public GameCore.MasterData.SkillData BaseMaster
    {
      [Token(Token = "0x600F9F2"), Address(RVA = "0x44C5E44", Offset = "0x44C5E44", VA = "0x44C5E44")] get
      {
        return (GameCore.MasterData.SkillData) null;
      }
      [Token(Token = "0x600F9F3"), Address(RVA = "0x44C5E4C", Offset = "0x44C5E4C", VA = "0x44C5E4C")] private set
      {
      }
    }

    [Token(Token = "0x17003636")]
    public int Level
    {
      [Token(Token = "0x600F9F4"), Address(RVA = "0x44C5E54", Offset = "0x44C5E54", VA = "0x44C5E54")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9F5"), Address(RVA = "0x44C5E5C", Offset = "0x44C5E5C", VA = "0x44C5E5C")] private set
      {
      }
    }

    [Token(Token = "0x17003637")]
    public int Rarity
    {
      [Token(Token = "0x600F9F6"), Address(RVA = "0x44C5E64", Offset = "0x44C5E64", VA = "0x44C5E64")] get
      {
        return new int();
      }
      [Token(Token = "0x600F9F7"), Address(RVA = "0x44C5E6C", Offset = "0x44C5E6C", VA = "0x44C5E6C")] private set
      {
      }
    }

    [Token(Token = "0x17003638")]
    public SkillDetailData DetailMaster
    {
      [Token(Token = "0x600F9F8"), Address(RVA = "0x44C5E74", Offset = "0x44C5E74", VA = "0x44C5E74")] get
      {
        return (SkillDetailData) null;
      }
      [Token(Token = "0x600F9F9"), Address(RVA = "0x44C5E7C", Offset = "0x44C5E7C", VA = "0x44C5E7C")] private set
      {
      }
    }

    [Token(Token = "0x17003639")]
    public SkillTagTypeEnum[] SkillTags
    {
      [Token(Token = "0x600F9FA"), Address(RVA = "0x44C5E84", Offset = "0x44C5E84", VA = "0x44C5E84")] get
      {
        return (SkillTagTypeEnum[]) null;
      }
      [Token(Token = "0x600F9FB"), Address(RVA = "0x44C5E8C", Offset = "0x44C5E8C", VA = "0x44C5E8C")] private set
      {
      }
    }

    [Token(Token = "0x1700363A")]
    public EffectData[] Effects
    {
      [Token(Token = "0x600F9FC"), Address(RVA = "0x44C5E94", Offset = "0x44C5E94", VA = "0x44C5E94")] get
      {
        return (EffectData[]) null;
      }
      [Token(Token = "0x600F9FD"), Address(RVA = "0x44C5E9C", Offset = "0x44C5E9C", VA = "0x44C5E9C")] private set
      {
      }
    }

    [Token(Token = "0x1700363B")]
    public CompositeRangeData[] CompositeEffectiveRange
    {
      [Token(Token = "0x600F9FE"), Address(RVA = "0x44C5EA4", Offset = "0x44C5EA4", VA = "0x44C5EA4")] get
      {
        return (CompositeRangeData[]) null;
      }
      [Token(Token = "0x600F9FF"), Address(RVA = "0x44C5EAC", Offset = "0x44C5EAC", VA = "0x44C5EAC")] private set
      {
      }
    }

    [Token(Token = "0x1700363C")]
    public RangeShapeData RangeShape
    {
      [Token(Token = "0x600FA00"), Address(RVA = "0x44C5EB4", Offset = "0x44C5EB4", VA = "0x44C5EB4")] get
      {
        return (RangeShapeData) null;
      }
      [Token(Token = "0x600FA01"), Address(RVA = "0x44C5EBC", Offset = "0x44C5EBC", VA = "0x44C5EBC")] private set
      {
      }
    }

    [Token(Token = "0x1700363D")]
    public string Name
    {
      [Token(Token = "0x600FA02"), Address(RVA = "0x44C5EC4", Offset = "0x44C5EC4", VA = "0x44C5EC4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700363E")]
    public SkillKindTypeEnum Kind
    {
      [Token(Token = "0x600FA03"), Address(RVA = "0x44C5EE0", Offset = "0x44C5EE0", VA = "0x44C5EE0")] get
      {
        return new SkillKindTypeEnum();
      }
    }

    [Token(Token = "0x1700363F")]
    public SkillCategoryTypeEnum Category
    {
      [Token(Token = "0x600FA04"), Address(RVA = "0x44C5D28", Offset = "0x44C5D28", VA = "0x44C5D28")] get
      {
        return new SkillCategoryTypeEnum();
      }
    }

    [Token(Token = "0x17003640")]
    public WeaponAttackTypeEnum WeaponAttackType
    {
      [Token(Token = "0x600FA05"), Address(RVA = "0x44C5EFC", Offset = "0x44C5EFC", VA = "0x44C5EFC")] get
      {
        return new WeaponAttackTypeEnum();
      }
    }

    [Token(Token = "0x17003641")]
    public AttackTypeEnum AttackType
    {
      [Token(Token = "0x600FA06"), Address(RVA = "0x44C5F18", Offset = "0x44C5F18", VA = "0x44C5F18")] get
      {
        return new AttackTypeEnum();
      }
    }

    [Token(Token = "0x17003642")]
    public bool OverwriteAttackType
    {
      [Token(Token = "0x600FA07"), Address(RVA = "0x44C5F34", Offset = "0x44C5F34", VA = "0x44C5F34")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003643")]
    public ElementTypeEnum Element
    {
      [Token(Token = "0x600FA08"), Address(RVA = "0x44C5F50", Offset = "0x44C5F50", VA = "0x44C5F50")] get
      {
        return new ElementTypeEnum();
      }
    }

    [Token(Token = "0x17003644")]
    public bool OverwriteElement
    {
      [Token(Token = "0x600FA09"), Address(RVA = "0x44C5F6C", Offset = "0x44C5F6C", VA = "0x44C5F6C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003645")]
    public int MaxUsableCount
    {
      [Token(Token = "0x600FA0A"), Address(RVA = "0x44C5F88", Offset = "0x44C5F88", VA = "0x44C5F88")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003646")]
    public bool IsAttackSkill
    {
      [Token(Token = "0x600FA0B"), Address(RVA = "0x44C5FA4", Offset = "0x44C5FA4", VA = "0x44C5FA4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600FA0C"), Address(RVA = "0x44C5FAC", Offset = "0x44C5FAC", VA = "0x44C5FAC")] private set
      {
      }
    }

    [Token(Token = "0x17003647")]
    public bool IsHealSkill
    {
      [Token(Token = "0x600FA0D"), Address(RVA = "0x44C5FB8", Offset = "0x44C5FB8", VA = "0x44C5FB8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600FA0E"), Address(RVA = "0x44C5FC0", Offset = "0x44C5FC0", VA = "0x44C5FC0")] private set
      {
      }
    }

    [Token(Token = "0x17003648")]
    public bool IsMoveSkill
    {
      [Token(Token = "0x600FA0F"), Address(RVA = "0x44C5FCC", Offset = "0x44C5FCC", VA = "0x44C5FCC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600FA10"), Address(RVA = "0x44C5FD4", Offset = "0x44C5FD4", VA = "0x44C5FD4")] private set
      {
      }
    }

    [Token(Token = "0x17003649")]
    public bool IsFierceSkill
    {
      [Token(Token = "0x600FA11"), Address(RVA = "0x44C5FE0", Offset = "0x44C5FE0", VA = "0x44C5FE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700364A")]
    public SkillTriggerTimingTypeEnum TriggerTiming
    {
      [Token(Token = "0x600FA12"), Address(RVA = "0x44C6004", Offset = "0x44C6004", VA = "0x44C6004")] get
      {
        return new SkillTriggerTimingTypeEnum();
      }
    }

    [Token(Token = "0x1700364B")]
    public TargettableUnitTypeEnum TargettableUnit
    {
      [Token(Token = "0x600FA13"), Address(RVA = "0x44C6020", Offset = "0x44C6020", VA = "0x44C6020")] get
      {
        return new TargettableUnitTypeEnum();
      }
    }

    [Token(Token = "0x1700364C")]
    public int RequiredChargeTurns
    {
      [Token(Token = "0x600FA14"), Address(RVA = "0x44C603C", Offset = "0x44C603C", VA = "0x44C603C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700364D")]
    public int BattleStartCoolTime
    {
      [Token(Token = "0x600FA15"), Address(RVA = "0x44C6058", Offset = "0x44C6058", VA = "0x44C6058")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700364E")]
    public int CoolTime
    {
      [Token(Token = "0x600FA16"), Address(RVA = "0x44C6074", Offset = "0x44C6074", VA = "0x44C6074")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700364F")]
    public int ConsumeDurability
    {
      [Token(Token = "0x600FA17"), Address(RVA = "0x44C6090", Offset = "0x44C6090", VA = "0x44C6090")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003650")]
    public string Discription
    {
      [Token(Token = "0x600FA18"), Address(RVA = "0x44C60AC", Offset = "0x44C60AC", VA = "0x44C60AC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003651")]
    public ConditionDetail[] TriggerConditions
    {
      [Token(Token = "0x600FA19"), Address(RVA = "0x44C60C8", Offset = "0x44C60C8", VA = "0x44C60C8")] get
      {
        return (ConditionDetail[]) null;
      }
      [Token(Token = "0x600FA1A"), Address(RVA = "0x44C60D0", Offset = "0x44C60D0", VA = "0x44C60D0")] private set
      {
      }
    }

    [Token(Token = "0x17003652")]
    public ConditionDetail SupportOffsetCondition
    {
      [Token(Token = "0x600FA1B"), Address(RVA = "0x44C60D8", Offset = "0x44C60D8", VA = "0x44C60D8")] get
      {
        return (ConditionDetail) null;
      }
      [Token(Token = "0x600FA1C"), Address(RVA = "0x44C60E0", Offset = "0x44C60E0", VA = "0x44C60E0")] private set
      {
      }
    }

    [Token(Token = "0x17003653")]
    public int SupportActivateRate
    {
      [Token(Token = "0x600FA1D"), Address(RVA = "0x44C60E8", Offset = "0x44C60E8", VA = "0x44C60E8")] get
      {
        return new int();
      }
      [Token(Token = "0x600FA1E"), Address(RVA = "0x44C60F0", Offset = "0x44C60F0", VA = "0x44C60F0")] private set
      {
      }
    }

    [Token(Token = "0x17003654")]
    public int SupportOffsetRate
    {
      [Token(Token = "0x600FA1F"), Address(RVA = "0x44C60F8", Offset = "0x44C60F8", VA = "0x44C60F8")] get
      {
        return new int();
      }
      [Token(Token = "0x600FA20"), Address(RVA = "0x44C6100", Offset = "0x44C6100", VA = "0x44C6100")] private set
      {
      }
    }

    [Token(Token = "0x17003655")]
    public bool IsDuelSkill
    {
      [Token(Token = "0x600FA21"), Address(RVA = "0x44C6108", Offset = "0x44C6108", VA = "0x44C6108")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003656")]
    public bool IsSupportSkill
    {
      [Token(Token = "0x600FA22"), Address(RVA = "0x44C6168", Offset = "0x44C6168", VA = "0x44C6168")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600FA23")]
    public static TSkillData Create<TSkillData>(
      int id,
      int skill,
      int level,
      int rarity,
      List<EffectData> effects)
      where TSkillData : SkillData, new()
    {
      return (TSkillData) null;
    }

    [Token(Token = "0x600FA24")]
    [Address(RVA = "0x44C5A30", Offset = "0x44C5A30", VA = "0x44C5A30", Slot = "4")]
    protected virtual void OnInitialized()
    {
    }

    [Token(Token = "0x600FA25")]
    [Address(RVA = "0x44C6190", Offset = "0x44C6190", VA = "0x44C6190")]
    public BattleUnitTargetIcon.TargetType GetTargetTypeIcon(EffectData eff)
    {
      return new BattleUnitTargetIcon.TargetType();
    }

    [Token(Token = "0x600FA26")]
    [Address(RVA = "0x44C6280", Offset = "0x44C6280", VA = "0x44C6280")]
    public bool IsConditionEmpty() => new bool();

    [Token(Token = "0x600FA27")]
    [Address(RVA = "0x44C5D44", Offset = "0x44C5D44", VA = "0x44C5D44", Slot = "5")]
    public virtual bool IsConditionable(
      SkillTriggerTimingTypeEnum timing,
      UnitParameterData unit,
      WeaponParameterData weaponParam,
      BoardData board)
    {
      return new bool();
    }

    [Token(Token = "0x600FA28")]
    [Address(RVA = "0x44C65E8", Offset = "0x44C65E8", VA = "0x44C65E8")]
    public bool IsConditionable(SkillTriggerTimingTypeEnum timing, ConditionParam conditionParam)
    {
      return new bool();
    }

    [Token(Token = "0x600FA29")]
    [Address(RVA = "0x44C66F4", Offset = "0x44C66F4", VA = "0x44C66F4")]
    public bool SupportOffsetConditionable(
      SkillTriggerTimingTypeEnum timing,
      UnitParameterData unit,
      BoardData board)
    {
      return new bool();
    }

    [Token(Token = "0x600FA2A")]
    [Address(RVA = "0x44C675C", Offset = "0x44C675C", VA = "0x44C675C")]
    public bool IsTargettable(BoardData board, UnitParameterData from, UnitParameterData to)
    {
      return new bool();
    }

    [Token(Token = "0x600FA2B")]
    [Address(RVA = "0x44C678C", Offset = "0x44C678C", VA = "0x44C678C")]
    public bool IsTargettable(BattlePlayerData player, UnitParameterData targetUnit) => new bool();

    [Token(Token = "0x600FA2C")]
    [Address(RVA = "0x44C67BC", Offset = "0x44C67BC", VA = "0x44C67BC")]
    public bool IsEffectable(BoardData board, UnitParameterData from, UnitParameterData to)
    {
      return new bool();
    }

    [Token(Token = "0x600FA2D")]
    [Address(RVA = "0x44C2E74", Offset = "0x44C2E74", VA = "0x44C2E74")]
    public string ToJson() => (string) null;

    [Token(Token = "0x600FA2E")]
    [Address(RVA = "0x44C5C3C", Offset = "0x44C5C3C", VA = "0x44C5C3C")]
    protected SkillData()
    {
    }
  }
}
