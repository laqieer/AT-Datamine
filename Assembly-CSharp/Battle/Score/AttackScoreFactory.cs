// Decompiled with JetBrains decompiler
// Type: Battle.Score.AttackScoreFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x2002478")]
  public class AttackScoreFactory
  {
    [Token(Token = "0x4009C6C")]
    [FieldOffset(Offset = "0x10")]
    private UnitBattleParameterBuilder battleParamBuilder;
    [Token(Token = "0x4009C6D")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<(int, string), IBattleParameter> battleParams;
    [Token(Token = "0x4009C6E")]
    [FieldOffset(Offset = "0x20")]
    private List<AttackScoreFactory.CreatedScore> createdScores;
    [Token(Token = "0x4009C6F")]
    [FieldOffset(Offset = "0x28")]
    private List<(int result, List<AttackScoreFactory.CreatedScore> list)> rank;
    [Token(Token = "0x4009C70")]
    private const int rankSize = 5;
    [Token(Token = "0x4009C71")]
    [FieldOffset(Offset = "0x30")]
    private AIConstParam attack;
    [Token(Token = "0x4009C72")]
    [FieldOffset(Offset = "0x40")]
    private StringBuilder builder;

    [Token(Token = "0x600DFAB")]
    [Address(RVA = "0x201E36C", Offset = "0x201E36C", VA = "0x201E36C")]
    public AttackScoreFactory(AIConstParam attack)
    {
    }

    [Token(Token = "0x600DFAC")]
    [Address(RVA = "0x201E4EC", Offset = "0x201E4EC", VA = "0x201E4EC")]
    public Battle.Score.Score Create(
      BoardData board,
      UnitParameterData attacker,
      WeaponParameterData weapon,
      UnitParameterData defender,
      GridData defenderGrid,
      SkillParameterData skill)
    {
      return (Battle.Score.Score) null;
    }

    [Token(Token = "0x600DFAD")]
    [Address(RVA = "0x201E91C", Offset = "0x201E91C", VA = "0x201E91C")]
    private (int, int) CalcDamageScore(
      BoardData board,
      UnitParameterData attacker,
      WeaponParameterData weapon,
      UnitParameterData defender,
      GridData defenderGrid,
      SkillParameterData skill)
    {
      return ();
    }

    [Token(Token = "0x600DFAE")]
    [Address(RVA = "0x201F3EC", Offset = "0x201F3EC", VA = "0x201F3EC")]
    private Decimal CalcDamageValue(
      UnitParameterData attacker,
      WeaponParameterData weapon,
      UnitParameterData defender,
      IDamageEffect damage)
    {
      return 0M;
    }

    [Token(Token = "0x600DFAF")]
    [Address(RVA = "0x201F9F8", Offset = "0x201F9F8", VA = "0x201F9F8")]
    private IBattleParameter GetBattleParam(UnitParameterData unit, WeaponParameterData weapon = null)
    {
      return (IBattleParameter) null;
    }

    [Token(Token = "0x600DFB0")]
    [Address(RVA = "0x201FC30", Offset = "0x201FC30", VA = "0x201FC30")]
    private string Log(
      UnitParameterData attacker,
      WeaponParameterData weapon,
      UnitParameterData defender,
      GridData defenderGrid,
      SkillParameterData skill,
      int result)
    {
      return (string) null;
    }

    [Token(Token = "0x600DFB1")]
    [Address(RVA = "0x202063C", Offset = "0x202063C", VA = "0x202063C")]
    private void LogByFixed(IDamageEffect damage)
    {
    }

    [Token(Token = "0x600DFB2")]
    [Address(RVA = "0x2020754", Offset = "0x2020754", VA = "0x2020754")]
    private void LogByRatio(UnitParameterData defender, IDamageEffect damage)
    {
    }

    [Token(Token = "0x600DFB3")]
    [Address(RVA = "0x20209D4", Offset = "0x20209D4", VA = "0x20209D4")]
    private void LogByVariable(
      UnitParameterData attacker,
      WeaponParameterData weapon,
      UnitParameterData defender,
      IDamageEffect damage,
      WeaponAttackTypeEnum weaponAttackType)
    {
    }

    [Token(Token = "0x600DFB4")]
    [Address(RVA = "0x201EF20", Offset = "0x201EF20", VA = "0x201EF20")]
    private void SetRank(AttackScoreFactory.CreatedScore score)
    {
    }

    [Token(Token = "0x600DFB5")]
    [Address(RVA = "0x2020EDC", Offset = "0x2020EDC", VA = "0x2020EDC")]
    public void Clear()
    {
    }

    [Token(Token = "0x2002479")]
    private class AttackScore : Battle.Score.Score
    {
      [Token(Token = "0x17002FFA")]
      public int Result
      {
        [Token(Token = "0x600DFB6"), Address(RVA = "0x2020F84", Offset = "0x2020F84", VA = "0x2020F84")] get
        {
          return new int();
        }
        [Token(Token = "0x600DFB7"), Address(RVA = "0x2020F8C", Offset = "0x2020F8C", VA = "0x2020F8C")] private set
        {
        }
      }

      [Token(Token = "0x600DFB8")]
      [Address(RVA = "0x201EE90", Offset = "0x201EE90", VA = "0x201EE90")]
      public AttackScore(ScoreTypeEnum scoreType, int result, int value, string log = "")
      {
      }
    }

    [Token(Token = "0x200247A")]
    private class CreatedScore
    {
      [Token(Token = "0x17002FFB")]
      public UnitParameterData Attacker
      {
        [Token(Token = "0x600DFB9"), Address(RVA = "0x2020F94", Offset = "0x2020F94", VA = "0x2020F94")] get
        {
          return (UnitParameterData) null;
        }
      }

      [Token(Token = "0x17002FFC")]
      public WeaponParameterData Weapon
      {
        [Token(Token = "0x600DFBA"), Address(RVA = "0x2020F9C", Offset = "0x2020F9C", VA = "0x2020F9C")] get
        {
          return (WeaponParameterData) null;
        }
      }

      [Token(Token = "0x17002FFD")]
      public UnitParameterData Defender
      {
        [Token(Token = "0x600DFBB"), Address(RVA = "0x2020FA4", Offset = "0x2020FA4", VA = "0x2020FA4")] get
        {
          return (UnitParameterData) null;
        }
      }

      [Token(Token = "0x17002FFE")]
      public GridData DefenderGrid
      {
        [Token(Token = "0x600DFBC"), Address(RVA = "0x2020FAC", Offset = "0x2020FAC", VA = "0x2020FAC")] get
        {
          return (GridData) null;
        }
      }

      [Token(Token = "0x17002FFF")]
      public SkillParameterData Skill
      {
        [Token(Token = "0x600DFBD"), Address(RVA = "0x2020FB4", Offset = "0x2020FB4", VA = "0x2020FB4")] get
        {
          return (SkillParameterData) null;
        }
      }

      [Token(Token = "0x17003000")]
      public AttackScoreFactory.AttackScore Score
      {
        [Token(Token = "0x600DFBE"), Address(RVA = "0x2020FBC", Offset = "0x2020FBC", VA = "0x2020FBC")] get
        {
          return (AttackScoreFactory.AttackScore) null;
        }
      }

      [Token(Token = "0x600DFBF")]
      [Address(RVA = "0x201EECC", Offset = "0x201EECC", VA = "0x201EECC")]
      public CreatedScore(
        UnitParameterData attacker,
        WeaponParameterData weapon,
        UnitParameterData defender,
        GridData defenderGrid,
        SkillParameterData skill,
        AttackScoreFactory.AttackScore score)
      {
      }
    }
  }
}
