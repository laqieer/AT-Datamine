// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildMemberList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D05")]
  public class APIGuildMemberList
  {
    [Token(Token = "0x4007BEE")]
    public const string DefaultAPIPath = "api/v1/guild/member/list";
    [Token(Token = "0x4007BF2")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007BF3")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildMemberListResponse> onSuccess;
    [Token(Token = "0x4007BF4")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002107")]
    public APIGuildMemberListRequest Request
    {
      [Token(Token = "0x600AB01"), Address(RVA = "0x1A41878", Offset = "0x1A41878", VA = "0x1A41878")] private get
      {
        return (APIGuildMemberListRequest) null;
      }
      [Token(Token = "0x600AB02"), Address(RVA = "0x1A41880", Offset = "0x1A41880", VA = "0x1A41880")] set
      {
      }
    }

    [Token(Token = "0x17002108")]
    public APIGuildMemberListResponse Response
    {
      [Token(Token = "0x600AB03"), Address(RVA = "0x1A41888", Offset = "0x1A41888", VA = "0x1A41888")] get
      {
        return (APIGuildMemberListResponse) null;
      }
      [Token(Token = "0x600AB04"), Address(RVA = "0x1A41890", Offset = "0x1A41890", VA = "0x1A41890")] private set
      {
      }
    }

    [Token(Token = "0x17002109")]
    public int ResponseCode
    {
      [Token(Token = "0x600AB05"), Address(RVA = "0x1A41898", Offset = "0x1A41898", VA = "0x1A41898")] get
      {
        return new int();
      }
      [Token(Token = "0x600AB06"), Address(RVA = "0x1A418A0", Offset = "0x1A418A0", VA = "0x1A418A0")] private set
      {
      }
    }

    [Token(Token = "0x1700210A")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AB07"), Address(RVA = "0x1A418A8", Offset = "0x1A418A8", VA = "0x1A418A8")] set
      {
      }
      [Token(Token = "0x600AB08"), Address(RVA = "0x1A418C4", Offset = "0x1A418C4", VA = "0x1A418C4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AB09")]
    [Address(RVA = "0x1A418E0", Offset = "0x1A418E0", VA = "0x1A418E0")]
    public APIGuildMemberList(string apiPath = "api/v1/guild/member/list")
    {
    }

    [Token(Token = "0x600AB0A")]
    [Address(RVA = "0x1A41978", Offset = "0x1A41978", VA = "0x1A41978")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AB0B")]
    [Address(RVA = "0x1A41A08", Offset = "0x1A41A08", VA = "0x1A41A08")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AB0C")]
    [Address(RVA = "0x1A41A14", Offset = "0x1A41A14", VA = "0x1A41A14")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AB0D")]
    [Address(RVA = "0x1A41AE8", Offset = "0x1A41AE8", VA = "0x1A41AE8")]
    private void OnSuccess(string json)
    {
    }
  }
}
