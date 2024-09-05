// Decompiled with JetBrains decompiler
// Type: Battle.Data.ConditionParamUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200274B")]
  public class ConditionParamUnit : ConditionParam
  {
    [Token(Token = "0x1700345D")]
    protected ITargettable ExTarget
    {
      [Token(Token = "0x600F4F4"), Address(RVA = "0x1FB14D4", Offset = "0x1FB14D4", VA = "0x1FB14D4")] get
      {
        return (ITargettable) null;
      }
      [Token(Token = "0x600F4F5"), Address(RVA = "0x1FB14DC", Offset = "0x1FB14DC", VA = "0x1FB14DC")] private set
      {
      }
    }

    [Token(Token = "0x1700345E")]
    protected WeaponParameterData ExTargetWeaponParam
    {
      [Token(Token = "0x600F4F6"), Address(RVA = "0x1FB14E4", Offset = "0x1FB14E4", VA = "0x1FB14E4")] get
      {
        return (WeaponParameterData) null;
      }
      [Token(Token = "0x600F4F7"), Address(RVA = "0x1FB14EC", Offset = "0x1FB14EC", VA = "0x1FB14EC")] private set
      {
      }
    }

    [Token(Token = "0x1700345F")]
    protected ITargettable ConditionTarget
    {
      [Token(Token = "0x600F4F8"), Address(RVA = "0x1FB14F4", Offset = "0x1FB14F4", VA = "0x1FB14F4")] get
      {
        return (ITargettable) null;
      }
      [Token(Token = "0x600F4F9"), Address(RVA = "0x1FB14FC", Offset = "0x1FB14FC", VA = "0x1FB14FC")] private set
      {
      }
    }

    [Token(Token = "0x17003460")]
    protected WeaponParameterData ConditionTargetWeaponParam
    {
      [Token(Token = "0x600F4FA"), Address(RVA = "0x1FB1504", Offset = "0x1FB1504", VA = "0x1FB1504")] get
      {
        return (WeaponParameterData) null;
      }
      [Token(Token = "0x600F4FB"), Address(RVA = "0x1FB150C", Offset = "0x1FB150C", VA = "0x1FB150C")] private set
      {
      }
    }

    [Token(Token = "0x600F4FC")]
    [Address(RVA = "0x1FB1514", Offset = "0x1FB1514", VA = "0x1FB1514")]
    public static ConditionParamUnit Create(
      BoardData board,
      ITargettable activator,
      WeaponParameterData activatorWeaponParam,
      ITargettable target,
      WeaponParameterData targetWeaponParam,
      ActionResult actionResult = null)
    {
      return (ConditionParamUnit) null;
    }

    [Token(Token = "0x600F4FD")]
    [Address(RVA = "0x1FB1618", Offset = "0x1FB1618", VA = "0x1FB1618")]
    public static ConditionParamUnit Create(
      BoardData board,
      ITargettable activator,
      WeaponParameterData activatorWeaponParam,
      ITargettable target,
      WeaponParameterData targetWeaponParam,
      ITargettable exTarget,
      WeaponParameterData exTargetWeaponParam,
      ActionResult actionResult)
    {
      return (ConditionParamUnit) null;
    }

    [Token(Token = "0x600F4FE")]
    [Address(RVA = "0x1FB15B0", Offset = "0x1FB15B0", VA = "0x1FB15B0")]
    protected ConditionParamUnit(
      BoardData board,
      ITargettable activator,
      WeaponParameterData activatorWeaponParam,
      ITargettable target,
      WeaponParameterData targetWeaponParam,
      ITargettable exTarget,
      WeaponParameterData exTargetWeaponParam,
      ActionResult actionResult)
    {
    }

    [Token(Token = "0x600F4FF")]
    [Address(RVA = "0x1FB16C4", Offset = "0x1FB16C4", VA = "0x1FB16C4", Slot = "4")]
    public override void SetConditionTarget(ConditionTargetTypeEnum targetType)
    {
    }

    [Token(Token = "0x600F500")]
    [Address(RVA = "0x1FB1714", Offset = "0x1FB1714", VA = "0x1FB1714", Slot = "5")]
    public override bool IsValidCondition(SkillTriggerConditionTypeEnum conditionType)
    {
      return new bool();
    }

    [Token(Token = "0x600F501")]
    [Address(RVA = "0x1FB1794", Offset = "0x1FB1794", VA = "0x1FB1794", Slot = "6")]
    protected override bool IsMatchConditionImpl(SkillTriggerConditionDetailData detail)
    {
      return new bool();
    }

    [Token(Token = "0x600F502")]
    [Address(RVA = "0x1FB24C4", Offset = "0x1FB24C4", VA = "0x1FB24C4")]
    private bool IsHpMoreThan(ITargettable activator, ITargettable target) => new bool();

    [Token(Token = "0x600F503")]
    [Address(RVA = "0x1FB25B0", Offset = "0x1FB25B0", VA = "0x1FB25B0")]
    private bool IsSameDistance(
      UnitParameterData activator,
      UnitParameterData target,
      int threshold)
    {
      return new bool();
    }

    [Token(Token = "0x600F504")]
    [Address(RVA = "0x1FB2628", Offset = "0x1FB2628", VA = "0x1FB2628")]
    private bool IsLessDistance(
      UnitParameterData activator,
      UnitParameterData target,
      int threshold)
    {
      return new bool();
    }

    [Token(Token = "0x600F505")]
    [Address(RVA = "0x1FB26A0", Offset = "0x1FB26A0", VA = "0x1FB26A0")]
    private bool IsMoreDistance(
      UnitParameterData activator,
      UnitParameterData target,
      int threshold)
    {
      return new bool();
    }

    [Token(Token = "0x600F506")]
    [Address(RVA = "0x1FB2718", Offset = "0x1FB2718", VA = "0x1FB2718")]
    private bool IsMatchStyleTag(UnitParameterData conditionTarget, int threshold) => new bool();

    [Token(Token = "0x600F507")]
    [Address(RVA = "0x1FB2780", Offset = "0x1FB2780", VA = "0x1FB2780")]
    private bool IsMatchHitCount(UnitParameterData conditionTarget, int threshold) => new bool();

    [Token(Token = "0x600F508")]
    [Address(RVA = "0x1FB2994", Offset = "0x1FB2994", VA = "0x1FB2994")]
    private bool IsMatchAvoidCount(UnitParameterData conditionTarget, int threshold) => new bool();

    [Token(Token = "0x600F509")]
    [Address(RVA = "0x1FB2B9C", Offset = "0x1FB2B9C", VA = "0x1FB2B9C")]
    private bool IsMatchCritCount(UnitParameterData conditionTarget, int threshold) => new bool();

    [Token(Token = "0x600F50A")]
    [Address(RVA = "0x1FB2DB0", Offset = "0x1FB2DB0", VA = "0x1FB2DB0")]
    private bool IsMatchHasChase(UnitParameterData conditionTarget) => new bool();
  }
}
