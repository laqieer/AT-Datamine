// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaDetailResponse
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
  [Token(Token = "0x2001B94")]
  [Serializable]
  public class APIArenaDetailResponse
  {
    [Token(Token = "0x400763F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerArenaType> player_arenas;
    [Token(Token = "0x4007640")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ArenaRankingType arena_ranking;
    [Token(Token = "0x4007641")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<EnemyArenaRankingType> enemy_arena_rankings;
    [Token(Token = "0x4007642")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerDeckType> player_decks;
    [Token(Token = "0x4007643")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int battle_power;
    [Token(Token = "0x4007644")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private int time_reward_quantity;
    [Token(Token = "0x4007645")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int time_reward_quantity_per_hour;
    [Token(Token = "0x4007646")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<Reward> periodical_rewards;
    [Token(Token = "0x4007647")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007648")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;

    [Token(Token = "0x17001DCE")]
    public List<PlayerArenaType> PlayerArenas
    {
      [Token(Token = "0x600A207"), Address(RVA = "0x46C9DE4", Offset = "0x46C9DE4", VA = "0x46C9DE4")] get
      {
        return (List<PlayerArenaType>) null;
      }
    }

    [Token(Token = "0x17001DCF")]
    public ArenaRankingType ArenaRanking
    {
      [Token(Token = "0x600A208"), Address(RVA = "0x46C9DEC", Offset = "0x46C9DEC", VA = "0x46C9DEC")] get
      {
        return (ArenaRankingType) null;
      }
    }

    [Token(Token = "0x17001DD0")]
    public List<EnemyArenaRankingType> EnemyArenaRankings
    {
      [Token(Token = "0x600A209"), Address(RVA = "0x46C9DF4", Offset = "0x46C9DF4", VA = "0x46C9DF4")] get
      {
        return (List<EnemyArenaRankingType>) null;
      }
    }

    [Token(Token = "0x17001DD1")]
    public List<PlayerDeckType> PlayerDecks
    {
      [Token(Token = "0x600A20A"), Address(RVA = "0x46C9DFC", Offset = "0x46C9DFC", VA = "0x46C9DFC")] get
      {
        return (List<PlayerDeckType>) null;
      }
    }

    [Token(Token = "0x17001DD2")]
    public int BattlePower
    {
      [Token(Token = "0x600A20B"), Address(RVA = "0x46C9E04", Offset = "0x46C9E04", VA = "0x46C9E04")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001DD3")]
    public int TimeRewardQuantity
    {
      [Token(Token = "0x600A20C"), Address(RVA = "0x46C9E0C", Offset = "0x46C9E0C", VA = "0x46C9E0C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001DD4")]
    public int TimeRewardQuantityPerHour
    {
      [Token(Token = "0x600A20D"), Address(RVA = "0x46C9E14", Offset = "0x46C9E14", VA = "0x46C9E14")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001DD5")]
    public List<Reward> PeriodicalRewards
    {
      [Token(Token = "0x600A20E"), Address(RVA = "0x46C9E1C", Offset = "0x46C9E1C", VA = "0x46C9E1C")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x17001DD6")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A20F"), Address(RVA = "0x46C9E24", Offset = "0x46C9E24", VA = "0x46C9E24")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001DD7")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600A210"), Address(RVA = "0x46C9E2C", Offset = "0x46C9E2C", VA = "0x46C9E2C")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600A211")]
    [Address(RVA = "0x46C9E34", Offset = "0x46C9E34", VA = "0x46C9E34")]
    public APIArenaDetailResponse()
    {
    }
  }
}
