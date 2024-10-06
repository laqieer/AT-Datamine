// Decompiled with JetBrains decompiler
// Type: Battle.Score.OpponentDistanceScoreFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.RouteSearch;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x2002492")]
  public class OpponentDistanceScoreFactory
  {
    [Token(Token = "0x4009CD3")]
    [FieldOffset(Offset = "0x18")]
    private List<OpponentDistanceScoreFactory.CreatedScore> createdScores;
    [Token(Token = "0x4009CD4")]
    [FieldOffset(Offset = "0x20")]
    private int maxDistanceScore;
    [Token(Token = "0x4009CD5")]
    [FieldOffset(Offset = "0x24")]
    private int attenuation;
    [Token(Token = "0x4009CD6")]
    [FieldOffset(Offset = "0x28")]
    private int minDistanceScore;
    [Token(Token = "0x4009CD7")]
    [FieldOffset(Offset = "0x30")]
    private StringBuilder builder;

    [Token(Token = "0x1700302F")]
    public bool IsDescending
    {
      [Token(Token = "0x600E069"), Address(RVA = "0x2029360", Offset = "0x2029360", VA = "0x2029360")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E06A"), Address(RVA = "0x2029368", Offset = "0x2029368", VA = "0x2029368")] protected set
      {
      }
    }

    [Token(Token = "0x600E06B")]
    [Address(RVA = "0x2029374", Offset = "0x2029374", VA = "0x2029374")]
    public OpponentDistanceScoreFactory(bool isDescending)
    {
    }

    [Token(Token = "0x600E06C")]
    [Address(RVA = "0x2029448", Offset = "0x2029448", VA = "0x2029448")]
    public Battle.Score.Score Create(
      ScoreTypeEnum scoreType,
      in BoardData board,
      UnitParameterData actionUnit,
      UnitParameterData mainTarget,
      TwoPointShortestPathSearcher searcher)
    {
      return (Battle.Score.Score) null;
    }

    [Token(Token = "0x600E06D")]
    [Address(RVA = "0x2029BE8", Offset = "0x2029BE8", VA = "0x2029BE8")]
    public void Clear()
    {
    }

    [Token(Token = "0x600E06E")]
    [Address(RVA = "0x20299C4", Offset = "0x20299C4", VA = "0x20299C4")]
    protected void ReCalc()
    {
    }

    [Token(Token = "0x600E06F")]
    [Address(RVA = "0x2029C58", Offset = "0x2029C58", VA = "0x2029C58")]
    private int CalcScoreValue(int rank) => new int();

    [Token(Token = "0x600E070")]
    [Address(RVA = "0x2029824", Offset = "0x2029824", VA = "0x2029824")]
    private OpponentDistanceScoreFactory.CreatedScore GetCreatedScore(int unitParamId)
    {
      return (OpponentDistanceScoreFactory.CreatedScore) null;
    }

    [Token(Token = "0x600E071")]
    [Address(RVA = "0x2029CC8", Offset = "0x2029CC8", VA = "0x2029CC8")]
    private string Log(int rank, int distance, int score) => (string) null;

    [Token(Token = "0x600E072")]
    [Address(RVA = "0x2029E4C", Offset = "0x2029E4C", VA = "0x2029E4C")]
    private int Sort(
      OpponentDistanceScoreFactory.CreatedScore a,
      OpponentDistanceScoreFactory.CreatedScore b)
    {
      return new int();
    }

    [Token(Token = "0x2002493")]
    private class CreatedScore
    {
      [Token(Token = "0x17003030")]
      public int UnitParamId
      {
        [Token(Token = "0x600E073"), Address(RVA = "0x2029E90", Offset = "0x2029E90", VA = "0x2029E90")] get
        {
          return new int();
        }
        [Token(Token = "0x600E074"), Address(RVA = "0x2029E98", Offset = "0x2029E98", VA = "0x2029E98")] private set
        {
        }
      }

      [Token(Token = "0x17003031")]
      public int Distance
      {
        [Token(Token = "0x600E075"), Address(RVA = "0x2029EA0", Offset = "0x2029EA0", VA = "0x2029EA0")] get
        {
          return new int();
        }
        [Token(Token = "0x600E076"), Address(RVA = "0x2029EA8", Offset = "0x2029EA8", VA = "0x2029EA8")] private set
        {
        }
      }

      [Token(Token = "0x17003032")]
      public Battle.Score.Score Score
      {
        [Token(Token = "0x600E077"), Address(RVA = "0x2029EB0", Offset = "0x2029EB0", VA = "0x2029EB0")] get
        {
          return (Battle.Score.Score) null;
        }
        [Token(Token = "0x600E078"), Address(RVA = "0x2029EB8", Offset = "0x2029EB8", VA = "0x2029EB8")] private set
        {
        }
      }

      [Token(Token = "0x600E079")]
      [Address(RVA = "0x2029988", Offset = "0x2029988", VA = "0x2029988")]
      public CreatedScore(int unitParamId, int way, Battle.Score.Score score)
      {
      }
    }
  }
}
