// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildAppointGeneralResponse
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
  [Token(Token = "0x2001C9C")]
  [Serializable]
  public class APIGuildAppointGeneralResponse
  {
    [Token(Token = "0x4007A56")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GuildSyncDataSet guild_sync_data_set;

    [Token(Token = "0x1700202A")]
    public GuildSyncDataSet GuildSyncDataSet
    {
      [Token(Token = "0x600A883"), Address(RVA = "0x1912210", Offset = "0x1912210", VA = "0x1912210")] get
      {
        return (GuildSyncDataSet) null;
      }
    }

    [Token(Token = "0x600A884")]
    [Address(RVA = "0x1912218", Offset = "0x1912218", VA = "0x1912218")]
    public APIGuildAppointGeneralResponse()
    {
    }
  }
}
