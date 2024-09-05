// Decompiled with JetBrains decompiler
// Type: StaqData.AreaEvent.AreaEventQuestData
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
namespace StaqData.AreaEvent
{
  [Token(Token = "0x2002152")]
  public class AreaEventQuestData : ITrackingTargetQuest
  {
    [Token(Token = "0x4008D42")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, AreaEventQuestTask> tasks;

    [Token(Token = "0x17002CAC")]
    public int ID
    {
      [Token(Token = "0x600CC1E"), Address(RVA = "0x1BABDFC", Offset = "0x1BABDFC", VA = "0x1BABDFC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CAD")]
    public int NextQuestID
    {
      [Token(Token = "0x600CC1F"), Address(RVA = "0x1BABE18", Offset = "0x1BABE18", VA = "0x1BABE18")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CAE")]
    public ADVIDs ADVIDs
    {
      [Token(Token = "0x600CC20"), Address(RVA = "0x1BABE34", Offset = "0x1BABE34", VA = "0x1BABE34")] get
      {
        return (ADVIDs) null;
      }
      [Token(Token = "0x600CC21"), Address(RVA = "0x1BABE3C", Offset = "0x1BABE3C", VA = "0x1BABE3C")] private set
      {
      }
    }

    [Token(Token = "0x17002CAF")]
    public AreaEventQuestData RequireQuest
    {
      [Token(Token = "0x600CC22"), Address(RVA = "0x1BABE44", Offset = "0x1BABE44", VA = "0x1BABE44")] get
      {
        return (AreaEventQuestData) null;
      }
      [Token(Token = "0x600CC23"), Address(RVA = "0x1BABE4C", Offset = "0x1BABE4C", VA = "0x1BABE4C")] set
      {
      }
    }

    [Token(Token = "0x17002CB0")]
    public IEnumerable<AreaEventQuestTask> Tasks
    {
      [Token(Token = "0x600CC24"), Address(RVA = "0x1BABE54", Offset = "0x1BABE54", VA = "0x1BABE54")] get
      {
        return (IEnumerable<AreaEventQuestTask>) null;
      }
    }

    [Token(Token = "0x600CC25")]
    [Address(RVA = "0x1BABEA4", Offset = "0x1BABEA4", VA = "0x1BABEA4")]
    public AreaEventQuestTask ActiveTask() => (AreaEventQuestTask) null;

    [Token(Token = "0x17002CB1")]
    public StoryAreaEventQuestData MasterQuestData
    {
      [Token(Token = "0x600CC26"), Address(RVA = "0x1BABFCC", Offset = "0x1BABFCC", VA = "0x1BABFCC")] get
      {
        return (StoryAreaEventQuestData) null;
      }
      [Token(Token = "0x600CC27"), Address(RVA = "0x1BABFD4", Offset = "0x1BABFD4", VA = "0x1BABFD4")] private set
      {
      }
    }

    [Token(Token = "0x17002CB2")]
    private PlayerStoryAreaEventQuestType serverResponse
    {
      [Token(Token = "0x600CC28"), Address(RVA = "0x1BABFDC", Offset = "0x1BABFDC", VA = "0x1BABFDC")] get
      {
        return (PlayerStoryAreaEventQuestType) null;
      }
      [Token(Token = "0x600CC29"), Address(RVA = "0x1BABFE4", Offset = "0x1BABFE4", VA = "0x1BABFE4")] set
      {
      }
    }

    [Token(Token = "0x17002CB3")]
    private int Flags
    {
      [Token(Token = "0x600CC2A"), Address(RVA = "0x1BABFEC", Offset = "0x1BABFEC", VA = "0x1BABFEC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CB4")]
    public int TotalCompleteCount
    {
      [Token(Token = "0x600CC2B"), Address(RVA = "0x1BAC004", Offset = "0x1BAC004", VA = "0x1BAC004")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CB5")]
    public IEnumerable<StoryAreaEventQuestTaskData> MasterTaskDataList
    {
      [Token(Token = "0x600CC2C"), Address(RVA = "0x1BAC01C", Offset = "0x1BAC01C", VA = "0x1BAC01C")] get
      {
        return (IEnumerable<StoryAreaEventQuestTaskData>) null;
      }
    }

    [Token(Token = "0x17002CB6")]
    public IEnumerable<StoryAreaEventQuestTaskData> MasterTaskProgressDataList
    {
      [Token(Token = "0x600CC2D"), Address(RVA = "0x1BAC0AC", Offset = "0x1BAC0AC", VA = "0x1BAC0AC")] get
      {
        return (IEnumerable<StoryAreaEventQuestTaskData>) null;
      }
    }

    [Token(Token = "0x17002CB7")]
    public StoryAreaEventQuestTaskData MasterTaskReceiptData
    {
      [Token(Token = "0x600CC2E"), Address(RVA = "0x1BAC1B8", Offset = "0x1BAC1B8", VA = "0x1BAC1B8")] get
      {
        return (StoryAreaEventQuestTaskData) null;
      }
    }

    [Token(Token = "0x17002CB8")]
    public StoryAreaEventQuestTaskData MasterTaskCompleteData
    {
      [Token(Token = "0x600CC2F"), Address(RVA = "0x1BAC2C4", Offset = "0x1BAC2C4", VA = "0x1BAC2C4")] get
      {
        return (StoryAreaEventQuestTaskData) null;
      }
    }

    [Token(Token = "0x14000134")]
    public event Action<AreaEventQuestData> OnChange
    {
      [Token(Token = "0x600CC30"), Address(RVA = "0x1BAC3D0", Offset = "0x1BAC3D0", VA = "0x1BAC3D0")] add
      {
      }
      [Token(Token = "0x600CC31"), Address(RVA = "0x1BAC480", Offset = "0x1BAC480", VA = "0x1BAC480")] remove
      {
      }
    }

    [Token(Token = "0x600CC32")]
    [Address(RVA = "0x1BAC530", Offset = "0x1BAC530", VA = "0x1BAC530")]
    public AreaEventQuestData(StoryAreaEventQuestData masterQuestData)
    {
    }

    [Token(Token = "0x600CC33")]
    [Address(RVA = "0x1BACD7C", Offset = "0x1BACD7C", VA = "0x1BACD7C")]
    public AreaEventQuestData(PlayerStoryAreaEventQuestType response)
    {
    }

    [Token(Token = "0x600CC34")]
    [Address(RVA = "0x1BAC60C", Offset = "0x1BAC60C", VA = "0x1BAC60C")]
    private void SetTasks(PlayerStoryAreaEventQuestType response)
    {
    }

    [Token(Token = "0x600CC35")]
    [Address(RVA = "0x1BACF8C", Offset = "0x1BACF8C", VA = "0x1BACF8C")]
    public AreaEventQuestData.Status GetStatus() => new AreaEventQuestData.Status();

    [Token(Token = "0x17002CB9")]
    public bool IsReceipting
    {
      [Token(Token = "0x600CC36"), Address(RVA = "0x1BACFFC", Offset = "0x1BACFFC", VA = "0x1BACFFC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002CBA")]
    public bool IsCompleted
    {
      [Token(Token = "0x600CC37"), Address(RVA = "0x1BACFDC", Offset = "0x1BACFDC", VA = "0x1BACFDC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002CBB")]
    private int Story\u002ETracker\u002EITrackingTargetQuest\u002EUniqueKey
    {
      [Token(Token = "0x600CC38"), Address(RVA = "0x1BAD064", Offset = "0x1BAD064", VA = "0x1BAD064", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CBC")]
    private string Story\u002ETracker\u002EITrackingTargetQuest\u002ETitle
    {
      [Token(Token = "0x600CC39"), Address(RVA = "0x1BAD080", Offset = "0x1BAD080", VA = "0x1BAD080", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002CBD")]
    private bool Story\u002ETracker\u002EITrackingTargetQuest\u002EEnable
    {
      [Token(Token = "0x600CC3A"), Address(RVA = "0x1BAD09C", Offset = "0x1BAD09C", VA = "0x1BAD09C", Slot = "6")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002CBE")]
    private bool Story\u002ETracker\u002EITrackingTargetQuest\u002ECompletable
    {
      [Token(Token = "0x600CC3B"), Address(RVA = "0x1BAD0DC", Offset = "0x1BAD0DC", VA = "0x1BAD0DC", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002CBF")]
    private bool Story\u002ETracker\u002EITrackingTargetQuest\u002ECompleted
    {
      [Token(Token = "0x600CC3C"), Address(RVA = "0x1BAD348", Offset = "0x1BAD348", VA = "0x1BAD348", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002CC0")]
    public ITrackingTargetQuestTaskProgress[] Progresses
    {
      [Token(Token = "0x600CC3D"), Address(RVA = "0x1BAD368", Offset = "0x1BAD368", VA = "0x1BAD368", Slot = "9")] get
      {
        return (ITrackingTargetQuestTaskProgress[]) null;
      }
    }

    [Token(Token = "0x17002CC1")]
    public ITrackingTargetQuestTaskProgress[] AllProgresses
    {
      [Token(Token = "0x600CC3E"), Address(RVA = "0x1BAD490", Offset = "0x1BAD490", VA = "0x1BAD490", Slot = "10")] get
      {
        return (ITrackingTargetQuestTaskProgress[]) null;
      }
    }

    [Token(Token = "0x600CC3F")]
    [Address(RVA = "0x1BAD024", Offset = "0x1BAD024", VA = "0x1BAD024")]
    public bool IsActive() => new bool();

    [Token(Token = "0x600CC40")]
    [Address(RVA = "0x1BAD0E0", Offset = "0x1BAD0E0", VA = "0x1BAD0E0")]
    public bool IsCompletable() => new bool();

    [Token(Token = "0x600CC41")]
    [Address(RVA = "0x1BAD58C", Offset = "0x1BAD58C", VA = "0x1BAD58C")]
    public bool IsActive(int flagCheckID) => new bool();

    [Token(Token = "0x600CC42")]
    [Address(RVA = "0x1BAD658", Offset = "0x1BAD658", VA = "0x1BAD658")]
    public void SetRequireQuest(AreaEventQuestData requireQuest)
    {
    }

    [Token(Token = "0x600CC43")]
    [Address(RVA = "0x1BACEE4", Offset = "0x1BACEE4", VA = "0x1BACEE4")]
    public void Apply(PlayerStoryAreaEventQuestType response)
    {
    }

    [Token(Token = "0x600CC44")]
    [Address(RVA = "0x1BAD660", Offset = "0x1BAD660", VA = "0x1BAD660")]
    public bool IsParallelCheck() => new bool();

    [Token(Token = "0x2002153")]
    public enum Status
    {
      [Token(Token = "0x4008D47")] Completed,
      [Token(Token = "0x4008D48")] Receipted,
      [Token(Token = "0x4008D49")] Receiptable,
      [Token(Token = "0x4008D4A")] Locked,
    }
  }
}
