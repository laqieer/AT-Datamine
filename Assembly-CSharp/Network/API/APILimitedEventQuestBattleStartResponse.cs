// Decompiled with JetBrains decompiler
// Type: Network.API.APILimitedEventQuestBattleStartResponse
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
  [Token(Token = "0x2001D48")]
  [Serializable]
  public class APILimitedEventQuestBattleStartResponse : ICommonApiResult
  {
    [Token(Token = "0x4007D17")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007D18")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x4007D19")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerBattleEnemyDrops enemy_drops;
    [Token(Token = "0x4007D1A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerBattleChestDropType> chest_drops;
    [Token(Token = "0x4007D1B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitLevelUpType> player_unit_level_ups;
    [Token(Token = "0x4007D1C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x4007D1D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string battle_uuid;

    [Token(Token = "0x170021A6")]
    public NoticeData Notice
    {
      [Token(Token = "0x600ACAF"), Address(RVA = "0x1A47434", Offset = "0x1A47434", VA = "0x1A47434", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170021A7")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600ACB0"), Address(RVA = "0x1A4743C", Offset = "0x1A4743C", VA = "0x1A4743C")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x170021A8")]
    public PlayerBattleEnemyDrops EnemyDrops
    {
      [Token(Token = "0x600ACB1"), Address(RVA = "0x1A47444", Offset = "0x1A47444", VA = "0x1A47444")] get
      {
        return (PlayerBattleEnemyDrops) null;
      }
    }

    [Token(Token = "0x170021A9")]
    public List<PlayerBattleChestDropType> ChestDrops
    {
      [Token(Token = "0x600ACB2"), Address(RVA = "0x1A4744C", Offset = "0x1A4744C", VA = "0x1A4744C")] get
      {
        return (List<PlayerBattleChestDropType>) null;
      }
    }

    [Token(Token = "0x170021AA")]
    public List<PlayerUnitLevelUpType> PlayerUnitLevelUps
    {
      [Token(Token = "0x600ACB3"), Address(RVA = "0x1A47454", Offset = "0x1A47454", VA = "0x1A47454")] get
      {
        return (List<PlayerUnitLevelUpType>) null;
      }
    }

    [Token(Token = "0x170021AB")]
    public int RollbackCount
    {
      [Token(Token = "0x600ACB4"), Address(RVA = "0x1A4745C", Offset = "0x1A4745C", VA = "0x1A4745C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170021AC")]
    public string BattleUuid
    {
      [Token(Token = "0x600ACB5"), Address(RVA = "0x1A47464", Offset = "0x1A47464", VA = "0x1A47464")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600ACB6")]
    [Address(RVA = "0x1A4746C", Offset = "0x1A4746C", VA = "0x1A4746C")]
    public APILimitedEventQuestBattleStartResponse()
    {
    }
  }
}
