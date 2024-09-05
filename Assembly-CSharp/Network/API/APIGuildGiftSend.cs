// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildGiftSend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CD1")]
  public class APIGuildGiftSend
  {
    [Token(Token = "0x4007B2B")]
    public const string DefaultAPIPath = "api/v1/guild/gift/send";
    [Token(Token = "0x4007B2F")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007B30")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildGiftSendResponse> onSuccess;
    [Token(Token = "0x4007B31")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170020A0")]
    public APIGuildGiftSendRequest Request
    {
      [Token(Token = "0x600A9CA"), Address(RVA = "0x1916824", Offset = "0x1916824", VA = "0x1916824")] private get
      {
        return (APIGuildGiftSendRequest) null;
      }
      [Token(Token = "0x600A9CB"), Address(RVA = "0x191682C", Offset = "0x191682C", VA = "0x191682C")] set
      {
      }
    }

    [Token(Token = "0x170020A1")]
    public APIGuildGiftSendResponse Response
    {
      [Token(Token = "0x600A9CC"), Address(RVA = "0x1916834", Offset = "0x1916834", VA = "0x1916834")] get
      {
        return (APIGuildGiftSendResponse) null;
      }
      [Token(Token = "0x600A9CD"), Address(RVA = "0x191683C", Offset = "0x191683C", VA = "0x191683C")] private set
      {
      }
    }

    [Token(Token = "0x170020A2")]
    public int ResponseCode
    {
      [Token(Token = "0x600A9CE"), Address(RVA = "0x1916844", Offset = "0x1916844", VA = "0x1916844")] get
      {
        return new int();
      }
      [Token(Token = "0x600A9CF"), Address(RVA = "0x191684C", Offset = "0x191684C", VA = "0x191684C")] private set
      {
      }
    }

    [Token(Token = "0x170020A3")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A9D0"), Address(RVA = "0x1916854", Offset = "0x1916854", VA = "0x1916854")] set
      {
      }
      [Token(Token = "0x600A9D1"), Address(RVA = "0x1916870", Offset = "0x1916870", VA = "0x1916870")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A9D2")]
    [Address(RVA = "0x191688C", Offset = "0x191688C", VA = "0x191688C")]
    public APIGuildGiftSend(string apiPath = "api/v1/guild/gift/send")
    {
    }

    [Token(Token = "0x600A9D3")]
    [Address(RVA = "0x1916924", Offset = "0x1916924", VA = "0x1916924")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A9D4")]
    [Address(RVA = "0x19169B4", Offset = "0x19169B4", VA = "0x19169B4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A9D5")]
    [Address(RVA = "0x19169C0", Offset = "0x19169C0", VA = "0x19169C0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A9D6")]
    [Address(RVA = "0x1916A94", Offset = "0x1916A94", VA = "0x1916A94")]
    private void OnSuccess(string json)
    {
    }
  }
}
