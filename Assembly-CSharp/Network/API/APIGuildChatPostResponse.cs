// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildChatPostResponse
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
  [Token(Token = "0x2001CB4")]
  [Serializable]
  public class APIGuildChatPostResponse
  {
    [Token(Token = "0x4007ABD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GuildMemberType> members;
    [Token(Token = "0x4007ABE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<GuildChatMessageType> messages;
    [Token(Token = "0x4007ABF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string post_message_id;
    [Token(Token = "0x4007AC0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int chat_active_count;
    [Token(Token = "0x4007AC1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string last_guild_bulletin_board_id;

    [Token(Token = "0x17002060")]
    public List<GuildMemberType> Members
    {
      [Token(Token = "0x600A919"), Address(RVA = "0x1914268", Offset = "0x1914268", VA = "0x1914268")] get
      {
        return (List<GuildMemberType>) null;
      }
    }

    [Token(Token = "0x17002061")]
    public List<GuildChatMessageType> Messages
    {
      [Token(Token = "0x600A91A"), Address(RVA = "0x1914270", Offset = "0x1914270", VA = "0x1914270")] get
      {
        return (List<GuildChatMessageType>) null;
      }
    }

    [Token(Token = "0x17002062")]
    public string PostMessageId
    {
      [Token(Token = "0x600A91B"), Address(RVA = "0x1914278", Offset = "0x1914278", VA = "0x1914278")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002063")]
    public int ChatActiveCount
    {
      [Token(Token = "0x600A91C"), Address(RVA = "0x1914280", Offset = "0x1914280", VA = "0x1914280")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002064")]
    public string LastGuildBulletinBoardId
    {
      [Token(Token = "0x600A91D"), Address(RVA = "0x1914288", Offset = "0x1914288", VA = "0x1914288")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600A91E")]
    [Address(RVA = "0x1914290", Offset = "0x1914290", VA = "0x1914290")]
    public APIGuildChatPostResponse()
    {
    }
  }
}
