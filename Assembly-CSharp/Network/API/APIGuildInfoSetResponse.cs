// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildInfoSetResponse
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
  [Token(Token = "0x2001CE0")]
  [Serializable]
  public class APIGuildInfoSetResponse : ICommonApiResult
  {
    [Token(Token = "0x4007B71")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007B72")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildSyncDataSet guild_sync_data_set;

    [Token(Token = "0x170020C3")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AA2C"), Address(RVA = "0x1917DA4", Offset = "0x1917DA4", VA = "0x1917DA4", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170020C4")]
    public GuildSyncDataSet GuildSyncDataSet
    {
      [Token(Token = "0x600AA2D"), Address(RVA = "0x1917DAC", Offset = "0x1917DAC", VA = "0x1917DAC")] get
      {
        return (GuildSyncDataSet) null;
      }
    }

    [Token(Token = "0x600AA2E")]
    [Address(RVA = "0x1917DB4", Offset = "0x1917DB4", VA = "0x1917DB4")]
    public APIGuildInfoSetResponse()
    {
    }
  }
}
