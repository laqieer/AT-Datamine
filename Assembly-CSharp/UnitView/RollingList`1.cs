// Decompiled with JetBrains decompiler
// Type: UnitView.RollingList`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace UnitView
{
  [Token(Token = "0x20003C2")]
  [Serializable]
  public class RollingList<T> : List<T>
  {
    [Token(Token = "0x60015CF")]
    public RollingList()
    {
    }

    [Token(Token = "0x60015D0")]
    public RollingList(T[] items)
    {
    }

    [Token(Token = "0x1700023E")]
    public T Current
    {
      [Token(Token = "0x60015D1")] get => (T) null;
    }

    [Token(Token = "0x1700023F")]
    public int Index
    {
      [Token(Token = "0x60015D2")] get => new int();
      [Token(Token = "0x60015D3")] private set
      {
      }
    }

    [Token(Token = "0x60015D4")]
    public void Initialize(int initIndex = 0)
    {
    }

    [Token(Token = "0x60015D5")]
    public void ToPrev()
    {
    }

    [Token(Token = "0x60015D6")]
    public void ToNext()
    {
    }

    [Token(Token = "0x60015D7")]
    public void Jump(int index)
    {
    }

    [Token(Token = "0x60015D8")]
    private void SetIndex(int index)
    {
    }

    [Token(Token = "0x60015D9")]
    private int PrevIndex() => new int();

    [Token(Token = "0x60015DA")]
    private int NextIndex() => new int();

    [Token(Token = "0x60015DB")]
    private int LastIndex() => new int();
  }
}
