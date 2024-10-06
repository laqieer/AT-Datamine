// Decompiled with JetBrains decompiler
// Type: StaqData.AreaEvent.AreaEventQuestTask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData.Quest;
using Story.Tracker;
using System.Collections.Generic;

#nullable disable
namespace StaqData.AreaEvent
{
  [Token(Token = "0x200215C")]
  public class AreaEventQuestTask : ITrackingTargetQuestTaskProgress
  {
    [Token(Token = "0x4008D61")]
    [FieldOffset(Offset = "0x18")]
    private List<ItemInfo> items;

    [Token(Token = "0x17002CCA")]
    private int Story\u002ETracker\u002EITrackingTargetQuestTaskProgress\u002EUniqueKey
    {
      [Token(Token = "0x600CC74"), Address(RVA = "0x1BAFB78", Offset = "0x1BAFB78", VA = "0x1BAFB78", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CCB")]
    private bool Story\u002ETracker\u002EITrackingTargetQuestTaskProgress\u002EIsActive
    {
      [Token(Token = "0x600CC75"), Address(RVA = "0x1BAFB94", Offset = "0x1BAFB94", VA = "0x1BAFB94", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002CCC")]
    private bool Story\u002ETracker\u002EITrackingTargetQuestTaskProgress\u002EIsCompleted
    {
      [Token(Token = "0x600CC76"), Address(RVA = "0x1BAFBB4", Offset = "0x1BAFBB4", VA = "0x1BAFBB4", Slot = "6")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002CCD")]
    public int Current
    {
      [Token(Token = "0x600CC77"), Address(RVA = "0x1BAFBBC", Offset = "0x1BAFBBC", VA = "0x1BAFBBC", Slot = "7")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CCE")]
    public int Max
    {
      [Token(Token = "0x600CC78"), Address(RVA = "0x1BAFC40", Offset = "0x1BAFC40", VA = "0x1BAFC40", Slot = "8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002CCF")]
    public string Text
    {
      [Token(Token = "0x600CC79"), Address(RVA = "0x1BAFCC0", Offset = "0x1BAFCC0", VA = "0x1BAFCC0", Slot = "9")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002CD0")]
    public StoryAreaEventQuestTaskData MasterData
    {
      [Token(Token = "0x600CC7A"), Address(RVA = "0x1BAFDA8", Offset = "0x1BAFDA8", VA = "0x1BAFDA8")] get
      {
        return (StoryAreaEventQuestTaskData) null;
      }
      [Token(Token = "0x600CC7B"), Address(RVA = "0x1BAFDB0", Offset = "0x1BAFDB0", VA = "0x1BAFDB0")] private set
      {
      }
    }

    [Token(Token = "0x17002CD1")]
    public IEnumerable<ItemInfo> NeedItems
    {
      [Token(Token = "0x600CC7C"), Address(RVA = "0x1BAFDB8", Offset = "0x1BAFDB8", VA = "0x1BAFDB8")] get
      {
        return (IEnumerable<ItemInfo>) null;
      }
    }

    [Token(Token = "0x17002CD2")]
    public bool IsActive
    {
      [Token(Token = "0x600CC7D"), Address(RVA = "0x1BAD8A0", Offset = "0x1BAD8A0", VA = "0x1BAD8A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002CD3")]
    public bool FlagCheck
    {
      [Token(Token = "0x600CC7E"), Address(RVA = "0x1BAFDC0", Offset = "0x1BAFDC0", VA = "0x1BAFDC0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CC7F"), Address(RVA = "0x1BAFDC8", Offset = "0x1BAFDC8", VA = "0x1BAFDC8")] private set
      {
      }
    }

    [Token(Token = "0x17002CD4")]
    public bool IsCompleted
    {
      [Token(Token = "0x600CC80"), Address(RVA = "0x1BAFDD4", Offset = "0x1BAFDD4", VA = "0x1BAFDD4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600CC81"), Address(RVA = "0x1BAFDDC", Offset = "0x1BAFDDC", VA = "0x1BAFDDC")] private set
      {
      }
    }

    [Token(Token = "0x600CC82")]
    [Address(RVA = "0x1BAD4DC", Offset = "0x1BAD4DC", VA = "0x1BAD4DC")]
    public int GetFlagValue() => new int();

    [Token(Token = "0x600CC83")]
    [Address(RVA = "0x1BAFDE8", Offset = "0x1BAFDE8", VA = "0x1BAFDE8")]
    public int GetFlagCheckValue() => new int();

    [Token(Token = "0x17002CD5")]
    public AreaEventQuestData Parent
    {
      [Token(Token = "0x600CC84"), Address(RVA = "0x1BAFEB0", Offset = "0x1BAFEB0", VA = "0x1BAFEB0")] get
      {
        return (AreaEventQuestData) null;
      }
    }

    [Token(Token = "0x600CC85")]
    [Address(RVA = "0x1BAFF24", Offset = "0x1BAFF24", VA = "0x1BAFF24")]
    public bool IsContainTopicGroup() => new bool();

    [Token(Token = "0x600CC86")]
    [Address(RVA = "0x1BACEEC", Offset = "0x1BACEEC", VA = "0x1BACEEC")]
    public AreaEventQuestTask(StoryAreaEventQuestTaskData masterData, int flags)
    {
    }

    [Token(Token = "0x600CC87")]
    [Address(RVA = "0x1BACF88", Offset = "0x1BACF88", VA = "0x1BACF88")]
    public void Apply(int flags)
    {
    }

    [Token(Token = "0x600CC88")]
    [Address(RVA = "0x1BAFF80", Offset = "0x1BAFF80", VA = "0x1BAFF80")]
    public void FlagUpdate(int flags)
    {
    }

    [Token(Token = "0x600CC89")]
    [Address(RVA = "0x1BAFBC0", Offset = "0x1BAFBC0", VA = "0x1BAFBC0")]
    private int GetProgressCurrentNum() => new int();

    [Token(Token = "0x600CC8A")]
    [Address(RVA = "0x1BAFC44", Offset = "0x1BAFC44", VA = "0x1BAFC44")]
    private int GetProgressMaxNum() => new int();

    [Token(Token = "0x600CC8B")]
    [Address(RVA = "0x1BAFCC4", Offset = "0x1BAFCC4", VA = "0x1BAFCC4")]
    private string GetProgressText() => (string) null;
  }
}
