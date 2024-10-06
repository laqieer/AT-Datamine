// Decompiled with JetBrains decompiler
// Type: UnityDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x200009B")]
public abstract class UnityDictionary<K, V> : 
  IDictionary<K, V>,
  ICollection<KeyValuePair<K, V>>,
  IEnumerable<KeyValuePair<K, V>>,
  IEnumerable
{
  [Token(Token = "0x17000036")]
  protected abstract List<UnityKeyValuePair<K, V>> KeyValuePairs { [Token(Token = "0x6000520")] get; [Token(Token = "0x6000521")] set; }

  [Token(Token = "0x6000522")]
  protected abstract void SetKeyValuePair(K k, V v);

  [Token(Token = "0x17000037")]
  public virtual V this[K key]
  {
    [Token(Token = "0x6000523")] get => (V) null;
    [Token(Token = "0x6000524")] set
    {
    }
  }

  [Token(Token = "0x6000525")]
  public void Add(K key, V value)
  {
  }

  [Token(Token = "0x6000526")]
  public void Add(KeyValuePair<K, V> kvp)
  {
  }

  [Token(Token = "0x6000527")]
  public bool TryGetValue(K key, out V value) => new bool();

  [Token(Token = "0x6000528")]
  public bool Remove(KeyValuePair<K, V> item) => new bool();

  [Token(Token = "0x6000529")]
  public bool Remove(K key) => new bool();

  [Token(Token = "0x600052A")]
  public void Clear()
  {
  }

  [Token(Token = "0x600052B")]
  public bool ContainsKey(K key) => new bool();

  [Token(Token = "0x600052C")]
  public bool Contains(KeyValuePair<K, V> kvp) => new bool();

  [Token(Token = "0x17000038")]
  public int Count
  {
    [Token(Token = "0x600052D")] get => new int();
  }

  [Token(Token = "0x600052E")]
  public void CopyTo(KeyValuePair<K, V>[] array, int index)
  {
  }

  [Token(Token = "0x600052F")]
  public KeyValuePair<K, V> ConvertUkvp(UnityKeyValuePair<K, V> ukvp) => new KeyValuePair<K, V>();

  [Token(Token = "0x6000530")]
  private IEnumerator System\u002ECollections\u002EIEnumerable\u002EGetEnumerator()
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000531")]
  public IEnumerator<KeyValuePair<K, V>> GetEnumerator() => (IEnumerator<KeyValuePair<K, V>>) null;

  [Token(Token = "0x17000039")]
  public ICollection<K> Keys
  {
    [Token(Token = "0x6000532")] get => (ICollection<K>) null;
  }

  [Token(Token = "0x1700003A")]
  public ICollection<V> Values
  {
    [Token(Token = "0x6000533")] get => (ICollection<V>) null;
  }

  [Token(Token = "0x1700003B")]
  public ICollection<KeyValuePair<K, V>> Items
  {
    [Token(Token = "0x6000534")] get => (ICollection<KeyValuePair<K, V>>) null;
  }

  [Token(Token = "0x1700003C")]
  public V SyncRoot
  {
    [Token(Token = "0x6000535")] get => (V) null;
  }

  [Token(Token = "0x1700003D")]
  public bool IsFixedSize
  {
    [Token(Token = "0x6000536")] get => new bool();
  }

  [Token(Token = "0x1700003E")]
  public bool IsReadOnly
  {
    [Token(Token = "0x6000537")] get => new bool();
  }

  [Token(Token = "0x1700003F")]
  public bool IsSynchronized
  {
    [Token(Token = "0x6000538")] get => new bool();
  }

  [Token(Token = "0x6000539")]
  protected UnityDictionary()
  {
  }

  [Token(Token = "0x200009C")]
  internal sealed class UnityDictionaryEnumerator : 
    IEnumerator<KeyValuePair<K, V>>,
    IEnumerator,
    IDisposable
  {
    [Token(Token = "0x4000289")]
    [FieldOffset(Offset = "0x0")]
    private KeyValuePair<K, V>[] items;
    [Token(Token = "0x400028A")]
    [FieldOffset(Offset = "0x0")]
    private int index;

    [Token(Token = "0x600053A")]
    internal UnityDictionaryEnumerator()
    {
    }

    [Token(Token = "0x600053B")]
    internal UnityDictionaryEnumerator(UnityDictionary<K, V> ud)
    {
    }

    [Token(Token = "0x17000040")]
    private object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [Token(Token = "0x600053C")] get => (object) null;
    }

    [Token(Token = "0x17000041")]
    public KeyValuePair<K, V> Current
    {
      [Token(Token = "0x600053D")] get => new KeyValuePair<K, V>();
    }

    [Token(Token = "0x17000042")]
    public KeyValuePair<K, V> Entry
    {
      [Token(Token = "0x600053E")] get => new KeyValuePair<K, V>();
    }

    [Token(Token = "0x600053F")]
    public void Dispose()
    {
    }

    [Token(Token = "0x17000043")]
    public K Key
    {
      [Token(Token = "0x6000540")] get => (K) null;
    }

    [Token(Token = "0x17000044")]
    public V Value
    {
      [Token(Token = "0x6000541")] get => (V) null;
    }

    [Token(Token = "0x6000542")]
    public bool MoveNext() => new bool();

    [Token(Token = "0x6000543")]
    private void ValidateIndex()
    {
    }

    [Token(Token = "0x6000544")]
    public void Reset()
    {
    }
  }
}
