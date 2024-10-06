// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustAndroid
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
  [Token(Token = "0x2003FDD")]
  public class AdjustAndroid
  {
    [Token(Token = "0x40117C4")]
    private const string sdkPrefix = "unity4.38.0";
    [Token(Token = "0x40117C5")]
    [FieldOffset(Offset = "0x0")]
    private static bool launchDeferredDeeplink;
    [Token(Token = "0x40117C6")]
    [FieldOffset(Offset = "0x8")]
    private static AndroidJavaClass ajcAdjust;
    [Token(Token = "0x40117C7")]
    [FieldOffset(Offset = "0x10")]
    private static AndroidJavaObject ajoCurrentActivity;
    [Token(Token = "0x40117C8")]
    [FieldOffset(Offset = "0x18")]
    private static AdjustAndroid.DeferredDeeplinkListener onDeferredDeeplinkListener;
    [Token(Token = "0x40117C9")]
    [FieldOffset(Offset = "0x20")]
    private static AdjustAndroid.AttributionChangeListener onAttributionChangedListener;
    [Token(Token = "0x40117CA")]
    [FieldOffset(Offset = "0x28")]
    private static AdjustAndroid.EventTrackingFailedListener onEventTrackingFailedListener;
    [Token(Token = "0x40117CB")]
    [FieldOffset(Offset = "0x30")]
    private static AdjustAndroid.EventTrackingSucceededListener onEventTrackingSucceededListener;
    [Token(Token = "0x40117CC")]
    [FieldOffset(Offset = "0x38")]
    private static AdjustAndroid.SessionTrackingFailedListener onSessionTrackingFailedListener;
    [Token(Token = "0x40117CD")]
    [FieldOffset(Offset = "0x40")]
    private static AdjustAndroid.SessionTrackingSucceededListener onSessionTrackingSucceededListener;
    [Token(Token = "0x40117CE")]
    [FieldOffset(Offset = "0x48")]
    private static AdjustAndroid.VerificationInfoListener onVerificationInfoListener;
    [Token(Token = "0x40117CF")]
    [FieldOffset(Offset = "0x50")]
    private static AdjustAndroid.DeeplinkResolutionListener onDeeplinkResolvedListener;

    [Token(Token = "0x6019B38")]
    [Address(RVA = "0x37912F8", Offset = "0x37912F8", VA = "0x37912F8")]
    public static void Start(AdjustConfig adjustConfig)
    {
    }

    [Token(Token = "0x6019B39")]
    [Address(RVA = "0x3792E88", Offset = "0x3792E88", VA = "0x3792E88")]
    public static void TrackEvent(AdjustEvent adjustEvent)
    {
    }

    [Token(Token = "0x6019B3A")]
    [Address(RVA = "0x3793498", Offset = "0x3793498", VA = "0x3793498")]
    public static bool IsEnabled() => new bool();

    [Token(Token = "0x6019B3B")]
    [Address(RVA = "0x3793584", Offset = "0x3793584", VA = "0x3793584")]
    public static void SetEnabled(bool enabled)
    {
    }

    [Token(Token = "0x6019B3C")]
    [Address(RVA = "0x379369C", Offset = "0x379369C", VA = "0x379369C")]
    public static void SetOfflineMode(bool enabled)
    {
    }

    [Token(Token = "0x6019B3D")]
    [Address(RVA = "0x37937B4", Offset = "0x37937B4", VA = "0x37937B4")]
    public static void SendFirstPackages()
    {
    }

    [Token(Token = "0x6019B3E")]
    [Address(RVA = "0x379388C", Offset = "0x379388C", VA = "0x379388C")]
    public static void SetDeviceToken(string deviceToken)
    {
    }

    [Token(Token = "0x6019B3F")]
    [Address(RVA = "0x37939AC", Offset = "0x37939AC", VA = "0x37939AC")]
    public static string GetAdid() => (string) null;

    [Token(Token = "0x6019B40")]
    [Address(RVA = "0x3793A98", Offset = "0x3793A98", VA = "0x3793A98")]
    public static void GdprForgetMe()
    {
    }

    [Token(Token = "0x6019B41")]
    [Address(RVA = "0x3793B84", Offset = "0x3793B84", VA = "0x3793B84")]
    public static void DisableThirdPartySharing()
    {
    }

    [Token(Token = "0x6019B42")]
    [Address(RVA = "0x3793C70", Offset = "0x3793C70", VA = "0x3793C70")]
    public static AdjustAttribution GetAttribution() => (AdjustAttribution) null;

    [Token(Token = "0x6019B43")]
    [Address(RVA = "0x3794534", Offset = "0x3794534", VA = "0x3794534")]
    public static void AddSessionPartnerParameter(string key, string value)
    {
    }

    [Token(Token = "0x6019B44")]
    [Address(RVA = "0x37946C8", Offset = "0x37946C8", VA = "0x37946C8")]
    public static void AddSessionCallbackParameter(string key, string value)
    {
    }

    [Token(Token = "0x6019B45")]
    [Address(RVA = "0x379485C", Offset = "0x379485C", VA = "0x379485C")]
    public static void RemoveSessionPartnerParameter(string key)
    {
    }

    [Token(Token = "0x6019B46")]
    [Address(RVA = "0x37949C4", Offset = "0x37949C4", VA = "0x37949C4")]
    public static void RemoveSessionCallbackParameter(string key)
    {
    }

    [Token(Token = "0x6019B47")]
    [Address(RVA = "0x3794B2C", Offset = "0x3794B2C", VA = "0x3794B2C")]
    public static void ResetSessionPartnerParameters()
    {
    }

    [Token(Token = "0x6019B48")]
    [Address(RVA = "0x3794C88", Offset = "0x3794C88", VA = "0x3794C88")]
    public static void ResetSessionCallbackParameters()
    {
    }

    [Token(Token = "0x6019B49")]
    [Address(RVA = "0x3794DE4", Offset = "0x3794DE4", VA = "0x3794DE4")]
    public static void AppWillOpenUrl(string url)
    {
    }

    [Token(Token = "0x6019B4A")]
    [Address(RVA = "0x3794FC4", Offset = "0x3794FC4", VA = "0x3794FC4")]
    public static void TrackAdRevenue(string source, string payload)
    {
    }

    [Token(Token = "0x6019B4B")]
    [Address(RVA = "0x37951D8", Offset = "0x37951D8", VA = "0x37951D8")]
    public static void TrackAdRevenue(AdjustAdRevenue adRevenue)
    {
    }

    [Token(Token = "0x6019B4C")]
    [Address(RVA = "0x37958D0", Offset = "0x37958D0", VA = "0x37958D0")]
    public static void TrackPlayStoreSubscription(AdjustPlayStoreSubscription subscription)
    {
    }

    [Token(Token = "0x6019B4D")]
    [Address(RVA = "0x3795E20", Offset = "0x3795E20", VA = "0x3795E20")]
    public static void TrackThirdPartySharing(AdjustThirdPartySharing thirdPartySharing)
    {
    }

    [Token(Token = "0x6019B4E")]
    [Address(RVA = "0x37965C8", Offset = "0x37965C8", VA = "0x37965C8")]
    public static void TrackMeasurementConsent(bool measurementConsent)
    {
    }

    [Token(Token = "0x6019B4F")]
    [Address(RVA = "0x37966E0", Offset = "0x37966E0", VA = "0x37966E0")]
    public static void OnPause()
    {
    }

    [Token(Token = "0x6019B50")]
    [Address(RVA = "0x37967B8", Offset = "0x37967B8", VA = "0x37967B8")]
    public static void OnResume()
    {
    }

    [Token(Token = "0x6019B51")]
    [Address(RVA = "0x3796890", Offset = "0x3796890", VA = "0x3796890")]
    public static void SetReferrer(string referrer)
    {
    }

    [Token(Token = "0x6019B52")]
    [Address(RVA = "0x37969B0", Offset = "0x37969B0", VA = "0x37969B0")]
    public static void GetGoogleAdId(Action<string> onDeviceIdsRead)
    {
    }

    [Token(Token = "0x6019B53")]
    [Address(RVA = "0x3796B7C", Offset = "0x3796B7C", VA = "0x3796B7C")]
    public static string GetAmazonAdId() => (string) null;

    [Token(Token = "0x6019B54")]
    [Address(RVA = "0x3796C7C", Offset = "0x3796C7C", VA = "0x3796C7C")]
    public static string GetSdkVersion() => (string) null;

    [Token(Token = "0x6019B55")]
    [Address(RVA = "0x3796D90", Offset = "0x3796D90", VA = "0x3796D90")]
    public static void VerifyPlayStorePurchase(
      AdjustPlayStorePurchase purchase,
      Action<AdjustPurchaseVerificationInfo> verificationInfoCallback)
    {
    }

    [Token(Token = "0x6019B56")]
    [Address(RVA = "0x3797018", Offset = "0x3797018", VA = "0x3797018")]
    public static void ProcessDeeplink(string url, Action<string> resolvedLinkCallback)
    {
    }

    [Token(Token = "0x6019B57")]
    [Address(RVA = "0x37972EC", Offset = "0x37972EC", VA = "0x37972EC")]
    public static void SetTestOptions(Dictionary<string, string> testOptions)
    {
    }

    [Token(Token = "0x6019B58")]
    [Address(RVA = "0x3792AFC", Offset = "0x3792AFC", VA = "0x3792AFC")]
    private static bool IsAppSecretSet(AdjustConfig adjustConfig) => new bool();

    [Token(Token = "0x6019B59")]
    [Address(RVA = "0x3797424", Offset = "0x3797424", VA = "0x3797424")]
    public AdjustAndroid()
    {
    }

    [Token(Token = "0x6019B5A")]
    [Address(RVA = "0x379742C", Offset = "0x379742C", VA = "0x379742C")]
    static AdjustAndroid()
    {
    }

    [Token(Token = "0x2003FDE")]
    private class AttributionChangeListener : AndroidJavaProxy
    {
      [Token(Token = "0x40117D0")]
      [FieldOffset(Offset = "0x20")]
      private Action<AdjustAttribution> callback;

      [Token(Token = "0x6019B5B")]
      [Address(RVA = "0x3792B70", Offset = "0x3792B70", VA = "0x3792B70")]
      public AttributionChangeListener(Action<AdjustAttribution> pCallback)
      {
      }

      [Token(Token = "0x6019B5C")]
      [Address(RVA = "0x3797548", Offset = "0x3797548", VA = "0x3797548")]
      public void onAttributionChanged(AndroidJavaObject attribution)
      {
      }
    }

    [Token(Token = "0x2003FDF")]
    private class DeferredDeeplinkListener : AndroidJavaProxy
    {
      [Token(Token = "0x40117D1")]
      [FieldOffset(Offset = "0x20")]
      private Action<string> callback;

      [Token(Token = "0x6019B5D")]
      [Address(RVA = "0x3792E04", Offset = "0x3792E04", VA = "0x3792E04")]
      public DeferredDeeplinkListener(Action<string> pCallback)
      {
      }

      [Token(Token = "0x6019B5E")]
      [Address(RVA = "0x3797C08", Offset = "0x3797C08", VA = "0x3797C08")]
      public bool launchReceivedDeeplink(AndroidJavaObject deeplink) => new bool();
    }

    [Token(Token = "0x2003FE0")]
    private class EventTrackingSucceededListener : AndroidJavaProxy
    {
      [Token(Token = "0x40117D2")]
      [FieldOffset(Offset = "0x20")]
      private Action<AdjustEventSuccess> callback;

      [Token(Token = "0x6019B5F")]
      [Address(RVA = "0x3792BF4", Offset = "0x3792BF4", VA = "0x3792BF4")]
      public EventTrackingSucceededListener(Action<AdjustEventSuccess> pCallback)
      {
      }

      [Token(Token = "0x6019B60")]
      [Address(RVA = "0x3797D28", Offset = "0x3797D28", VA = "0x3797D28")]
      public void onFinishedEventTrackingSucceeded(AndroidJavaObject eventSuccessData)
      {
      }
    }

    [Token(Token = "0x2003FE1")]
    private class EventTrackingFailedListener : AndroidJavaProxy
    {
      [Token(Token = "0x40117D3")]
      [FieldOffset(Offset = "0x20")]
      private Action<AdjustEventFailure> callback;

      [Token(Token = "0x6019B61")]
      [Address(RVA = "0x3792C78", Offset = "0x3792C78", VA = "0x3792C78")]
      public EventTrackingFailedListener(Action<AdjustEventFailure> pCallback)
      {
      }

      [Token(Token = "0x6019B62")]
      [Address(RVA = "0x3798280", Offset = "0x3798280", VA = "0x3798280")]
      public void onFinishedEventTrackingFailed(AndroidJavaObject eventFailureData)
      {
      }
    }

    [Token(Token = "0x2003FE2")]
    private class SessionTrackingSucceededListener : AndroidJavaProxy
    {
      [Token(Token = "0x40117D4")]
      [FieldOffset(Offset = "0x20")]
      private Action<AdjustSessionSuccess> callback;

      [Token(Token = "0x6019B63")]
      [Address(RVA = "0x3792CFC", Offset = "0x3792CFC", VA = "0x3792CFC")]
      public SessionTrackingSucceededListener(Action<AdjustSessionSuccess> pCallback)
      {
      }

      [Token(Token = "0x6019B64")]
      [Address(RVA = "0x379880C", Offset = "0x379880C", VA = "0x379880C")]
      public void onFinishedSessionTrackingSucceeded(AndroidJavaObject sessionSuccessData)
      {
      }
    }

    [Token(Token = "0x2003FE3")]
    private class SessionTrackingFailedListener : AndroidJavaProxy
    {
      [Token(Token = "0x40117D5")]
      [FieldOffset(Offset = "0x20")]
      private Action<AdjustSessionFailure> callback;

      [Token(Token = "0x6019B65")]
      [Address(RVA = "0x3792D80", Offset = "0x3792D80", VA = "0x3792D80")]
      public SessionTrackingFailedListener(Action<AdjustSessionFailure> pCallback)
      {
      }

      [Token(Token = "0x6019B66")]
      [Address(RVA = "0x3798B98", Offset = "0x3798B98", VA = "0x3798B98")]
      public void onFinishedSessionTrackingFailed(AndroidJavaObject sessionFailureData)
      {
      }
    }

    [Token(Token = "0x2003FE4")]
    private class DeviceIdsReadListener : AndroidJavaProxy
    {
      [Token(Token = "0x40117D6")]
      [FieldOffset(Offset = "0x20")]
      private Action<string> onPlayAdIdReadCallback;

      [Token(Token = "0x6019B67")]
      [Address(RVA = "0x3796AF8", Offset = "0x3796AF8", VA = "0x3796AF8")]
      public DeviceIdsReadListener(Action<string> pCallback)
      {
      }

      [Token(Token = "0x6019B68")]
      [Address(RVA = "0x3798F58", Offset = "0x3798F58", VA = "0x3798F58")]
      public void onGoogleAdIdRead(string playAdId)
      {
      }

      [Token(Token = "0x6019B69")]
      [Address(RVA = "0x3798F74", Offset = "0x3798F74", VA = "0x3798F74")]
      public void onGoogleAdIdRead(AndroidJavaObject ajoAdId)
      {
      }
    }

    [Token(Token = "0x2003FE5")]
    private class VerificationInfoListener : AndroidJavaProxy
    {
      [Token(Token = "0x40117D7")]
      [FieldOffset(Offset = "0x20")]
      private Action<AdjustPurchaseVerificationInfo> callback;

      [Token(Token = "0x6019B6A")]
      [Address(RVA = "0x3796F94", Offset = "0x3796F94", VA = "0x3796F94")]
      public VerificationInfoListener(Action<AdjustPurchaseVerificationInfo> pCallback)
      {
      }

      [Token(Token = "0x6019B6B")]
      [Address(RVA = "0x3799080", Offset = "0x3799080", VA = "0x3799080")]
      public void onVerificationFinished(AndroidJavaObject verificationInfo)
      {
      }
    }

    [Token(Token = "0x2003FE6")]
    private class DeeplinkResolutionListener : AndroidJavaProxy
    {
      [Token(Token = "0x40117D8")]
      [FieldOffset(Offset = "0x20")]
      private Action<string> callback;

      [Token(Token = "0x6019B6C")]
      [Address(RVA = "0x3797268", Offset = "0x3797268", VA = "0x3797268")]
      public DeeplinkResolutionListener(Action<string> pCallback)
      {
      }

      [Token(Token = "0x6019B6D")]
      [Address(RVA = "0x37991C0", Offset = "0x37991C0", VA = "0x37991C0")]
      public void onDeeplinkResolved(string resolvedLink)
      {
      }
    }
  }
}
