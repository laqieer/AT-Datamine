// Decompiled with JetBrains decompiler
// Type: Network.Param.ArenaBattleHistoryType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A3D")]
  [Serializable]
  public class ArenaBattleHistoryType
  {
    [Token(Token = "0x400702D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private long battle_id;
    [Token(Token = "0x400702E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string enemy_player_id;
    [Token(Token = "0x400702F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int ranking;
    [Token(Token = "0x4007030")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int enemy_ranking;
    [Token(Token = "0x4007031")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool is_win;
    [Token(Token = "0x4007032")]
    [FieldOffset(Offset = "0x29")]
    [SerializeField]
    private bool is_attack;
    [Token(Token = "0x4007033")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private string battle_start_at;
    [Token(Token = "0x4007034")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string battle_end_at;
    [Token(Token = "0x4007035")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<ArenaDeckUnitHistoryType> deck_units;
    [Token(Token = "0x4007036")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerUnitArenaHistoryType> player_units;
    [Token(Token = "0x4007037")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<ArenaDeckUnitHistoryType> enemy_deck_units;
    [Token(Token = "0x4007038")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayerUnitArenaHistoryType> enemy_player_units;
    [Token(Token = "0x4007039")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private PlayerArenaProfileType player_profile;
    [Token(Token = "0x400703A")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private PlayerArenaProfileType enemy_player_profile;
    [Token(Token = "0x400703B")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private List<ArenaRankingNpcDeckUnitHistoryType> npc_deck_units;
    [Token(Token = "0x400703C")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private int battle_power;
    [Token(Token = "0x400703D")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private int enemy_battle_power;
    [Token(Token = "0x400703E")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private int seed;

    [Token(Token = "0x17001863")]
    public long BattleId
    {
      [Token(Token = "0x6009599"), Address(RVA = "0x48EEAE8", Offset = "0x48EEAE8", VA = "0x48EEAE8")] get
      {
        return new long();
      }
      [Token(Token = "0x600959A"), Address(RVA = "0x48EEAF0", Offset = "0x48EEAF0", VA = "0x48EEAF0")] set
      {
      }
    }

    [Token(Token = "0x17001864")]
    public string EnemyPlayerId
    {
      [Token(Token = "0x600959B"), Address(RVA = "0x48EEAF8", Offset = "0x48EEAF8", VA = "0x48EEAF8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600959C"), Address(RVA = "0x48EEB00", Offset = "0x48EEB00", VA = "0x48EEB00")] set
      {
      }
    }

    [Token(Token = "0x17001865")]
    public int Ranking
    {
      [Token(Token = "0x600959D"), Address(RVA = "0x48EEB08", Offset = "0x48EEB08", VA = "0x48EEB08")] get
      {
        return new int();
      }
      [Token(Token = "0x600959E"), Address(RVA = "0x48EEB10", Offset = "0x48EEB10", VA = "0x48EEB10")] set
      {
      }
    }

    [Token(Token = "0x17001866")]
    public int EnemyRanking
    {
      [Token(Token = "0x600959F"), Address(RVA = "0x48EEB18", Offset = "0x48EEB18", VA = "0x48EEB18")] get
      {
        return new int();
      }
      [Token(Token = "0x60095A0"), Address(RVA = "0x48EEB20", Offset = "0x48EEB20", VA = "0x48EEB20")] set
      {
      }
    }

    [Token(Token = "0x17001867")]
    public bool IsWin
    {
      [Token(Token = "0x60095A1"), Address(RVA = "0x48EEB28", Offset = "0x48EEB28", VA = "0x48EEB28")] get
      {
        return new bool();
      }
      [Token(Token = "0x60095A2"), Address(RVA = "0x48EEB30", Offset = "0x48EEB30", VA = "0x48EEB30")] set
      {
      }
    }

    [Token(Token = "0x17001868")]
    public bool IsAttack
    {
      [Token(Token = "0x60095A3"), Address(RVA = "0x48EEB3C", Offset = "0x48EEB3C", VA = "0x48EEB3C")] get
      {
        return new bool();
      }
      [Token(Token = "0x60095A4"), Address(RVA = "0x48EEB44", Offset = "0x48EEB44", VA = "0x48EEB44")] set
      {
      }
    }

    [Token(Token = "0x17001869")]
    public string BattleStartAt
    {
      [Token(Token = "0x60095A5"), Address(RVA = "0x48EEB50", Offset = "0x48EEB50", VA = "0x48EEB50")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60095A6"), Address(RVA = "0x48EEB58", Offset = "0x48EEB58", VA = "0x48EEB58")] set
      {
      }
    }

    [Token(Token = "0x1700186A")]
    public string BattleEndAt
    {
      [Token(Token = "0x60095A7"), Address(RVA = "0x48EEB60", Offset = "0x48EEB60", VA = "0x48EEB60")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60095A8"), Address(RVA = "0x48EEB68", Offset = "0x48EEB68", VA = "0x48EEB68")] set
      {
      }
    }

    [Token(Token = "0x1700186B")]
    public List<ArenaDeckUnitHistoryType> DeckUnits
    {
      [Token(Token = "0x60095A9"), Address(RVA = "0x48EEB70", Offset = "0x48EEB70", VA = "0x48EEB70")] get
      {
        return (List<ArenaDeckUnitHistoryType>) null;
      }
      [Token(Token = "0x60095AA"), Address(RVA = "0x48EEB78", Offset = "0x48EEB78", VA = "0x48EEB78")] set
      {
      }
    }

    [Token(Token = "0x1700186C")]
    public List<PlayerUnitArenaHistoryType> PlayerUnits
    {
      [Token(Token = "0x60095AB"), Address(RVA = "0x48EEB80", Offset = "0x48EEB80", VA = "0x48EEB80")] get
      {
        return (List<PlayerUnitArenaHistoryType>) null;
      }
      [Token(Token = "0x60095AC"), Address(RVA = "0x48EEB88", Offset = "0x48EEB88", VA = "0x48EEB88")] set
      {
      }
    }

    [Token(Token = "0x1700186D")]
    public List<ArenaDeckUnitHistoryType> EnemyDeckUnits
    {
      [Token(Token = "0x60095AD"), Address(RVA = "0x48EEB90", Offset = "0x48EEB90", VA = "0x48EEB90")] get
      {
        return (List<ArenaDeckUnitHistoryType>) null;
      }
      [Token(Token = "0x60095AE"), Address(RVA = "0x48EEB98", Offset = "0x48EEB98", VA = "0x48EEB98")] set
      {
      }
    }

    [Token(Token = "0x1700186E")]
    public List<PlayerUnitArenaHistoryType> EnemyPlayerUnits
    {
      [Token(Token = "0x60095AF"), Address(RVA = "0x48EEBA0", Offset = "0x48EEBA0", VA = "0x48EEBA0")] get
      {
        return (List<PlayerUnitArenaHistoryType>) null;
      }
      [Token(Token = "0x60095B0"), Address(RVA = "0x48EEBA8", Offset = "0x48EEBA8", VA = "0x48EEBA8")] set
      {
      }
    }

    [Token(Token = "0x1700186F")]
    public PlayerArenaProfileType PlayerProfile
    {
      [Token(Token = "0x60095B1"), Address(RVA = "0x48EEBB0", Offset = "0x48EEBB0", VA = "0x48EEBB0")] get
      {
        return (PlayerArenaProfileType) null;
      }
      [Token(Token = "0x60095B2"), Address(RVA = "0x48EEBB8", Offset = "0x48EEBB8", VA = "0x48EEBB8")] set
      {
      }
    }

    [Token(Token = "0x17001870")]
    public PlayerArenaProfileType EnemyPlayerProfile
    {
      [Token(Token = "0x60095B3"), Address(RVA = "0x48EEBC0", Offset = "0x48EEBC0", VA = "0x48EEBC0")] get
      {
        return (PlayerArenaProfileType) null;
      }
      [Token(Token = "0x60095B4"), Address(RVA = "0x48EEBC8", Offset = "0x48EEBC8", VA = "0x48EEBC8")] set
      {
      }
    }

    [Token(Token = "0x17001871")]
    public List<ArenaRankingNpcDeckUnitHistoryType> NpcDeckUnits
    {
      [Token(Token = "0x60095B5"), Address(RVA = "0x48EEBD0", Offset = "0x48EEBD0", VA = "0x48EEBD0")] get
      {
        return (List<ArenaRankingNpcDeckUnitHistoryType>) null;
      }
      [Token(Token = "0x60095B6"), Address(RVA = "0x48EEBD8", Offset = "0x48EEBD8", VA = "0x48EEBD8")] set
      {
      }
    }

    [Token(Token = "0x17001872")]
    public int BattlePower
    {
      [Token(Token = "0x60095B7"), Address(RVA = "0x48EEBE0", Offset = "0x48EEBE0", VA = "0x48EEBE0")] get
      {
        return new int();
      }
      [Token(Token = "0x60095B8"), Address(RVA = "0x48EEBE8", Offset = "0x48EEBE8", VA = "0x48EEBE8")] set
      {
      }
    }

    [Token(Token = "0x17001873")]
    public int EnemyBattlePower
    {
      [Token(Token = "0x60095B9"), Address(RVA = "0x48EEBF0", Offset = "0x48EEBF0", VA = "0x48EEBF0")] get
      {
        return new int();
      }
      [Token(Token = "0x60095BA"), Address(RVA = "0x48EEBF8", Offset = "0x48EEBF8", VA = "0x48EEBF8")] set
      {
      }
    }

    [Token(Token = "0x17001874")]
    public int Seed
    {
      [Token(Token = "0x60095BB"), Address(RVA = "0x48EEC00", Offset = "0x48EEC00", VA = "0x48EEC00")] get
      {
        return new int();
      }
      [Token(Token = "0x60095BC"), Address(RVA = "0x48EEC08", Offset = "0x48EEC08", VA = "0x48EEC08")] set
      {
      }
    }

    [Token(Token = "0x60095BD")]
    [Address(RVA = "0x48EEC10", Offset = "0x48EEC10", VA = "0x48EEC10")]
    public ArenaBattleHistoryType()
    {
    }
  }
}
