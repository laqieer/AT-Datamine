// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryShopPurchase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E6D")]
  public class APIStoryShopPurchase
  {
    [Token(Token = "0x40082A5")]
    public const string DefaultAPIPath = "api/v1/story/shop/purchase";
    [Token(Token = "0x40082A9")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40082AA")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryShopPurchaseResponse> onSuccess;
    [Token(Token = "0x40082AB")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170024DE")]
    public APIStoryShopPurchaseRequest Request
    {
      [Token(Token = "0x600B478"), Address(RVA = "0x22E611C", Offset = "0x22E611C", VA = "0x22E611C")] private get
      {
        return (APIStoryShopPurchaseRequest) null;
      }
      [Token(Token = "0x600B479"), Address(RVA = "0x22E6124", Offset = "0x22E6124", VA = "0x22E6124")] set
      {
      }
    }

    [Token(Token = "0x170024DF")]
    public APIStoryShopPurchaseResponse Response
    {
      [Token(Token = "0x600B47A"), Address(RVA = "0x22E612C", Offset = "0x22E612C", VA = "0x22E612C")] get
      {
        return (APIStoryShopPurchaseResponse) null;
      }
      [Token(Token = "0x600B47B"), Address(RVA = "0x22E6134", Offset = "0x22E6134", VA = "0x22E6134")] private set
      {
      }
    }

    [Token(Token = "0x170024E0")]
    public int ResponseCode
    {
      [Token(Token = "0x600B47C"), Address(RVA = "0x22E613C", Offset = "0x22E613C", VA = "0x22E613C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B47D"), Address(RVA = "0x22E6144", Offset = "0x22E6144", VA = "0x22E6144")] private set
      {
      }
    }

    [Token(Token = "0x170024E1")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B47E"), Address(RVA = "0x22E614C", Offset = "0x22E614C", VA = "0x22E614C")] set
      {
      }
      [Token(Token = "0x600B47F"), Address(RVA = "0x22E6168", Offset = "0x22E6168", VA = "0x22E6168")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B480")]
    [Address(RVA = "0x22E6184", Offset = "0x22E6184", VA = "0x22E6184")]
    public APIStoryShopPurchase(string apiPath = "api/v1/story/shop/purchase")
    {
    }

    [Token(Token = "0x600B481")]
    [Address(RVA = "0x22E621C", Offset = "0x22E621C", VA = "0x22E621C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B482")]
    [Address(RVA = "0x22E62AC", Offset = "0x22E62AC", VA = "0x22E62AC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B483")]
    [Address(RVA = "0x22E62B8", Offset = "0x22E62B8", VA = "0x22E62B8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B484")]
    [Address(RVA = "0x22E638C", Offset = "0x22E638C", VA = "0x22E638C")]
    private void OnSuccess(string json)
    {
    }
  }
}
