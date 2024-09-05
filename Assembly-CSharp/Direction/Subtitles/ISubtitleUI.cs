// Decompiled with JetBrains decompiler
// Type: Direction.Subtitles.ISubtitleUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Direction.Subtitles
{
  [Token(Token = "0x2001F23")]
  public interface ISubtitleUI
  {
    [Token(Token = "0x600B8E6")]
    void Init();

    [Token(Token = "0x600B8E7")]
    void SetActive(bool isActive);

    [Token(Token = "0x600B8E8")]
    void SetSubtitle(string subtitle);

    [Token(Token = "0x600B8E9")]
    void SetTalkerAndSubtitle(string talker, string subtitle);
  }
}
