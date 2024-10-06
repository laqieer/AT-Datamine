// Decompiled with JetBrains decompiler
// Type: Battle.Score.OpponentCombatPowerScoreFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x2002490")]
  public class OpponentCombatPowerScoreFactory
  {
    [Token(Token = "0x4009CCC")]
    [FieldOffset(Offset = "0x10")]
    private List<OpponentCombatPowerScoreFactory.CreatedScore> createdScores;
    [Token(Token = "0x4009CCD")]
    [FieldOffset(Offset = "0x18")]
    private AIConstParam combatPower;
    [Token(Token = "0x4009CCE")]
    [FieldOffset(Offset = "0x28")]
    private StringBuilder builder;

    [Token(Token = "0x600E05A")]
    [Address(RVA = "0x2028AD8", Offset = "0x2028AD8", VA = "0x2028AD8")]
    public OpponentCombatPowerScoreFactory(AIConstParam combatPower)
    {
    }

    [Token(Token = "0x600E05B")]
    [Address(RVA = "0x2028BA0", Offset = "0x2028BA0", VA = "0x2028BA0")]
    public Battle.Score.Score Create(int unitParamId, int combatPower) => (Battle.Score.Score) null;

    [Token(Token = "0x600E05C")]
    [Address(RVA = "0x20290AC", Offset = "0x20290AC", VA = "0x20290AC")]
    public void Clear()
    {
    }

    [Token(Token = "0x600E05D")]
    [Address(RVA = "0x2028E88", Offset = "0x2028E88", VA = "0x2028E88")]
    private void ReCalc()
    {
    }

    [Token(Token = "0x600E05E")]
    [Address(RVA = "0x202911C", Offset = "0x202911C", VA = "0x202911C")]
    private int CalcScoreValue(int rank) => new int();

    [Token(Token = "0x600E05F")]
    [Address(RVA = "0x2028CE8", Offset = "0x2028CE8", VA = "0x2028CE8")]
    private OpponentCombatPowerScoreFactory.CreatedScore GetCreatedScore(int unitParamId)
    {
      return (OpponentCombatPowerScoreFactory.CreatedScore) null;
    }

    [Token(Token = "0x600E060")]
    [Address(RVA = "0x202918C", Offset = "0x202918C", VA = "0x202918C")]
    private string Log(int rank, int combatPower, int score) => (string) null;

    [Token(Token = "0x600E061")]
    [Address(RVA = "0x202930C", Offset = "0x202930C", VA = "0x202930C")]
    private int Sort(
      OpponentCombatPowerScoreFactory.CreatedScore a,
      OpponentCombatPowerScoreFactory.CreatedScore b)
    {
      return new int();
    }

    [Token(Token = "0x2002491")]
    private class CreatedScore
    {
      [Token(Token = "0x1700302C")]
      public int UnitParamId
      {
        [Token(Token = "0x600E062"), Address(RVA = "0x2029330", Offset = "0x2029330", VA = "0x2029330")] get
        {
          return new int();
        }
        [Token(Token = "0x600E063"), Address(RVA = "0x2029338", Offset = "0x2029338", VA = "0x2029338")] private set
        {
        }
      }

      [Token(Token = "0x1700302D")]
      public int CombatPower
      {
        [Token(Token = "0x600E064"), Address(RVA = "0x2029340", Offset = "0x2029340", VA = "0x2029340")] get
        {
          return new int();
        }
        [Token(Token = "0x600E065"), Address(RVA = "0x2029348", Offset = "0x2029348", VA = "0x2029348")] private set
        {
        }
      }

      [Token(Token = "0x1700302E")]
      public Battle.Score.Score Score
      {
        [Token(Token = "0x600E066"), Address(RVA = "0x2029350", Offset = "0x2029350", VA = "0x2029350")] get
        {
          return (Battle.Score.Score) null;
        }
        [Token(Token = "0x600E067"), Address(RVA = "0x2029358", Offset = "0x2029358", VA = "0x2029358")] private set
        {
        }
      }

      [Token(Token = "0x600E068")]
      [Address(RVA = "0x2028E4C", Offset = "0x2028E4C", VA = "0x2028E4C")]
      public CreatedScore(int unitParamId, int combatPower, Battle.Score.Score score)
      {
      }
    }
  }
}
