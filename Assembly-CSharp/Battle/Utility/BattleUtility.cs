// Decompiled with JetBrains decompiler
// Type: Battle.Utility.BattleUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Logic;
using Battle.Unit;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Utility
{
  [Token(Token = "0x20022C8")]
  public static class BattleUtility
  {
    [Token(Token = "0x4009326")]
    [FieldOffset(Offset = "0x0")]
    public static int PreloadEffectCountPerOnce;

    [Token(Token = "0x600D418")]
    [Address(RVA = "0x19DE9C8", Offset = "0x19DE9C8", VA = "0x19DE9C8")]
    public static bool Lottery(BoardData board, Decimal chance) => new bool();

    [Token(Token = "0x600D419")]
    [Address(RVA = "0x19DEA58", Offset = "0x19DEA58", VA = "0x19DEA58")]
    public static bool IsUsableDurable(
      WeaponParameterData weaponParam,
      SkillParameterData skillParam)
    {
      return new bool();
    }

    [Token(Token = "0x600D41A")]
    [Address(RVA = "0x19DEAAC", Offset = "0x19DEAAC", VA = "0x19DEAAC")]
    public static bool IsUsableDurable(WeaponParameterData weaponParam, Battle.Data.Board.SkillData skill)
    {
      return new bool();
    }

    [Token(Token = "0x600D41B")]
    [Address(RVA = "0x19DEB00", Offset = "0x19DEB00", VA = "0x19DEB00")]
    public static bool IsAptitudeWeapon(UnitParameterData unit, WeaponParameterData weapon)
    {
      return new bool();
    }

    [Token(Token = "0x600D41C")]
    [Address(RVA = "0x19DECFC", Offset = "0x19DECFC", VA = "0x19DECFC")]
    public static void PlaySe(string soundId)
    {
    }

    [Token(Token = "0x600D41D")]
    [Address(RVA = "0x19DEEF8", Offset = "0x19DEEF8", VA = "0x19DEEF8")]
    public static bool IsPlacedAt(UnitParameterData unit, int x, int y) => new bool();

    [Token(Token = "0x600D41E")]
    [Address(RVA = "0x19DF044", Offset = "0x19DF044", VA = "0x19DF044")]
    public static int Distance(UnitParameterData unit1, UnitParameterData unit2) => new int();

    [Token(Token = "0x600D41F")]
    [Address(RVA = "0x19DF2DC", Offset = "0x19DF2DC", VA = "0x19DF2DC")]
    public static Dictionary<EffectData, List<UnitParameterData>> GetEffectiveSupportHealEffect(
      BoardData board,
      UnitParameterData unit,
      UnitParameterData supportUnit,
      SkillParameterData effectiveSkillParam)
    {
      return (Dictionary<EffectData, List<UnitParameterData>>) null;
    }

    [Token(Token = "0x600D420")]
    [Address(RVA = "0x19DFE1C", Offset = "0x19DFE1C", VA = "0x19DFE1C")]
    public static (UnitParameterChange, UnitParameterChange) CreateParameterBySupportHealing(
      BoardData board,
      UnitParameterData from,
      UnitParameterData to,
      SkillParameterData affectSkill,
      EffectData effect)
    {
      return ();
    }

    [Token(Token = "0x600D421")]
    [Address(RVA = "0x19E0030", Offset = "0x19E0030", VA = "0x19E0030")]
    public static void CalcPositionFrom(
      Actor.Direction direction,
      int xCenter,
      int yCenter,
      int xDist,
      int yDist,
      out int ax,
      out int ay)
    {
    }

    [Token(Token = "0x600D422")]
    [Address(RVA = "0x19E0098", Offset = "0x19E0098", VA = "0x19E0098")]
    public static GridData GetUnitGrid(UnitParameterData unit) => (GridData) null;

    [Token(Token = "0x600D423")]
    [Address(RVA = "0x19E00D8", Offset = "0x19E00D8", VA = "0x19E00D8")]
    public static bool ContainsInRangeFrom(
      IBasicRangeData range,
      UnitParameterData from,
      UnitParameterData to)
    {
      return new bool();
    }

    [Token(Token = "0x600D424")]
    [Address(RVA = "0x19E05B0", Offset = "0x19E05B0", VA = "0x19E05B0")]
    public static List<GridData> GetInRangeGrids(
      BoardData board,
      UnitParameterData from,
      int minDistance,
      int maxDistance)
    {
      return (List<GridData>) null;
    }

    [Token(Token = "0x600D425")]
    [Address(RVA = "0x19E071C", Offset = "0x19E071C", VA = "0x19E071C")]
    public static List<GridData> GetInRangeGrids(
      BoardData board,
      List<GridData> from,
      int minDistance,
      int maxDistance)
    {
      return (List<GridData>) null;
    }

    [Token(Token = "0x600D426")]
    [Address(RVA = "0x19E0CE4", Offset = "0x19E0CE4", VA = "0x19E0CE4")]
    public static void CalcRangeVfxScalingFromRange(
      IBasicRangeData range,
      out float scaleX,
      out float scaleZ)
    {
    }

    [Token(Token = "0x600D427")]
    [Address(RVA = "0x19E0CF4", Offset = "0x19E0CF4", VA = "0x19E0CF4")]
    public static IReadOnlyList<IEffectValueCalculator> CreateCalculators(
      BoardData board,
      IDamageEffect damageEffect,
      bool isCritical,
      UnitParameterData activator,
      ICorrectableParameter<IBattleParameter> activatorBattleParam,
      WeaponParameterData activatorWeaponParam,
      UnitParameterData target,
      ICorrectableParameter<IBattleParameter> targetBattleParam)
    {
      return (IReadOnlyList<IEffectValueCalculator>) null;
    }

    [Token(Token = "0x600D428")]
    [Address(RVA = "0x19E0FB8", Offset = "0x19E0FB8", VA = "0x19E0FB8")]
    public static IEffectValueCalculator CreateBaseCalculator(
      IEffectValue effect,
      UnitParameterData target)
    {
      return (IEffectValueCalculator) null;
    }

    [Token(Token = "0x600D429")]
    [Address(RVA = "0x19E1228", Offset = "0x19E1228", VA = "0x19E1228")]
    private static BasicDamage CreateBasicDamage(
      IDamageEffect damageEffect,
      ICorrectableParameter<IBattleParameter> activatorBattleParam,
      WeaponParameterData activatorWeaponParam,
      ICorrectableParameter<IBattleParameter> targetBattleParam)
    {
      return (BasicDamage) null;
    }

    [Token(Token = "0x600D42A")]
    [Address(RVA = "0x19E1604", Offset = "0x19E1604", VA = "0x19E1604")]
    private static CorrectedDamage CreateCorrectedDamage(
      IDamageEffect damageEffect,
      bool isCritical,
      UnitParameterData activator,
      BattlePlayerData activatorOwner,
      WeaponParameterData activatorWeaponParam,
      UnitParameterData target,
      BattlePlayerData targetOwner)
    {
      return (CorrectedDamage) null;
    }

    [Token(Token = "0x600D42B")]
    [Address(RVA = "0x19E23A8", Offset = "0x19E23A8", VA = "0x19E23A8")]
    public static BarrierResistance.Param CreateBarrierResistanceParam(
      UnitParameterData acitonUnit,
      TargetPair targetPair,
      IDamageEffect damageEffect)
    {
      return new BarrierResistance.Param();
    }

    [Token(Token = "0x600D42C")]
    [Address(RVA = "0x19E2514", Offset = "0x19E2514", VA = "0x19E2514")]
    public static HealValue.Param CreateHealParam(
      BattleLogicConstData constData,
      UnitParameterData activator,
      WeaponParameterData activatorWeaponParam,
      ICorrectableParameter<IBattleParameter> activatorBattleParam,
      UnitParameterData target,
      HealEffectData healEffect)
    {
      return (HealValue.Param) null;
    }

    [Token(Token = "0x600D42D")]
    [Address(RVA = "0x19E26D8", Offset = "0x19E26D8", VA = "0x19E26D8")]
    public static SupportGuard.Param CreateSupportGuardParam(
      WeaponParameterData weaponParam,
      IDamageEffect damageEffect,
      SupportGuardEffectData supportGuardEffect)
    {
      return new SupportGuard.Param();
    }

    [Token(Token = "0x600D42E")]
    [Address(RVA = "0x19E2724", Offset = "0x19E2724", VA = "0x19E2724")]
    public static void LoadCommonParticles(IDirector mainDirector)
    {
    }

    [Token(Token = "0x600D42F")]
    [Address(RVA = "0x19E2FF4", Offset = "0x19E2FF4", VA = "0x19E2FF4")]
    public static void LoadUnitParticles(IDirector mainDirector, IEnumerable<UnitData> units)
    {
    }

    [Token(Token = "0x600D430")]
    public static int GetModifierValue<TModifierCategory>(
      this TModifierCategory self,
      BattleEffectTypeEnum effectType,
      BattleEffectValueTypeEnum valueType,
      UnitParameterData unit)
      where TModifierCategory : Enum
    {
      return new int();
    }

    [Token(Token = "0x600D431")]
    [Address(RVA = "0x19E3788", Offset = "0x19E3788", VA = "0x19E3788")]
    public static bool IsSameParty(UnitParameterData aUnitParam, UnitParameterData bUnitParam)
    {
      return new bool();
    }

    [Token(Token = "0x600D432")]
    [Address(RVA = "0x19E37EC", Offset = "0x19E37EC", VA = "0x19E37EC")]
    public static Decimal CalcEffectRate(Decimal X) => 0M;

    [Token(Token = "0x600D433")]
    [Address(RVA = "0x19E4040", Offset = "0x19E4040", VA = "0x19E4040")]
    public static void ConvertTimeAndWeatherFromStorySequence(
      out BattleTimeTypeEnum time,
      out BattleWeatherTypeEnum weather)
    {
    }

    [Token(Token = "0x600D434")]
    [Address(RVA = "0x19E4154", Offset = "0x19E4154", VA = "0x19E4154")]
    static BattleUtility()
    {
    }
  }
}
