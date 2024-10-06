// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x2003FFC")]
  public class AdjustUtils
  {
    [Token(Token = "0x4011898")]
    [FieldOffset(Offset = "0x0")]
    public static string KeyAdid;
    [Token(Token = "0x4011899")]
    [FieldOffset(Offset = "0x8")]
    public static string KeyMessage;
    [Token(Token = "0x401189A")]
    [FieldOffset(Offset = "0x10")]
    public static string KeyNetwork;
    [Token(Token = "0x401189B")]
    [FieldOffset(Offset = "0x18")]
    public static string KeyAdgroup;
    [Token(Token = "0x401189C")]
    [FieldOffset(Offset = "0x20")]
    public static string KeyCampaign;
    [Token(Token = "0x401189D")]
    [FieldOffset(Offset = "0x28")]
    public static string KeyCreative;
    [Token(Token = "0x401189E")]
    [FieldOffset(Offset = "0x30")]
    public static string KeyWillRetry;
    [Token(Token = "0x401189F")]
    [FieldOffset(Offset = "0x38")]
    public static string KeyTimestamp;
    [Token(Token = "0x40118A0")]
    [FieldOffset(Offset = "0x40")]
    public static string KeyCallbackId;
    [Token(Token = "0x40118A1")]
    [FieldOffset(Offset = "0x48")]
    public static string KeyEventToken;
    [Token(Token = "0x40118A2")]
    [FieldOffset(Offset = "0x50")]
    public static string KeyClickLabel;
    [Token(Token = "0x40118A3")]
    [FieldOffset(Offset = "0x58")]
    public static string KeyTrackerName;
    [Token(Token = "0x40118A4")]
    [FieldOffset(Offset = "0x60")]
    public static string KeyTrackerToken;
    [Token(Token = "0x40118A5")]
    [FieldOffset(Offset = "0x68")]
    public static string KeyJsonResponse;
    [Token(Token = "0x40118A6")]
    [FieldOffset(Offset = "0x70")]
    public static string KeyCostType;
    [Token(Token = "0x40118A7")]
    [FieldOffset(Offset = "0x78")]
    public static string KeyCostAmount;
    [Token(Token = "0x40118A8")]
    [FieldOffset(Offset = "0x80")]
    public static string KeyCostCurrency;
    [Token(Token = "0x40118A9")]
    [FieldOffset(Offset = "0x88")]
    public static string KeyFbInstallReferrer;
    [Token(Token = "0x40118AA")]
    [FieldOffset(Offset = "0x90")]
    public static string KeySkadConversionValue;
    [Token(Token = "0x40118AB")]
    [FieldOffset(Offset = "0x98")]
    public static string KeySkadCoarseValue;
    [Token(Token = "0x40118AC")]
    [FieldOffset(Offset = "0xA0")]
    public static string KeySkadLockWindow;
    [Token(Token = "0x40118AD")]
    [FieldOffset(Offset = "0xA8")]
    public static string KeyCode;
    [Token(Token = "0x40118AE")]
    [FieldOffset(Offset = "0xB0")]
    public static string KeyVerificationStatus;
    [Token(Token = "0x40118AF")]
    [FieldOffset(Offset = "0xB8")]
    public static string KeyTestOptionsBaseUrl;
    [Token(Token = "0x40118B0")]
    [FieldOffset(Offset = "0xC0")]
    public static string KeyTestOptionsGdprUrl;
    [Token(Token = "0x40118B1")]
    [FieldOffset(Offset = "0xC8")]
    public static string KeyTestOptionsSubscriptionUrl;
    [Token(Token = "0x40118B2")]
    [FieldOffset(Offset = "0xD0")]
    public static string KeyTestOptionsPurchaseVerificationUrl;
    [Token(Token = "0x40118B3")]
    [FieldOffset(Offset = "0xD8")]
    public static string KeyTestOptionsOverwriteUrl;
    [Token(Token = "0x40118B4")]
    [FieldOffset(Offset = "0xE0")]
    public static string KeyTestOptionsExtraPath;
    [Token(Token = "0x40118B5")]
    [FieldOffset(Offset = "0xE8")]
    public static string KeyTestOptionsBasePath;
    [Token(Token = "0x40118B6")]
    [FieldOffset(Offset = "0xF0")]
    public static string KeyTestOptionsGdprPath;
    [Token(Token = "0x40118B7")]
    [FieldOffset(Offset = "0xF8")]
    public static string KeyTestOptionsDeleteState;
    [Token(Token = "0x40118B8")]
    [FieldOffset(Offset = "0x100")]
    public static string KeyTestOptionsUseTestConnectionOptions;
    [Token(Token = "0x40118B9")]
    [FieldOffset(Offset = "0x108")]
    public static string KeyTestOptionsTimerIntervalInMilliseconds;
    [Token(Token = "0x40118BA")]
    [FieldOffset(Offset = "0x110")]
    public static string KeyTestOptionsTimerStartInMilliseconds;
    [Token(Token = "0x40118BB")]
    [FieldOffset(Offset = "0x118")]
    public static string KeyTestOptionsSessionIntervalInMilliseconds;
    [Token(Token = "0x40118BC")]
    [FieldOffset(Offset = "0x120")]
    public static string KeyTestOptionsSubsessionIntervalInMilliseconds;
    [Token(Token = "0x40118BD")]
    [FieldOffset(Offset = "0x128")]
    public static string KeyTestOptionsTeardown;
    [Token(Token = "0x40118BE")]
    [FieldOffset(Offset = "0x130")]
    public static string KeyTestOptionsNoBackoffWait;
    [Token(Token = "0x40118BF")]
    [FieldOffset(Offset = "0x138")]
    public static string KeyTestOptionsAdServicesFrameworkEnabled;
    [Token(Token = "0x40118C0")]
    [FieldOffset(Offset = "0x140")]
    public static string KeyTestOptionsAttStatus;
    [Token(Token = "0x40118C1")]
    [FieldOffset(Offset = "0x148")]
    public static string KeyTestOptionsIdfa;

    [Token(Token = "0x6019C52")]
    [Address(RVA = "0x3B3C5DC", Offset = "0x3B3C5DC", VA = "0x3B3C5DC")]
    public static int ConvertLogLevel(AdjustLogLevel? logLevel) => new int();

    [Token(Token = "0x6019C53")]
    [Address(RVA = "0x3B3C648", Offset = "0x3B3C648", VA = "0x3B3C648")]
    public static int ConvertBool(bool? value) => new int();

    [Token(Token = "0x6019C54")]
    [Address(RVA = "0x3B3C6B8", Offset = "0x3B3C6B8", VA = "0x3B3C6B8")]
    public static double ConvertDouble(double? value) => new double();

    [Token(Token = "0x6019C55")]
    [Address(RVA = "0x3B3C72C", Offset = "0x3B3C72C", VA = "0x3B3C72C")]
    public static int ConvertInt(int? value) => new int();

    [Token(Token = "0x6019C56")]
    [Address(RVA = "0x3B3C798", Offset = "0x3B3C798", VA = "0x3B3C798")]
    public static long ConvertLong(long? value) => new long();

    [Token(Token = "0x6019C57")]
    [Address(RVA = "0x3B3C80C", Offset = "0x3B3C80C", VA = "0x3B3C80C")]
    public static string ConvertListToJson(List<string> list) => (string) null;

    [Token(Token = "0x6019C58")]
    [Address(RVA = "0x3B3B4B4", Offset = "0x3B3B4B4", VA = "0x3B3B4B4")]
    public static string GetJsonResponseCompact(Dictionary<string, object> dictionary)
    {
      return (string) null;
    }

    [Token(Token = "0x6019C59")]
    [Address(RVA = "0x3B3A928", Offset = "0x3B3A928", VA = "0x3B3A928")]
    public static string GetJsonString(JSONNode node, string key) => (string) null;

    [Token(Token = "0x6019C5A")]
    [Address(RVA = "0x3B3AD34", Offset = "0x3B3AD34", VA = "0x3B3AD34")]
    public static void WriteJsonResponseDictionary(
      JSONClass jsonObject,
      Dictionary<string, object> output)
    {
    }

    [Token(Token = "0x6019C5B")]
    [Address(RVA = "0x3B3AC8C", Offset = "0x3B3AC8C", VA = "0x3B3AC8C")]
    public static string TryGetValue(Dictionary<string, string> dictionary, string key)
    {
      return (string) null;
    }

    [Token(Token = "0x6019C5C")]
    [Address(RVA = "0x3B3CB54", Offset = "0x3B3CB54", VA = "0x3B3CB54")]
    public static int GetSkad4ConversionValue(string conversionValueUpdate) => new int();

    [Token(Token = "0x6019C5D")]
    [Address(RVA = "0x3B3CC00", Offset = "0x3B3CC00", VA = "0x3B3CC00")]
    public static string GetSkad4CoarseValue(string conversionValueUpdate) => (string) null;

    [Token(Token = "0x6019C5E")]
    [Address(RVA = "0x3B3CC90", Offset = "0x3B3CC90", VA = "0x3B3CC90")]
    public static bool GetSkad4LockWindow(string conversionValueUpdate) => new bool();

    [Token(Token = "0x6019C5F")]
    [Address(RVA = "0x3B3CD58", Offset = "0x3B3CD58", VA = "0x3B3CD58")]
    public static AndroidJavaObject TestOptionsMap2AndroidJavaObject(
      Dictionary<string, string> testOptionsMap,
      AndroidJavaObject ajoCurrentActivity)
    {
      return (AndroidJavaObject) null;
    }

    [Token(Token = "0x6019C60")]
    [Address(RVA = "0x3B3D9B4", Offset = "0x3B3D9B4", VA = "0x3B3D9B4")]
    public AdjustUtils()
    {
    }

    [Token(Token = "0x6019C61")]
    [Address(RVA = "0x3B3D9BC", Offset = "0x3B3D9BC", VA = "0x3B3D9BC")]
    static AdjustUtils()
    {
    }
  }
}
