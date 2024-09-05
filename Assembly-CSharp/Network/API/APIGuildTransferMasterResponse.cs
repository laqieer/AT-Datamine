// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildTransferMasterResponse
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
  [Token(Token = "0x2001D24")]
  [Serializable]
  public class APIGuildTransferMasterResponse
  {
    [Token(Token = "0x4007C7F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GuildSyncDataSet guild_sync_data_set;

    [Token(Token = "0x17002150")]
    public GuildSyncDataSet GuildSyncDataSet
    {
      [Token(Token = "0x600ABC9"), Address(RVA = "0x1A44398", Offset = "0x1A44398", VA = "0x1A44398")] get
      {
        return (GuildSyncDataSet) null;
      }
    }

    [Token(Token = "0x600ABCA")]
    [Address(RVA = "0x1A443A0", Offset = "0x1A443A0", VA = "0x1A443A0")]
    public APIGuildTransferMasterResponse()
    {
    }
  }
}
