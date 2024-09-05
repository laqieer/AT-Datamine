// Decompiled with JetBrains decompiler
// Type: Network.API.APIShopPurchase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E15")]
  public class APIShopPurchase
  {
    [Token(Token = "0x40080BF")]
    public const string DefaultAPIPath = "api/v1/shop/purchase";
    [Token(Token = "0x40080C3")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40080C4")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIShopPurchaseResponse> onSuccess;
    [Token(Token = "0x40080C5")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170023C7")]
    public APIShopPurchaseRequest Request
    {
      [Token(Token = "0x600B201"), Address(RVA = "0x22DE7FC", Offset = "0x22DE7FC", VA = "0x22DE7FC")] private get
      {
        return (APIShopPurchaseRequest) null;
      }
      [Token(Token = "0x600B202"), Address(RVA = "0x22DE804", Offset = "0x22DE804", VA = "0x22DE804")] set
      {
      }
    }

    [Token(Token = "0x170023C8")]
    public APIShopPurchaseResponse Response
    {
      [Token(Token = "0x600B203"), Address(RVA = "0x22DE80C", Offset = "0x22DE80C", VA = "0x22DE80C")] get
      {
        return (APIShopPurchaseResponse) null;
      }
      [Token(Token = "0x600B204"), Address(RVA = "0x22DE814", Offset = "0x22DE814", VA = "0x22DE814")] private set
      {
      }
    }

    [Token(Token = "0x170023C9")]
    public int ResponseCode
    {
      [Token(Token = "0x600B205"), Address(RVA = "0x22DE81C", Offset = "0x22DE81C", VA = "0x22DE81C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B206"), Address(RVA = "0x22DE824", Offset = "0x22DE824", VA = "0x22DE824")] private set
      {
      }
    }

    [Token(Token = "0x170023CA")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B207"), Address(RVA = "0x22DE82C", Offset = "0x22DE82C", VA = "0x22DE82C")] set
      {
      }
      [Token(Token = "0x600B208"), Address(RVA = "0x22DE848", Offset = "0x22DE848", VA = "0x22DE848")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B209")]
    [Address(RVA = "0x22DE864", Offset = "0x22DE864", VA = "0x22DE864")]
    public APIShopPurchase(string apiPath = "api/v1/shop/purchase")
    {
    }

    [Token(Token = "0x600B20A")]
    [Address(RVA = "0x22DE8FC", Offset = "0x22DE8FC", VA = "0x22DE8FC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B20B")]
    [Address(RVA = "0x22DE98C", Offset = "0x22DE98C", VA = "0x22DE98C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B20C")]
    [Address(RVA = "0x22DE998", Offset = "0x22DE998", VA = "0x22DE998")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B20D")]
    [Address(RVA = "0x22DEA6C", Offset = "0x22DEA6C", VA = "0x22DEA6C")]
    private void OnSuccess(string json)
    {
    }
  }
}
