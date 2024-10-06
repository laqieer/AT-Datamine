// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildSearchResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D20")]
  [Serializable]
  public class APIGuildSearchResponse
  {
    [Token(Token = "0x4007C70")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GuildSearchResultType> guilds;
    [Token(Token = "0x4007C71")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildJoinRequestType join_request;

    [Token(Token = "0x17002148")]
    public List<GuildSearchResultType> Guilds
    {
      [Token(Token = "0x600ABB1"), Address(RVA = "0x1A43E3C", Offset = "0x1A43E3C", VA = "0x1A43E3C")] get
      {
        return (List<GuildSearchResultType>) null;
      }
    }

    [Token(Token = "0x17002149")]
    public GuildJoinRequestType JoinRequest
    {
      [Token(Token = "0x600ABB2"), Address(RVA = "0x1A43E44", Offset = "0x1A43E44", VA = "0x1A43E44")] get
      {
        return (GuildJoinRequestType) null;
      }
    }

    [Token(Token = "0x600ABB3")]
    [Address(RVA = "0x1A43E4C", Offset = "0x1A43E4C", VA = "0x1A43E4C")]
    public APIGuildSearchResponse()
    {
    }
  }
}
