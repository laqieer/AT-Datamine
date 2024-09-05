// Decompiled with JetBrains decompiler
// Type: StaqData.RaidQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002070")]
  public class RaidQuestInfo : QuestInfo
  {
    [Token(Token = "0x4008A29")]
    [FieldOffset(Offset = "0x18")]
    private BattleData battleData;
    [Token(Token = "0x4008A2A")]
    [FieldOffset(Offset = "0x20")]
    private IReadOnlyList<BattleRewardDescriptionData> firstClearRewards;
    [Token(Token = "0x4008A2B")]
    [FieldOffset(Offset = "0x28")]
    private IReadOnlyList<BattleRewardDescriptionData> clearRewards;
    [Token(Token = "0x4008A2C")]
    [FieldOffset(Offset = "0x30")]
    private QuestInfoMissions mission;

    [Token(Token = "0x170029D5")]
    public RaidQuestData RaidQuestData
    {
      [Token(Token = "0x600C425"), Address(RVA = "0x19F5D04", Offset = "0x19F5D04", VA = "0x19F5D04")] get
      {
        return (RaidQuestData) null;
      }
      [Token(Token = "0x600C426"), Address(RVA = "0x19F5D0C", Offset = "0x19F5D0C", VA = "0x19F5D0C")] private set
      {
      }
    }

    [Token(Token = "0x170029D6")]
    public GuildRaidStageData GuildRaidStageData
    {
      [Token(Token = "0x600C427"), Address(RVA = "0x19F5D14", Offset = "0x19F5D14", VA = "0x19F5D14")] get
      {
        return (GuildRaidStageData) null;
      }
      [Token(Token = "0x600C428"), Address(RVA = "0x19F5D1C", Offset = "0x19F5D1C", VA = "0x19F5D1C")] private set
      {
      }
    }

    [Token(Token = "0x170029D7")]
    public override int QuestMapPosition
    {
      [Token(Token = "0x600C429"), Address(RVA = "0x19F5D24", Offset = "0x19F5D24", VA = "0x19F5D24", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029D8")]
    public override IQuestStage QuestStage
    {
      [Token(Token = "0x600C42A"), Address(RVA = "0x19F5D40", Offset = "0x19F5D40", VA = "0x19F5D40", Slot = "9")] get
      {
        return (IQuestStage) null;
      }
    }

    [Token(Token = "0x170029D9")]
    public override bool IsNeedLp
    {
      [Token(Token = "0x600C42B"), Address(RVA = "0x19F5D48", Offset = "0x19F5D48", VA = "0x19F5D48", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170029DA")]
    public override QuestTypeEnum QuestType
    {
      [Token(Token = "0x600C42C"), Address(RVA = "0x19F5D68", Offset = "0x19F5D68", VA = "0x19F5D68", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x170029DB")]
    public override int LoopCount
    {
      [Token(Token = "0x600C42D"), Address(RVA = "0x19F5D70", Offset = "0x19F5D70", VA = "0x19F5D70", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029DC")]
    public override BattleData BattleData
    {
      [Token(Token = "0x600C42E"), Address(RVA = "0x19F5D90", Offset = "0x19F5D90", VA = "0x19F5D90", Slot = "12")] get
      {
        return (BattleData) null;
      }
    }

    [Token(Token = "0x170029DD")]
    public override QuestStageData QuestStageData
    {
      [Token(Token = "0x600C42F"), Address(RVA = "0x19F5D98", Offset = "0x19F5D98", VA = "0x19F5D98", Slot = "10")] get
      {
        return (QuestStageData) null;
      }
    }

    [Token(Token = "0x170029DE")]
    public override IReadOnlyList<QuestMissionInfo> Missions
    {
      [Token(Token = "0x600C430"), Address(RVA = "0x19F5DA0", Offset = "0x19F5DA0", VA = "0x19F5DA0", Slot = "18")] get
      {
        return (IReadOnlyList<QuestMissionInfo>) null;
      }
    }

    [Token(Token = "0x170029DF")]
    public override IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards
    {
      [Token(Token = "0x600C431"), Address(RVA = "0x19F5DBC", Offset = "0x19F5DBC", VA = "0x19F5DBC", Slot = "19")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x170029E0")]
    public override IReadOnlyList<BattleRewardDescriptionData> ClearRewards
    {
      [Token(Token = "0x600C432"), Address(RVA = "0x19F5DC4", Offset = "0x19F5DC4", VA = "0x19F5DC4", Slot = "20")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x170029E1")]
    public override bool IsAllowMultipleSameCharacters
    {
      [Token(Token = "0x600C433"), Address(RVA = "0x19F5DCC", Offset = "0x19F5DCC", VA = "0x19F5DCC", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C434")]
    [Address(RVA = "0x19F5DD4", Offset = "0x19F5DD4", VA = "0x19F5DD4", Slot = "23")]
    public override bool DifficultyType(out QuestDifficultyTypeEnum difficultyType) => new bool();

    [Token(Token = "0x600C435")]
    [Address(RVA = "0x19F5DE4", Offset = "0x19F5DE4", VA = "0x19F5DE4", Slot = "25")]
    public override bool IsCleared() => new bool();

    [Token(Token = "0x600C436")]
    [Address(RVA = "0x19F5DEC", Offset = "0x19F5DEC", VA = "0x19F5DEC", Slot = "24")]
    public override bool IsReleased() => new bool();

    [Token(Token = "0x170029E2")]
    public override int TotalClearCount
    {
      [Token(Token = "0x600C437"), Address(RVA = "0x19F5DF4", Offset = "0x19F5DF4", VA = "0x19F5DF4", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029E3")]
    public override int TodayClearCount
    {
      [Token(Token = "0x600C438"), Address(RVA = "0x19F5DFC", Offset = "0x19F5DFC", VA = "0x19F5DFC", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029E4")]
    public override int NumberOfClearsPerDay
    {
      [Token(Token = "0x600C439"), Address(RVA = "0x19F5E04", Offset = "0x19F5E04", VA = "0x19F5E04", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170029E5")]
    public int ConsumeCostItemId
    {
      [Token(Token = "0x600C43A"), Address(RVA = "0x19F5E0C", Offset = "0x19F5E0C", VA = "0x19F5E0C")] get
      {
        return new int();
      }
      [Token(Token = "0x600C43B"), Address(RVA = "0x19F5E14", Offset = "0x19F5E14", VA = "0x19F5E14")] private set
      {
      }
    }

    [Token(Token = "0x600C43C")]
    [Address(RVA = "0x19F4D60", Offset = "0x19F4D60", VA = "0x19F4D60")]
    public RaidQuestInfo(int questId)
    {
    }
  }
}
