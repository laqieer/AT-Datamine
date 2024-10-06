// Decompiled with JetBrains decompiler
// Type: Story.FlowInitializing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005AA")]
  public class FlowInitializing : StoryContentPlayDirector.IFlow
  {
    [Token(Token = "0x4001C77")]
    [FieldOffset(Offset = "0x10")]
    private ContentTaskQueue initialize;
    [Token(Token = "0x4001C78")]
    [FieldOffset(Offset = "0x18")]
    private bool start;
    [Token(Token = "0x4001C79")]
    [FieldOffset(Offset = "0x19")]
    private bool end;

    [Token(Token = "0x60020A7")]
    [Address(RVA = "0x2D92BCC", Offset = "0x2D92BCC", VA = "0x2D92BCC")]
    public bool IsEnd() => new bool();

    [Token(Token = "0x140000E2")]
    public event Action OnEnd
    {
      [Token(Token = "0x60020A8"), Address(RVA = "0x2D92BD4", Offset = "0x2D92BD4", VA = "0x2D92BD4")] add
      {
      }
      [Token(Token = "0x60020A9"), Address(RVA = "0x2D92C70", Offset = "0x2D92C70", VA = "0x2D92C70")] remove
      {
      }
    }

    [Token(Token = "0x60020AA")]
    [Address(RVA = "0x2D92D0C", Offset = "0x2D92D0C", VA = "0x2D92D0C")]
    public FlowInitializing(ContentTaskQueue initialize)
    {
    }

    [Token(Token = "0x60020AB")]
    [Address(RVA = "0x2D92D34", Offset = "0x2D92D34", VA = "0x2D92D34", Slot = "4")]
    public void Update()
    {
    }
  }
}
