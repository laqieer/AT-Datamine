// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FEC")]
  public class AdjustConfig
  {
    [Token(Token = "0x4011815")]
    public const string AdjustUrlStrategyChina = "china";
    [Token(Token = "0x4011816")]
    public const string AdjustUrlStrategyIndia = "india";
    [Token(Token = "0x4011817")]
    public const string AdjustUrlStrategyCn = "cn";
    [Token(Token = "0x4011818")]
    public const string AdjustUrlStrategyCnOnly = "cn-only";
    [Token(Token = "0x4011819")]
    public const string AdjustDataResidencyEU = "data-residency-eu";
    [Token(Token = "0x401181A")]
    public const string AdjustDataResidencyTR = "data-residency-tr";
    [Token(Token = "0x401181B")]
    public const string AdjustDataResidencyUS = "data-residency-us";
    [Token(Token = "0x401181C")]
    public const string AdjustAdRevenueSourceAppLovinMAX = "applovin_max_sdk";
    [Token(Token = "0x401181D")]
    public const string AdjustAdRevenueSourceMopub = "mopub";
    [Token(Token = "0x401181E")]
    public const string AdjustAdRevenueSourceAdMob = "admob_sdk";
    [Token(Token = "0x401181F")]
    public const string AdjustAdRevenueSourceIronSource = "ironsource_sdk";
    [Token(Token = "0x4011820")]
    public const string AdjustAdRevenueSourceAdmost = "admost_sdk";
    [Token(Token = "0x4011821")]
    public const string AdjustAdRevenueSourceUnity = "unity_sdk";
    [Token(Token = "0x4011822")]
    public const string AdjustAdRevenueSourceHeliumChartboost = "helium_chartboost_sdk";
    [Token(Token = "0x4011823")]
    public const string AdjustAdRevenueSourcePublisher = "publisher_sdk";
    [Token(Token = "0x4011824")]
    public const string AdjustAdRevenueSourceTopOn = "topon_sdk";
    [Token(Token = "0x4011825")]
    public const string AdjustAdRevenueSourceAdx = "adx_sdk";
    [Token(Token = "0x4011826")]
    public const string AdjustAdRevenueTradPlus = "tradplus_sdk";
    [Token(Token = "0x4011827")]
    [FieldOffset(Offset = "0x10")]
    internal string appToken;
    [Token(Token = "0x4011828")]
    [FieldOffset(Offset = "0x18")]
    internal string sceneName;
    [Token(Token = "0x4011829")]
    [FieldOffset(Offset = "0x20")]
    internal string userAgent;
    [Token(Token = "0x401182A")]
    [FieldOffset(Offset = "0x28")]
    internal string defaultTracker;
    [Token(Token = "0x401182B")]
    [FieldOffset(Offset = "0x30")]
    internal string externalDeviceId;
    [Token(Token = "0x401182C")]
    [FieldOffset(Offset = "0x38")]
    internal string urlStrategy;
    [Token(Token = "0x401182D")]
    [FieldOffset(Offset = "0x40")]
    internal long? info1;
    [Token(Token = "0x401182E")]
    [FieldOffset(Offset = "0x50")]
    internal long? info2;
    [Token(Token = "0x401182F")]
    [FieldOffset(Offset = "0x60")]
    internal long? info3;
    [Token(Token = "0x4011830")]
    [FieldOffset(Offset = "0x70")]
    internal long? info4;
    [Token(Token = "0x4011831")]
    [FieldOffset(Offset = "0x80")]
    internal long? secretId;
    [Token(Token = "0x4011832")]
    [FieldOffset(Offset = "0x90")]
    internal double? delayStart;
    [Token(Token = "0x4011833")]
    [FieldOffset(Offset = "0xA0")]
    internal bool? isDeviceKnown;
    [Token(Token = "0x4011834")]
    [FieldOffset(Offset = "0xA2")]
    internal bool? sendInBackground;
    [Token(Token = "0x4011835")]
    [FieldOffset(Offset = "0xA4")]
    internal bool? eventBufferingEnabled;
    [Token(Token = "0x4011836")]
    [FieldOffset(Offset = "0xA6")]
    internal bool? coppaCompliantEnabled;
    [Token(Token = "0x4011837")]
    [FieldOffset(Offset = "0xA8")]
    internal bool? playStoreKidsAppEnabled;
    [Token(Token = "0x4011838")]
    [FieldOffset(Offset = "0xAA")]
    internal bool? allowSuppressLogLevel;
    [Token(Token = "0x4011839")]
    [FieldOffset(Offset = "0xAC")]
    internal bool? needsCost;
    [Token(Token = "0x401183A")]
    [FieldOffset(Offset = "0xAE")]
    internal bool? readDeviceInfoOnceEnabled;
    [Token(Token = "0x401183B")]
    [FieldOffset(Offset = "0xB0")]
    internal bool launchDeferredDeeplink;
    [Token(Token = "0x401183C")]
    [FieldOffset(Offset = "0xB4")]
    internal AdjustLogLevel? logLevel;
    [Token(Token = "0x401183D")]
    [FieldOffset(Offset = "0xBC")]
    internal AdjustEnvironment environment;
    [Token(Token = "0x401183E")]
    [FieldOffset(Offset = "0xC0")]
    internal Action<string> deferredDeeplinkDelegate;
    [Token(Token = "0x401183F")]
    [FieldOffset(Offset = "0xC8")]
    internal Action<AdjustEventSuccess> eventSuccessDelegate;
    [Token(Token = "0x4011840")]
    [FieldOffset(Offset = "0xD0")]
    internal Action<AdjustEventFailure> eventFailureDelegate;
    [Token(Token = "0x4011841")]
    [FieldOffset(Offset = "0xD8")]
    internal Action<AdjustSessionSuccess> sessionSuccessDelegate;
    [Token(Token = "0x4011842")]
    [FieldOffset(Offset = "0xE0")]
    internal Action<AdjustSessionFailure> sessionFailureDelegate;
    [Token(Token = "0x4011843")]
    [FieldOffset(Offset = "0xE8")]
    internal Action<AdjustAttribution> attributionChangedDelegate;
    [Token(Token = "0x4011844")]
    [FieldOffset(Offset = "0xF0")]
    internal Action<int> conversionValueUpdatedDelegate;
    [Token(Token = "0x4011845")]
    [FieldOffset(Offset = "0xF8")]
    internal Action<int, string, bool> skad4ConversionValueUpdatedDelegate;
    [Token(Token = "0x4011846")]
    [FieldOffset(Offset = "0x100")]
    internal string processName;
    [Token(Token = "0x4011847")]
    [FieldOffset(Offset = "0x108")]
    internal bool? readImei;
    [Token(Token = "0x4011848")]
    [FieldOffset(Offset = "0x10A")]
    internal bool? preinstallTrackingEnabled;
    [Token(Token = "0x4011849")]
    [FieldOffset(Offset = "0x110")]
    internal string preinstallFilePath;
    [Token(Token = "0x401184A")]
    [FieldOffset(Offset = "0x118")]
    internal bool? finalAndroidAttributionEnabled;
    [Token(Token = "0x401184B")]
    [FieldOffset(Offset = "0x120")]
    internal string fbAppId;
    [Token(Token = "0x401184C")]
    [FieldOffset(Offset = "0x128")]
    internal bool? allowAdServicesInfoReading;
    [Token(Token = "0x401184D")]
    [FieldOffset(Offset = "0x12A")]
    internal bool? allowIdfaReading;
    [Token(Token = "0x401184E")]
    [FieldOffset(Offset = "0x12C")]
    internal bool? skAdNetworkHandling;
    [Token(Token = "0x401184F")]
    [FieldOffset(Offset = "0x12E")]
    internal bool? linkMeEnabled;
    [Token(Token = "0x4011850")]
    [FieldOffset(Offset = "0x130")]
    internal int? attConsentWaitingInterval;
    [Token(Token = "0x4011851")]
    [FieldOffset(Offset = "0x138")]
    internal Action<string> logDelegate;

    [Token(Token = "0x6019BC5")]
    [Address(RVA = "0x379B92C", Offset = "0x379B92C", VA = "0x379B92C")]
    public AdjustConfig(string appToken, AdjustEnvironment environment)
    {
    }

    [Token(Token = "0x6019BC6")]
    [Address(RVA = "0x3799460", Offset = "0x3799460", VA = "0x3799460")]
    public AdjustConfig(string appToken, AdjustEnvironment environment, bool allowSuppressLogLevel)
    {
    }

    [Token(Token = "0x6019BC7")]
    [Address(RVA = "0x3799510", Offset = "0x3799510", VA = "0x3799510")]
    public void setLogLevel(AdjustLogLevel logLevel)
    {
    }

    [Token(Token = "0x6019BC8")]
    [Address(RVA = "0x379B998", Offset = "0x379B998", VA = "0x379B998")]
    public void setDefaultTracker(string defaultTracker)
    {
    }

    [Token(Token = "0x6019BC9")]
    [Address(RVA = "0x379B9A0", Offset = "0x379B9A0", VA = "0x379B9A0")]
    public void setExternalDeviceId(string externalDeviceId)
    {
    }

    [Token(Token = "0x6019BCA")]
    [Address(RVA = "0x379B9A8", Offset = "0x379B9A8", VA = "0x379B9A8")]
    public void setLaunchDeferredDeeplink(bool launchDeferredDeeplink)
    {
    }

    [Token(Token = "0x6019BCB")]
    [Address(RVA = "0x3799578", Offset = "0x3799578", VA = "0x3799578")]
    public void setSendInBackground(bool sendInBackground)
    {
    }

    [Token(Token = "0x6019BCC")]
    [Address(RVA = "0x37995E0", Offset = "0x37995E0", VA = "0x37995E0")]
    public void setEventBufferingEnabled(bool eventBufferingEnabled)
    {
    }

    [Token(Token = "0x6019BCD")]
    [Address(RVA = "0x3799958", Offset = "0x3799958", VA = "0x3799958")]
    public void setCoppaCompliantEnabled(bool coppaCompliantEnabled)
    {
    }

    [Token(Token = "0x6019BCE")]
    [Address(RVA = "0x37997B8", Offset = "0x37997B8", VA = "0x37997B8")]
    public void setNeedsCost(bool needsCost)
    {
    }

    [Token(Token = "0x6019BCF")]
    [Address(RVA = "0x3799748", Offset = "0x3799748", VA = "0x3799748")]
    public void setDelayStart(double delayStart)
    {
    }

    [Token(Token = "0x6019BD0")]
    [Address(RVA = "0x379B9B4", Offset = "0x379B9B4", VA = "0x379B9B4")]
    public void setUserAgent(string userAgent)
    {
    }

    [Token(Token = "0x6019BD1")]
    [Address(RVA = "0x379B9BC", Offset = "0x379B9BC", VA = "0x379B9BC")]
    public void setIsDeviceKnown(bool isDeviceKnown)
    {
    }

    [Token(Token = "0x6019BD2")]
    [Address(RVA = "0x379BA24", Offset = "0x379BA24", VA = "0x379BA24")]
    public void setUrlStrategy(string urlStrategy)
    {
    }

    [Token(Token = "0x6019BD3")]
    [Address(RVA = "0x3799648", Offset = "0x3799648", VA = "0x3799648")]
    public void setAppSecret(long secretId, long info1, long info2, long info3, long info4)
    {
    }

    [Token(Token = "0x6019BD4")]
    [Address(RVA = "0x379BA2C", Offset = "0x379BA2C", VA = "0x379BA2C")]
    public void setDeferredDeeplinkDelegate(
      Action<string> deferredDeeplinkDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019BD5")]
    [Address(RVA = "0x379BA38", Offset = "0x379BA38", VA = "0x379BA38")]
    public Action<string> getDeferredDeeplinkDelegate() => (Action<string>) null;

    [Token(Token = "0x6019BD6")]
    [Address(RVA = "0x379BA40", Offset = "0x379BA40", VA = "0x379BA40")]
    public void setAttributionChangedDelegate(
      Action<AdjustAttribution> attributionChangedDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019BD7")]
    [Address(RVA = "0x379BA4C", Offset = "0x379BA4C", VA = "0x379BA4C")]
    public Action<AdjustAttribution> getAttributionChangedDelegate()
    {
      return (Action<AdjustAttribution>) null;
    }

    [Token(Token = "0x6019BD8")]
    [Address(RVA = "0x379BA54", Offset = "0x379BA54", VA = "0x379BA54")]
    public void setEventSuccessDelegate(
      Action<AdjustEventSuccess> eventSuccessDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019BD9")]
    [Address(RVA = "0x379BA60", Offset = "0x379BA60", VA = "0x379BA60")]
    public Action<AdjustEventSuccess> getEventSuccessDelegate()
    {
      return (Action<AdjustEventSuccess>) null;
    }

    [Token(Token = "0x6019BDA")]
    [Address(RVA = "0x379BA68", Offset = "0x379BA68", VA = "0x379BA68")]
    public void setEventFailureDelegate(
      Action<AdjustEventFailure> eventFailureDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019BDB")]
    [Address(RVA = "0x379BA74", Offset = "0x379BA74", VA = "0x379BA74")]
    public Action<AdjustEventFailure> getEventFailureDelegate()
    {
      return (Action<AdjustEventFailure>) null;
    }

    [Token(Token = "0x6019BDC")]
    [Address(RVA = "0x379BA7C", Offset = "0x379BA7C", VA = "0x379BA7C")]
    public void setSessionSuccessDelegate(
      Action<AdjustSessionSuccess> sessionSuccessDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019BDD")]
    [Address(RVA = "0x379BA88", Offset = "0x379BA88", VA = "0x379BA88")]
    public Action<AdjustSessionSuccess> getSessionSuccessDelegate()
    {
      return (Action<AdjustSessionSuccess>) null;
    }

    [Token(Token = "0x6019BDE")]
    [Address(RVA = "0x379BA90", Offset = "0x379BA90", VA = "0x379BA90")]
    public void setSessionFailureDelegate(
      Action<AdjustSessionFailure> sessionFailureDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019BDF")]
    [Address(RVA = "0x379BA9C", Offset = "0x379BA9C", VA = "0x379BA9C")]
    public Action<AdjustSessionFailure> getSessionFailureDelegate()
    {
      return (Action<AdjustSessionFailure>) null;
    }

    [Token(Token = "0x6019BE0")]
    [Address(RVA = "0x379BAA4", Offset = "0x379BAA4", VA = "0x379BAA4")]
    [Obsolete("This is an obsolete method. Apple Search Ads attribution with usage of iAd.framework has been sunset by Apple as of February 7th 2023.")]
    public void setAllowiAdInfoReading(bool allowiAdInfoReading)
    {
    }

    [Token(Token = "0x6019BE1")]
    [Address(RVA = "0x3799888", Offset = "0x3799888", VA = "0x3799888")]
    public void setAllowAdServicesInfoReading(bool allowAdServicesInfoReading)
    {
    }

    [Token(Token = "0x6019BE2")]
    [Address(RVA = "0x37998F0", Offset = "0x37998F0", VA = "0x37998F0")]
    public void setAllowIdfaReading(bool allowIdfaReading)
    {
    }

    [Token(Token = "0x6019BE3")]
    [Address(RVA = "0x3799A90", Offset = "0x3799A90", VA = "0x3799A90")]
    public void deactivateSKAdNetworkHandling()
    {
    }

    [Token(Token = "0x6019BE4")]
    [Address(RVA = "0x3799A28", Offset = "0x3799A28", VA = "0x3799A28")]
    public void setLinkMeEnabled(bool linkMeEnabled)
    {
    }

    [Token(Token = "0x6019BE5")]
    [Address(RVA = "0x379BAA8", Offset = "0x379BAA8", VA = "0x379BAA8")]
    public void setConversionValueUpdatedDelegate(
      Action<int> conversionValueUpdatedDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019BE6")]
    [Address(RVA = "0x379BAB4", Offset = "0x379BAB4", VA = "0x379BAB4")]
    public Action<int> getConversionValueUpdatedDelegate() => (Action<int>) null;

    [Token(Token = "0x6019BE7")]
    [Address(RVA = "0x379BABC", Offset = "0x379BABC", VA = "0x379BABC")]
    public void setSkad4ConversionValueUpdatedDelegate(
      Action<int, string, bool> skad4ConversionValueUpdatedDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019BE8")]
    [Address(RVA = "0x379BAC8", Offset = "0x379BAC8", VA = "0x379BAC8")]
    public Action<int, string, bool> getSkad4ConversionValueUpdatedDelegate()
    {
      return (Action<int, string, bool>) null;
    }

    [Token(Token = "0x6019BE9")]
    [Address(RVA = "0x379BAD0", Offset = "0x379BAD0", VA = "0x379BAD0")]
    public void setAttConsentWaitingInterval(int numberOfSeconds)
    {
    }

    [Token(Token = "0x6019BEA")]
    [Address(RVA = "0x379BB38", Offset = "0x379BB38", VA = "0x379BB38")]
    public void setProcessName(string processName)
    {
    }

    [Token(Token = "0x6019BEB")]
    [Address(RVA = "0x379BB40", Offset = "0x379BB40", VA = "0x379BB40")]
    [Obsolete("This is an obsolete method.")]
    public void setReadMobileEquipmentIdentity(bool readMobileEquipmentIdentity)
    {
    }

    [Token(Token = "0x6019BEC")]
    [Address(RVA = "0x3799820", Offset = "0x3799820", VA = "0x3799820")]
    public void setPreinstallTrackingEnabled(bool preinstallTrackingEnabled)
    {
    }

    [Token(Token = "0x6019BED")]
    [Address(RVA = "0x379BB44", Offset = "0x379BB44", VA = "0x379BB44")]
    public void setPreinstallFilePath(string preinstallFilePath)
    {
    }

    [Token(Token = "0x6019BEE")]
    [Address(RVA = "0x37999C0", Offset = "0x37999C0", VA = "0x37999C0")]
    public void setPlayStoreKidsAppEnabled(bool playStoreKidsAppEnabled)
    {
    }

    [Token(Token = "0x6019BEF")]
    [Address(RVA = "0x379BB4C", Offset = "0x379BB4C", VA = "0x379BB4C")]
    public void setFinalAndroidAttributionEnabled(bool finalAndroidAttributionEnabled)
    {
    }

    [Token(Token = "0x6019BF0")]
    [Address(RVA = "0x379BBB4", Offset = "0x379BBB4", VA = "0x379BBB4")]
    public void setFbAppId(string fbAppId)
    {
    }

    [Token(Token = "0x6019BF1")]
    [Address(RVA = "0x379BBBC", Offset = "0x379BBBC", VA = "0x379BBBC")]
    public void setReadDeviceInfoOnceEnabled(bool readDeviceInfoOnceEnabled)
    {
    }

    [Token(Token = "0x6019BF2")]
    [Address(RVA = "0x379BC24", Offset = "0x379BC24", VA = "0x379BC24")]
    public void setLogDelegate(Action<string> logDelegate)
    {
    }
  }
}
