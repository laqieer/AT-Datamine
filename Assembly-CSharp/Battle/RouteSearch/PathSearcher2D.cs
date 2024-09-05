// Decompiled with JetBrains decompiler
// Type: Battle.RouteSearch.PathSearcher2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.RouteSearch
{
  [Token(Token = "0x200249C")]
  public abstract class PathSearcher2D
  {
    [Token(Token = "0x4009D05")]
    [FieldOffset(Offset = "0x0")]
    public static readonly int[,] SearchDirs;
    [Token(Token = "0x4009D06")]
    [FieldOffset(Offset = "0x10")]
    protected Node[,] nodes;
    [Token(Token = "0x4009D07")]
    [FieldOffset(Offset = "0x18")]
    protected Dictionary<Node, PathSearcher2D.NodeMapParam> nodeMap;
    [Token(Token = "0x4009D08")]
    [FieldOffset(Offset = "0x20")]
    protected int lengthX;
    [Token(Token = "0x4009D09")]
    [FieldOffset(Offset = "0x24")]
    protected int lengthY;
    [Token(Token = "0x4009D0A")]
    [FieldOffset(Offset = "0x28")]
    public List<Node> HitNodes;
    [Token(Token = "0x4009D0B")]
    [FieldOffset(Offset = "0x30")]
    protected Dictionary<(int x, int y), int> hitIndexWithPosition;

    [Token(Token = "0x600E0CD")]
    [Address(RVA = "0x42517C0", Offset = "0x42517C0", VA = "0x42517C0")]
    protected PathSearcher2D(
      Node[,] nodes,
      Dictionary<LandTagEnum, int> overrideCost = null,
      List<Vector2Int> forceStop = null,
      bool considerWarp = false)
    {
    }

    [Token(Token = "0x600E0CE")]
    [Address(RVA = "0x42548B4", Offset = "0x42548B4", VA = "0x42548B4")]
    public void ChangeSeachNodes(Node[,] nodes)
    {
    }

    [Token(Token = "0x600E0CF")]
    [Address(RVA = "0x4254760", Offset = "0x4254760", VA = "0x4254760")]
    private void CreateNode(
      Node[,] src,
      Dictionary<LandTagEnum, int> overrideCost,
      List<Vector2Int> forceStop,
      bool considerWarp)
    {
    }

    [Token(Token = "0x600E0D0")]
    [Address(RVA = "0x42548E0", Offset = "0x42548E0", VA = "0x42548E0")]
    private void CreateNode(
      Node[,] src,
      int x,
      int y,
      Dictionary<LandTagEnum, int> overrideCost,
      List<Vector2Int> forceStop,
      bool considerWarp)
    {
    }

    [Token(Token = "0x600E0D1")]
    [Address(RVA = "0x42526E8", Offset = "0x42526E8", VA = "0x42526E8")]
    protected void ChangeNode(
      Node[,] src,
      Dictionary<LandTagEnum, int> overrideCost,
      List<Vector2Int> forceStop,
      bool considerWarp)
    {
    }

    [Token(Token = "0x600E0D2")]
    [Address(RVA = "0x4254D64", Offset = "0x4254D64", VA = "0x4254D64")]
    private void ChangeNode(
      Node[,] src,
      int x,
      int y,
      Dictionary<LandTagEnum, int> overrideCost,
      List<Vector2Int> forceStop,
      bool considerWarp)
    {
    }

    [Token(Token = "0x600E0D3")]
    [Address(RVA = "0x4251D50", Offset = "0x4251D50", VA = "0x4251D50")]
    public void ResetNodes()
    {
    }

    [Token(Token = "0x600E0D4")]
    [Address(RVA = "0x4254F3C", Offset = "0x4254F3C", VA = "0x4254F3C", Slot = "4")]
    protected virtual Node OpenNode(int x, int y, Node parent) => (Node) null;

    [Token(Token = "0x600E0D5")]
    [Address(RVA = "0x4251DD8", Offset = "0x4251DD8", VA = "0x4251DD8")]
    protected Node GetNodeAt(int x, int y) => (Node) null;

    [Token(Token = "0x600E0D6")]
    [Address(RVA = "0x4252858", Offset = "0x4252858", VA = "0x4252858", Slot = "5")]
    public virtual void ClearResult()
    {
    }

    [Token(Token = "0x600E0D7")]
    [Address(RVA = "0x4254BC4", Offset = "0x4254BC4", VA = "0x4254BC4")]
    private void OverrideNodeFromLand(Node node, Dictionary<LandTagEnum, int> overrideCost)
    {
    }

    [Token(Token = "0x600E0D8")]
    [Address(RVA = "0x4252180", Offset = "0x4252180", VA = "0x4252180")]
    protected void AddHitNode(Node node)
    {
    }

    [Token(Token = "0x600E0D9")]
    [Address(RVA = "0x42529F8", Offset = "0x42529F8", VA = "0x42529F8")]
    public Node GetHitNodeAt(int x, int y) => (Node) null;

    [Token(Token = "0x600E0DA")]
    [Address(RVA = "0x4255018", Offset = "0x4255018", VA = "0x4255018")]
    public Node GetHitNodeAt(Vector2Int coordinate) => (Node) null;

    [Token(Token = "0x600E0DB")]
    [Address(RVA = "0x4252BD0", Offset = "0x4252BD0", VA = "0x4252BD0")]
    public Node GetHitNodeParent(Node node) => (Node) null;

    [Token(Token = "0x600E0DC")]
    [Address(RVA = "0x425244C", Offset = "0x425244C", VA = "0x425244C")]
    public Node GetHitNodeParentAt(int x, int y) => (Node) null;

    [Token(Token = "0x600E0DD")]
    [Address(RVA = "0x4255020", Offset = "0x4255020", VA = "0x4255020")]
    public Node GetHitNodeParentAt(Vector2Int coord) => (Node) null;

    [Token(Token = "0x600E0DE")]
    [Address(RVA = "0x4251F60", Offset = "0x4251F60", VA = "0x4251F60")]
    public void SortHitNode(IComparer<Node> comparer)
    {
    }

    [Token(Token = "0x600E0DF")]
    [Address(RVA = "0x4255028", Offset = "0x4255028", VA = "0x4255028")]
    public string DumpResult() => (string) null;

    [Token(Token = "0x600E0E0")]
    [Address(RVA = "0x4255270", Offset = "0x4255270", VA = "0x4255270")]
    static PathSearcher2D()
    {
    }

    [Token(Token = "0x200249D")]
    public class NodeMapParam
    {
      [Token(Token = "0x17003041")]
      public Node Parent
      {
        [Token(Token = "0x600E0E1"), Address(RVA = "0x425531C", Offset = "0x425531C", VA = "0x425531C")] get
        {
          return (Node) null;
        }
        [Token(Token = "0x600E0E2"), Address(RVA = "0x4255324", Offset = "0x4255324", VA = "0x4255324")] set
        {
        }
      }

      [Token(Token = "0x17003042")]
      public NodeStatus Status
      {
        [Token(Token = "0x600E0E3"), Address(RVA = "0x425532C", Offset = "0x425532C", VA = "0x425532C")] get
        {
          return new NodeStatus();
        }
        [Token(Token = "0x600E0E4"), Address(RVA = "0x4255334", Offset = "0x4255334", VA = "0x4255334")] set
        {
        }
      }

      [Token(Token = "0x600E0E5")]
      [Address(RVA = "0x4254BBC", Offset = "0x4254BBC", VA = "0x4254BBC")]
      public NodeMapParam()
      {
      }
    }

    [Token(Token = "0x200249E")]
    public delegate bool NodeValidationCallback(Vector2Int coord);
  }
}
