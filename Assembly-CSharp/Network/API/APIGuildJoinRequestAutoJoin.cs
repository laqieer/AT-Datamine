// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestAutoJoin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CE9")]
  public class APIGuildJoinRequestAutoJoin
  {
    [Token(Token = "0x4007B91")]
    public const string DefaultAPIPath = "api/v1/guild/join_request/auto_join";
    [Token(Token = "0x4007B95")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007B96")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildJoinRequestAutoJoinResponse> onSuccess;
    [Token(Token = "0x4007B97")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170020D6")]
    public APIGuildJoinRequestAutoJoinRequest Request
    {
      [Token(Token = "0x600AA60"), Address(RVA = "0x191887C", Offset = "0x191887C", VA = "0x191887C")] private get
      {
        return (APIGuildJoinRequestAutoJoinRequest) null;
      }
      [Token(Token = "0x600AA61"), Address(RVA = "0x1918884", Offset = "0x1918884", VA = "0x1918884")] set
      {
      }
    }

    [Token(Token = "0x170020D7")]
    public APIGuildJoinRequestAutoJoinResponse Response
    {
      [Token(Token = "0x600AA62"), Address(RVA = "0x191888C", Offset = "0x191888C", VA = "0x191888C")] get
      {
        return (APIGuildJoinRequestAutoJoinResponse) null;
      }
      [Token(Token = "0x600AA63"), Address(RVA = "0x1918894", Offset = "0x1918894", VA = "0x1918894")] private set
      {
      }
    }

    [Token(Token = "0x170020D8")]
    public int ResponseCode
    {
      [Token(Token = "0x600AA64"), Address(RVA = "0x191889C", Offset = "0x191889C", VA = "0x191889C")] get
      {
        return new int();
      }
      [Token(Token = "0x600AA65"), Address(RVA = "0x19188A4", Offset = "0x19188A4", VA = "0x19188A4")] private set
      {
      }
    }

    [Token(Token = "0x170020D9")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AA66"), Address(RVA = "0x19188AC", Offset = "0x19188AC", VA = "0x19188AC")] set
      {
      }
      [Token(Token = "0x600AA67"), Address(RVA = "0x19188C8", Offset = "0x19188C8", VA = "0x19188C8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AA68")]
    [Address(RVA = "0x19188E4", Offset = "0x19188E4", VA = "0x19188E4")]
    public APIGuildJoinRequestAutoJoin(string apiPath = "api/v1/guild/join_request/auto_join")
    {
    }

    [Token(Token = "0x600AA69")]
    [Address(RVA = "0x191897C", Offset = "0x191897C", VA = "0x191897C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AA6A")]
    [Address(RVA = "0x1918A0C", Offset = "0x1918A0C", VA = "0x1918A0C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AA6B")]
    [Address(RVA = "0x1918A18", Offset = "0x1918A18", VA = "0x1918A18")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AA6C")]
    [Address(RVA = "0x1918AEC", Offset = "0x1918AEC", VA = "0x1918AEC")]
    private void OnSuccess(string json)
    {
    }
  }
}
