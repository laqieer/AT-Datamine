// Decompiled with JetBrains decompiler
// Type: Network.API.APIPresentReceive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DC9")]
  public class APIPresentReceive
  {
    [Token(Token = "0x4007F43")]
    public const string DefaultAPIPath = "api/v1/present/receive";
    [Token(Token = "0x4007F47")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007F48")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPresentReceiveResponse> onSuccess;
    [Token(Token = "0x4007F49")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002307")]
    public APIPresentReceiveRequest Request
    {
      [Token(Token = "0x600B011"), Address(RVA = "0x1A52294", Offset = "0x1A52294", VA = "0x1A52294")] private get
      {
        return (APIPresentReceiveRequest) null;
      }
      [Token(Token = "0x600B012"), Address(RVA = "0x1A5229C", Offset = "0x1A5229C", VA = "0x1A5229C")] set
      {
      }
    }

    [Token(Token = "0x17002308")]
    public APIPresentReceiveResponse Response
    {
      [Token(Token = "0x600B013"), Address(RVA = "0x1A522A4", Offset = "0x1A522A4", VA = "0x1A522A4")] get
      {
        return (APIPresentReceiveResponse) null;
      }
      [Token(Token = "0x600B014"), Address(RVA = "0x1A522AC", Offset = "0x1A522AC", VA = "0x1A522AC")] private set
      {
      }
    }

    [Token(Token = "0x17002309")]
    public int ResponseCode
    {
      [Token(Token = "0x600B015"), Address(RVA = "0x1A522B4", Offset = "0x1A522B4", VA = "0x1A522B4")] get
      {
        return new int();
      }
      [Token(Token = "0x600B016"), Address(RVA = "0x1A522BC", Offset = "0x1A522BC", VA = "0x1A522BC")] private set
      {
      }
    }

    [Token(Token = "0x1700230A")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B017"), Address(RVA = "0x1A522C4", Offset = "0x1A522C4", VA = "0x1A522C4")] set
      {
      }
      [Token(Token = "0x600B018"), Address(RVA = "0x1A522E0", Offset = "0x1A522E0", VA = "0x1A522E0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B019")]
    [Address(RVA = "0x1A522FC", Offset = "0x1A522FC", VA = "0x1A522FC")]
    public APIPresentReceive(string apiPath = "api/v1/present/receive")
    {
    }

    [Token(Token = "0x600B01A")]
    [Address(RVA = "0x1A52394", Offset = "0x1A52394", VA = "0x1A52394")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B01B")]
    [Address(RVA = "0x1A52424", Offset = "0x1A52424", VA = "0x1A52424")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B01C")]
    [Address(RVA = "0x1A52430", Offset = "0x1A52430", VA = "0x1A52430")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B01D")]
    [Address(RVA = "0x1A52504", Offset = "0x1A52504", VA = "0x1A52504")]
    private void OnSuccess(string json)
    {
    }
  }
}
