// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerScoreAttackBattleResult
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
  [Token(Token = "0x2001AD4")]
  [Serializable]
  public class PlayerScoreAttackBattleResult
  {
    [Token(Token = "0x40072FE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerQuestBattleType player_quest;
    [Token(Token = "0x40072FF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerQuestBattleMissionType> updated_player_quest_battle_missions;
    [Token(Token = "0x4007300")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x4007301")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool is_high_score;

    [Token(Token = "0x17001B60")]
    public PlayerQuestBattleType PlayerQuest
    {
      [Token(Token = "0x6009BFF"), Address(RVA = "0x48F2084", Offset = "0x48F2084", VA = "0x48F2084")] get
      {
        return (PlayerQuestBattleType) null;
      }
      [Token(Token = "0x6009C00"), Address(RVA = "0x48F208C", Offset = "0x48F208C", VA = "0x48F208C")] set
      {
      }
    }

    [Token(Token = "0x17001B61")]
    public List<PlayerQuestBattleMissionType> UpdatedPlayerQuestBattleMissions
    {
      [Token(Token = "0x6009C01"), Address(RVA = "0x48F2094", Offset = "0x48F2094", VA = "0x48F2094")] get
      {
        return (List<PlayerQuestBattleMissionType>) null;
      }
      [Token(Token = "0x6009C02"), Address(RVA = "0x48F209C", Offset = "0x48F209C", VA = "0x48F209C")] set
      {
      }
    }

    [Token(Token = "0x17001B62")]
    public PlayerType Player
    {
      [Token(Token = "0x6009C03"), Address(RVA = "0x48F20A4", Offset = "0x48F20A4", VA = "0x48F20A4")] get
      {
        return (PlayerType) null;
      }
      [Token(Token = "0x6009C04"), Address(RVA = "0x48F20AC", Offset = "0x48F20AC", VA = "0x48F20AC")] set
      {
      }
    }

    [Token(Token = "0x17001B63")]
    public bool IsHighScore
    {
      [Token(Token = "0x6009C05"), Address(RVA = "0x48F20B4", Offset = "0x48F20B4", VA = "0x48F20B4")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009C06"), Address(RVA = "0x48F20BC", Offset = "0x48F20BC", VA = "0x48F20BC")] set
      {
      }
    }

    [Token(Token = "0x6009C07")]
    [Address(RVA = "0x48F20C8", Offset = "0x48F20C8", VA = "0x48F20C8")]
    public PlayerScoreAttackBattleResult()
    {
    }
  }
}
