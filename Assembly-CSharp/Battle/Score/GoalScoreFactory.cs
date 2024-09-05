// Decompiled with JetBrains decompiler
// Type: Battle.Score.GoalScoreFactory
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
  [Token(Token = "0x2002480")]
  public class GoalScoreFactory
  {
    [Token(Token = "0x4009C91")]
    [FieldOffset(Offset = "0x10")]
    private ShortestPathSearcher shortest;
    [Token(Token = "0x4009C92")]
    [FieldOffset(Offset = "0x18")]
    private AIConstParam primalTarget;
    [Token(Token = "0x4009C93")]
    [FieldOffset(Offset = "0x24")]
    private AIConstParam target;
    [Token(Token = "0x4009C94")]
    [FieldOffset(Offset = "0x30")]
    private List<GoalScoreFactory.GoalInfo> goalList;
    [Token(Token = "0x4009C95")]
    [FieldOffset(Offset = "0x38")]
    private HashSet<int> targetUnitIds;
    [Token(Token = "0x4009C96")]
    [FieldOffset(Offset = "0x40")]
    private StringBuilder builder;

    [Token(Token = "0x600DFE8")]
    [Address(RVA = "0x2021550", Offset = "0x2021550", VA = "0x2021550")]
    public GoalScoreFactory(AIConstParam primalTarget, AIConstParam target)
    {
    }

    [Token(Token = "0x600DFE9")]
    [Address(RVA = "0x2021674", Offset = "0x2021674", VA = "0x2021674")]
    public void SetGoalInfo(BoardData board, IReadOnlyList<BattleClearConditionData> conditions)
    {
    }

    [Token(Token = "0x600DFEA")]
    [Address(RVA = "0x2021B08", Offset = "0x2021B08", VA = "0x2021B08")]
    public void SetGoalInfo(
      BoardData board,
      IReadOnlyList<BattleFailedConditionData> conditions)
    {
    }

    [Token(Token = "0x600DFEB")]
    [Address(RVA = "0x2021F9C", Offset = "0x2021F9C", VA = "0x2021F9C")]
    public void Clear()
    {
    }

    [Token(Token = "0x600DFEC")]
    [Address(RVA = "0x20216EC", Offset = "0x20216EC", VA = "0x20216EC")]
    public List<GoalScoreFactory.GoalInfo> CreateGoalInfo(
      BoardData board,
      IReadOnlyList<BattleClearConditionData> conditions)
    {
      return (List<GoalScoreFactory.GoalInfo>) null;
    }

    [Token(Token = "0x600DFED")]
    [Address(RVA = "0x2021B80", Offset = "0x2021B80", VA = "0x2021B80")]
    public List<GoalScoreFactory.GoalInfo> CreateGoalInfo(
      BoardData board,
      IReadOnlyList<BattleFailedConditionData> conditions)
    {
      return (List<GoalScoreFactory.GoalInfo>) null;
    }

    [Token(Token = "0x600DFEE")]
    [Address(RVA = "0x2022044", Offset = "0x2022044", VA = "0x2022044")]
    private IReadOnlyList<GoalScoreFactory.GoalInfo> CreateAnihilationTarget(
      BattlePlayerData activePlayer)
    {
      return (IReadOnlyList<GoalScoreFactory.GoalInfo>) null;
    }

    [Token(Token = "0x600DFEF")]
    [Address(RVA = "0x2022428", Offset = "0x2022428", VA = "0x2022428")]
    private IReadOnlyList<GoalScoreFactory.GoalInfo> CreateDefeatTarget(
      BoardData board,
      int targetId)
    {
      return (IReadOnlyList<GoalScoreFactory.GoalInfo>) null;
    }

    [Token(Token = "0x600DFF0")]
    [Address(RVA = "0x202285C", Offset = "0x202285C", VA = "0x202285C")]
    private IReadOnlyList<GoalScoreFactory.GoalInfo> CreateReachPosition(
      BoardData board,
      int x,
      int y)
    {
      return (IReadOnlyList<GoalScoreFactory.GoalInfo>) null;
    }

    [Token(Token = "0x600DFF1")]
    [Address(RVA = "0x2022934", Offset = "0x2022934", VA = "0x2022934")]
    private IReadOnlyList<GoalScoreFactory.GoalInfo> CreateActivateGimmick(
      BoardData board,
      int facility,
      int switchState)
    {
      return (IReadOnlyList<GoalScoreFactory.GoalInfo>) null;
    }

    [Token(Token = "0x600DFF2")]
    [Address(RVA = "0x2022B64", Offset = "0x2022B64", VA = "0x2022B64")]
    private IReadOnlyList<GoalScoreFactory.GoalInfo> CreateGoalTarget(
      BattleClearConditionTypeEnum clearCondition,
      IReadOnlyCollection<GridData> goalGrids)
    {
      return (IReadOnlyList<GoalScoreFactory.GoalInfo>) null;
    }

    [Token(Token = "0x600DFF3")]
    [Address(RVA = "0x2022EF4", Offset = "0x2022EF4", VA = "0x2022EF4")]
    private GoalScoreFactory.GoalInfo CreateGoalTarget(
      BattleClearConditionTypeEnum clearCondition,
      GridData goalGrid)
    {
      return (GoalScoreFactory.GoalInfo) null;
    }

    [Token(Token = "0x600DFF4")]
    [Address(RVA = "0x2022FF0", Offset = "0x2022FF0", VA = "0x2022FF0")]
    public Battle.Score.Score Create(
      in BoardData board,
      UnitParameterData unit,
      GridData grid,
      bool considerWarp)
    {
      return (Battle.Score.Score) null;
    }

    [Token(Token = "0x600DFF5")]
    [Address(RVA = "0x2023698", Offset = "0x2023698", VA = "0x2023698")]
    private int CalcScoreValue(int x, int y, AIConstParam baseScoreParam) => new int();

    [Token(Token = "0x600DFF6")]
    [Address(RVA = "0x20235E0", Offset = "0x20235E0", VA = "0x20235E0")]
    private PathSearcher2D.NodeValidationCallback GetValidator(
      BoardData board,
      UnitParameterData unit)
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }

    [Token(Token = "0x600DFF7")]
    [Address(RVA = "0x2023770", Offset = "0x2023770", VA = "0x2023770")]
    private string Log((int x, int y)? moveTo, (int x, int y)? nearestGoal, int score)
    {
      return (string) null;
    }

    [Token(Token = "0x2002481")]
    public class GoalInfo
    {
      [Token(Token = "0x17003012")]
      public BattleClearConditionTypeEnum Condition
      {
        [Token(Token = "0x600DFF8"), Address(RVA = "0x20239B0", Offset = "0x20239B0", VA = "0x20239B0")] get
        {
          return new BattleClearConditionTypeEnum();
        }
        [Token(Token = "0x600DFF9"), Address(RVA = "0x20239B8", Offset = "0x20239B8", VA = "0x20239B8")] private set
        {
        }
      }

      [Token(Token = "0x17003013")]
      public (int x, int y) Pos
      {
        [Token(Token = "0x600DFFA"), Address(RVA = "0x20239C0", Offset = "0x20239C0", VA = "0x20239C0")] get
        {
          return ();
        }
        [Token(Token = "0x600DFFB"), Address(RVA = "0x20239C8", Offset = "0x20239C8", VA = "0x20239C8")] private set
        {
        }
      }

      [Token(Token = "0x600DFFC")]
      [Address(RVA = "0x2022FC0", Offset = "0x2022FC0", VA = "0x2022FC0")]
      public GoalInfo(BattleClearConditionTypeEnum condition, (int x, int y) pos)
      {
      }
    }
  }
}
