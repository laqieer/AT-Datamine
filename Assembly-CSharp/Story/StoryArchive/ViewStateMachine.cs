// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.ViewStateMachine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.StoryArchive.UIState;
using System.Collections;

#nullable disable
namespace Story.StoryArchive
{
  [Token(Token = "0x2000641")]
  public class ViewStateMachine
  {
    [Token(Token = "0x4001E8B")]
    [FieldOffset(Offset = "0x10")]
    private IStoryArchiveViewState currentState;

    [Token(Token = "0x600241F")]
    [Address(RVA = "0x2F2EC68", Offset = "0x2F2EC68", VA = "0x2F2EC68")]
    public IEnumerator Start(IStoryArchiveViewState storyArchiveViewState) => (IEnumerator) null;

    [Token(Token = "0x6002420")]
    [Address(RVA = "0x2F2ED04", Offset = "0x2F2ED04", VA = "0x2F2ED04")]
    private bool HasActiveState() => new bool();

    [Token(Token = "0x6002421")]
    [Address(RVA = "0x2F2ED14", Offset = "0x2F2ED14", VA = "0x2F2ED14")]
    public IEnumerator End() => (IEnumerator) null;

    [Token(Token = "0x6002422")]
    [Address(RVA = "0x2F2EDA4", Offset = "0x2F2EDA4", VA = "0x2F2EDA4")]
    public ViewStateMachine()
    {
    }
  }
}
