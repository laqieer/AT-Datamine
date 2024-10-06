// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryShopList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E69")]
  public class APIStoryShopList
  {
    [Token(Token = "0x4008294")]
    public const string DefaultAPIPath = "api/v1/story/shop/list";
    [Token(Token = "0x4008298")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008299")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryShopListResponse> onSuccess;
    [Token(Token = "0x400829A")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170024D4")]
    public APIStoryShopListRequest Request
    {
      [Token(Token = "0x600B45E"), Address(RVA = "0x22E5BB0", Offset = "0x22E5BB0", VA = "0x22E5BB0")] private get
      {
        return (APIStoryShopListRequest) null;
      }
      [Token(Token = "0x600B45F"), Address(RVA = "0x22E5BB8", Offset = "0x22E5BB8", VA = "0x22E5BB8")] set
      {
      }
    }

    [Token(Token = "0x170024D5")]
    public APIStoryShopListResponse Response
    {
      [Token(Token = "0x600B460"), Address(RVA = "0x22E5BC0", Offset = "0x22E5BC0", VA = "0x22E5BC0")] get
      {
        return (APIStoryShopListResponse) null;
      }
      [Token(Token = "0x600B461"), Address(RVA = "0x22E5BC8", Offset = "0x22E5BC8", VA = "0x22E5BC8")] private set
      {
      }
    }

    [Token(Token = "0x170024D6")]
    public int ResponseCode
    {
      [Token(Token = "0x600B462"), Address(RVA = "0x22E5BD0", Offset = "0x22E5BD0", VA = "0x22E5BD0")] get
      {
        return new int();
      }
      [Token(Token = "0x600B463"), Address(RVA = "0x22E5BD8", Offset = "0x22E5BD8", VA = "0x22E5BD8")] private set
      {
      }
    }

    [Token(Token = "0x170024D7")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B464"), Address(RVA = "0x22E5BE0", Offset = "0x22E5BE0", VA = "0x22E5BE0")] set
      {
      }
      [Token(Token = "0x600B465"), Address(RVA = "0x22E5BFC", Offset = "0x22E5BFC", VA = "0x22E5BFC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B466")]
    [Address(RVA = "0x22E5C18", Offset = "0x22E5C18", VA = "0x22E5C18")]
    public APIStoryShopList(string apiPath = "api/v1/story/shop/list")
    {
    }

    [Token(Token = "0x600B467")]
    [Address(RVA = "0x22E5CB0", Offset = "0x22E5CB0", VA = "0x22E5CB0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B468")]
    [Address(RVA = "0x22E5D40", Offset = "0x22E5D40", VA = "0x22E5D40")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B469")]
    [Address(RVA = "0x22E5D4C", Offset = "0x22E5D4C", VA = "0x22E5D4C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B46A")]
    [Address(RVA = "0x22E5E20", Offset = "0x22E5E20", VA = "0x22E5E20")]
    private void OnSuccess(string json)
    {
    }
  }
}
