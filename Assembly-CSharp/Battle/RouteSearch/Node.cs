// Decompiled with JetBrains decompiler
// Type: Battle.RouteSearch.Node
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.RouteSearch
{
  [Token(Token = "0x200249A")]
  public sealed class Node
  {
    [Token(Token = "0x4009D00")]
    [FieldOffset(Offset = "0x38")]
    public bool ForceStop;

    [Token(Token = "0x600E0B4")]
    [Address(RVA = "0x425411C", Offset = "0x425411C", VA = "0x425411C")]
    public static int Distance(Node a, Node b) => new int();

    [Token(Token = "0x600E0B5")]
    [Address(RVA = "0x42541F4", Offset = "0x42541F4", VA = "0x42541F4")]
    public bool Equals(IGridData grid) => new bool();

    [Token(Token = "0x17003039")]
    public Vector2Int Coordinate
    {
      [Token(Token = "0x600E0B6"), Address(RVA = "0x42542B8", Offset = "0x42542B8", VA = "0x42542B8")] get
      {
        return new Vector2Int();
      }
      [Token(Token = "0x600E0B7"), Address(RVA = "0x42542C0", Offset = "0x42542C0", VA = "0x42542C0")] private set
      {
      }
    }

    [Token(Token = "0x1700303A")]
    public int RequiredCost
    {
      [Token(Token = "0x600E0B8"), Address(RVA = "0x42542C8", Offset = "0x42542C8", VA = "0x42542C8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E0B9"), Address(RVA = "0x42542D0", Offset = "0x42542D0", VA = "0x42542D0")] set
      {
      }
    }

    [Token(Token = "0x1700303B")]
    public int Cost
    {
      [Token(Token = "0x600E0BA"), Address(RVA = "0x42542D8", Offset = "0x42542D8", VA = "0x42542D8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E0BB"), Address(RVA = "0x42542E0", Offset = "0x42542E0", VA = "0x42542E0")] set
      {
      }
    }

    [Token(Token = "0x1700303C")]
    public int HuristicCost
    {
      [Token(Token = "0x600E0BC"), Address(RVA = "0x42542E8", Offset = "0x42542E8", VA = "0x42542E8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E0BD"), Address(RVA = "0x42542F0", Offset = "0x42542F0", VA = "0x42542F0")] private set
      {
      }
    }

    [Token(Token = "0x1700303D")]
    public int Score
    {
      [Token(Token = "0x600E0BE"), Address(RVA = "0x42542F8", Offset = "0x42542F8", VA = "0x42542F8")] get
      {
        return new int();
      }
      [Token(Token = "0x600E0BF"), Address(RVA = "0x4254300", Offset = "0x4254300", VA = "0x4254300")] private set
      {
      }
    }

    [Token(Token = "0x1700303E")]
    public LandTagEnum[] LandTags
    {
      [Token(Token = "0x600E0C0"), Address(RVA = "0x4254308", Offset = "0x4254308", VA = "0x4254308")] get
      {
        return (LandTagEnum[]) null;
      }
      [Token(Token = "0x600E0C1"), Address(RVA = "0x4254310", Offset = "0x4254310", VA = "0x4254310")] private set
      {
      }
    }

    [Token(Token = "0x1700303F")]
    public Vector2Int WarpOutCoord
    {
      [Token(Token = "0x600E0C2"), Address(RVA = "0x4254318", Offset = "0x4254318", VA = "0x4254318")] get
      {
        return new Vector2Int();
      }
      [Token(Token = "0x600E0C3"), Address(RVA = "0x4254320", Offset = "0x4254320", VA = "0x4254320")] private set
      {
      }
    }

    [Token(Token = "0x17003040")]
    public bool HasWarpOut
    {
      [Token(Token = "0x600E0C4"), Address(RVA = "0x4253E04", Offset = "0x4253E04", VA = "0x4253E04")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E0C5")]
    [Address(RVA = "0x4254328", Offset = "0x4254328", VA = "0x4254328")]
    public Node(
      int x,
      int y,
      int requiredCost,
      LandTagEnum[] tags,
      bool forceStop = false,
      int warpOutX = -1,
      int warpOutY = -1)
    {
    }

    [Token(Token = "0x600E0C6")]
    [Address(RVA = "0x425439C", Offset = "0x425439C", VA = "0x425439C")]
    private Node(Node copyFrom)
    {
    }

    [Token(Token = "0x600E0C7")]
    [Address(RVA = "0x42543F0", Offset = "0x42543F0", VA = "0x42543F0")]
    public Node Clone() => (Node) null;

    [Token(Token = "0x600E0C8")]
    [Address(RVA = "0x4254450", Offset = "0x4254450", VA = "0x4254450")]
    public int ClacHuristicCostTo(int x, int y) => new int();

    [Token(Token = "0x600E0C9")]
    [Address(RVA = "0x4252574", Offset = "0x4252574", VA = "0x4252574")]
    public void Open(Node parentNode)
    {
    }

    [Token(Token = "0x600E0CA")]
    [Address(RVA = "0x4254524", Offset = "0x4254524", VA = "0x4254524")]
    public void Reset()
    {
    }

    [Token(Token = "0x600E0CB")]
    [Address(RVA = "0x4254530", Offset = "0x4254530", VA = "0x4254530")]
    public void Reset(Node node)
    {
    }

    [Token(Token = "0x600E0CC")]
    [Address(RVA = "0x4254574", Offset = "0x4254574", VA = "0x4254574", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
