// Decompiled with JetBrains decompiler
// Type: StaqData.StroyScenarioSubQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002068")]
  public class StroyScenarioSubQuestInfo : SubQuestInfoBase
  {
    [Token(Token = "0x40089FB")]
    [FieldOffset(Offset = "0x18")]
    private QuestStageData questStageData;
    [Token(Token = "0x40089FC")]
    [FieldOffset(Offset = "0x20")]
    private int releaseQuestId;
    [Token(Token = "0x40089FD")]
    [FieldOffset(Offset = "0x28")]
    private IReadOnlyList<BattleRewardDescriptionData> firstClearRewards;
    [Token(Token = "0x40089FE")]
    [FieldOffset(Offset = "0x30")]
    private IReadOnlyList<BattleRewardDescriptionData> clearRewards;
    [Token(Token = "0x40089FF")]
    [FieldOffset(Offset = "0x38")]
    private int numberOfClearsPerDay;
    [Token(Token = "0x4008A00")]
    [FieldOffset(Offset = "0x40")]
    private QuestInfoMissions mission;

    [Token(Token = "0x1700297A")]
    public override bool IsNeedLp
    {
      [Token(Token = "0x600C3A5"), Address(RVA = "0x19F3CF0", Offset = "0x19F3CF0", VA = "0x19F3CF0", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700297B")]
    public override QuestTypeEnum QuestType
    {
      [Token(Token = "0x600C3A6"), Address(RVA = "0x19F3D10", Offset = "0x19F3D10", VA = "0x19F3D10", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x1700297C")]
    public override int LoopCount
    {
      [Token(Token = "0x600C3A7"), Address(RVA = "0x19F3D18", Offset = "0x19F3D18", VA = "0x19F3D18", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700297D")]
    public override QuestStageData QuestStageData
    {
      [Token(Token = "0x600C3A8"), Address(RVA = "0x19F3D38", Offset = "0x19F3D38", VA = "0x19F3D38", Slot = "10")] get
      {
        return (QuestStageData) null;
      }
    }

    [Token(Token = "0x1700297E")]
    public override IReadOnlyList<QuestMissionInfo> Missions
    {
      [Token(Token = "0x600C3A9"), Address(RVA = "0x19F3D40", Offset = "0x19F3D40", VA = "0x19F3D40", Slot = "18")] get
      {
        return (IReadOnlyList<QuestMissionInfo>) null;
      }
    }

    [Token(Token = "0x1700297F")]
    public override IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards
    {
      [Token(Token = "0x600C3AA"), Address(RVA = "0x19F3D5C", Offset = "0x19F3D5C", VA = "0x19F3D5C", Slot = "19")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x17002980")]
    public override IReadOnlyList<BattleRewardDescriptionData> ClearRewards
    {
      [Token(Token = "0x600C3AB"), Address(RVA = "0x19F3D64", Offset = "0x19F3D64", VA = "0x19F3D64", Slot = "20")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x17002981")]
    public override bool IsAllowMultipleSameCharacters
    {
      [Token(Token = "0x600C3AC"), Address(RVA = "0x19F3D6C", Offset = "0x19F3D6C", VA = "0x19F3D6C", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C3AD")]
    [Address(RVA = "0x19F3D90", Offset = "0x19F3D90", VA = "0x19F3D90", Slot = "23")]
    public override bool DifficultyType(out QuestDifficultyTypeEnum difficultyType) => new bool();

    [Token(Token = "0x600C3AE")]
    [Address(RVA = "0x19F3DA0", Offset = "0x19F3DA0", VA = "0x19F3DA0", Slot = "24")]
    public override bool IsReleased() => new bool();

    [Token(Token = "0x600C3AF")]
    [Address(RVA = "0x19F3DA8", Offset = "0x19F3DA8", VA = "0x19F3DA8", Slot = "25")]
    public override bool IsCleared() => new bool();

    [Token(Token = "0x17002982")]
    public override int TotalClearCount
    {
      [Token(Token = "0x600C3B0"), Address(RVA = "0x19F3DB0", Offset = "0x19F3DB0", VA = "0x19F3DB0", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002983")]
    public override int TodayClearCount
    {
      [Token(Token = "0x600C3B1"), Address(RVA = "0x19F3DB8", Offset = "0x19F3DB8", VA = "0x19F3DB8", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002984")]
    public override int NumberOfClearsPerDay
    {
      [Token(Token = "0x600C3B2"), Address(RVA = "0x19F3DC0", Offset = "0x19F3DC0", VA = "0x19F3DC0", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C3B3")]
    [Address(RVA = "0x19F3DC8", Offset = "0x19F3DC8", VA = "0x19F3DC8")]
    public StroyScenarioSubQuestInfo(int questId, int subQuestTaskId)
    {
    }
  }
}
