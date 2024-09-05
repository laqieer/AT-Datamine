// Decompiled with JetBrains decompiler
// Type: SerializableCollections.SerializableLookup`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

#nullable disable
namespace SerializableCollections
{
  [Token(Token = "0x20019B3")]
  [Serializable]
  public class SerializableLookup<TKey, TElement> : 
    ILookup<TKey, TElement>,
    IEnumerable<IGrouping<TKey, TElement>>,
    IEnumerable
  {
    [Token(Token = "0x4006E56")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    [HideInInspector]
    private int[] buckets;
    [Token(Token = "0x4006E57")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    [HideInInspector]
    private int count;
    [Token(Token = "0x4006E58")]
    [FieldOffset(Offset = "0x0")]
    [HideInInspector]
    [SerializeField]
    private int[] entriesHashCode;
    [Token(Token = "0x4006E59")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    [HideInInspector]
    private int[] entriesNext;
    [Token(Token = "0x4006E5A")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    [HideInInspector]
    private TKey[] entriesKey;
    [Token(Token = "0x4006E5B")]
    [FieldOffset(Offset = "0x0")]
    [HideInInspector]
    [SerializeField]
    private TElement[] entriesValue;
    [Token(Token = "0x4006E5C")]
    [FieldOffset(Offset = "0x0")]
    private int version;

    [Token(Token = "0x170017B1")]
    public virtual IEqualityComparer<TKey> Comparer
    {
      [Token(Token = "0x60092D0")] get => (IEqualityComparer<TKey>) null;
    }

    [Token(Token = "0x60092D1")]
    protected SerializableLookup()
    {
    }

    [Token(Token = "0x60092D2")]
    protected SerializableLookup(int initialCapacity)
    {
    }

    [Token(Token = "0x60092D3")]
    private SerializableLookup(int staticCapacity, bool forceSize)
    {
    }

    [Token(Token = "0x170017B2")]
    public int Count
    {
      [Token(Token = "0x60092D4")] get => new int();
    }

    [Token(Token = "0x170017B3")]
    public IEnumerable<TElement> this[TKey key]
    {
      [Token(Token = "0x60092D5")] get => (IEnumerable<TElement>) null;
    }

    [Token(Token = "0x60092D6")]
    public void Add(TKey key, TElement value)
    {
    }

    [Token(Token = "0x60092D7")]
    public void Clear()
    {
    }

    [Token(Token = "0x60092D8")]
    public bool Contains(TKey key) => new bool();

    [Token(Token = "0x60092D9")]
    private int FindEntry(TKey key) => new int();

    [Token(Token = "0x60092DA")]
    private IEnumerable<int> FindEntries(TKey key) => (IEnumerable<int>) null;

    [Token(Token = "0x60092DB")]
    private void Initialize(int capacity)
    {
    }

    [Token(Token = "0x60092DC")]
    private void Initialize(int capacity, bool forceSize)
    {
    }

    [Token(Token = "0x60092DD")]
    private void Insert(TKey key, TElement value)
    {
    }

    [Token(Token = "0x60092DE")]
    private void Resize()
    {
    }

    [Token(Token = "0x60092DF")]
    private void Resize(int newSize, bool forceNewHashCodes)
    {
    }

    [Token(Token = "0x60092E0")]
    public bool TryGetValue(TKey key, out TElement value) => new bool();

    [Token(Token = "0x60092E1")]
    public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
    {
      return (IEnumerator<IGrouping<TKey, TElement>>) null;
    }

    [Token(Token = "0x60092E2")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60092E3")]
    public void TrimExcess()
    {
    }

    [Token(Token = "0x20019B4")]
    private class Grouping : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
    {
      [Token(Token = "0x4006E5D")]
      [FieldOffset(Offset = "0x0")]
      private readonly SerializableLookup<TKey, TElement> lookup;

      [Token(Token = "0x170017B4")]
      public TKey Key
      {
        [Token(Token = "0x60092E4")] get => (TKey) null;
        [Token(Token = "0x60092E5")] private set
        {
        }
      }

      [Token(Token = "0x60092E6")]
      public Grouping(SerializableLookup<TKey, TElement> lookup, TKey key)
      {
      }

      [Token(Token = "0x60092E7")]
      public IEnumerator<TElement> GetEnumerator() => (IEnumerator<TElement>) null;

      [Token(Token = "0x60092E8")]
      private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
      {
        return (IEnumerator) null;
      }
    }

    [Token(Token = "0x20019B5")]
    private class LookupCollection : ICollection<TElement>, IEnumerable<TElement>, IEnumerable
    {
      [Token(Token = "0x4006E5F")]
      [FieldOffset(Offset = "0x0")]
      private readonly SerializableLookup<TKey, TElement> lookup;
      [Token(Token = "0x4006E60")]
      [FieldOffset(Offset = "0x0")]
      private readonly int version;
      [Token(Token = "0x4006E61")]
      [FieldOffset(Offset = "0x0")]
      private readonly List<int> indexes;

      [Token(Token = "0x60092E9")]
      public LookupCollection(SerializableLookup<TKey, TElement> lookup, TKey key)
      {
      }

      [Token(Token = "0x170017B5")]
      public int Count
      {
        [Token(Token = "0x60092EA")] get => new int();
      }

      [Token(Token = "0x170017B6")]
      public bool IsReadOnly
      {
        [Token(Token = "0x60092EB")] get => new bool();
      }

      [Token(Token = "0x60092EC")]
      public void Add(TElement item)
      {
      }

      [Token(Token = "0x60092ED")]
      public void Clear()
      {
      }

      [Token(Token = "0x60092EE")]
      public bool Contains(TElement item) => new bool();

      [Token(Token = "0x60092EF")]
      public void CopyTo(TElement[] array, int arrayIndex)
      {
      }

      [Token(Token = "0x60092F0")]
      public IEnumerator<TElement> GetEnumerator() => (IEnumerator<TElement>) null;

      [Token(Token = "0x60092F1")]
      public bool Remove(TElement item) => new bool();

      [Token(Token = "0x60092F2")]
      private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
      {
        return (IEnumerator) null;
      }
    }

    [Token(Token = "0x20019B7")]
    private static class SR
    {
      [Token(Token = "0x4006E66")]
      public const string InvalidOperation_EnumFailedVersion = "InvalidOperation_EnumFailedVersion";
      [Token(Token = "0x4006E67")]
      public const string InvalidOperation_EnumOpCantHappen = "InvalidOperation_EnumOpCantHappen";
      [Token(Token = "0x4006E68")]
      public const string ArgumentOutOfRange_Index = "ArgumentOutOfRange_Index";
      [Token(Token = "0x4006E69")]
      public const string Argument_InvalidArrayType = "Argument_InvalidArrayType";
      [Token(Token = "0x4006E6A")]
      public const string NotSupported_ValueCollectionSet = "NotSupported_ValueCollectionSet";
      [Token(Token = "0x4006E6B")]
      public const string Arg_RankMultiDimNotSupported = "Arg_RankMultiDimNotSupported";
      [Token(Token = "0x4006E6C")]
      public const string Arg_ArrayPlusOffTooSmall = "Arg_ArrayPlusOffTooSmall";
      [Token(Token = "0x4006E6D")]
      public const string Arg_NonZeroLowerBound = "Arg_NonZeroLowerBound";
      [Token(Token = "0x4006E6E")]
      public const string NotSupported_KeyCollectionSet = "NotSupported_KeyCollectionSet";
      [Token(Token = "0x4006E6F")]
      public const string Arg_WrongType = "Arg_WrongType";
      [Token(Token = "0x4006E70")]
      public const string ArgumentOutOfRange_NeedNonNegNum = "ArgumentOutOfRange_NeedNonNegNum";
      [Token(Token = "0x4006E71")]
      public const string Arg_HTCapacityOverflow = "Arg_HTCapacityOverflow";
      [Token(Token = "0x4006E72")]
      public const string Argument_AddingDuplicate = "Argument_AddingDuplicate";

      [Token(Token = "0x60092F9")]
      public static string Format(string f, params object[] args) => (string) null;
    }

    [Token(Token = "0x20019B8")]
    private static class HashHelpers
    {
      [Token(Token = "0x4006E73")]
      [FieldOffset(Offset = "0x0")]
      public static readonly int[] primes;
      [Token(Token = "0x4006E74")]
      public const int MaxPrimeArrayLength = 2146435069;

      [Token(Token = "0x60092FA")]
      public static int GetPrime(int min) => new int();

      [Token(Token = "0x60092FB")]
      public static int GetMinPrime() => new int();

      [Token(Token = "0x60092FC")]
      public static int ExpandPrime(int oldSize) => new int();

      [Token(Token = "0x60092FD")]
      static HashHelpers()
      {
      }
    }
  }
}
