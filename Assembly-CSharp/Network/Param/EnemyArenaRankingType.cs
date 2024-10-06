// Decompiled with JetBrains decompiler
// Type: Network.Param.EnemyArenaRankingType
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
  [Token(Token = "0x2001A52")]
  [Serializable]
  public class EnemyArenaRankingType
  {
    [Token(Token = "0x4007096")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int ranking;
    [Token(Token = "0x4007097")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerOpenProfileType player_profile;
    [Token(Token = "0x4007098")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerUnitArenaType> player_units;
    [Token(Token = "0x4007099")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<ArenaDeckUnitType> deck_units;
    [Token(Token = "0x400709A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private long battle_power;

    [Token(Token = "0x170018CC")]
    public int Ranking
    {
      [Token(Token = "0x6009680"), Address(RVA = "0x48EF240", Offset = "0x48EF240", VA = "0x48EF240")] get
      {
        return new int();
      }
      [Token(Token = "0x6009681"), Address(RVA = "0x48EF248", Offset = "0x48EF248", VA = "0x48EF248")] set
      {
      }
    }

    [Token(Token = "0x170018CD")]
    public PlayerOpenProfileType PlayerProfile
    {
      [Token(Token = "0x6009682"), Address(RVA = "0x48EF250", Offset = "0x48EF250", VA = "0x48EF250")] get
      {
        return (PlayerOpenProfileType) null;
      }
      [Token(Token = "0x6009683"), Address(RVA = "0x48EF258", Offset = "0x48EF258", VA = "0x48EF258")] set
      {
      }
    }

    [Token(Token = "0x170018CE")]
    public List<PlayerUnitArenaType> PlayerUnits
    {
      [Token(Token = "0x6009684"), Address(RVA = "0x48EF260", Offset = "0x48EF260", VA = "0x48EF260")] get
      {
        return (List<PlayerUnitArenaType>) null;
      }
      [Token(Token = "0x6009685"), Address(RVA = "0x48EF268", Offset = "0x48EF268", VA = "0x48EF268")] set
      {
      }
    }

    [Token(Token = "0x170018CF")]
    public List<ArenaDeckUnitType> DeckUnits
    {
      [Token(Token = "0x6009686"), Address(RVA = "0x48EF270", Offset = "0x48EF270", VA = "0x48EF270")] get
      {
        return (List<ArenaDeckUnitType>) null;
      }
      [Token(Token = "0x6009687"), Address(RVA = "0x48EF278", Offset = "0x48EF278", VA = "0x48EF278")] set
      {
      }
    }

    [Token(Token = "0x170018D0")]
    public long BattlePower
    {
      [Token(Token = "0x6009688"), Address(RVA = "0x48EF280", Offset = "0x48EF280", VA = "0x48EF280")] get
      {
        return new long();
      }
      [Token(Token = "0x6009689"), Address(RVA = "0x48EF288", Offset = "0x48EF288", VA = "0x48EF288")] set
      {
      }
    }

    [Token(Token = "0x600968A")]
    [Address(RVA = "0x48EF290", Offset = "0x48EF290", VA = "0x48EF290")]
    public EnemyArenaRankingType()
    {
    }
  }
}
