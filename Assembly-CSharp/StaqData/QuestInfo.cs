// Decompiled with JetBrains decompiler
// Type: StaqData.QuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200205A")]
  public abstract class QuestInfo
  {
    [Token(Token = "0x17002916")]
    public int QuestId
    {
      [Token(Token = "0x600C317"), Address(RVA = "0x19EFAF0", Offset = "0x19EFAF0", VA = "0x19EFAF0")] get
      {
        return new int();
      }
      [Token(Token = "0x600C318"), Address(RVA = "0x19EFAF8", Offset = "0x19EFAF8", VA = "0x19EFAF8")] private set
      {
      }
    }

    [Token(Token = "0x17002917")]
    public string QuestName
    {
      [Token(Token = "0x600C319"), Address(RVA = "0x19EFB00", Offset = "0x19EFB00", VA = "0x19EFB00")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002918")]
    public virtual string LockedQuestName
    {
      [Token(Token = "0x600C31A"), Address(RVA = "0x19EFB24", Offset = "0x19EFB24", VA = "0x19EFB24", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002919")]
    public virtual BattleComsumeCostTypeEnum ConsumeCostType
    {
      [Token(Token = "0x600C31B"), Address(RVA = "0x19EFB48", Offset = "0x19EFB48", VA = "0x19EFB48", Slot = "5")] get
      {
        return new BattleComsumeCostTypeEnum();
      }
    }

    [Token(Token = "0x1700291A")]
    public virtual int Ap
    {
      [Token(Token = "0x600C31C"), Address(RVA = "0x19EFBFC", Offset = "0x19EFBFC", VA = "0x19EFBFC", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700291B")]
    public abstract bool IsNeedLp { [Token(Token = "0x600C31D")] get; }

    [Token(Token = "0x1700291C")]
    public abstract QuestTypeEnum QuestType { [Token(Token = "0x600C31E")] get; }

    [Token(Token = "0x1700291D")]
    public virtual IQuestStage QuestStage
    {
      [Token(Token = "0x600C31F"), Address(RVA = "0x19EFCB0", Offset = "0x19EFCB0", VA = "0x19EFCB0", Slot = "9")] get
      {
        return (IQuestStage) null;
      }
    }

    [Token(Token = "0x1700291E")]
    public abstract QuestStageData QuestStageData { [Token(Token = "0x600C320")] get; }

    [Token(Token = "0x1700291F")]
    public abstract int LoopCount { [Token(Token = "0x600C321")] get; }

    [Token(Token = "0x17002920")]
    public virtual BattleData BattleData
    {
      [Token(Token = "0x600C322"), Address(RVA = "0x19EFCBC", Offset = "0x19EFCBC", VA = "0x19EFCBC", Slot = "12")] get
      {
        return (BattleData) null;
      }
    }

    [Token(Token = "0x17002921")]
    public virtual int RecommendedCombatPower
    {
      [Token(Token = "0x600C323"), Address(RVA = "0x19EFD70", Offset = "0x19EFD70", VA = "0x19EFD70", Slot = "13")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002922")]
    public virtual int QuestMapPosition
    {
      [Token(Token = "0x600C324"), Address(RVA = "0x19EFD90", Offset = "0x19EFD90", VA = "0x19EFD90", Slot = "14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002923")]
    public QuestMapPositionData QuestMapPositionData
    {
      [Token(Token = "0x600C325"), Address(RVA = "0x19EFDB4", Offset = "0x19EFDB4", VA = "0x19EFDB4")] get
      {
        return (QuestMapPositionData) null;
      }
    }

    [Token(Token = "0x17002924")]
    public abstract int TotalClearCount { [Token(Token = "0x600C326")] get; }

    [Token(Token = "0x17002925")]
    public abstract int TodayClearCount { [Token(Token = "0x600C327")] get; }

    [Token(Token = "0x17002926")]
    public abstract int NumberOfClearsPerDay { [Token(Token = "0x600C328")] get; }

    [Token(Token = "0x17002927")]
    public abstract IReadOnlyList<QuestMissionInfo> Missions { [Token(Token = "0x600C329")] get; }

    [Token(Token = "0x17002928")]
    public abstract IReadOnlyList<BattleRewardDescriptionData> FirstClearRewards { [Token(Token = "0x600C32A")] get; }

    [Token(Token = "0x17002929")]
    public abstract IReadOnlyList<BattleRewardDescriptionData> ClearRewards { [Token(Token = "0x600C32B")] get; }

    [Token(Token = "0x1700292A")]
    public abstract bool IsAllowMultipleSameCharacters { [Token(Token = "0x600C32C")] get; }

    [Token(Token = "0x1700292B")]
    public DeckTypeEnum RequiredDeckType
    {
      [Token(Token = "0x600C32D"), Address(RVA = "0x19EFE80", Offset = "0x19EFE80", VA = "0x19EFE80")] get
      {
        return new DeckTypeEnum();
      }
    }

    [Token(Token = "0x1700292C")]
    public virtual int NormalQuestId
    {
      [Token(Token = "0x600C32E"), Address(RVA = "0x19EFEDC", Offset = "0x19EFEDC", VA = "0x19EFEDC", Slot = "22")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C32F")]
    public abstract bool DifficultyType(out QuestDifficultyTypeEnum difficultyType);

    [Token(Token = "0x600C330")]
    public abstract bool IsReleased();

    [Token(Token = "0x600C331")]
    public abstract bool IsCleared();

    [Token(Token = "0x1700292D")]
    public int AchievedMissionCount
    {
      [Token(Token = "0x600C332"), Address(RVA = "0x19EFEE4", Offset = "0x19EFEE4", VA = "0x19EFEE4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700292E")]
    public bool HasMissions
    {
      [Token(Token = "0x600C333"), Address(RVA = "0x19F0280", Offset = "0x19F0280", VA = "0x19F0280")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C334")]
    [Address(RVA = "0x19F02D8", Offset = "0x19F02D8", VA = "0x19F02D8")]
    public bool IsMissionCompleted() => new bool();

    [Token(Token = "0x600C335")]
    [Address(RVA = "0x19F05FC", Offset = "0x19F05FC", VA = "0x19F05FC")]
    public bool CanSkip() => new bool();

    [Token(Token = "0x1700292F")]
    protected virtual bool CheckSkipConditionOnIgnoreState
    {
      [Token(Token = "0x600C336"), Address(RVA = "0x19F065C", Offset = "0x19F065C", VA = "0x19F065C", Slot = "26")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C337")]
    [Address(RVA = "0x19F0664", Offset = "0x19F0664", VA = "0x19F0664")]
    public bool IsRemainingChallengeCount() => new bool();

    [Token(Token = "0x600C338")]
    [Address(RVA = "0x19F06CC", Offset = "0x19F06CC", VA = "0x19F06CC")]
    protected QuestInfo(int questId)
    {
    }
  }
}
