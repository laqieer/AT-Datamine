// Decompiled with JetBrains decompiler
// Type: IronSourceIAgent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000042")]
public interface IronSourceIAgent
{
  [Token(Token = "0x6000234")]
  void SetWaterfallConfiguration(WaterfallConfiguration waterfallConfiguration, AdFormat adFormat);

  [Token(Token = "0x6000235")]
  void onApplicationPause(bool pause);

  [Token(Token = "0x6000236")]
  string getAdvertiserId();

  [Token(Token = "0x6000237")]
  void validateIntegration();

  [Token(Token = "0x6000238")]
  void shouldTrackNetworkState(bool track);

  [Token(Token = "0x6000239")]
  bool setDynamicUserId(string dynamicUserId);

  [Token(Token = "0x600023A")]
  void setAdaptersDebug(bool enabled);

  [Token(Token = "0x600023B")]
  void setMetaData(string key, string value);

  [Token(Token = "0x600023C")]
  void setMetaData(string key, params string[] values);

  [Token(Token = "0x600023D")]
  int? getConversionValue();

  [Token(Token = "0x600023E")]
  void setManualLoadRewardedVideo(bool isOn);

  [Token(Token = "0x600023F")]
  void setNetworkData(string networkKey, string networkData);

  [Token(Token = "0x6000240")]
  void SetPauseGame(bool pause);

  [Token(Token = "0x6000241")]
  void setUserId(string userId);

  [Token(Token = "0x6000242")]
  void init(string appKey);

  [Token(Token = "0x6000243")]
  void init(string appKey, params string[] adUnits);

  [Token(Token = "0x6000244")]
  void initISDemandOnly(string appKey, params string[] adUnits);

  [Token(Token = "0x6000245")]
  void loadRewardedVideo();

  [Token(Token = "0x6000246")]
  void showRewardedVideo();

  [Token(Token = "0x6000247")]
  void showRewardedVideo(string placementName);

  [Token(Token = "0x6000248")]
  bool isRewardedVideoAvailable();

  [Token(Token = "0x6000249")]
  bool isRewardedVideoPlacementCapped(string placementName);

  [Token(Token = "0x600024A")]
  IronSourcePlacement getPlacementInfo(string name);

  [Token(Token = "0x600024B")]
  void setRewardedVideoServerParams(Dictionary<string, string> parameters);

  [Token(Token = "0x600024C")]
  void clearRewardedVideoServerParams();

  [Token(Token = "0x600024D")]
  void showISDemandOnlyRewardedVideo(string instanceId);

  [Token(Token = "0x600024E")]
  void loadISDemandOnlyRewardedVideo(string instanceId);

  [Token(Token = "0x600024F")]
  bool isISDemandOnlyRewardedVideoAvailable(string instanceId);

  [Token(Token = "0x6000250")]
  void loadInterstitial();

  [Token(Token = "0x6000251")]
  void showInterstitial();

  [Token(Token = "0x6000252")]
  void showInterstitial(string placementName);

  [Token(Token = "0x6000253")]
  bool isInterstitialReady();

  [Token(Token = "0x6000254")]
  bool isInterstitialPlacementCapped(string placementName);

  [Token(Token = "0x6000255")]
  void loadISDemandOnlyInterstitial(string instanceId);

  [Token(Token = "0x6000256")]
  void showISDemandOnlyInterstitial(string instanceId);

  [Token(Token = "0x6000257")]
  bool isISDemandOnlyInterstitialReady(string instanceId);

  [Token(Token = "0x6000258")]
  void showOfferwall();

  [Token(Token = "0x6000259")]
  void showOfferwall(string placementName);

  [Token(Token = "0x600025A")]
  bool isOfferwallAvailable();

  [Token(Token = "0x600025B")]
  void getOfferwallCredits();

  [Token(Token = "0x600025C")]
  void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position);

  [Token(Token = "0x600025D")]
  void loadBanner(
    IronSourceBannerSize size,
    IronSourceBannerPosition position,
    string placementName);

  [Token(Token = "0x600025E")]
  void destroyBanner();

  [Token(Token = "0x600025F")]
  void displayBanner();

  [Token(Token = "0x6000260")]
  void hideBanner();

  [Token(Token = "0x6000261")]
  bool isBannerPlacementCapped(string placementName);

  [Token(Token = "0x6000262")]
  float getMaximalAdaptiveHeight(float width);

  [Token(Token = "0x6000263")]
  float getDeviceScreenWidth();

  [Token(Token = "0x6000264")]
  void setSegment(IronSourceSegment segment);

  [Token(Token = "0x6000265")]
  void setConsent(bool consent);

  [Token(Token = "0x6000266")]
  void loadConsentViewWithType(string consentViewType);

  [Token(Token = "0x6000267")]
  void showConsentViewWithType(string consentViewType);

  [Token(Token = "0x6000268")]
  void setAdRevenueData(string dataSource, Dictionary<string, string> impressionData);

  [Token(Token = "0x6000269")]
  void launchTestSuite();
}
