// Decompiled with JetBrains decompiler
// Type: Battle.Utility.ObjectPool`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Utility
{
  [Token(Token = "0x20022CF")]
  public sealed class ObjectPool<TPoolable, TPoolTarget> : IDisposable where TPoolable : class, IPoolable<TPoolTarget, TPoolable>
  {
    [Token(Token = "0x400932D")]
    [FieldOffset(Offset = "0x0")]
    private TPoolable original;
    [Token(Token = "0x400932F")]
    [FieldOffset(Offset = "0x0")]
    private Queue<TPoolable> pooledObjects;
    [Token(Token = "0x4009330")]
    [FieldOffset(Offset = "0x0")]
    private HashSet<TPoolable> letObjects;

    [Token(Token = "0x17002DED")]
    public int CreatedObjectCount
    {
      [Token(Token = "0x600D447")] get => new int();
      [Token(Token = "0x600D448")] private set
      {
      }
    }

    [Token(Token = "0x17002DEE")]
    public int InitialPoolingCount
    {
      [Token(Token = "0x600D449")] get => new int();
      [Token(Token = "0x600D44A")] private set
      {
      }
    }

    [Token(Token = "0x17002DEF")]
    public int MaxPoolingCount
    {
      [Token(Token = "0x600D44B")] get => new int();
      [Token(Token = "0x600D44C")] private set
      {
      }
    }

    [Token(Token = "0x17002DF0")]
    public bool Restrict
    {
      [Token(Token = "0x600D44D")] get => new bool();
      [Token(Token = "0x600D44E")] private set
      {
      }
    }

    [Token(Token = "0x600D44F")]
    public ObjectPool(
      TPoolable original,
      int initialPoolingCount,
      int maxPoolingCount,
      bool restrict = false)
    {
    }

    [Token(Token = "0x600D450")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600D451")]
    public void CreatePoolingObject(int count)
    {
    }

    [Token(Token = "0x600D452")]
    public TPoolable Get() => (TPoolable) null;

    [Token(Token = "0x600D453")]
    public void BlingBack(TPoolable obj)
    {
    }
  }
}
