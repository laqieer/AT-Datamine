// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.UIState.IStoryArchiveViewState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story.StoryArchive.UIState
{
  [Token(Token = "0x200065A")]
  public interface IStoryArchiveViewState
  {
    [Token(Token = "0x6002483")]
    IEnumerator InitializeAsync();

    [Token(Token = "0x6002484")]
    IEnumerator EndAsync();
  }
}
