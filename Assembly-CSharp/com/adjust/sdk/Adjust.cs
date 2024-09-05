// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.Adjust
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FE7")]
  public class Adjust : MonoBehaviour
  {
    [Token(Token = "0x40117D9")]
    private const string errorMsgEditor = "[Adjust]: SDK can not be used in Editor.";
    [Token(Token = "0x40117DA")]
    private const string errorMsgStart = "[Adjust]: SDK not started. Start it manually using the 'start' method.";
    [Token(Token = "0x40117DB")]
    private const string errorMsgPlatform = "[Adjust]: SDK can only be used in Android, iOS, Windows Phone 8.1, Windows Store or Universal Windows apps.";
    [Token(Token = "0x40117DC")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public bool startManually;
    [Token(Token = "0x40117DD")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public string appToken;
    [Token(Token = "0x40117DE")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public AdjustEnvironment environment;
    [Token(Token = "0x40117DF")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public AdjustLogLevel logLevel;
    [Token(Token = "0x40117E0")]
    [FieldOffset(Offset = "0x30")]
    [HideInInspector]
    public bool eventBuffering;
    [Token(Token = "0x40117E1")]
    [FieldOffset(Offset = "0x31")]
    [HideInInspector]
    public bool sendInBackground;
    [Token(Token = "0x40117E2")]
    [FieldOffset(Offset = "0x32")]
    [HideInInspector]
    public bool launchDeferredDeeplink;
    [Token(Token = "0x40117E3")]
    [FieldOffset(Offset = "0x33")]
    [HideInInspector]
    public bool needsCost;
    [Token(Token = "0x40117E4")]
    [FieldOffset(Offset = "0x34")]
    [HideInInspector]
    public bool coppaCompliant;
    [Token(Token = "0x40117E5")]
    [FieldOffset(Offset = "0x35")]
    [HideInInspector]
    public bool linkMe;
    [Token(Token = "0x40117E6")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    public string defaultTracker;
    [Token(Token = "0x40117E7")]
    [FieldOffset(Offset = "0x40")]
    [HideInInspector]
    public AdjustUrlStrategy urlStrategy;
    [Token(Token = "0x40117E8")]
    [FieldOffset(Offset = "0x48")]
    [HideInInspector]
    public double startDelay;
    [Token(Token = "0x40117E9")]
    [FieldOffset(Offset = "0x50")]
    [HideInInspector]
    public long secretId;
    [Token(Token = "0x40117EA")]
    [FieldOffset(Offset = "0x58")]
    [HideInInspector]
    public long info1;
    [Token(Token = "0x40117EB")]
    [FieldOffset(Offset = "0x60")]
    [HideInInspector]
    public long info2;
    [Token(Token = "0x40117EC")]
    [FieldOffset(Offset = "0x68")]
    [HideInInspector]
    public long info3;
    [Token(Token = "0x40117ED")]
    [FieldOffset(Offset = "0x70")]
    [HideInInspector]
    public long info4;
    [Token(Token = "0x40117EE")]
    [FieldOffset(Offset = "0x78")]
    [HideInInspector]
    public bool preinstallTracking;
    [Token(Token = "0x40117EF")]
    [FieldOffset(Offset = "0x80")]
    [HideInInspector]
    public string preinstallFilePath;
    [Token(Token = "0x40117F0")]
    [FieldOffset(Offset = "0x88")]
    [HideInInspector]
    public bool playStoreKidsApp;
    [Token(Token = "0x40117F1")]
    [FieldOffset(Offset = "0x89")]
    [HideInInspector]
    public bool adServicesInfoReading;
    [Token(Token = "0x40117F2")]
    [FieldOffset(Offset = "0x8A")]
    [HideInInspector]
    public bool idfaInfoReading;
    [Token(Token = "0x40117F3")]
    [FieldOffset(Offset = "0x8B")]
    [HideInInspector]
    public bool skAdNetworkHandling;

    [Token(Token = "0x6019B6E")]
    [Address(RVA = "0x37991DC", Offset = "0x37991DC", VA = "0x37991DC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6019B6F")]
    [Address(RVA = "0x3799B98", Offset = "0x3799B98", VA = "0x3799B98")]
    private void OnApplicationPause(bool pauseStatus)
    {
    }

    [Token(Token = "0x6019B70")]
    [Address(RVA = "0x3799AF4", Offset = "0x3799AF4", VA = "0x3799AF4")]
    public static void start(AdjustConfig adjustConfig)
    {
    }

    [Token(Token = "0x6019B71")]
    [Address(RVA = "0x3799BFC", Offset = "0x3799BFC", VA = "0x3799BFC")]
    public static void trackEvent(AdjustEvent adjustEvent)
    {
    }

    [Token(Token = "0x6019B72")]
    [Address(RVA = "0x3799CA0", Offset = "0x3799CA0", VA = "0x3799CA0")]
    public static void setEnabled(bool enabled)
    {
    }

    [Token(Token = "0x6019B73")]
    [Address(RVA = "0x3799CF4", Offset = "0x3799CF4", VA = "0x3799CF4")]
    public static bool isEnabled() => new bool();

    [Token(Token = "0x6019B74")]
    [Address(RVA = "0x3799D40", Offset = "0x3799D40", VA = "0x3799D40")]
    public static void setOfflineMode(bool enabled)
    {
    }

    [Token(Token = "0x6019B75")]
    [Address(RVA = "0x3799D94", Offset = "0x3799D94", VA = "0x3799D94")]
    public static void setDeviceToken(string deviceToken)
    {
    }

    [Token(Token = "0x6019B76")]
    [Address(RVA = "0x3799DE8", Offset = "0x3799DE8", VA = "0x3799DE8")]
    public static void gdprForgetMe()
    {
    }

    [Token(Token = "0x6019B77")]
    [Address(RVA = "0x3799E34", Offset = "0x3799E34", VA = "0x3799E34")]
    public static void disableThirdPartySharing()
    {
    }

    [Token(Token = "0x6019B78")]
    [Address(RVA = "0x379940C", Offset = "0x379940C", VA = "0x379940C")]
    public static void appWillOpenUrl(string url)
    {
    }

    [Token(Token = "0x6019B79")]
    [Address(RVA = "0x3799E80", Offset = "0x3799E80", VA = "0x3799E80")]
    public static void sendFirstPackages()
    {
    }

    [Token(Token = "0x6019B7A")]
    [Address(RVA = "0x3799ECC", Offset = "0x3799ECC", VA = "0x3799ECC")]
    public static void addSessionPartnerParameter(string key, string value)
    {
    }

    [Token(Token = "0x6019B7B")]
    [Address(RVA = "0x3799F30", Offset = "0x3799F30", VA = "0x3799F30")]
    public static void addSessionCallbackParameter(string key, string value)
    {
    }

    [Token(Token = "0x6019B7C")]
    [Address(RVA = "0x3799F94", Offset = "0x3799F94", VA = "0x3799F94")]
    public static void removeSessionPartnerParameter(string key)
    {
    }

    [Token(Token = "0x6019B7D")]
    [Address(RVA = "0x3799FE8", Offset = "0x3799FE8", VA = "0x3799FE8")]
    public static void removeSessionCallbackParameter(string key)
    {
    }

    [Token(Token = "0x6019B7E")]
    [Address(RVA = "0x379A03C", Offset = "0x379A03C", VA = "0x379A03C")]
    public static void resetSessionPartnerParameters()
    {
    }

    [Token(Token = "0x6019B7F")]
    [Address(RVA = "0x379A088", Offset = "0x379A088", VA = "0x379A088")]
    public static void resetSessionCallbackParameters()
    {
    }

    [Token(Token = "0x6019B80")]
    [Address(RVA = "0x379A0D4", Offset = "0x379A0D4", VA = "0x379A0D4")]
    public static void trackAdRevenue(string source, string payload)
    {
    }

    [Token(Token = "0x6019B81")]
    [Address(RVA = "0x379A138", Offset = "0x379A138", VA = "0x379A138")]
    public static void trackAdRevenue(AdjustAdRevenue adRevenue)
    {
    }

    [Token(Token = "0x6019B82")]
    [Address(RVA = "0x379A18C", Offset = "0x379A18C", VA = "0x379A18C")]
    public static void trackAppStoreSubscription(AdjustAppStoreSubscription subscription)
    {
    }

    [Token(Token = "0x6019B83")]
    [Address(RVA = "0x379A1F4", Offset = "0x379A1F4", VA = "0x379A1F4")]
    public static void trackPlayStoreSubscription(AdjustPlayStoreSubscription subscription)
    {
    }

    [Token(Token = "0x6019B84")]
    [Address(RVA = "0x379A248", Offset = "0x379A248", VA = "0x379A248")]
    public static void trackThirdPartySharing(AdjustThirdPartySharing thirdPartySharing)
    {
    }

    [Token(Token = "0x6019B85")]
    [Address(RVA = "0x379A29C", Offset = "0x379A29C", VA = "0x379A29C")]
    public static void trackMeasurementConsent(bool measurementConsent)
    {
    }

    [Token(Token = "0x6019B86")]
    [Address(RVA = "0x379A2F0", Offset = "0x379A2F0", VA = "0x379A2F0")]
    public static void requestTrackingAuthorizationWithCompletionHandler(
      Action<int> statusCallback,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019B87")]
    [Address(RVA = "0x379A358", Offset = "0x379A358", VA = "0x379A358")]
    public static void updateConversionValue(int conversionValue)
    {
    }

    [Token(Token = "0x6019B88")]
    [Address(RVA = "0x379A3C0", Offset = "0x379A3C0", VA = "0x379A3C0")]
    public static void updateConversionValue(
      int conversionValue,
      Action<string> completionCallback,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019B89")]
    [Address(RVA = "0x379A428", Offset = "0x379A428", VA = "0x379A428")]
    public static void updateConversionValue(
      int conversionValue,
      string coarseValue,
      bool lockWindow,
      Action<string> completionCallback,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019B8A")]
    [Address(RVA = "0x379A490", Offset = "0x379A490", VA = "0x379A490")]
    public static void checkForNewAttStatus()
    {
    }

    [Token(Token = "0x6019B8B")]
    [Address(RVA = "0x379A4F8", Offset = "0x379A4F8", VA = "0x379A4F8")]
    public static int getAppTrackingAuthorizationStatus() => new int();

    [Token(Token = "0x6019B8C")]
    [Address(RVA = "0x379A568", Offset = "0x379A568", VA = "0x379A568")]
    public static string getAdid() => (string) null;

    [Token(Token = "0x6019B8D")]
    [Address(RVA = "0x379A5C0", Offset = "0x379A5C0", VA = "0x379A5C0")]
    public static AdjustAttribution getAttribution() => (AdjustAttribution) null;

    [Token(Token = "0x6019B8E")]
    [Address(RVA = "0x379A60C", Offset = "0x379A60C", VA = "0x379A60C")]
    public static string getWinAdid() => (string) null;

    [Token(Token = "0x6019B8F")]
    [Address(RVA = "0x379A698", Offset = "0x379A698", VA = "0x379A698")]
    public static string getIdfa() => (string) null;

    [Token(Token = "0x6019B90")]
    [Address(RVA = "0x379A724", Offset = "0x379A724", VA = "0x379A724")]
    public static string getIdfv() => (string) null;

    [Token(Token = "0x6019B91")]
    [Address(RVA = "0x379A7B0", Offset = "0x379A7B0", VA = "0x379A7B0")]
    public static string getSdkVersion() => (string) null;

    [Token(Token = "0x6019B92")]
    [Address(RVA = "0x379A808", Offset = "0x379A808", VA = "0x379A808")]
    [Obsolete("This method is intended for testing purposes only. Do not use it.")]
    public static void setReferrer(string referrer)
    {
    }

    [Token(Token = "0x6019B93")]
    [Address(RVA = "0x379A85C", Offset = "0x379A85C", VA = "0x379A85C")]
    public static void getGoogleAdId(Action<string> onDeviceIdsRead)
    {
    }

    [Token(Token = "0x6019B94")]
    [Address(RVA = "0x379A8B0", Offset = "0x379A8B0", VA = "0x379A8B0")]
    public static string getAmazonAdId() => (string) null;

    [Token(Token = "0x6019B95")]
    [Address(RVA = "0x379A908", Offset = "0x379A908", VA = "0x379A908")]
    public static string getLastDeeplink() => (string) null;

    [Token(Token = "0x6019B96")]
    [Address(RVA = "0x379A994", Offset = "0x379A994", VA = "0x379A994")]
    public static void verifyAppStorePurchase(
      AdjustAppStorePurchase purchase,
      Action<AdjustPurchaseVerificationInfo> verificationInfoDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019B97")]
    [Address(RVA = "0x379A9FC", Offset = "0x379A9FC", VA = "0x379A9FC")]
    public static void verifyPlayStorePurchase(
      AdjustPlayStorePurchase purchase,
      Action<AdjustPurchaseVerificationInfo> verificationInfoDelegate)
    {
    }

    [Token(Token = "0x6019B98")]
    [Address(RVA = "0x379AAB8", Offset = "0x379AAB8", VA = "0x379AAB8")]
    public static void processDeeplink(
      string url,
      Action<string> resolvedLinkDelegate,
      string sceneName = "Adjust")
    {
    }

    [Token(Token = "0x6019B99")]
    [Address(RVA = "0x3799404", Offset = "0x3799404", VA = "0x3799404")]
    private static bool IsEditor() => new bool();

    [Token(Token = "0x6019B9A")]
    [Address(RVA = "0x379AB1C", Offset = "0x379AB1C", VA = "0x379AB1C")]
    public static void SetTestOptions(Dictionary<string, string> testOptions)
    {
    }

    [Token(Token = "0x6019B9B")]
    [Address(RVA = "0x379AB70", Offset = "0x379AB70", VA = "0x379AB70")]
    public Adjust()
    {
    }
  }
}
