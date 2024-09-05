// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildSearch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D21")]
  public class APIGuildSearch
  {
    [Token(Token = "0x4007C72")]
    public const string DefaultAPIPath = "api/v1/guild/search";
    [Token(Token = "0x4007C76")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007C77")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildSearchResponse> onSuccess;
    [Token(Token = "0x4007C78")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700214A")]
    public APIGuildSearchRequest Request
    {
      [Token(Token = "0x600ABB4"), Address(RVA = "0x1A43E54", Offset = "0x1A43E54", VA = "0x1A43E54")] private get
      {
        return (APIGuildSearchRequest) null;
      }
      [Token(Token = "0x600ABB5"), Address(RVA = "0x1A43E5C", Offset = "0x1A43E5C", VA = "0x1A43E5C")] set
      {
      }
    }

    [Token(Token = "0x1700214B")]
    public APIGuildSearchResponse Response
    {
      [Token(Token = "0x600ABB6"), Address(RVA = "0x1A43E64", Offset = "0x1A43E64", VA = "0x1A43E64")] get
      {
        return (APIGuildSearchResponse) null;
      }
      [Token(Token = "0x600ABB7"), Address(RVA = "0x1A43E6C", Offset = "0x1A43E6C", VA = "0x1A43E6C")] private set
      {
      }
    }

    [Token(Token = "0x1700214C")]
    public int ResponseCode
    {
      [Token(Token = "0x600ABB8"), Address(RVA = "0x1A43E74", Offset = "0x1A43E74", VA = "0x1A43E74")] get
      {
        return new int();
      }
      [Token(Token = "0x600ABB9"), Address(RVA = "0x1A43E7C", Offset = "0x1A43E7C", VA = "0x1A43E7C")] private set
      {
      }
    }

    [Token(Token = "0x1700214D")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600ABBA"), Address(RVA = "0x1A43E84", Offset = "0x1A43E84", VA = "0x1A43E84")] set
      {
      }
      [Token(Token = "0x600ABBB"), Address(RVA = "0x1A43EA0", Offset = "0x1A43EA0", VA = "0x1A43EA0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600ABBC")]
    [Address(RVA = "0x1A43EBC", Offset = "0x1A43EBC", VA = "0x1A43EBC")]
    public APIGuildSearch(string apiPath = "api/v1/guild/search")
    {
    }

    [Token(Token = "0x600ABBD")]
    [Address(RVA = "0x1A43F54", Offset = "0x1A43F54", VA = "0x1A43F54")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600ABBE")]
    [Address(RVA = "0x1A43FE4", Offset = "0x1A43FE4", VA = "0x1A43FE4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600ABBF")]
    [Address(RVA = "0x1A43FF0", Offset = "0x1A43FF0", VA = "0x1A43FF0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600ABC0")]
    [Address(RVA = "0x1A440C4", Offset = "0x1A440C4", VA = "0x1A440C4")]
    private void OnSuccess(string json)
    {
    }
  }
}
