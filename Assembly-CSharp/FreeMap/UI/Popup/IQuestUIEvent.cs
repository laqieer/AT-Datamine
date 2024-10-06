// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Popup.IQuestUIEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.UI.Popup
{
  [Token(Token = "0x200162B")]
  public interface IQuestUIEvent
  {
    [Token(Token = "0x6007D9A")]
    void OnPositive();

    [Token(Token = "0x6007D9B")]
    void OnNegative();

    [Token(Token = "0x6007D9C")]
    void OnNeutral();

    [Token(Token = "0x6007D9D")]
    void OnClose();

    [Token(Token = "0x6007D9E")]
    void OnPocketBook();

    [Token(Token = "0x6007D9F")]
    void OnMap();

    [Token(Token = "0x6007DA0")]
    void OnPositiveSE();
  }
}
