// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestApproveResponse
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
  [Token(Token = "0x2001CE4")]
  [Serializable]
  public class APIGuildJoinRequestApproveResponse
  {
    [Token(Token = "0x4007B80")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GuildSyncDataSet guild_sync_data_set;
    [Token(Token = "0x4007B81")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<int> new_title_ids;

    [Token(Token = "0x170020CB")]
    public GuildSyncDataSet GuildSyncDataSet
    {
      [Token(Token = "0x600AA44"), Address(RVA = "0x1918300", Offset = "0x1918300", VA = "0x1918300")] get
      {
        return (GuildSyncDataSet) null;
      }
    }

    [Token(Token = "0x170020CC")]
    public List<int> NewTitleIds
    {
      [Token(Token = "0x600AA45"), Address(RVA = "0x1918308", Offset = "0x1918308", VA = "0x1918308")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x600AA46")]
    [Address(RVA = "0x1918310", Offset = "0x1918310", VA = "0x1918310")]
    public APIGuildJoinRequestApproveResponse()
    {
    }
  }
}
