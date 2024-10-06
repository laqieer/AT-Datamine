// Decompiled with JetBrains decompiler
// Type: Battle.Score.HealScoreFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x2002488")]
  public class HealScoreFactory
  {
    [Token(Token = "0x4009CB1")]
    [FieldOffset(Offset = "0x10")]
    private List<HealScoreFactory.CreatedScore> createdScores;
    [Token(Token = "0x4009CB2")]
    [FieldOffset(Offset = "0x18")]
    private AIConstParam heal;
    [Token(Token = "0x4009CB3")]
    [FieldOffset(Offset = "0x28")]
    private StringBuilder builder;

    [Token(Token = "0x600E020")]
    [Address(RVA = "0x20266F8", Offset = "0x20266F8", VA = "0x20266F8")]
    public HealScoreFactory(AIConstParam heal)
    {
    }

    [Token(Token = "0x600E021")]
    [Address(RVA = "0x20267C0", Offset = "0x20267C0", VA = "0x20267C0")]
    public Battle.Score.Score Create(int targetUnitParamId, int currentHPRate) => (Battle.Score.Score) null;

    [Token(Token = "0x600E022")]
    [Address(RVA = "0x2026CCC", Offset = "0x2026CCC", VA = "0x2026CCC")]
    public void Clear()
    {
    }

    [Token(Token = "0x600E023")]
    [Address(RVA = "0x2026AA8", Offset = "0x2026AA8", VA = "0x2026AA8")]
    private void ReCalc()
    {
    }

    [Token(Token = "0x600E024")]
    [Address(RVA = "0x2026D3C", Offset = "0x2026D3C", VA = "0x2026D3C")]
    private int CalcScoreValue(int rank) => new int();

    [Token(Token = "0x600E025")]
    [Address(RVA = "0x2026908", Offset = "0x2026908", VA = "0x2026908")]
    private HealScoreFactory.CreatedScore GetCreatedScore(int targetUnitParamId)
    {
      return (HealScoreFactory.CreatedScore) null;
    }

    [Token(Token = "0x600E026")]
    [Address(RVA = "0x2026DAC", Offset = "0x2026DAC", VA = "0x2026DAC")]
    private string Log(int rank, int currentHPRate, int score) => (string) null;

    [Token(Token = "0x600E027")]
    [Address(RVA = "0x2026F2C", Offset = "0x2026F2C", VA = "0x2026F2C")]
    private int Sort(HealScoreFactory.CreatedScore a, HealScoreFactory.CreatedScore b) => new int();

    [Token(Token = "0x2002489")]
    private class CreatedScore
    {
      [Token(Token = "0x1700301E")]
      public int TargetUnitParamId
      {
        [Token(Token = "0x600E028"), Address(RVA = "0x2026F50", Offset = "0x2026F50", VA = "0x2026F50")] get
        {
          return new int();
        }
        [Token(Token = "0x600E029"), Address(RVA = "0x2026F58", Offset = "0x2026F58", VA = "0x2026F58")] private set
        {
        }
      }

      [Token(Token = "0x1700301F")]
      public int CurrentHPRate
      {
        [Token(Token = "0x600E02A"), Address(RVA = "0x2026F60", Offset = "0x2026F60", VA = "0x2026F60")] get
        {
          return new int();
        }
        [Token(Token = "0x600E02B"), Address(RVA = "0x2026F68", Offset = "0x2026F68", VA = "0x2026F68")] private set
        {
        }
      }

      [Token(Token = "0x17003020")]
      public Battle.Score.Score Score
      {
        [Token(Token = "0x600E02C"), Address(RVA = "0x2026F70", Offset = "0x2026F70", VA = "0x2026F70")] get
        {
          return (Battle.Score.Score) null;
        }
        [Token(Token = "0x600E02D"), Address(RVA = "0x2026F78", Offset = "0x2026F78", VA = "0x2026F78")] private set
        {
        }
      }

      [Token(Token = "0x600E02E")]
      [Address(RVA = "0x2026A6C", Offset = "0x2026A6C", VA = "0x2026A6C")]
      public CreatedScore(int targetUnitParamId, int currentHPRate, Battle.Score.Score score)
      {
      }
    }
  }
}
