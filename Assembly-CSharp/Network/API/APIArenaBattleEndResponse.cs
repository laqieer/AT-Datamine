// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaBattleEndResponse
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
  [Token(Token = "0x2001B84")]
  [Serializable]
  public class APIArenaBattleEndResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40075FC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40075FD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40075FE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40075FF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ArenaBattleHistoryType arena_battle_history;
    [Token(Token = "0x4007600")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private bool is_new_record;
    [Token(Token = "0x4007601")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<Reward> new_record_rewards;
    [Token(Token = "0x4007602")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private PlayerArenaType player_arena;
    [Token(Token = "0x4007603")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerType player;

    [Token(Token = "0x17001DA5")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A19E"), Address(RVA = "0x46C882C", Offset = "0x46C882C", VA = "0x46C882C", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001DA6")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A19F"), Address(RVA = "0x46C8834", Offset = "0x46C8834", VA = "0x46C8834", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001DA7")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A1A0"), Address(RVA = "0x46C883C", Offset = "0x46C883C", VA = "0x46C883C", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001DA8")]
    public ArenaBattleHistoryType ArenaBattleHistory
    {
      [Token(Token = "0x600A1A1"), Address(RVA = "0x46C8844", Offset = "0x46C8844", VA = "0x46C8844")] get
      {
        return (ArenaBattleHistoryType) null;
      }
    }

    [Token(Token = "0x17001DA9")]
    public bool IsNewRecord
    {
      [Token(Token = "0x600A1A2"), Address(RVA = "0x46C884C", Offset = "0x46C884C", VA = "0x46C884C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DAA")]
    public List<Reward> NewRecordRewards
    {
      [Token(Token = "0x600A1A3"), Address(RVA = "0x46C8854", Offset = "0x46C8854", VA = "0x46C8854")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x17001DAB")]
    public PlayerArenaType PlayerArena
    {
      [Token(Token = "0x600A1A4"), Address(RVA = "0x46C885C", Offset = "0x46C885C", VA = "0x46C885C")] get
      {
        return (PlayerArenaType) null;
      }
    }

    [Token(Token = "0x17001DAC")]
    public PlayerType Player
    {
      [Token(Token = "0x600A1A5"), Address(RVA = "0x46C8864", Offset = "0x46C8864", VA = "0x46C8864")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x600A1A6")]
    [Address(RVA = "0x46C886C", Offset = "0x46C886C", VA = "0x46C886C")]
    public APIArenaBattleEndResponse()
    {
    }
  }
}
