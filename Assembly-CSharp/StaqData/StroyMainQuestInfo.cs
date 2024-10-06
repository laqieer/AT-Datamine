// Decompiled with JetBrains decompiler
// Type: StaqData.StroyMainQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200205F")]
  public class StroyMainQuestInfo : QuestInfo, StroyMainQuestStoryParam, HaveQuestDifficulty
  {
    [Token(Token = "0x40089D2")]
    [FieldOffset(Offset = "0x18")]
    private QuestStageData questStageData;
    [Token(Token = "0x40089D3")]
    [FieldOffset(Offset = "0x20")]
    private int releaseQuestId;
    [Token(Token = "0x40089D4")]
    [FieldOffset(Offset = "0x28")]
    private IReadOnlyList<BattleRewardDescriptionData> firstClearRewards;
    [Token(Token = "0x40089D5")]
    [FieldOffset(Offset = "0x30")]
    private IReadOnlyList<BattleRewardDescriptionData> clearRewards;
    [Token(Token = "0x40089D6")]
    [FieldOffset(Offset = "0x38")]
    private int numberOfClearsPerDay;
    [Token(Token = "0x40089D7")]
    [FieldOffset(Offset = "0x40")]
    private QuestInfoMissions mission;
    [Token(Token = "0x40089D8")]
    [FieldOffset(Offset = "0x48")]
    private QuestDifficultyTypeEnum difficultyType;
    [Token(Token = "0x40089D9")]
    [FieldOffset(Offset = "0x4C")]
    private int questGroupId;

    [Token(Token = "0x17002935")]
    public override bool IsNeedLp
    {
      [Token(Token = "0x600C341"), Address(RVA = "0x19F06F4", Offset = "0x19F06F4", VA = "0x19F06F4", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002936")]
    public override QuestTypeEnum QuestType
    {
      [Token(Token = "0x600C342"), Address(RVA = "0x19F072C", Offset = "0x19F072C", VA = "0x19F072C", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17002937")]
    public override int LoopCount
    {
      [Token(Token = "0x600C343"), Address(RVA = "0x19F0734", Offset = "0x19F0734", VA = "0x19F0734", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002938")]
    public override QuestStageData QuestStageData
    {
      [Token(Token = "0x600C344"), Address(RVA = "0x19F08C8", Offset = "0x19F08C8", VA = "0x19F08C8", Slot = "10")] get
      {
        return (QuestStageData) null;
      }
    }

    [Token(Token = "0x17002939")]
    public override IReadOnlyList<QuestMissionInfo> Missions
    {
      [Token(Token = "0x600C345"), Address(RVA = "0x19F08D0", Offset = "0x19F08D0", VA = "0x19F08D0", Slot = "18")] get
      {
        return (IReadOnlyList<QuestMissionInfo>) null;
      }
    }

    [Token(Token = "0x1700293A")]
    public override IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards
    {
      [Token(Token = "0x600C346"), Address(RVA = "0x19F08EC", Offset = "0x19F08EC", VA = "0x19F08EC", Slot = "19")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x1700293B")]
    public override IReadOnlyList<BattleRewardDescriptionData> ClearRewards
    {
      [Token(Token = "0x600C347"), Address(RVA = "0x19F08F4", Offset = "0x19F08F4", VA = "0x19F08F4", Slot = "20")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x1700293C")]
    public override bool IsAllowMultipleSameCharacters
    {
      [Token(Token = "0x600C348"), Address(RVA = "0x19F08FC", Offset = "0x19F08FC", VA = "0x19F08FC", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700293D")]
    public override int NormalQuestId
    {
      [Token(Token = "0x600C349"), Address(RVA = "0x19F0920", Offset = "0x19F0920", VA = "0x19F0920", Slot = "22")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C34A")]
    [Address(RVA = "0x19F0AA4", Offset = "0x19F0AA4", VA = "0x19F0AA4", Slot = "23")]
    public override bool DifficultyType(out QuestDifficultyTypeEnum difficultyType) => new bool();

    [Token(Token = "0x600C34B")]
    [Address(RVA = "0x19F0B60", Offset = "0x19F0B60", VA = "0x19F0B60", Slot = "24")]
    public override bool IsReleased() => new bool();

    [Token(Token = "0x600C34C")]
    [Address(RVA = "0x19F0C74", Offset = "0x19F0C74", VA = "0x19F0C74", Slot = "25")]
    public override bool IsCleared() => new bool();

    [Token(Token = "0x1700293E")]
    public override int TotalClearCount
    {
      [Token(Token = "0x600C34D"), Address(RVA = "0x19F0D18", Offset = "0x19F0D18", VA = "0x19F0D18", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700293F")]
    public override int TodayClearCount
    {
      [Token(Token = "0x600C34E"), Address(RVA = "0x19F0DB4", Offset = "0x19F0DB4", VA = "0x19F0DB4", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002940")]
    public override int NumberOfClearsPerDay
    {
      [Token(Token = "0x600C34F"), Address(RVA = "0x19F0E50", Offset = "0x19F0E50", VA = "0x19F0E50", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002941")]
    public int ChapterId
    {
      [Token(Token = "0x600C350"), Address(RVA = "0x19F0E58", Offset = "0x19F0E58", VA = "0x19F0E58", Slot = "27")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002942")]
    private QuestDifficultyTypeEnum StaqData\u002EHaveQuestDifficulty\u002EDifficultyType
    {
      [Token(Token = "0x600C351"), Address(RVA = "0x19F0E70", Offset = "0x19F0E70", VA = "0x19F0E70", Slot = "29")] get
      {
        return new QuestDifficultyTypeEnum();
      }
    }

    [Token(Token = "0x17002943")]
    private int StaqData\u002EHaveQuestDifficulty\u002EQuestGroupId
    {
      [Token(Token = "0x600C352"), Address(RVA = "0x19F0E78", Offset = "0x19F0E78", VA = "0x19F0E78", Slot = "28")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C353")]
    [Address(RVA = "0x19F0E80", Offset = "0x19F0E80", VA = "0x19F0E80")]
    public StroyMainQuestInfo(int questId)
    {
    }
  }
}
