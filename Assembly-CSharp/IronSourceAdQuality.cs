// Decompiled with JetBrains decompiler
// Type: IronSourceAdQuality
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000085")]
public class IronSourceAdQuality : CodeGeneratedSingleton
{
  [Token(Token = "0x400022F")]
  [FieldOffset(Offset = "0x0")]
  private static GameObject adQualityGameObject;
  [Token(Token = "0x4000230")]
  private const string TAG = "IronSource AdQuality";
  [Token(Token = "0x4000231")]
  private const bool DEBUG = false;

  [Token(Token = "0x17000023")]
  protected override bool DontDestroySingleton
  {
    [Token(Token = "0x60004C3"), Address(RVA = "0x44ADD40", Offset = "0x44ADD40", VA = "0x44ADD40", Slot = "9")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x60004C4")]
  [Address(RVA = "0x44ADD48", Offset = "0x44ADD48", VA = "0x44ADD48", Slot = "8")]
  protected override void InitAfterRegisteringAsSingleInstance()
  {
  }

  [Token(Token = "0x60004C5")]
  [Address(RVA = "0x44ADD50", Offset = "0x44ADD50", VA = "0x44ADD50")]
  public static void Initialize(string appKey)
  {
  }

  [Token(Token = "0x60004C6")]
  [Address(RVA = "0x44ADE28", Offset = "0x44ADE28", VA = "0x44ADE28")]
  public static void Initialize(string appKey, ISAdQualityConfig adQualityConfig)
  {
  }

  [Token(Token = "0x60004C7")]
  [Address(RVA = "0x44ADF40", Offset = "0x44ADF40", VA = "0x44ADF40")]
  private static void Initialize(
    string appKey,
    string userId,
    bool userIdSet,
    bool testMode,
    ISAdQualityLogLevel logLevel,
    string initializationSource,
    bool coppa,
    ISAdQualityDeviceIdType deviceIdType,
    ISAdQualityInitCallback adQualityInitCallback)
  {
  }

  [Token(Token = "0x60004C8")]
  [Address(RVA = "0x44AE778", Offset = "0x44AE778", VA = "0x44AE778")]
  public static void ChangeUserId(string userId)
  {
  }

  [Token(Token = "0x60004C9")]
  [Address(RVA = "0x44AE9C8", Offset = "0x44AE9C8", VA = "0x44AE9C8")]
  [Obsolete("This method has been deprecated and will be removed soon")]
  public static void SetUserConsent(bool userConsent)
  {
  }

  [Token(Token = "0x60004CA")]
  [Address(RVA = "0x44AEC48", Offset = "0x44AEC48", VA = "0x44AEC48")]
  public static void SendCustomMediationRevenue(
    ISAdQualityCustomMediationRevenue customMediationRevenue)
  {
  }

  [Token(Token = "0x60004CB")]
  [Address(RVA = "0x44AEFE0", Offset = "0x44AEFE0", VA = "0x44AEFE0")]
  public static void setSegment(ISAdQualitySegment segment)
  {
  }

  [Token(Token = "0x60004CC")]
  [Address(RVA = "0x44AF6F8", Offset = "0x44AF6F8", VA = "0x44AF6F8")]
  public IronSourceAdQuality()
  {
  }

  [Token(Token = "0x60004CD")]
  [Address(RVA = "0x44AF754", Offset = "0x44AF754", VA = "0x44AF754")]
  static IronSourceAdQuality()
  {
  }
}
