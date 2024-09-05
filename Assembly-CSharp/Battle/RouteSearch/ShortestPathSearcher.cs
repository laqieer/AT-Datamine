// Decompiled with JetBrains decompiler
// Type: Battle.RouteSearch.ShortestPathSearcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.RouteSearch
{
  [Token(Token = "0x20024A0")]
  public sealed class ShortestPathSearcher : PathSearcher2D
  {
    [Token(Token = "0x4009D11")]
    [FieldOffset(Offset = "0x38")]
    private PriorityQueue<Node> openedNodes;
    [Token(Token = "0x4009D12")]
    [FieldOffset(Offset = "0x40")]
    private int startX;
    [Token(Token = "0x4009D13")]
    [FieldOffset(Offset = "0x44")]
    private int startY;

    [Token(Token = "0x600E0F6")]
    [Address(RVA = "0x42554C0", Offset = "0x42554C0", VA = "0x42554C0")]
    public ShortestPathSearcher(Node[,] nodes)
    {
    }

    [Token(Token = "0x600E0F7")]
    [Address(RVA = "0x4255530", Offset = "0x4255530", VA = "0x4255530")]
    public void ChangeSeachNodes(Node[,] nodes, bool considerWarp = false)
    {
    }

    [Token(Token = "0x600E0F8")]
    [Address(RVA = "0x425555C", Offset = "0x425555C", VA = "0x425555C", Slot = "5")]
    public override void ClearResult()
    {
    }

    [Token(Token = "0x600E0F9")]
    [Address(RVA = "0x42555B8", Offset = "0x42555B8", VA = "0x42555B8")]
    public void SearchPath(
      int startX,
      int startY,
      int distanceX = -1,
      int distanceY = -1,
      PathSearcher2D.NodeValidationCallback movableValidation = null,
      PathSearcher2D.NodeValidationCallback occupiableValidation = null,
      bool considerWarp = false)
    {
    }

    [Token(Token = "0x600E0FA")]
    [Address(RVA = "0x4255790", Offset = "0x4255790", VA = "0x4255790")]
    private void SearchPathInternal(
      Node parent,
      int distanceX,
      int distanceY,
      PathSearcher2D.NodeValidationCallback movableValidation = null,
      PathSearcher2D.NodeValidationCallback occupiableValidation = null,
      bool considerWarp = false)
    {
    }
  }
}
