// Decompiled with JetBrains decompiler
// Type: Battle.Score.AttackPosScoreFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x2002476")]
  public class AttackPosScoreFactory
  {
    [Token(Token = "0x4009C60")]
    private const int MaxPosScore = 10;
    [Token(Token = "0x4009C61")]
    private const int MinPosScore = 1;
    [Token(Token = "0x4009C62")]
    private const int InvolveBonus = 5;
    [Token(Token = "0x4009C63")]
    [FieldOffset(Offset = "0x10")]
    private StringBuilder builder;
    [Token(Token = "0x4009C64")]
    [FieldOffset(Offset = "0x18")]
    private int minRange;
    [Token(Token = "0x4009C65")]
    [FieldOffset(Offset = "0x1C")]
    private int maxRange;
    [Token(Token = "0x4009C66")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<AttackPosScoreFactory.CreatedScoreKey, Battle.Score.Score> createdScores;

    [Token(Token = "0x17002FF4")]
    public Dictionary<AttackPosScoreFactory.CreatedScoreKey, Battle.Score.Score> Created
    {
      [Token(Token = "0x600DF99"), Address(RVA = "0x201D364", Offset = "0x201D364", VA = "0x201D364")] get
      {
        return (Dictionary<AttackPosScoreFactory.CreatedScoreKey, Battle.Score.Score>) null;
      }
    }

    [Token(Token = "0x600DF9A")]
    [Address(RVA = "0x201D36C", Offset = "0x201D36C", VA = "0x201D36C")]
    public void SetRange(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DF9B")]
    [Address(RVA = "0x201D794", Offset = "0x201D794", VA = "0x201D794")]
    public Battle.Score.Score Create(
      BoardData board,
      GridData castFrom,
      UnitParameterData mainTarget,
      CommandScore commandScore)
    {
      return (Battle.Score.Score) null;
    }

    [Token(Token = "0x600DF9C")]
    [Address(RVA = "0x201DF34", Offset = "0x201DF34", VA = "0x201DF34")]
    private int CalcScore(
      AttackPosScoreFactory.CreatedScoreKey key,
      UnitParameterData main,
      List<TargetPair> others)
    {
      return new int();
    }

    [Token(Token = "0x600DF9D")]
    [Address(RVA = "0x201E050", Offset = "0x201E050", VA = "0x201E050")]
    private string Log(AttackPosScoreFactory.CreatedScoreKey key, int score) => (string) null;

    [Token(Token = "0x600DF9E")]
    [Address(RVA = "0x201E208", Offset = "0x201E208", VA = "0x201E208")]
    public void Clear()
    {
    }

    [Token(Token = "0x600DF9F")]
    [Address(RVA = "0x201E268", Offset = "0x201E268", VA = "0x201E268")]
    public AttackPosScoreFactory()
    {
    }

    [Token(Token = "0x2002477")]
    public struct CreatedScoreKey
    {
      [Token(Token = "0x17002FF5")]
      public (int x, int y) From
      {
        [Token(Token = "0x600DFA0"), Address(RVA = "0x201E31C", Offset = "0x201E31C", VA = "0x201E31C")] readonly get
        {
          return ();
        }
        [Token(Token = "0x600DFA1"), Address(RVA = "0x201E324", Offset = "0x201E324", VA = "0x201E324")] private set
        {
        }
      }

      [Token(Token = "0x17002FF6")]
      public (int x, int y) To
      {
        [Token(Token = "0x600DFA2"), Address(RVA = "0x201E32C", Offset = "0x201E32C", VA = "0x201E32C")] readonly get
        {
          return ();
        }
        [Token(Token = "0x600DFA3"), Address(RVA = "0x201E334", Offset = "0x201E334", VA = "0x201E334")] private set
        {
        }
      }

      [Token(Token = "0x17002FF7")]
      public RangeData FiringRange
      {
        [Token(Token = "0x600DFA4"), Address(RVA = "0x201E33C", Offset = "0x201E33C", VA = "0x201E33C")] readonly get
        {
          return (RangeData) null;
        }
        [Token(Token = "0x600DFA5"), Address(RVA = "0x201E344", Offset = "0x201E344", VA = "0x201E344")] private set
        {
        }
      }

      [Token(Token = "0x17002FF8")]
      public IBasicRangeData EffectiveRange
      {
        [Token(Token = "0x600DFA6"), Address(RVA = "0x201E34C", Offset = "0x201E34C", VA = "0x201E34C")] readonly get
        {
          return (IBasicRangeData) null;
        }
        [Token(Token = "0x600DFA7"), Address(RVA = "0x201E354", Offset = "0x201E354", VA = "0x201E354")] private set
        {
        }
      }

      [Token(Token = "0x17002FF9")]
      public int InvolveCount
      {
        [Token(Token = "0x600DFA8"), Address(RVA = "0x201E35C", Offset = "0x201E35C", VA = "0x201E35C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x600DFA9"), Address(RVA = "0x201E364", Offset = "0x201E364", VA = "0x201E364")] private set
        {
        }
      }

      [Token(Token = "0x600DFAA")]
      [Address(RVA = "0x201DE1C", Offset = "0x201DE1C", VA = "0x201DE1C")]
      public CreatedScoreKey(
        GridData from,
        GridData to,
        SkillParameterData skill,
        int involveCount)
      {
      }
    }
  }
}
