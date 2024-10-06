// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRaidTopResponse
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
  [Token(Token = "0x2001D14")]
  [Serializable]
  public class APIGuildRaidTopResponse
  {
    [Token(Token = "0x4007C3C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int lap;
    [Token(Token = "0x4007C3D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<GuildRaidPositionType> position_infos;
    [Token(Token = "0x4007C3E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string last_guild_chat_message_id;
    [Token(Token = "0x4007C3F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<GuildMemberType> members;

    [Token(Token = "0x1700212F")]
    public int Lap
    {
      [Token(Token = "0x600AB68"), Address(RVA = "0x1A42E20", Offset = "0x1A42E20", VA = "0x1A42E20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002130")]
    public List<GuildRaidPositionType> PositionInfos
    {
      [Token(Token = "0x600AB69"), Address(RVA = "0x1A42E28", Offset = "0x1A42E28", VA = "0x1A42E28")] get
      {
        return (List<GuildRaidPositionType>) null;
      }
    }

    [Token(Token = "0x17002131")]
    public string LastGuildChatMessageId
    {
      [Token(Token = "0x600AB6A"), Address(RVA = "0x1A42E30", Offset = "0x1A42E30", VA = "0x1A42E30")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002132")]
    public List<GuildMemberType> Members
    {
      [Token(Token = "0x600AB6B"), Address(RVA = "0x1A42E38", Offset = "0x1A42E38", VA = "0x1A42E38")] get
      {
        return (List<GuildMemberType>) null;
      }
    }

    [Token(Token = "0x600AB6C")]
    [Address(RVA = "0x1A42E40", Offset = "0x1A42E40", VA = "0x1A42E40")]
    public APIGuildRaidTopResponse()
    {
    }
  }
}
