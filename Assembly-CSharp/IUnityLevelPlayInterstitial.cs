// Decompiled with JetBrains decompiler
// Type: IUnityLevelPlayInterstitial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x200007B")]
public interface IUnityLevelPlayInterstitial
{
  [Token(Token = "0x140000B3")]
  event Action<IronSourceError, IronSourceAdInfo> OnAdShowFailed;

  [Token(Token = "0x140000B4")]
  event Action<IronSourceError> OnAdLoadFailed;

  [Token(Token = "0x140000B5")]
  event Action<IronSourceAdInfo> OnAdReady;

  [Token(Token = "0x140000B6")]
  event Action<IronSourceAdInfo> OnAdOpened;

  [Token(Token = "0x140000B7")]
  event Action<IronSourceAdInfo> OnAdClosed;

  [Token(Token = "0x140000B8")]
  event Action<IronSourceAdInfo> OnAdShowSucceeded;

  [Token(Token = "0x140000B9")]
  event Action<IronSourceAdInfo> OnAdClicked;
}
