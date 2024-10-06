// Decompiled with JetBrains decompiler
// Type: GenericComparer`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x20001DD")]
public class GenericComparer<TKey> : IComparer<TKey>
{
  [Token(Token = "0x4000AE7")]
  [FieldOffset(Offset = "0x0")]
  private Func<TKey, TKey, int> comparer;

  [Token(Token = "0x6000BF8")]
  public GenericComparer(Func<TKey, TKey, int> comparer)
  {
  }

  [Token(Token = "0x6000BF9")]
  public int Compare(TKey x, TKey y) => new int();
}
