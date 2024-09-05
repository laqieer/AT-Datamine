// Decompiled with JetBrains decompiler
// Type: StaqData.SubQuestTaskInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData.Quest;
using StaqData.SubQuest;
using Story.Tracker;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020F2")]
  public class SubQuestTaskInfo : ITrackingTargetQuestTaskProgress
  {
    [Token(Token = "0x4008B84")]
    [FieldOffset(Offset = "0x30")]
    protected StorySubquestTaskFlagData flagcheck;
    [Token(Token = "0x4008B85")]
    [FieldOffset(Offset = "0x38")]
    protected StorySubquestTaskFlagData flagvalue;

    [Token(Token = "0x17002B0A")]
    public int SubQuestID
    {
      [Token(Token = "0x600C7AD"), Address(RVA = "0x1CDDEF8", Offset = "0x1CDDEF8", VA = "0x1CDDEF8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B0B")]
    public int SubQuestTaskID
    {
      [Token(Token = "0x600C7AE"), Address(RVA = "0x1CE0710", Offset = "0x1CE0710", VA = "0x1CE0710")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B0C")]
    public BattleInfo BattleInfo
    {
      [Token(Token = "0x600C7AF"), Address(RVA = "0x1CE072C", Offset = "0x1CE072C", VA = "0x1CE072C")] get
      {
        return (BattleInfo) null;
      }
      [Token(Token = "0x600C7B0"), Address(RVA = "0x1CE0734", Offset = "0x1CE0734", VA = "0x1CE0734")] private set
      {
      }
    }

    [Token(Token = "0x17002B0D")]
    public ConditionItemInfo ConditionItem
    {
      [Token(Token = "0x600C7B1"), Address(RVA = "0x1CE073C", Offset = "0x1CE073C", VA = "0x1CE073C")] get
      {
        return (ConditionItemInfo) null;
      }
      [Token(Token = "0x600C7B2"), Address(RVA = "0x1CE0744", Offset = "0x1CE0744", VA = "0x1CE0744")] private set
      {
      }
    }

    [Token(Token = "0x600C7B3")]
    [Address(RVA = "0x1CE074C", Offset = "0x1CE074C", VA = "0x1CE074C")]
    public bool IsContainTopicGroup() => new bool();

    [Token(Token = "0x17002B0E")]
    public List<ItemInfo> ObtainItems
    {
      [Token(Token = "0x600C7B4"), Address(RVA = "0x1CE0808", Offset = "0x1CE0808", VA = "0x1CE0808")] get
      {
        return (List<ItemInfo>) null;
      }
    }

    [Token(Token = "0x17002B0F")]
    private int Story\u002ETracker\u002EITrackingTargetQuestTaskProgress\u002EUniqueKey
    {
      [Token(Token = "0x600C7B5"), Address(RVA = "0x1CE0810", Offset = "0x1CE0810", VA = "0x1CE0810", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B10")]
    private bool Story\u002ETracker\u002EITrackingTargetQuestTaskProgress\u002EIsActive
    {
      [Token(Token = "0x600C7B6"), Address(RVA = "0x1CE082C", Offset = "0x1CE082C", VA = "0x1CE082C", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002B11")]
    private bool Story\u002ETracker\u002EITrackingTargetQuestTaskProgress\u002EIsCompleted
    {
      [Token(Token = "0x600C7B7"), Address(RVA = "0x1CE0830", Offset = "0x1CE0830", VA = "0x1CE0830", Slot = "6")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002B12")]
    private int Story\u002ETracker\u002EITrackingTargetQuestTaskProgress\u002ECurrent
    {
      [Token(Token = "0x600C7B8"), Address(RVA = "0x1CE0834", Offset = "0x1CE0834", VA = "0x1CE0834", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B13")]
    private int Story\u002ETracker\u002EITrackingTargetQuestTaskProgress\u002EMax
    {
      [Token(Token = "0x600C7B9"), Address(RVA = "0x1CE08B0", Offset = "0x1CE08B0", VA = "0x1CE08B0", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002B14")]
    private string Story\u002ETracker\u002EITrackingTargetQuestTaskProgress\u002EText
    {
      [Token(Token = "0x600C7BA"), Address(RVA = "0x1CE091C", Offset = "0x1CE091C", VA = "0x1CE091C", Slot = "9")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002B15")]
    public StorySubquestTaskData MasterData
    {
      [Token(Token = "0x600C7BB"), Address(RVA = "0x1CE098C", Offset = "0x1CE098C", VA = "0x1CE098C")] get
      {
        return (StorySubquestTaskData) null;
      }
      [Token(Token = "0x600C7BC"), Address(RVA = "0x1CE0994", Offset = "0x1CE0994", VA = "0x1CE0994")] private set
      {
      }
    }

    [Token(Token = "0x17002B16")]
    protected SubQuestTaskDestinationObject TaskDestination
    {
      [Token(Token = "0x600C7BD"), Address(RVA = "0x1CE099C", Offset = "0x1CE099C", VA = "0x1CE099C")] get
      {
        return (SubQuestTaskDestinationObject) null;
      }
      [Token(Token = "0x600C7BE"), Address(RVA = "0x1CE09A4", Offset = "0x1CE09A4", VA = "0x1CE09A4")] private set
      {
      }
    }

    [Token(Token = "0x17002B17")]
    protected SubQuestData Parent
    {
      [Token(Token = "0x600C7BF"), Address(RVA = "0x1CE0790", Offset = "0x1CE0790", VA = "0x1CE0790")] get
      {
        return (SubQuestData) null;
      }
    }

    [Token(Token = "0x600C7C0")]
    [Address(RVA = "0x1CDF26C", Offset = "0x1CDF26C", VA = "0x1CDF26C")]
    public SubQuestTaskInfo(StorySubquestTaskData taskData)
    {
    }

    [Token(Token = "0x600C7C1")]
    [Address(RVA = "0x1CDFCE0", Offset = "0x1CDFCE0", VA = "0x1CDFCE0")]
    public bool IsActive() => new bool();

    [Token(Token = "0x600C7C2")]
    [Address(RVA = "0x1CE09AC", Offset = "0x1CE09AC", VA = "0x1CE09AC")]
    public bool IsFlagCheck() => new bool();

    [Token(Token = "0x600C7C3")]
    [Address(RVA = "0x1CDFD2C", Offset = "0x1CDFD2C", VA = "0x1CDFD2C")]
    public bool IsCompleted() => new bool();

    [Token(Token = "0x600C7C4")]
    [Address(RVA = "0x1CDFC44", Offset = "0x1CDFC44", VA = "0x1CDFC44")]
    public bool IsAvailable() => new bool();

    [Token(Token = "0x600C7C5")]
    [Address(RVA = "0x1CE09F0", Offset = "0x1CE09F0", VA = "0x1CE09F0")]
    public State GetState() => new State();

    [Token(Token = "0x600C7C6")]
    [Address(RVA = "0x1CE0A14", Offset = "0x1CE0A14", VA = "0x1CE0A14")]
    public StoryFreeActionLayoutData GetLayoutData() => (StoryFreeActionLayoutData) null;

    [Token(Token = "0x600C7C7")]
    [Address(RVA = "0x1CDDF14", Offset = "0x1CDDF14", VA = "0x1CDDF14")]
    public SubQuestData.ProgressStatus GetProgressStatus() => new SubQuestData.ProgressStatus();

    [Token(Token = "0x600C7C8")]
    [Address(RVA = "0x1CE0838", Offset = "0x1CE0838", VA = "0x1CE0838")]
    protected int GetProgressCurrentNum() => new int();

    [Token(Token = "0x600C7C9")]
    [Address(RVA = "0x1CE08B4", Offset = "0x1CE08B4", VA = "0x1CE08B4")]
    protected int GetProgressMaxNum() => new int();

    [Token(Token = "0x600C7CA")]
    [Address(RVA = "0x1CE0920", Offset = "0x1CE0920", VA = "0x1CE0920")]
    protected string GetProgressText() => (string) null;
  }
}
