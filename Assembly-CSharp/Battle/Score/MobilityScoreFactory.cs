// Decompiled with JetBrains decompiler
// Type: Battle.Score.MobilityScoreFactory
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
  [Token(Token = "0x200248E")]
  public class MobilityScoreFactory
  {
    [Token(Token = "0x4009CC5")]
    [FieldOffset(Offset = "0x10")]
    private List<MobilityScoreFactory.CreatedScore> createdScores;
    [Token(Token = "0x4009CC6")]
    [FieldOffset(Offset = "0x18")]
    private AIConstParam mobility;
    [Token(Token = "0x4009CC7")]
    [FieldOffset(Offset = "0x24")]
    private int maxDistance;
    [Token(Token = "0x4009CC8")]
    [FieldOffset(Offset = "0x28")]
    private StringBuilder builder;

    [Token(Token = "0x17003028")]
    public int MaxDistance
    {
      [Token(Token = "0x600E04B"), Address(RVA = "0x2028120", Offset = "0x2028120", VA = "0x2028120")] get
      {
        return new int();
      }
      [Token(Token = "0x600E04C"), Address(RVA = "0x2028128", Offset = "0x2028128", VA = "0x2028128")] set
      {
      }
    }

    [Token(Token = "0x600E04D")]
    [Address(RVA = "0x2028324", Offset = "0x2028324", VA = "0x2028324")]
    public MobilityScoreFactory(AIConstParam mobility)
    {
    }

    [Token(Token = "0x600E04E")]
    [Address(RVA = "0x20283EC", Offset = "0x20283EC", VA = "0x20283EC")]
    public Battle.Score.Score Create(GridData from, GridData to) => (Battle.Score.Score) null;

    [Token(Token = "0x600E04F")]
    [Address(RVA = "0x2028A38", Offset = "0x2028A38", VA = "0x2028A38")]
    public void Clear()
    {
    }

    [Token(Token = "0x600E050")]
    [Address(RVA = "0x2028260", Offset = "0x2028260", VA = "0x2028260")]
    private void ReCalc(MobilityScoreFactory.CreatedScore createdScore)
    {
    }

    [Token(Token = "0x600E051")]
    [Address(RVA = "0x2028660", Offset = "0x2028660", VA = "0x2028660")]
    private int CalcScoreValue(int distance) => new int();

    [Token(Token = "0x600E052")]
    [Address(RVA = "0x20286E4", Offset = "0x20286E4", VA = "0x20286E4")]
    private string Log((int x, int y) from, (int x, int y) to, int distance, int score)
    {
      return (string) null;
    }

    [Token(Token = "0x200248F")]
    private class CreatedScore
    {
      [Token(Token = "0x17003029")]
      public (int x, int y) From
      {
        [Token(Token = "0x600E053"), Address(RVA = "0x2028AA8", Offset = "0x2028AA8", VA = "0x2028AA8")] get
        {
          return ();
        }
        [Token(Token = "0x600E054"), Address(RVA = "0x2028AB0", Offset = "0x2028AB0", VA = "0x2028AB0")] private set
        {
        }
      }

      [Token(Token = "0x1700302A")]
      public (int x, int y) To
      {
        [Token(Token = "0x600E055"), Address(RVA = "0x2028AB8", Offset = "0x2028AB8", VA = "0x2028AB8")] get
        {
          return ();
        }
        [Token(Token = "0x600E056"), Address(RVA = "0x2028AC0", Offset = "0x2028AC0", VA = "0x2028AC0")] private set
        {
        }
      }

      [Token(Token = "0x1700302B")]
      public Battle.Score.Score Score
      {
        [Token(Token = "0x600E057"), Address(RVA = "0x2028AC8", Offset = "0x2028AC8", VA = "0x2028AC8")] get
        {
          return (Battle.Score.Score) null;
        }
        [Token(Token = "0x600E058"), Address(RVA = "0x2028AD0", Offset = "0x2028AD0", VA = "0x2028AD0")] private set
        {
        }
      }

      [Token(Token = "0x600E059")]
      [Address(RVA = "0x2028948", Offset = "0x2028948", VA = "0x2028948")]
      public CreatedScore(GridData from, GridData to, Battle.Score.Score score)
      {
      }
    }
  }
}
