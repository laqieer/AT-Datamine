// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestCancel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CED")]
  public class APIGuildJoinRequestCancel
  {
    [Token(Token = "0x4007B9D")]
    public const string DefaultAPIPath = "api/v1/guild/join_request/cancel";
    [Token(Token = "0x4007BA1")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007BA2")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildJoinRequestCancelResponse> onSuccess;
    [Token(Token = "0x4007BA3")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170020DC")]
    public APIGuildJoinRequestCancelRequest Request
    {
      [Token(Token = "0x600AA76"), Address(RVA = "0x1918DC8", Offset = "0x1918DC8", VA = "0x1918DC8")] private get
      {
        return (APIGuildJoinRequestCancelRequest) null;
      }
      [Token(Token = "0x600AA77"), Address(RVA = "0x1918DD0", Offset = "0x1918DD0", VA = "0x1918DD0")] set
      {
      }
    }

    [Token(Token = "0x170020DD")]
    public APIGuildJoinRequestCancelResponse Response
    {
      [Token(Token = "0x600AA78"), Address(RVA = "0x1918DD8", Offset = "0x1918DD8", VA = "0x1918DD8")] get
      {
        return (APIGuildJoinRequestCancelResponse) null;
      }
      [Token(Token = "0x600AA79"), Address(RVA = "0x1918DE0", Offset = "0x1918DE0", VA = "0x1918DE0")] private set
      {
      }
    }

    [Token(Token = "0x170020DE")]
    public int ResponseCode
    {
      [Token(Token = "0x600AA7A"), Address(RVA = "0x1918DE8", Offset = "0x1918DE8", VA = "0x1918DE8")] get
      {
        return new int();
      }
      [Token(Token = "0x600AA7B"), Address(RVA = "0x1918DF0", Offset = "0x1918DF0", VA = "0x1918DF0")] private set
      {
      }
    }

    [Token(Token = "0x170020DF")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AA7C"), Address(RVA = "0x1918DF8", Offset = "0x1918DF8", VA = "0x1918DF8")] set
      {
      }
      [Token(Token = "0x600AA7D"), Address(RVA = "0x1918E14", Offset = "0x1918E14", VA = "0x1918E14")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AA7E")]
    [Address(RVA = "0x1918E30", Offset = "0x1918E30", VA = "0x1918E30")]
    public APIGuildJoinRequestCancel(string apiPath = "api/v1/guild/join_request/cancel")
    {
    }

    [Token(Token = "0x600AA7F")]
    [Address(RVA = "0x1918EC8", Offset = "0x1918EC8", VA = "0x1918EC8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AA80")]
    [Address(RVA = "0x1918F58", Offset = "0x1918F58", VA = "0x1918F58")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AA81")]
    [Address(RVA = "0x1918F64", Offset = "0x1918F64", VA = "0x1918F64")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AA82")]
    [Address(RVA = "0x1919038", Offset = "0x1919038", VA = "0x1919038")]
    private void OnSuccess(string json)
    {
    }
  }
}
