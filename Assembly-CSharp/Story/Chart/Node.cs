// Decompiled with JetBrains decompiler
// Type: Story.Chart.Node
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006D1")]
  public class Node : IBranch
  {
    [Token(Token = "0x4002055")]
    [FieldOffset(Offset = "0x30")]
    private INodeStatus nodeStatus;
    [Token(Token = "0x4002056")]
    [FieldOffset(Offset = "0x38")]
    private List<Node> parents;
    [Token(Token = "0x4002057")]
    [FieldOffset(Offset = "0x40")]
    private List<Node> childs;

    [Token(Token = "0x6002694")]
    [Address(RVA = "0x2F452A0", Offset = "0x2F452A0", VA = "0x2F452A0")]
    public bool ParentIsLocked() => new bool();

    [Token(Token = "0x6002695")]
    [Address(RVA = "0x2F453E8", Offset = "0x2F453E8", VA = "0x2F453E8")]
    public bool IsntConnection() => new bool();

    [Token(Token = "0x6002696")]
    [Address(RVA = "0x2F45450", Offset = "0x2F45450", VA = "0x2F45450")]
    public bool IsDefault() => new bool();

    [Token(Token = "0x6002697")]
    [Address(RVA = "0x2F44C84", Offset = "0x2F44C84", VA = "0x2F44C84")]
    public bool IsBranching() => new bool();

    [Token(Token = "0x6002698")]
    [Address(RVA = "0x2F455EC", Offset = "0x2F455EC", VA = "0x2F455EC")]
    public bool IsTerminal() => new bool();

    [Token(Token = "0x6002699")]
    [Address(RVA = "0x2F4563C", Offset = "0x2F4563C", VA = "0x2F4563C")]
    public int CalculateNest() => new int();

    [Token(Token = "0x600269A")]
    [Address(RVA = "0x2F45668", Offset = "0x2F45668", VA = "0x2F45668")]
    private int CalculateNestInternal() => new int();

    [Token(Token = "0x600269B")]
    [Address(RVA = "0x2F40ED4", Offset = "0x2F40ED4", VA = "0x2F40ED4")]
    public void AppendChild(Node child)
    {
    }

    [Token(Token = "0x600269C")]
    [Address(RVA = "0x2F457FC", Offset = "0x2F457FC", VA = "0x2F457FC")]
    public void SetStatus(INodeStatus status)
    {
    }

    [Token(Token = "0x600269D")]
    [Address(RVA = "0x2F45804", Offset = "0x2F45804", VA = "0x2F45804", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600269E")]
    [Address(RVA = "0x2F458A8", Offset = "0x2F458A8", VA = "0x2F458A8", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x170005B2")]
    public StoryMainQuestSequenceData Sequence
    {
      [Token(Token = "0x600269F"), Address(RVA = "0x2F458C8", Offset = "0x2F458C8", VA = "0x2F458C8")] get
      {
        return (StoryMainQuestSequenceData) null;
      }
      [Token(Token = "0x60026A0"), Address(RVA = "0x2F458D0", Offset = "0x2F458D0", VA = "0x2F458D0")] set
      {
      }
    }

    [Token(Token = "0x170005B3")]
    public StoryMainQuestSequenceConditionData Condition
    {
      [Token(Token = "0x60026A1"), Address(RVA = "0x2F458D8", Offset = "0x2F458D8", VA = "0x2F458D8")] get
      {
        return (StoryMainQuestSequenceConditionData) null;
      }
      [Token(Token = "0x60026A2"), Address(RVA = "0x2F458E0", Offset = "0x2F458E0", VA = "0x2F458E0")] set
      {
      }
    }

    [Token(Token = "0x60026A3")]
    [Address(RVA = "0x2F42D98", Offset = "0x2F42D98", VA = "0x2F42D98")]
    public bool IsLocked() => new bool();

    [Token(Token = "0x60026A4")]
    [Address(RVA = "0x2F44B14", Offset = "0x2F44B14", VA = "0x2F44B14")]
    public bool IsInactive() => new bool();

    [Token(Token = "0x60026A5")]
    [Address(RVA = "0x2F44BCC", Offset = "0x2F44BCC", VA = "0x2F44BCC")]
    public bool IsHighlight() => new bool();

    [Token(Token = "0x60026A6")]
    [Address(RVA = "0x2F42E4C", Offset = "0x2F42E4C", VA = "0x2F42E4C")]
    public bool IsHighlight(StoryMainQuestSequenceData to) => new bool();

    [Token(Token = "0x60026A7")]
    [Address(RVA = "0x2F40E14", Offset = "0x2F40E14", VA = "0x2F40E14")]
    public bool IsHere() => new bool();

    [Token(Token = "0x170005B4")]
    public int X
    {
      [Token(Token = "0x60026A8"), Address(RVA = "0x2F42FCC", Offset = "0x2F42FCC", VA = "0x2F42FCC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005B5")]
    public int Y
    {
      [Token(Token = "0x60026A9"), Address(RVA = "0x2F42FD4", Offset = "0x2F42FD4", VA = "0x2F42FD4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170005B6")]
    public int Depth
    {
      [Token(Token = "0x60026AA"), Address(RVA = "0x2F458E8", Offset = "0x2F458E8", VA = "0x2F458E8")] get
      {
        return new int();
      }
      [Token(Token = "0x60026AB"), Address(RVA = "0x2F458F0", Offset = "0x2F458F0", VA = "0x2F458F0")] set
      {
      }
    }

    [Token(Token = "0x170005B7")]
    public int Index
    {
      [Token(Token = "0x60026AC"), Address(RVA = "0x2F458F8", Offset = "0x2F458F8", VA = "0x2F458F8")] get
      {
        return new int();
      }
      [Token(Token = "0x60026AD"), Address(RVA = "0x2F45900", Offset = "0x2F45900", VA = "0x2F45900")] set
      {
      }
    }

    [Token(Token = "0x170005B8")]
    public int Nest
    {
      [Token(Token = "0x60026AE"), Address(RVA = "0x2F45908", Offset = "0x2F45908", VA = "0x2F45908")] get
      {
        return new int();
      }
      [Token(Token = "0x60026AF"), Address(RVA = "0x2F45910", Offset = "0x2F45910", VA = "0x2F45910")] set
      {
      }
    }

    [Token(Token = "0x170005B9")]
    public int Height
    {
      [Token(Token = "0x60026B0"), Address(RVA = "0x2F45918", Offset = "0x2F45918", VA = "0x2F45918")] get
      {
        return new int();
      }
      [Token(Token = "0x60026B1"), Address(RVA = "0x2F45920", Offset = "0x2F45920", VA = "0x2F45920")] set
      {
      }
    }

    [Token(Token = "0x170005BA")]
    public List<Node> Parents
    {
      [Token(Token = "0x60026B2"), Address(RVA = "0x2F45928", Offset = "0x2F45928", VA = "0x2F45928", Slot = "4")] get
      {
        return (List<Node>) null;
      }
    }

    [Token(Token = "0x170005BB")]
    public List<Node> Childs
    {
      [Token(Token = "0x60026B3"), Address(RVA = "0x2F45930", Offset = "0x2F45930", VA = "0x2F45930", Slot = "5")] get
      {
        return (List<Node>) null;
      }
    }

    [Token(Token = "0x60026B4")]
    [Address(RVA = "0x2F401FC", Offset = "0x2F401FC", VA = "0x2F401FC")]
    public Node()
    {
    }
  }
}
