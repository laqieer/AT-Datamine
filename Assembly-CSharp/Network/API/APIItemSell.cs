// Decompiled with JetBrains decompiler
// Type: Network.API.APIItemSell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D41")]
  public class APIItemSell
  {
    [Token(Token = "0x4007CEA")]
    public const string DefaultAPIPath = "api/v1/item/sell";
    [Token(Token = "0x4007CEE")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007CEF")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIItemSellResponse> onSuccess;
    [Token(Token = "0x4007CF0")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002196")]
    public APIItemSellRequest Request
    {
      [Token(Token = "0x600AC80"), Address(RVA = "0x1A46984", Offset = "0x1A46984", VA = "0x1A46984")] private get
      {
        return (APIItemSellRequest) null;
      }
      [Token(Token = "0x600AC81"), Address(RVA = "0x1A4698C", Offset = "0x1A4698C", VA = "0x1A4698C")] set
      {
      }
    }

    [Token(Token = "0x17002197")]
    public APIItemSellResponse Response
    {
      [Token(Token = "0x600AC82"), Address(RVA = "0x1A46994", Offset = "0x1A46994", VA = "0x1A46994")] get
      {
        return (APIItemSellResponse) null;
      }
      [Token(Token = "0x600AC83"), Address(RVA = "0x1A4699C", Offset = "0x1A4699C", VA = "0x1A4699C")] private set
      {
      }
    }

    [Token(Token = "0x17002198")]
    public int ResponseCode
    {
      [Token(Token = "0x600AC84"), Address(RVA = "0x1A469A4", Offset = "0x1A469A4", VA = "0x1A469A4")] get
      {
        return new int();
      }
      [Token(Token = "0x600AC85"), Address(RVA = "0x1A469AC", Offset = "0x1A469AC", VA = "0x1A469AC")] private set
      {
      }
    }

    [Token(Token = "0x17002199")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AC86"), Address(RVA = "0x1A469B4", Offset = "0x1A469B4", VA = "0x1A469B4")] set
      {
      }
      [Token(Token = "0x600AC87"), Address(RVA = "0x1A469D0", Offset = "0x1A469D0", VA = "0x1A469D0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AC88")]
    [Address(RVA = "0x1A469EC", Offset = "0x1A469EC", VA = "0x1A469EC")]
    public APIItemSell(string apiPath = "api/v1/item/sell")
    {
    }

    [Token(Token = "0x600AC89")]
    [Address(RVA = "0x1A46A84", Offset = "0x1A46A84", VA = "0x1A46A84")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AC8A")]
    [Address(RVA = "0x1A46B14", Offset = "0x1A46B14", VA = "0x1A46B14")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AC8B")]
    [Address(RVA = "0x1A46B20", Offset = "0x1A46B20", VA = "0x1A46B20")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AC8C")]
    [Address(RVA = "0x1A46BF4", Offset = "0x1A46BF4", VA = "0x1A46BF4")]
    private void OnSuccess(string json)
    {
    }
  }
}
