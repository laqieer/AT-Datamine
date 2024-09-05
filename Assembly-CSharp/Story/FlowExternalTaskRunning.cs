// Decompiled with JetBrains decompiler
// Type: Story.FlowExternalTaskRunning
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005B7")]
  public class FlowExternalTaskRunning : StoryContentPlayDirector.IFlow
  {
    [Token(Token = "0x4001C97")]
    [FieldOffset(Offset = "0x10")]
    private FlowTaskRunningHelper taskRunning;

    [Token(Token = "0x17000491")]
    public ContentTaskQueue TaskQueue
    {
      [Token(Token = "0x60020E7"), Address(RVA = "0x2D94AD8", Offset = "0x2D94AD8", VA = "0x2D94AD8")] get
      {
        return (ContentTaskQueue) null;
      }
    }

    [Token(Token = "0x60020E8")]
    [Address(RVA = "0x2D94AF4", Offset = "0x2D94AF4", VA = "0x2D94AF4")]
    public bool IsEnd() => new bool();

    [Token(Token = "0x60020E9")]
    [Address(RVA = "0x2D94B2C", Offset = "0x2D94B2C", VA = "0x2D94B2C", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x60020EA")]
    [Address(RVA = "0x2D94B44", Offset = "0x2D94B44", VA = "0x2D94B44")]
    public FlowExternalTaskRunning()
    {
    }
  }
}
