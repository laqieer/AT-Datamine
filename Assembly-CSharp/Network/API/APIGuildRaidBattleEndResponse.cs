// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRaidBattleEndResponse
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
  [Token(Token = "0x2001D08")]
  [Serializable]
  public class APIGuildRaidBattleEndResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007C00")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007C01")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007C02")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007C03")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool is_subjugated;
    [Token(Token = "0x4007C04")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int position_score;
    [Token(Token = "0x4007C05")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GuildRaidPositionDetailType position_detail_info;
    [Token(Token = "0x4007C06")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<GuildMemberType> members;
    [Token(Token = "0x4007C07")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<string> used_player_unit_ids;

    [Token(Token = "0x1700210D")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AB16"), Address(RVA = "0x1A41DBC", Offset = "0x1A41DBC", VA = "0x1A41DBC", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700210E")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600AB17"), Address(RVA = "0x1A41DC4", Offset = "0x1A41DC4", VA = "0x1A41DC4", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700210F")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600AB18"), Address(RVA = "0x1A41DCC", Offset = "0x1A41DCC", VA = "0x1A41DCC", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002110")]
    public bool IsSubjugated
    {
      [Token(Token = "0x600AB19"), Address(RVA = "0x1A41DD4", Offset = "0x1A41DD4", VA = "0x1A41DD4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002111")]
    public int PositionScore
    {
      [Token(Token = "0x600AB1A"), Address(RVA = "0x1A41DDC", Offset = "0x1A41DDC", VA = "0x1A41DDC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002112")]
    public GuildRaidPositionDetailType PositionDetailInfo
    {
      [Token(Token = "0x600AB1B"), Address(RVA = "0x1A41DE4", Offset = "0x1A41DE4", VA = "0x1A41DE4")] get
      {
        return (GuildRaidPositionDetailType) null;
      }
    }

    [Token(Token = "0x17002113")]
    public List<GuildMemberType> Members
    {
      [Token(Token = "0x600AB1C"), Address(RVA = "0x1A41DEC", Offset = "0x1A41DEC", VA = "0x1A41DEC")] get
      {
        return (List<GuildMemberType>) null;
      }
    }

    [Token(Token = "0x17002114")]
    public List<string> UsedPlayerUnitIds
    {
      [Token(Token = "0x600AB1D"), Address(RVA = "0x1A41DF4", Offset = "0x1A41DF4", VA = "0x1A41DF4")] get
      {
        return (List<string>) null;
      }
    }

    [Token(Token = "0x600AB1E")]
    [Address(RVA = "0x1A41DFC", Offset = "0x1A41DFC", VA = "0x1A41DFC")]
    public APIGuildRaidBattleEndResponse()
    {
    }
  }
}
