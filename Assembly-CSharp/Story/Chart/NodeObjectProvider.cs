// Decompiled with JetBrains decompiler
// Type: Story.Chart.NodeObjectProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.Chart.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Story.Chart
{
  [Token(Token = "0x20006D4")]
  public class NodeObjectProvider : ObjectPool<StoryChartNodeUI>.IHandler
  {
    [Token(Token = "0x400205A")]
    [FieldOffset(Offset = "0x10")]
    private ObjectPool<StoryChartNodeUI> pool;
    [Token(Token = "0x400205B")]
    [FieldOffset(Offset = "0x18")]
    private NodeObjectProvider.Concreator<GameObject> concreator;
    [Token(Token = "0x400205C")]
    [FieldOffset(Offset = "0x20")]
    private int PRESERVE_PER_FRAME;

    [Token(Token = "0x170005BE")]
    public IEnumerable<StoryChartNodeUI> Elements
    {
      [Token(Token = "0x60026BA"), Address(RVA = "0x2F44814", Offset = "0x2F44814", VA = "0x2F44814")] get
      {
        return (IEnumerable<StoryChartNodeUI>) null;
      }
    }

    [Token(Token = "0x60026BB")]
    [Address(RVA = "0x2F41510", Offset = "0x2F41510", VA = "0x2F41510")]
    public StoryChartNodeUI Peek() => (StoryChartNodeUI) null;

    [Token(Token = "0x60026BC")]
    [Address(RVA = "0x2F42B0C", Offset = "0x2F42B0C", VA = "0x2F42B0C")]
    public StoryChartNodeUI Provide() => (StoryChartNodeUI) null;

    [Token(Token = "0x60026BD")]
    [Address(RVA = "0x2F42FE4", Offset = "0x2F42FE4", VA = "0x2F42FE4")]
    public void Release(StoryChartNodeUI instance)
    {
    }

    [Token(Token = "0x60026BE")]
    [Address(RVA = "0x2F44718", Offset = "0x2F44718", VA = "0x2F44718")]
    public void Initialize(
      NodeObjectProvider.Concreator<GameObject> concreator)
    {
    }

    [Token(Token = "0x60026BF")]
    [Address(RVA = "0x2F4479C", Offset = "0x2F4479C", VA = "0x2F4479C")]
    public IEnumerator Reserve(int reserve) => (IEnumerator) null;

    [Token(Token = "0x60026C0")]
    [Address(RVA = "0x2F459C8", Offset = "0x2F459C8", VA = "0x2F459C8")]
    private StoryChartNodeUI Concreate() => (StoryChartNodeUI) null;

    [Token(Token = "0x60026C1")]
    [Address(RVA = "0x2F45A78", Offset = "0x2F45A78", VA = "0x2F45A78", Slot = "4")]
    private void Story\u002EChart\u002EObjectPool\u003CStory\u002EChart\u002EUI\u002EStoryChartNodeUI\u003E\u002EIHandler\u002EActivate(
      StoryChartNodeUI instance)
    {
    }

    [Token(Token = "0x60026C2")]
    [Address(RVA = "0x2F45A94", Offset = "0x2F45A94", VA = "0x2F45A94", Slot = "5")]
    private void Story\u002EChart\u002EObjectPool\u003CStory\u002EChart\u002EUI\u002EStoryChartNodeUI\u003E\u002EIHandler\u002EDeactivate(
      StoryChartNodeUI instance)
    {
    }

    [Token(Token = "0x60026C3")]
    [Address(RVA = "0x2F436C4", Offset = "0x2F436C4", VA = "0x2F436C4")]
    public NodeObjectProvider()
    {
    }

    [Token(Token = "0x20006D5")]
    public class Concreator<T> where T : Object
    {
      [Token(Token = "0x400205D")]
      [FieldOffset(Offset = "0x0")]
      private T original;
      [Token(Token = "0x400205E")]
      [FieldOffset(Offset = "0x0")]
      private Transform parent;
      [Token(Token = "0x400205F")]
      [FieldOffset(Offset = "0x0")]
      private bool worldstays;

      [Token(Token = "0x60026C4")]
      public Concreator(T original, Transform parent, bool worldstays)
      {
      }

      [Token(Token = "0x60026C5")]
      public T Instantiate() => (T) null;
    }
  }
}
