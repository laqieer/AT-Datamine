// Decompiled with JetBrains decompiler
// Type: GameCore.Utility.CycleList`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.Utility
{
  [Token(Token = "0x2000BCF")]
  [Serializable]
  public class CycleList<T> : List<T>
  {
    [Token(Token = "0x6004385")]
    public CycleList()
    {
    }

    [Token(Token = "0x6004386")]
    public CycleList(T[] items)
    {
    }

    [Token(Token = "0x170009D1")]
    public T Current
    {
      [Token(Token = "0x6004387")] get => (T) null;
    }

    [Token(Token = "0x170009D2")]
    public int Index
    {
      [Token(Token = "0x6004388")] get => new int();
      [Token(Token = "0x6004389")] private set
      {
      }
    }

    [Token(Token = "0x600438A")]
    public void Initialize(int initIndex = 0)
    {
    }

    [Token(Token = "0x600438B")]
    public void ToPrev()
    {
    }

    [Token(Token = "0x600438C")]
    public void ToNext()
    {
    }

    [Token(Token = "0x600438D")]
    public void Jump(int index)
    {
    }

    [Token(Token = "0x600438E")]
    private void SetIndex(int index)
    {
    }

    [Token(Token = "0x600438F")]
    private int PrevIndex() => new int();

    [Token(Token = "0x6004390")]
    private int NextIndex() => new int();

    [Token(Token = "0x6004391")]
    private int LastIndex() => new int();
  }
}
