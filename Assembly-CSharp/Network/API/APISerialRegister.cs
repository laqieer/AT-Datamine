// Decompiled with JetBrains decompiler
// Type: Network.API.APISerialRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E09")]
  public class APISerialRegister
  {
    [Token(Token = "0x4008093")]
    public const string DefaultAPIPath = "api/v1/serial/register";
    [Token(Token = "0x4008097")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008098")]
    [FieldOffset(Offset = "0x30")]
    public Action<APISerialRegisterResponse> onSuccess;
    [Token(Token = "0x4008099")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170023AC")]
    public APISerialRegisterRequest Request
    {
      [Token(Token = "0x600B1B6"), Address(RVA = "0x22DD7D0", Offset = "0x22DD7D0", VA = "0x22DD7D0")] private get
      {
        return (APISerialRegisterRequest) null;
      }
      [Token(Token = "0x600B1B7"), Address(RVA = "0x22DD7D8", Offset = "0x22DD7D8", VA = "0x22DD7D8")] set
      {
      }
    }

    [Token(Token = "0x170023AD")]
    public APISerialRegisterResponse Response
    {
      [Token(Token = "0x600B1B8"), Address(RVA = "0x22DD7E0", Offset = "0x22DD7E0", VA = "0x22DD7E0")] get
      {
        return (APISerialRegisterResponse) null;
      }
      [Token(Token = "0x600B1B9"), Address(RVA = "0x22DD7E8", Offset = "0x22DD7E8", VA = "0x22DD7E8")] private set
      {
      }
    }

    [Token(Token = "0x170023AE")]
    public int ResponseCode
    {
      [Token(Token = "0x600B1BA"), Address(RVA = "0x22DD7F0", Offset = "0x22DD7F0", VA = "0x22DD7F0")] get
      {
        return new int();
      }
      [Token(Token = "0x600B1BB"), Address(RVA = "0x22DD7F8", Offset = "0x22DD7F8", VA = "0x22DD7F8")] private set
      {
      }
    }

    [Token(Token = "0x170023AF")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B1BC"), Address(RVA = "0x22DD800", Offset = "0x22DD800", VA = "0x22DD800")] set
      {
      }
      [Token(Token = "0x600B1BD"), Address(RVA = "0x22DD81C", Offset = "0x22DD81C", VA = "0x22DD81C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B1BE")]
    [Address(RVA = "0x22DD838", Offset = "0x22DD838", VA = "0x22DD838")]
    public APISerialRegister(string apiPath = "api/v1/serial/register")
    {
    }

    [Token(Token = "0x600B1BF")]
    [Address(RVA = "0x22DD8D0", Offset = "0x22DD8D0", VA = "0x22DD8D0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B1C0")]
    [Address(RVA = "0x22DD960", Offset = "0x22DD960", VA = "0x22DD960")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B1C1")]
    [Address(RVA = "0x22DD96C", Offset = "0x22DD96C", VA = "0x22DD96C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B1C2")]
    [Address(RVA = "0x22DDA40", Offset = "0x22DDA40", VA = "0x22DDA40")]
    private void OnSuccess(string json)
    {
    }
  }
}
