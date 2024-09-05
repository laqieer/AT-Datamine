// Decompiled with JetBrains decompiler
// Type: Network.API.APIServiceState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E0D")]
  public class APIServiceState
  {
    [Token(Token = "0x400809F")]
    public const string DefaultAPIPath = "pass/service/state";
    [Token(Token = "0x40080A3")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40080A4")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIServiceStateResponse> onSuccess;
    [Token(Token = "0x40080A5")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170023B3")]
    public APIServiceStateRequest Request
    {
      [Token(Token = "0x600B1CD"), Address(RVA = "0x22DDD24", Offset = "0x22DDD24", VA = "0x22DDD24")] private get
      {
        return (APIServiceStateRequest) null;
      }
      [Token(Token = "0x600B1CE"), Address(RVA = "0x22DDD2C", Offset = "0x22DDD2C", VA = "0x22DDD2C")] set
      {
      }
    }

    [Token(Token = "0x170023B4")]
    public APIServiceStateResponse Response
    {
      [Token(Token = "0x600B1CF"), Address(RVA = "0x22DDD34", Offset = "0x22DDD34", VA = "0x22DDD34")] get
      {
        return (APIServiceStateResponse) null;
      }
      [Token(Token = "0x600B1D0"), Address(RVA = "0x22DDD3C", Offset = "0x22DDD3C", VA = "0x22DDD3C")] private set
      {
      }
    }

    [Token(Token = "0x170023B5")]
    public int ResponseCode
    {
      [Token(Token = "0x600B1D1"), Address(RVA = "0x22DDD44", Offset = "0x22DDD44", VA = "0x22DDD44")] get
      {
        return new int();
      }
      [Token(Token = "0x600B1D2"), Address(RVA = "0x22DDD4C", Offset = "0x22DDD4C", VA = "0x22DDD4C")] private set
      {
      }
    }

    [Token(Token = "0x170023B6")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B1D3"), Address(RVA = "0x22DDD54", Offset = "0x22DDD54", VA = "0x22DDD54")] set
      {
      }
      [Token(Token = "0x600B1D4"), Address(RVA = "0x22DDD70", Offset = "0x22DDD70", VA = "0x22DDD70")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B1D5")]
    [Address(RVA = "0x22DDD8C", Offset = "0x22DDD8C", VA = "0x22DDD8C")]
    public APIServiceState(string apiPath = "pass/service/state")
    {
    }

    [Token(Token = "0x600B1D6")]
    [Address(RVA = "0x22DDE24", Offset = "0x22DDE24", VA = "0x22DDE24")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B1D7")]
    [Address(RVA = "0x22DDEB4", Offset = "0x22DDEB4", VA = "0x22DDEB4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B1D8")]
    [Address(RVA = "0x22DDEC0", Offset = "0x22DDEC0", VA = "0x22DDEC0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B1D9")]
    [Address(RVA = "0x22DDF94", Offset = "0x22DDF94", VA = "0x22DDF94")]
    private void OnSuccess(string json)
    {
    }
  }
}
