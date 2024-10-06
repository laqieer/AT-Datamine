// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildKickResponse
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
  [Token(Token = "0x2001CFC")]
  [Serializable]
  public class APIGuildKickResponse
  {
    [Token(Token = "0x4007BD2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GuildSyncDataSet guild_sync_data_set;

    [Token(Token = "0x170020F7")]
    public GuildSyncDataSet GuildSyncDataSet
    {
      [Token(Token = "0x600AAD0"), Address(RVA = "0x1A40DB8", Offset = "0x1A40DB8", VA = "0x1A40DB8")] get
      {
        return (GuildSyncDataSet) null;
      }
    }

    [Token(Token = "0x600AAD1")]
    [Address(RVA = "0x1A40DC0", Offset = "0x1A40DC0", VA = "0x1A40DC0")]
    public APIGuildKickResponse()
    {
    }
  }
}
