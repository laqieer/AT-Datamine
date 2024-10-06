// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventFreeQuestBattleStartResponse
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
  [Token(Token = "0x2001DDC")]
  [Serializable]
  public class APIScenarioEventFreeQuestBattleStartResponse : ICommonApiResult
  {
    [Token(Token = "0x4007F9E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007F9F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x4007FA0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerBattleEnemyDrops enemy_drops;
    [Token(Token = "0x4007FA1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerBattleChestDropType> chest_drops;
    [Token(Token = "0x4007FA2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitLevelUpType> player_unit_level_ups;
    [Token(Token = "0x4007FA3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x4007FA4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string battle_uuid;

    [Token(Token = "0x1700232F")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B088"), Address(RVA = "0x1A53D58", Offset = "0x1A53D58", VA = "0x1A53D58", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002330")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600B089"), Address(RVA = "0x1A53D60", Offset = "0x1A53D60", VA = "0x1A53D60")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x17002331")]
    public PlayerBattleEnemyDrops EnemyDrops
    {
      [Token(Token = "0x600B08A"), Address(RVA = "0x1A53D68", Offset = "0x1A53D68", VA = "0x1A53D68")] get
      {
        return (PlayerBattleEnemyDrops) null;
      }
    }

    [Token(Token = "0x17002332")]
    public List<PlayerBattleChestDropType> ChestDrops
    {
      [Token(Token = "0x600B08B"), Address(RVA = "0x1A53D70", Offset = "0x1A53D70", VA = "0x1A53D70")] get
      {
        return (List<PlayerBattleChestDropType>) null;
      }
    }

    [Token(Token = "0x17002333")]
    public List<PlayerUnitLevelUpType> PlayerUnitLevelUps
    {
      [Token(Token = "0x600B08C"), Address(RVA = "0x1A53D78", Offset = "0x1A53D78", VA = "0x1A53D78")] get
      {
        return (List<PlayerUnitLevelUpType>) null;
      }
    }

    [Token(Token = "0x17002334")]
    public int RollbackCount
    {
      [Token(Token = "0x600B08D"), Address(RVA = "0x1A53D80", Offset = "0x1A53D80", VA = "0x1A53D80")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002335")]
    public string BattleUuid
    {
      [Token(Token = "0x600B08E"), Address(RVA = "0x1A53D88", Offset = "0x1A53D88", VA = "0x1A53D88")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600B08F")]
    [Address(RVA = "0x1A53D90", Offset = "0x1A53D90", VA = "0x1A53D90")]
    public APIScenarioEventFreeQuestBattleStartResponse()
    {
    }
  }
}
