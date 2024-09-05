// Decompiled with JetBrains decompiler
// Type: Battle.RouteSearch.PriorityQueue`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Battle.RouteSearch
{
  [Token(Token = "0x200249F")]
  public class PriorityQueue<TKey> : IEnumerable<TKey>, IEnumerable
  {
    [Token(Token = "0x4009D0E")]
    [FieldOffset(Offset = "0x0")]
    private readonly List<TKey> data;
    [Token(Token = "0x4009D0F")]
    [FieldOffset(Offset = "0x0")]
    private readonly bool isDescending;
    [Token(Token = "0x4009D10")]
    [FieldOffset(Offset = "0x0")]
    private IComparer<TKey> comparer;

    [Token(Token = "0x600E0EA")]
    public PriorityQueue(IComparer<TKey> comparer, bool isDescending = true)
    {
    }

    [Token(Token = "0x600E0EB")]
    public void SetComparer(IComparer<TKey> comparer)
    {
    }

    [Token(Token = "0x600E0EC")]
    public void Enqueue(TKey key)
    {
    }

    [Token(Token = "0x600E0ED")]
    public TKey Dequeue() => (TKey) null;

    [Token(Token = "0x600E0EE")]
    public TKey Peek() => (TKey) null;

    [Token(Token = "0x600E0EF")]
    public void Clear()
    {
    }

    [Token(Token = "0x600E0F0")]
    private void Swap(int index1, int index2)
    {
    }

    [Token(Token = "0x600E0F1")]
    private int Compare(TKey a, TKey b) => new int();

    [Token(Token = "0x17003043")]
    public int Count
    {
      [Token(Token = "0x600E0F2")] get => new int();
    }

    [Token(Token = "0x600E0F3")]
    public IEnumerator<TKey> GetEnumerator() => (IEnumerator<TKey>) null;

    [Token(Token = "0x600E0F4")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600E0F5")]
    public static PriorityQueue<TKey> Create(
      IEnumerable<TKey> source,
      IComparer<TKey> comparer,
      bool isDescending = true)
    {
      return (PriorityQueue<TKey>) null;
    }
  }
}
