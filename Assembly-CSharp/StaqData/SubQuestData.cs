// Decompiled with JetBrains decompiler
// Type: StaqData.SubQuestData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Story.Tracker;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020E9")]
  public class SubQuestData : ITrackingTargetQuest
  {
    [Token(Token = "0x4008B68")]
    [FieldOffset(Offset = "0x70")]
    private readonly List<SubQuestTaskInfo> tasks;

    [Token(Token = "0x17002AE2")]
    public int SubQuestID
    {
      [Token(Token = "0x600C746"), Address(RVA = "0x1CDD574", Offset = "0x1CDD574", VA = "0x1CDD574")] get
      {
        return new int();
      }
      [Token(Token = "0x600C747"), Address(RVA = "0x1CDD57C", Offset = "0x1CDD57C", VA = "0x1CDD57C")] private set
      {
      }
    }

    [Token(Token = "0x17002AE3")]
    public string Name
    {
      [Token(Token = "0x600C748"), Address(RVA = "0x1CDD584", Offset = "0x1CDD584", VA = "0x1CDD584")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600C749"), Address(RVA = "0x1CDD58C", Offset = "0x1CDD58C", VA = "0x1CDD58C")] private set
      {
      }
    }

    [Token(Token = "0x17002AE4")]
    public string Description
    {
      [Token(Token = "0x600C74A"), Address(RVA = "0x1CDD594", Offset = "0x1CDD594", VA = "0x1CDD594")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600C74B"), Address(RVA = "0x1CDD59C", Offset = "0x1CDD59C", VA = "0x1CDD59C")] private set
      {
      }
    }

    [Token(Token = "0x17002AE5")]
    public string Conditions
    {
      [Token(Token = "0x600C74C"), Address(RVA = "0x1CDD5A4", Offset = "0x1CDD5A4", VA = "0x1CDD5A4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600C74D"), Address(RVA = "0x1CDD5AC", Offset = "0x1CDD5AC", VA = "0x1CDD5AC")] private set
      {
      }
    }

    [Token(Token = "0x17002AE6")]
    public bool ShouldReset
    {
      [Token(Token = "0x600C74E"), Address(RVA = "0x1CDD5B4", Offset = "0x1CDD5B4", VA = "0x1CDD5B4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002AE7")]
    public SubQuestPeriod Period
    {
      [Token(Token = "0x600C74F"), Address(RVA = "0x1CDD5CC", Offset = "0x1CDD5CC", VA = "0x1CDD5CC")] get
      {
        return (SubQuestPeriod) null;
      }
      [Token(Token = "0x600C750"), Address(RVA = "0x1CDD5D4", Offset = "0x1CDD5D4", VA = "0x1CDD5D4")] private set
      {
      }
    }

    [Token(Token = "0x17002AE8")]
    public SubQuestCycle Cycle
    {
      [Token(Token = "0x600C751"), Address(RVA = "0x1CDD5DC", Offset = "0x1CDD5DC", VA = "0x1CDD5DC")] get
      {
        return (SubQuestCycle) null;
      }
      [Token(Token = "0x600C752"), Address(RVA = "0x1CDD5E4", Offset = "0x1CDD5E4", VA = "0x1CDD5E4")] private set
      {
      }
    }

    [Token(Token = "0x17002AE9")]
    public SubQuestClearReward ClearReward
    {
      [Token(Token = "0x600C753"), Address(RVA = "0x1CDD5EC", Offset = "0x1CDD5EC", VA = "0x1CDD5EC")] get
      {
        return (SubQuestClearReward) null;
      }
      [Token(Token = "0x600C754"), Address(RVA = "0x1CDD5F4", Offset = "0x1CDD5F4", VA = "0x1CDD5F4")] private set
      {
      }
    }

    [Token(Token = "0x17002AEA")]
    public int TotalClearCount
    {
      [Token(Token = "0x600C755"), Address(RVA = "0x1CDD5FC", Offset = "0x1CDD5FC", VA = "0x1CDD5FC")] get
      {
        return new int();
      }
      [Token(Token = "0x600C756"), Address(RVA = "0x1CDD604", Offset = "0x1CDD604", VA = "0x1CDD604")] private set
      {
      }
    }

    [Token(Token = "0x17002AEB")]
    public NPCInfo NPCInfo
    {
      [Token(Token = "0x600C757"), Address(RVA = "0x1CDD60C", Offset = "0x1CDD60C", VA = "0x1CDD60C")] get
      {
        return (NPCInfo) null;
      }
      [Token(Token = "0x600C758"), Address(RVA = "0x1CDD614", Offset = "0x1CDD614", VA = "0x1CDD614")] private set
      {
      }
    }

    [Token(Token = "0x17002AEC")]
    public SubQuestReceiptInfo ReceiptInfo
    {
      [Token(Token = "0x600C759"), Address(RVA = "0x1CDD61C", Offset = "0x1CDD61C", VA = "0x1CDD61C")] get
      {
        return (SubQuestReceiptInfo) null;
      }
      [Token(Token = "0x600C75A"), Address(RVA = "0x1CDD624", Offset = "0x1CDD624", VA = "0x1CDD624")] private set
      {
      }
    }

    [Token(Token = "0x17002AED")]
    public SubQuestCompleteInfo CompleteInfo
    {
      [Token(Token = "0x600C75B"), Address(RVA = "0x1CDD62C", Offset = "0x1CDD62C", VA = "0x1CDD62C")] get
      {
        return (SubQuestCompleteInfo) null;
      }
      [Token(Token = "0x600C75C"), Address(RVA = "0x1CDD634", Offset = "0x1CDD634", VA = "0x1CDD634")] private set
      {
      }
    }

    [Token(Token = "0x17002AEE")]
    public IEnumerable<SubQuestTaskInfo> Tasks
    {
      [Token(Token = "0x600C75D"), Address(RVA = "0x1CDD63C", Offset = "0x1CDD63C", VA = "0x1CDD63C")] get
      {
        return (IEnumerable<SubQuestTaskInfo>) null;
      }
    }

    [Token(Token = "0x17002AEF")]
    private int Story\u002ETracker\u002EITrackingTargetQuest\u002EUniqueKey
    {
      [Token(Token = "0x600C75E"), Address(RVA = "0x1CDD644", Offset = "0x1CDD644", VA = "0x1CDD644", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002AF0")]
    private string Story\u002ETracker\u002EITrackingTargetQuest\u002ETitle
    {
      [Token(Token = "0x600C75F"), Address(RVA = "0x1CDD64C", Offset = "0x1CDD64C", VA = "0x1CDD64C", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002AF1")]
    private bool Story\u002ETracker\u002EITrackingTargetQuest\u002EEnable
    {
      [Token(Token = "0x600C760"), Address(RVA = "0x1CDD654", Offset = "0x1CDD654", VA = "0x1CDD654", Slot = "6")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002AF2")]
    private bool Story\u002ETracker\u002EITrackingTargetQuest\u002ECompletable
    {
      [Token(Token = "0x600C761"), Address(RVA = "0x1CDD750", Offset = "0x1CDD750", VA = "0x1CDD750", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002AF3")]
    private bool Story\u002ETracker\u002EITrackingTargetQuest\u002ECompleted
    {
      [Token(Token = "0x600C762"), Address(RVA = "0x1CDD8F4", Offset = "0x1CDD8F4", VA = "0x1CDD8F4", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002AF4")]
    public bool IsInterimCompletable
    {
      [Token(Token = "0x600C763"), Address(RVA = "0x1CDD934", Offset = "0x1CDD934", VA = "0x1CDD934")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C764"), Address(RVA = "0x1CDD93C", Offset = "0x1CDD93C", VA = "0x1CDD93C")] set
      {
      }
    }

    [Token(Token = "0x17002AF5")]
    private ITrackingTargetQuestTaskProgress[] Story\u002ETracker\u002EITrackingTargetQuest\u002EProgresses
    {
      [Token(Token = "0x600C765"), Address(RVA = "0x1CDD948", Offset = "0x1CDD948", VA = "0x1CDD948", Slot = "9")] get
      {
        return (ITrackingTargetQuestTaskProgress[]) null;
      }
    }

    [Token(Token = "0x600C766")]
    [Address(RVA = "0x1CDDA54", Offset = "0x1CDDA54", VA = "0x1CDDA54")]
    public SubQuestTaskInfo GetTopicTask() => (SubQuestTaskInfo) null;

    [Token(Token = "0x17002AF6")]
    private ITrackingTargetQuestTaskProgress[] Story\u002ETracker\u002EITrackingTargetQuest\u002EAllProgresses
    {
      [Token(Token = "0x600C767"), Address(RVA = "0x1CDDB50", Offset = "0x1CDDB50", VA = "0x1CDDB50", Slot = "10")] get
      {
        return (ITrackingTargetQuestTaskProgress[]) null;
      }
    }

    [Token(Token = "0x17002AF7")]
    public int FlagStatus
    {
      [Token(Token = "0x600C768"), Address(RVA = "0x1CDDB98", Offset = "0x1CDDB98", VA = "0x1CDDB98")] get
      {
        return new int();
      }
      [Token(Token = "0x600C769"), Address(RVA = "0x1CDDBA0", Offset = "0x1CDDBA0", VA = "0x1CDDBA0")] private set
      {
      }
    }

    [Token(Token = "0x600C76A")]
    [Address(RVA = "0x1CDDBA8", Offset = "0x1CDDBA8", VA = "0x1CDDBA8")]
    public bool IsReceipableInCycle() => new bool();

    [Token(Token = "0x600C76B")]
    [Address(RVA = "0x1CDDC20", Offset = "0x1CDDC20", VA = "0x1CDDC20")]
    public bool IsReceipable() => new bool();

    [Token(Token = "0x600C76C")]
    [Address(RVA = "0x1CDDC54", Offset = "0x1CDDC54", VA = "0x1CDDC54")]
    private bool isConditionCommuRank() => new bool();

    [Token(Token = "0x600C76D")]
    [Address(RVA = "0x1CDDD00", Offset = "0x1CDDD00", VA = "0x1CDDD00")]
    private bool isConditionHumanRank() => new bool();

    [Token(Token = "0x17002AF8")]
    public bool IsReceipting
    {
      [Token(Token = "0x600C76E"), Address(RVA = "0x1CDDBFC", Offset = "0x1CDDBFC", VA = "0x1CDDBFC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002AF9")]
    public bool IsCompleted
    {
      [Token(Token = "0x600C76F"), Address(RVA = "0x1CDD914", Offset = "0x1CDD914", VA = "0x1CDD914")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002AFA")]
    private bool IsServerCompleted
    {
      [Token(Token = "0x600C770"), Address(RVA = "0x1CDDDA8", Offset = "0x1CDDDA8", VA = "0x1CDDDA8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C771"), Address(RVA = "0x1CDDDB0", Offset = "0x1CDDDB0", VA = "0x1CDDDB0")] set
      {
      }
    }

    [Token(Token = "0x17002AFB")]
    private bool IsServerReceipted
    {
      [Token(Token = "0x600C772"), Address(RVA = "0x1CDDDBC", Offset = "0x1CDDDBC", VA = "0x1CDDDBC")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C773"), Address(RVA = "0x1CDDDC4", Offset = "0x1CDDDC4", VA = "0x1CDDDC4")] set
      {
      }
    }

    [Token(Token = "0x600C774")]
    [Address(RVA = "0x1CDDC1C", Offset = "0x1CDDC1C", VA = "0x1CDDC1C")]
    public bool IsCompletedRequire() => new bool();

    [Token(Token = "0x600C775")]
    [Address(RVA = "0x1CDDDD0", Offset = "0x1CDDDD0", VA = "0x1CDDDD0")]
    public bool IsCompletedRequireQuest() => new bool();

    [Token(Token = "0x600C776")]
    [Address(RVA = "0x1CDD754", Offset = "0x1CDD754", VA = "0x1CDD754")]
    public bool IsCompletable() => new bool();

    [Token(Token = "0x600C777")]
    [Address(RVA = "0x1CDE254", Offset = "0x1CDE254", VA = "0x1CDE254")]
    public bool HasBattle() => new bool();

    [Token(Token = "0x600C778")]
    [Address(RVA = "0x1CDE55C", Offset = "0x1CDE55C", VA = "0x1CDE55C")]
    public bool HasValidBattle() => new bool();

    [Token(Token = "0x14000133")]
    public event Action<SubQuestData> OnChange
    {
      [Token(Token = "0x600C779"), Address(RVA = "0x1CDE874", Offset = "0x1CDE874", VA = "0x1CDE874")] add
      {
      }
      [Token(Token = "0x600C77A"), Address(RVA = "0x1CDE924", Offset = "0x1CDE924", VA = "0x1CDE924")] remove
      {
      }
    }

    [Token(Token = "0x600C77B")]
    [Address(RVA = "0x1CDE9D4", Offset = "0x1CDE9D4", VA = "0x1CDE9D4")]
    public SubQuestData(int subquestID)
    {
    }

    [Token(Token = "0x600C77C")]
    [Address(RVA = "0x1CDF118", Offset = "0x1CDF118", VA = "0x1CDF118")]
    public void Apply(PlayerStorySubQuestType res)
    {
    }

    [Token(Token = "0x17002AFC")]
    public StorySubquestData MasterData
    {
      [Token(Token = "0x600C77D"), Address(RVA = "0x1CDF178", Offset = "0x1CDF178", VA = "0x1CDF178")] get
      {
        return (StorySubquestData) null;
      }
      [Token(Token = "0x600C77E"), Address(RVA = "0x1CDF180", Offset = "0x1CDF180", VA = "0x1CDF180")] private set
      {
      }
    }

    [Token(Token = "0x600C77F")]
    [Address(RVA = "0x1CDEB34", Offset = "0x1CDEB34", VA = "0x1CDEB34")]
    private void OnInitialize(int lastReceiptSequenceID = 0)
    {
    }

    [Token(Token = "0x600C780")]
    [Address(RVA = "0x1CDF9BC", Offset = "0x1CDF9BC", VA = "0x1CDF9BC")]
    public void UpdateQuestCondition()
    {
    }

    [Token(Token = "0x600C781")]
    [Address(RVA = "0x1CDF9D4", Offset = "0x1CDF9D4", VA = "0x1CDF9D4")]
    private string GetConditionText() => (string) null;

    [Token(Token = "0x600C782")]
    [Address(RVA = "0x1CDFA7C", Offset = "0x1CDFA7C", VA = "0x1CDFA7C")]
    public IEnumerable<SubQuestData.ProgressStatus> GetProgresses()
    {
      return (IEnumerable<SubQuestData.ProgressStatus>) null;
    }

    [Token(Token = "0x20020EA")]
    public struct ProgressStatus
    {
      [Token(Token = "0x17002AFD")]
      public readonly int Current
      {
        [Token(Token = "0x600C783"), Address(RVA = "0x1CDFB94", Offset = "0x1CDFB94", VA = "0x1CDFB94")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002AFE")]
      public readonly int Max
      {
        [Token(Token = "0x600C784"), Address(RVA = "0x1CDFB9C", Offset = "0x1CDFB9C", VA = "0x1CDFB9C")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002AFF")]
      public readonly string ProgressText
      {
        [Token(Token = "0x600C785"), Address(RVA = "0x1CDFBA4", Offset = "0x1CDFBA4", VA = "0x1CDFBA4")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x17002B00")]
      public readonly int SubQuestTaskID
      {
        [Token(Token = "0x600C786"), Address(RVA = "0x1CDFBAC", Offset = "0x1CDFBAC", VA = "0x1CDFBAC")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002B01")]
      public bool IsComplete
      {
        [Token(Token = "0x600C787"), Address(RVA = "0x1CDE11C", Offset = "0x1CDE11C", VA = "0x1CDE11C")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600C788")]
      [Address(RVA = "0x1CDFBB4", Offset = "0x1CDFBB4", VA = "0x1CDFBB4")]
      public ProgressStatus(int current, int max, string progressText, int subQuestTaskId = 0)
      {
      }
    }
  }
}
