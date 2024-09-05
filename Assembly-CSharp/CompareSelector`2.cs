// Decompiled with JetBrains decompiler
// Type: CompareSelector`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x20001DE")]
public class CompareSelector<T, TKey> : IEqualityComparer<T>
{
  [Token(Token = "0x4000AE8")]
  [FieldOffset(Offset = "0x0")]
  private Func<T, TKey> selector;

  [Token(Token = "0x6000BFA")]
  public CompareSelector(Func<T, TKey> selector)
  {
  }

  [Token(Token = "0x6000BFB")]
  public bool Equals(T x, T y) => new bool();

  [Token(Token = "0x6000BFC")]
  public int GetHashCode(T obj) => new int();
}
