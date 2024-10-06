// Decompiled with JetBrains decompiler
// Type: Story.Chart.NodeStatusCurrentLoopActivate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006CF")]
  public class NodeStatusCurrentLoopActivate : INodeStatus
  {
    [Token(Token = "0x400204D")]
    [FieldOffset(Offset = "0x10")]
    private SpecifiedStory story;

    [Token(Token = "0x170005B0")]
    private int CurrentSequenceID
    {
      [Token(Token = "0x6002685"), Address(RVA = "0x2F44D94", Offset = "0x2F44D94", VA = "0x2F44D94")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6002686")]
    [Address(RVA = "0x2F44DBC", Offset = "0x2F44DBC", VA = "0x2F44DBC")]
    public NodeStatusCurrentLoopActivate(SpecifiedStory story)
    {
    }

    [Token(Token = "0x6002687")]
    [Address(RVA = "0x2F44DE4", Offset = "0x2F44DE4", VA = "0x2F44DE4")]
    private bool IsCurrentSequence(StoryMainQuestSequenceData sequence) => new bool();

    [Token(Token = "0x6002688")]
    [Address(RVA = "0x2F44E4C", Offset = "0x2F44E4C", VA = "0x2F44E4C", Slot = "5")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsInactive(
      StoryMainQuestSequenceData sequence)
    {
      return new bool();
    }

    [Token(Token = "0x6002689")]
    [Address(RVA = "0x2F44EB0", Offset = "0x2F44EB0", VA = "0x2F44EB0", Slot = "4")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsLock(StoryMainQuestSequenceData sequence)
    {
      return new bool();
    }

    [Token(Token = "0x600268A")]
    [Address(RVA = "0x2F44F14", Offset = "0x2F44F14", VA = "0x2F44F14", Slot = "6")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsHighlight(
      StoryMainQuestSequenceData sequence)
    {
      return new bool();
    }

    [Token(Token = "0x600268B")]
    [Address(RVA = "0x2F44F74", Offset = "0x2F44F74", VA = "0x2F44F74", Slot = "7")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsHighlight(
      StoryMainQuestSequenceData from,
      StoryMainQuestSequenceData to)
    {
      return new bool();
    }

    [Token(Token = "0x600268C")]
    [Address(RVA = "0x2F45024", Offset = "0x2F45024", VA = "0x2F45024", Slot = "8")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsHere(StoryMainQuestSequenceData sequence)
    {
      return new bool();
    }
  }
}
