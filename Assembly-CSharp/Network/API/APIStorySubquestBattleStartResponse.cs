// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestBattleStartResponse
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
  [Token(Token = "0x2001E78")]
  [Serializable]
  public class APIStorySubquestBattleStartResponse : ICommonApiResult
  {
    [Token(Token = "0x40082F0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40082F1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x40082F2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerBattleEnemyDrops enemy_drops;
    [Token(Token = "0x40082F3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerBattleChestDropType> chest_drops;
    [Token(Token = "0x40082F4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitLevelUpType> player_unit_level_ups;
    [Token(Token = "0x40082F5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x40082F6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string battle_uuid;

    [Token(Token = "0x17002503")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B4CC"), Address(RVA = "0x22E7190", Offset = "0x22E7190", VA = "0x22E7190", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002504")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600B4CD"), Address(RVA = "0x22E7198", Offset = "0x22E7198", VA = "0x22E7198")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x17002505")]
    public PlayerBattleEnemyDrops EnemyDrops
    {
      [Token(Token = "0x600B4CE"), Address(RVA = "0x22E71A0", Offset = "0x22E71A0", VA = "0x22E71A0")] get
      {
        return (PlayerBattleEnemyDrops) null;
      }
    }

    [Token(Token = "0x17002506")]
    public List<PlayerBattleChestDropType> ChestDrops
    {
      [Token(Token = "0x600B4CF"), Address(RVA = "0x22E71A8", Offset = "0x22E71A8", VA = "0x22E71A8")] get
      {
        return (List<PlayerBattleChestDropType>) null;
      }
    }

    [Token(Token = "0x17002507")]
    public List<PlayerUnitLevelUpType> PlayerUnitLevelUps
    {
      [Token(Token = "0x600B4D0"), Address(RVA = "0x22E71B0", Offset = "0x22E71B0", VA = "0x22E71B0")] get
      {
        return (List<PlayerUnitLevelUpType>) null;
      }
    }

    [Token(Token = "0x17002508")]
    public int RollbackCount
    {
      [Token(Token = "0x600B4D1"), Address(RVA = "0x22E71B8", Offset = "0x22E71B8", VA = "0x22E71B8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002509")]
    public string BattleUuid
    {
      [Token(Token = "0x600B4D2"), Address(RVA = "0x22E71C0", Offset = "0x22E71C0", VA = "0x22E71C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600B4D3")]
    [Address(RVA = "0x22E71C8", Offset = "0x22E71C8", VA = "0x22E71C8")]
    public APIStorySubquestBattleStartResponse()
    {
    }
  }
}
