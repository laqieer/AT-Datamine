// Decompiled with JetBrains decompiler
// Type: Battle.Score.HealableTakeBadStatusScoreFactory
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
  [Token(Token = "0x2002483")]
  public class HealableTakeBadStatusScoreFactory
  {
    [Token(Token = "0x4009C9B")]
    [FieldOffset(Offset = "0x10")]
    private BadStatusPriority priority;
    [Token(Token = "0x4009C9C")]
    [FieldOffset(Offset = "0x18")]
    private List<HealableTakeBadStatusScoreFactory.CreatedScore> createdScores;
    [Token(Token = "0x4009C9D")]
    [FieldOffset(Offset = "0x20")]
    private int maxScore;
    [Token(Token = "0x4009C9E")]
    [FieldOffset(Offset = "0x24")]
    private int attenuation;
    [Token(Token = "0x4009C9F")]
    [FieldOffset(Offset = "0x28")]
    private int minScore;
    [Token(Token = "0x4009CA0")]
    [FieldOffset(Offset = "0x30")]
    private StringBuilder builder;

    [Token(Token = "0x600DFFF")]
    [Address(RVA = "0x2023E3C", Offset = "0x2023E3C", VA = "0x2023E3C")]
    public HealableTakeBadStatusScoreFactory(BadStatusPriority priority)
    {
    }

    [Token(Token = "0x600E000")]
    [Address(RVA = "0x2023F10", Offset = "0x2023F10", VA = "0x2023F10")]
    public void Initialize(BoardData board, int actionUnitId)
    {
    }

    [Token(Token = "0x600E001")]
    [Address(RVA = "0x20244E8", Offset = "0x20244E8", VA = "0x20244E8")]
    public Battle.Score.Score Create(UnitParameterData unit) => (Battle.Score.Score) null;

    [Token(Token = "0x600E002")]
    [Address(RVA = "0x20246CC", Offset = "0x20246CC", VA = "0x20246CC")]
    public void Clear()
    {
    }

    [Token(Token = "0x600E003")]
    [Address(RVA = "0x2024310", Offset = "0x2024310", VA = "0x2024310")]
    private int CalcScore(int rank) => new int();

    [Token(Token = "0x600E004")]
    [Address(RVA = "0x2024380", Offset = "0x2024380", VA = "0x2024380")]
    private string Log(int rank, int priority) => (string) null;

    [Token(Token = "0x2002484")]
    private class CreatedScore
    {
      [Token(Token = "0x17003014")]
      public int UnitParamId
      {
        [Token(Token = "0x600E005"), Address(RVA = "0x202473C", Offset = "0x202473C", VA = "0x202473C")] get
        {
          return new int();
        }
        [Token(Token = "0x600E006"), Address(RVA = "0x2024744", Offset = "0x2024744", VA = "0x2024744")] private set
        {
        }
      }

      [Token(Token = "0x17003015")]
      public BattleBadStatusTypeEnum BadStatus
      {
        [Token(Token = "0x600E007"), Address(RVA = "0x202474C", Offset = "0x202474C", VA = "0x202474C")] get
        {
          return new BattleBadStatusTypeEnum();
        }
        [Token(Token = "0x600E008"), Address(RVA = "0x2024754", Offset = "0x2024754", VA = "0x2024754")] private set
        {
        }
      }

      [Token(Token = "0x17003016")]
      public int Priority
      {
        [Token(Token = "0x600E009"), Address(RVA = "0x202475C", Offset = "0x202475C", VA = "0x202475C")] get
        {
          return new int();
        }
        [Token(Token = "0x600E00A"), Address(RVA = "0x2024764", Offset = "0x2024764", VA = "0x2024764")] private set
        {
        }
      }

      [Token(Token = "0x17003017")]
      public Battle.Score.Score Score
      {
        [Token(Token = "0x600E00B"), Address(RVA = "0x202476C", Offset = "0x202476C", VA = "0x202476C")] get
        {
          return (Battle.Score.Score) null;
        }
        [Token(Token = "0x600E00C"), Address(RVA = "0x2024774", Offset = "0x2024774", VA = "0x2024774")] private set
        {
        }
      }

      [Token(Token = "0x600E00D")]
      [Address(RVA = "0x20244A4", Offset = "0x20244A4", VA = "0x20244A4")]
      public CreatedScore(
        int unitParamId,
        BattleBadStatusTypeEnum badStatus,
        int priority,
        Battle.Score.Score score)
      {
      }
    }
  }
}
