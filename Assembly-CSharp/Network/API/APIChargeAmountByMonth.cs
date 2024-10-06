// Decompiled with JetBrains decompiler
// Type: Network.API.APIChargeAmountByMonth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BC1")]
  public class APIChargeAmountByMonth
  {
    [Token(Token = "0x40076F2")]
    public const string DefaultAPIPath = "api/v1/shop/charge_amount_by_month";
    [Token(Token = "0x40076F6")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40076F7")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIChargeAmountByMonthResponse> onSuccess;
    [Token(Token = "0x40076F8")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E33")]
    public APIChargeAmountByMonthRequest Request
    {
      [Token(Token = "0x600A31D"), Address(RVA = "0x46CD948", Offset = "0x46CD948", VA = "0x46CD948")] private get
      {
        return (APIChargeAmountByMonthRequest) null;
      }
      [Token(Token = "0x600A31E"), Address(RVA = "0x46CD950", Offset = "0x46CD950", VA = "0x46CD950")] set
      {
      }
    }

    [Token(Token = "0x17001E34")]
    public APIChargeAmountByMonthResponse Response
    {
      [Token(Token = "0x600A31F"), Address(RVA = "0x46CD958", Offset = "0x46CD958", VA = "0x46CD958")] get
      {
        return (APIChargeAmountByMonthResponse) null;
      }
      [Token(Token = "0x600A320"), Address(RVA = "0x46CD960", Offset = "0x46CD960", VA = "0x46CD960")] private set
      {
      }
    }

    [Token(Token = "0x17001E35")]
    public int ResponseCode
    {
      [Token(Token = "0x600A321"), Address(RVA = "0x46CD968", Offset = "0x46CD968", VA = "0x46CD968")] get
      {
        return new int();
      }
      [Token(Token = "0x600A322"), Address(RVA = "0x46CD970", Offset = "0x46CD970", VA = "0x46CD970")] private set
      {
      }
    }

    [Token(Token = "0x17001E36")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A323"), Address(RVA = "0x46CD978", Offset = "0x46CD978", VA = "0x46CD978")] set
      {
      }
      [Token(Token = "0x600A324"), Address(RVA = "0x46CD994", Offset = "0x46CD994", VA = "0x46CD994")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A325")]
    [Address(RVA = "0x46CD9B0", Offset = "0x46CD9B0", VA = "0x46CD9B0")]
    public APIChargeAmountByMonth(string apiPath = "api/v1/shop/charge_amount_by_month")
    {
    }

    [Token(Token = "0x600A326")]
    [Address(RVA = "0x46CDA48", Offset = "0x46CDA48", VA = "0x46CDA48")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A327")]
    [Address(RVA = "0x46CDAD8", Offset = "0x46CDAD8", VA = "0x46CDAD8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A328")]
    [Address(RVA = "0x46CDAE4", Offset = "0x46CDAE4", VA = "0x46CDAE4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A329")]
    [Address(RVA = "0x46CDBB8", Offset = "0x46CDBB8", VA = "0x46CDBB8")]
    private void OnSuccess(string json)
    {
    }
  }
}
