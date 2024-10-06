// Decompiled with JetBrains decompiler
// Type: StaqData.StroySubQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002065")]
  public class StroySubQuestInfo : SubQuestInfoBase
  {
    [Token(Token = "0x40089E9")]
    [FieldOffset(Offset = "0x18")]
    private QuestStageData questStageData;
    [Token(Token = "0x40089EA")]
    [FieldOffset(Offset = "0x20")]
    private int releaseQuestId;
    [Token(Token = "0x40089EB")]
    [FieldOffset(Offset = "0x28")]
    private IReadOnlyList<BattleRewardDescriptionData> firstClearRewards;
    [Token(Token = "0x40089EC")]
    [FieldOffset(Offset = "0x30")]
    private IReadOnlyList<BattleRewardDescriptionData> clearRewards;
    [Token(Token = "0x40089ED")]
    [FieldOffset(Offset = "0x38")]
    private int numberOfClearsPerDay;
    [Token(Token = "0x40089EE")]
    [FieldOffset(Offset = "0x40")]
    private QuestInfoMissions mission;

    [Token(Token = "0x17002956")]
    public override bool IsNeedLp
    {
      [Token(Token = "0x600C372"), Address(RVA = "0x19F2E80", Offset = "0x19F2E80", VA = "0x19F2E80", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002957")]
    public override QuestTypeEnum QuestType
    {
      [Token(Token = "0x600C373"), Address(RVA = "0x19F2EA0", Offset = "0x19F2EA0", VA = "0x19F2EA0", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17002958")]
    public override int LoopCount
    {
      [Token(Token = "0x600C374"), Address(RVA = "0x19F2EA8", Offset = "0x19F2EA8", VA = "0x19F2EA8", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002959")]
    public override QuestStageData QuestStageData
    {
      [Token(Token = "0x600C375"), Address(RVA = "0x19F2EC8", Offset = "0x19F2EC8", VA = "0x19F2EC8", Slot = "10")] get
      {
        return (QuestStageData) null;
      }
    }

    [Token(Token = "0x1700295A")]
    public override IReadOnlyList<QuestMissionInfo> Missions
    {
      [Token(Token = "0x600C376"), Address(RVA = "0x19F2ED0", Offset = "0x19F2ED0", VA = "0x19F2ED0", Slot = "18")] get
      {
        return (IReadOnlyList<QuestMissionInfo>) null;
      }
    }

    [Token(Token = "0x1700295B")]
    public override IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards
    {
      [Token(Token = "0x600C377"), Address(RVA = "0x19F2EEC", Offset = "0x19F2EEC", VA = "0x19F2EEC", Slot = "19")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x1700295C")]
    public override IReadOnlyList<BattleRewardDescriptionData> ClearRewards
    {
      [Token(Token = "0x600C378"), Address(RVA = "0x19F2EF4", Offset = "0x19F2EF4", VA = "0x19F2EF4", Slot = "20")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x1700295D")]
    public override bool IsAllowMultipleSameCharacters
    {
      [Token(Token = "0x600C379"), Address(RVA = "0x19F2EFC", Offset = "0x19F2EFC", VA = "0x19F2EFC", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C37A")]
    [Address(RVA = "0x19F2F20", Offset = "0x19F2F20", VA = "0x19F2F20", Slot = "23")]
    public override bool DifficultyType(out QuestDifficultyTypeEnum difficultyType) => new bool();

    [Token(Token = "0x600C37B")]
    [Address(RVA = "0x19F2F30", Offset = "0x19F2F30", VA = "0x19F2F30", Slot = "24")]
    public override bool IsReleased() => new bool();

    [Token(Token = "0x600C37C")]
    [Address(RVA = "0x19F2F38", Offset = "0x19F2F38", VA = "0x19F2F38", Slot = "25")]
    public override bool IsCleared() => new bool();

    [Token(Token = "0x1700295E")]
    public override int TotalClearCount
    {
      [Token(Token = "0x600C37D"), Address(RVA = "0x19F2F40", Offset = "0x19F2F40", VA = "0x19F2F40", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700295F")]
    public override int TodayClearCount
    {
      [Token(Token = "0x600C37E"), Address(RVA = "0x19F2F48", Offset = "0x19F2F48", VA = "0x19F2F48", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002960")]
    public override int NumberOfClearsPerDay
    {
      [Token(Token = "0x600C37F"), Address(RVA = "0x19F2F50", Offset = "0x19F2F50", VA = "0x19F2F50", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C380")]
    [Address(RVA = "0x19F2F58", Offset = "0x19F2F58", VA = "0x19F2F58")]
    public StroySubQuestInfo(int questId, int subQuestTaskId)
    {
    }
  }
}
