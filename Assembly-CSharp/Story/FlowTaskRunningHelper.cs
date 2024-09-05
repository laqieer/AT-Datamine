// Decompiled with JetBrains decompiler
// Type: Story.FlowTaskRunningHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005B8")]
  public class FlowTaskRunningHelper : StoryContentPlayDirector.IFlow
  {
    [Token(Token = "0x4001C99")]
    [FieldOffset(Offset = "0x18")]
    private bool calledStart;

    [Token(Token = "0x17000492")]
    public ContentTaskQueue TaskQueue
    {
      [Token(Token = "0x60020EB"), Address(RVA = "0x2D94BA8", Offset = "0x2D94BA8", VA = "0x2D94BA8")] get
      {
        return (ContentTaskQueue) null;
      }
    }

    [Token(Token = "0x60020EC")]
    [Address(RVA = "0x2D944D8", Offset = "0x2D944D8", VA = "0x2D944D8")]
    public bool IsEnd() => new bool();

    [Token(Token = "0x60020ED")]
    [Address(RVA = "0x2D9451C", Offset = "0x2D9451C", VA = "0x2D9451C", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x60020EE")]
    [Address(RVA = "0x2D945DC", Offset = "0x2D945DC", VA = "0x2D945DC")]
    public FlowTaskRunningHelper()
    {
    }
  }
}
