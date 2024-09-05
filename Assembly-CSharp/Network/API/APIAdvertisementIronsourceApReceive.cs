// Decompiled with JetBrains decompiler
// Type: Network.API.APIAdvertisementIronsourceApReceive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B51")]
  public class APIAdvertisementIronsourceApReceive
  {
    [Token(Token = "0x4007520")]
    public const string DefaultAPIPath = "api/v1/advertisement/ironsource/ap/receive";
    [Token(Token = "0x4007524")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007525")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAdvertisementIronsourceApReceiveResponse> onSuccess;
    [Token(Token = "0x4007526")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D37")]
    public APIAdvertisementIronsourceApReceiveRequest Request
    {
      [Token(Token = "0x600A061"), Address(RVA = "0x46C4258", Offset = "0x46C4258", VA = "0x46C4258")] private get
      {
        return (APIAdvertisementIronsourceApReceiveRequest) null;
      }
      [Token(Token = "0x600A062"), Address(RVA = "0x46C4260", Offset = "0x46C4260", VA = "0x46C4260")] set
      {
      }
    }

    [Token(Token = "0x17001D38")]
    public APIAdvertisementIronsourceApReceiveResponse Response
    {
      [Token(Token = "0x600A063"), Address(RVA = "0x46C4268", Offset = "0x46C4268", VA = "0x46C4268")] get
      {
        return (APIAdvertisementIronsourceApReceiveResponse) null;
      }
      [Token(Token = "0x600A064"), Address(RVA = "0x46C4270", Offset = "0x46C4270", VA = "0x46C4270")] private set
      {
      }
    }

    [Token(Token = "0x17001D39")]
    public int ResponseCode
    {
      [Token(Token = "0x600A065"), Address(RVA = "0x46C4278", Offset = "0x46C4278", VA = "0x46C4278")] get
      {
        return new int();
      }
      [Token(Token = "0x600A066"), Address(RVA = "0x46C4280", Offset = "0x46C4280", VA = "0x46C4280")] private set
      {
      }
    }

    [Token(Token = "0x17001D3A")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A067"), Address(RVA = "0x46C4288", Offset = "0x46C4288", VA = "0x46C4288")] set
      {
      }
      [Token(Token = "0x600A068"), Address(RVA = "0x46C42A4", Offset = "0x46C42A4", VA = "0x46C42A4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A069")]
    [Address(RVA = "0x46C42C0", Offset = "0x46C42C0", VA = "0x46C42C0")]
    public APIAdvertisementIronsourceApReceive(string apiPath = "api/v1/advertisement/ironsource/ap/receive")
    {
    }

    [Token(Token = "0x600A06A")]
    [Address(RVA = "0x46C4358", Offset = "0x46C4358", VA = "0x46C4358")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A06B")]
    [Address(RVA = "0x46C43E8", Offset = "0x46C43E8", VA = "0x46C43E8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A06C")]
    [Address(RVA = "0x46C43F4", Offset = "0x46C43F4", VA = "0x46C43F4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A06D")]
    [Address(RVA = "0x46C44C8", Offset = "0x46C44C8", VA = "0x46C44C8")]
    private void OnSuccess(string json)
    {
    }
  }
}
