// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildChatPost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CB5")]
  public class APIGuildChatPost
  {
    [Token(Token = "0x4007AC2")]
    public const string DefaultAPIPath = "api/v1/guild/chat/post";
    [Token(Token = "0x4007AC6")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007AC7")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildChatPostResponse> onSuccess;
    [Token(Token = "0x4007AC8")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002065")]
    public APIGuildChatPostRequest Request
    {
      [Token(Token = "0x600A91F"), Address(RVA = "0x1914298", Offset = "0x1914298", VA = "0x1914298")] private get
      {
        return (APIGuildChatPostRequest) null;
      }
      [Token(Token = "0x600A920"), Address(RVA = "0x19142A0", Offset = "0x19142A0", VA = "0x19142A0")] set
      {
      }
    }

    [Token(Token = "0x17002066")]
    public APIGuildChatPostResponse Response
    {
      [Token(Token = "0x600A921"), Address(RVA = "0x19142A8", Offset = "0x19142A8", VA = "0x19142A8")] get
      {
        return (APIGuildChatPostResponse) null;
      }
      [Token(Token = "0x600A922"), Address(RVA = "0x19142B0", Offset = "0x19142B0", VA = "0x19142B0")] private set
      {
      }
    }

    [Token(Token = "0x17002067")]
    public int ResponseCode
    {
      [Token(Token = "0x600A923"), Address(RVA = "0x19142B8", Offset = "0x19142B8", VA = "0x19142B8")] get
      {
        return new int();
      }
      [Token(Token = "0x600A924"), Address(RVA = "0x19142C0", Offset = "0x19142C0", VA = "0x19142C0")] private set
      {
      }
    }

    [Token(Token = "0x17002068")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A925"), Address(RVA = "0x19142C8", Offset = "0x19142C8", VA = "0x19142C8")] set
      {
      }
      [Token(Token = "0x600A926"), Address(RVA = "0x19142E4", Offset = "0x19142E4", VA = "0x19142E4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A927")]
    [Address(RVA = "0x1914300", Offset = "0x1914300", VA = "0x1914300")]
    public APIGuildChatPost(string apiPath = "api/v1/guild/chat/post")
    {
    }

    [Token(Token = "0x600A928")]
    [Address(RVA = "0x1914398", Offset = "0x1914398", VA = "0x1914398")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A929")]
    [Address(RVA = "0x1914428", Offset = "0x1914428", VA = "0x1914428")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A92A")]
    [Address(RVA = "0x1914434", Offset = "0x1914434", VA = "0x1914434")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A92B")]
    [Address(RVA = "0x1914508", Offset = "0x1914508", VA = "0x1914508")]
    private void OnSuccess(string json)
    {
    }
  }
}
