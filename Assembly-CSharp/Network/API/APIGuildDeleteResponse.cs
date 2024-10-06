// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildDeleteResponse
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
  [Token(Token = "0x2001CBC")]
  [Serializable]
  public class APIGuildDeleteResponse : ICommonApiResult
  {
    [Token(Token = "0x4007AD9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007ADA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerGuildRelationSync guild_relation_sync;

    [Token(Token = "0x17002071")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A94A"), Address(RVA = "0x1914D18", Offset = "0x1914D18", VA = "0x1914D18", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002072")]
    public PlayerGuildRelationSync GuildRelationSync
    {
      [Token(Token = "0x600A94B"), Address(RVA = "0x1914D20", Offset = "0x1914D20", VA = "0x1914D20")] get
      {
        return (PlayerGuildRelationSync) null;
      }
    }

    [Token(Token = "0x600A94C")]
    [Address(RVA = "0x1914D28", Offset = "0x1914D28", VA = "0x1914D28")]
    public APIGuildDeleteResponse()
    {
    }
  }
}
