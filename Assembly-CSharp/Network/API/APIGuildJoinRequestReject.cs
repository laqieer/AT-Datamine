// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestReject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CF5")]
  public class APIGuildJoinRequestReject
  {
    [Token(Token = "0x4007BB8")]
    public const string DefaultAPIPath = "api/v1/guild/join_request/reject";
    [Token(Token = "0x4007BBC")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007BBD")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildJoinRequestRejectResponse> onSuccess;
    [Token(Token = "0x4007BBE")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170020EA")]
    public APIGuildJoinRequestRejectRequest Request
    {
      [Token(Token = "0x600AAA4"), Address(RVA = "0x1919870", Offset = "0x1919870", VA = "0x1919870")] private get
      {
        return (APIGuildJoinRequestRejectRequest) null;
      }
      [Token(Token = "0x600AAA5"), Address(RVA = "0x1919878", Offset = "0x1919878", VA = "0x1919878")] set
      {
      }
    }

    [Token(Token = "0x170020EB")]
    public APIGuildJoinRequestRejectResponse Response
    {
      [Token(Token = "0x600AAA6"), Address(RVA = "0x1919880", Offset = "0x1919880", VA = "0x1919880")] get
      {
        return (APIGuildJoinRequestRejectResponse) null;
      }
      [Token(Token = "0x600AAA7"), Address(RVA = "0x1919888", Offset = "0x1919888", VA = "0x1919888")] private set
      {
      }
    }

    [Token(Token = "0x170020EC")]
    public int ResponseCode
    {
      [Token(Token = "0x600AAA8"), Address(RVA = "0x1919890", Offset = "0x1919890", VA = "0x1919890")] get
      {
        return new int();
      }
      [Token(Token = "0x600AAA9"), Address(RVA = "0x1919898", Offset = "0x1919898", VA = "0x1919898")] private set
      {
      }
    }

    [Token(Token = "0x170020ED")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AAAA"), Address(RVA = "0x19198A0", Offset = "0x19198A0", VA = "0x19198A0")] set
      {
      }
      [Token(Token = "0x600AAAB"), Address(RVA = "0x19198BC", Offset = "0x19198BC", VA = "0x19198BC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AAAC")]
    [Address(RVA = "0x19198D8", Offset = "0x19198D8", VA = "0x19198D8")]
    public APIGuildJoinRequestReject(string apiPath = "api/v1/guild/join_request/reject")
    {
    }

    [Token(Token = "0x600AAAD")]
    [Address(RVA = "0x1919970", Offset = "0x1919970", VA = "0x1919970")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AAAE")]
    [Address(RVA = "0x1919A00", Offset = "0x1919A00", VA = "0x1919A00")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AAAF")]
    [Address(RVA = "0x1919A0C", Offset = "0x1919A0C", VA = "0x1919A0C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AAB0")]
    [Address(RVA = "0x1919AE0", Offset = "0x1919AE0", VA = "0x1919AE0")]
    private void OnSuccess(string json)
    {
    }
  }
}
