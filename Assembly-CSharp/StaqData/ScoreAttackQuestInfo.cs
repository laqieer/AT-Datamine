// Decompiled with JetBrains decompiler
// Type: StaqData.ScoreAttackQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200206D")]
  public class ScoreAttackQuestInfo : QuestInfo, IStoryQuestDailyFreePlay
  {
    [Token(Token = "0x4008A1A")]
    [FieldOffset(Offset = "0x18")]
    private QuestStageData questStageData;
    [Token(Token = "0x4008A1B")]
    [FieldOffset(Offset = "0x20")]
    private int releaseQuestId;
    [Token(Token = "0x4008A1C")]
    [FieldOffset(Offset = "0x28")]
    private IReadOnlyList<BattleRewardDescriptionData> firstClearRewards;
    [Token(Token = "0x4008A1D")]
    [FieldOffset(Offset = "0x30")]
    private IReadOnlyList<BattleRewardDescriptionData> clearRewards;
    [Token(Token = "0x4008A1E")]
    [FieldOffset(Offset = "0x38")]
    private int numberOfClearsPerDay;
    [Token(Token = "0x4008A1F")]
    [FieldOffset(Offset = "0x40")]
    private QuestInfoMissions mission;

    [Token(Token = "0x170029B8")]
    public override bool IsNeedLp
    {
      [Token(Token = "0x600C3FD"), Address(RVA = "0x19F53EC", Offset = "0x19F53EC", VA = "0x19F53EC", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170029B9")]
    public override QuestTypeEnum QuestType
    {
      [Token(Token = "0x600C3FE"), Address(RVA = "0x19F540C", Offset = "0x19F540C", VA = "0x19F540C", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x170029BA")]
    public override int LoopCount
    {
      [Token(Token = "0x600C3FF"), Address(RVA = "0x19F5414", Offset = "0x19F5414", VA = "0x19F5414", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029BB")]
    public override QuestStageData QuestStageData
    {
      [Token(Token = "0x600C400"), Address(RVA = "0x19F5434", Offset = "0x19F5434", VA = "0x19F5434", Slot = "10")] get
      {
        return (QuestStageData) null;
      }
    }

    [Token(Token = "0x170029BC")]
    public override IReadOnlyList<QuestMissionInfo> Missions
    {
      [Token(Token = "0x600C401"), Address(RVA = "0x19F543C", Offset = "0x19F543C", VA = "0x19F543C", Slot = "18")] get
      {
        return (IReadOnlyList<QuestMissionInfo>) null;
      }
    }

    [Token(Token = "0x170029BD")]
    public override IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards
    {
      [Token(Token = "0x600C402"), Address(RVA = "0x19F5458", Offset = "0x19F5458", VA = "0x19F5458", Slot = "19")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x170029BE")]
    public override IReadOnlyList<BattleRewardDescriptionData> ClearRewards
    {
      [Token(Token = "0x600C403"), Address(RVA = "0x19F5460", Offset = "0x19F5460", VA = "0x19F5460", Slot = "20")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x170029BF")]
    public override bool IsAllowMultipleSameCharacters
    {
      [Token(Token = "0x600C404"), Address(RVA = "0x19F5468", Offset = "0x19F5468", VA = "0x19F5468", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170029C0")]
    public int DailyFreePlayCount
    {
      [Token(Token = "0x600C405"), Address(RVA = "0x19F548C", Offset = "0x19F548C", VA = "0x19F548C", Slot = "27")] get
      {
        return new int();
      }
      [Token(Token = "0x600C406"), Address(RVA = "0x19F5494", Offset = "0x19F5494", VA = "0x19F5494", Slot = "28")] set
      {
      }
    }

    [Token(Token = "0x170029C1")]
    public int DailyFreePlayRemaining
    {
      [Token(Token = "0x600C407"), Address(RVA = "0x19F549C", Offset = "0x19F549C", VA = "0x19F549C", Slot = "29")] get
      {
        return new int();
      }
      [Token(Token = "0x600C408"), Address(RVA = "0x19F54A4", Offset = "0x19F54A4", VA = "0x19F54A4", Slot = "30")] set
      {
      }
    }

    [Token(Token = "0x170029C2")]
    public override int NormalQuestId
    {
      [Token(Token = "0x600C409"), Address(RVA = "0x19F54AC", Offset = "0x19F54AC", VA = "0x19F54AC", Slot = "22")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C40A")]
    [Address(RVA = "0x19F54B4", Offset = "0x19F54B4", VA = "0x19F54B4", Slot = "23")]
    public override bool DifficultyType(out QuestDifficultyTypeEnum difficultyType) => new bool();

    [Token(Token = "0x600C40B")]
    [Address(RVA = "0x19F54C4", Offset = "0x19F54C4", VA = "0x19F54C4", Slot = "24")]
    public override bool IsReleased() => new bool();

    [Token(Token = "0x600C40C")]
    [Address(RVA = "0x19F54CC", Offset = "0x19F54CC", VA = "0x19F54CC", Slot = "25")]
    public override bool IsCleared() => new bool();

    [Token(Token = "0x170029C3")]
    public override int TotalClearCount
    {
      [Token(Token = "0x600C40D"), Address(RVA = "0x19F54D4", Offset = "0x19F54D4", VA = "0x19F54D4", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029C4")]
    public override int TodayClearCount
    {
      [Token(Token = "0x600C40E"), Address(RVA = "0x19F54DC", Offset = "0x19F54DC", VA = "0x19F54DC", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029C5")]
    public override int NumberOfClearsPerDay
    {
      [Token(Token = "0x600C40F"), Address(RVA = "0x19F54E4", Offset = "0x19F54E4", VA = "0x19F54E4", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C410")]
    [Address(RVA = "0x19F4AA4", Offset = "0x19F4AA4", VA = "0x19F4AA4")]
    public ScoreAttackQuestInfo(int questId)
    {
    }
  }
}
