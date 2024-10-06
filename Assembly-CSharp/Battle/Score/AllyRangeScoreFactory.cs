// Decompiled with JetBrains decompiler
// Type: Battle.Score.AllyRangeScoreFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x2002474")]
  public class AllyRangeScoreFactory
  {
    [Token(Token = "0x4009C5B")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<(int x, int y), AllyRangeScoreFactory.CreatedScore> createdScores;
    [Token(Token = "0x4009C5C")]
    [FieldOffset(Offset = "0x18")]
    private StringBuilder builder;
    [Token(Token = "0x4009C5D")]
    private const int EffectableScore = 5;

    [Token(Token = "0x600DF8F")]
    [Address(RVA = "0x201C3D8", Offset = "0x201C3D8", VA = "0x201C3D8")]
    public Battle.Score.Score Create(
      in BoardData board,
      UnitParameterData actionUnit,
      GridData moveTo,
      AttackableAreaSearcher healableSearcher)
    {
      return (Battle.Score.Score) null;
    }

    [Token(Token = "0x600DF90")]
    [Address(RVA = "0x201D0A8", Offset = "0x201D0A8", VA = "0x201D0A8")]
    public void Clear()
    {
    }

    [Token(Token = "0x600DF91")]
    [Address(RVA = "0x201D0F8", Offset = "0x201D0F8", VA = "0x201D0F8")]
    private string Log((int x, int y) to, int EffectableCount, int score) => (string) null;

    [Token(Token = "0x600DF92")]
    [Address(RVA = "0x201CF50", Offset = "0x201CF50", VA = "0x201CF50")]
    private AllyRangeScoreFactory.CreatedScore GetCreatedScore(int x, int y)
    {
      return (AllyRangeScoreFactory.CreatedScore) null;
    }

    [Token(Token = "0x600DF93")]
    [Address(RVA = "0x201D298", Offset = "0x201D298", VA = "0x201D298")]
    public AllyRangeScoreFactory()
    {
    }

    [Token(Token = "0x2002475")]
    private class CreatedScore
    {
      [Token(Token = "0x17002FF2")]
      public (int x, int y) To
      {
        [Token(Token = "0x600DF94"), Address(RVA = "0x201D344", Offset = "0x201D344", VA = "0x201D344")] get
        {
          return ();
        }
        [Token(Token = "0x600DF95"), Address(RVA = "0x201D34C", Offset = "0x201D34C", VA = "0x201D34C")] private set
        {
        }
      }

      [Token(Token = "0x17002FF3")]
      public Battle.Score.Score Score
      {
        [Token(Token = "0x600DF96"), Address(RVA = "0x201D354", Offset = "0x201D354", VA = "0x201D354")] get
        {
          return (Battle.Score.Score) null;
        }
        [Token(Token = "0x600DF97"), Address(RVA = "0x201D35C", Offset = "0x201D35C", VA = "0x201D35C")] private set
        {
        }
      }

      [Token(Token = "0x600DF98")]
      [Address(RVA = "0x201D000", Offset = "0x201D000", VA = "0x201D000")]
      public CreatedScore(GridData to, Battle.Score.Score score)
      {
      }
    }
  }
}
