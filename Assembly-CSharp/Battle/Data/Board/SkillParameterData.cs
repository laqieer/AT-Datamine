// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.SkillParameterData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027FE")]
  public class SkillParameterData
  {
    [Token(Token = "0x17003657")]
    public int Id
    {
      [Token(Token = "0x600FA3D"), Address(RVA = "0x44C6A58", Offset = "0x44C6A58", VA = "0x44C6A58")] get
      {
        return new int();
      }
      [Token(Token = "0x600FA3E"), Address(RVA = "0x44C6A60", Offset = "0x44C6A60", VA = "0x44C6A60")] protected set
      {
      }
    }

    [Token(Token = "0x17003658")]
    public SkillData Data
    {
      [Token(Token = "0x600FA3F"), Address(RVA = "0x44C6A68", Offset = "0x44C6A68", VA = "0x44C6A68")] get
      {
        return (SkillData) null;
      }
      [Token(Token = "0x600FA40"), Address(RVA = "0x44C6A70", Offset = "0x44C6A70", VA = "0x44C6A70")] protected set
      {
      }
    }

    [Token(Token = "0x17003659")]
    public bool IsActive
    {
      [Token(Token = "0x600FA41"), Address(RVA = "0x44C6A78", Offset = "0x44C6A78", VA = "0x44C6A78")] get
      {
        return new bool();
      }
      [Token(Token = "0x600FA42"), Address(RVA = "0x44C6A80", Offset = "0x44C6A80", VA = "0x44C6A80")] protected set
      {
      }
    }

    [Token(Token = "0x1700365A")]
    public int UsableCount
    {
      [Token(Token = "0x600FA43"), Address(RVA = "0x44C6A8C", Offset = "0x44C6A8C", VA = "0x44C6A8C")] get
      {
        return new int();
      }
      [Token(Token = "0x600FA44"), Address(RVA = "0x44C6A94", Offset = "0x44C6A94", VA = "0x44C6A94")] protected set
      {
      }
    }

    [Token(Token = "0x1700365B")]
    public int CurrentCoolTime
    {
      [Token(Token = "0x600FA45"), Address(RVA = "0x44C6A9C", Offset = "0x44C6A9C", VA = "0x44C6A9C")] get
      {
        return new int();
      }
      [Token(Token = "0x600FA46"), Address(RVA = "0x44C6AA4", Offset = "0x44C6AA4", VA = "0x44C6AA4")] protected set
      {
      }
    }

    [Token(Token = "0x1700365C")]
    public GameCore.MasterData.SkillData MasterData
    {
      [Token(Token = "0x600FA47"), Address(RVA = "0x44C6AAC", Offset = "0x44C6AAC", VA = "0x44C6AAC")] get
      {
        return (GameCore.MasterData.SkillData) null;
      }
    }

    [Token(Token = "0x1700365D")]
    public string Name
    {
      [Token(Token = "0x600FA48"), Address(RVA = "0x44C6AC8", Offset = "0x44C6AC8", VA = "0x44C6AC8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700365E")]
    public int Level
    {
      [Token(Token = "0x600FA49"), Address(RVA = "0x44C6AEC", Offset = "0x44C6AEC", VA = "0x44C6AEC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700365F")]
    public int Rarity
    {
      [Token(Token = "0x600FA4A"), Address(RVA = "0x44C6B08", Offset = "0x44C6B08", VA = "0x44C6B08")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003660")]
    public SkillTypeEnum SkillType
    {
      [Token(Token = "0x600FA4B"), Address(RVA = "0x44C6B24", Offset = "0x44C6B24", VA = "0x44C6B24")] get
      {
        return new SkillTypeEnum();
      }
    }

    [Token(Token = "0x17003661")]
    public SkillCategoryTypeEnum Category
    {
      [Token(Token = "0x600FA4C"), Address(RVA = "0x44C6B48", Offset = "0x44C6B48", VA = "0x44C6B48")] get
      {
        return new SkillCategoryTypeEnum();
      }
    }

    [Token(Token = "0x17003662")]
    public SkillKindTypeEnum Kind
    {
      [Token(Token = "0x600FA4D"), Address(RVA = "0x44C6B6C", Offset = "0x44C6B6C", VA = "0x44C6B6C")] get
      {
        return new SkillKindTypeEnum();
      }
    }

    [Token(Token = "0x17003663")]
    public SkillTagTypeEnum[] Tags
    {
      [Token(Token = "0x600FA4E"), Address(RVA = "0x44C6B90", Offset = "0x44C6B90", VA = "0x44C6B90")] get
      {
        return (SkillTagTypeEnum[]) null;
      }
    }

    [Token(Token = "0x17003664")]
    public ElementTypeEnum Element
    {
      [Token(Token = "0x600FA4F"), Address(RVA = "0x44C6BAC", Offset = "0x44C6BAC", VA = "0x44C6BAC")] get
      {
        return new ElementTypeEnum();
      }
    }

    [Token(Token = "0x17003665")]
    public bool OverwriteElement
    {
      [Token(Token = "0x600FA50"), Address(RVA = "0x44C6BD0", Offset = "0x44C6BD0", VA = "0x44C6BD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003666")]
    public AttackTypeEnum AttackType
    {
      [Token(Token = "0x600FA51"), Address(RVA = "0x44C6BF4", Offset = "0x44C6BF4", VA = "0x44C6BF4")] get
      {
        return new AttackTypeEnum();
      }
    }

    [Token(Token = "0x17003667")]
    public bool OverwriteAttackType
    {
      [Token(Token = "0x600FA52"), Address(RVA = "0x44C6C18", Offset = "0x44C6C18", VA = "0x44C6C18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003668")]
    public WeaponAttackTypeEnum WeaponAttackType
    {
      [Token(Token = "0x600FA53"), Address(RVA = "0x44C6C3C", Offset = "0x44C6C3C", VA = "0x44C6C3C")] get
      {
        return new WeaponAttackTypeEnum();
      }
    }

    [Token(Token = "0x17003669")]
    public SkillTriggerTimingTypeEnum TriggerTiming
    {
      [Token(Token = "0x600FA54"), Address(RVA = "0x44C6C60", Offset = "0x44C6C60", VA = "0x44C6C60")] get
      {
        return new SkillTriggerTimingTypeEnum();
      }
    }

    [Token(Token = "0x1700366A")]
    public ConditionDetail[] TriggerConditions
    {
      [Token(Token = "0x600FA55"), Address(RVA = "0x44C6C84", Offset = "0x44C6C84", VA = "0x44C6C84")] get
      {
        return (ConditionDetail[]) null;
      }
    }

    [Token(Token = "0x1700366B")]
    public TargettableUnitTypeEnum TargettableUnit
    {
      [Token(Token = "0x600FA56"), Address(RVA = "0x44C6CA0", Offset = "0x44C6CA0", VA = "0x44C6CA0")] get
      {
        return new TargettableUnitTypeEnum();
      }
    }

    [Token(Token = "0x1700366C")]
    public EffectData[] Effects
    {
      [Token(Token = "0x600FA57"), Address(RVA = "0x44C6CC4", Offset = "0x44C6CC4", VA = "0x44C6CC4")] get
      {
        return (EffectData[]) null;
      }
    }

    [Token(Token = "0x1700366D")]
    public int MaxCoolTime
    {
      [Token(Token = "0x600FA58"), Address(RVA = "0x44C6CE0", Offset = "0x44C6CE0", VA = "0x44C6CE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700366E")]
    public int MaxUsableCount
    {
      [Token(Token = "0x600FA59"), Address(RVA = "0x44C6D04", Offset = "0x44C6D04", VA = "0x44C6D04")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700366F")]
    public bool IsUsable
    {
      [Token(Token = "0x600FA5A"), Address(RVA = "0x44C6D28", Offset = "0x44C6D28", VA = "0x44C6D28")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003670")]
    public int RequiredChargeTurns
    {
      [Token(Token = "0x600FA5B"), Address(RVA = "0x44C6D60", Offset = "0x44C6D60", VA = "0x44C6D60")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003671")]
    public bool ChargeRequired
    {
      [Token(Token = "0x600FA5C"), Address(RVA = "0x44C6D84", Offset = "0x44C6D84", VA = "0x44C6D84")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003672")]
    public int ConsumeDurability
    {
      [Token(Token = "0x600FA5D"), Address(RVA = "0x44C6D9C", Offset = "0x44C6D9C", VA = "0x44C6D9C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003673")]
    public RangeData FiringRange
    {
      [Token(Token = "0x600FA5E"), Address(RVA = "0x44C6DC0", Offset = "0x44C6DC0", VA = "0x44C6DC0")] get
      {
        return (RangeData) null;
      }
    }

    [Token(Token = "0x17003674")]
    public RangeShapeData RangeShape
    {
      [Token(Token = "0x600FA5F"), Address(RVA = "0x44C6E4C", Offset = "0x44C6E4C", VA = "0x44C6E4C")] get
      {
        return (RangeShapeData) null;
      }
    }

    [Token(Token = "0x17003675")]
    public int SupportActivateRate
    {
      [Token(Token = "0x600FA60"), Address(RVA = "0x44C6E68", Offset = "0x44C6E68", VA = "0x44C6E68")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003676")]
    public int SupportOffsetRate
    {
      [Token(Token = "0x600FA61"), Address(RVA = "0x44C6E84", Offset = "0x44C6E84", VA = "0x44C6E84")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003677")]
    public string Discription
    {
      [Token(Token = "0x600FA62"), Address(RVA = "0x44C6EA0", Offset = "0x44C6EA0", VA = "0x44C6EA0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17003678")]
    public bool IsAttackSkill
    {
      [Token(Token = "0x600FA63"), Address(RVA = "0x44C6EC4", Offset = "0x44C6EC4", VA = "0x44C6EC4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003679")]
    public bool IsHealSkill
    {
      [Token(Token = "0x600FA64"), Address(RVA = "0x44C6EE0", Offset = "0x44C6EE0", VA = "0x44C6EE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700367A")]
    public bool IsMoveSkill
    {
      [Token(Token = "0x600FA65"), Address(RVA = "0x44C6EFC", Offset = "0x44C6EFC", VA = "0x44C6EFC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700367B")]
    public bool IsItemSkill
    {
      [Token(Token = "0x600FA66"), Address(RVA = "0x44C6F18", Offset = "0x44C6F18", VA = "0x44C6F18")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700367C")]
    public bool IsDuelSkill
    {
      [Token(Token = "0x600FA67"), Address(RVA = "0x44C6F34", Offset = "0x44C6F34", VA = "0x44C6F34")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700367D")]
    public bool IsSupportSkill
    {
      [Token(Token = "0x600FA68"), Address(RVA = "0x44C6F4C", Offset = "0x44C6F4C", VA = "0x44C6F4C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700367E")]
    public bool IsFierceSkill
    {
      [Token(Token = "0x600FA69"), Address(RVA = "0x44C6F7C", Offset = "0x44C6F7C", VA = "0x44C6F7C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700367F")]
    public bool IsTargetEnemySkill
    {
      [Token(Token = "0x600FA6A"), Address(RVA = "0x44C6FA8", Offset = "0x44C6FA8", VA = "0x44C6FA8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600FA6B")]
    [Address(RVA = "0x44C698C", Offset = "0x44C698C", VA = "0x44C698C")]
    public static SkillParameterData Create(SkillParameterSource source)
    {
      return (SkillParameterData) null;
    }

    [Token(Token = "0x600FA6C")]
    [Address(RVA = "0x44BEE18", Offset = "0x44BEE18", VA = "0x44BEE18")]
    public static SkillParameterData Clone(
      SkillParameterData src,
      ISkillParameterDataHandler handler)
    {
      return (SkillParameterData) null;
    }

    [Token(Token = "0x600FA6D")]
    [Address(RVA = "0x44C6FCC", Offset = "0x44C6FCC", VA = "0x44C6FCC")]
    public SkillParameterData Copy() => (SkillParameterData) null;

    [Token(Token = "0x600FA6E")]
    [Address(RVA = "0x44C7014", Offset = "0x44C7014", VA = "0x44C7014")]
    public void Activate()
    {
    }

    [Token(Token = "0x600FA6F")]
    [Address(RVA = "0x44C7020", Offset = "0x44C7020", VA = "0x44C7020")]
    public void Deactivate()
    {
    }

    [Token(Token = "0x600FA70")]
    [Address(RVA = "0x44C7028", Offset = "0x44C7028", VA = "0x44C7028")]
    public void AfterUse()
    {
    }

    [Token(Token = "0x600FA71")]
    [Address(RVA = "0x44C70C8", Offset = "0x44C70C8", VA = "0x44C70C8")]
    public void CoolTimeConsume()
    {
    }

    [Token(Token = "0x600FA72")]
    [Address(RVA = "0x44C7048", Offset = "0x44C7048", VA = "0x44C7048")]
    private void UsableCountConsume()
    {
    }

    [Token(Token = "0x600FA73")]
    [Address(RVA = "0x44C70B0", Offset = "0x44C70B0", VA = "0x44C70B0")]
    private void SetCoolTime()
    {
    }

    [Token(Token = "0x600FA74")]
    [Address(RVA = "0x44C7130", Offset = "0x44C7130", VA = "0x44C7130")]
    public IBasicRangeData GetCompositeEffectiveRange(ConditionTargetTypeEnum effectiveBase)
    {
      return (IBasicRangeData) null;
    }

    [Token(Token = "0x600FA75")]
    [Address(RVA = "0x44C7168", Offset = "0x44C7168", VA = "0x44C7168")]
    public bool IsTargettable(BoardData board, UnitParameterData from, UnitParameterData to)
    {
      return new bool();
    }

    [Token(Token = "0x600FA76")]
    [Address(RVA = "0x44C7180", Offset = "0x44C7180", VA = "0x44C7180")]
    public bool IsTargettable(BattlePlayerData player, UnitParameterData targetUnit) => new bool();

    [Token(Token = "0x600FA77")]
    [Address(RVA = "0x44C7198", Offset = "0x44C7198", VA = "0x44C7198")]
    public bool IsConditionEmpty() => new bool();

    [Token(Token = "0x600FA78")]
    [Address(RVA = "0x44C71B0", Offset = "0x44C71B0", VA = "0x44C71B0")]
    public bool IsConditionable(
      SkillTriggerTimingTypeEnum timing,
      UnitParameterData unit,
      WeaponParameterData weaponParam,
      BoardData board)
    {
      return new bool();
    }

    [Token(Token = "0x600FA79")]
    [Address(RVA = "0x44C71D0", Offset = "0x44C71D0", VA = "0x44C71D0")]
    public bool IsConditionable(SkillTriggerTimingTypeEnum timing, ConditionParam conditionParam)
    {
      return new bool();
    }

    [Token(Token = "0x600FA7A")]
    [Address(RVA = "0x44C71E8", Offset = "0x44C71E8", VA = "0x44C71E8")]
    public bool IsEffectable(BoardData board, UnitParameterData from, UnitParameterData to)
    {
      return new bool();
    }

    [Token(Token = "0x600FA7B")]
    [Address(RVA = "0x44C7200", Offset = "0x44C7200", VA = "0x44C7200")]
    public bool SupportOffsetConditionable(
      SkillTriggerTimingTypeEnum timing,
      UnitParameterData unit,
      BoardData board)
    {
      return new bool();
    }

    [Token(Token = "0x600FA7C")]
    [Address(RVA = "0x44C7218", Offset = "0x44C7218", VA = "0x44C7218", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600FA7D")]
    [Address(RVA = "0x44C6FC4", Offset = "0x44C6FC4", VA = "0x44C6FC4")]
    public SkillParameterData()
    {
    }
  }
}
