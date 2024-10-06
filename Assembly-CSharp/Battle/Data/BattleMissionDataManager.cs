// Decompiled with JetBrains decompiler
// Type: Battle.Data.BattleMissionDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using FlatBuffers;
using GameCore.MasterData;
using Il2CppDummyDll;
using staq.SaveSchema;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002706")]
  public class BattleMissionDataManager
  {
    [Token(Token = "0x400A6E4")]
    [FieldOffset(Offset = "0x10")]
    private QuestTypeEnum questType;
    [Token(Token = "0x400A6E5")]
    [FieldOffset(Offset = "0x14")]
    private int missionSetId;
    [Token(Token = "0x400A6E7")]
    [FieldOffset(Offset = "0x20")]
    private List<IMissionData> missions;
    [Token(Token = "0x400A6E8")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<IMissionData, int> counters;

    [Token(Token = "0x1700335E")]
    public StoryBattleMissionData StorySub
    {
      [Token(Token = "0x600F1E8"), Address(RVA = "0x41AFCC4", Offset = "0x41AFCC4", VA = "0x41AFCC4")] get
      {
        return (StoryBattleMissionData) null;
      }
      [Token(Token = "0x600F1E9"), Address(RVA = "0x41AFCCC", Offset = "0x41AFCCC", VA = "0x41AFCCC")] private set
      {
      }
    }

    [Token(Token = "0x1700335F")]
    public IReadOnlyList<IMissionData> Missions
    {
      [Token(Token = "0x600F1EA"), Address(RVA = "0x41AFCD4", Offset = "0x41AFCD4", VA = "0x41AFCD4")] get
      {
        return (IReadOnlyList<IMissionData>) null;
      }
    }

    [Token(Token = "0x600F1EB")]
    [Address(RVA = "0x41AFCDC", Offset = "0x41AFCDC", VA = "0x41AFCDC")]
    public BattleMissionDataManager(QuestTypeEnum type, int missionSetId)
    {
    }

    [Token(Token = "0x600F1EC")]
    [Address(RVA = "0x41B0164", Offset = "0x41B0164", VA = "0x41B0164")]
    public static BattleMissionDataManager CreateFromSchema(BattleMissionProgress schema)
    {
      return (BattleMissionDataManager) null;
    }

    [Token(Token = "0x600F1ED")]
    [Address(RVA = "0x41B03AC", Offset = "0x41B03AC", VA = "0x41B03AC")]
    public BattleMissionDataManager Copy() => (BattleMissionDataManager) null;

    [Token(Token = "0x600F1EE")]
    [Address(RVA = "0x41B06C4", Offset = "0x41B06C4", VA = "0x41B06C4")]
    public Offset<BattleMissionProgress> Serialize(FlatBufferBuilder fbb)
    {
      return new Offset<BattleMissionProgress>();
    }

    [Token(Token = "0x600F1EF")]
    [Address(RVA = "0x41B0970", Offset = "0x41B0970", VA = "0x41B0970")]
    public List<int> GetAchivedMissionIDs(Battle.Data.Board.BoardData board) => (List<int>) null;

    [Token(Token = "0x600F1F0")]
    [Address(RVA = "0x41B0C60", Offset = "0x41B0C60", VA = "0x41B0C60")]
    public List<int> GetAchivedMissionIDsOnBattleWin(Battle.Data.Board.BoardData board)
    {
      return (List<int>) null;
    }

    [Token(Token = "0x600F1F1")]
    [Address(RVA = "0x41B106C", Offset = "0x41B106C", VA = "0x41B106C")]
    public void Aggregate(Battle.Data.Board.BoardData board, Battle.Data.Board.UnitParameterData unit, UnitParameterChange paramChange)
    {
    }

    [Token(Token = "0x600F1F2")]
    [Address(RVA = "0x41B1484", Offset = "0x41B1484", VA = "0x41B1484")]
    public void Aggregate(Battle.Data.Board.BoardData board, UnitCommandBase command)
    {
    }

    [Token(Token = "0x600F1F3")]
    [Address(RVA = "0x41B1D64", Offset = "0x41B1D64", VA = "0x41B1D64")]
    public void AggregateOnBoard(Battle.Data.Board.BoardData board)
    {
    }

    [Token(Token = "0x600F1F4")]
    [Address(RVA = "0x41B2780", Offset = "0x41B2780", VA = "0x41B2780")]
    public void AggregateBadStateKill(
      Battle.Data.Board.BoardData board,
      Battle.Data.Board.UnitParameterData unit,
      UnitParameterChange paramChange)
    {
    }

    [Token(Token = "0x600F1F5")]
    [Address(RVA = "0x41B29E4", Offset = "0x41B29E4", VA = "0x41B29E4")]
    public void SetRollBackCount(int count)
    {
    }

    [Token(Token = "0x600F1F6")]
    [Address(RVA = "0x41B1CF0", Offset = "0x41B1CF0", VA = "0x41B1CF0")]
    private void Aggregate(Battle.Data.Board.BoardData board, SkillCommandBase command)
    {
    }

    [Token(Token = "0x600F1F7")]
    [Address(RVA = "0x41B2EB4", Offset = "0x41B2EB4", VA = "0x41B2EB4")]
    private void Aggregate(Battle.Data.Board.BoardData board, ActionResult actionResult)
    {
    }

    [Token(Token = "0x600F1F8")]
    [Address(RVA = "0x41B17EC", Offset = "0x41B17EC", VA = "0x41B17EC")]
    private void Aggregate(Battle.Data.Board.BoardData board, UseItemCommand command)
    {
    }

    [Token(Token = "0x600F1F9")]
    [Address(RVA = "0x41B15B0", Offset = "0x41B15B0", VA = "0x41B15B0")]
    private void Aggregate(Battle.Data.Board.BoardData board, InteractCommand command)
    {
    }

    [Token(Token = "0x600F1FA")]
    [Address(RVA = "0x41B2BA4", Offset = "0x41B2BA4", VA = "0x41B2BA4")]
    private void CountUseSkill(
      Battle.Data.Board.UnitParameterData from,
      Battle.Data.Board.UnitParameterData to,
      Battle.Data.Board.WeaponParameterData useWeapon,
      Battle.Data.Board.SkillParameterData useSkill,
      int turn)
    {
    }

    [Token(Token = "0x600F1FB")]
    [Address(RVA = "0x41B31C4", Offset = "0x41B31C4", VA = "0x41B31C4")]
    private void CountOnDealEffect(
      Battle.Data.Board.UnitParameterData from,
      Battle.Data.Board.UnitParameterData to,
      Battle.Data.Board.WeaponParameterData useWeapon,
      Battle.Data.Board.SkillParameterData useSkill,
      UnitParameterChange beforeParam,
      UnitParameterChange afterParam,
      int turn)
    {
    }

    [Token(Token = "0x600F1FC")]
    [Address(RVA = "0x41B10A4", Offset = "0x41B10A4", VA = "0x41B10A4")]
    private void CountOnReceiveEffect(
      Battle.Data.Board.UnitParameterData from,
      Battle.Data.Board.UnitParameterData to,
      Battle.Data.Board.WeaponParameterData useWeapon,
      Battle.Data.Board.SkillParameterData useSkill,
      UnitParameterChange beforeParam,
      UnitParameterChange afterParam,
      int turn)
    {
    }
  }
}
