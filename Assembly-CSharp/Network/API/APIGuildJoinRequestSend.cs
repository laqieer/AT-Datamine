// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestSend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CF9")]
  public class APIGuildJoinRequestSend
  {
    [Token(Token = "0x4007BC5")]
    public const string DefaultAPIPath = "api/v1/guild/join_request/send";
    [Token(Token = "0x4007BC9")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007BCA")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildJoinRequestSendResponse> onSuccess;
    [Token(Token = "0x4007BCB")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170020F1")]
    public APIGuildJoinRequestSendRequest Request
    {
      [Token(Token = "0x600AABB"), Address(RVA = "0x1919DC4", Offset = "0x1919DC4", VA = "0x1919DC4")] private get
      {
        return (APIGuildJoinRequestSendRequest) null;
      }
      [Token(Token = "0x600AABC"), Address(RVA = "0x1919DCC", Offset = "0x1919DCC", VA = "0x1919DCC")] set
      {
      }
    }

    [Token(Token = "0x170020F2")]
    public APIGuildJoinRequestSendResponse Response
    {
      [Token(Token = "0x600AABD"), Address(RVA = "0x1919DD4", Offset = "0x1919DD4", VA = "0x1919DD4")] get
      {
        return (APIGuildJoinRequestSendResponse) null;
      }
      [Token(Token = "0x600AABE"), Address(RVA = "0x1919DDC", Offset = "0x1919DDC", VA = "0x1919DDC")] private set
      {
      }
    }

    [Token(Token = "0x170020F3")]
    public int ResponseCode
    {
      [Token(Token = "0x600AABF"), Address(RVA = "0x1919DE4", Offset = "0x1919DE4", VA = "0x1919DE4")] get
      {
        return new int();
      }
      [Token(Token = "0x600AAC0"), Address(RVA = "0x1919DEC", Offset = "0x1919DEC", VA = "0x1919DEC")] private set
      {
      }
    }

    [Token(Token = "0x170020F4")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AAC1"), Address(RVA = "0x1919DF4", Offset = "0x1919DF4", VA = "0x1919DF4")] set
      {
      }
      [Token(Token = "0x600AAC2"), Address(RVA = "0x1919E10", Offset = "0x1919E10", VA = "0x1919E10")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AAC3")]
    [Address(RVA = "0x1919E2C", Offset = "0x1919E2C", VA = "0x1919E2C")]
    public APIGuildJoinRequestSend(string apiPath = "api/v1/guild/join_request/send")
    {
    }

    [Token(Token = "0x600AAC4")]
    [Address(RVA = "0x1919EC4", Offset = "0x1919EC4", VA = "0x1919EC4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AAC5")]
    [Address(RVA = "0x1919F2C", Offset = "0x1919F2C", VA = "0x1919F2C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AAC6")]
    [Address(RVA = "0x1919F38", Offset = "0x1919F38", VA = "0x1919F38")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AAC7")]
    [Address(RVA = "0x191A00C", Offset = "0x191A00C", VA = "0x191A00C")]
    private void OnSuccess(string json)
    {
    }
  }
}
