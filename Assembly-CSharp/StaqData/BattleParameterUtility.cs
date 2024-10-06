// Decompiled with JetBrains decompiler
// Type: StaqData.BattleParameterUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FEE")]
  public static class BattleParameterUtility
  {
    [Token(Token = "0x400883B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Dictionary<int, string> BattleParameterLabel;
    [Token(Token = "0x400883C")]
    [FieldOffset(Offset = "0x8")]
    private static Decimal CombatPower_FactorA;
    [Token(Token = "0x400883D")]
    [FieldOffset(Offset = "0x18")]
    private static Decimal CombatPower_FactorB;
    [Token(Token = "0x400883E")]
    [FieldOffset(Offset = "0x28")]
    private static Decimal CombatPower_FactorC;
    [Token(Token = "0x400883F")]
    [FieldOffset(Offset = "0x38")]
    private static Decimal CombatPower_FactorD;
    [Token(Token = "0x4008840")]
    [FieldOffset(Offset = "0x48")]
    private static Decimal CombatPower_FactorE;
    [Token(Token = "0x4008841")]
    [FieldOffset(Offset = "0x58")]
    private static Decimal CombatPower_FactorF;
    [Token(Token = "0x4008842")]
    private const int CombatPowerDefOffset = 200;
    [Token(Token = "0x4008843")]
    private const int OFFSET_DEFAULT = 100;

    [Token(Token = "0x600BDC9")]
    [Address(RVA = "0x1E5B72C", Offset = "0x1E5B72C", VA = "0x1E5B72C")]
    public static BattleParameter CreateFromSchema(staq.SaveSchema.BattleParameter schema)
    {
      return (BattleParameter) null;
    }

    [Token(Token = "0x600BDCA")]
    [Address(RVA = "0x1E5B86C", Offset = "0x1E5B86C", VA = "0x1E5B86C")]
    public static int CalcBaseHp(int life) => new int();

    [Token(Token = "0x600BDCB")]
    [Address(RVA = "0x1E5B954", Offset = "0x1E5B954", VA = "0x1E5B954")]
    public static int CalcBasePhysicalAtk(int strength) => new int();

    [Token(Token = "0x600BDCC")]
    [Address(RVA = "0x1E5B958", Offset = "0x1E5B958", VA = "0x1E5B958")]
    public static int CalcBasePhysicalDef(int vitality) => new int();

    [Token(Token = "0x600BDCD")]
    [Address(RVA = "0x1E5B95C", Offset = "0x1E5B95C", VA = "0x1E5B95C")]
    public static int CalcBaseMagicalAtk(int intelligence) => new int();

    [Token(Token = "0x600BDCE")]
    [Address(RVA = "0x1E5B960", Offset = "0x1E5B960", VA = "0x1E5B960")]
    public static int CalcBaseMagicalDef(int mind) => new int();

    [Token(Token = "0x600BDCF")]
    [Address(RVA = "0x1E5B964", Offset = "0x1E5B964", VA = "0x1E5B964")]
    public static int CalcBaseHit(int dexterity, int lucky) => new int();

    [Token(Token = "0x600BDD0")]
    [Address(RVA = "0x1E5BA90", Offset = "0x1E5BA90", VA = "0x1E5BA90")]
    public static int CalcBaseAvoid(int agility, int lucky) => new int();

    [Token(Token = "0x600BDD1")]
    [Address(RVA = "0x1E5BBBC", Offset = "0x1E5BBBC", VA = "0x1E5BBBC")]
    public static int CalcBaseCritical(int dexterity) => new int();

    [Token(Token = "0x600BDD2")]
    [Address(RVA = "0x1E5BCA4", Offset = "0x1E5BCA4", VA = "0x1E5BCA4")]
    public static int CalcBaseCriticalAvoid(int lucky) => new int();

    [Token(Token = "0x600BDD3")]
    [Address(RVA = "0x1E5BD8C", Offset = "0x1E5BD8C", VA = "0x1E5BD8C")]
    public static int CalcBaseAtkSpeed(int agility) => new int();

    [Token(Token = "0x600BDD4")]
    [Address(RVA = "0x1E5BD90", Offset = "0x1E5BD90", VA = "0x1E5BD90")]
    public static BattleParameter CalcBaseBattleParameter(IBasicParameter basic)
    {
      return (BattleParameter) null;
    }

    [Token(Token = "0x600BDD5")]
    [Address(RVA = "0x1E5C310", Offset = "0x1E5C310", VA = "0x1E5C310")]
    public static IBattleParameter GetStyleMasterBonus(PlayerProfile profile, Style style)
    {
      return (IBattleParameter) null;
    }

    [Token(Token = "0x600BDD6")]
    [Address(RVA = "0x1E5C324", Offset = "0x1E5C324", VA = "0x1E5C324")]
    public static IBattleParameter GetGuildFacilityBonus() => (IBattleParameter) null;

    [Token(Token = "0x600BDD7")]
    [Address(RVA = "0x1E5C384", Offset = "0x1E5C384", VA = "0x1E5C384")]
    public static int CalcUnitOffsetDamageRate(int offsetRate1, int offsetRate2 = 0) => new int();

    [Token(Token = "0x600BDD8")]
    [Address(RVA = "0x1E5C770", Offset = "0x1E5C770", VA = "0x1E5C770")]
    public static int CalcUnitOffsetChanceRate(int offsetRate1, int offsetRate2 = 0) => new int();

    [Token(Token = "0x600BDD9")]
    [Address(RVA = "0x1E5C454", Offset = "0x1E5C454", VA = "0x1E5C454")]
    private static int CalcUnitOffsetRate(
      int[] offsets,
      int offsetBaseValueB1,
      int offsetBaseValueB2)
    {
      return new int();
    }

    [Token(Token = "0x600BDDA")]
    [Address(RVA = "0x1E5C840", Offset = "0x1E5C840", VA = "0x1E5C840")]
    public static int CalcMoveAmount(Battle.Data.Board.UnitParameterData unit) => new int();

    [Token(Token = "0x600BDDB")]
    [Address(RVA = "0x1E5C8BC", Offset = "0x1E5C8BC", VA = "0x1E5C8BC")]
    public static int GetBuffDeduffMoveAmount(Battle.Data.Board.UnitParameterData unit)
    {
      return new int();
    }

    [Token(Token = "0x600BDDC")]
    [Address(RVA = "0x1E5C9E4", Offset = "0x1E5C9E4", VA = "0x1E5C9E4")]
    public static int CalcLoadWeight(int weights, int strength) => new int();

    [Token(Token = "0x600BDDD")]
    [Address(RVA = "0x1E5CAB8", Offset = "0x1E5CAB8", VA = "0x1E5CAB8")]
    public static int GetParameter(
      this BattleParameterType parameterType,
      IBattleParameter parameter)
    {
      return new int();
    }

    [Token(Token = "0x600BDDE")]
    [Address(RVA = "0x1E5CE1C", Offset = "0x1E5CE1C", VA = "0x1E5CE1C")]
    public static int CalcCombatPowerHP(int paramValue, int offsetRate) => new int();

    [Token(Token = "0x600BDDF")]
    [Address(RVA = "0x1E5D218", Offset = "0x1E5D218", VA = "0x1E5D218")]
    public static int CalcCombatPowerPhysicalAtk(int paramValue, int offsetRate) => new int();

    [Token(Token = "0x600BDE0")]
    [Address(RVA = "0x1E5D2CC", Offset = "0x1E5D2CC", VA = "0x1E5D2CC")]
    public static int CalcCombatPowerPhysicalDef(int paramValue, int offsetRate) => new int();

    [Token(Token = "0x600BDE1")]
    [Address(RVA = "0x1E5D3B0", Offset = "0x1E5D3B0", VA = "0x1E5D3B0")]
    public static int CalcCombatPowerMagicalAtk(int paramValue, int offsetRate) => new int();

    [Token(Token = "0x600BDE2")]
    [Address(RVA = "0x1E5D464", Offset = "0x1E5D464", VA = "0x1E5D464")]
    public static int CalcCombatPowerMagicalDef(int paramValue, int offsetRate) => new int();

    [Token(Token = "0x600BDE3")]
    [Address(RVA = "0x1E5D548", Offset = "0x1E5D548", VA = "0x1E5D548")]
    public static int CalcCombatPowerHit(int paramValue, int offsetRate) => new int();

    [Token(Token = "0x600BDE4")]
    [Address(RVA = "0x1E5D6CC", Offset = "0x1E5D6CC", VA = "0x1E5D6CC")]
    public static int CalcCombatPowerAvoid(int paramValue, int offsetRate) => new int();

    [Token(Token = "0x600BDE5")]
    [Address(RVA = "0x1E5D854", Offset = "0x1E5D854", VA = "0x1E5D854")]
    public static int CalcCombatPowerCritical(int paramValue, int offsetRate) => new int();

    [Token(Token = "0x600BDE6")]
    [Address(RVA = "0x1E5D990", Offset = "0x1E5D990", VA = "0x1E5D990")]
    public static int CalcCombatPowerCriticalAvoid(int paramValue, int offsetRate) => new int();

    [Token(Token = "0x600BDE7")]
    [Address(RVA = "0x1E5DAD0", Offset = "0x1E5DAD0", VA = "0x1E5DAD0")]
    public static int CalcCombatPowerSpeed(int paramValue) => new int();

    [Token(Token = "0x600BDE8")]
    [Address(RVA = "0x1E5DBB4", Offset = "0x1E5DBB4", VA = "0x1E5DBB4")]
    public static int CalcCombatPower(Battle.Data.Board.UnitParameterData unit, Battle.Data.Board.BattlePlayerData owner)
    {
      return new int();
    }

    [Token(Token = "0x600BDE9")]
    [Address(RVA = "0x1E5ED38", Offset = "0x1E5ED38", VA = "0x1E5ED38")]
    public static int CalcCombatPower(PlayerProfile profile, Style style) => new int();

    [Token(Token = "0x600BDEA")]
    [Address(RVA = "0x1E5EE08", Offset = "0x1E5EE08", VA = "0x1E5EE08")]
    public static int CalcCombatPower(
      IBattleParameter parameter,
      IBattleParameter styleMastarBonus,
      StyleData styleData)
    {
      return new int();
    }

    [Token(Token = "0x600BDEB")]
    [Address(RVA = "0x1E5E8B0", Offset = "0x1E5E8B0", VA = "0x1E5E8B0")]
    public static int CalcCombatPower(
      int hp,
      int physicalAtk,
      int physicalDef,
      int magicalAtk,
      int magicalDef,
      int hit,
      int avoid,
      int critical,
      int criticalAvoid,
      int speed,
      IBattleParameter offsetRateBase)
    {
      return new int();
    }

    [Token(Token = "0x600BDEC")]
    [Address(RVA = "0x1E5FBB0", Offset = "0x1E5FBB0", VA = "0x1E5FBB0")]
    public static int CalcCombatPower(IBattleParameter battleParameter) => new int();

    [Token(Token = "0x600BDED")]
    [Address(RVA = "0x1E60058", Offset = "0x1E60058", VA = "0x1E60058")]
    public static int CalcCombatPower(
      int hp,
      int physicalAtk,
      int physicalDef,
      int magicalAtk,
      int magicalDef,
      int hit,
      int avoid,
      int critical,
      int criticalAvoid,
      int speed)
    {
      return new int();
    }

    [Token(Token = "0x600BDEE")]
    [Address(RVA = "0x1E5F9C4", Offset = "0x1E5F9C4", VA = "0x1E5F9C4")]
    public static int CalcCombatPower(
      int hp,
      int hpOffsetRate,
      int physicalAtk,
      int physicalAtkOffsetRate,
      int physicalDef,
      int physicalDefOffsetRate,
      int magicalAtk,
      int magicalAtkOffsetRate,
      int magicalDef,
      int magicalDefOffsetRate,
      int hit,
      int hitOffsetRate,
      int avoid,
      int avoidOffsetRate,
      int critical,
      int criticalOffsetRate,
      int criticalAvoid,
      int criticalAvoidOffsetRate,
      int speed,
      int speedOffsetRate = 0)
    {
      return new int();
    }

    [Token(Token = "0x600BDEF")]
    [Address(RVA = "0x1E60148", Offset = "0x1E60148", VA = "0x1E60148")]
    static BattleParameterUtility()
    {
    }
  }
}
