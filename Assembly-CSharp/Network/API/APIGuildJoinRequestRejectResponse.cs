// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestRejectResponse
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
  [Token(Token = "0x2001CF4")]
  [Serializable]
  public class APIGuildJoinRequestRejectResponse
  {
    [Token(Token = "0x4007BB7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GuildSyncDataSet guild_sync_data_set;

    [Token(Token = "0x170020E9")]
    public GuildSyncDataSet GuildSyncDataSet
    {
      [Token(Token = "0x600AAA2"), Address(RVA = "0x1919860", Offset = "0x1919860", VA = "0x1919860")] get
      {
        return (GuildSyncDataSet) null;
      }
    }

    [Token(Token = "0x600AAA3")]
    [Address(RVA = "0x1919868", Offset = "0x1919868", VA = "0x1919868")]
    public APIGuildJoinRequestRejectResponse()
    {
    }
  }
}
