// Decompiled with JetBrains decompiler
// Type: Network.API.APIShopList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E11")]
  public class APIShopList
  {
    [Token(Token = "0x40080AC")]
    public const string DefaultAPIPath = "api/v1/shop/list";
    [Token(Token = "0x40080B0")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40080B1")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIShopListResponse> onSuccess;
    [Token(Token = "0x40080B2")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170023BB")]
    public APIShopListRequest Request
    {
      [Token(Token = "0x600B1E5"), Address(RVA = "0x22DE280", Offset = "0x22DE280", VA = "0x22DE280")] private get
      {
        return (APIShopListRequest) null;
      }
      [Token(Token = "0x600B1E6"), Address(RVA = "0x22DE288", Offset = "0x22DE288", VA = "0x22DE288")] set
      {
      }
    }

    [Token(Token = "0x170023BC")]
    public APIShopListResponse Response
    {
      [Token(Token = "0x600B1E7"), Address(RVA = "0x22DE290", Offset = "0x22DE290", VA = "0x22DE290")] get
      {
        return (APIShopListResponse) null;
      }
      [Token(Token = "0x600B1E8"), Address(RVA = "0x22DE298", Offset = "0x22DE298", VA = "0x22DE298")] private set
      {
      }
    }

    [Token(Token = "0x170023BD")]
    public int ResponseCode
    {
      [Token(Token = "0x600B1E9"), Address(RVA = "0x22DE2A0", Offset = "0x22DE2A0", VA = "0x22DE2A0")] get
      {
        return new int();
      }
      [Token(Token = "0x600B1EA"), Address(RVA = "0x22DE2A8", Offset = "0x22DE2A8", VA = "0x22DE2A8")] private set
      {
      }
    }

    [Token(Token = "0x170023BE")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B1EB"), Address(RVA = "0x22DE2B0", Offset = "0x22DE2B0", VA = "0x22DE2B0")] set
      {
      }
      [Token(Token = "0x600B1EC"), Address(RVA = "0x22DE2CC", Offset = "0x22DE2CC", VA = "0x22DE2CC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B1ED")]
    [Address(RVA = "0x22DE2E8", Offset = "0x22DE2E8", VA = "0x22DE2E8")]
    public APIShopList(string apiPath = "api/v1/shop/list")
    {
    }

    [Token(Token = "0x600B1EE")]
    [Address(RVA = "0x22DE380", Offset = "0x22DE380", VA = "0x22DE380")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B1EF")]
    [Address(RVA = "0x22DE410", Offset = "0x22DE410", VA = "0x22DE410")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B1F0")]
    [Address(RVA = "0x22DE41C", Offset = "0x22DE41C", VA = "0x22DE41C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B1F1")]
    [Address(RVA = "0x22DE4F0", Offset = "0x22DE4F0", VA = "0x22DE4F0")]
    private void OnSuccess(string json)
    {
    }
  }
}
