// Decompiled with JetBrains decompiler
// Type: Network.API.APIOfficial_messageRead
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D7D")]
  public class APIOfficial_messageRead
  {
    [Token(Token = "0x4007DEE")]
    public const string DefaultAPIPath = "api/v1/official_message/read";
    [Token(Token = "0x4007DF2")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007DF3")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIOfficial_messageReadResponse> onSuccess;
    [Token(Token = "0x4007DF4")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700222C")]
    public APIOfficial_messageReadRequest Request
    {
      [Token(Token = "0x600AE06"), Address(RVA = "0x1A4BAB8", Offset = "0x1A4BAB8", VA = "0x1A4BAB8")] private get
      {
        return (APIOfficial_messageReadRequest) null;
      }
      [Token(Token = "0x600AE07"), Address(RVA = "0x1A4BAC0", Offset = "0x1A4BAC0", VA = "0x1A4BAC0")] set
      {
      }
    }

    [Token(Token = "0x1700222D")]
    public APIOfficial_messageReadResponse Response
    {
      [Token(Token = "0x600AE08"), Address(RVA = "0x1A4BAC8", Offset = "0x1A4BAC8", VA = "0x1A4BAC8")] get
      {
        return (APIOfficial_messageReadResponse) null;
      }
      [Token(Token = "0x600AE09"), Address(RVA = "0x1A4BAD0", Offset = "0x1A4BAD0", VA = "0x1A4BAD0")] private set
      {
      }
    }

    [Token(Token = "0x1700222E")]
    public int ResponseCode
    {
      [Token(Token = "0x600AE0A"), Address(RVA = "0x1A4BAD8", Offset = "0x1A4BAD8", VA = "0x1A4BAD8")] get
      {
        return new int();
      }
      [Token(Token = "0x600AE0B"), Address(RVA = "0x1A4BAE0", Offset = "0x1A4BAE0", VA = "0x1A4BAE0")] private set
      {
      }
    }

    [Token(Token = "0x1700222F")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AE0C"), Address(RVA = "0x1A4BAE8", Offset = "0x1A4BAE8", VA = "0x1A4BAE8")] set
      {
      }
      [Token(Token = "0x600AE0D"), Address(RVA = "0x1A4BB04", Offset = "0x1A4BB04", VA = "0x1A4BB04")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AE0E")]
    [Address(RVA = "0x1A4BB20", Offset = "0x1A4BB20", VA = "0x1A4BB20")]
    public APIOfficial_messageRead(string apiPath = "api/v1/official_message/read")
    {
    }

    [Token(Token = "0x600AE0F")]
    [Address(RVA = "0x1A4BBB8", Offset = "0x1A4BBB8", VA = "0x1A4BBB8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AE10")]
    [Address(RVA = "0x1A4BC48", Offset = "0x1A4BC48", VA = "0x1A4BC48")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AE11")]
    [Address(RVA = "0x1A4BC54", Offset = "0x1A4BC54", VA = "0x1A4BC54")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AE12")]
    [Address(RVA = "0x1A4BD28", Offset = "0x1A4BD28", VA = "0x1A4BD28")]
    private void OnSuccess(string json)
    {
    }
  }
}
