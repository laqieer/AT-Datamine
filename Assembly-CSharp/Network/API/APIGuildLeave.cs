// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildLeave
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D01")]
  public class APIGuildLeave
  {
    [Token(Token = "0x4007BE1")]
    public const string DefaultAPIPath = "api/v1/guild/leave";
    [Token(Token = "0x4007BE5")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007BE6")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildLeaveResponse> onSuccess;
    [Token(Token = "0x4007BE7")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002100")]
    public APIGuildLeaveRequest Request
    {
      [Token(Token = "0x600AAEA"), Address(RVA = "0x1A41324", Offset = "0x1A41324", VA = "0x1A41324")] private get
      {
        return (APIGuildLeaveRequest) null;
      }
      [Token(Token = "0x600AAEB"), Address(RVA = "0x1A4132C", Offset = "0x1A4132C", VA = "0x1A4132C")] set
      {
      }
    }

    [Token(Token = "0x17002101")]
    public APIGuildLeaveResponse Response
    {
      [Token(Token = "0x600AAEC"), Address(RVA = "0x1A41334", Offset = "0x1A41334", VA = "0x1A41334")] get
      {
        return (APIGuildLeaveResponse) null;
      }
      [Token(Token = "0x600AAED"), Address(RVA = "0x1A4133C", Offset = "0x1A4133C", VA = "0x1A4133C")] private set
      {
      }
    }

    [Token(Token = "0x17002102")]
    public int ResponseCode
    {
      [Token(Token = "0x600AAEE"), Address(RVA = "0x1A41344", Offset = "0x1A41344", VA = "0x1A41344")] get
      {
        return new int();
      }
      [Token(Token = "0x600AAEF"), Address(RVA = "0x1A4134C", Offset = "0x1A4134C", VA = "0x1A4134C")] private set
      {
      }
    }

    [Token(Token = "0x17002103")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AAF0"), Address(RVA = "0x1A41354", Offset = "0x1A41354", VA = "0x1A41354")] set
      {
      }
      [Token(Token = "0x600AAF1"), Address(RVA = "0x1A41370", Offset = "0x1A41370", VA = "0x1A41370")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AAF2")]
    [Address(RVA = "0x1A4138C", Offset = "0x1A4138C", VA = "0x1A4138C")]
    public APIGuildLeave(string apiPath = "api/v1/guild/leave")
    {
    }

    [Token(Token = "0x600AAF3")]
    [Address(RVA = "0x1A41424", Offset = "0x1A41424", VA = "0x1A41424")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AAF4")]
    [Address(RVA = "0x1A414B4", Offset = "0x1A414B4", VA = "0x1A414B4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AAF5")]
    [Address(RVA = "0x1A414C0", Offset = "0x1A414C0", VA = "0x1A414C0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AAF6")]
    [Address(RVA = "0x1A41594", Offset = "0x1A41594", VA = "0x1A41594")]
    private void OnSuccess(string json)
    {
    }
  }
}
