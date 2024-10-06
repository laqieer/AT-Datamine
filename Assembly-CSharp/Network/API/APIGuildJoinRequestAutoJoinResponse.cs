// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestAutoJoinResponse
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
  [Token(Token = "0x2001CE8")]
  [Serializable]
  public class APIGuildJoinRequestAutoJoinResponse : ICommonApiResult
  {
    [Token(Token = "0x4007B8E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007B8F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerGuildRelationSync guild_relation_sync;
    [Token(Token = "0x4007B90")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GuildSyncDataSet guild_sync_data_set;

    [Token(Token = "0x170020D3")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AA5C"), Address(RVA = "0x191885C", Offset = "0x191885C", VA = "0x191885C", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170020D4")]
    public PlayerGuildRelationSync GuildRelationSync
    {
      [Token(Token = "0x600AA5D"), Address(RVA = "0x1918864", Offset = "0x1918864", VA = "0x1918864")] get
      {
        return (PlayerGuildRelationSync) null;
      }
    }

    [Token(Token = "0x170020D5")]
    public GuildSyncDataSet GuildSyncDataSet
    {
      [Token(Token = "0x600AA5E"), Address(RVA = "0x191886C", Offset = "0x191886C", VA = "0x191886C")] get
      {
        return (GuildSyncDataSet) null;
      }
    }

    [Token(Token = "0x600AA5F")]
    [Address(RVA = "0x1918874", Offset = "0x1918874", VA = "0x1918874")]
    public APIGuildJoinRequestAutoJoinResponse()
    {
    }
  }
}
