// Decompiled with JetBrains decompiler
// Type: IUnityInterstitial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x2000079")]
public interface IUnityInterstitial
{
  [Token(Token = "0x1400009F")]
  event Action<IronSourceError> OnInterstitialAdShowFailed;

  [Token(Token = "0x140000A0")]
  event Action<IronSourceError> OnInterstitialAdLoadFailed;

  [Token(Token = "0x140000A1")]
  event Action OnInterstitialAdReady;

  [Token(Token = "0x140000A2")]
  event Action OnInterstitialAdOpened;

  [Token(Token = "0x140000A3")]
  event Action OnInterstitialAdClosed;

  [Token(Token = "0x140000A4")]
  event Action OnInterstitialAdShowSucceeded;

  [Token(Token = "0x140000A5")]
  event Action OnInterstitialAdClicked;

  [Token(Token = "0x140000A6")]
  event Action OnInterstitialAdRewarded;

  [Token(Token = "0x140000A7")]
  event Action<string> OnInterstitialAdReadyDemandOnly;

  [Token(Token = "0x140000A8")]
  event Action<string> OnInterstitialAdOpenedDemandOnly;

  [Token(Token = "0x140000A9")]
  event Action<string> OnInterstitialAdClosedDemandOnly;

  [Token(Token = "0x140000AA")]
  event Action<string, IronSourceError> OnInterstitialAdLoadFailedDemandOnly;

  [Token(Token = "0x140000AB")]
  event Action<string> OnInterstitialAdClickedDemandOnly;

  [Token(Token = "0x140000AC")]
  event Action<string, IronSourceError> OnInterstitialAdShowFailedDemandOnly;
}
