// Decompiled with JetBrains decompiler
// Type: Battle.Score.ScoreFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.RouteSearch;
using GameCore.MasterData;
using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace Battle.Score
{
  [Token(Token = "0x2002495")]
  public class ScoreFactory
  {
    [Token(Token = "0x4009CDE")]
    [FieldOffset(Offset = "0x10")]
    private MobilityScoreFactory mobility;
    [Token(Token = "0x4009CDF")]
    [FieldOffset(Offset = "0x18")]
    private LandformScoreFactory landform;
    [Token(Token = "0x4009CE0")]
    [FieldOffset(Offset = "0x20")]
    private GoalScoreFactory goal;
    [Token(Token = "0x4009CE1")]
    [FieldOffset(Offset = "0x28")]
    private AllyDistanceScoreFactory allyDistance;
    [Token(Token = "0x4009CE2")]
    [FieldOffset(Offset = "0x30")]
    private AllyRangeScoreFactory allyRange;
    [Token(Token = "0x4009CE3")]
    [FieldOffset(Offset = "0x38")]
    private AttackPosScoreFactory attackPos;
    [Token(Token = "0x4009CE4")]
    [FieldOffset(Offset = "0x40")]
    private OpponentCombatPowerScoreFactory opponentCombatPower;
    [Token(Token = "0x4009CE5")]
    [FieldOffset(Offset = "0x48")]
    private OpponentDistanceScoreFactory opponentNearDistance;
    [Token(Token = "0x4009CE6")]
    [FieldOffset(Offset = "0x50")]
    private AttackScoreFactory attack;
    [Token(Token = "0x4009CE7")]
    [FieldOffset(Offset = "0x58")]
    private HPScoreFactory lowHp;
    [Token(Token = "0x4009CE8")]
    [FieldOffset(Offset = "0x60")]
    private HealScoreFactory heal;
    [Token(Token = "0x4009CE9")]
    [FieldOffset(Offset = "0x68")]
    private HealPowerScoreFactory healPower;
    [Token(Token = "0x4009CEA")]
    [FieldOffset(Offset = "0x70")]
    private HealableTakeBadStatusScoreFactory healableTakeBadStatus;
    [Token(Token = "0x4009CEC")]
    [FieldOffset(Offset = "0x80")]
    private TwoPointShortestPathSearcher searcher;
    [Token(Token = "0x4009CED")]
    [FieldOffset(Offset = "0x88")]
    private AttackableAreaSearcher rangeSearcher;

    [Token(Token = "0x17003036")]
    public AIConst AiConst
    {
      [Token(Token = "0x600E082"), Address(RVA = "0x2029EF0", Offset = "0x2029EF0", VA = "0x2029EF0")] get
      {
        return (AIConst) null;
      }
      [Token(Token = "0x600E083"), Address(RVA = "0x2029EF8", Offset = "0x2029EF8", VA = "0x2029EF8")] private set
      {
      }
    }

    [Token(Token = "0x600E084")]
    [Address(RVA = "0x2029F00", Offset = "0x2029F00", VA = "0x2029F00")]
    public ScoreFactory(Table table)
    {
    }

    [Token(Token = "0x600E085")]
    [Address(RVA = "0x202A2E8", Offset = "0x202A2E8", VA = "0x202A2E8")]
    public void Initialize(BoardData board, int actionUnitId)
    {
    }

    [Token(Token = "0x600E086")]
    [Address(RVA = "0x202A4B4", Offset = "0x202A4B4", VA = "0x202A4B4")]
    public Battle.Score.Score Create(int scoreId, BoardData board, CommandScore commandScore)
    {
      return (Battle.Score.Score) null;
    }

    [Token(Token = "0x600E087")]
    [Address(RVA = "0x202AE74", Offset = "0x202AE74", VA = "0x202AE74")]
    public void Clear()
    {
    }

    [Token(Token = "0x600E088")]
    [Address(RVA = "0x202AE04", Offset = "0x202AE04", VA = "0x202AE04")]
    private Battle.Score.Score CreateEmptyScore(ScoreTypeEnum scoreType) => (Battle.Score.Score) null;
  }
}
