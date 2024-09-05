// Decompiled with JetBrains decompiler
// Type: StaqData.ObliviaeQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002066")]
  public class ObliviaeQuestInfo : QuestInfo, StroyMainQuestStoryParam, HaveReleaseDisplayTextMethod
  {
    [Token(Token = "0x40089EF")]
    [FieldOffset(Offset = "0x18")]
    private QuestStageData questStageData;
    [Token(Token = "0x40089F0")]
    [FieldOffset(Offset = "0x20")]
    private IReadOnlyList<BattleRewardDescriptionData> firstClearRewards;
    [Token(Token = "0x40089F1")]
    [FieldOffset(Offset = "0x28")]
    private IReadOnlyList<BattleRewardDescriptionData> clearRewards;
    [Token(Token = "0x40089F2")]
    [FieldOffset(Offset = "0x30")]
    private int numberOfClearsPerDay;
    [Token(Token = "0x40089F3")]
    [FieldOffset(Offset = "0x38")]
    private QuestInfoMissions mission;

    [Token(Token = "0x17002961")]
    public override bool IsNeedLp
    {
      [Token(Token = "0x600C381"), Address(RVA = "0x19F3084", Offset = "0x19F3084", VA = "0x19F3084", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002962")]
    public override QuestTypeEnum QuestType
    {
      [Token(Token = "0x600C382"), Address(RVA = "0x19F30A4", Offset = "0x19F30A4", VA = "0x19F30A4", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17002963")]
    public override int LoopCount
    {
      [Token(Token = "0x600C383"), Address(RVA = "0x19F30AC", Offset = "0x19F30AC", VA = "0x19F30AC", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002964")]
    public override QuestStageData QuestStageData
    {
      [Token(Token = "0x600C384"), Address(RVA = "0x19F30CC", Offset = "0x19F30CC", VA = "0x19F30CC", Slot = "10")] get
      {
        return (QuestStageData) null;
      }
    }

    [Token(Token = "0x17002965")]
    public override IReadOnlyList<QuestMissionInfo> Missions
    {
      [Token(Token = "0x600C385"), Address(RVA = "0x19F30D4", Offset = "0x19F30D4", VA = "0x19F30D4", Slot = "18")] get
      {
        return (IReadOnlyList<QuestMissionInfo>) null;
      }
    }

    [Token(Token = "0x17002966")]
    public override IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards
    {
      [Token(Token = "0x600C386"), Address(RVA = "0x19F30F0", Offset = "0x19F30F0", VA = "0x19F30F0", Slot = "19")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x17002967")]
    public override IReadOnlyList<BattleRewardDescriptionData> ClearRewards
    {
      [Token(Token = "0x600C387"), Address(RVA = "0x19F30F8", Offset = "0x19F30F8", VA = "0x19F30F8", Slot = "20")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x17002968")]
    public override bool IsAllowMultipleSameCharacters
    {
      [Token(Token = "0x600C388"), Address(RVA = "0x19F3100", Offset = "0x19F3100", VA = "0x19F3100", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C389")]
    [Address(RVA = "0x19F3124", Offset = "0x19F3124", VA = "0x19F3124", Slot = "23")]
    public override bool DifficultyType(out QuestDifficultyTypeEnum difficultyType) => new bool();

    [Token(Token = "0x600C38A")]
    [Address(RVA = "0x19F3134", Offset = "0x19F3134", VA = "0x19F3134", Slot = "24")]
    public override bool IsReleased() => new bool();

    [Token(Token = "0x600C38B")]
    [Address(RVA = "0x19F337C", Offset = "0x19F337C", VA = "0x19F337C", Slot = "28")]
    private string StaqData\u002EHaveReleaseDisplayTextMethod\u002EGetReleaseDisplayText()
    {
      return (string) null;
    }

    [Token(Token = "0x600C38C")]
    [Address(RVA = "0x19F38EC", Offset = "0x19F38EC", VA = "0x19F38EC", Slot = "25")]
    public override bool IsCleared() => new bool();

    [Token(Token = "0x17002969")]
    public override int TotalClearCount
    {
      [Token(Token = "0x600C38D"), Address(RVA = "0x19F38F4", Offset = "0x19F38F4", VA = "0x19F38F4", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700296A")]
    public override int TodayClearCount
    {
      [Token(Token = "0x600C38E"), Address(RVA = "0x19F38FC", Offset = "0x19F38FC", VA = "0x19F38FC", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700296B")]
    public override int NumberOfClearsPerDay
    {
      [Token(Token = "0x600C38F"), Address(RVA = "0x19F3904", Offset = "0x19F3904", VA = "0x19F3904", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700296C")]
    public int ChapterId
    {
      [Token(Token = "0x600C390"), Address(RVA = "0x19F390C", Offset = "0x19F390C", VA = "0x19F390C", Slot = "27")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700296D")]
    private StoryObliviaeQuestData obliviaeQuestData
    {
      [Token(Token = "0x600C391"), Address(RVA = "0x19F3924", Offset = "0x19F3924", VA = "0x19F3924")] get
      {
        return (StoryObliviaeQuestData) null;
      }
      [Token(Token = "0x600C392"), Address(RVA = "0x19F392C", Offset = "0x19F392C", VA = "0x19F392C")] set
      {
      }
    }

    [Token(Token = "0x600C393")]
    [Address(RVA = "0x19F3934", Offset = "0x19F3934", VA = "0x19F3934")]
    public ObliviaeQuestInfo(int questId)
    {
    }
  }
}
