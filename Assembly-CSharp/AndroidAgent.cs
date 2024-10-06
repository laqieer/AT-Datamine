// Decompiled with JetBrains decompiler
// Type: AndroidAgent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000010")]
public class AndroidAgent : IronSourceIAgent
{
  [Token(Token = "0x4000022")]
  [FieldOffset(Offset = "0x0")]
  private static AndroidJavaObject _androidBridge;
  [Token(Token = "0x4000023")]
  [FieldOffset(Offset = "0x8")]
  private static readonly string AndroidBridge;
  [Token(Token = "0x4000024")]
  private const string REWARD_AMOUNT = "reward_amount";
  [Token(Token = "0x4000025")]
  private const string REWARD_NAME = "reward_name";
  [Token(Token = "0x4000026")]
  private const string PLACEMENT_NAME = "placement_name";
  [Token(Token = "0x4000027")]
  private const string WATERFALL_CONFIG_FLOOR = "floor";
  [Token(Token = "0x4000028")]
  private const string WATERFALL_CONFIG_CEILING = "ceiling";
  [Token(Token = "0x4000029")]
  private const string WATERFALL_CONFIG_API = "setWaterfallConfiguration";

  [Token(Token = "0x6000049")]
  [Address(RVA = "0x203E05C", Offset = "0x203E05C", VA = "0x203E05C")]
  public AndroidAgent()
  {
  }

  [Token(Token = "0x600004A")]
  [Address(RVA = "0x203E0BC", Offset = "0x203E0BC", VA = "0x203E0BC")]
  public AndroidJavaObject getBridge() => (AndroidJavaObject) null;

  [Token(Token = "0x600004B")]
  [Address(RVA = "0x203E070", Offset = "0x203E070", VA = "0x203E070")]
  private void initEventsDispatcher()
  {
  }

  [Token(Token = "0x600004C")]
  [Address(RVA = "0x203E478", Offset = "0x203E478", VA = "0x203E478", Slot = "4")]
  public void SetWaterfallConfiguration(
    WaterfallConfiguration waterfallConfiguration,
    AdFormat adFormat)
  {
  }

  [Token(Token = "0x600004D")]
  [Address(RVA = "0x203E764", Offset = "0x203E764", VA = "0x203E764", Slot = "5")]
  public void onApplicationPause(bool pause)
  {
  }

  [Token(Token = "0x600004E")]
  [Address(RVA = "0x203E83C", Offset = "0x203E83C", VA = "0x203E83C", Slot = "6")]
  public string getAdvertiserId() => (string) null;

  [Token(Token = "0x600004F")]
  [Address(RVA = "0x203E908", Offset = "0x203E908", VA = "0x203E908", Slot = "7")]
  public void validateIntegration()
  {
  }

  [Token(Token = "0x6000050")]
  [Address(RVA = "0x203E9C0", Offset = "0x203E9C0", VA = "0x203E9C0", Slot = "8")]
  public void shouldTrackNetworkState(bool track)
  {
  }

  [Token(Token = "0x6000051")]
  [Address(RVA = "0x203EAB4", Offset = "0x203EAB4", VA = "0x203EAB4", Slot = "9")]
  public bool setDynamicUserId(string dynamicUserId) => new bool();

  [Token(Token = "0x6000052")]
  [Address(RVA = "0x203EB88", Offset = "0x203EB88", VA = "0x203EB88", Slot = "10")]
  public void setAdaptersDebug(bool enabled)
  {
  }

  [Token(Token = "0x6000053")]
  [Address(RVA = "0x203EC7C", Offset = "0x203EC7C", VA = "0x203EC7C", Slot = "11")]
  public void setMetaData(string key, string value)
  {
  }

  [Token(Token = "0x6000054")]
  [Address(RVA = "0x203ED70", Offset = "0x203ED70", VA = "0x203ED70", Slot = "12")]
  public void setMetaData(string key, params string[] values)
  {
  }

  [Token(Token = "0x6000055")]
  [Address(RVA = "0x203EE64", Offset = "0x203EE64", VA = "0x203EE64", Slot = "13")]
  public int? getConversionValue() => new int?();

  [Token(Token = "0x6000056")]
  [Address(RVA = "0x203EE6C", Offset = "0x203EE6C", VA = "0x203EE6C", Slot = "14")]
  public void setManualLoadRewardedVideo(bool isOn)
  {
  }

  [Token(Token = "0x6000057")]
  [Address(RVA = "0x203EF60", Offset = "0x203EF60", VA = "0x203EF60", Slot = "15")]
  public void setNetworkData(string networkKey, string networkData)
  {
  }

  [Token(Token = "0x6000058")]
  [Address(RVA = "0x203F054", Offset = "0x203F054", VA = "0x203F054", Slot = "16")]
  public void SetPauseGame(bool pause)
  {
  }

  [Token(Token = "0x6000059")]
  [Address(RVA = "0x203F058", Offset = "0x203F058", VA = "0x203F058", Slot = "17")]
  public void setUserId(string userId)
  {
  }

  [Token(Token = "0x600005A")]
  [Address(RVA = "0x203F118", Offset = "0x203F118", VA = "0x203F118", Slot = "18")]
  public void init(string appKey)
  {
  }

  [Token(Token = "0x600005B")]
  [Address(RVA = "0x203F3C4", Offset = "0x203F3C4", VA = "0x203F3C4", Slot = "19")]
  public void init(string appKey, params string[] adUnits)
  {
  }

  [Token(Token = "0x600005C")]
  [Address(RVA = "0x203F69C", Offset = "0x203F69C", VA = "0x203F69C", Slot = "20")]
  public void initISDemandOnly(string appKey, params string[] adUnits)
  {
  }

  [Token(Token = "0x600005D")]
  [Address(RVA = "0x203F974", Offset = "0x203F974", VA = "0x203F974", Slot = "21")]
  public void loadRewardedVideo()
  {
  }

  [Token(Token = "0x600005E")]
  [Address(RVA = "0x203FA2C", Offset = "0x203FA2C", VA = "0x203FA2C", Slot = "22")]
  public void showRewardedVideo()
  {
  }

  [Token(Token = "0x600005F")]
  [Address(RVA = "0x203FAE4", Offset = "0x203FAE4", VA = "0x203FAE4", Slot = "23")]
  public void showRewardedVideo(string placementName)
  {
  }

  [Token(Token = "0x6000060")]
  [Address(RVA = "0x203FBA4", Offset = "0x203FBA4", VA = "0x203FBA4", Slot = "24")]
  public bool isRewardedVideoAvailable() => new bool();

  [Token(Token = "0x6000061")]
  [Address(RVA = "0x203FC70", Offset = "0x203FC70", VA = "0x203FC70", Slot = "25")]
  public bool isRewardedVideoPlacementCapped(string placementName) => new bool();

  [Token(Token = "0x6000062")]
  [Address(RVA = "0x203FD44", Offset = "0x203FD44", VA = "0x203FD44", Slot = "26")]
  public IronSourcePlacement getPlacementInfo(string placementName) => (IronSourcePlacement) null;

  [Token(Token = "0x6000063")]
  [Address(RVA = "0x203FFB4", Offset = "0x203FFB4", VA = "0x203FFB4", Slot = "27")]
  public void setRewardedVideoServerParams(Dictionary<string, string> parameters)
  {
  }

  [Token(Token = "0x6000064")]
  [Address(RVA = "0x2040084", Offset = "0x2040084", VA = "0x2040084", Slot = "28")]
  public void clearRewardedVideoServerParams()
  {
  }

  [Token(Token = "0x6000065")]
  [Address(RVA = "0x204013C", Offset = "0x204013C", VA = "0x204013C", Slot = "29")]
  public void showISDemandOnlyRewardedVideo(string instanceId)
  {
  }

  [Token(Token = "0x6000066")]
  [Address(RVA = "0x20401FC", Offset = "0x20401FC", VA = "0x20401FC", Slot = "30")]
  public void loadISDemandOnlyRewardedVideo(string instanceId)
  {
  }

  [Token(Token = "0x6000067")]
  [Address(RVA = "0x20402BC", Offset = "0x20402BC", VA = "0x20402BC", Slot = "31")]
  public bool isISDemandOnlyRewardedVideoAvailable(string instanceId) => new bool();

  [Token(Token = "0x6000068")]
  [Address(RVA = "0x2040390", Offset = "0x2040390", VA = "0x2040390", Slot = "32")]
  public void loadInterstitial()
  {
  }

  [Token(Token = "0x6000069")]
  [Address(RVA = "0x2040448", Offset = "0x2040448", VA = "0x2040448", Slot = "33")]
  public void showInterstitial()
  {
  }

  [Token(Token = "0x600006A")]
  [Address(RVA = "0x2040500", Offset = "0x2040500", VA = "0x2040500", Slot = "34")]
  public void showInterstitial(string placementName)
  {
  }

  [Token(Token = "0x600006B")]
  [Address(RVA = "0x20405C0", Offset = "0x20405C0", VA = "0x20405C0", Slot = "35")]
  public bool isInterstitialReady() => new bool();

  [Token(Token = "0x600006C")]
  [Address(RVA = "0x204068C", Offset = "0x204068C", VA = "0x204068C", Slot = "36")]
  public bool isInterstitialPlacementCapped(string placementName) => new bool();

  [Token(Token = "0x600006D")]
  [Address(RVA = "0x2040760", Offset = "0x2040760", VA = "0x2040760", Slot = "37")]
  public void loadISDemandOnlyInterstitial(string instanceId)
  {
  }

  [Token(Token = "0x600006E")]
  [Address(RVA = "0x2040820", Offset = "0x2040820", VA = "0x2040820", Slot = "38")]
  public void showISDemandOnlyInterstitial(string instanceId)
  {
  }

  [Token(Token = "0x600006F")]
  [Address(RVA = "0x20408E0", Offset = "0x20408E0", VA = "0x20408E0", Slot = "39")]
  public bool isISDemandOnlyInterstitialReady(string instanceId) => new bool();

  [Token(Token = "0x6000070")]
  [Address(RVA = "0x20409B4", Offset = "0x20409B4", VA = "0x20409B4", Slot = "40")]
  public void showOfferwall()
  {
  }

  [Token(Token = "0x6000071")]
  [Address(RVA = "0x2040A6C", Offset = "0x2040A6C", VA = "0x2040A6C", Slot = "41")]
  public void showOfferwall(string placementName)
  {
  }

  [Token(Token = "0x6000072")]
  [Address(RVA = "0x2040B2C", Offset = "0x2040B2C", VA = "0x2040B2C", Slot = "43")]
  public void getOfferwallCredits()
  {
  }

  [Token(Token = "0x6000073")]
  [Address(RVA = "0x2040BE4", Offset = "0x2040BE4", VA = "0x2040BE4", Slot = "42")]
  public bool isOfferwallAvailable() => new bool();

  [Token(Token = "0x6000074")]
  [Address(RVA = "0x2040CB0", Offset = "0x2040CB0", VA = "0x2040CB0", Slot = "44")]
  public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position)
  {
  }

  [Token(Token = "0x6000075")]
  [Address(RVA = "0x2040D08", Offset = "0x2040D08", VA = "0x2040D08", Slot = "45")]
  public void loadBanner(
    IronSourceBannerSize size,
    IronSourceBannerPosition position,
    string placementName)
  {
  }

  [Token(Token = "0x6000076")]
  [Address(RVA = "0x2041024", Offset = "0x2041024", VA = "0x2041024", Slot = "46")]
  public void destroyBanner()
  {
  }

  [Token(Token = "0x6000077")]
  [Address(RVA = "0x20410DC", Offset = "0x20410DC", VA = "0x20410DC", Slot = "47")]
  public void displayBanner()
  {
  }

  [Token(Token = "0x6000078")]
  [Address(RVA = "0x2041194", Offset = "0x2041194", VA = "0x2041194", Slot = "48")]
  public void hideBanner()
  {
  }

  [Token(Token = "0x6000079")]
  [Address(RVA = "0x204124C", Offset = "0x204124C", VA = "0x204124C", Slot = "49")]
  public bool isBannerPlacementCapped(string placementName) => new bool();

  [Token(Token = "0x600007A")]
  [Address(RVA = "0x2041320", Offset = "0x2041320", VA = "0x2041320", Slot = "50")]
  public float getMaximalAdaptiveHeight(float width) => new float();

  [Token(Token = "0x600007B")]
  [Address(RVA = "0x2041428", Offset = "0x2041428", VA = "0x2041428", Slot = "51")]
  public float getDeviceScreenWidth() => new float();

  [Token(Token = "0x600007C")]
  [Address(RVA = "0x20414F4", Offset = "0x20414F4", VA = "0x20414F4", Slot = "52")]
  public void setSegment(IronSourceSegment segment)
  {
  }

  [Token(Token = "0x600007D")]
  [Address(RVA = "0x20415D0", Offset = "0x20415D0", VA = "0x20415D0", Slot = "53")]
  public void setConsent(bool consent)
  {
  }

  [Token(Token = "0x600007E")]
  [Address(RVA = "0x20416C4", Offset = "0x20416C4", VA = "0x20416C4", Slot = "54")]
  public void loadConsentViewWithType(string consentViewType)
  {
  }

  [Token(Token = "0x600007F")]
  [Address(RVA = "0x20416C8", Offset = "0x20416C8", VA = "0x20416C8", Slot = "55")]
  public void showConsentViewWithType(string consentViewType)
  {
  }

  [Token(Token = "0x6000080")]
  [Address(RVA = "0x20416CC", Offset = "0x20416CC", VA = "0x20416CC", Slot = "56")]
  public void setAdRevenueData(string dataSource, Dictionary<string, string> impressionData)
  {
  }

  [Token(Token = "0x6000081")]
  [Address(RVA = "0x20417D0", Offset = "0x20417D0", VA = "0x20417D0", Slot = "57")]
  public void launchTestSuite()
  {
  }

  [Token(Token = "0x6000082")]
  [Address(RVA = "0x20418CC", Offset = "0x20418CC", VA = "0x20418CC")]
  static AndroidAgent()
  {
  }
}
