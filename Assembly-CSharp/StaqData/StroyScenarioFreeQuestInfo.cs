// Decompiled with JetBrains decompiler
// Type: StaqData.StroyScenarioFreeQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002069")]
  public class StroyScenarioFreeQuestInfo : QuestInfo
  {
    [Token(Token = "0x4008A01")]
    [FieldOffset(Offset = "0x18")]
    private QuestStageData questStageData;
    [Token(Token = "0x4008A02")]
    [FieldOffset(Offset = "0x20")]
    private int releaseQuestId;
    [Token(Token = "0x4008A03")]
    [FieldOffset(Offset = "0x28")]
    private IReadOnlyList<BattleRewardDescriptionData> firstClearRewards;
    [Token(Token = "0x4008A04")]
    [FieldOffset(Offset = "0x30")]
    private IReadOnlyList<BattleRewardDescriptionData> clearRewards;
    [Token(Token = "0x4008A05")]
    [FieldOffset(Offset = "0x38")]
    private int numberOfClearsPerDay;
    [Token(Token = "0x4008A06")]
    [FieldOffset(Offset = "0x40")]
    private QuestInfoMissions mission;

    [Token(Token = "0x17002985")]
    public override bool IsNeedLp
    {
      [Token(Token = "0x600C3B4"), Address(RVA = "0x19F3EF4", Offset = "0x19F3EF4", VA = "0x19F3EF4", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002986")]
    public override QuestTypeEnum QuestType
    {
      [Token(Token = "0x600C3B5"), Address(RVA = "0x19F3F14", Offset = "0x19F3F14", VA = "0x19F3F14", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17002987")]
    public override int LoopCount
    {
      [Token(Token = "0x600C3B6"), Address(RVA = "0x19F3F1C", Offset = "0x19F3F1C", VA = "0x19F3F1C", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002988")]
    public override QuestStageData QuestStageData
    {
      [Token(Token = "0x600C3B7"), Address(RVA = "0x19F3F3C", Offset = "0x19F3F3C", VA = "0x19F3F3C", Slot = "10")] get
      {
        return (QuestStageData) null;
      }
    }

    [Token(Token = "0x17002989")]
    public override IReadOnlyList<QuestMissionInfo> Missions
    {
      [Token(Token = "0x600C3B8"), Address(RVA = "0x19F3F44", Offset = "0x19F3F44", VA = "0x19F3F44", Slot = "18")] get
      {
        return (IReadOnlyList<QuestMissionInfo>) null;
      }
    }

    [Token(Token = "0x1700298A")]
    public override IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards
    {
      [Token(Token = "0x600C3B9"), Address(RVA = "0x19F3F60", Offset = "0x19F3F60", VA = "0x19F3F60", Slot = "19")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x1700298B")]
    public override IReadOnlyList<BattleRewardDescriptionData> ClearRewards
    {
      [Token(Token = "0x600C3BA"), Address(RVA = "0x19F3F68", Offset = "0x19F3F68", VA = "0x19F3F68", Slot = "20")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x1700298C")]
    protected override bool CheckSkipConditionOnIgnoreState
    {
      [Token(Token = "0x600C3BB"), Address(RVA = "0x19F3F70", Offset = "0x19F3F70", VA = "0x19F3F70", Slot = "26")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700298D")]
    public override bool IsAllowMultipleSameCharacters
    {
      [Token(Token = "0x600C3BC"), Address(RVA = "0x19F3F98", Offset = "0x19F3F98", VA = "0x19F3F98", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700298E")]
    public override int NormalQuestId
    {
      [Token(Token = "0x600C3BD"), Address(RVA = "0x19F3FBC", Offset = "0x19F3FBC", VA = "0x19F3FBC", Slot = "22")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C3BE")]
    [Address(RVA = "0x19F3FC4", Offset = "0x19F3FC4", VA = "0x19F3FC4", Slot = "23")]
    public override bool DifficultyType(out QuestDifficultyTypeEnum difficultyType) => new bool();

    [Token(Token = "0x600C3BF")]
    [Address(RVA = "0x19F4080", Offset = "0x19F4080", VA = "0x19F4080", Slot = "24")]
    public override bool IsReleased() => new bool();

    [Token(Token = "0x600C3C0")]
    [Address(RVA = "0x19F4088", Offset = "0x19F4088", VA = "0x19F4088", Slot = "25")]
    public override bool IsCleared() => new bool();

    [Token(Token = "0x1700298F")]
    public override int TotalClearCount
    {
      [Token(Token = "0x600C3C1"), Address(RVA = "0x19F4090", Offset = "0x19F4090", VA = "0x19F4090", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002990")]
    public override int TodayClearCount
    {
      [Token(Token = "0x600C3C2"), Address(RVA = "0x19F4098", Offset = "0x19F4098", VA = "0x19F4098", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002991")]
    public override int NumberOfClearsPerDay
    {
      [Token(Token = "0x600C3C3"), Address(RVA = "0x19F40A0", Offset = "0x19F40A0", VA = "0x19F40A0", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C3C4")]
    [Address(RVA = "0x19F40A8", Offset = "0x19F40A8", VA = "0x19F40A8")]
    public StroyScenarioFreeQuestInfo(int questId)
    {
    }
  }
}
