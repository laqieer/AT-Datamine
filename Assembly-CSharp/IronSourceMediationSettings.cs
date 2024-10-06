// Decompiled with JetBrains decompiler
// Type: IronSourceMediationSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200005B")]
public class IronSourceMediationSettings : ScriptableObject
{
  [Token(Token = "0x40001A7")]
  [FieldOffset(Offset = "0x0")]
  public static readonly string IRONSOURCE_SETTINGS_ASSET_PATH;
  [Token(Token = "0x40001A8")]
  [FieldOffset(Offset = "0x18")]
  [Header("Ironsource AppKey")]
  [Tooltip("Add your application AppKeys, as provided in Ironsource Platform")]
  public string AndroidAppKey;
  [Token(Token = "0x40001A9")]
  [FieldOffset(Offset = "0x20")]
  [Tooltip("Add your application AppKeys, as provided in Ironsource Platform")]
  public string IOSAppKey;
  [Token(Token = "0x40001AA")]
  [FieldOffset(Offset = "0x28")]
  [Header("Automatic Initialization")]
  [Tooltip("Use this flag when you wish to initialize all ad units (recommended)")]
  public bool EnableIronsourceSDKInitAPI;
  [Token(Token = "0x40001AB")]
  [FieldOffset(Offset = "0x29")]
  [Tooltip("Add Ironsource SKAdNetworkIdentifier to your Info.plist for iOS 14+")]
  [Header("Ironsource SKAdNetwork ID")]
  public bool AddIronsourceSkadnetworkID;
  [Token(Token = "0x40001AC")]
  [FieldOffset(Offset = "0x2A")]
  [Header("Google Play Services Settings")]
  [Tooltip("Add Google Play Services normal permission for API level 31 (Android 12)")]
  public bool DeclareAD_IDPermission;
  [Token(Token = "0x40001AD")]
  [FieldOffset(Offset = "0x2B")]
  [Header("Project Features")]
  public bool EnableAdapterDebug;
  [Token(Token = "0x40001AE")]
  [FieldOffset(Offset = "0x2C")]
  public bool EnableIntegrationHelper;

  [Token(Token = "0x600031B")]
  [Address(RVA = "0x44A3910", Offset = "0x44A3910", VA = "0x44A3910")]
  public IronSourceMediationSettings()
  {
  }

  [Token(Token = "0x600031C")]
  [Address(RVA = "0x44A3968", Offset = "0x44A3968", VA = "0x44A3968")]
  static IronSourceMediationSettings()
  {
  }
}
