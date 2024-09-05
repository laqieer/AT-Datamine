// Decompiled with JetBrains decompiler
// Type: SerializableCollections.SerializableTuple`4
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SerializableCollections
{
  [Token(Token = "0x20019BD")]
  [Serializable]
  public abstract class SerializableTuple<T1, T2, T3, T4> : 
    IEquatable<SerializableTuple<T1, T2, T3, T4>>
  {
    [Token(Token = "0x4006E86")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private T1 item1;
    [Token(Token = "0x4006E87")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private T2 item2;
    [Token(Token = "0x4006E88")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private T3 item3;
    [Token(Token = "0x4006E89")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private T4 item4;

    [Token(Token = "0x170017C2")]
    public T1 Item1
    {
      [Token(Token = "0x600931C")] get => (T1) null;
    }

    [Token(Token = "0x170017C3")]
    public T2 Item2
    {
      [Token(Token = "0x600931D")] get => (T2) null;
    }

    [Token(Token = "0x170017C4")]
    public T3 Item3
    {
      [Token(Token = "0x600931E")] get => (T3) null;
    }

    [Token(Token = "0x170017C5")]
    public T4 Item4
    {
      [Token(Token = "0x600931F")] get => (T4) null;
    }

    [Token(Token = "0x6009320")]
    public SerializableTuple()
    {
    }

    [Token(Token = "0x6009321")]
    public SerializableTuple(T1 item1, T2 item2, T3 item3, T4 item4)
    {
    }

    [Token(Token = "0x6009322")]
    public bool Equals(SerializableTuple<T1, T2, T3, T4> other) => new bool();

    [Token(Token = "0x6009323")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6009324")]
    public override string ToString() => (string) null;
  }
}
