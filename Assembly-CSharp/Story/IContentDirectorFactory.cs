// Decompiled with JetBrains decompiler
// Type: Story.IContentDirectorFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000594")]
  public interface IContentDirectorFactory
  {
    [Token(Token = "0x600203B")]
    IContentDirector Create(PlayingStoryInfo playingStory);
  }
}
