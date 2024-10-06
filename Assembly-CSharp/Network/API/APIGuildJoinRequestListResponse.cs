// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestListResponse
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
  [Token(Token = "0x2001CF0")]
  [Serializable]
  public class APIGuildJoinRequestListResponse
  {
    [Token(Token = "0x4007BA9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GuildJoinRequestPlayer> requests;

    [Token(Token = "0x170020E2")]
    public List<GuildJoinRequestPlayer> Requests
    {
      [Token(Token = "0x600AA8B"), Address(RVA = "0x191930C", Offset = "0x191930C", VA = "0x191930C")] get
      {
        return (List<GuildJoinRequestPlayer>) null;
      }
    }

    [Token(Token = "0x600AA8C")]
    [Address(RVA = "0x1919314", Offset = "0x1919314", VA = "0x1919314")]
    public APIGuildJoinRequestListResponse()
    {
    }
  }
}
