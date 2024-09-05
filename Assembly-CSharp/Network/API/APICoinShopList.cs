// Decompiled with JetBrains decompiler
// Type: Network.API.APICoinShopList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BDD")]
  public class APICoinShopList
  {
    [Token(Token = "0x4007751")]
    public const string DefaultAPIPath = "api/v1/shop/coin_shop_list";
    [Token(Token = "0x4007755")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007756")]
    [FieldOffset(Offset = "0x30")]
    public Action<APICoinShopListResponse> onSuccess;
    [Token(Token = "0x4007757")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E63")]
    public APICoinShopListRequest Request
    {
      [Token(Token = "0x600A3BD"), Address(RVA = "0x46CFE8C", Offset = "0x46CFE8C", VA = "0x46CFE8C")] private get
      {
        return (APICoinShopListRequest) null;
      }
      [Token(Token = "0x600A3BE"), Address(RVA = "0x46CFE94", Offset = "0x46CFE94", VA = "0x46CFE94")] set
      {
      }
    }

    [Token(Token = "0x17001E64")]
    public APICoinShopListResponse Response
    {
      [Token(Token = "0x600A3BF"), Address(RVA = "0x46CFE9C", Offset = "0x46CFE9C", VA = "0x46CFE9C")] get
      {
        return (APICoinShopListResponse) null;
      }
      [Token(Token = "0x600A3C0"), Address(RVA = "0x46CFEA4", Offset = "0x46CFEA4", VA = "0x46CFEA4")] private set
      {
      }
    }

    [Token(Token = "0x17001E65")]
    public int ResponseCode
    {
      [Token(Token = "0x600A3C1"), Address(RVA = "0x46CFEAC", Offset = "0x46CFEAC", VA = "0x46CFEAC")] get
      {
        return new int();
      }
      [Token(Token = "0x600A3C2"), Address(RVA = "0x46CFEB4", Offset = "0x46CFEB4", VA = "0x46CFEB4")] private set
      {
      }
    }

    [Token(Token = "0x17001E66")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A3C3"), Address(RVA = "0x46CFEBC", Offset = "0x46CFEBC", VA = "0x46CFEBC")] set
      {
      }
      [Token(Token = "0x600A3C4"), Address(RVA = "0x46CFED8", Offset = "0x46CFED8", VA = "0x46CFED8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A3C5")]
    [Address(RVA = "0x46CFEF4", Offset = "0x46CFEF4", VA = "0x46CFEF4")]
    public APICoinShopList(string apiPath = "api/v1/shop/coin_shop_list")
    {
    }

    [Token(Token = "0x600A3C6")]
    [Address(RVA = "0x46CFF8C", Offset = "0x46CFF8C", VA = "0x46CFF8C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A3C7")]
    [Address(RVA = "0x46D001C", Offset = "0x46D001C", VA = "0x46D001C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A3C8")]
    [Address(RVA = "0x46D0028", Offset = "0x46D0028", VA = "0x46D0028")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A3C9")]
    [Address(RVA = "0x46D00FC", Offset = "0x46D00FC", VA = "0x46D00FC")]
    private void OnSuccess(string json)
    {
    }
  }
}
