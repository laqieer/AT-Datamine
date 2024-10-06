// Decompiled with JetBrains decompiler
// Type: IronSourceCustomSKADNetworkIdSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000021")]
public class IronSourceCustomSKADNetworkIdSettings : ScriptableObject
{
  [Token(Token = "0x4000094")]
  [FieldOffset(Offset = "0x0")]
  public static readonly string IRONSOURCE_SKAD_ID_SETTING_NAME;
  [Token(Token = "0x4000095")]
  [FieldOffset(Offset = "0x8")]
  public static readonly string IRONSOURCE_SKAD_ID_SETTINGS_ASSET_PATH;
  [Token(Token = "0x4000096")]
  [FieldOffset(Offset = "0x18")]
  [Tooltip("Add SKAdNetworkIdentifier List")]
  [Header("Add SKAdNetwork ID List")]
  public IronSourceCustomSKADNetworkIdSettings.SKADNetworkIdListItem[] SkadnetworkIdList;

  [Token(Token = "0x6000123")]
  [Address(RVA = "0x2049960", Offset = "0x2049960", VA = "0x2049960")]
  public IronSourceCustomSKADNetworkIdSettings()
  {
  }

  [Token(Token = "0x6000124")]
  [Address(RVA = "0x2049968", Offset = "0x2049968", VA = "0x2049968")]
  static IronSourceCustomSKADNetworkIdSettings()
  {
  }

  [Token(Token = "0x2000022")]
  [Serializable]
  public struct SKADNetworkIdListItem
  {
    [Token(Token = "0x4000097")]
    [FieldOffset(Offset = "0x0")]
    [SerializeField]
    private string memo;
    [Token(Token = "0x4000098")]
    [FieldOffset(Offset = "0x8")]
    [Multiline(3)]
    public string key;
  }
}
