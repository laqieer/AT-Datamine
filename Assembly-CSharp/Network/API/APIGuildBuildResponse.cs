// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildBuildResponse
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
  [Token(Token = "0x2001CA8")]
  [Serializable]
  public class APIGuildBuildResponse : ICommonApiResult
  {
    [Token(Token = "0x4007A8B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007A8C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerGuildRelationSync guild_relation_sync;
    [Token(Token = "0x4007A8D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GuildSyncDataSet guild_sync_data_set;

    [Token(Token = "0x17002045")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A8CE"), Address(RVA = "0x191323C", Offset = "0x191323C", VA = "0x191323C", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002046")]
    public PlayerGuildRelationSync GuildRelationSync
    {
      [Token(Token = "0x600A8CF"), Address(RVA = "0x1913244", Offset = "0x1913244", VA = "0x1913244")] get
      {
        return (PlayerGuildRelationSync) null;
      }
    }

    [Token(Token = "0x17002047")]
    public GuildSyncDataSet GuildSyncDataSet
    {
      [Token(Token = "0x600A8D0"), Address(RVA = "0x191324C", Offset = "0x191324C", VA = "0x191324C")] get
      {
        return (GuildSyncDataSet) null;
      }
    }

    [Token(Token = "0x600A8D1")]
    [Address(RVA = "0x1913254", Offset = "0x1913254", VA = "0x1913254")]
    public APIGuildBuildResponse()
    {
    }
  }
}
