// Decompiled with JetBrains decompiler
// Type: UnityEngine.Collections.Generic.UDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

#nullable disable
namespace UnityEngine.Collections.Generic
{
  [Token(Token = "0x2003F35")]
  [Serializable]
  public class UDictionary<TKey, TValue> : 
    UDictionaryBase,
    IDictionary<TKey, TValue>,
    ICollection<KeyValuePair<TKey, TValue>>,
    IEnumerable<KeyValuePair<TKey, TValue>>,
    IEnumerable,
    IDictionary,
    ICollection,
    ISerializationCallbackReceiver
  {
    [Token(Token = "0x40114C4")]
    [FieldOffset(Offset = "0x0")]
    private int[] buckets;
    [Token(Token = "0x40114C5")]
    [FieldOffset(Offset = "0x0")]
    private UDictionary<TKey, TValue>.Entry[] entries;
    [Token(Token = "0x40114C6")]
    [FieldOffset(Offset = "0x0")]
    private int count;
    [Token(Token = "0x40114C7")]
    [FieldOffset(Offset = "0x0")]
    private int version;
    [Token(Token = "0x40114C8")]
    [FieldOffset(Offset = "0x0")]
    private int freeList;
    [Token(Token = "0x40114C9")]
    [FieldOffset(Offset = "0x0")]
    private int freeCount;
    [Token(Token = "0x40114CA")]
    [FieldOffset(Offset = "0x0")]
    private IEqualityComparer<TKey> comparer;
    [Token(Token = "0x40114CB")]
    [FieldOffset(Offset = "0x0")]
    private UDictionary<TKey, TValue>.KeyCollection keys;
    [Token(Token = "0x40114CC")]
    [FieldOffset(Offset = "0x0")]
    private UDictionary<TKey, TValue>.ValueCollection values;
    [Token(Token = "0x40114CD")]
    [FieldOffset(Offset = "0x0")]
    private UnityEngine.Object _syncRoot;
    [Token(Token = "0x40114CE")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private TKey[] m_keys;
    [Token(Token = "0x40114CF")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private TValue[] m_values;

    [Token(Token = "0x601981C")]
    public UDictionary()
    {
    }

    [Token(Token = "0x601981D")]
    public UDictionary(int capacity)
    {
    }

    [Token(Token = "0x601981E")]
    public UDictionary(IEqualityComparer<TKey> comparer)
    {
    }

    [Token(Token = "0x601981F")]
    public UDictionary(int capacity, IEqualityComparer<TKey> comparer)
    {
    }

    [Token(Token = "0x6019820")]
    public UDictionary(IDictionary<TKey, TValue> dictionary)
    {
    }

    [Token(Token = "0x6019821")]
    public UDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer)
    {
    }

    [Token(Token = "0x17005223")]
    public IEqualityComparer<TKey> Comparer
    {
      [Token(Token = "0x6019822")] get => (IEqualityComparer<TKey>) null;
    }

    [Token(Token = "0x17005224")]
    public int Count
    {
      [Token(Token = "0x6019823")] get => new int();
    }

    [Token(Token = "0x17005225")]
    public UDictionary<TKey, TValue>.KeyCollection Keys
    {
      [Token(Token = "0x6019824")] get => (UDictionary<TKey, TValue>.KeyCollection) null;
    }

    [Token(Token = "0x17005226")]
    private ICollection<TKey> System\u002ECollections\u002EGeneric\u002EIDictionary\u003CTKey\u002CTValue\u003E\u002EKeys
    {
      [Token(Token = "0x6019825")] get => (ICollection<TKey>) null;
    }

    [Token(Token = "0x17005227")]
    public UDictionary<TKey, TValue>.ValueCollection Values
    {
      [Token(Token = "0x6019826")] get => (UDictionary<TKey, TValue>.ValueCollection) null;
    }

    [Token(Token = "0x17005228")]
    private ICollection<TValue> System\u002ECollections\u002EGeneric\u002EIDictionary\u003CTKey\u002CTValue\u003E\u002EValues
    {
      [Token(Token = "0x6019827")] get => (ICollection<TValue>) null;
    }

    [Token(Token = "0x17005229")]
    public TValue this[TKey key]
    {
      [Token(Token = "0x6019828")] get => (TValue) null;
      [Token(Token = "0x6019829")] set
      {
      }
    }

    [Token(Token = "0x601982A")]
    private void UnityEngine\u002EISerializationCallbackReceiver\u002EOnBeforeSerialize()
    {
    }

    [Token(Token = "0x601982B")]
    private void UnityEngine\u002EISerializationCallbackReceiver\u002EOnAfterDeserialize()
    {
    }

    [Token(Token = "0x601982C")]
    public void Add(TKey key, TValue value)
    {
    }

    [Token(Token = "0x601982D")]
    private void System\u002ECollections\u002EGeneric\u002EICollection\u003CSystem\u002ECollections\u002EGeneric\u002EKeyValuePair\u003CTKey\u002CTValue\u003E\u003E\u002EAdd(
      KeyValuePair<TKey, TValue> keyValuePair)
    {
    }

    [Token(Token = "0x601982E")]
    private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CSystem\u002ECollections\u002EGeneric\u002EKeyValuePair\u003CTKey\u002CTValue\u003E\u003E\u002EContains(
      KeyValuePair<TKey, TValue> keyValuePair)
    {
      return new bool();
    }

    [Token(Token = "0x601982F")]
    private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CSystem\u002ECollections\u002EGeneric\u002EKeyValuePair\u003CTKey\u002CTValue\u003E\u003E\u002ERemove(
      KeyValuePair<TKey, TValue> keyValuePair)
    {
      return new bool();
    }

    [Token(Token = "0x6019830")]
    public void Clear()
    {
    }

    [Token(Token = "0x6019831")]
    public bool ContainsKey(TKey key) => new bool();

    [Token(Token = "0x6019832")]
    public bool ContainsValue(TValue value) => new bool();

    [Token(Token = "0x6019833")]
    private void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
    {
    }

    [Token(Token = "0x6019834")]
    public UDictionary<TKey, TValue>.Enumerator GetEnumerator()
    {
      return new UDictionary<TKey, TValue>.Enumerator();
    }

    [Token(Token = "0x6019835")]
    private IEnumerator<KeyValuePair<TKey, TValue>> System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CSystem\u002ECollections\u002EGeneric\u002EKeyValuePair\u003CTKey\u002CTValue\u003E\u003E\u002EGetEnumerator()
    {
      return (IEnumerator<KeyValuePair<TKey, TValue>>) null;
    }

    [Token(Token = "0x6019836")]
    private int FindEntry(TKey key) => new int();

    [Token(Token = "0x6019837")]
    private void Initialize(int capacity)
    {
    }

    [Token(Token = "0x6019838")]
    private void Insert(TKey key, TValue value, bool add)
    {
    }

    [Token(Token = "0x6019839")]
    private void Resize()
    {
    }

    [Token(Token = "0x601983A")]
    private void Resize(int newSize, bool forceNewHashCodes)
    {
    }

    [Token(Token = "0x601983B")]
    public bool Remove(TKey key) => new bool();

    [Token(Token = "0x601983C")]
    public bool TryGetValue(TKey key, out TValue value) => new bool();

    [Token(Token = "0x601983D")]
    internal TValue GetValueOrDefault(TKey key) => (TValue) null;

    [Token(Token = "0x1700522A")]
    private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CSystem\u002ECollections\u002EGeneric\u002EKeyValuePair\u003CTKey\u002CTValue\u003E\u003E\u002EIsReadOnly
    {
      [Token(Token = "0x601983E")] get => new bool();
    }

    [Token(Token = "0x601983F")]
    private void System\u002ECollections\u002EGeneric\u002EICollection\u003CSystem\u002ECollections\u002EGeneric\u002EKeyValuePair\u003CTKey\u002CTValue\u003E\u003E\u002ECopyTo(
      KeyValuePair<TKey, TValue>[] array,
      int index)
    {
    }

    [Token(Token = "0x6019840")]
    private void System\u002ECollections\u002EICollection\u002ECopyTo(Array array, int index)
    {
    }

    [Token(Token = "0x6019841")]
    private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x1700522B")]
    private bool System\u002ECollections\u002EICollection\u002EIsSynchronized
    {
      [Token(Token = "0x6019842")] get => new bool();
    }

    [Token(Token = "0x1700522C")]
    private object System\u002ECollections\u002EICollection\u002ESyncRoot
    {
      [Token(Token = "0x6019843")] get => (object) null;
    }

    [Token(Token = "0x1700522D")]
    private bool System\u002ECollections\u002EIDictionary\u002EIsFixedSize
    {
      [Token(Token = "0x6019844")] get => new bool();
    }

    [Token(Token = "0x1700522E")]
    private bool System\u002ECollections\u002EIDictionary\u002EIsReadOnly
    {
      [Token(Token = "0x6019845")] get => new bool();
    }

    [Token(Token = "0x1700522F")]
    private ICollection System\u002ECollections\u002EIDictionary\u002EKeys
    {
      [Token(Token = "0x6019846")] get => (ICollection) null;
    }

    [Token(Token = "0x17005230")]
    private ICollection System\u002ECollections\u002EIDictionary\u002EValues
    {
      [Token(Token = "0x6019847")] get => (ICollection) null;
    }

    [Token(Token = "0x6019848")]
    private object System\u002ECollections\u002EIDictionary\u002Eget_Item(object key)
    {
      return (object) null;
    }

    [Token(Token = "0x6019849")]
    private void System\u002ECollections\u002EIDictionary\u002Eset_Item(object key, object value)
    {
    }

    [Token(Token = "0x601984A")]
    private static bool IsCompatibleKey(object key) => new bool();

    [Token(Token = "0x601984B")]
    private void System\u002ECollections\u002EIDictionary\u002EAdd(object key, object value)
    {
    }

    [Token(Token = "0x601984C")]
    private bool System\u002ECollections\u002EIDictionary\u002EContains(object key) => new bool();

    [Token(Token = "0x601984D")]
    private IDictionaryEnumerator System\u002ECollections\u002EIDictionary\u002EGetEnumerator()
    {
      return (IDictionaryEnumerator) null;
    }

    [Token(Token = "0x601984E")]
    private void System\u002ECollections\u002EIDictionary\u002ERemove(object key)
    {
    }

    [Token(Token = "0x2003F36")]
    private struct Entry
    {
      [Token(Token = "0x40114D0")]
      [FieldOffset(Offset = "0x0")]
      public int hashCode;
      [Token(Token = "0x40114D1")]
      [FieldOffset(Offset = "0x0")]
      public int next;
      [Token(Token = "0x40114D2")]
      [FieldOffset(Offset = "0x0")]
      public TKey key;
      [Token(Token = "0x40114D3")]
      [FieldOffset(Offset = "0x0")]
      public TValue value;
    }

    [Token(Token = "0x2003F37")]
    [Serializable]
    public struct Enumerator : 
      IEnumerator<KeyValuePair<TKey, TValue>>,
      IEnumerator,
      IDisposable,
      IDictionaryEnumerator
    {
      [Token(Token = "0x40114D4")]
      [FieldOffset(Offset = "0x0")]
      private UDictionary<TKey, TValue> dictionary;
      [Token(Token = "0x40114D5")]
      [FieldOffset(Offset = "0x0")]
      private int version;
      [Token(Token = "0x40114D6")]
      [FieldOffset(Offset = "0x0")]
      private int index;
      [Token(Token = "0x40114D7")]
      [FieldOffset(Offset = "0x0")]
      private KeyValuePair<TKey, TValue> current;
      [Token(Token = "0x40114D8")]
      [FieldOffset(Offset = "0x0")]
      private int getEnumeratorRetType;
      [Token(Token = "0x40114D9")]
      internal const int DictEntry = 1;
      [Token(Token = "0x40114DA")]
      internal const int KeyValuePair = 2;

      [Token(Token = "0x601984F")]
      internal Enumerator(UDictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
      {
      }

      [Token(Token = "0x6019850")]
      public bool MoveNext() => new bool();

      [Token(Token = "0x17005232")]
      public KeyValuePair<TKey, TValue> Current
      {
        [Token(Token = "0x6019851")] get => new KeyValuePair<TKey, TValue>();
      }

      [Token(Token = "0x6019852")]
      public void Dispose()
      {
      }

      [Token(Token = "0x17005233")]
      private object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [Token(Token = "0x6019853")] get => (object) null;
      }

      [Token(Token = "0x6019854")]
      private void System\u002ECollections\u002EIEnumerator\u002EReset()
      {
      }

      [Token(Token = "0x17005234")]
      private DictionaryEntry System\u002ECollections\u002EIDictionaryEnumerator\u002EEntry
      {
        [Token(Token = "0x6019855")] get => new DictionaryEntry();
      }

      [Token(Token = "0x17005235")]
      private object System\u002ECollections\u002EIDictionaryEnumerator\u002EKey
      {
        [Token(Token = "0x6019856")] get => (object) null;
      }

      [Token(Token = "0x17005236")]
      private object System\u002ECollections\u002EIDictionaryEnumerator\u002EValue
      {
        [Token(Token = "0x6019857")] get => (object) null;
      }
    }

    [Token(Token = "0x2003F38")]
    [DebuggerDisplay("Count = {Count}")]
    [Serializable]
    public sealed class KeyCollection : 
      ICollection<TKey>,
      IEnumerable<TKey>,
      IEnumerable,
      ICollection
    {
      [Token(Token = "0x40114DB")]
      [FieldOffset(Offset = "0x0")]
      private UDictionary<TKey, TValue> dictionary;

      [Token(Token = "0x6019858")]
      public KeyCollection(UDictionary<TKey, TValue> dictionary)
      {
      }

      [Token(Token = "0x6019859")]
      public UDictionary<TKey, TValue>.KeyCollection.Enumerator GetEnumerator()
      {
        return new UDictionary<TKey, TValue>.KeyCollection.Enumerator();
      }

      [Token(Token = "0x601985A")]
      public void CopyTo(TKey[] array, int index)
      {
      }

      [Token(Token = "0x17005237")]
      public int Count
      {
        [Token(Token = "0x601985B")] get => new int();
      }

      [Token(Token = "0x17005238")]
      private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CTKey\u003E\u002EIsReadOnly
      {
        [Token(Token = "0x601985C")] get => new bool();
      }

      [Token(Token = "0x601985D")]
      private void System\u002ECollections\u002EGeneric\u002EICollection\u003CTKey\u003E\u002EAdd(
        TKey item)
      {
      }

      [Token(Token = "0x601985E")]
      private void System\u002ECollections\u002EGeneric\u002EICollection\u003CTKey\u003E\u002EClear()
      {
      }

      [Token(Token = "0x601985F")]
      private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CTKey\u003E\u002EContains(
        TKey item)
      {
        return new bool();
      }

      [Token(Token = "0x6019860")]
      private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CTKey\u003E\u002ERemove(
        TKey item)
      {
        return new bool();
      }

      [Token(Token = "0x6019861")]
      private IEnumerator<TKey> System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CTKey\u003E\u002EGetEnumerator()
      {
        return (IEnumerator<TKey>) null;
      }

      [Token(Token = "0x6019862")]
      private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6019863")]
      private void System\u002ECollections\u002EICollection\u002ECopyTo(Array array, int index)
      {
      }

      [Token(Token = "0x17005239")]
      private bool System\u002ECollections\u002EICollection\u002EIsSynchronized
      {
        [Token(Token = "0x6019864")] get => new bool();
      }

      [Token(Token = "0x1700523A")]
      private object System\u002ECollections\u002EICollection\u002ESyncRoot
      {
        [Token(Token = "0x6019865")] get => (object) null;
      }

      [Token(Token = "0x2003F39")]
      [Serializable]
      public struct Enumerator : IEnumerator<TKey>, IEnumerator, IDisposable
      {
        [Token(Token = "0x40114DC")]
        [FieldOffset(Offset = "0x0")]
        private UDictionary<TKey, TValue> dictionary;
        [Token(Token = "0x40114DD")]
        [FieldOffset(Offset = "0x0")]
        private int index;
        [Token(Token = "0x40114DE")]
        [FieldOffset(Offset = "0x0")]
        private int version;
        [Token(Token = "0x40114DF")]
        [FieldOffset(Offset = "0x0")]
        private TKey currentKey;

        [Token(Token = "0x6019866")]
        internal Enumerator(UDictionary<TKey, TValue> dictionary)
        {
        }

        [Token(Token = "0x6019867")]
        public void Dispose()
        {
        }

        [Token(Token = "0x6019868")]
        public bool MoveNext() => new bool();

        [Token(Token = "0x1700523B")]
        public TKey Current
        {
          [Token(Token = "0x6019869")] get => (TKey) null;
        }

        [Token(Token = "0x1700523C")]
        private object System\u002ECollections\u002EIEnumerator\u002ECurrent
        {
          [Token(Token = "0x601986A")] get => (object) null;
        }

        [Token(Token = "0x601986B")]
        private void System\u002ECollections\u002EIEnumerator\u002EReset()
        {
        }
      }
    }

    [Token(Token = "0x2003F3A")]
    [DebuggerDisplay("Count = {Count}")]
    [Serializable]
    public sealed class ValueCollection : 
      ICollection<TValue>,
      IEnumerable<TValue>,
      IEnumerable,
      ICollection
    {
      [Token(Token = "0x40114E0")]
      [FieldOffset(Offset = "0x0")]
      private UDictionary<TKey, TValue> dictionary;

      [Token(Token = "0x601986C")]
      public ValueCollection(UDictionary<TKey, TValue> dictionary)
      {
      }

      [Token(Token = "0x601986D")]
      public UDictionary<TKey, TValue>.ValueCollection.Enumerator GetEnumerator()
      {
        return new UDictionary<TKey, TValue>.ValueCollection.Enumerator();
      }

      [Token(Token = "0x601986E")]
      public void CopyTo(TValue[] array, int index)
      {
      }

      [Token(Token = "0x1700523D")]
      public int Count
      {
        [Token(Token = "0x601986F")] get => new int();
      }

      [Token(Token = "0x1700523E")]
      private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CTValue\u003E\u002EIsReadOnly
      {
        [Token(Token = "0x6019870")] get => new bool();
      }

      [Token(Token = "0x6019871")]
      private void System\u002ECollections\u002EGeneric\u002EICollection\u003CTValue\u003E\u002EAdd(
        TValue item)
      {
      }

      [Token(Token = "0x6019872")]
      private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CTValue\u003E\u002ERemove(
        TValue item)
      {
        return new bool();
      }

      [Token(Token = "0x6019873")]
      private void System\u002ECollections\u002EGeneric\u002EICollection\u003CTValue\u003E\u002EClear()
      {
      }

      [Token(Token = "0x6019874")]
      private bool System\u002ECollections\u002EGeneric\u002EICollection\u003CTValue\u003E\u002EContains(
        TValue item)
      {
        return new bool();
      }

      [Token(Token = "0x6019875")]
      private IEnumerator<TValue> System\u002ECollections\u002EGeneric\u002EIEnumerable\u003CTValue\u003E\u002EGetEnumerator()
      {
        return (IEnumerator<TValue>) null;
      }

      [Token(Token = "0x6019876")]
      private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
      {
        return (IEnumerator) null;
      }

      [Token(Token = "0x6019877")]
      private void System\u002ECollections\u002EICollection\u002ECopyTo(Array array, int index)
      {
      }

      [Token(Token = "0x1700523F")]
      private bool System\u002ECollections\u002EICollection\u002EIsSynchronized
      {
        [Token(Token = "0x6019878")] get => new bool();
      }

      [Token(Token = "0x17005240")]
      private object System\u002ECollections\u002EICollection\u002ESyncRoot
      {
        [Token(Token = "0x6019879")] get => (object) null;
      }

      [Token(Token = "0x2003F3B")]
      [Serializable]
      public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
      {
        [Token(Token = "0x40114E1")]
        [FieldOffset(Offset = "0x0")]
        private UDictionary<TKey, TValue> dictionary;
        [Token(Token = "0x40114E2")]
        [FieldOffset(Offset = "0x0")]
        private int index;
        [Token(Token = "0x40114E3")]
        [FieldOffset(Offset = "0x0")]
        private int version;
        [Token(Token = "0x40114E4")]
        [FieldOffset(Offset = "0x0")]
        private TValue currentValue;

        [Token(Token = "0x601987A")]
        internal Enumerator(UDictionary<TKey, TValue> dictionary)
        {
        }

        [Token(Token = "0x601987B")]
        public void Dispose()
        {
        }

        [Token(Token = "0x601987C")]
        public bool MoveNext() => new bool();

        [Token(Token = "0x17005241")]
        public TValue Current
        {
          [Token(Token = "0x601987D")] get => (TValue) null;
        }

        [Token(Token = "0x17005242")]
        private object System\u002ECollections\u002EIEnumerator\u002ECurrent
        {
          [Token(Token = "0x601987E")] get => (object) null;
        }

        [Token(Token = "0x601987F")]
        private void System\u002ECollections\u002EIEnumerator\u002EReset()
        {
        }
      }
    }
  }
}
