// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryObliviaeBattleStartResponse
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
  [Token(Token = "0x2001E60")]
  [Serializable]
  public class APIStoryObliviaeBattleStartResponse : ICommonApiResult
  {
    [Token(Token = "0x400826B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400826C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x400826D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerBattleEnemyDrops enemy_drops;
    [Token(Token = "0x400826E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerBattleChestDropType> chest_drops;
    [Token(Token = "0x400826F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitLevelUpType> player_unit_level_ups;
    [Token(Token = "0x4008270")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x4008271")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string battle_uuid;

    [Token(Token = "0x170024B7")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B420"), Address(RVA = "0x22E5088", Offset = "0x22E5088", VA = "0x22E5088", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170024B8")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600B421"), Address(RVA = "0x22E5090", Offset = "0x22E5090", VA = "0x22E5090")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x170024B9")]
    public PlayerBattleEnemyDrops EnemyDrops
    {
      [Token(Token = "0x600B422"), Address(RVA = "0x22E5098", Offset = "0x22E5098", VA = "0x22E5098")] get
      {
        return (PlayerBattleEnemyDrops) null;
      }
    }

    [Token(Token = "0x170024BA")]
    public List<PlayerBattleChestDropType> ChestDrops
    {
      [Token(Token = "0x600B423"), Address(RVA = "0x22E50A0", Offset = "0x22E50A0", VA = "0x22E50A0")] get
      {
        return (List<PlayerBattleChestDropType>) null;
      }
    }

    [Token(Token = "0x170024BB")]
    public List<PlayerUnitLevelUpType> PlayerUnitLevelUps
    {
      [Token(Token = "0x600B424"), Address(RVA = "0x22E50A8", Offset = "0x22E50A8", VA = "0x22E50A8")] get
      {
        return (List<PlayerUnitLevelUpType>) null;
      }
    }

    [Token(Token = "0x170024BC")]
    public int RollbackCount
    {
      [Token(Token = "0x600B425"), Address(RVA = "0x22E50B0", Offset = "0x22E50B0", VA = "0x22E50B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170024BD")]
    public string BattleUuid
    {
      [Token(Token = "0x600B426"), Address(RVA = "0x22E50B8", Offset = "0x22E50B8", VA = "0x22E50B8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600B427")]
    [Address(RVA = "0x22E50C0", Offset = "0x22E50C0", VA = "0x22E50C0")]
    public APIStoryObliviaeBattleStartResponse()
    {
    }
  }
}
