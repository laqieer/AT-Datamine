// Decompiled with JetBrains decompiler
// Type: Network.API.APIMedal_trade_shopTrade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D55")]
  public class APIMedal_trade_shopTrade
  {
    [Token(Token = "0x4007D4B")]
    public const string DefaultAPIPath = "api/v1/medal_trade_shop/trade";
    [Token(Token = "0x4007D4F")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007D50")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIMedal_trade_shopTradeResponse> onSuccess;
    [Token(Token = "0x4007D51")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170021C8")]
    public APIMedal_trade_shopTradeRequest Request
    {
      [Token(Token = "0x600AD02"), Address(RVA = "0x1A48490", Offset = "0x1A48490", VA = "0x1A48490")] private get
      {
        return (APIMedal_trade_shopTradeRequest) null;
      }
      [Token(Token = "0x600AD03"), Address(RVA = "0x1A48498", Offset = "0x1A48498", VA = "0x1A48498")] set
      {
      }
    }

    [Token(Token = "0x170021C9")]
    public APIMedal_trade_shopTradeResponse Response
    {
      [Token(Token = "0x600AD04"), Address(RVA = "0x1A484A0", Offset = "0x1A484A0", VA = "0x1A484A0")] get
      {
        return (APIMedal_trade_shopTradeResponse) null;
      }
      [Token(Token = "0x600AD05"), Address(RVA = "0x1A484A8", Offset = "0x1A484A8", VA = "0x1A484A8")] private set
      {
      }
    }

    [Token(Token = "0x170021CA")]
    public int ResponseCode
    {
      [Token(Token = "0x600AD06"), Address(RVA = "0x1A484B0", Offset = "0x1A484B0", VA = "0x1A484B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600AD07"), Address(RVA = "0x1A484B8", Offset = "0x1A484B8", VA = "0x1A484B8")] private set
      {
      }
    }

    [Token(Token = "0x170021CB")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AD08"), Address(RVA = "0x1A484C0", Offset = "0x1A484C0", VA = "0x1A484C0")] set
      {
      }
      [Token(Token = "0x600AD09"), Address(RVA = "0x1A484DC", Offset = "0x1A484DC", VA = "0x1A484DC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AD0A")]
    [Address(RVA = "0x1A484F8", Offset = "0x1A484F8", VA = "0x1A484F8")]
    public APIMedal_trade_shopTrade(string apiPath = "api/v1/medal_trade_shop/trade")
    {
    }

    [Token(Token = "0x600AD0B")]
    [Address(RVA = "0x1A48590", Offset = "0x1A48590", VA = "0x1A48590")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AD0C")]
    [Address(RVA = "0x1A48620", Offset = "0x1A48620", VA = "0x1A48620")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AD0D")]
    [Address(RVA = "0x1A4862C", Offset = "0x1A4862C", VA = "0x1A4862C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AD0E")]
    [Address(RVA = "0x1A48700", Offset = "0x1A48700", VA = "0x1A48700")]
    private void OnSuccess(string json)
    {
    }
  }
}
