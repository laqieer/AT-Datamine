// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildAppointSubMasterResponse
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
  [Token(Token = "0x2001CA0")]
  [Serializable]
  public class APIGuildAppointSubMasterResponse
  {
    [Token(Token = "0x4007A64")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GuildSyncDataSet guild_sync_data_set;

    [Token(Token = "0x17002031")]
    public GuildSyncDataSet GuildSyncDataSet
    {
      [Token(Token = "0x600A89A"), Address(RVA = "0x1912764", Offset = "0x1912764", VA = "0x1912764")] get
      {
        return (GuildSyncDataSet) null;
      }
    }

    [Token(Token = "0x600A89B")]
    [Address(RVA = "0x191276C", Offset = "0x191276C", VA = "0x191276C")]
    public APIGuildAppointSubMasterResponse()
    {
    }
  }
}
