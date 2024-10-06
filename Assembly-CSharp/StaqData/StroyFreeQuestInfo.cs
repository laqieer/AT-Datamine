// Decompiled with JetBrains decompiler
// Type: StaqData.StroyFreeQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002061")]
  public class StroyFreeQuestInfo : QuestInfo, HaveQuestDifficulty
  {
    [Token(Token = "0x40089DC")]
    [FieldOffset(Offset = "0x18")]
    private QuestStageData questStageData;
    [Token(Token = "0x40089DD")]
    [FieldOffset(Offset = "0x20")]
    private int releaseQuestId;
    [Token(Token = "0x40089DE")]
    [FieldOffset(Offset = "0x28")]
    private IReadOnlyList<BattleRewardDescriptionData> firstClearRewards;
    [Token(Token = "0x40089DF")]
    [FieldOffset(Offset = "0x30")]
    private IReadOnlyList<BattleRewardDescriptionData> clearRewards;
    [Token(Token = "0x40089E0")]
    [FieldOffset(Offset = "0x38")]
    private int numberOfClearsPerDay;
    [Token(Token = "0x40089E1")]
    [FieldOffset(Offset = "0x40")]
    private QuestInfoMissions mission;
    [Token(Token = "0x40089E2")]
    [FieldOffset(Offset = "0x48")]
    private int releaseMainQuestGruopId;
    [Token(Token = "0x40089E3")]
    [FieldOffset(Offset = "0x4C")]
    private int releaseConditionAreaNodeQuestGroupId;
    [Token(Token = "0x40089E4")]
    [FieldOffset(Offset = "0x50")]
    private QuestDifficultyTypeEnum difficultyType;
    [Token(Token = "0x40089E5")]
    [FieldOffset(Offset = "0x54")]
    private int questGroupId;

    [Token(Token = "0x17002944")]
    public override bool IsNeedLp
    {
      [Token(Token = "0x600C357"), Address(RVA = "0x19F1990", Offset = "0x19F1990", VA = "0x19F1990", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002945")]
    public override QuestTypeEnum QuestType
    {
      [Token(Token = "0x600C358"), Address(RVA = "0x19F19B0", Offset = "0x19F19B0", VA = "0x19F19B0", Slot = "8")] get
      {
        return new QuestTypeEnum();
      }
    }

    [Token(Token = "0x17002946")]
    public override int LoopCount
    {
      [Token(Token = "0x600C359"), Address(RVA = "0x19F19B8", Offset = "0x19F19B8", VA = "0x19F19B8", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002947")]
    public override QuestStageData QuestStageData
    {
      [Token(Token = "0x600C35A"), Address(RVA = "0x19F19D8", Offset = "0x19F19D8", VA = "0x19F19D8", Slot = "10")] get
      {
        return (QuestStageData) null;
      }
    }

    [Token(Token = "0x17002948")]
    public override IReadOnlyList<QuestMissionInfo> Missions
    {
      [Token(Token = "0x600C35B"), Address(RVA = "0x19F19E0", Offset = "0x19F19E0", VA = "0x19F19E0", Slot = "18")] get
      {
        return (IReadOnlyList<QuestMissionInfo>) null;
      }
    }

    [Token(Token = "0x17002949")]
    public override IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards
    {
      [Token(Token = "0x600C35C"), Address(RVA = "0x19F19FC", Offset = "0x19F19FC", VA = "0x19F19FC", Slot = "19")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x1700294A")]
    public override IReadOnlyList<BattleRewardDescriptionData> ClearRewards
    {
      [Token(Token = "0x600C35D"), Address(RVA = "0x19F1A04", Offset = "0x19F1A04", VA = "0x19F1A04", Slot = "20")] get
      {
        return (IReadOnlyList<BattleRewardDescriptionData>) null;
      }
    }

    [Token(Token = "0x1700294B")]
    public override bool IsAllowMultipleSameCharacters
    {
      [Token(Token = "0x600C35E"), Address(RVA = "0x19F1A0C", Offset = "0x19F1A0C", VA = "0x19F1A0C", Slot = "21")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700294C")]
    public override string LockedQuestName
    {
      [Token(Token = "0x600C35F"), Address(RVA = "0x19F1A30", Offset = "0x19F1A30", VA = "0x19F1A30", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700294D")]
    protected override bool CheckSkipConditionOnIgnoreState
    {
      [Token(Token = "0x600C360"), Address(RVA = "0x19F232C", Offset = "0x19F232C", VA = "0x19F232C", Slot = "26")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700294E")]
    public override int NormalQuestId
    {
      [Token(Token = "0x600C361"), Address(RVA = "0x19F2354", Offset = "0x19F2354", VA = "0x19F2354", Slot = "22")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C362")]
    [Address(RVA = "0x19F24D8", Offset = "0x19F24D8", VA = "0x19F24D8", Slot = "23")]
    public override bool DifficultyType(out QuestDifficultyTypeEnum difficultyType) => new bool();

    [Token(Token = "0x600C363")]
    [Address(RVA = "0x19F2594", Offset = "0x19F2594", VA = "0x19F2594", Slot = "24")]
    public override bool IsReleased() => new bool();

    [Token(Token = "0x600C364")]
    [Address(RVA = "0x19F2C48", Offset = "0x19F2C48", VA = "0x19F2C48", Slot = "25")]
    public override bool IsCleared() => new bool();

    [Token(Token = "0x1700294F")]
    public override int TotalClearCount
    {
      [Token(Token = "0x600C365"), Address(RVA = "0x19F2C50", Offset = "0x19F2C50", VA = "0x19F2C50", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002950")]
    public override int TodayClearCount
    {
      [Token(Token = "0x600C366"), Address(RVA = "0x19F2C58", Offset = "0x19F2C58", VA = "0x19F2C58", Slot = "16")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002951")]
    public override int NumberOfClearsPerDay
    {
      [Token(Token = "0x600C367"), Address(RVA = "0x19F2C60", Offset = "0x19F2C60", VA = "0x19F2C60", Slot = "17")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002952")]
    private QuestDifficultyTypeEnum StaqData\u002EHaveQuestDifficulty\u002EDifficultyType
    {
      [Token(Token = "0x600C368"), Address(RVA = "0x19F2C68", Offset = "0x19F2C68", VA = "0x19F2C68", Slot = "28")] get
      {
        return new QuestDifficultyTypeEnum();
      }
    }

    [Token(Token = "0x17002953")]
    private int StaqData\u002EHaveQuestDifficulty\u002EQuestGroupId
    {
      [Token(Token = "0x600C369"), Address(RVA = "0x19F2C70", Offset = "0x19F2C70", VA = "0x19F2C70", Slot = "27")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C36A")]
    [Address(RVA = "0x19F2C78", Offset = "0x19F2C78", VA = "0x19F2C78")]
    public StroyFreeQuestInfo(int questId)
    {
    }
  }
}
