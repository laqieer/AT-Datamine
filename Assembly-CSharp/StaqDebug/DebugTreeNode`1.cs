// Decompiled with JetBrains decompiler
// Type: StaqDebug.DebugTreeNode`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace StaqDebug
{
  [Token(Token = "0x2001F50")]
  public class DebugTreeNode<T> where T : new()
  {
    [Token(Token = "0x4008626")]
    [FieldOffset(Offset = "0x0")]
    private DebugTreeNode<T> parent;
    [Token(Token = "0x4008627")]
    [FieldOffset(Offset = "0x0")]
    private List<DebugTreeNode<T>> children;
    [Token(Token = "0x4008628")]
    [FieldOffset(Offset = "0x0")]
    private T genericValue;
    [Token(Token = "0x4008629")]
    [FieldOffset(Offset = "0x0")]
    private DebugTreeNode<T>.OnSelectEvent onSelect;
    [Token(Token = "0x400862A")]
    [FieldOffset(Offset = "0x0")]
    private DebugTreeNode<T>.OnSearchEvent onSearch;

    [Token(Token = "0x17002698")]
    public string FullPath
    {
      [Token(Token = "0x600B9D1")] get => (string) null;
      [Token(Token = "0x600B9D2")] set
      {
      }
    }

    [Token(Token = "0x17002699")]
    public string Name
    {
      [Token(Token = "0x600B9D3")] get => (string) null;
      [Token(Token = "0x600B9D4")] set
      {
      }
    }

    [Token(Token = "0x1700269A")]
    public string ToolTip
    {
      [Token(Token = "0x600B9D5")] get => (string) null;
      [Token(Token = "0x600B9D6")] set
      {
      }
    }

    [Token(Token = "0x1700269B")]
    public int Depth
    {
      [Token(Token = "0x600B9D7")] get => new int();
      [Token(Token = "0x600B9D8")] set
      {
      }
    }

    [Token(Token = "0x1700269C")]
    public Vector2 VerticalScrollPos
    {
      [Token(Token = "0x600B9D9")] set
      {
      }
      [Token(Token = "0x600B9DA")] get => new Vector2();
    }

    [Token(Token = "0x1700269D")]
    public T GenericValue
    {
      [Token(Token = "0x600B9DB")] get => (T) null;
    }

    [Token(Token = "0x1700269E")]
    public DebugTreeNode<T> Parent
    {
      [Token(Token = "0x600B9DC")] get => (DebugTreeNode<T>) null;
    }

    [Token(Token = "0x1700269F")]
    public List<DebugTreeNode<T>> Children
    {
      [Token(Token = "0x600B9DD")] get => (List<DebugTreeNode<T>>) null;
    }

    [Token(Token = "0x170026A0")]
    public DebugTreeNode<T> Root
    {
      [Token(Token = "0x600B9DE")] get => (DebugTreeNode<T>) null;
    }

    [Token(Token = "0x170026A1")]
    public bool isRoot
    {
      [Token(Token = "0x600B9DF")] get => new bool();
    }

    [Token(Token = "0x170026A2")]
    public bool isLeaf
    {
      [Token(Token = "0x600B9E0")] get => new bool();
    }

    [Token(Token = "0x170026A3")]
    public bool IsEdge
    {
      [Token(Token = "0x600B9E1")] get => new bool();
      [Token(Token = "0x600B9E2")] set
      {
      }
    }

    [Token(Token = "0x170026A4")]
    public string[] Names
    {
      [Token(Token = "0x600B9E3")] get => (string[]) null;
    }

    [Token(Token = "0x170026A5")]
    public DebugTreeNode<T>.OnSelectEvent OnSelect
    {
      [Token(Token = "0x600B9E4")] get => (DebugTreeNode<T>.OnSelectEvent) null;
      [Token(Token = "0x600B9E5")] set
      {
      }
    }

    [Token(Token = "0x170026A6")]
    public DebugTreeNode<T>.OnSearchEvent OnSearch
    {
      [Token(Token = "0x600B9E6")] get => (DebugTreeNode<T>.OnSearchEvent) null;
      [Token(Token = "0x600B9E7")] set
      {
      }
    }

    [Token(Token = "0x600B9E8")]
    public DebugTreeNode(string name)
    {
    }

    [Token(Token = "0x600B9E9")]
    public DebugTreeNode<T> Clone() => (DebugTreeNode<T>) null;

    [Token(Token = "0x600B9EA")]
    private void CloneChildren(DebugTreeNode<T> newParent)
    {
    }

    [Token(Token = "0x600B9EB")]
    public DebugTreeNode<T> Add(string name) => (DebugTreeNode<T>) null;

    [Token(Token = "0x600B9EC")]
    public void Clear()
    {
    }

    [Token(Token = "0x600B9ED")]
    public void Add(DebugTreeNode<T> child)
    {
    }

    [Token(Token = "0x600B9EE")]
    public static DebugTreeNode<T> Add(DebugTreeNode<T> tree, string label, int depth)
    {
      return (DebugTreeNode<T>) null;
    }

    [Token(Token = "0x600B9EF")]
    public static DebugTreeNode<T> Add(DebugTreeNode<T> tree, string[] splitedLabels, int depth)
    {
      return (DebugTreeNode<T>) null;
    }

    [Token(Token = "0x600B9F0")]
    internal List<DebugTreeNode<T>> FindNodes(string keyword) => (List<DebugTreeNode<T>>) null;

    [Token(Token = "0x600B9F1")]
    private void FindNodes(List<DebugTreeNode<T>> result, string keyword)
    {
    }

    [Token(Token = "0x600B9F2")]
    internal List<DebugTreeNode<T>> FindLeafNodes(string keyword) => (List<DebugTreeNode<T>>) null;

    [Token(Token = "0x600B9F3")]
    private void GetLeafNodes(List<DebugTreeNode<T>> result, DebugTreeNode<T> node)
    {
    }

    [Token(Token = "0x600B9F4")]
    private string GetFullPath() => (string) null;

    [Token(Token = "0x600B9F5")]
    private void InternalGetFullPath(List<string> paths)
    {
    }

    [Token(Token = "0x600B9F6")]
    public void UpdateDepth()
    {
    }

    [Token(Token = "0x600B9F7")]
    public void Sort()
    {
    }

    [Token(Token = "0x2001F51")]
    public delegate void OnSelectEvent(DebugTreeNode<T> tree) where T : new();

    [Token(Token = "0x2001F52")]
    public delegate bool OnSearchEvent(string keyword, DebugTreeNode<T> tree) where T : new();
  }
}
