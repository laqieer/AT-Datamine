// Decompiled with JetBrains decompiler
// Type: IUnityLevelPlayRewardedVideo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x200007C")]
public interface IUnityLevelPlayRewardedVideo
{
  [Token(Token = "0x140000BA")]
  event Action<IronSourceError, IronSourceAdInfo> OnAdShowFailed;

  [Token(Token = "0x140000BB")]
  event Action<IronSourceAdInfo> OnAdOpened;

  [Token(Token = "0x140000BC")]
  event Action<IronSourceAdInfo> OnAdClosed;

  [Token(Token = "0x140000BD")]
  event Action<IronSourcePlacement, IronSourceAdInfo> OnAdRewarded;

  [Token(Token = "0x140000BE")]
  event Action<IronSourcePlacement, IronSourceAdInfo> OnAdClicked;

  [Token(Token = "0x140000BF")]
  event Action<IronSourceAdInfo> OnAdAvailable;

  [Token(Token = "0x140000C0")]
  event Action OnAdUnavailable;
}
