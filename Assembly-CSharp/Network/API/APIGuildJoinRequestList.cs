// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CF1")]
  public class APIGuildJoinRequestList
  {
    [Token(Token = "0x4007BAA")]
    public const string DefaultAPIPath = "api/v1/guild/join_request/list";
    [Token(Token = "0x4007BAE")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007BAF")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildJoinRequestListResponse> onSuccess;
    [Token(Token = "0x4007BB0")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170020E3")]
    public APIGuildJoinRequestListRequest Request
    {
      [Token(Token = "0x600AA8D"), Address(RVA = "0x191931C", Offset = "0x191931C", VA = "0x191931C")] private get
      {
        return (APIGuildJoinRequestListRequest) null;
      }
      [Token(Token = "0x600AA8E"), Address(RVA = "0x1919324", Offset = "0x1919324", VA = "0x1919324")] set
      {
      }
    }

    [Token(Token = "0x170020E4")]
    public APIGuildJoinRequestListResponse Response
    {
      [Token(Token = "0x600AA8F"), Address(RVA = "0x191932C", Offset = "0x191932C", VA = "0x191932C")] get
      {
        return (APIGuildJoinRequestListResponse) null;
      }
      [Token(Token = "0x600AA90"), Address(RVA = "0x1919334", Offset = "0x1919334", VA = "0x1919334")] private set
      {
      }
    }

    [Token(Token = "0x170020E5")]
    public int ResponseCode
    {
      [Token(Token = "0x600AA91"), Address(RVA = "0x191933C", Offset = "0x191933C", VA = "0x191933C")] get
      {
        return new int();
      }
      [Token(Token = "0x600AA92"), Address(RVA = "0x1919344", Offset = "0x1919344", VA = "0x1919344")] private set
      {
      }
    }

    [Token(Token = "0x170020E6")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AA93"), Address(RVA = "0x191934C", Offset = "0x191934C", VA = "0x191934C")] set
      {
      }
      [Token(Token = "0x600AA94"), Address(RVA = "0x1919368", Offset = "0x1919368", VA = "0x1919368")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AA95")]
    [Address(RVA = "0x1919384", Offset = "0x1919384", VA = "0x1919384")]
    public APIGuildJoinRequestList(string apiPath = "api/v1/guild/join_request/list")
    {
    }

    [Token(Token = "0x600AA96")]
    [Address(RVA = "0x191941C", Offset = "0x191941C", VA = "0x191941C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AA97")]
    [Address(RVA = "0x19194AC", Offset = "0x19194AC", VA = "0x19194AC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AA98")]
    [Address(RVA = "0x19194B8", Offset = "0x19194B8", VA = "0x19194B8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AA99")]
    [Address(RVA = "0x191958C", Offset = "0x191958C", VA = "0x191958C")]
    private void OnSuccess(string json)
    {
    }
  }
}
