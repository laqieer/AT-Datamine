// Decompiled with JetBrains decompiler
// Type: Battle.Score.LandformScoreFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x200248C")]
  public class LandformScoreFactory
  {
    [Token(Token = "0x4009CC0")]
    [FieldOffset(Offset = "0x10")]
    private StringBuilder builder;
    [Token(Token = "0x4009CC1")]
    [FieldOffset(Offset = "0x18")]
    private List<LandformScoreFactory.CreatedScore> createdScores;

    [Token(Token = "0x600E040")]
    [Address(RVA = "0x202782C", Offset = "0x202782C", VA = "0x202782C")]
    public Battle.Score.Score Create(UnitParameterData unit, GridData grid) => (Battle.Score.Score) null;

    [Token(Token = "0x600E041")]
    [Address(RVA = "0x2027B28", Offset = "0x2027B28", VA = "0x2027B28")]
    private int CalcScore(MoveData moveData, LandformTypeEnum landform) => new int();

    [Token(Token = "0x600E042")]
    [Address(RVA = "0x2027EC0", Offset = "0x2027EC0", VA = "0x2027EC0")]
    private string Log(MoveData moveData, LandformTypeEnum landform, int score) => (string) null;

    [Token(Token = "0x600E043")]
    [Address(RVA = "0x2028040", Offset = "0x2028040", VA = "0x2028040")]
    public LandformScoreFactory()
    {
    }

    [Token(Token = "0x200248D")]
    private class CreatedScore
    {
      [Token(Token = "0x17003025")]
      public MoveData MoveData
      {
        [Token(Token = "0x600E044"), Address(RVA = "0x20280EC", Offset = "0x20280EC", VA = "0x20280EC")] get
        {
          return (MoveData) null;
        }
        [Token(Token = "0x600E045"), Address(RVA = "0x20280F4", Offset = "0x20280F4", VA = "0x20280F4")] private set
        {
        }
      }

      [Token(Token = "0x17003026")]
      public bool IsLargeUnit
      {
        [Token(Token = "0x600E046"), Address(RVA = "0x20280FC", Offset = "0x20280FC", VA = "0x20280FC")] get
        {
          return new bool();
        }
        [Token(Token = "0x600E047"), Address(RVA = "0x2028104", Offset = "0x2028104", VA = "0x2028104")] private set
        {
        }
      }

      [Token(Token = "0x17003027")]
      public Battle.Score.Score Score
      {
        [Token(Token = "0x600E048"), Address(RVA = "0x2028110", Offset = "0x2028110", VA = "0x2028110")] get
        {
          return (Battle.Score.Score) null;
        }
        [Token(Token = "0x600E049"), Address(RVA = "0x2028118", Offset = "0x2028118", VA = "0x2028118")] private set
        {
        }
      }

      [Token(Token = "0x600E04A")]
      [Address(RVA = "0x2027E7C", Offset = "0x2027E7C", VA = "0x2027E7C")]
      public CreatedScore(MoveData moveData, bool isLargeUnit, Battle.Score.Score score)
      {
      }
    }
  }
}
