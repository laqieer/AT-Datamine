// Decompiled with JetBrains decompiler
// Type: Battle.Score.HPScoreFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x200248A")]
  public class HPScoreFactory
  {
    [Token(Token = "0x4009CB8")]
    [FieldOffset(Offset = "0x18")]
    private List<HPScoreFactory.CreatedScore> createdScores;
    [Token(Token = "0x4009CB9")]
    [FieldOffset(Offset = "0x20")]
    private int maxDistanceScore;
    [Token(Token = "0x4009CBA")]
    [FieldOffset(Offset = "0x24")]
    private int attenuation;
    [Token(Token = "0x4009CBB")]
    [FieldOffset(Offset = "0x28")]
    private int minDistanceScore;
    [Token(Token = "0x4009CBC")]
    [FieldOffset(Offset = "0x30")]
    private StringBuilder builder;

    [Token(Token = "0x17003021")]
    public bool IsDescending
    {
      [Token(Token = "0x600E02F"), Address(RVA = "0x2026F80", Offset = "0x2026F80", VA = "0x2026F80")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E030"), Address(RVA = "0x2026F88", Offset = "0x2026F88", VA = "0x2026F88")] protected set
      {
      }
    }

    [Token(Token = "0x600E031")]
    [Address(RVA = "0x2026F94", Offset = "0x2026F94", VA = "0x2026F94")]
    public HPScoreFactory(bool isDescending)
    {
    }

    [Token(Token = "0x600E032")]
    [Address(RVA = "0x2027068", Offset = "0x2027068", VA = "0x2027068")]
    public Battle.Score.Score Create(UnitParameterData mainTarget) => (Battle.Score.Score) null;

    [Token(Token = "0x600E033")]
    [Address(RVA = "0x2027594", Offset = "0x2027594", VA = "0x2027594")]
    public void Clear()
    {
    }

    [Token(Token = "0x600E034")]
    [Address(RVA = "0x2027380", Offset = "0x2027380", VA = "0x2027380")]
    protected void ReCalc()
    {
    }

    [Token(Token = "0x600E035")]
    [Address(RVA = "0x2027604", Offset = "0x2027604", VA = "0x2027604")]
    private int CalcScoreValue(int rank) => new int();

    [Token(Token = "0x600E036")]
    [Address(RVA = "0x20271E0", Offset = "0x20271E0", VA = "0x20271E0")]
    private HPScoreFactory.CreatedScore GetCreatedScore(int unitParamId)
    {
      return (HPScoreFactory.CreatedScore) null;
    }

    [Token(Token = "0x600E037")]
    [Address(RVA = "0x2027674", Offset = "0x2027674", VA = "0x2027674")]
    private string Log(int targetId, int hp, int score) => (string) null;

    [Token(Token = "0x600E038")]
    [Address(RVA = "0x20277B8", Offset = "0x20277B8", VA = "0x20277B8")]
    private int Sort(HPScoreFactory.CreatedScore a, HPScoreFactory.CreatedScore b) => new int();

    [Token(Token = "0x200248B")]
    private class CreatedScore
    {
      [Token(Token = "0x17003022")]
      public int UnitParamId
      {
        [Token(Token = "0x600E039"), Address(RVA = "0x20277FC", Offset = "0x20277FC", VA = "0x20277FC")] get
        {
          return new int();
        }
        [Token(Token = "0x600E03A"), Address(RVA = "0x2027804", Offset = "0x2027804", VA = "0x2027804")] private set
        {
        }
      }

      [Token(Token = "0x17003023")]
      public int HPPercentage
      {
        [Token(Token = "0x600E03B"), Address(RVA = "0x202780C", Offset = "0x202780C", VA = "0x202780C")] get
        {
          return new int();
        }
        [Token(Token = "0x600E03C"), Address(RVA = "0x2027814", Offset = "0x2027814", VA = "0x2027814")] private set
        {
        }
      }

      [Token(Token = "0x17003024")]
      public Battle.Score.Score Score
      {
        [Token(Token = "0x600E03D"), Address(RVA = "0x202781C", Offset = "0x202781C", VA = "0x202781C")] get
        {
          return (Battle.Score.Score) null;
        }
        [Token(Token = "0x600E03E"), Address(RVA = "0x2027824", Offset = "0x2027824", VA = "0x2027824")] private set
        {
        }
      }

      [Token(Token = "0x600E03F")]
      [Address(RVA = "0x2027344", Offset = "0x2027344", VA = "0x2027344")]
      public CreatedScore(int unitParamId, int hpPercentage, Battle.Score.Score score)
      {
      }
    }
  }
}
