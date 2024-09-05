// Decompiled with JetBrains decompiler
// Type: Battle.Utility.IPoolable`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Utility
{
  [Token(Token = "0x20022CE")]
  public interface IPoolable<TTArget, TOwn> : IDisposable where TOwn : IPoolable<TTArget, TOwn>
  {
    [Token(Token = "0x600D444")]
    TOwn Clone();

    [Token(Token = "0x600D445")]
    void Reset();

    [Token(Token = "0x600D446")]
    void BringBack();
  }
}
