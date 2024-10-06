// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaBattleStartResponse
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
  [Token(Token = "0x2001B90")]
  [Serializable]
  public class APIArenaBattleStartResponse
  {
    [Token(Token = "0x400762E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private long battle_id;
    [Token(Token = "0x400762F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string battle_start_at;
    [Token(Token = "0x4007630")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x4007631")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private EnemyArenaRankingDetailType enemy_arena_ranking;
    [Token(Token = "0x4007632")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int seed;

    [Token(Token = "0x17001DC3")]
    public long BattleId
    {
      [Token(Token = "0x600A1EC"), Address(RVA = "0x46C9870", Offset = "0x46C9870", VA = "0x46C9870")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001DC4")]
    public string BattleStartAt
    {
      [Token(Token = "0x600A1ED"), Address(RVA = "0x46C9878", Offset = "0x46C9878", VA = "0x46C9878")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001DC5")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600A1EE"), Address(RVA = "0x46C9880", Offset = "0x46C9880", VA = "0x46C9880")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x17001DC6")]
    public EnemyArenaRankingDetailType EnemyArenaRanking
    {
      [Token(Token = "0x600A1EF"), Address(RVA = "0x46C9888", Offset = "0x46C9888", VA = "0x46C9888")] get
      {
        return (EnemyArenaRankingDetailType) null;
      }
    }

    [Token(Token = "0x17001DC7")]
    public int Seed
    {
      [Token(Token = "0x600A1F0"), Address(RVA = "0x46C9890", Offset = "0x46C9890", VA = "0x46C9890")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A1F1")]
    [Address(RVA = "0x46C9898", Offset = "0x46C9898", VA = "0x46C9898")]
    public APIArenaBattleStartResponse()
    {
    }
  }
}
