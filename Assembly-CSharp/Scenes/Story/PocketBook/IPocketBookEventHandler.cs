// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.IPocketBookEventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002D9E")]
  public interface IPocketBookEventHandler
  {
    [Token(Token = "0x17003CF9")]
    IPocketBookStoryIndexEventHandler StoryIndex { [Token(Token = "0x6011D88")] get; }

    [Token(Token = "0x6011D89")]
    void OnClose();

    [Token(Token = "0x6011D8A")]
    void OnTimeSkip();

    [Token(Token = "0x6011D8B")]
    void OnOpenKizunaListFromSchedule();

    [Token(Token = "0x6011D8C")]
    void OnOpenKizunaListFromMap();
  }
}
