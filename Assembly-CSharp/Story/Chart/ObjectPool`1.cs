// Decompiled with JetBrains decompiler
// Type: Story.Chart.ObjectPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006D7")]
  public class ObjectPool<T> : ObjectPool<T>.IHandler where T : Object
  {
    [Token(Token = "0x4002065")]
    [FieldOffset(Offset = "0x0")]
    private Queue<T> pool;
    [Token(Token = "0x4002066")]
    [FieldOffset(Offset = "0x0")]
    private List<T> providing;
    [Token(Token = "0x4002067")]
    [FieldOffset(Offset = "0x0")]
    private ObjectPool<T>.IHandler handler;

    [Token(Token = "0x170005C1")]
    public IEnumerable<T> Elements
    {
      [Token(Token = "0x60026CC")] get => (IEnumerable<T>) null;
    }

    [Token(Token = "0x170005C2")]
    public IEnumerable<T> ProvidingList
    {
      [Token(Token = "0x60026CD")] get => (IEnumerable<T>) null;
    }

    [Token(Token = "0x60026CE")]
    public T Peek() => (T) null;

    [Token(Token = "0x60026CF")]
    public ObjectPool()
    {
    }

    [Token(Token = "0x60026D0")]
    public ObjectPool(ObjectPool<T>.IHandler handler)
    {
    }

    [Token(Token = "0x60026D1")]
    public T Provide() => (T) null;

    [Token(Token = "0x60026D2")]
    public void Pooling(T instance)
    {
    }

    [Token(Token = "0x60026D3")]
    private void Story\u002EChart\u002EObjectPool\u003CT\u003E\u002EIHandler\u002EActivate(
      T instance)
    {
    }

    [Token(Token = "0x60026D4")]
    private void Story\u002EChart\u002EObjectPool\u003CT\u003E\u002EIHandler\u002EDeactivate(
      T instance)
    {
    }

    [Token(Token = "0x20006D8")]
    public interface IHandler
    {
      [Token(Token = "0x60026D5")]
      void Activate(T instance);

      [Token(Token = "0x60026D6")]
      void Deactivate(T instance);
    }
  }
}
