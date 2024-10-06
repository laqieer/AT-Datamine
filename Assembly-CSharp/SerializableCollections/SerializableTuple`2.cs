// Decompiled with JetBrains decompiler
// Type: SerializableCollections.SerializableTuple`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SerializableCollections
{
  [Token(Token = "0x20019BB")]
  [Serializable]
  public abstract class SerializableTuple<T1, T2> : IEquatable<SerializableTuple<T1, T2>>
  {
    [Token(Token = "0x4006E81")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private T1 item1;
    [Token(Token = "0x4006E82")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private T2 item2;

    [Token(Token = "0x170017BD")]
    public T1 Item1
    {
      [Token(Token = "0x600930D")] get => (T1) null;
    }

    [Token(Token = "0x170017BE")]
    public T2 Item2
    {
      [Token(Token = "0x600930E")] get => (T2) null;
    }

    [Token(Token = "0x600930F")]
    public SerializableTuple()
    {
    }

    [Token(Token = "0x6009310")]
    public SerializableTuple(T1 item1, T2 item2)
    {
    }

    [Token(Token = "0x6009311")]
    public bool Equals(SerializableTuple<T1, T2> other) => new bool();

    [Token(Token = "0x6009312")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6009313")]
    public override string ToString() => (string) null;
  }
}
