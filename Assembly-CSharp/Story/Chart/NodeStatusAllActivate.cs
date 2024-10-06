// Decompiled with JetBrains decompiler
// Type: Story.Chart.NodeStatusAllActivate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006CE")]
  public class NodeStatusAllActivate : INodeStatus
  {
    [Token(Token = "0x400204C")]
    [FieldOffset(Offset = "0x10")]
    private bool highlight;

    [Token(Token = "0x600267F")]
    [Address(RVA = "0x2F44D44", Offset = "0x2F44D44", VA = "0x2F44D44")]
    public NodeStatusAllActivate(bool highlight)
    {
    }

    [Token(Token = "0x6002680")]
    [Address(RVA = "0x2F44D6C", Offset = "0x2F44D6C", VA = "0x2F44D6C", Slot = "5")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsInactive(
      StoryMainQuestSequenceData sequence)
    {
      return new bool();
    }

    [Token(Token = "0x6002681")]
    [Address(RVA = "0x2F44D74", Offset = "0x2F44D74", VA = "0x2F44D74", Slot = "4")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsLock(StoryMainQuestSequenceData sequence)
    {
      return new bool();
    }

    [Token(Token = "0x6002682")]
    [Address(RVA = "0x2F44D7C", Offset = "0x2F44D7C", VA = "0x2F44D7C", Slot = "6")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsHighlight(
      StoryMainQuestSequenceData sequence)
    {
      return new bool();
    }

    [Token(Token = "0x6002683")]
    [Address(RVA = "0x2F44D84", Offset = "0x2F44D84", VA = "0x2F44D84", Slot = "7")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsHighlight(
      StoryMainQuestSequenceData from,
      StoryMainQuestSequenceData to)
    {
      return new bool();
    }

    [Token(Token = "0x6002684")]
    [Address(RVA = "0x2F44D8C", Offset = "0x2F44D8C", VA = "0x2F44D8C", Slot = "8")]
    private bool Story\u002EChart\u002EINodeStatus\u002EIsHere(StoryMainQuestSequenceData sequence)
    {
      return new bool();
    }
  }
}
