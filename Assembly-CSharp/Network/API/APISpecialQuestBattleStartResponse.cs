// Decompiled with JetBrains decompiler
// Type: Network.API.APISpecialQuestBattleStartResponse
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
  [Token(Token = "0x2001E20")]
  [Serializable]
  public class APISpecialQuestBattleStartResponse : ICommonApiResult
  {
    [Token(Token = "0x40080FD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40080FE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x40080FF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerBattleEnemyDrops enemy_drops;
    [Token(Token = "0x4008100")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerBattleChestDropType> chest_drops;
    [Token(Token = "0x4008101")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitLevelUpType> player_unit_level_ups;
    [Token(Token = "0x4008102")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x4008103")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string battle_uuid;

    [Token(Token = "0x170023E2")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B24B"), Address(RVA = "0x22DF820", Offset = "0x22DF820", VA = "0x22DF820", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170023E3")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600B24C"), Address(RVA = "0x22DF828", Offset = "0x22DF828", VA = "0x22DF828")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x170023E4")]
    public PlayerBattleEnemyDrops EnemyDrops
    {
      [Token(Token = "0x600B24D"), Address(RVA = "0x22DF830", Offset = "0x22DF830", VA = "0x22DF830")] get
      {
        return (PlayerBattleEnemyDrops) null;
      }
    }

    [Token(Token = "0x170023E5")]
    public List<PlayerBattleChestDropType> ChestDrops
    {
      [Token(Token = "0x600B24E"), Address(RVA = "0x22DF838", Offset = "0x22DF838", VA = "0x22DF838")] get
      {
        return (List<PlayerBattleChestDropType>) null;
      }
    }

    [Token(Token = "0x170023E6")]
    public List<PlayerUnitLevelUpType> PlayerUnitLevelUps
    {
      [Token(Token = "0x600B24F"), Address(RVA = "0x22DF840", Offset = "0x22DF840", VA = "0x22DF840")] get
      {
        return (List<PlayerUnitLevelUpType>) null;
      }
    }

    [Token(Token = "0x170023E7")]
    public int RollbackCount
    {
      [Token(Token = "0x600B250"), Address(RVA = "0x22DF848", Offset = "0x22DF848", VA = "0x22DF848")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170023E8")]
    public string BattleUuid
    {
      [Token(Token = "0x600B251"), Address(RVA = "0x22DF850", Offset = "0x22DF850", VA = "0x22DF850")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600B252")]
    [Address(RVA = "0x22DF858", Offset = "0x22DF858", VA = "0x22DF858")]
    public APISpecialQuestBattleStartResponse()
    {
    }
  }
}
