// Decompiled with JetBrains decompiler
// Type: Network.API.APIChargeLimit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BC5")]
  public class APIChargeLimit
  {
    [Token(Token = "0x40076FF")]
    public const string DefaultAPIPath = "api/charge/v2/currency/charge_limit";
    [Token(Token = "0x4007703")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007704")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIChargeLimitResponse> onSuccess;
    [Token(Token = "0x4007705")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E3A")]
    public APIChargeLimitRequest Request
    {
      [Token(Token = "0x600A334"), Address(RVA = "0x46CDE9C", Offset = "0x46CDE9C", VA = "0x46CDE9C")] private get
      {
        return (APIChargeLimitRequest) null;
      }
      [Token(Token = "0x600A335"), Address(RVA = "0x46CDEA4", Offset = "0x46CDEA4", VA = "0x46CDEA4")] set
      {
      }
    }

    [Token(Token = "0x17001E3B")]
    public APIChargeLimitResponse Response
    {
      [Token(Token = "0x600A336"), Address(RVA = "0x46CDEAC", Offset = "0x46CDEAC", VA = "0x46CDEAC")] get
      {
        return (APIChargeLimitResponse) null;
      }
      [Token(Token = "0x600A337"), Address(RVA = "0x46CDEB4", Offset = "0x46CDEB4", VA = "0x46CDEB4")] private set
      {
      }
    }

    [Token(Token = "0x17001E3C")]
    public int ResponseCode
    {
      [Token(Token = "0x600A338"), Address(RVA = "0x46CDEBC", Offset = "0x46CDEBC", VA = "0x46CDEBC")] get
      {
        return new int();
      }
      [Token(Token = "0x600A339"), Address(RVA = "0x46CDEC4", Offset = "0x46CDEC4", VA = "0x46CDEC4")] private set
      {
      }
    }

    [Token(Token = "0x17001E3D")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A33A"), Address(RVA = "0x46CDECC", Offset = "0x46CDECC", VA = "0x46CDECC")] set
      {
      }
      [Token(Token = "0x600A33B"), Address(RVA = "0x46CDEE8", Offset = "0x46CDEE8", VA = "0x46CDEE8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A33C")]
    [Address(RVA = "0x46CDF04", Offset = "0x46CDF04", VA = "0x46CDF04")]
    public APIChargeLimit(string apiPath = "api/charge/v2/currency/charge_limit")
    {
    }

    [Token(Token = "0x600A33D")]
    [Address(RVA = "0x46CDF9C", Offset = "0x46CDF9C", VA = "0x46CDF9C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A33E")]
    [Address(RVA = "0x46CE02C", Offset = "0x46CE02C", VA = "0x46CE02C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A33F")]
    [Address(RVA = "0x46CE038", Offset = "0x46CE038", VA = "0x46CE038")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A340")]
    [Address(RVA = "0x46CE10C", Offset = "0x46CE10C", VA = "0x46CE10C")]
    private void OnSuccess(string json)
    {
    }
  }
}
