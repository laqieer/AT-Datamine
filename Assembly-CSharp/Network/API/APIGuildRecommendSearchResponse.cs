// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRecommendSearchResponse
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
  [Token(Token = "0x2001D18")]
  [Serializable]
  public class APIGuildRecommendSearchResponse
  {
    [Token(Token = "0x4007C4B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GuildSearchResultType> guilds;
    [Token(Token = "0x4007C4C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildJoinRequestType join_request;

    [Token(Token = "0x17002139")]
    public List<GuildSearchResultType> Guilds
    {
      [Token(Token = "0x600AB82"), Address(RVA = "0x1A4338C", Offset = "0x1A4338C", VA = "0x1A4338C")] get
      {
        return (List<GuildSearchResultType>) null;
      }
    }

    [Token(Token = "0x1700213A")]
    public GuildJoinRequestType JoinRequest
    {
      [Token(Token = "0x600AB83"), Address(RVA = "0x1A43394", Offset = "0x1A43394", VA = "0x1A43394")] get
      {
        return (GuildJoinRequestType) null;
      }
    }

    [Token(Token = "0x600AB84")]
    [Address(RVA = "0x1A4339C", Offset = "0x1A4339C", VA = "0x1A4339C")]
    public APIGuildRecommendSearchResponse()
    {
    }
  }
}
