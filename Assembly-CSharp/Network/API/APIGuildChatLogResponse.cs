// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildChatLogResponse
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
  [Token(Token = "0x2001CB0")]
  [Serializable]
  public class APIGuildChatLogResponse
  {
    [Token(Token = "0x4007AAA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GuildMemberType> members;
    [Token(Token = "0x4007AAB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<GuildChatMessageType> messages;
    [Token(Token = "0x4007AAC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int chat_active_count;
    [Token(Token = "0x4007AAD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string last_guild_bulletin_board_id;

    [Token(Token = "0x17002056")]
    public List<GuildMemberType> Members
    {
      [Token(Token = "0x600A8FF"), Address(RVA = "0x1913CFC", Offset = "0x1913CFC", VA = "0x1913CFC")] get
      {
        return (List<GuildMemberType>) null;
      }
    }

    [Token(Token = "0x17002057")]
    public List<GuildChatMessageType> Messages
    {
      [Token(Token = "0x600A900"), Address(RVA = "0x1913D04", Offset = "0x1913D04", VA = "0x1913D04")] get
      {
        return (List<GuildChatMessageType>) null;
      }
    }

    [Token(Token = "0x17002058")]
    public int ChatActiveCount
    {
      [Token(Token = "0x600A901"), Address(RVA = "0x1913D0C", Offset = "0x1913D0C", VA = "0x1913D0C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002059")]
    public string LastGuildBulletinBoardId
    {
      [Token(Token = "0x600A902"), Address(RVA = "0x1913D14", Offset = "0x1913D14", VA = "0x1913D14")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600A903")]
    [Address(RVA = "0x1913D1C", Offset = "0x1913D1C", VA = "0x1913D1C")]
    public APIGuildChatLogResponse()
    {
    }
  }
}
