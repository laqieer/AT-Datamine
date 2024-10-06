// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildInfoGetResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CDC")]
  [Serializable]
  public class APIGuildInfoGetResponse
  {
    [Token(Token = "0x4007B58")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GuildSearchResultType guild;
    [Token(Token = "0x4007B59")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildJoinRequestType join_request;

    [Token(Token = "0x170020BB")]
    public GuildSearchResultType Guild
    {
      [Token(Token = "0x600AA14"), Address(RVA = "0x1917848", Offset = "0x1917848", VA = "0x1917848")] get
      {
        return (GuildSearchResultType) null;
      }
    }

    [Token(Token = "0x170020BC")]
    public GuildJoinRequestType JoinRequest
    {
      [Token(Token = "0x600AA15"), Address(RVA = "0x1917850", Offset = "0x1917850", VA = "0x1917850")] get
      {
        return (GuildJoinRequestType) null;
      }
    }

    [Token(Token = "0x600AA16")]
    [Address(RVA = "0x1917858", Offset = "0x1917858", VA = "0x1917858")]
    public APIGuildInfoGetResponse()
    {
    }
  }
}
