// Decompiled with JetBrains decompiler
// Type: UnsupportedPlatformAgent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000082")]
public class UnsupportedPlatformAgent : IronSourceIAgent
{
  [Token(Token = "0x6000481")]
  [Address(RVA = "0x44AD828", Offset = "0x44AD828", VA = "0x44AD828")]
  public UnsupportedPlatformAgent()
  {
  }

  [Token(Token = "0x6000482")]
  [Address(RVA = "0x44AD8A0", Offset = "0x44AD8A0", VA = "0x44AD8A0", Slot = "4")]
  public void SetWaterfallConfiguration(
    WaterfallConfiguration waterfallConfiguration,
    AdFormat adFormat)
  {
  }

  [Token(Token = "0x6000483")]
  [Address(RVA = "0x44AD8A4", Offset = "0x44AD8A4", VA = "0x44AD8A4")]
  public void start()
  {
  }

  [Token(Token = "0x6000484")]
  [Address(RVA = "0x44AD8A8", Offset = "0x44AD8A8", VA = "0x44AD8A8", Slot = "5")]
  public void onApplicationPause(bool pause)
  {
  }

  [Token(Token = "0x6000485")]
  [Address(RVA = "0x44AD8AC", Offset = "0x44AD8AC", VA = "0x44AD8AC", Slot = "6")]
  public string getAdvertiserId() => (string) null;

  [Token(Token = "0x6000486")]
  [Address(RVA = "0x44AD8EC", Offset = "0x44AD8EC", VA = "0x44AD8EC", Slot = "7")]
  public void validateIntegration()
  {
  }

  [Token(Token = "0x6000487")]
  [Address(RVA = "0x44AD8F0", Offset = "0x44AD8F0", VA = "0x44AD8F0", Slot = "8")]
  public void shouldTrackNetworkState(bool track)
  {
  }

  [Token(Token = "0x6000488")]
  [Address(RVA = "0x44AD8F4", Offset = "0x44AD8F4", VA = "0x44AD8F4", Slot = "9")]
  public bool setDynamicUserId(string dynamicUserId) => new bool();

  [Token(Token = "0x6000489")]
  [Address(RVA = "0x44AD8FC", Offset = "0x44AD8FC", VA = "0x44AD8FC", Slot = "10")]
  public void setAdaptersDebug(bool enabled)
  {
  }

  [Token(Token = "0x600048A")]
  [Address(RVA = "0x44AD900", Offset = "0x44AD900", VA = "0x44AD900", Slot = "11")]
  public void setMetaData(string key, string value)
  {
  }

  [Token(Token = "0x600048B")]
  [Address(RVA = "0x44AD904", Offset = "0x44AD904", VA = "0x44AD904", Slot = "12")]
  public void setMetaData(string key, params string[] values)
  {
  }

  [Token(Token = "0x600048C")]
  [Address(RVA = "0x44AD908", Offset = "0x44AD908", VA = "0x44AD908", Slot = "13")]
  public int? getConversionValue() => new int?();

  [Token(Token = "0x600048D")]
  [Address(RVA = "0x44AD910", Offset = "0x44AD910", VA = "0x44AD910", Slot = "14")]
  public void setManualLoadRewardedVideo(bool isOn)
  {
  }

  [Token(Token = "0x600048E")]
  [Address(RVA = "0x44AD914", Offset = "0x44AD914", VA = "0x44AD914", Slot = "15")]
  public void setNetworkData(string networkKey, string networkDataJson)
  {
  }

  [Token(Token = "0x600048F")]
  [Address(RVA = "0x44AD918", Offset = "0x44AD918", VA = "0x44AD918", Slot = "16")]
  public void SetPauseGame(bool pause)
  {
  }

  [Token(Token = "0x6000490")]
  [Address(RVA = "0x44AD91C", Offset = "0x44AD91C", VA = "0x44AD91C", Slot = "17")]
  public void setUserId(string userId)
  {
  }

  [Token(Token = "0x6000491")]
  [Address(RVA = "0x44AD920", Offset = "0x44AD920", VA = "0x44AD920", Slot = "18")]
  public void init(string appKey)
  {
  }

  [Token(Token = "0x6000492")]
  [Address(RVA = "0x44AD924", Offset = "0x44AD924", VA = "0x44AD924", Slot = "19")]
  public void init(string appKey, params string[] adUnits)
  {
  }

  [Token(Token = "0x6000493")]
  [Address(RVA = "0x44AD928", Offset = "0x44AD928", VA = "0x44AD928", Slot = "20")]
  public void initISDemandOnly(string appKey, params string[] adUnits)
  {
  }

  [Token(Token = "0x6000494")]
  [Address(RVA = "0x44AD92C", Offset = "0x44AD92C", VA = "0x44AD92C", Slot = "21")]
  public void loadRewardedVideo()
  {
  }

  [Token(Token = "0x6000495")]
  [Address(RVA = "0x44AD930", Offset = "0x44AD930", VA = "0x44AD930", Slot = "22")]
  public void showRewardedVideo()
  {
  }

  [Token(Token = "0x6000496")]
  [Address(RVA = "0x44AD934", Offset = "0x44AD934", VA = "0x44AD934", Slot = "23")]
  public void showRewardedVideo(string placementName)
  {
  }

  [Token(Token = "0x6000497")]
  [Address(RVA = "0x44AD938", Offset = "0x44AD938", VA = "0x44AD938", Slot = "24")]
  public bool isRewardedVideoAvailable() => new bool();

  [Token(Token = "0x6000498")]
  [Address(RVA = "0x44AD940", Offset = "0x44AD940", VA = "0x44AD940", Slot = "25")]
  public bool isRewardedVideoPlacementCapped(string placementName) => new bool();

  [Token(Token = "0x6000499")]
  [Address(RVA = "0x44AD948", Offset = "0x44AD948", VA = "0x44AD948", Slot = "26")]
  public IronSourcePlacement getPlacementInfo(string placementName) => (IronSourcePlacement) null;

  [Token(Token = "0x600049A")]
  [Address(RVA = "0x44AD950", Offset = "0x44AD950", VA = "0x44AD950", Slot = "27")]
  public void setRewardedVideoServerParams(Dictionary<string, string> parameters)
  {
  }

  [Token(Token = "0x600049B")]
  [Address(RVA = "0x44AD954", Offset = "0x44AD954", VA = "0x44AD954", Slot = "28")]
  public void clearRewardedVideoServerParams()
  {
  }

  [Token(Token = "0x600049C")]
  [Address(RVA = "0x44AD958", Offset = "0x44AD958", VA = "0x44AD958", Slot = "29")]
  public void showISDemandOnlyRewardedVideo(string instanceId)
  {
  }

  [Token(Token = "0x600049D")]
  [Address(RVA = "0x44AD95C", Offset = "0x44AD95C", VA = "0x44AD95C", Slot = "30")]
  public void loadISDemandOnlyRewardedVideo(string instanceId)
  {
  }

  [Token(Token = "0x600049E")]
  [Address(RVA = "0x44AD960", Offset = "0x44AD960", VA = "0x44AD960", Slot = "31")]
  public bool isISDemandOnlyRewardedVideoAvailable(string instanceId) => new bool();

  [Token(Token = "0x600049F")]
  [Address(RVA = "0x44AD968", Offset = "0x44AD968", VA = "0x44AD968", Slot = "32")]
  public void loadInterstitial()
  {
  }

  [Token(Token = "0x60004A0")]
  [Address(RVA = "0x44AD96C", Offset = "0x44AD96C", VA = "0x44AD96C", Slot = "33")]
  public void showInterstitial()
  {
  }

  [Token(Token = "0x60004A1")]
  [Address(RVA = "0x44AD970", Offset = "0x44AD970", VA = "0x44AD970", Slot = "34")]
  public void showInterstitial(string placementName)
  {
  }

  [Token(Token = "0x60004A2")]
  [Address(RVA = "0x44AD974", Offset = "0x44AD974", VA = "0x44AD974", Slot = "35")]
  public bool isInterstitialReady() => new bool();

  [Token(Token = "0x60004A3")]
  [Address(RVA = "0x44AD97C", Offset = "0x44AD97C", VA = "0x44AD97C", Slot = "36")]
  public bool isInterstitialPlacementCapped(string placementName) => new bool();

  [Token(Token = "0x60004A4")]
  [Address(RVA = "0x44AD984", Offset = "0x44AD984", VA = "0x44AD984", Slot = "37")]
  public void loadISDemandOnlyInterstitial(string instanceId)
  {
  }

  [Token(Token = "0x60004A5")]
  [Address(RVA = "0x44AD988", Offset = "0x44AD988", VA = "0x44AD988", Slot = "38")]
  public void showISDemandOnlyInterstitial(string instanceId)
  {
  }

  [Token(Token = "0x60004A6")]
  [Address(RVA = "0x44AD98C", Offset = "0x44AD98C", VA = "0x44AD98C", Slot = "39")]
  public bool isISDemandOnlyInterstitialReady(string instanceId) => new bool();

  [Token(Token = "0x60004A7")]
  [Address(RVA = "0x44AD994", Offset = "0x44AD994", VA = "0x44AD994", Slot = "40")]
  public void showOfferwall()
  {
  }

  [Token(Token = "0x60004A8")]
  [Address(RVA = "0x44AD998", Offset = "0x44AD998", VA = "0x44AD998", Slot = "41")]
  public void showOfferwall(string placementName)
  {
  }

  [Token(Token = "0x60004A9")]
  [Address(RVA = "0x44AD99C", Offset = "0x44AD99C", VA = "0x44AD99C", Slot = "43")]
  public void getOfferwallCredits()
  {
  }

  [Token(Token = "0x60004AA")]
  [Address(RVA = "0x44AD9A0", Offset = "0x44AD9A0", VA = "0x44AD9A0", Slot = "42")]
  public bool isOfferwallAvailable() => new bool();

  [Token(Token = "0x60004AB")]
  [Address(RVA = "0x44AD9A8", Offset = "0x44AD9A8", VA = "0x44AD9A8", Slot = "44")]
  public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position)
  {
  }

  [Token(Token = "0x60004AC")]
  [Address(RVA = "0x44AD9AC", Offset = "0x44AD9AC", VA = "0x44AD9AC", Slot = "45")]
  public void loadBanner(
    IronSourceBannerSize size,
    IronSourceBannerPosition position,
    string placementName)
  {
  }

  [Token(Token = "0x60004AD")]
  [Address(RVA = "0x44AD9B0", Offset = "0x44AD9B0", VA = "0x44AD9B0", Slot = "46")]
  public void destroyBanner()
  {
  }

  [Token(Token = "0x60004AE")]
  [Address(RVA = "0x44AD9B4", Offset = "0x44AD9B4", VA = "0x44AD9B4", Slot = "47")]
  public void displayBanner()
  {
  }

  [Token(Token = "0x60004AF")]
  [Address(RVA = "0x44AD9B8", Offset = "0x44AD9B8", VA = "0x44AD9B8", Slot = "48")]
  public void hideBanner()
  {
  }

  [Token(Token = "0x60004B0")]
  [Address(RVA = "0x44AD9BC", Offset = "0x44AD9BC", VA = "0x44AD9BC", Slot = "49")]
  public bool isBannerPlacementCapped(string placementName) => new bool();

  [Token(Token = "0x60004B1")]
  [Address(RVA = "0x44AD9C4", Offset = "0x44AD9C4", VA = "0x44AD9C4", Slot = "50")]
  public float getMaximalAdaptiveHeight(float width) => new float();

  [Token(Token = "0x60004B2")]
  [Address(RVA = "0x44AD9CC", Offset = "0x44AD9CC", VA = "0x44AD9CC", Slot = "51")]
  public float getDeviceScreenWidth() => new float();

  [Token(Token = "0x60004B3")]
  [Address(RVA = "0x44AD9D4", Offset = "0x44AD9D4", VA = "0x44AD9D4")]
  public void setBannerContainerParams(ISContainerParams parameters)
  {
  }

  [Token(Token = "0x60004B4")]
  [Address(RVA = "0x44AD9D8", Offset = "0x44AD9D8", VA = "0x44AD9D8", Slot = "52")]
  public void setSegment(IronSourceSegment segment)
  {
  }

  [Token(Token = "0x60004B5")]
  [Address(RVA = "0x44AD9DC", Offset = "0x44AD9DC", VA = "0x44AD9DC", Slot = "53")]
  public void setConsent(bool consent)
  {
  }

  [Token(Token = "0x60004B6")]
  [Address(RVA = "0x44AD9E0", Offset = "0x44AD9E0", VA = "0x44AD9E0", Slot = "54")]
  public void loadConsentViewWithType(string consentViewType)
  {
  }

  [Token(Token = "0x60004B7")]
  [Address(RVA = "0x44AD9E4", Offset = "0x44AD9E4", VA = "0x44AD9E4", Slot = "55")]
  public void showConsentViewWithType(string consentViewType)
  {
  }

  [Token(Token = "0x60004B8")]
  [Address(RVA = "0x44AD9E8", Offset = "0x44AD9E8", VA = "0x44AD9E8", Slot = "56")]
  public void setAdRevenueData(string dataSource, Dictionary<string, string> impressionData)
  {
  }

  [Token(Token = "0x60004B9")]
  [Address(RVA = "0x44AD9EC", Offset = "0x44AD9EC", VA = "0x44AD9EC", Slot = "57")]
  public void launchTestSuite()
  {
  }
}
