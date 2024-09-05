// Decompiled with JetBrains decompiler
// Type: Battle.RouteSearch.MovableAreaSearcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.RouteSearch
{
  [Token(Token = "0x2002498")]
  public sealed class MovableAreaSearcher : PathSearcher2D
  {
    [Token(Token = "0x4009CF1")]
    private const int NeighborNodesLength = 4;
    [Token(Token = "0x4009CF3")]
    [FieldOffset(Offset = "0x40")]
    public List<Node> OccupiableNodes;
    [Token(Token = "0x4009CF4")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<(int x, int y), Node> occupiableMovableMap;

    [Token(Token = "0x17003037")]
    public Node Root
    {
      [Token(Token = "0x600E09E"), Address(RVA = "0x42525A0", Offset = "0x42525A0", VA = "0x42525A0")] get
      {
        return (Node) null;
      }
      [Token(Token = "0x600E09F"), Address(RVA = "0x42525A8", Offset = "0x42525A8", VA = "0x42525A8")] private set
      {
      }
    }

    [Token(Token = "0x17003038")]
    public List<Node> MovableNodes
    {
      [Token(Token = "0x600E0A0"), Address(RVA = "0x42525B0", Offset = "0x42525B0", VA = "0x42525B0")] get
      {
        return (List<Node>) null;
      }
    }

    [Token(Token = "0x600E0A1")]
    [Address(RVA = "0x42525B8", Offset = "0x42525B8", VA = "0x42525B8")]
    public MovableAreaSearcher(
      Node[,] nodes,
      Dictionary<LandTagEnum, int> overrideLandEffect = null,
      List<Vector2Int> forceStop = null)
    {
    }

    [Token(Token = "0x600E0A2")]
    [Address(RVA = "0x42526C4", Offset = "0x42526C4", VA = "0x42526C4")]
    public void ChangeSeachNodes(
      Node[,] nodes,
      Dictionary<LandTagEnum, int> overrideCost,
      List<Vector2Int> forceStop,
      bool considerWarp = false)
    {
    }

    [Token(Token = "0x600E0A3")]
    [Address(RVA = "0x42527BC", Offset = "0x42527BC", VA = "0x42527BC", Slot = "5")]
    public override void ClearResult()
    {
    }

    [Token(Token = "0x600E0A4")]
    [Address(RVA = "0x42529E0", Offset = "0x42529E0", VA = "0x42529E0")]
    public bool IsMovable(int x, int y) => new bool();

    [Token(Token = "0x600E0A5")]
    [Address(RVA = "0x4252AD4", Offset = "0x4252AD4", VA = "0x4252AD4")]
    public bool IsOccupiable(int x, int y) => new bool();

    [Token(Token = "0x600E0A6")]
    [Address(RVA = "0x4252B78", Offset = "0x4252B78", VA = "0x4252B78")]
    public bool IsOccupiableWithWarp(int x, int y) => new bool();

    [Token(Token = "0x600E0A7")]
    [Address(RVA = "0x4252BE8", Offset = "0x4252BE8", VA = "0x4252BE8")]
    public Node GetOccupiableNode(IGridData grid) => (Node) null;

    [Token(Token = "0x600E0A8")]
    [Address(RVA = "0x4252CF4", Offset = "0x4252CF4", VA = "0x4252CF4")]
    public Node GetNodeIfOccupiable(int x, int y) => (Node) null;

    [Token(Token = "0x600E0A9")]
    [Address(RVA = "0x4252DB0", Offset = "0x4252DB0", VA = "0x4252DB0")]
    private void AddOccupiable(Node node, Node movableParent)
    {
    }

    [Token(Token = "0x600E0AA")]
    [Address(RVA = "0x4252F34", Offset = "0x4252F34", VA = "0x4252F34")]
    public void SearchArea(
      int referenceX,
      int referenceY,
      IReadableUnitGridShapeData unitGridShape,
      int costThreshold,
      PathSearcher2D.NodeValidationCallback movaAreaValidation = null,
      PathSearcher2D.NodeValidationCallback occupyAreaValidation = null,
      bool considerWarp = false)
    {
    }

    [Token(Token = "0x600E0AB")]
    [Address(RVA = "0x4253194", Offset = "0x4253194", VA = "0x4253194")]
    private void SearchMovableArea(
      Node current,
      int costThreshold,
      bool considerWarp,
      PathSearcher2D.NodeValidationCallback validation)
    {
    }

    [Token(Token = "0x600E0AC")]
    [Address(RVA = "0x4253818", Offset = "0x4253818", VA = "0x4253818")]
    private void SearchOccupiableArea(
      IReadableUnitGridShapeData shapeData,
      PathSearcher2D.NodeValidationCallback validation)
    {
    }

    [Token(Token = "0x600E0AD")]
    [Address(RVA = "0x4253E18", Offset = "0x4253E18", VA = "0x4253E18")]
    private bool OccupiableValidation(
      Node node,
      Dictionary<(int x, int y), bool> validationResults,
      PathSearcher2D.NodeValidationCallback validationCallback)
    {
      return new bool();
    }

    [Token(Token = "0x600E0AE")]
    [Address(RVA = "0x4253F3C", Offset = "0x4253F3C", VA = "0x4253F3C", Slot = "4")]
    protected override Node OpenNode(int x, int y, Node parent) => (Node) null;
  }
}
