// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildLeaveResponse
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
  [Token(Token = "0x2001D00")]
  [Serializable]
  public class APIGuildLeaveResponse : ICommonApiResult
  {
    [Token(Token = "0x4007BDF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007BE0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerGuildRelationSync guild_relation_sync;

    [Token(Token = "0x170020FE")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AAE7"), Address(RVA = "0x1A4130C", Offset = "0x1A4130C", VA = "0x1A4130C", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170020FF")]
    public PlayerGuildRelationSync GuildRelationSync
    {
      [Token(Token = "0x600AAE8"), Address(RVA = "0x1A41314", Offset = "0x1A41314", VA = "0x1A41314")] get
      {
        return (PlayerGuildRelationSync) null;
      }
    }

    [Token(Token = "0x600AAE9")]
    [Address(RVA = "0x1A4131C", Offset = "0x1A4131C", VA = "0x1A4131C")]
    public APIGuildLeaveResponse()
    {
    }
  }
}
