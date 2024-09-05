// Decompiled with JetBrains decompiler
// Type: SerializableCollections.SerializableDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

#nullable disable
namespace SerializableCollections
{
  [Token(Token = "0x20019A8")]
  [Serializable]
  public class SerializableDictionary<TKey, TValue> : 
    IDictionary<TKey, TValue>,
    ICollection<KeyValuePair<TKey, TValue>>,
    IEnumerable<KeyValuePair<TKey, TValue>>,
    IEnumerable,
    IDictionary,
    ICollection
  {
    [Token(Token = "0x4006E27")]
    [FieldOffset(Offset = "0x0")]
    [HideInInspector]
    [SerializeField]
    private int[] buckets;
    [Token(Token = "0x4006E28")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    [HideInInspector]
    private int count;
    [Token(Token = "0x4006E29")]
    [FieldOffset(Offset = "0x0")]
    [HideInInspector]
    [SerializeField]
    private int[] entriesHashCode;
    [Token(Token = "0x4006E2A")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    [HideInInspector]
    private int[] entriesNext;
    [Token(Token = "0x4006E2B")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    [HideInInspector]
    private TKey[] entriesKey;
    [Token(Token = "0x4006E2C")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    [HideInInspector]
    private TValue[] entriesValue;
    [Token(Token = "0x4006E2D")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    [HideInInspector]
    private int freeCount;
    [Token(Token = "0x4006E2E")]
    [FieldOffset(Offset = "0x0")]
    [HideInInspector]
    [SerializeField]
    private int freeList;
    [Token(Token = "0x4006E2F")]
    [FieldOffset(Offset = "0x0")]
    private int version;
    [Token(Token = "0x4006E30")]
    [FieldOffset(Offset = "0x0")]
    private SerializableDictionary<TKey, TValue>.KeyCollection keys;
    [Token(Token = "0x4006E31")]
    [FieldOffset(Offset = "0x0")]
    private SerializableDictionary<TKey, TValue>.ValueCollection values;
    [Token(Token = "0x4006E32")]
    [FieldOffset(Offset = "0x0")]
    private object _syncRoot;

    [Token(Token = "0x1700178E")]
    public virtual IEqualityComparer<TKey> Comparer
    {
      [Token(Token = "0x6009265")] get => (IEqualityComparer<TKey>) null;
    }

    [Token(Token = "0x6009266")]
    protected SerializableDictionary()
    {
    }

    [Token(Token = "0x6009267")]
    protected SerializableDictionary(int initialCapacity)
    {
    }

    [Token(Token = "0x6009268")]
    private SerializableDictionary(int staticCapacity, bool forceSize)
    {
    }

    [Token(Token = "0x1700178F")]
    public int Count
    {
      [Token(Token = "0x6009269")] get => new int();
    }

    [Token(Token = "0x17001790")]
    public SerializableDictionary<TKey, TValue>.KeyCollection Keys
    {
      [Token(Token = "0x600926A")] get => (SerializableDictionary<TKey, TValue>.KeyCollection) null;
    }

    [Token(Token = "0x17001791")]
    private ICollection<TKey> System\u002ECollections\u002EGeneric\u002EIDictionary\u003CTKey\u002CTValue\u003E\u002EKeys
    {
      [Token(Token = "0x600926B")] get => (ICollection<TKey>) null;
    }

    [Token(Token = "0x17001792")]
    public SerializableDictionary<TKey, TValue>.ValueCollection Values
    {
      [Token(Token = "0x600926C")] get
      {
        return (SerializableDictionary<TKey, TValue>.ValueCollection) null;
      }
    }

    [Token(Token = "0x17001793")]
    private ICollection<TValue> System\u002ECollections\u002EGeneric\u002EIDictionary\u003CTKey\u002CTValue\u003E\u002EValues
    {
      [Token(Token = "0x600926D")] get => (ICollection<TValue>) null;
    }

    [Token(Token = "0x17001794")]
    public TValue this[TKey key]
    {
      [Token(Token = "0x600926E")] get => (TValue) null;
      [Token(Token = "0x600926F")] set
      {
      }
    }

    [Token(Token = "0x6009270")]
    public void Add(TKey key, TValue value)
    {
    }

    [Token(Token = "0x6009271")]
    private void System\u002ECollections\u002EGeneric\u002EICollection\u003CSystem\u002ECollections\u002EGeneric\u002EKeyValuePair\u003CTKey\u002CTValue\u003E\u003E\u002EAdd(
      KeyValuePair<TKey, TValue> keyValuePair)
    {
    }

    [Token(Token = "0x6009272")]
    private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CSystem\u002ECollections\u002EGeneric\u002EKeyValuePair\u003CTKey\u002CTValue\u003E\u003E\u002EContains(
      KeyValuePair<TKey, TValue> keyValuePair)
    {
      return new bool();
    }

    [Token(Token = "0x6009273")]
    private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CSystem\u002ECollections\u002EGeneric\u002EKeyValuePair\u003CTKey\u002CTValue\u003E\u003E\u002ERemove(
      KeyValuePair<TKey, TValue> keyValuePair)
    {
      return new bool();
    }

    [Token(Token = "0x6009274")]
    public void Clear()
    {
    }

    [Token(Token = "0x6009275")]
    public bool ContainsKey(TKey key) => new bool();

    [Token(Token = "0x6009276")]
    public bool ContainsValue(TValue value) => new bool();

    [Token(Token = "0x6009277")]
    private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
    {
    }

    [Token(Token = "0x6009278")]
    public SerializableDictionary<TKey, TValue>.Enumerator GetEnumerator()
    {
      return new SerializableDictionary<TKey, TValue>.Enumerator();
    }

    [Token(Token = "0x6009279")]
    private IEnumerator<KeyValuePair<TKey, TValue>> System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CSystem\u002ECollections\u002EGeneric\u002EKeyValuePair\u003CTKey\u002CTValue\u003E\u003E\u002EGetEnumerator()
    {
      return (IEnumerator<KeyValuePair<TKey, TValue>>) null;
    }

    [Token(Token = "0x600927A")]
    private int FindEntry(TKey key) => new int();

    [Token(Token = "0x600927B")]
    private void Initialize(int capacity)
    {
    }

    [Token(Token = "0x600927C")]
    private void Initialize(int capacity, bool forceSize)
    {
    }

    [Token(Token = "0x600927D")]
    private void Insert(TKey key, TValue value, bool add)
    {
    }

    [Token(Token = "0x600927E")]
    private void Resize()
    {
    }

    [Token(Token = "0x600927F")]
    private void Resize(int newSize, bool forceNewHashCodes)
    {
    }

    [Token(Token = "0x6009280")]
    public bool Remove(TKey key) => new bool();

    [Token(Token = "0x6009281")]
    public bool TryGetValue(TKey key, out TValue value) => new bool();

    [Token(Token = "0x17001795")]
    private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CSystem\u002ECollections\u002EGeneric\u002EKeyValuePair\u003CTKey\u002CTValue\u003E\u003E\u002EIsReadOnly
    {
      [Token(Token = "0x6009282")] get => new bool();
    }

    [Token(Token = "0x6009283")]
    private void System\u002ECollections\u002EGeneric\u002EICollection\u003CSystem\u002ECollections\u002EGeneric\u002EKeyValuePair\u003CTKey\u002CTValue\u003E\u003E\u002ECopyTo(
      KeyValuePair<TKey, TValue>[] array,
      int index)
    {
    }

    [Token(Token = "0x6009284")]
    private void System\u002ECollections\u002EICollection\u002ECopyTo(Array array, int index)
    {
    }

    [Token(Token = "0x6009285")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x17001796")]
    private bool System\u002ECollections\u002EICollection\u002EIsSynchronized
    {
      [Token(Token = "0x6009286")] get => new bool();
    }

    [Token(Token = "0x17001797")]
    private object System\u002ECollections\u002EICollection\u002ESyncRoot
    {
      [Token(Token = "0x6009287")] get => (object) null;
    }

    [Token(Token = "0x17001798")]
    private bool System\u002ECollections\u002EIDictionary\u002EIsFixedSize
    {
      [Token(Token = "0x6009288")] get => new bool();
    }

    [Token(Token = "0x17001799")]
    private bool System\u002ECollections\u002EIDictionary\u002EIsReadOnly
    {
      [Token(Token = "0x6009289")] get => new bool();
    }

    [Token(Token = "0x1700179A")]
    private ICollection System\u002ECollections\u002EIDictionary\u002EKeys
    {
      [Token(Token = "0x600928A")] get => (ICollection) null;
    }

    [Token(Token = "0x1700179B")]
    private ICollection System\u002ECollections\u002EIDictionary\u002EValues
    {
      [Token(Token = "0x600928B")] get => (ICollection) null;
    }

    [Token(Token = "0x600928C")]
    private object System\u002ECollections\u002EIDictionary\u002Eget_Item(object key)
    {
      return (object) null;
    }

    [Token(Token = "0x600928D")]
    private void System\u002ECollections\u002EIDictionary\u002Eset_Item(object key, object value)
    {
    }

    [Token(Token = "0x600928E")]
    private static bool IsCompatibleKey(object key) => new bool();

    [Token(Token = "0x600928F")]
    private void System\u002ECollections\u002EIDictionary\u002EAdd(object key, object value)
    {
    }

    [Token(Token = "0x6009290")]
    private bool System\u002ECollections\u002EIDictionary\u002EContains(object key) => new bool();

    [Token(Token = "0x6009291")]
    private IDictionaryEnumerator System\u002ECollections\u002EIDictionary\u002EGetEnumerator()
    {
      return (IDictionaryEnumerator) null;
    }

    [Token(Token = "0x6009292")]
    private void System\u002ECollections\u002EIDictionary\u002ERemove(object key)
    {
    }

    [Token(Token = "0x6009293")]
    public void TrimExcess()
    {
    }

    [Token(Token = "0x20019A9")]
    public struct Enumerator : 
      IEnumerator<KeyValuePair<TKey, TValue>>,
      IEnumerator,
      IDisposable,
      IDictionaryEnumerator
    {
      [Token(Token = "0x4006E33")]
      [FieldOffset(Offset = "0x0")]
      private SerializableDictionary<TKey, TValue> dictionary;
      [Token(Token = "0x4006E34")]
      [FieldOffset(Offset = "0x0")]
      private int version;
      [Token(Token = "0x4006E35")]
      [FieldOffset(Offset = "0x0")]
      private int index;
      [Token(Token = "0x4006E36")]
      [FieldOffset(Offset = "0x0")]
      private KeyValuePair<TKey, TValue> current;
      [Token(Token = "0x4006E37")]
      [FieldOffset(Offset = "0x0")]
      private int getEnumeratorRetType;
      [Token(Token = "0x4006E38")]
      internal const int DictEntry = 1;
      [Token(Token = "0x4006E39")]
      internal const int KeyValuePair = 2;

      [Token(Token = "0x6009294")]
      internal Enumerator(SerializableDictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
      {
      }

      [Token(Token = "0x6009295")]
      public bool MoveNext() => new bool();

      [Token(Token = "0x1700179D")]
      public KeyValuePair<TKey, TValue> Current
      {
        [Token(Token = "0x6009296")] get => new KeyValuePair<TKey, TValue>();
      }

      [Token(Token = "0x6009297")]
      public void Dispose()
      {
      }

      [Token(Token = "0x1700179E")]
      private object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [Token(Token = "0x6009298")] get => (object) null;
      }

      [Token(Token = "0x6009299")]
      private void System\u002ECollections\u002EIEnumerator\u002EReset()
      {
      }

      [Token(Token = "0x1700179F")]
      private DictionaryEntry System\u002ECollections\u002EIDictionaryEnumerator\u002EEntry
      {
        [Token(Token = "0x600929A")] get => new DictionaryEntry();
      }

      [Token(Token = "0x170017A0")]
      private object System\u002ECollections\u002EIDictionaryEnumerator\u002EKey
      {
        [Token(Token = "0x600929B")] get => (object) null;
      }

      [Token(Token = "0x170017A1")]
      private object System\u002ECollections\u002EIDictionaryEnumerator\u002EValue
      {
        [Token(Token = "0x600929C")] get => (object) null;
      }
    }

    [Token(Token = "0x20019AA")]
    [DebuggerDisplay("Count = {Count}")]
    [DebuggerTypeProxy(typeof (DictionaryKeyCollectionDebugView<,>))]
    public sealed class KeyCollection : 
      ICollection<TKey>,
      IEnumerable<TKey>,
      IEnumerable,
      ICollection
    {
      [Token(Token = "0x4006E3A")]
      [FieldOffset(Offset = "0x0")]
      private SerializableDictionary<TKey, TValue> dictionary;

      [Token(Token = "0x600929D")]
      public KeyCollection(SerializableDictionary<TKey, TValue> dictionary)
      {
      }

      [Token(Token = "0x600929E")]
      public SerializableDictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
      {
        return new SerializableDictionary<TKey, TValue>.KeyCollection.Enumerator();
      }

      [Token(Token = "0x600929F")]
      public void CopyTo(TKey[] array, int index)
      {
      }

      [Token(Token = "0x170017A2")]
      public int Count
      {
        [Token(Token = "0x60092A0")] get => new int();
      }

      [Token(Token = "0x170017A3")]
      private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CTKey\u003E\u002EIsReadOnly
      {
        [Token(Token = "0x60092A1")] get => new bool();
      }

      [Token(Token = "0x60092A2")]
      private void System\u002ECollections\u002EGeneric\u002EICollection\u003CTKey\u003E\u002EAdd(
        TKey item)
      {
      }

      [Token(Token = "0x60092A3")]
      private void System\u002ECollections\u002EGeneric\u002EICollection\u003CTKey\u003E\u002EClear()
      {
      }

      [Token(Token = "0x60092A4")]
      private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CTKey\u003E\u002EContains(
        TKey item)
      {
        return new bool();
      }

      [Token(Token = "0x60092A5")]
      private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CTKey\u003E\u002ERemove(
        TKey item)
      {
        return new bool();
      }

      [Token(Token = "0x60092A6")]
      private IEnumerator<TKey> System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CTKey\u003E\u002EGetEnumerator()
      {
        return (IEnumerator<TKey>) null;
      }

      [Token(Token = "0x60092A7")]
      private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x60092A8")]
      private void System\u002ECollections\u002EICollection\u002ECopyTo(Array array, int index)
      {
      }

      [Token(Token = "0x170017A4")]
      private bool System\u002ECollections\u002EICollection\u002EIsSynchronized
      {
        [Token(Token = "0x60092A9")] get => new bool();
      }

      [Token(Token = "0x170017A5")]
      private object System\u002ECollections\u002EICollection\u002ESyncRoot
      {
        [Token(Token = "0x60092AA")] get => (object) null;
      }

      [Token(Token = "0x20019AB")]
      public struct Enumerator : IEnumerator<TKey>, IEnumerator, IDisposable
      {
        [Token(Token = "0x4006E3B")]
        [FieldOffset(Offset = "0x0")]
        private SerializableDictionary<TKey, TValue> dictionary;
        [Token(Token = "0x4006E3C")]
        [FieldOffset(Offset = "0x0")]
        private int index;
        [Token(Token = "0x4006E3D")]
        [FieldOffset(Offset = "0x0")]
        private int version;
        [Token(Token = "0x4006E3E")]
        [FieldOffset(Offset = "0x0")]
        private TKey currentKey;

        [Token(Token = "0x60092AB")]
        internal Enumerator(SerializableDictionary<TKey, TValue> dictionary)
        {
        }

        [Token(Token = "0x60092AC")]
        public void Dispose()
        {
        }

        [Token(Token = "0x60092AD")]
        public bool MoveNext() => new bool();

        [Token(Token = "0x170017A6")]
        public TKey Current
        {
          [Token(Token = "0x60092AE")] get => (TKey) null;
        }

        [Token(Token = "0x170017A7")]
        private object System\u002ECollections\u002EIEnumerator\u002ECurrent
        {
          [Token(Token = "0x60092AF")] get => (object) null;
        }

        [Token(Token = "0x60092B0")]
        private void System\u002ECollections\u002EIEnumerator\u002EReset()
        {
        }
      }
    }

    [Token(Token = "0x20019AC")]
    [DebuggerDisplay("Count = {Count}")]
    [DebuggerTypeProxy(typeof (DictionaryValueCollectionDebugView<,>))]
    public sealed class ValueCollection : 
      ICollection<TValue>,
      IEnumerable<TValue>,
      IEnumerable,
      ICollection
    {
      [Token(Token = "0x4006E3F")]
      [FieldOffset(Offset = "0x0")]
      private SerializableDictionary<TKey, TValue> dictionary;

      [Token(Token = "0x60092B1")]
      public ValueCollection(SerializableDictionary<TKey, TValue> dictionary)
      {
      }

      [Token(Token = "0x60092B2")]
      public SerializableDictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
      {
        return new SerializableDictionary<TKey, TValue>.ValueCollection.Enumerator();
      }

      [Token(Token = "0x60092B3")]
      public void CopyTo(TValue[] array, int index)
      {
      }

      [Token(Token = "0x170017A8")]
      public int Count
      {
        [Token(Token = "0x60092B4")] get => new int();
      }

      [Token(Token = "0x170017A9")]
      private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CTValue\u003E\u002EIsReadOnly
      {
        [Token(Token = "0x60092B5")] get => new bool();
      }

      [Token(Token = "0x60092B6")]
      private void System\u002ECollections\u002EGeneric\u002EICollection\u003CTValue\u003E\u002EAdd(
        TValue item)
      {
      }

      [Token(Token = "0x60092B7")]
      private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CTValue\u003E\u002ERemove(
        TValue item)
      {
        return new bool();
      }

      [Token(Token = "0x60092B8")]
      private void System\u002ECollections\u002EGeneric\u002EICollection\u003CTValue\u003E\u002EClear()
      {
      }

      [Token(Token = "0x60092B9")]
      private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CTValue\u003E\u002EContains(
        TValue item)
      {
        return new bool();
      }

      [Token(Token = "0x60092BA")]
      private IEnumerator<TValue> System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CTValue\u003E\u002EGetEnumerator()
      {
        return (IEnumerator<TValue>) null;
      }

      [Token(Token = "0x60092BB")]
      private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x60092BC")]
      private void System\u002ECollections\u002EICollection\u002ECopyTo(Array array, int index)
      {
      }

      [Token(Token = "0x170017AA")]
      private bool System\u002ECollections\u002EICollection\u002EIsSynchronized
      {
        [Token(Token = "0x60092BD")] get => new bool();
      }

      [Token(Token = "0x170017AB")]
      private object System\u002ECollections\u002EICollection\u002ESyncRoot
      {
        [Token(Token = "0x60092BE")] get => (object) null;
      }

      [Token(Token = "0x20019AD")]
      public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
      {
        [Token(Token = "0x4006E40")]
        [FieldOffset(Offset = "0x0")]
        private SerializableDictionary<TKey, TValue> dictionary;
        [Token(Token = "0x4006E41")]
        [FieldOffset(Offset = "0x0")]
        private int index;
        [Token(Token = "0x4006E42")]
        [FieldOffset(Offset = "0x0")]
        private int version;
        [Token(Token = "0x4006E43")]
        [FieldOffset(Offset = "0x0")]
        private TValue currentValue;

        [Token(Token = "0x60092BF")]
        internal Enumerator(SerializableDictionary<TKey, TValue> dictionary)
        {
        }

        [Token(Token = "0x60092C0")]
        public void Dispose()
        {
        }

        [Token(Token = "0x60092C1")]
        public bool MoveNext() => new bool();

        [Token(Token = "0x170017AC")]
        public TValue Current
        {
          [Token(Token = "0x60092C2")] get => (TValue) null;
        }

        [Token(Token = "0x170017AD")]
        private object System\u002ECollections\u002EIEnumerator\u002ECurrent
        {
          [Token(Token = "0x60092C3")] get => (object) null;
        }

        [Token(Token = "0x60092C4")]
        private void System\u002ECollections\u002EIEnumerator\u002EReset()
        {
        }
      }
    }

    [Token(Token = "0x20019AE")]
    private static class SR
    {
      [Token(Token = "0x4006E44")]
      public const string InvalidOperation_EnumFailedVersion = "InvalidOperation_EnumFailedVersion";
      [Token(Token = "0x4006E45")]
      public const string InvalidOperation_EnumOpCantHappen = "InvalidOperation_EnumOpCantHappen";
      [Token(Token = "0x4006E46")]
      public const string ArgumentOutOfRange_Index = "ArgumentOutOfRange_Index";
      [Token(Token = "0x4006E47")]
      public const string Argument_InvalidArrayType = "Argument_InvalidArrayType";
      [Token(Token = "0x4006E48")]
      public const string NotSupported_ValueCollectionSet = "NotSupported_ValueCollectionSet";
      [Token(Token = "0x4006E49")]
      public const string Arg_RankMultiDimNotSupported = "Arg_RankMultiDimNotSupported";
      [Token(Token = "0x4006E4A")]
      public const string Arg_ArrayPlusOffTooSmall = "Arg_ArrayPlusOffTooSmall";
      [Token(Token = "0x4006E4B")]
      public const string Arg_NonZeroLowerBound = "Arg_NonZeroLowerBound";
      [Token(Token = "0x4006E4C")]
      public const string NotSupported_KeyCollectionSet = "NotSupported_KeyCollectionSet";
      [Token(Token = "0x4006E4D")]
      public const string Arg_WrongType = "Arg_WrongType";
      [Token(Token = "0x4006E4E")]
      public const string ArgumentOutOfRange_NeedNonNegNum = "ArgumentOutOfRange_NeedNonNegNum";
      [Token(Token = "0x4006E4F")]
      public const string Arg_HTCapacityOverflow = "Arg_HTCapacityOverflow";
      [Token(Token = "0x4006E50")]
      public const string Argument_AddingDuplicate = "Argument_AddingDuplicate";

      [Token(Token = "0x60092C5")]
      public static string Format(string f, params object[] args) => (string) null;
    }

    [Token(Token = "0x20019AF")]
    private static class HashHelpers
    {
      [Token(Token = "0x4006E51")]
      [FieldOffset(Offset = "0x0")]
      public static readonly int[] primes;
      [Token(Token = "0x4006E52")]
      public const int MaxPrimeArrayLength = 2146435069;

      [Token(Token = "0x60092C6")]
      public static int GetPrime(int min) => new int();

      [Token(Token = "0x60092C7")]
      public static int GetMinPrime() => new int();

      [Token(Token = "0x60092C8")]
      public static int ExpandPrime(int oldSize) => new int();

      [Token(Token = "0x60092C9")]
      static HashHelpers()
      {
      }
    }
  }
}
