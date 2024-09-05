// Decompiled with JetBrains decompiler
// Type: Battle.RouteSearch.AttackableAreaSearcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Unit;
using Battle.Utility;
using Il2CppDummyDll;

#nullable disable
namespace Battle.RouteSearch
{
  [Token(Token = "0x2002496")]
  public sealed class AttackableAreaSearcher : PathSearcher2D
  {
    [Token(Token = "0x4009CEE")]
    [FieldOffset(Offset = "0x38")]
    private Actor.Direction[] dirs;
    [Token(Token = "0x4009CEF")]
    [FieldOffset(Offset = "0x40")]
    private SearchUtility.GridSearchComparer comparer;

    [Token(Token = "0x600E089")]
    [Address(RVA = "0x2019CB0", Offset = "0x2019CB0", VA = "0x2019CB0")]
    public AttackableAreaSearcher(Node[,] nodes)
    {
    }

    [Token(Token = "0x600E08A")]
    [Address(RVA = "0x202AF14", Offset = "0x202AF14", VA = "0x202AF14")]
    public void SearchArea(
      int x,
      int y,
      IBasicRangeData range,
      PathSearcher2D.NodeValidationCallback attackTargetNodeVallidation = null)
    {
    }

    [Token(Token = "0x600E08B")]
    [Address(RVA = "0x2019E6C", Offset = "0x2019E6C", VA = "0x2019E6C")]
    public void SearchArea(
      int x,
      int y,
      IBasicRangeData range,
      Actor.Direction direction,
      PathSearcher2D.NodeValidationCallback attackTargetNodeVallidation = null,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600E08C")]
    [Address(RVA = "0x202B634", Offset = "0x202B634", VA = "0x202B634")]
    public void SearchArea(
      int x,
      int y,
      IReadableUnitGridShapeData shapeData,
      IBasicRangeData range,
      Actor.Direction direction,
      PathSearcher2D.NodeValidationCallback attackTargetNodeVallidation = null,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600E08D")]
    [Address(RVA = "0x202B01C", Offset = "0x202B01C", VA = "0x202B01C")]
    private void SearchAreaImpl(
      int x,
      int y,
      IReadableUnitGridShapeData shapeData,
      IBasicRangeData range,
      Actor.Direction direction,
      PathSearcher2D.NodeValidationCallback attackTargetNodeVallidation = null)
    {
    }

    [Token(Token = "0x600E08E")]
    [Address(RVA = "0x2019DA8", Offset = "0x2019DA8", VA = "0x2019DA8")]
    public void SearchArea(
      int x,
      int y,
      IReadableUnitGridShapeData shapeData,
      IBasicRangeData range,
      PathSearcher2D.NodeValidationCallback attackTargetNodeVallidation = null,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600E08F")]
    [Address(RVA = "0x202B6B0", Offset = "0x202B6B0", VA = "0x202B6B0")]
    private void SearchRangeFrom(
      Node root,
      IBasicRangeData range,
      Actor.Direction direction,
      PathSearcher2D.NodeValidationCallback attackTargetNodeVallidation)
    {
    }

    [Token(Token = "0x600E090")]
    [Address(RVA = "0x202BB84", Offset = "0x202BB84", VA = "0x202BB84")]
    public void SearchArea(
      int x,
      int y,
      int near,
      int far,
      PathSearcher2D.NodeValidationCallback attackTargetNodeVallidation = null,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600E091")]
    [Address(RVA = "0x202BC38", Offset = "0x202BC38", VA = "0x202BC38")]
    public void SearchArea(
      int x,
      int y,
      IReadableUnitGridShapeData shapeData,
      int near,
      int far,
      PathSearcher2D.NodeValidationCallback attackTargetNodeVallidation = null,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600E092")]
    [Address(RVA = "0x202C218", Offset = "0x202C218", VA = "0x202C218")]
    public void SearchArea(
      MovableAreaSearcher movable,
      IReadableUnitGridShapeData shapeData,
      IBasicRangeData range,
      PathSearcher2D.NodeValidationCallback searchStartNodeVallidation = null,
      PathSearcher2D.NodeValidationCallback attackTargetNodeVallidation = null,
      bool isReset = true)
    {
    }

    [Token(Token = "0x600E093")]
    [Address(RVA = "0x202C744", Offset = "0x202C744", VA = "0x202C744")]
    public void SearchArea(
      MovableAreaSearcher movable,
      IReadableUnitGridShapeData shapeData,
      int near,
      int far,
      PathSearcher2D.NodeValidationCallback searchStartNodeVallidation = null,
      PathSearcher2D.NodeValidationCallback attackTargetNodeVallidation = null)
    {
    }

    [Token(Token = "0x600E094")]
    [Address(RVA = "0x202C10C", Offset = "0x202C10C", VA = "0x202C10C")]
    private void SearchRangeFrom(
      Node root,
      int near,
      int far,
      PathSearcher2D.NodeValidationCallback attackTargetNodeVallidation)
    {
    }

    [Token(Token = "0x600E095")]
    [Address(RVA = "0x202BAA0", Offset = "0x202BAA0", VA = "0x202BAA0")]
    private bool AddAttackableNode(
      int x,
      int y,
      Node parent,
      PathSearcher2D.NodeValidationCallback callback)
    {
      return new bool();
    }

    [Token(Token = "0x600E096")]
    [Address(RVA = "0x202CB94", Offset = "0x202CB94", VA = "0x202CB94", Slot = "4")]
    protected override Node OpenNode(int x, int y, Node parent) => (Node) null;
  }
}
