// Decompiled with JetBrains decompiler
// Type: Battle.Score.HealPowerScoreFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x2002485")]
  public class HealPowerScoreFactory
  {
    [Token(Token = "0x4009CA5")]
    [FieldOffset(Offset = "0x10")]
    private List<HealPowerScoreFactory.CreatedScore> createdScores;
    [Token(Token = "0x4009CA6")]
    [FieldOffset(Offset = "0x18")]
    private List<(int result, List<HealPowerScoreFactory.CreatedScore> list)> rank;
    [Token(Token = "0x4009CA7")]
    private const int rankSize = 5;
    [Token(Token = "0x4009CA8")]
    [FieldOffset(Offset = "0x20")]
    private AIConstParam healPowerConst;
    [Token(Token = "0x4009CA9")]
    [FieldOffset(Offset = "0x30")]
    private BattleLogicConstData constData;
    [Token(Token = "0x4009CAA")]
    [FieldOffset(Offset = "0x38")]
    private StringBuilder builder;

    [Token(Token = "0x600E00E")]
    [Address(RVA = "0x202477C", Offset = "0x202477C", VA = "0x202477C")]
    public HealPowerScoreFactory(AIConstParam healPower, BattleLogicConstData constData)
    {
    }

    [Token(Token = "0x600E00F")]
    [Address(RVA = "0x2024898", Offset = "0x2024898", VA = "0x2024898")]
    public Battle.Score.Score Create(
      UnitParameterData activator,
      WeaponParameterData weapon,
      UnitParameterData target,
      SkillParameterData skill)
    {
      return (Battle.Score.Score) null;
    }

    [Token(Token = "0x600E010")]
    [Address(RVA = "0x2024C20", Offset = "0x2024C20", VA = "0x2024C20")]
    private int CalcScore(
      UnitParameterData activator,
      WeaponParameterData weapon,
      UnitParameterData target,
      SkillParameterData skill)
    {
      return new int();
    }

    [Token(Token = "0x600E011")]
    [Address(RVA = "0x202548C", Offset = "0x202548C", VA = "0x202548C")]
    private Decimal CalcHealValue(
      UnitParameterData activator,
      WeaponParameterData weapon,
      UnitParameterData target,
      HealEffectData effect)
    {
      return 0M;
    }

    [Token(Token = "0x600E012")]
    [Address(RVA = "0x2025848", Offset = "0x2025848", VA = "0x2025848")]
    private string Log(
      UnitParameterData activator,
      WeaponParameterData weapon,
      UnitParameterData target,
      SkillParameterData skill,
      int result)
    {
      return (string) null;
    }

    [Token(Token = "0x600E013")]
    [Address(RVA = "0x2026010", Offset = "0x2026010", VA = "0x2026010")]
    private void LogByFixed(HealEffectData heal)
    {
    }

    [Token(Token = "0x600E014")]
    [Address(RVA = "0x20260B8", Offset = "0x20260B8", VA = "0x20260B8")]
    private void LogByRatio(UnitParameterData target, HealEffectData heal)
    {
    }

    [Token(Token = "0x600E015")]
    [Address(RVA = "0x2026268", Offset = "0x2026268", VA = "0x2026268")]
    private void LogByBariable(
      UnitParameterData activator,
      WeaponParameterData weapon,
      HealEffectData heal)
    {
    }

    [Token(Token = "0x600E016")]
    [Address(RVA = "0x2024FC4", Offset = "0x2024FC4", VA = "0x2024FC4")]
    private void SetRank(HealPowerScoreFactory.CreatedScore score)
    {
    }

    [Token(Token = "0x600E017")]
    [Address(RVA = "0x2026620", Offset = "0x2026620", VA = "0x2026620")]
    public void Clear()
    {
    }

    [Token(Token = "0x2002486")]
    private class HealPowerScore : Battle.Score.Score
    {
      [Token(Token = "0x17003018")]
      public int Result
      {
        [Token(Token = "0x600E018"), Address(RVA = "0x20266C8", Offset = "0x20266C8", VA = "0x20266C8")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x600E019")]
      [Address(RVA = "0x2024F34", Offset = "0x2024F34", VA = "0x2024F34")]
      public HealPowerScore(ScoreTypeEnum scoreType, int result, int value, string log = "")
      {
      }
    }

    [Token(Token = "0x2002487")]
    private class CreatedScore
    {
      [Token(Token = "0x17003019")]
      public int ActivatorId
      {
        [Token(Token = "0x600E01A"), Address(RVA = "0x20266D0", Offset = "0x20266D0", VA = "0x20266D0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x1700301A")]
      public string WeaponId
      {
        [Token(Token = "0x600E01B"), Address(RVA = "0x20266D8", Offset = "0x20266D8", VA = "0x20266D8")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700301B")]
      public int TargetId
      {
        [Token(Token = "0x600E01C"), Address(RVA = "0x20266E0", Offset = "0x20266E0", VA = "0x20266E0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x1700301C")]
      public int SkillId
      {
        [Token(Token = "0x600E01D"), Address(RVA = "0x20266E8", Offset = "0x20266E8", VA = "0x20266E8")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x1700301D")]
      public HealPowerScoreFactory.HealPowerScore Score
      {
        [Token(Token = "0x600E01E"), Address(RVA = "0x20266F0", Offset = "0x20266F0", VA = "0x20266F0")] get
        {
          return (HealPowerScoreFactory.HealPowerScore) null;
        }
      }

      [Token(Token = "0x600E01F")]
      [Address(RVA = "0x2024F70", Offset = "0x2024F70", VA = "0x2024F70")]
      public CreatedScore(
        int activatorId,
        string weaponId,
        int targetId,
        int skillId,
        HealPowerScoreFactory.HealPowerScore score)
      {
      }
    }
  }
}
