// Decompiled with JetBrains decompiler
// Type: SerializableCollections.SerializableTuple`3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SerializableCollections
{
  [Token(Token = "0x20019BC")]
  [Serializable]
  public abstract class SerializableTuple<T1, T2, T3> : IEquatable<SerializableTuple<T1, T2, T3>>
  {
    [Token(Token = "0x4006E83")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private T1 item1;
    [Token(Token = "0x4006E84")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private T2 item2;
    [Token(Token = "0x4006E85")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private T3 item3;

    [Token(Token = "0x170017BF")]
    public T1 Item1
    {
      [Token(Token = "0x6009314")] get => (T1) null;
    }

    [Token(Token = "0x170017C0")]
    public T2 Item2
    {
      [Token(Token = "0x6009315")] get => (T2) null;
    }

    [Token(Token = "0x170017C1")]
    public T3 Item3
    {
      [Token(Token = "0x6009316")] get => (T3) null;
    }

    [Token(Token = "0x6009317")]
    public SerializableTuple()
    {
    }

    [Token(Token = "0x6009318")]
    public SerializableTuple(T1 item1, T2 item2, T3 item3)
    {
    }

    [Token(Token = "0x6009319")]
    public bool Equals(SerializableTuple<T1, T2, T3> other) => new bool();

    [Token(Token = "0x600931A")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600931B")]
    public override string ToString() => (string) null;
  }
}
