// Decompiled with JetBrains decompiler
// Type: StaqData.SpecialQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200206C")]
  public class SpecialQuestInfo : QuestInfo, IStoryQuestDailyFreePlay
  {
    [Token(Token = "0x4008A0F")]
    [FieldOffset(Offset = "0x18")]
    private BattleData battleData;
    [Token(Token = "0x4008A10")]
    [FieldOffset(Offset = "0x20")]
    private int recommendedCombatPower;
    [Token(Token = "0x4008A11")]
    [FieldOffset(Offset = "0x24")]
    private int releaseQuestId;
    [Token(Token = "0x4008A12")]
    [FieldOffset(Offset = "0x28")]
    private IReadOnlyList<BattleRewardDescriptionData> firstClearRewards;
    [Token(Token = "0x4008A13")]
    [FieldOffset(Offset = "0x30")]
    private IReadOnlyList<BattleRewardDescriptionData> clearRewards;
    [Token(Token = "0x4008A14")]
    [FieldOffset(Offset = "0x38")]
    private QuestInfoMissions mission;

    [Token(Token = "0x170029A2")]
    public SpecialQuestData SpecialQuestData
    {
      [Token(Token = "0x600C3DC"), Address(RVA = "0x19F5188", Offset = "0x19F5188", VA = "0x19F5188")] get
      {
        return (SpecialQuestData) null;
      }
      [Token(Token = "0x600C3DD"), Address(RVA = "0x19F5190", Offset = "0x19F5190", VA = "0x19F5190")] private set
      {
      }
    }

    [Token(Token = "0x170029A3")]
    public StoryScenarioQuestData StoryScenarioQuest
    {
      [Token(Token = "0x600C3DE"), Address(RVA = "0x19F5198", Offset = "0x19F5198", VA = "0x19F5198")] get
      {
        return (StoryScenarioQuestData) null;
      }
      [Token(Token = "0x600C3DF"), Address(RVA = "0x19F51A0", Offset = "0x19F51A0", VA = "0x19F51A0")] private set
      {
      }
    }

    [Token(Token = "0x170029A4")]
    public SpecialQuestStageData SpecialQuestStageData
    {
      [Token(Token = "0x600C3E0"), Address(RVA = "0x19F51A8", Offset = "0x19F51A8", VA = "0x19F51A8")] get
      {
        return (SpecialQuestStageData) null;
      }
      [Token(Token = "0x600C3E1"), Address(RVA = "0x19F51B0", Offset = "0x19F51B0", VA = "0x19F51B0")] private set
      {
      }
    }

    [Token(Token = "0x170029A5")]
    public int QuestLevel
    {
      [Token(Token = "0x600C3E2"), Address(RVA = "0x19F51B8", Offset = "0x19F51B8", VA = "0x19F51B8")] get
      {
        return new int();
      }
      [Token(Token = "0x600C3E3"), Address(RVA = "0x19F51C0", Offset = "0x19F51C0", VA = "0x19F51C0")] private set
      {
      }
    }

    [Token(Token = "0x170029A6")]
    public StageLevelData StageLevelData
    {
      [Token(Token = "0x600C3E4"), Address(RVA = "0x19F51C8", Offset = "0x19F51C8", VA = "0x19F51C8")] get
      {
        return (StageLevelData) null;
      }
      [Token(Token = "0x600C3E5"), Address(RVA = "0x19F51D0", Offset = "0x19F51D0", VA = "0x19F51D0")] private set
      {
      }
    }

    [Token(Token = "0x170029A7")]
    public override IQuestStage QuestStage
    {
      [Token(Token = "0x600C3E6"), Address(RVA = "0x19F51D8", Offset = "0x19F51D8", VA = "0x19F51D8", Slot = "9")] get
      {
        return (IQuestStage) null;
      }
    }

    [Token(Token = "0x170029A8")]
    public override bool IsNeedLp
    {
      [Token(Token = "0x600C3E7"), Address(RVA = "0x19F51E0", Offset = "0x19F51E0", VA = "0x19F51E0", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170029A9")]
    public override QuestTypeEnum QuestType
    {
      [Token(Token = "0x600C3E8"), Address(RVA = "0x19F5200", Offset = "0x19F5200", VA = "0x19F5200", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x170029AA")]
    public override int LoopCount
    {
      [Token(Token = "0x600C3E9"), Address(RVA = "0x19F5208", Offset = "0x19F5208", VA = "0x19F5208", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029AB")]
    public override BattleData BattleData
    {
      [Token(Token = "0x600C3EA"), Address(RVA = "0x19F5228", Offset = "0x19F5228", VA = "0x19F5228", Slot = "12")] get
      {
        return (BattleData) null;
      }
    }

    [Token(Token = "0x170029AC")]
    public override int RecommendedCombatPower
    {
      [Token(Token = "0x600C3EB"), Address(RVA = "0x19F5230", Offset = "0x19F5230", VA = "0x19F5230", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029AD")]
    public override QuestStageData QuestStageData
    {
      [Token(Token = "0x600C3EC"), Address(RVA = "0x19F5238", Offset = "0x19F5238", VA = "0x19F5238", Slot = "10")] get
      {
        return (QuestStageData) null;
      }
    }

    [Token(Token = "0x170029AE")]
    public override IReadOnlyList<QuestMissionInfo> Missions
    {
      [Token(Token = "0x600C3ED"), Address(RVA = "0x19F5240", Offset = "0x19F5240", VA = "0x19F5240", Slot = "18")] get
      {
        return (IReadOnlyList<QuestMissionInfo>) null;
      }
    }

    [Token(Token = "0x170029AF")]
    public override IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards
    {
      [Token(Token = "0x600C3EE"), Address(RVA = "0x19F525C", Offset = "0x19F525C", VA = "0x19F525C", Slot = "19")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x170029B0")]
    public override IReadOnlyList<BattleRewardDescriptionData> ClearRewards
    {
      [Token(Token = "0x600C3EF"), Address(RVA = "0x19F5264", Offset = "0x19F5264", VA = "0x19F5264", Slot = "20")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x170029B1")]
    public override bool IsAllowMultipleSameCharacters
    {
      [Token(Token = "0x600C3F0"), Address(RVA = "0x19F526C", Offset = "0x19F526C", VA = "0x19F526C", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C3F1")]
    [Address(RVA = "0x19F5288", Offset = "0x19F5288", VA = "0x19F5288", Slot = "23")]
    public override bool DifficultyType(out QuestDifficultyTypeEnum difficultyType) => new bool();

    [Token(Token = "0x600C3F2")]
    [Address(RVA = "0x19F5298", Offset = "0x19F5298", VA = "0x19F5298", Slot = "24")]
    public override bool IsReleased() => new bool();

    [Token(Token = "0x600C3F3")]
    [Address(RVA = "0x19F52A0", Offset = "0x19F52A0", VA = "0x19F52A0", Slot = "25")]
    public override bool IsCleared() => new bool();

    [Token(Token = "0x170029B2")]
    public override int TotalClearCount
    {
      [Token(Token = "0x600C3F4"), Address(RVA = "0x19F52A8", Offset = "0x19F52A8", VA = "0x19F52A8", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029B3")]
    public override int TodayClearCount
    {
      [Token(Token = "0x600C3F5"), Address(RVA = "0x19F52B0", Offset = "0x19F52B0", VA = "0x19F52B0", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029B4")]
    public override int NumberOfClearsPerDay
    {
      [Token(Token = "0x600C3F6"), Address(RVA = "0x19F52B8", Offset = "0x19F52B8", VA = "0x19F52B8", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029B5")]
    public override int QuestMapPosition
    {
      [Token(Token = "0x600C3F7"), Address(RVA = "0x19F52C0", Offset = "0x19F52C0", VA = "0x19F52C0", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029B6")]
    public int DailyFreePlayCount
    {
      [Token(Token = "0x600C3F8"), Address(RVA = "0x19F52DC", Offset = "0x19F52DC", VA = "0x19F52DC", Slot = "27")] get
      {
        return new int();
      }
      [Token(Token = "0x600C3F9"), Address(RVA = "0x19F52F8", Offset = "0x19F52F8", VA = "0x19F52F8", Slot = "28")] set
      {
      }
    }

    [Token(Token = "0x170029B7")]
    public int DailyFreePlayRemaining
    {
      [Token(Token = "0x600C3FA"), Address(RVA = "0x19F52FC", Offset = "0x19F52FC", VA = "0x19F52FC", Slot = "29")] get
      {
        return new int();
      }
      [Token(Token = "0x600C3FB"), Address(RVA = "0x19F53E8", Offset = "0x19F53E8", VA = "0x19F53E8", Slot = "30")] set
      {
      }
    }

    [Token(Token = "0x600C3FC")]
    [Address(RVA = "0x19F44C8", Offset = "0x19F44C8", VA = "0x19F44C8")]
    public SpecialQuestInfo(int questId, int level = -1)
    {
    }
  }
}
