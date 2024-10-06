// Decompiled with JetBrains decompiler
// Type: Network.API.APILocationsResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D4C")]
  [Serializable]
  public class APILocationsResponse
  {
    [Token(Token = "0x4007D29")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string dlc_version;
    [Token(Token = "0x4007D2A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string api_url;
    [Token(Token = "0x4007D2B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string cdn_url;
    [Token(Token = "0x4007D2C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string advertisement_app_key;

    [Token(Token = "0x170021B3")]
    public string DlcVersion
    {
      [Token(Token = "0x600ACCC"), Address(RVA = "0x1A479B0", Offset = "0x1A479B0", VA = "0x1A479B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170021B4")]
    public string ApiUrl
    {
      [Token(Token = "0x600ACCD"), Address(RVA = "0x1A479B8", Offset = "0x1A479B8", VA = "0x1A479B8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170021B5")]
    public string CdnUrl
    {
      [Token(Token = "0x600ACCE"), Address(RVA = "0x1A479C0", Offset = "0x1A479C0", VA = "0x1A479C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170021B6")]
    public string AdvertisementAppKey
    {
      [Token(Token = "0x600ACCF"), Address(RVA = "0x1A479C8", Offset = "0x1A479C8", VA = "0x1A479C8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600ACD0")]
    [Address(RVA = "0x1A479D0", Offset = "0x1A479D0", VA = "0x1A479D0")]
    public APILocationsResponse()
    {
    }
  }
}
