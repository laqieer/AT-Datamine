// Decompiled with JetBrains decompiler
// Type: Battle.AttackUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace Battle
{
  [Token(Token = "0x200228C")]
  public static class AttackUtility
  {
    [Token(Token = "0x4009198")]
    public const int CriticalDamageRate = 200;
    [Token(Token = "0x4009199")]
    public const int SlayEqualTimeRate = 100;

    [Token(Token = "0x600D2A0")]
    [Address(RVA = "0x19615E0", Offset = "0x19615E0", VA = "0x19615E0")]
    public static bool IsChasableAtkSpeed(
      BoardData board,
      UnitParameterData activator,
      UnitParameterData target)
    {
      return new bool();
    }

    [Token(Token = "0x600D2A1")]
    [Address(RVA = "0x196183C", Offset = "0x196183C", VA = "0x196183C")]
    public static SkillParameterData GetEffectiveSupportSkill(
      BoardData board,
      UnitParameterData unit)
    {
      return (SkillParameterData) null;
    }

    [Token(Token = "0x600D2A2")]
    [Address(RVA = "0x1961ABC", Offset = "0x1961ABC", VA = "0x1961ABC")]
    public static (UnitParameterData, SkillParameterData, int)? GetEffectiveSupportSkillFromFront(
      BoardData board,
      UnitParameterData unit)
    {
      return new (UnitParameterData, SkillParameterData, int)?();
    }

    [Token(Token = "0x600D2A3")]
    [Address(RVA = "0x19622C0", Offset = "0x19622C0", VA = "0x19622C0")]
    public static SkillParameterData LotSupportSkill(
      BoardData board,
      SkillParameterData skill,
      int rate,
      AttackUtility.EffectableValidator validator = null)
    {
      return (SkillParameterData) null;
    }

    [Token(Token = "0x600D2A4")]
    [Address(RVA = "0x196239C", Offset = "0x196239C", VA = "0x196239C")]
    private static bool IsAbsoluteDivide(
      UnitParameterData atkUnit,
      UnitParameterData defUnit,
      BattleEffectTypeEnum effectType)
    {
      return new bool();
    }

    [Token(Token = "0x600D2A5")]
    [Address(RVA = "0x19623D8", Offset = "0x19623D8", VA = "0x19623D8")]
    private static bool IsAbsolute(UnitParameterData unit, BattleEffectTypeEnum effectType)
    {
      return new bool();
    }

    [Token(Token = "0x600D2A6")]
    [Address(RVA = "0x1962518", Offset = "0x1962518", VA = "0x1962518")]
    public static Decimal CalcHitRateA(
      BattlePlayerData atkOwner,
      UnitParameterData atkUnit,
      ICorrectableParameter<IBattleParameter> atkBattleParam,
      BattlePlayerData defOwner,
      UnitParameterData defUnit,
      ICorrectableParameter<IBattleParameter> defBattleParam)
    {
      return 0M;
    }

    [Token(Token = "0x600D2A7")]
    [Address(RVA = "0x19627FC", Offset = "0x19627FC", VA = "0x19627FC")]
    public static int CalcHitRate(
      UnitParameterData atkUnit,
      UnitParameterData defUnit,
      Decimal hitRateA)
    {
      return new int();
    }

    [Token(Token = "0x600D2A8")]
    [Address(RVA = "0x196297C", Offset = "0x196297C", VA = "0x196297C")]
    public static bool IsHit(
      BoardData board,
      UnitParameterData atkUnit,
      ICorrectableParameter<IBattleParameter> atkBattleParam,
      UnitParameterData defUnit,
      ICorrectableParameter<IBattleParameter> defBattleParam,
      EffectData effectData,
      out int hitRate)
    {
      return new bool();
    }

    [Token(Token = "0x600D2A9")]
    [Address(RVA = "0x1962BD4", Offset = "0x1962BD4", VA = "0x1962BD4")]
    public static int CalcCriticalRate(
      BoardData board,
      UnitParameterData atkUnit,
      ICorrectableParameter<IBattleParameter> atkBattleParam,
      UnitParameterData defUnit,
      ICorrectableParameter<IBattleParameter> defBattleParam)
    {
      return new int();
    }

    [Token(Token = "0x600D2AA")]
    [Address(RVA = "0x1963008", Offset = "0x1963008", VA = "0x1963008")]
    public static bool IsCritical(
      BoardData board,
      UnitParameterData atkUnit,
      ICorrectableParameter<IBattleParameter> atkBattleParam,
      UnitParameterData defUnit,
      ICorrectableParameter<IBattleParameter> defBattleParam)
    {
      return new bool();
    }

    [Token(Token = "0x600D2AB")]
    [Address(RVA = "0x19630E0", Offset = "0x19630E0", VA = "0x19630E0")]
    public static EffectParameterData GetActivatableEndure(
      BoardData boardData,
      UnitParameterData unitParam)
    {
      return (EffectParameterData) null;
    }

    [Token(Token = "0x600D2AC")]
    [Address(RVA = "0x1963360", Offset = "0x1963360", VA = "0x1963360")]
    public static int GetElementEnhanceRate(
      ElementTypeEnum element,
      UnitParameterData unit,
      WeaponParameterData weaponParam)
    {
      return new int();
    }

    [Token(Token = "0x600D2AD")]
    [Address(RVA = "0x1963840", Offset = "0x1963840", VA = "0x1963840")]
    public static int GetElementResistRate(ElementTypeEnum element, UnitParameterData unit)
    {
      return new int();
    }

    [Token(Token = "0x600D2AE")]
    [Address(RVA = "0x1963BA4", Offset = "0x1963BA4", VA = "0x1963BA4")]
    public static int GetAttackTypeEnhanceRate(
      AttackTypeEnum attackType,
      UnitParameterData unit,
      WeaponParameterData weaponParam)
    {
      return new int();
    }

    [Token(Token = "0x600D2AF")]
    [Address(RVA = "0x1964084", Offset = "0x1964084", VA = "0x1964084")]
    public static int GetAttackTypeResistRate(AttackTypeEnum attackType, UnitParameterData unit)
    {
      return new int();
    }

    [Token(Token = "0x600D2B0")]
    [Address(RVA = "0x19643E8", Offset = "0x19643E8", VA = "0x19643E8")]
    public static Decimal GetAtkEnhanceResistRate(
      UnitParameterData attacker,
      WeaponParameterData attackWeapon,
      AttackTypeEnum attackType,
      ElementTypeEnum attackElement,
      UnitParameterData defender,
      out Decimal enhance,
      out Decimal resist)
    {
      return 0M;
    }

    [Token(Token = "0x600D2B1")]
    [Address(RVA = "0x1964988", Offset = "0x1964988", VA = "0x1964988")]
    public static float GetSlayDamageRate(UnitParameterData attacker, UnitParameterData defender)
    {
      return new float();
    }

    [Token(Token = "0x600D2B2")]
    [Address(RVA = "0x1964A4C", Offset = "0x1964A4C", VA = "0x1964A4C")]
    public static int GetAkSlayValue(UnitParameterData attacker, UnitParameterData defender)
    {
      return new int();
    }

    [Token(Token = "0x600D2B3")]
    [Address(RVA = "0x1964ACC", Offset = "0x1964ACC", VA = "0x1964ACC")]
    private static int GetAtkElementSlayValue(
      UnitParameterData attacker,
      UnitParameterData defender)
    {
      return new int();
    }

    [Token(Token = "0x600D2B4")]
    [Address(RVA = "0x1964BA4", Offset = "0x1964BA4", VA = "0x1964BA4")]
    private static int GetAtkSpeciesSlayValue(
      UnitParameterData attacker,
      UnitParameterData defender)
    {
      return new int();
    }

    [Token(Token = "0x600D2B5")]
    [Address(RVA = "0x1964D24", Offset = "0x1964D24", VA = "0x1964D24")]
    private static int GetAtkArmorSlayValue(UnitParameterData attacker, UnitParameterData defender)
    {
      return new int();
    }

    [Token(Token = "0x600D2B6")]
    [Address(RVA = "0x1964DFC", Offset = "0x1964DFC", VA = "0x1964DFC")]
    private static int GetAtkRideSlayValue(UnitParameterData attacker, UnitParameterData defender)
    {
      return new int();
    }

    [Token(Token = "0x600D2B7")]
    [Address(RVA = "0x1964ED4", Offset = "0x1964ED4", VA = "0x1964ED4")]
    private static int GetAtkMoveSlayValue(UnitParameterData attacker, UnitParameterData defender)
    {
      return new int();
    }

    [Token(Token = "0x600D2B8")]
    [Address(RVA = "0x1961E70", Offset = "0x1961E70", VA = "0x1961E70")]
    private static int CalcActivateSupportSkillRate(
      BoardData board,
      UnitParameterData unit,
      UnitParameterData supportUnit,
      SkillParameterData skillParam)
    {
      return new int();
    }

    [Token(Token = "0x600D2B9")]
    [Address(RVA = "0x1964FB8", Offset = "0x1964FB8", VA = "0x1964FB8")]
    public static AttackTypeEnum GetActualAttackType(
      WeaponParameterData weapon,
      AttackTypeEnum attackType)
    {
      return new AttackTypeEnum();
    }

    [Token(Token = "0x600D2BA")]
    [Address(RVA = "0x1964FDC", Offset = "0x1964FDC", VA = "0x1964FDC")]
    public static WeaponAttackTypeEnum GetActualWeaponAttackType(
      WeaponParameterData weapon,
      IDamageEffect damageEffect)
    {
      return new WeaponAttackTypeEnum();
    }

    [Token(Token = "0x200228D")]
    public delegate bool EffectableValidator(SkillParameterData skillParam);
  }
}
