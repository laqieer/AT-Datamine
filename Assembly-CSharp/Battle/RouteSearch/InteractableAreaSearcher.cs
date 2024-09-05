// Decompiled with JetBrains decompiler
// Type: Battle.RouteSearch.InteractableAreaSearcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Utility;
using Il2CppDummyDll;

#nullable disable
namespace Battle.RouteSearch
{
  [Token(Token = "0x2002497")]
  public sealed class InteractableAreaSearcher : PathSearcher2D
  {
    [Token(Token = "0x4009CF0")]
    [FieldOffset(Offset = "0x38")]
    private SearchUtility.GridSearchComparer comparer;

    [Token(Token = "0x600E098")]
    [Address(RVA = "0x425171C", Offset = "0x425171C", VA = "0x425171C")]
    public InteractableAreaSearcher(Node[,] nodes)
    {
    }

    [Token(Token = "0x600E099")]
    [Address(RVA = "0x425190C", Offset = "0x425190C", VA = "0x425190C")]
    public void SearchArea(
      MovableAreaSearcher movable,
      IReadableUnitGridShapeData shapeData,
      int near,
      int far,
      PathSearcher2D.NodeValidationCallback searchStartNodeVallidation = null,
      PathSearcher2D.NodeValidationCallback interactTargetNodeVallidation = null)
    {
    }

    [Token(Token = "0x600E09A")]
    [Address(RVA = "0x4251E54", Offset = "0x4251E54", VA = "0x4251E54")]
    private void SearchRangeFrom(
      Node root,
      int near,
      int far,
      PathSearcher2D.NodeValidationCallback interactTargetNodeVallidation)
    {
    }

    [Token(Token = "0x600E09B")]
    [Address(RVA = "0x425209C", Offset = "0x425209C", VA = "0x425209C")]
    private void AddInteractableNode(
      int x,
      int y,
      Node parent,
      PathSearcher2D.NodeValidationCallback callback)
    {
    }

    [Token(Token = "0x600E09C")]
    [Address(RVA = "0x42522E0", Offset = "0x42522E0", VA = "0x42522E0", Slot = "4")]
    protected override Node OpenNode(int x, int y, Node parent) => (Node) null;
  }
}
