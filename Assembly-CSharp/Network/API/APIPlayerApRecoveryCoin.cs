// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerApRecoveryCoin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D81")]
  public class APIPlayerApRecoveryCoin
  {
    [Token(Token = "0x4007DFF")]
    public const string DefaultAPIPath = "api/v1/player/ap/recovery/coin";
    [Token(Token = "0x4007E03")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007E04")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerApRecoveryCoinResponse> onSuccess;
    [Token(Token = "0x4007E05")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002236")]
    public APIPlayerApRecoveryCoinRequest Request
    {
      [Token(Token = "0x600AE20"), Address(RVA = "0x1A4C024", Offset = "0x1A4C024", VA = "0x1A4C024")] private get
      {
        return (APIPlayerApRecoveryCoinRequest) null;
      }
      [Token(Token = "0x600AE21"), Address(RVA = "0x1A4C02C", Offset = "0x1A4C02C", VA = "0x1A4C02C")] set
      {
      }
    }

    [Token(Token = "0x17002237")]
    public APIPlayerApRecoveryCoinResponse Response
    {
      [Token(Token = "0x600AE22"), Address(RVA = "0x1A4C034", Offset = "0x1A4C034", VA = "0x1A4C034")] get
      {
        return (APIPlayerApRecoveryCoinResponse) null;
      }
      [Token(Token = "0x600AE23"), Address(RVA = "0x1A4C03C", Offset = "0x1A4C03C", VA = "0x1A4C03C")] private set
      {
      }
    }

    [Token(Token = "0x17002238")]
    public int ResponseCode
    {
      [Token(Token = "0x600AE24"), Address(RVA = "0x1A4C044", Offset = "0x1A4C044", VA = "0x1A4C044")] get
      {
        return new int();
      }
      [Token(Token = "0x600AE25"), Address(RVA = "0x1A4C04C", Offset = "0x1A4C04C", VA = "0x1A4C04C")] private set
      {
      }
    }

    [Token(Token = "0x17002239")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AE26"), Address(RVA = "0x1A4C054", Offset = "0x1A4C054", VA = "0x1A4C054")] set
      {
      }
      [Token(Token = "0x600AE27"), Address(RVA = "0x1A4C070", Offset = "0x1A4C070", VA = "0x1A4C070")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AE28")]
    [Address(RVA = "0x1A4C08C", Offset = "0x1A4C08C", VA = "0x1A4C08C")]
    public APIPlayerApRecoveryCoin(string apiPath = "api/v1/player/ap/recovery/coin")
    {
    }

    [Token(Token = "0x600AE29")]
    [Address(RVA = "0x1A4C124", Offset = "0x1A4C124", VA = "0x1A4C124")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AE2A")]
    [Address(RVA = "0x1A4C1B4", Offset = "0x1A4C1B4", VA = "0x1A4C1B4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AE2B")]
    [Address(RVA = "0x1A4C1C0", Offset = "0x1A4C1C0", VA = "0x1A4C1C0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AE2C")]
    [Address(RVA = "0x1A4C294", Offset = "0x1A4C294", VA = "0x1A4C294")]
    private void OnSuccess(string json)
    {
    }
  }
}
