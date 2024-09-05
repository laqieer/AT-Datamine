// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C61")]
  public class APIFriendList
  {
    [Token(Token = "0x4007984")]
    public const string DefaultAPIPath = "api/v1/friend/list";
    [Token(Token = "0x4007988")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007989")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIFriendListResponse> onSuccess;
    [Token(Token = "0x400798A")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001FB2")]
    public APIFriendListRequest Request
    {
      [Token(Token = "0x600A71C"), Address(RVA = "0x190D1B4", Offset = "0x190D1B4", VA = "0x190D1B4")] private get
      {
        return (APIFriendListRequest) null;
      }
      [Token(Token = "0x600A71D"), Address(RVA = "0x190D1BC", Offset = "0x190D1BC", VA = "0x190D1BC")] set
      {
      }
    }

    [Token(Token = "0x17001FB3")]
    public APIFriendListResponse Response
    {
      [Token(Token = "0x600A71E"), Address(RVA = "0x190D1C4", Offset = "0x190D1C4", VA = "0x190D1C4")] get
      {
        return (APIFriendListResponse) null;
      }
      [Token(Token = "0x600A71F"), Address(RVA = "0x190D1CC", Offset = "0x190D1CC", VA = "0x190D1CC")] private set
      {
      }
    }

    [Token(Token = "0x17001FB4")]
    public int ResponseCode
    {
      [Token(Token = "0x600A720"), Address(RVA = "0x190D1D4", Offset = "0x190D1D4", VA = "0x190D1D4")] get
      {
        return new int();
      }
      [Token(Token = "0x600A721"), Address(RVA = "0x190D1DC", Offset = "0x190D1DC", VA = "0x190D1DC")] private set
      {
      }
    }

    [Token(Token = "0x17001FB5")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A722"), Address(RVA = "0x190D1E4", Offset = "0x190D1E4", VA = "0x190D1E4")] set
      {
      }
      [Token(Token = "0x600A723"), Address(RVA = "0x190D200", Offset = "0x190D200", VA = "0x190D200")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A724")]
    [Address(RVA = "0x190D21C", Offset = "0x190D21C", VA = "0x190D21C")]
    public APIFriendList(string apiPath = "api/v1/friend/list")
    {
    }

    [Token(Token = "0x600A725")]
    [Address(RVA = "0x190D2B4", Offset = "0x190D2B4", VA = "0x190D2B4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A726")]
    [Address(RVA = "0x190D344", Offset = "0x190D344", VA = "0x190D344")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A727")]
    [Address(RVA = "0x190D350", Offset = "0x190D350", VA = "0x190D350")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A728")]
    [Address(RVA = "0x190D424", Offset = "0x190D424", VA = "0x190D424")]
    private void OnSuccess(string json)
    {
    }
  }
}
