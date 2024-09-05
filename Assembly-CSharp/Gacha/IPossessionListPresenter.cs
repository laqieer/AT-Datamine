// Decompiled with JetBrains decompiler
// Type: Gacha.IPossessionListPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001556")]
  internal interface IPossessionListPresenter
  {
    [Token(Token = "0x60078D6")]
    void AssignPossessionListItemPresenter(PossessionListItemView view, int index);

    [Token(Token = "0x60078D7")]
    void Initialize();

    [Token(Token = "0x60078D8")]
    void JumpButtonClicked();

    [Token(Token = "0x60078D9")]
    void CloseButtonClicked();

    [Token(Token = "0x60078DA")]
    void OutOfRangeButtonClicked();

    [Token(Token = "0x60078DB")]
    void Open();

    [Token(Token = "0x60078DC")]
    void CloseAnimationFinished();

    [Token(Token = "0x60078DD")]
    void OpenAnimationFinished();
  }
}
