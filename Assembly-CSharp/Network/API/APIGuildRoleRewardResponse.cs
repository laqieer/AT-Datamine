// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRoleRewardResponse
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
  [Token(Token = "0x2001D1C")]
  [Serializable]
  public class APIGuildRoleRewardResponse
  {
    [Token(Token = "0x4007C59")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;

    [Token(Token = "0x17002141")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600AB9A"), Address(RVA = "0x1A438E8", Offset = "0x1A438E8", VA = "0x1A438E8")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600AB9B")]
    [Address(RVA = "0x1A438F0", Offset = "0x1A438F0", VA = "0x1A438F0")]
    public APIGuildRoleRewardResponse()
    {
    }
  }
}
