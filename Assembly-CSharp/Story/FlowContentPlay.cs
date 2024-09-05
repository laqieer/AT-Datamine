// Decompiled with JetBrains decompiler
// Type: Story.FlowContentPlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005B4")]
  public class FlowContentPlay : 
    StoryContentPlayDirector.IFlow,
    StoryContentPlayDirector.IFlowStoppable
  {
    [Token(Token = "0x4001C91")]
    [FieldOffset(Offset = "0x10")]
    private IContentDirector director;
    [Token(Token = "0x4001C92")]
    [FieldOffset(Offset = "0x18")]
    private bool calledStart;

    [Token(Token = "0x1700048F")]
    public Content Content
    {
      [Token(Token = "0x60020DB"), Address(RVA = "0x2D94644", Offset = "0x2D94644", VA = "0x2D94644")] get
      {
        return (Content) null;
      }
    }

    [Token(Token = "0x60020DC")]
    [Address(RVA = "0x2D946E8", Offset = "0x2D946E8", VA = "0x2D946E8")]
    public void Assign(IContentDirector director)
    {
    }

    [Token(Token = "0x60020DD")]
    [Address(RVA = "0x2D946F0", Offset = "0x2D946F0", VA = "0x2D946F0", Slot = "4")]
    public void Update()
    {
    }

    [Token(Token = "0x60020DE")]
    [Address(RVA = "0x2D94814", Offset = "0x2D94814", VA = "0x2D94814", Slot = "5")]
    public void Abort()
    {
    }

    [Token(Token = "0x60020DF")]
    [Address(RVA = "0x2D948BC", Offset = "0x2D948BC", VA = "0x2D948BC")]
    public FlowContentPlay()
    {
    }
  }
}
