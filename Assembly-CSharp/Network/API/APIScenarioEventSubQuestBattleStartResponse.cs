// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventSubQuestBattleStartResponse
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
  [Token(Token = "0x2001DEC")]
  [Serializable]
  public class APIScenarioEventSubQuestBattleStartResponse : ICommonApiResult
  {
    [Token(Token = "0x4008017")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4008018")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x4008019")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerBattleEnemyDrops enemy_drops;
    [Token(Token = "0x400801A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerBattleChestDropType> chest_drops;
    [Token(Token = "0x400801B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitLevelUpType> player_unit_level_ups;
    [Token(Token = "0x400801C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x400801D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string battle_uuid;

    [Token(Token = "0x17002368")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B101"), Address(RVA = "0x22DB1E4", Offset = "0x22DB1E4", VA = "0x22DB1E4", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002369")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600B102"), Address(RVA = "0x22DB1EC", Offset = "0x22DB1EC", VA = "0x22DB1EC")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x1700236A")]
    public PlayerBattleEnemyDrops EnemyDrops
    {
      [Token(Token = "0x600B103"), Address(RVA = "0x22DB1F4", Offset = "0x22DB1F4", VA = "0x22DB1F4")] get
      {
        return (PlayerBattleEnemyDrops) null;
      }
    }

    [Token(Token = "0x1700236B")]
    public List<PlayerBattleChestDropType> ChestDrops
    {
      [Token(Token = "0x600B104"), Address(RVA = "0x22DB1FC", Offset = "0x22DB1FC", VA = "0x22DB1FC")] get
      {
        return (List<PlayerBattleChestDropType>) null;
      }
    }

    [Token(Token = "0x1700236C")]
    public List<PlayerUnitLevelUpType> PlayerUnitLevelUps
    {
      [Token(Token = "0x600B105"), Address(RVA = "0x22DB204", Offset = "0x22DB204", VA = "0x22DB204")] get
      {
        return (List<PlayerUnitLevelUpType>) null;
      }
    }

    [Token(Token = "0x1700236D")]
    public int RollbackCount
    {
      [Token(Token = "0x600B106"), Address(RVA = "0x22DB20C", Offset = "0x22DB20C", VA = "0x22DB20C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700236E")]
    public string BattleUuid
    {
      [Token(Token = "0x600B107"), Address(RVA = "0x22DB214", Offset = "0x22DB214", VA = "0x22DB214")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600B108")]
    [Address(RVA = "0x22DB21C", Offset = "0x22DB21C", VA = "0x22DB21C")]
    public APIScenarioEventSubQuestBattleStartResponse()
    {
    }
  }
}
