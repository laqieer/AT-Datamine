// Decompiled with JetBrains decompiler
// Type: Battle.Score.AllyDistanceScoreFactory
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
  [Token(Token = "0x2002472")]
  public class AllyDistanceScoreFactory
  {
    [Token(Token = "0x4009C55")]
    [FieldOffset(Offset = "0x10")]
    private ShortestPathSearcher shortest;
    [Token(Token = "0x4009C56")]
    [FieldOffset(Offset = "0x18")]
    private AIConstParam target;
    [Token(Token = "0x4009C57")]
    [FieldOffset(Offset = "0x28")]
    private HashSet<(int x, int y)> targetsPos;
    [Token(Token = "0x4009C58")]
    [FieldOffset(Offset = "0x30")]
    private StringBuilder builder;

    [Token(Token = "0x600DF86")]
    [Address(RVA = "0x201B044", Offset = "0x201B044", VA = "0x201B044")]
    public AllyDistanceScoreFactory(AIConstParam target)
    {
    }

    [Token(Token = "0x600DF87")]
    [Address(RVA = "0x201B10C", Offset = "0x201B10C", VA = "0x201B10C")]
    public void Clear()
    {
    }

    [Token(Token = "0x600DF88")]
    [Address(RVA = "0x201B17C", Offset = "0x201B17C", VA = "0x201B17C")]
    private int CalcScoreValue(int x, int y, AIConstParam baseScoreParam) => new int();

    [Token(Token = "0x600DF89")]
    [Address(RVA = "0x201B254", Offset = "0x201B254", VA = "0x201B254")]
    private PathSearcher2D.NodeValidationCallback GetValidator(
      BoardData board,
      UnitParameterData unit)
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }

    [Token(Token = "0x600DF8A")]
    [Address(RVA = "0x201B314", Offset = "0x201B314", VA = "0x201B314")]
    public void Setnfo(BoardData board, UnitParameterData actionUnit)
    {
    }

    [Token(Token = "0x600DF8B")]
    [Address(RVA = "0x201B908", Offset = "0x201B908", VA = "0x201B908")]
    private string Log((int x, int y)? moveTo, (int x, int y)? nearestGoal, int score)
    {
      return (string) null;
    }

    [Token(Token = "0x600DF8C")]
    [Address(RVA = "0x201BB40", Offset = "0x201BB40", VA = "0x201BB40")]
    public Battle.Score.Score Create(
      ScoreTypeEnum scoreType,
      in BoardData board,
      UnitParameterData unit,
      GridData grid,
      bool considerWarp)
    {
      return (Battle.Score.Score) null;
    }
  }
}
