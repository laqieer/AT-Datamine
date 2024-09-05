// Decompiled with JetBrains decompiler
// Type: Story.FlowFinalizing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005B5")]
  public class FlowFinalizing : StoryContentPlayDirector.IFlow
  {
    [Token(Token = "0x4001C93")]
    [FieldOffset(Offset = "0x10")]
    private FlowTaskRunningHelper taskRunning;
    [Token(Token = "0x4001C94")]
    [FieldOffset(Offset = "0x18")]
    public Action OnEnd;

    [Token(Token = "0x17000490")]
    public ContentTaskQueue TaskQueue
    {
      [Token(Token = "0x60020E0"), Address(RVA = "0x2D948C4", Offset = "0x2D948C4", VA = "0x2D948C4")] get
      {
        return (ContentTaskQueue) null;
      }
    }

    [Token(Token = "0x60020E1")]
    [Address(RVA = "0x2D948E0", Offset = "0x2D948E0", VA = "0x2D948E0")]
    public bool IsEnd() => new bool();

    [Token(Token = "0x60020E2")]
    [Address(RVA = "0x2D94918", Offset = "0x2D94918", VA = "0x2D94918", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x60020E3")]
    [Address(RVA = "0x2D94958", Offset = "0x2D94958", VA = "0x2D94958")]
    public FlowFinalizing()
    {
    }
  }
}
