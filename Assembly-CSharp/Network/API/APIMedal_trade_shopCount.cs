// Decompiled with JetBrains decompiler
// Type: Network.API.APIMedal_trade_shopCount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D51")]
  public class APIMedal_trade_shopCount
  {
    [Token(Token = "0x4007D3A")]
    public const string DefaultAPIPath = "api/v1/medal_trade_shop/count";
    [Token(Token = "0x4007D3E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007D3F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIMedal_trade_shopCountResponse> onSuccess;
    [Token(Token = "0x4007D40")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170021BE")]
    public APIMedal_trade_shopCountRequest Request
    {
      [Token(Token = "0x600ACE8"), Address(RVA = "0x1A47F24", Offset = "0x1A47F24", VA = "0x1A47F24")] private get
      {
        return (APIMedal_trade_shopCountRequest) null;
      }
      [Token(Token = "0x600ACE9"), Address(RVA = "0x1A47F2C", Offset = "0x1A47F2C", VA = "0x1A47F2C")] set
      {
      }
    }

    [Token(Token = "0x170021BF")]
    public APIMedal_trade_shopCountResponse Response
    {
      [Token(Token = "0x600ACEA"), Address(RVA = "0x1A47F34", Offset = "0x1A47F34", VA = "0x1A47F34")] get
      {
        return (APIMedal_trade_shopCountResponse) null;
      }
      [Token(Token = "0x600ACEB"), Address(RVA = "0x1A47F3C", Offset = "0x1A47F3C", VA = "0x1A47F3C")] private set
      {
      }
    }

    [Token(Token = "0x170021C0")]
    public int ResponseCode
    {
      [Token(Token = "0x600ACEC"), Address(RVA = "0x1A47F44", Offset = "0x1A47F44", VA = "0x1A47F44")] get
      {
        return new int();
      }
      [Token(Token = "0x600ACED"), Address(RVA = "0x1A47F4C", Offset = "0x1A47F4C", VA = "0x1A47F4C")] private set
      {
      }
    }

    [Token(Token = "0x170021C1")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600ACEE"), Address(RVA = "0x1A47F54", Offset = "0x1A47F54", VA = "0x1A47F54")] set
      {
      }
      [Token(Token = "0x600ACEF"), Address(RVA = "0x1A47F70", Offset = "0x1A47F70", VA = "0x1A47F70")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600ACF0")]
    [Address(RVA = "0x1A47F8C", Offset = "0x1A47F8C", VA = "0x1A47F8C")]
    public APIMedal_trade_shopCount(string apiPath = "api/v1/medal_trade_shop/count")
    {
    }

    [Token(Token = "0x600ACF1")]
    [Address(RVA = "0x1A48024", Offset = "0x1A48024", VA = "0x1A48024")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600ACF2")]
    [Address(RVA = "0x1A480B4", Offset = "0x1A480B4", VA = "0x1A480B4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600ACF3")]
    [Address(RVA = "0x1A480C0", Offset = "0x1A480C0", VA = "0x1A480C0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600ACF4")]
    [Address(RVA = "0x1A48194", Offset = "0x1A48194", VA = "0x1A48194")]
    private void OnSuccess(string json)
    {
    }
  }
}
