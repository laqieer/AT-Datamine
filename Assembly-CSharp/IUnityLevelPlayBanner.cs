// Decompiled with JetBrains decompiler
// Type: IUnityLevelPlayBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x200007A")]
public interface IUnityLevelPlayBanner
{
  [Token(Token = "0x140000AD")]
  event Action<IronSourceAdInfo> OnAdLoaded;

  [Token(Token = "0x140000AE")]
  event Action<IronSourceAdInfo> OnAdLeftApplication;

  [Token(Token = "0x140000AF")]
  event Action<IronSourceAdInfo> OnAdScreenDismissed;

  [Token(Token = "0x140000B0")]
  event Action<IronSourceAdInfo> OnAdScreenPresented;

  [Token(Token = "0x140000B1")]
  event Action<IronSourceAdInfo> OnAdClicked;

  [Token(Token = "0x140000B2")]
  event Action<IronSourceError> OnAdLoadFailed;
}
