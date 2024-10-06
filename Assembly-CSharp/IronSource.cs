// Decompiled with JetBrains decompiler
// Type: IronSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x2000011")]
public class IronSource : IronSourceIAgent
{
  [Token(Token = "0x400002A")]
  [FieldOffset(Offset = "0x10")]
  private IronSourceIAgent _platformAgent;
  [Token(Token = "0x400002B")]
  [FieldOffset(Offset = "0x0")]
  private static IronSource _instance;
  [Token(Token = "0x400002C")]
  [FieldOffset(Offset = "0x8")]
  public static string UNITY_PLUGIN_VERSION;
  [Token(Token = "0x400002D")]
  [FieldOffset(Offset = "0x10")]
  private static bool isUnsupportedPlatform;

  [Token(Token = "0x6000083")]
  [Address(RVA = "0x204192C", Offset = "0x204192C", VA = "0x204192C")]
  private IronSource()
  {
  }

  [Token(Token = "0x17000015")]
  public static IronSource Agent
  {
    [Token(Token = "0x6000084"), Address(RVA = "0x2041D44", Offset = "0x2041D44", VA = "0x2041D44")] get
    {
      return (IronSource) null;
    }
  }

  [Token(Token = "0x6000085")]
  [Address(RVA = "0x2041DEC", Offset = "0x2041DEC", VA = "0x2041DEC")]
  public static string pluginVersion() => (string) null;

  [Token(Token = "0x6000086")]
  [Address(RVA = "0x203F3BC", Offset = "0x203F3BC", VA = "0x203F3BC")]
  public static string unityVersion() => (string) null;

  [Token(Token = "0x6000087")]
  [Address(RVA = "0x2041E44", Offset = "0x2041E44", VA = "0x2041E44")]
  public static void setUnsupportedPlatform()
  {
  }

  [Token(Token = "0x6000088")]
  [Address(RVA = "0x2041EA0", Offset = "0x2041EA0", VA = "0x2041EA0", Slot = "4")]
  public void SetWaterfallConfiguration(
    WaterfallConfiguration waterfallConfiguration,
    AdFormat adFormat)
  {
  }

  [Token(Token = "0x6000089")]
  [Address(RVA = "0x2041F58", Offset = "0x2041F58", VA = "0x2041F58", Slot = "5")]
  public void onApplicationPause(bool pause)
  {
  }

  [Token(Token = "0x600008A")]
  [Address(RVA = "0x2042004", Offset = "0x2042004", VA = "0x2042004", Slot = "6")]
  public string getAdvertiserId() => (string) null;

  [Token(Token = "0x600008B")]
  [Address(RVA = "0x20420A8", Offset = "0x20420A8", VA = "0x20420A8", Slot = "7")]
  public void validateIntegration()
  {
  }

  [Token(Token = "0x600008C")]
  [Address(RVA = "0x204214C", Offset = "0x204214C", VA = "0x204214C", Slot = "8")]
  public void shouldTrackNetworkState(bool track)
  {
  }

  [Token(Token = "0x600008D")]
  [Address(RVA = "0x20421F8", Offset = "0x20421F8", VA = "0x20421F8", Slot = "9")]
  public bool setDynamicUserId(string dynamicUserId) => new bool();

  [Token(Token = "0x600008E")]
  [Address(RVA = "0x20422A4", Offset = "0x20422A4", VA = "0x20422A4", Slot = "10")]
  public void setAdaptersDebug(bool enabled)
  {
  }

  [Token(Token = "0x600008F")]
  [Address(RVA = "0x2042350", Offset = "0x2042350", VA = "0x2042350", Slot = "11")]
  public void setMetaData(string key, string value)
  {
  }

  [Token(Token = "0x6000090")]
  [Address(RVA = "0x204240C", Offset = "0x204240C", VA = "0x204240C", Slot = "12")]
  public void setMetaData(string key, params string[] values)
  {
  }

  [Token(Token = "0x6000091")]
  [Address(RVA = "0x20424C8", Offset = "0x20424C8", VA = "0x20424C8", Slot = "13")]
  public int? getConversionValue() => new int?();

  [Token(Token = "0x6000092")]
  [Address(RVA = "0x204256C", Offset = "0x204256C", VA = "0x204256C", Slot = "14")]
  public void setManualLoadRewardedVideo(bool isOn)
  {
  }

  [Token(Token = "0x6000093")]
  [Address(RVA = "0x2042618", Offset = "0x2042618", VA = "0x2042618", Slot = "15")]
  public void setNetworkData(string networkKey, string networkData)
  {
  }

  [Token(Token = "0x6000094")]
  [Address(RVA = "0x20426D4", Offset = "0x20426D4", VA = "0x20426D4", Slot = "16")]
  public void SetPauseGame(bool pause)
  {
  }

  [Token(Token = "0x6000095")]
  [Address(RVA = "0x2042780", Offset = "0x2042780", VA = "0x2042780", Slot = "17")]
  public void setUserId(string userId)
  {
  }

  [Token(Token = "0x6000096")]
  [Address(RVA = "0x204282C", Offset = "0x204282C", VA = "0x204282C", Slot = "18")]
  public void init(string appKey)
  {
  }

  [Token(Token = "0x6000097")]
  [Address(RVA = "0x20428D8", Offset = "0x20428D8", VA = "0x20428D8", Slot = "19")]
  public void init(string appKey, params string[] adUnits)
  {
  }

  [Token(Token = "0x6000098")]
  [Address(RVA = "0x2042994", Offset = "0x2042994", VA = "0x2042994", Slot = "20")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public void initISDemandOnly(string appKey, params string[] adUnits)
  {
  }

  [Token(Token = "0x6000099")]
  [Address(RVA = "0x2042A50", Offset = "0x2042A50", VA = "0x2042A50", Slot = "21")]
  public void loadRewardedVideo()
  {
  }

  [Token(Token = "0x600009A")]
  [Address(RVA = "0x2042AF4", Offset = "0x2042AF4", VA = "0x2042AF4", Slot = "22")]
  public void showRewardedVideo()
  {
  }

  [Token(Token = "0x600009B")]
  [Address(RVA = "0x2042B98", Offset = "0x2042B98", VA = "0x2042B98", Slot = "23")]
  public void showRewardedVideo(string placementName)
  {
  }

  [Token(Token = "0x600009C")]
  [Address(RVA = "0x2042C44", Offset = "0x2042C44", VA = "0x2042C44", Slot = "26")]
  public IronSourcePlacement getPlacementInfo(string placementName) => (IronSourcePlacement) null;

  [Token(Token = "0x600009D")]
  [Address(RVA = "0x2042CF0", Offset = "0x2042CF0", VA = "0x2042CF0", Slot = "24")]
  public bool isRewardedVideoAvailable() => new bool();

  [Token(Token = "0x600009E")]
  [Address(RVA = "0x2042D94", Offset = "0x2042D94", VA = "0x2042D94", Slot = "25")]
  public bool isRewardedVideoPlacementCapped(string placementName) => new bool();

  [Token(Token = "0x600009F")]
  [Address(RVA = "0x2042E40", Offset = "0x2042E40", VA = "0x2042E40", Slot = "27")]
  public void setRewardedVideoServerParams(Dictionary<string, string> parameters)
  {
  }

  [Token(Token = "0x60000A0")]
  [Address(RVA = "0x2042EEC", Offset = "0x2042EEC", VA = "0x2042EEC", Slot = "28")]
  public void clearRewardedVideoServerParams()
  {
  }

  [Token(Token = "0x60000A1")]
  [Address(RVA = "0x2042F90", Offset = "0x2042F90", VA = "0x2042F90", Slot = "29")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public void showISDemandOnlyRewardedVideo(string instanceId)
  {
  }

  [Token(Token = "0x60000A2")]
  [Address(RVA = "0x204303C", Offset = "0x204303C", VA = "0x204303C", Slot = "30")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public void loadISDemandOnlyRewardedVideo(string instanceId)
  {
  }

  [Token(Token = "0x60000A3")]
  [Address(RVA = "0x20430E8", Offset = "0x20430E8", VA = "0x20430E8", Slot = "31")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public bool isISDemandOnlyRewardedVideoAvailable(string instanceId) => new bool();

  [Token(Token = "0x60000A4")]
  [Address(RVA = "0x2043194", Offset = "0x2043194", VA = "0x2043194", Slot = "32")]
  public void loadInterstitial()
  {
  }

  [Token(Token = "0x60000A5")]
  [Address(RVA = "0x2043238", Offset = "0x2043238", VA = "0x2043238", Slot = "33")]
  public void showInterstitial()
  {
  }

  [Token(Token = "0x60000A6")]
  [Address(RVA = "0x20432DC", Offset = "0x20432DC", VA = "0x20432DC", Slot = "34")]
  public void showInterstitial(string placementName)
  {
  }

  [Token(Token = "0x60000A7")]
  [Address(RVA = "0x2043388", Offset = "0x2043388", VA = "0x2043388", Slot = "35")]
  public bool isInterstitialReady() => new bool();

  [Token(Token = "0x60000A8")]
  [Address(RVA = "0x204342C", Offset = "0x204342C", VA = "0x204342C", Slot = "36")]
  public bool isInterstitialPlacementCapped(string placementName) => new bool();

  [Token(Token = "0x60000A9")]
  [Address(RVA = "0x20434D8", Offset = "0x20434D8", VA = "0x20434D8", Slot = "37")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public void loadISDemandOnlyInterstitial(string instanceId)
  {
  }

  [Token(Token = "0x60000AA")]
  [Address(RVA = "0x2043584", Offset = "0x2043584", VA = "0x2043584", Slot = "38")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public void showISDemandOnlyInterstitial(string instanceId)
  {
  }

  [Token(Token = "0x60000AB")]
  [Address(RVA = "0x2043630", Offset = "0x2043630", VA = "0x2043630", Slot = "39")]
  [Obsolete("This API has been deprecated as of SDK 7.3.0.1", false)]
  public bool isISDemandOnlyInterstitialReady(string instanceId) => new bool();

  [Token(Token = "0x60000AC")]
  [Address(RVA = "0x20436DC", Offset = "0x20436DC", VA = "0x20436DC", Slot = "40")]
  [Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
  public void showOfferwall()
  {
  }

  [Token(Token = "0x60000AD")]
  [Address(RVA = "0x2043780", Offset = "0x2043780", VA = "0x2043780", Slot = "41")]
  [Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
  public void showOfferwall(string placementName)
  {
  }

  [Token(Token = "0x60000AE")]
  [Address(RVA = "0x204382C", Offset = "0x204382C", VA = "0x204382C", Slot = "43")]
  [Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
  public void getOfferwallCredits()
  {
  }

  [Token(Token = "0x60000AF")]
  [Address(RVA = "0x20438D0", Offset = "0x20438D0", VA = "0x20438D0", Slot = "42")]
  [Obsolete("This API call is for the ironSource Offerwall, which will soon be deprecated. Please migrate to the Tapjoy Offerwall using the 'Offerwall migration checklist'.", false)]
  public bool isOfferwallAvailable() => new bool();

  [Token(Token = "0x60000B0")]
  [Address(RVA = "0x2043974", Offset = "0x2043974", VA = "0x2043974", Slot = "44")]
  public void loadBanner(IronSourceBannerSize size, IronSourceBannerPosition position)
  {
  }

  [Token(Token = "0x60000B1")]
  [Address(RVA = "0x2043A30", Offset = "0x2043A30", VA = "0x2043A30", Slot = "45")]
  public void loadBanner(
    IronSourceBannerSize size,
    IronSourceBannerPosition position,
    string placementName)
  {
  }

  [Token(Token = "0x60000B2")]
  [Address(RVA = "0x2043AF4", Offset = "0x2043AF4", VA = "0x2043AF4", Slot = "46")]
  public void destroyBanner()
  {
  }

  [Token(Token = "0x60000B3")]
  [Address(RVA = "0x2043B98", Offset = "0x2043B98", VA = "0x2043B98", Slot = "47")]
  public void displayBanner()
  {
  }

  [Token(Token = "0x60000B4")]
  [Address(RVA = "0x2043C3C", Offset = "0x2043C3C", VA = "0x2043C3C", Slot = "48")]
  public void hideBanner()
  {
  }

  [Token(Token = "0x60000B5")]
  [Address(RVA = "0x2043CE0", Offset = "0x2043CE0", VA = "0x2043CE0", Slot = "49")]
  public bool isBannerPlacementCapped(string placementName) => new bool();

  [Token(Token = "0x60000B6")]
  [Address(RVA = "0x2043D8C", Offset = "0x2043D8C", VA = "0x2043D8C", Slot = "50")]
  public float getMaximalAdaptiveHeight(float width) => new float();

  [Token(Token = "0x60000B7")]
  [Address(RVA = "0x2043E40", Offset = "0x2043E40", VA = "0x2043E40", Slot = "51")]
  public float getDeviceScreenWidth() => new float();

  [Token(Token = "0x60000B8")]
  [Address(RVA = "0x2043EE4", Offset = "0x2043EE4", VA = "0x2043EE4", Slot = "52")]
  public void setSegment(IronSourceSegment segment)
  {
  }

  [Token(Token = "0x60000B9")]
  [Address(RVA = "0x2043F90", Offset = "0x2043F90", VA = "0x2043F90", Slot = "53")]
  public void setConsent(bool consent)
  {
  }

  [Token(Token = "0x60000BA")]
  [Address(RVA = "0x204403C", Offset = "0x204403C", VA = "0x204403C", Slot = "54")]
  public void loadConsentViewWithType(string consentViewType)
  {
  }

  [Token(Token = "0x60000BB")]
  [Address(RVA = "0x20440E8", Offset = "0x20440E8", VA = "0x20440E8", Slot = "55")]
  public void showConsentViewWithType(string consentViewType)
  {
  }

  [Token(Token = "0x60000BC")]
  [Address(RVA = "0x2044194", Offset = "0x2044194", VA = "0x2044194", Slot = "56")]
  public void setAdRevenueData(string dataSource, Dictionary<string, string> impressionData)
  {
  }

  [Token(Token = "0x60000BD")]
  [Address(RVA = "0x2044250", Offset = "0x2044250", VA = "0x2044250", Slot = "57")]
  public void launchTestSuite()
  {
  }

  [Token(Token = "0x60000BE")]
  [Address(RVA = "0x20442F4", Offset = "0x20442F4", VA = "0x20442F4")]
  static IronSource()
  {
  }
}
