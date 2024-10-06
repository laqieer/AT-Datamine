// Decompiled with JetBrains decompiler
// Type: Network.API.APIFreeQuestBattleStartResponse
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
  [Token(Token = "0x2001C4C")]
  [Serializable]
  public class APIFreeQuestBattleStartResponse : ICommonApiResult
  {
    [Token(Token = "0x400793C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400793D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x400793E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerBattleEnemyDrops enemy_drops;
    [Token(Token = "0x400793F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerBattleChestDropType> chest_drops;
    [Token(Token = "0x4007940")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitLevelUpType> player_unit_level_ups;
    [Token(Token = "0x4007941")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x4007942")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string battle_uuid;

    [Token(Token = "0x17001F86")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A69F"), Address(RVA = "0x190B6C0", Offset = "0x190B6C0", VA = "0x190B6C0", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001F87")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600A6A0"), Address(RVA = "0x190B6C8", Offset = "0x190B6C8", VA = "0x190B6C8")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x17001F88")]
    public PlayerBattleEnemyDrops EnemyDrops
    {
      [Token(Token = "0x600A6A1"), Address(RVA = "0x190B6D0", Offset = "0x190B6D0", VA = "0x190B6D0")] get
      {
        return (PlayerBattleEnemyDrops) null;
      }
    }

    [Token(Token = "0x17001F89")]
    public List<PlayerBattleChestDropType> ChestDrops
    {
      [Token(Token = "0x600A6A2"), Address(RVA = "0x190B6D8", Offset = "0x190B6D8", VA = "0x190B6D8")] get
      {
        return (List<PlayerBattleChestDropType>) null;
      }
    }

    [Token(Token = "0x17001F8A")]
    public List<PlayerUnitLevelUpType> PlayerUnitLevelUps
    {
      [Token(Token = "0x600A6A3"), Address(RVA = "0x190B6E0", Offset = "0x190B6E0", VA = "0x190B6E0")] get
      {
        return (List<PlayerUnitLevelUpType>) null;
      }
    }

    [Token(Token = "0x17001F8B")]
    public int RollbackCount
    {
      [Token(Token = "0x600A6A4"), Address(RVA = "0x190B6E8", Offset = "0x190B6E8", VA = "0x190B6E8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001F8C")]
    public string BattleUuid
    {
      [Token(Token = "0x600A6A5"), Address(RVA = "0x190B6F0", Offset = "0x190B6F0", VA = "0x190B6F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600A6A6")]
    [Address(RVA = "0x190B6F8", Offset = "0x190B6F8", VA = "0x190B6F8")]
    public APIFreeQuestBattleStartResponse()
    {
    }
  }
}
