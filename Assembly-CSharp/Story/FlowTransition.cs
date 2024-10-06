// Decompiled with JetBrains decompiler
// Type: Story.FlowTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005B3")]
  public class FlowTransition : StoryContentPlayDirector.IFlow
  {
    [Token(Token = "0x4001C90")]
    [FieldOffset(Offset = "0x10")]
    private FlowTaskRunningHelper transitionTask;

    [Token(Token = "0x1700048E")]
    public ContentTaskQueue TaskQueue
    {
      [Token(Token = "0x60020D7"), Address(RVA = "0x2D94484", Offset = "0x2D94484", VA = "0x2D94484")] get
      {
        return (ContentTaskQueue) null;
      }
    }

    [Token(Token = "0x60020D8")]
    [Address(RVA = "0x2D944A0", Offset = "0x2D944A0", VA = "0x2D944A0")]
    public bool IsEnd() => new bool();

    [Token(Token = "0x60020D9")]
    [Address(RVA = "0x2D94504", Offset = "0x2D94504", VA = "0x2D94504", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x60020DA")]
    [Address(RVA = "0x2D94578", Offset = "0x2D94578", VA = "0x2D94578")]
    public FlowTransition()
    {
    }
  }
}
