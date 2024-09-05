// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestBattleStartResponse
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
  [Token(Token = "0x2001E4C")]
  [Serializable]
  public class APIStoryMainquestBattleStartResponse : ICommonApiResult
  {
    [Token(Token = "0x40081ED")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40081EE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x40081EF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerBattleEnemyDrops enemy_drops;
    [Token(Token = "0x40081F0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerBattleChestDropType> chest_drops;
    [Token(Token = "0x40081F1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitLevelUpType> player_unit_level_ups;
    [Token(Token = "0x40081F2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x40081F3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string battle_uuid;

    [Token(Token = "0x1700246F")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B388"), Address(RVA = "0x22E34BC", Offset = "0x22E34BC", VA = "0x22E34BC", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002470")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600B389"), Address(RVA = "0x22E34C4", Offset = "0x22E34C4", VA = "0x22E34C4")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x17002471")]
    public PlayerBattleEnemyDrops EnemyDrops
    {
      [Token(Token = "0x600B38A"), Address(RVA = "0x22E34CC", Offset = "0x22E34CC", VA = "0x22E34CC")] get
      {
        return (PlayerBattleEnemyDrops) null;
      }
    }

    [Token(Token = "0x17002472")]
    public List<PlayerBattleChestDropType> ChestDrops
    {
      [Token(Token = "0x600B38B"), Address(RVA = "0x22E34D4", Offset = "0x22E34D4", VA = "0x22E34D4")] get
      {
        return (List<PlayerBattleChestDropType>) null;
      }
    }

    [Token(Token = "0x17002473")]
    public List<PlayerUnitLevelUpType> PlayerUnitLevelUps
    {
      [Token(Token = "0x600B38C"), Address(RVA = "0x22E34DC", Offset = "0x22E34DC", VA = "0x22E34DC")] get
      {
        return (List<PlayerUnitLevelUpType>) null;
      }
    }

    [Token(Token = "0x17002474")]
    public int RollbackCount
    {
      [Token(Token = "0x600B38D"), Address(RVA = "0x22E34E4", Offset = "0x22E34E4", VA = "0x22E34E4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002475")]
    public string BattleUuid
    {
      [Token(Token = "0x600B38E"), Address(RVA = "0x22E34EC", Offset = "0x22E34EC", VA = "0x22E34EC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600B38F")]
    [Address(RVA = "0x22E34F4", Offset = "0x22E34F4", VA = "0x22E34F4")]
    public APIStoryMainquestBattleStartResponse()
    {
    }
  }
}
