// Decompiled with JetBrains decompiler
// Type: IUnityBanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x2000076")]
public interface IUnityBanner
{
  [Token(Token = "0x14000096")]
  event Action OnBannerAdLoaded;

  [Token(Token = "0x14000097")]
  event Action OnBannerAdLeftApplication;

  [Token(Token = "0x14000098")]
  event Action OnBannerAdScreenDismissed;

  [Token(Token = "0x14000099")]
  event Action OnBannerAdScreenPresented;

  [Token(Token = "0x1400009A")]
  event Action OnBannerAdClicked;

  [Token(Token = "0x1400009B")]
  event Action<IronSourceError> OnBannerAdLoadFailed;
}
