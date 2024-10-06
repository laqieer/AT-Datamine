// Decompiled with JetBrains decompiler
// Type: Battle.RouteSearch.TwoPointShortestPathSearcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.RouteSearch
{
  [Token(Token = "0x20024A1")]
  public sealed class TwoPointShortestPathSearcher : PathSearcher2D
  {
    [Token(Token = "0x4009D15")]
    [FieldOffset(Offset = "0x40")]
    private PriorityQueue<Node> openedNodes;

    [Token(Token = "0x17003044")]
    public Node TargetPositionNode
    {
      [Token(Token = "0x600E0FB"), Address(RVA = "0x4255ACC", Offset = "0x4255ACC", VA = "0x4255ACC")] get
      {
        return (Node) null;
      }
      [Token(Token = "0x600E0FC"), Address(RVA = "0x4255AD4", Offset = "0x4255AD4", VA = "0x4255AD4")] private set
      {
      }
    }

    [Token(Token = "0x600E0FD")]
    [Address(RVA = "0x4255ADC", Offset = "0x4255ADC", VA = "0x4255ADC")]
    public TwoPointShortestPathSearcher(Node[,] nodes)
    {
    }

    [Token(Token = "0x600E0FE")]
    [Address(RVA = "0x4255B4C", Offset = "0x4255B4C", VA = "0x4255B4C", Slot = "5")]
    public override void ClearResult()
    {
    }

    [Token(Token = "0x600E0FF")]
    [Address(RVA = "0x4255BA8", Offset = "0x4255BA8", VA = "0x4255BA8")]
    public void SearchPath(
      int startX,
      int startY,
      int targetX,
      int targetY,
      PathSearcher2D.NodeValidationCallback movableValidation = null,
      PathSearcher2D.NodeValidationCallback occupiableValidation = null,
      bool considerWarp = false)
    {
    }

    [Token(Token = "0x600E100")]
    [Address(RVA = "0x4255D48", Offset = "0x4255D48", VA = "0x4255D48")]
    private void SearchPathInternal(
      Node root,
      int startX,
      int startY,
      int targetX,
      int targetY,
      PathSearcher2D.NodeValidationCallback movableValidation,
      PathSearcher2D.NodeValidationCallback occupiableValidation,
      bool considerWarp)
    {
    }
  }
}
