// Decompiled with JetBrains decompiler
// Type: IUnityRewardedVideo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x200007F")]
public interface IUnityRewardedVideo
{
  [Token(Token = "0x140000C9")]
  event Action<IronSourceError> OnRewardedVideoAdShowFailed;

  [Token(Token = "0x140000CA")]
  event Action OnRewardedVideoAdOpened;

  [Token(Token = "0x140000CB")]
  event Action OnRewardedVideoAdClosed;

  [Token(Token = "0x140000CC")]
  event Action OnRewardedVideoAdStarted;

  [Token(Token = "0x140000CD")]
  event Action OnRewardedVideoAdEnded;

  [Token(Token = "0x140000CE")]
  event Action<IronSourcePlacement> OnRewardedVideoAdRewarded;

  [Token(Token = "0x140000CF")]
  event Action<IronSourcePlacement> OnRewardedVideoAdClicked;

  [Token(Token = "0x140000D0")]
  event Action<bool> OnRewardedVideoAvailabilityChanged;

  [Token(Token = "0x140000D1")]
  event Action<string> OnRewardedVideoAdOpenedDemandOnlyEvent;

  [Token(Token = "0x140000D2")]
  event Action<string> OnRewardedVideoAdClosedDemandOnlyEvent;

  [Token(Token = "0x140000D3")]
  event Action<string> OnRewardedVideoAdLoadedDemandOnlyEvent;

  [Token(Token = "0x140000D4")]
  event Action<string> OnRewardedVideoAdRewardedDemandOnlyEvent;

  [Token(Token = "0x140000D5")]
  event Action<string, IronSourceError> OnRewardedVideoAdShowFailedDemandOnlyEvent;

  [Token(Token = "0x140000D6")]
  event Action<string> OnRewardedVideoAdClickedDemandOnlyEvent;

  [Token(Token = "0x140000D7")]
  event Action<string, IronSourceError> OnRewardedVideoAdLoadFailedDemandOnlyEvent;
}
