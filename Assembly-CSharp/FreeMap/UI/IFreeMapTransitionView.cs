// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.IFreeMapTransitionView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x200160C")]
  public interface IFreeMapTransitionView
  {
    [Token(Token = "0x6007CDD")]
    void SetTitle(string title);

    [Token(Token = "0x6007CDE")]
    void PlayShow();

    [Token(Token = "0x6007CDF")]
    void PlayHide(Action callback);
  }
}
