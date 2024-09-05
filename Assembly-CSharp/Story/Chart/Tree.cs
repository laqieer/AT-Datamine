// Decompiled with JetBrains decompiler
// Type: Story.Chart.Tree
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006EA")]
  public class Tree
  {
    [Token(Token = "0x4002098")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<int, Node> NodeTable;

    [Token(Token = "0x170005D7")]
    public Node Root
    {
      [Token(Token = "0x600272E"), Address(RVA = "0x366C87C", Offset = "0x366C87C", VA = "0x366C87C")] get
      {
        return (Node) null;
      }
      [Token(Token = "0x600272F"), Address(RVA = "0x366C884", Offset = "0x366C884", VA = "0x366C884")] set
      {
      }
    }

    [Token(Token = "0x6002730")]
    [Address(RVA = "0x366C88C", Offset = "0x366C88C", VA = "0x366C88C")]
    public void SetNodeStatus(INodeStatus nodeStatus)
    {
    }

    [Token(Token = "0x6002731")]
    [Address(RVA = "0x366B964", Offset = "0x366B964", VA = "0x366B964")]
    public IEnumerator Calculate() => (IEnumerator) null;

    [Token(Token = "0x6002732")]
    [Address(RVA = "0x366CA0C", Offset = "0x366CA0C", VA = "0x366CA0C")]
    private IEnumerator CalculateIndises() => (IEnumerator) null;

    [Token(Token = "0x6002733")]
    [Address(RVA = "0x366CA9C", Offset = "0x366CA9C", VA = "0x366CA9C")]
    private IEnumerator CalculateNest() => (IEnumerator) null;

    [Token(Token = "0x170005D8")]
    public IEnumerable<Node> NodeList
    {
      [Token(Token = "0x6002734"), Address(RVA = "0x366CB2C", Offset = "0x366CB2C", VA = "0x366CB2C")] get
      {
        return (IEnumerable<Node>) null;
      }
    }

    [Token(Token = "0x170005D9")]
    public IEnumerable<Node> OrderedShowNodeList
    {
      [Token(Token = "0x6002735"), Address(RVA = "0x366CB7C", Offset = "0x366CB7C", VA = "0x366CB7C")] get
      {
        return (IEnumerable<Node>) null;
      }
    }

    [Token(Token = "0x6002736")]
    [Address(RVA = "0x366CDE0", Offset = "0x366CDE0", VA = "0x366CDE0")]
    public Node[] OrderedShowNodeArray() => (Node[]) null;

    [Token(Token = "0x6002737")]
    [Address(RVA = "0x366CE2C", Offset = "0x366CE2C", VA = "0x366CE2C")]
    public IEnumerable<Node> GetTerminalNodes() => (IEnumerable<Node>) null;

    [Token(Token = "0x6002738")]
    [Address(RVA = "0x366CF38", Offset = "0x366CF38", VA = "0x366CF38")]
    public Tree()
    {
    }
  }
}
