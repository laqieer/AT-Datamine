// Decompiled with JetBrains decompiler
// Type: StaqData.AreaQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200206F")]
  public class AreaQuestInfo : QuestInfo, AreaQuestParam, HaveQuestDifficulty
  {
    [Token(Token = "0x4008A22")]
    [FieldOffset(Offset = "0x18")]
    private QuestStageData questStageData;
    [Token(Token = "0x4008A23")]
    [FieldOffset(Offset = "0x20")]
    private IReadOnlyList<BattleRewardDescriptionData> firstClearRewards;
    [Token(Token = "0x4008A24")]
    [FieldOffset(Offset = "0x28")]
    private IReadOnlyList<BattleRewardDescriptionData> clearRewards;
    [Token(Token = "0x4008A25")]
    [FieldOffset(Offset = "0x30")]
    private int numberOfClearsPerDay;
    [Token(Token = "0x4008A26")]
    [FieldOffset(Offset = "0x38")]
    private QuestInfoMissions mission;
    [Token(Token = "0x4008A27")]
    [FieldOffset(Offset = "0x40")]
    private int questGroupId;

    [Token(Token = "0x170029C6")]
    private QuestDifficultyTypeEnum StaqData\u002EHaveQuestDifficulty\u002EDifficultyType
    {
      [Token(Token = "0x600C411"), Address(RVA = "0x19F54EC", Offset = "0x19F54EC", VA = "0x19F54EC", Slot = "28")] get
      {
        return new QuestDifficultyTypeEnum();
      }
    }

    [Token(Token = "0x170029C7")]
    private int StaqData\u002EHaveQuestDifficulty\u002EQuestGroupId
    {
      [Token(Token = "0x600C412"), Address(RVA = "0x19F5594", Offset = "0x19F5594", VA = "0x19F5594", Slot = "27")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029C8")]
    public override bool IsNeedLp
    {
      [Token(Token = "0x600C413"), Address(RVA = "0x19F559C", Offset = "0x19F559C", VA = "0x19F559C", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170029C9")]
    public override QuestTypeEnum QuestType
    {
      [Token(Token = "0x600C414"), Address(RVA = "0x19F55BC", Offset = "0x19F55BC", VA = "0x19F55BC", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x170029CA")]
    public override int LoopCount
    {
      [Token(Token = "0x600C415"), Address(RVA = "0x19F55C4", Offset = "0x19F55C4", VA = "0x19F55C4", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029CB")]
    public override QuestStageData QuestStageData
    {
      [Token(Token = "0x600C416"), Address(RVA = "0x19F55E4", Offset = "0x19F55E4", VA = "0x19F55E4", Slot = "10")] get
      {
        return (QuestStageData) null;
      }
    }

    [Token(Token = "0x170029CC")]
    public override IReadOnlyList<QuestMissionInfo> Missions
    {
      [Token(Token = "0x600C417"), Address(RVA = "0x19F55EC", Offset = "0x19F55EC", VA = "0x19F55EC", Slot = "18")] get
      {
        return (IReadOnlyList<QuestMissionInfo>) null;
      }
    }

    [Token(Token = "0x170029CD")]
    public override IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards
    {
      [Token(Token = "0x600C418"), Address(RVA = "0x19F5608", Offset = "0x19F5608", VA = "0x19F5608", Slot = "19")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x170029CE")]
    public override IReadOnlyList<BattleRewardDescriptionData> ClearRewards
    {
      [Token(Token = "0x600C419"), Address(RVA = "0x19F5610", Offset = "0x19F5610", VA = "0x19F5610", Slot = "20")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x170029CF")]
    public override bool IsAllowMultipleSameCharacters
    {
      [Token(Token = "0x600C41A"), Address(RVA = "0x19F5618", Offset = "0x19F5618", VA = "0x19F5618", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170029D0")]
    public override int TotalClearCount
    {
      [Token(Token = "0x600C41B"), Address(RVA = "0x19F563C", Offset = "0x19F563C", VA = "0x19F563C", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029D1")]
    public override int TodayClearCount
    {
      [Token(Token = "0x600C41C"), Address(RVA = "0x19F5644", Offset = "0x19F5644", VA = "0x19F5644", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029D2")]
    public override int NumberOfClearsPerDay
    {
      [Token(Token = "0x600C41D"), Address(RVA = "0x19F564C", Offset = "0x19F564C", VA = "0x19F564C", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029D3")]
    public int AreaQuestNodeId
    {
      [Token(Token = "0x600C41E"), Address(RVA = "0x19F5654", Offset = "0x19F5654", VA = "0x19F5654")] get
      {
        return new int();
      }
      [Token(Token = "0x600C41F"), Address(RVA = "0x19F565C", Offset = "0x19F565C", VA = "0x19F565C")] set
      {
      }
    }

    [Token(Token = "0x170029D4")]
    protected override bool CheckSkipConditionOnIgnoreState
    {
      [Token(Token = "0x600C420"), Address(RVA = "0x19F5664", Offset = "0x19F5664", VA = "0x19F5664", Slot = "26")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C421")]
    [Address(RVA = "0x19F4BCC", Offset = "0x19F4BCC", VA = "0x19F4BCC")]
    public AreaQuestInfo(int questId, int areaQuestNodeId = 0)
    {
    }

    [Token(Token = "0x600C422")]
    [Address(RVA = "0x19F570C", Offset = "0x19F570C", VA = "0x19F570C", Slot = "23")]
    public override bool DifficultyType(out QuestDifficultyTypeEnum difficultyType) => new bool();

    [Token(Token = "0x600C423")]
    [Address(RVA = "0x19F59F8", Offset = "0x19F59F8", VA = "0x19F59F8", Slot = "24")]
    public override bool IsReleased() => new bool();

    [Token(Token = "0x600C424")]
    [Address(RVA = "0x19F5CFC", Offset = "0x19F5CFC", VA = "0x19F5CFC", Slot = "25")]
    public override bool IsCleared() => new bool();
  }
}
