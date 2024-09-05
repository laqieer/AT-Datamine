// Decompiled with JetBrains decompiler
// Type: Network.API.APICoinShopRefresh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BE1")]
  public class APICoinShopRefresh
  {
    [Token(Token = "0x4007761")]
    public const string DefaultAPIPath = "api/v1/shop/coin_shop_refresh";
    [Token(Token = "0x4007765")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007766")]
    [FieldOffset(Offset = "0x30")]
    public Action<APICoinShopRefreshResponse> onSuccess;
    [Token(Token = "0x4007767")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E6E")]
    public APICoinShopRefreshRequest Request
    {
      [Token(Token = "0x600A3D8"), Address(RVA = "0x46D0400", Offset = "0x46D0400", VA = "0x46D0400")] private get
      {
        return (APICoinShopRefreshRequest) null;
      }
      [Token(Token = "0x600A3D9"), Address(RVA = "0x46D0408", Offset = "0x46D0408", VA = "0x46D0408")] set
      {
      }
    }

    [Token(Token = "0x17001E6F")]
    public APICoinShopRefreshResponse Response
    {
      [Token(Token = "0x600A3DA"), Address(RVA = "0x46D0410", Offset = "0x46D0410", VA = "0x46D0410")] get
      {
        return (APICoinShopRefreshResponse) null;
      }
      [Token(Token = "0x600A3DB"), Address(RVA = "0x46D0418", Offset = "0x46D0418", VA = "0x46D0418")] private set
      {
      }
    }

    [Token(Token = "0x17001E70")]
    public int ResponseCode
    {
      [Token(Token = "0x600A3DC"), Address(RVA = "0x46D0420", Offset = "0x46D0420", VA = "0x46D0420")] get
      {
        return new int();
      }
      [Token(Token = "0x600A3DD"), Address(RVA = "0x46D0428", Offset = "0x46D0428", VA = "0x46D0428")] private set
      {
      }
    }

    [Token(Token = "0x17001E71")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A3DE"), Address(RVA = "0x46D0430", Offset = "0x46D0430", VA = "0x46D0430")] set
      {
      }
      [Token(Token = "0x600A3DF"), Address(RVA = "0x46D044C", Offset = "0x46D044C", VA = "0x46D044C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A3E0")]
    [Address(RVA = "0x46D0468", Offset = "0x46D0468", VA = "0x46D0468")]
    public APICoinShopRefresh(string apiPath = "api/v1/shop/coin_shop_refresh")
    {
    }

    [Token(Token = "0x600A3E1")]
    [Address(RVA = "0x46D0500", Offset = "0x46D0500", VA = "0x46D0500")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A3E2")]
    [Address(RVA = "0x46D0590", Offset = "0x46D0590", VA = "0x46D0590")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A3E3")]
    [Address(RVA = "0x46D059C", Offset = "0x46D059C", VA = "0x46D059C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A3E4")]
    [Address(RVA = "0x46D0670", Offset = "0x46D0670", VA = "0x46D0670")]
    private void OnSuccess(string json)
    {
    }
  }
}
