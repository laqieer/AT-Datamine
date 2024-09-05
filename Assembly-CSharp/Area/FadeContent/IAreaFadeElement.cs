// Decompiled with JetBrains decompiler
// Type: Area.FadeContent.IAreaFadeElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Area.FadeContent
{
  [Token(Token = "0x2002850")]
  public interface IAreaFadeElement
  {
    [Token(Token = "0x600FDEC")]
    void SetFade(float ratio);

    [Token(Token = "0x600FDED")]
    void SetInvisible();

    [Token(Token = "0x600FDEE")]
    void SetShown();

    [Token(Token = "0x600FDEF")]
    void SetEnableRenderer(bool enable);

    [Token(Token = "0x600FDF0")]
    void Destroy();
  }
}
