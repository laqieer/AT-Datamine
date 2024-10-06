// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestApprove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CE5")]
  public class APIGuildJoinRequestApprove
  {
    [Token(Token = "0x4007B82")]
    public const string DefaultAPIPath = "api/v1/guild/join_request/approve";
    [Token(Token = "0x4007B86")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007B87")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildJoinRequestApproveResponse> onSuccess;
    [Token(Token = "0x4007B88")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170020CD")]
    public APIGuildJoinRequestApproveRequest Request
    {
      [Token(Token = "0x600AA47"), Address(RVA = "0x1918318", Offset = "0x1918318", VA = "0x1918318")] private get
      {
        return (APIGuildJoinRequestApproveRequest) null;
      }
      [Token(Token = "0x600AA48"), Address(RVA = "0x1918320", Offset = "0x1918320", VA = "0x1918320")] set
      {
      }
    }

    [Token(Token = "0x170020CE")]
    public APIGuildJoinRequestApproveResponse Response
    {
      [Token(Token = "0x600AA49"), Address(RVA = "0x1918328", Offset = "0x1918328", VA = "0x1918328")] get
      {
        return (APIGuildJoinRequestApproveResponse) null;
      }
      [Token(Token = "0x600AA4A"), Address(RVA = "0x1918330", Offset = "0x1918330", VA = "0x1918330")] private set
      {
      }
    }

    [Token(Token = "0x170020CF")]
    public int ResponseCode
    {
      [Token(Token = "0x600AA4B"), Address(RVA = "0x1918338", Offset = "0x1918338", VA = "0x1918338")] get
      {
        return new int();
      }
      [Token(Token = "0x600AA4C"), Address(RVA = "0x1918340", Offset = "0x1918340", VA = "0x1918340")] private set
      {
      }
    }

    [Token(Token = "0x170020D0")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AA4D"), Address(RVA = "0x1918348", Offset = "0x1918348", VA = "0x1918348")] set
      {
      }
      [Token(Token = "0x600AA4E"), Address(RVA = "0x1918364", Offset = "0x1918364", VA = "0x1918364")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AA4F")]
    [Address(RVA = "0x1918380", Offset = "0x1918380", VA = "0x1918380")]
    public APIGuildJoinRequestApprove(string apiPath = "api/v1/guild/join_request/approve")
    {
    }

    [Token(Token = "0x600AA50")]
    [Address(RVA = "0x1918418", Offset = "0x1918418", VA = "0x1918418")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AA51")]
    [Address(RVA = "0x19184A8", Offset = "0x19184A8", VA = "0x19184A8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AA52")]
    [Address(RVA = "0x19184B4", Offset = "0x19184B4", VA = "0x19184B4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AA53")]
    [Address(RVA = "0x1918588", Offset = "0x1918588", VA = "0x1918588")]
    private void OnSuccess(string json)
    {
    }
  }
}
