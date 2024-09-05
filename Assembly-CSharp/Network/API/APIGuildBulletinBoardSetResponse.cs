// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildBulletinBoardSetResponse
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
  [Token(Token = "0x2001CAC")]
  [Serializable]
  public class APIGuildBulletinBoardSetResponse : ICommonApiResult
  {
    [Token(Token = "0x4007A9B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007A9C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildSyncDataSet guild_sync_data_set;

    [Token(Token = "0x1700204E")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A8E7"), Address(RVA = "0x19137A0", Offset = "0x19137A0", VA = "0x19137A0", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700204F")]
    public GuildSyncDataSet GuildSyncDataSet
    {
      [Token(Token = "0x600A8E8"), Address(RVA = "0x19137A8", Offset = "0x19137A8", VA = "0x19137A8")] get
      {
        return (GuildSyncDataSet) null;
      }
    }

    [Token(Token = "0x600A8E9")]
    [Address(RVA = "0x19137B0", Offset = "0x19137B0", VA = "0x19137B0")]
    public APIGuildBulletinBoardSetResponse()
    {
    }
  }
}
