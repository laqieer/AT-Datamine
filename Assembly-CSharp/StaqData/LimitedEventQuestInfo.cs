// Decompiled with JetBrains decompiler
// Type: StaqData.LimitedEventQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200206B")]
  public class LimitedEventQuestInfo : QuestInfo
  {
    [Token(Token = "0x4008A07")]
    [FieldOffset(Offset = "0x18")]
    private LimitedEventQuestStageData limitedEventQuestStageData;
    [Token(Token = "0x4008A08")]
    [FieldOffset(Offset = "0x20")]
    private QuestStageData questStageData;
    [Token(Token = "0x4008A09")]
    [FieldOffset(Offset = "0x28")]
    private int releaseQuestId;
    [Token(Token = "0x4008A0A")]
    [FieldOffset(Offset = "0x30")]
    private IReadOnlyList<BattleRewardDescriptionData> firstClearRewards;
    [Token(Token = "0x4008A0B")]
    [FieldOffset(Offset = "0x38")]
    private IReadOnlyList<BattleRewardDescriptionData> clearRewards;
    [Token(Token = "0x4008A0C")]
    [FieldOffset(Offset = "0x40")]
    private QuestInfoMissions mission;
    [Token(Token = "0x4008A0E")]
    [FieldOffset(Offset = "0x4C")]
    private BattleComsumeCostTypeEnum consumeCostType;

    [Token(Token = "0x17002992")]
    public LimitedEventQuestStageData LimitedEventQuestStageData
    {
      [Token(Token = "0x600C3C7"), Address(RVA = "0x19F4F64", Offset = "0x19F4F64", VA = "0x19F4F64")] get
      {
        return (LimitedEventQuestStageData) null;
      }
    }

    [Token(Token = "0x17002993")]
    public LimitedEventData LimitedEventData
    {
      [Token(Token = "0x600C3C8"), Address(RVA = "0x19F4F6C", Offset = "0x19F4F6C", VA = "0x19F4F6C")] get
      {
        return (LimitedEventData) null;
      }
    }

    [Token(Token = "0x17002994")]
    public override bool IsNeedLp
    {
      [Token(Token = "0x600C3C9"), Address(RVA = "0x19F5074", Offset = "0x19F5074", VA = "0x19F5074", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002995")]
    public override QuestTypeEnum QuestType
    {
      [Token(Token = "0x600C3CA"), Address(RVA = "0x19F5094", Offset = "0x19F5094", VA = "0x19F5094", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17002996")]
    public override int LoopCount
    {
      [Token(Token = "0x600C3CB"), Address(RVA = "0x19F50B0", Offset = "0x19F50B0", VA = "0x19F50B0", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002997")]
    public override QuestStageData QuestStageData
    {
      [Token(Token = "0x600C3CC"), Address(RVA = "0x19F50B8", Offset = "0x19F50B8", VA = "0x19F50B8", Slot = "10")] get
      {
        return (QuestStageData) null;
      }
    }

    [Token(Token = "0x17002998")]
    protected override bool CheckSkipConditionOnIgnoreState
    {
      [Token(Token = "0x600C3CD"), Address(RVA = "0x19F50C0", Offset = "0x19F50C0", VA = "0x19F50C0", Slot = "26")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C3CE")]
    [Address(RVA = "0x19F50E8", Offset = "0x19F50E8", VA = "0x19F50E8", Slot = "23")]
    public override bool DifficultyType(out QuestDifficultyTypeEnum difficultyType) => new bool();

    [Token(Token = "0x600C3CF")]
    [Address(RVA = "0x19F50F8", Offset = "0x19F50F8", VA = "0x19F50F8", Slot = "24")]
    public override bool IsReleased() => new bool();

    [Token(Token = "0x600C3D0")]
    [Address(RVA = "0x19F5100", Offset = "0x19F5100", VA = "0x19F5100", Slot = "25")]
    public override bool IsCleared() => new bool();

    [Token(Token = "0x17002999")]
    public override int TotalClearCount
    {
      [Token(Token = "0x600C3D1"), Address(RVA = "0x19F5108", Offset = "0x19F5108", VA = "0x19F5108", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700299A")]
    public override int TodayClearCount
    {
      [Token(Token = "0x600C3D2"), Address(RVA = "0x19F5110", Offset = "0x19F5110", VA = "0x19F5110", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700299B")]
    public override int NumberOfClearsPerDay
    {
      [Token(Token = "0x600C3D3"), Address(RVA = "0x19F5118", Offset = "0x19F5118", VA = "0x19F5118", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700299C")]
    public override IReadOnlyList<QuestMissionInfo> Missions
    {
      [Token(Token = "0x600C3D4"), Address(RVA = "0x19F5120", Offset = "0x19F5120", VA = "0x19F5120", Slot = "18")] get
      {
        return (IReadOnlyList<QuestMissionInfo>) null;
      }
    }

    [Token(Token = "0x1700299D")]
    public override IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards
    {
      [Token(Token = "0x600C3D5"), Address(RVA = "0x19F513C", Offset = "0x19F513C", VA = "0x19F513C", Slot = "19")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x1700299E")]
    public override IReadOnlyList<BattleRewardDescriptionData> ClearRewards
    {
      [Token(Token = "0x600C3D6"), Address(RVA = "0x19F5144", Offset = "0x19F5144", VA = "0x19F5144", Slot = "20")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x1700299F")]
    public override bool IsAllowMultipleSameCharacters
    {
      [Token(Token = "0x600C3D7"), Address(RVA = "0x19F514C", Offset = "0x19F514C", VA = "0x19F514C", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170029A0")]
    public int ConsumeCostItemId
    {
      [Token(Token = "0x600C3D8"), Address(RVA = "0x19F5170", Offset = "0x19F5170", VA = "0x19F5170")] get
      {
        return new int();
      }
      [Token(Token = "0x600C3D9"), Address(RVA = "0x19F5178", Offset = "0x19F5178", VA = "0x19F5178")] private set
      {
      }
    }

    [Token(Token = "0x170029A1")]
    public override BattleComsumeCostTypeEnum ConsumeCostType
    {
      [Token(Token = "0x600C3DA"), Address(RVA = "0x19F5180", Offset = "0x19F5180", VA = "0x19F5180", Slot = "5")] get
      {
        return new BattleComsumeCostTypeEnum();
      }
    }

    [Token(Token = "0x600C3DB")]
    [Address(RVA = "0x19F4708", Offset = "0x19F4708", VA = "0x19F4708")]
    public LimitedEventQuestInfo(int questId, int consumeCostItemId = -1)
    {
    }
  }
}
