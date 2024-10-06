// Decompiled with JetBrains decompiler
// Type: Story.Chart.NodeStatusAllLoopActivate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006D0")]
  public class NodeStatusAllLoopActivate : INodeStatus
  {
    [Token(Token = "0x400204E")]
    [FieldOffset(Offset = "0x10")]
    private SpecifiedStory story;

    [Token(Token = "0x170005B1")]
    private int CurrentSequenceID
    {
      [Token(Token = "0x600268D"), Address(RVA = "0x2F4504C", Offset = "0x2F4504C", VA = "0x2F4504C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600268E")]
    [Address(RVA = "0x2F45074", Offset = "0x2F45074", VA = "0x2F45074")]
    public NodeStatusAllLoopActivate(SpecifiedStory story)
    {
    }

    [Token(Token = "0x600268F")]
    [Address(RVA = "0x2F4509C", Offset = "0x2F4509C", VA = "0x2F4509C", Slot = "5")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsInactive(
      StoryMainQuestSequenceData sequence)
    {
      return new bool();
    }

    [Token(Token = "0x6002690")]
    [Address(RVA = "0x2F45108", Offset = "0x2F45108", VA = "0x2F45108", Slot = "4")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsLock(StoryMainQuestSequenceData sequence)
    {
      return new bool();
    }

    [Token(Token = "0x6002691")]
    [Address(RVA = "0x2F45174", Offset = "0x2F45174", VA = "0x2F45174", Slot = "6")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsHighlight(
      StoryMainQuestSequenceData sequence)
    {
      return new bool();
    }

    [Token(Token = "0x6002692")]
    [Address(RVA = "0x2F451DC", Offset = "0x2F451DC", VA = "0x2F451DC", Slot = "7")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsHighlight(
      StoryMainQuestSequenceData from,
      StoryMainQuestSequenceData to)
    {
      return new bool();
    }

    [Token(Token = "0x6002693")]
    [Address(RVA = "0x2F45298", Offset = "0x2F45298", VA = "0x2F45298", Slot = "8")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsHere(StoryMainQuestSequenceData sequence)
    {
      return new bool();
    }
  }
}
