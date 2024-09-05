// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRaidDetailResponse
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
  [Token(Token = "0x2001D10")]
  [Serializable]
  public class APIGuildRaidDetailResponse
  {
    [Token(Token = "0x4007C2D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GuildRaidPositionDetailType position_detail_info;
    [Token(Token = "0x4007C2E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<string> used_player_unit_ids;
    [Token(Token = "0x4007C2F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GuildMemberType> members;

    [Token(Token = "0x17002126")]
    public GuildRaidPositionDetailType PositionDetailInfo
    {
      [Token(Token = "0x600AB4F"), Address(RVA = "0x1A428BC", Offset = "0x1A428BC", VA = "0x1A428BC")] get
      {
        return (GuildRaidPositionDetailType) null;
      }
    }

    [Token(Token = "0x17002127")]
    public List<string> UsedPlayerUnitIds
    {
      [Token(Token = "0x600AB50"), Address(RVA = "0x1A428C4", Offset = "0x1A428C4", VA = "0x1A428C4")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x17002128")]
    public List<GuildMemberType> Members
    {
      [Token(Token = "0x600AB51"), Address(RVA = "0x1A428CC", Offset = "0x1A428CC", VA = "0x1A428CC")] get
      {
        return (List<GuildMemberType>) null;
      }
    }

    [Token(Token = "0x600AB52")]
    [Address(RVA = "0x1A428D4", Offset = "0x1A428D4", VA = "0x1A428D4")]
    public APIGuildRaidDetailResponse()
    {
    }
  }
}
