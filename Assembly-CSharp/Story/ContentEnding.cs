// Decompiled with JetBrains decompiler
// Type: Story.ContentEnding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.Ending;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000553")]
  public sealed class ContentEnding : Content
  {
    [Token(Token = "0x4001BC3")]
    [FieldOffset(Offset = "0x20")]
    private SequenseTaskBase[] seqTasks;
    [Token(Token = "0x4001BC4")]
    [FieldOffset(Offset = "0x28")]
    private int nowSeqTaskIndex;

    [Token(Token = "0x17000439")]
    public int NowSequenceId
    {
      [Token(Token = "0x6001ED0"), Address(RVA = "0x29FFD78", Offset = "0x29FFD78", VA = "0x29FFD78")] get
      {
        return new int();
      }
      [Token(Token = "0x6001ED1"), Address(RVA = "0x29FFD80", Offset = "0x29FFD80", VA = "0x29FFD80")] private set
      {
      }
    }

    [Token(Token = "0x6001ED2")]
    [Address(RVA = "0x29FFD88", Offset = "0x29FFD88", VA = "0x29FFD88")]
    public ContentEnding()
    {
    }

    [Token(Token = "0x6001ED3")]
    [Address(RVA = "0x29FFD98", Offset = "0x29FFD98", VA = "0x29FFD98", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001ED4")]
    [Address(RVA = "0x2A00354", Offset = "0x2A00354", VA = "0x2A00354", Slot = "5")]
    protected override void OnUpdate()
    {
    }
  }
}
