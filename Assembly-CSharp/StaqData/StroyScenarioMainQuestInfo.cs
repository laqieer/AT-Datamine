// Decompiled with JetBrains decompiler
// Type: StaqData.StroyScenarioMainQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002067")]
  public class StroyScenarioMainQuestInfo : QuestInfo, StroyMainQuestStoryParam
  {
    [Token(Token = "0x40089F5")]
    [FieldOffset(Offset = "0x18")]
    private QuestStageData questStageData;
    [Token(Token = "0x40089F6")]
    [FieldOffset(Offset = "0x20")]
    private int releaseQuestId;
    [Token(Token = "0x40089F7")]
    [FieldOffset(Offset = "0x28")]
    private IReadOnlyList<BattleRewardDescriptionData> firstClearRewards;
    [Token(Token = "0x40089F8")]
    [FieldOffset(Offset = "0x30")]
    private IReadOnlyList<BattleRewardDescriptionData> clearRewards;
    [Token(Token = "0x40089F9")]
    [FieldOffset(Offset = "0x38")]
    private int numberOfClearsPerDay;
    [Token(Token = "0x40089FA")]
    [FieldOffset(Offset = "0x40")]
    private QuestInfoMissions mission;

    [Token(Token = "0x1700296E")]
    public override bool IsNeedLp
    {
      [Token(Token = "0x600C395"), Address(RVA = "0x19F3A48", Offset = "0x19F3A48", VA = "0x19F3A48", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700296F")]
    public override QuestTypeEnum QuestType
    {
      [Token(Token = "0x600C396"), Address(RVA = "0x19F3A68", Offset = "0x19F3A68", VA = "0x19F3A68", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17002970")]
    public override int LoopCount
    {
      [Token(Token = "0x600C397"), Address(RVA = "0x19F3A70", Offset = "0x19F3A70", VA = "0x19F3A70", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002971")]
    public override QuestStageData QuestStageData
    {
      [Token(Token = "0x600C398"), Address(RVA = "0x19F3A90", Offset = "0x19F3A90", VA = "0x19F3A90", Slot = "10")] get
      {
        return (QuestStageData) null;
      }
    }

    [Token(Token = "0x17002972")]
    public override IReadOnlyList<QuestMissionInfo> Missions
    {
      [Token(Token = "0x600C399"), Address(RVA = "0x19F3A98", Offset = "0x19F3A98", VA = "0x19F3A98", Slot = "18")] get
      {
        return (IReadOnlyList<QuestMissionInfo>) null;
      }
    }

    [Token(Token = "0x17002973")]
    public override IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards
    {
      [Token(Token = "0x600C39A"), Address(RVA = "0x19F3AB4", Offset = "0x19F3AB4", VA = "0x19F3AB4", Slot = "19")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x17002974")]
    public override IReadOnlyList<BattleRewardDescriptionData> ClearRewards
    {
      [Token(Token = "0x600C39B"), Address(RVA = "0x19F3ABC", Offset = "0x19F3ABC", VA = "0x19F3ABC", Slot = "20")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x17002975")]
    public override bool IsAllowMultipleSameCharacters
    {
      [Token(Token = "0x600C39C"), Address(RVA = "0x19F3AC4", Offset = "0x19F3AC4", VA = "0x19F3AC4", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C39D")]
    [Address(RVA = "0x19F3AE8", Offset = "0x19F3AE8", VA = "0x19F3AE8", Slot = "23")]
    public override bool DifficultyType(out QuestDifficultyTypeEnum difficultyType) => new bool();

    [Token(Token = "0x600C39E")]
    [Address(RVA = "0x19F3AF8", Offset = "0x19F3AF8", VA = "0x19F3AF8", Slot = "24")]
    public override bool IsReleased() => new bool();

    [Token(Token = "0x600C39F")]
    [Address(RVA = "0x19F3B00", Offset = "0x19F3B00", VA = "0x19F3B00", Slot = "25")]
    public override bool IsCleared() => new bool();

    [Token(Token = "0x17002976")]
    public override int TotalClearCount
    {
      [Token(Token = "0x600C3A0"), Address(RVA = "0x19F3B08", Offset = "0x19F3B08", VA = "0x19F3B08", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002977")]
    public override int TodayClearCount
    {
      [Token(Token = "0x600C3A1"), Address(RVA = "0x19F3B10", Offset = "0x19F3B10", VA = "0x19F3B10", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002978")]
    public override int NumberOfClearsPerDay
    {
      [Token(Token = "0x600C3A2"), Address(RVA = "0x19F3B18", Offset = "0x19F3B18", VA = "0x19F3B18", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002979")]
    public int ChapterId
    {
      [Token(Token = "0x600C3A3"), Address(RVA = "0x19F3B20", Offset = "0x19F3B20", VA = "0x19F3B20", Slot = "27")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C3A4")]
    [Address(RVA = "0x19F3BC8", Offset = "0x19F3BC8", VA = "0x19F3BC8")]
    public StroyScenarioMainQuestInfo(int questId)
    {
    }
  }
}
