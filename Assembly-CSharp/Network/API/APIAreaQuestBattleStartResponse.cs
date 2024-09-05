// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestBattleStartResponse
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
  [Token(Token = "0x2001B78")]
  [Serializable]
  public class APIAreaQuestBattleStartResponse : ICommonApiResult
  {
    [Token(Token = "0x40075CA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40075CB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x40075CC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerBattleEnemyDrops enemy_drops;
    [Token(Token = "0x40075CD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerBattleChestDropType> chest_drops;
    [Token(Token = "0x40075CE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitLevelUpType> player_unit_level_ups;
    [Token(Token = "0x40075CF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x40075D0")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string battle_uuid;

    [Token(Token = "0x17001D8A")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A153"), Address(RVA = "0x46C7800", Offset = "0x46C7800", VA = "0x46C7800", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001D8B")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600A154"), Address(RVA = "0x46C7808", Offset = "0x46C7808", VA = "0x46C7808")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x17001D8C")]
    public PlayerBattleEnemyDrops EnemyDrops
    {
      [Token(Token = "0x600A155"), Address(RVA = "0x46C7810", Offset = "0x46C7810", VA = "0x46C7810")] get
      {
        return (PlayerBattleEnemyDrops) null;
      }
    }

    [Token(Token = "0x17001D8D")]
    public List<PlayerBattleChestDropType> ChestDrops
    {
      [Token(Token = "0x600A156"), Address(RVA = "0x46C7818", Offset = "0x46C7818", VA = "0x46C7818")] get
      {
        return (List<PlayerBattleChestDropType>) null;
      }
    }

    [Token(Token = "0x17001D8E")]
    public List<PlayerUnitLevelUpType> PlayerUnitLevelUps
    {
      [Token(Token = "0x600A157"), Address(RVA = "0x46C7820", Offset = "0x46C7820", VA = "0x46C7820")] get
      {
        return (List<PlayerUnitLevelUpType>) null;
      }
    }

    [Token(Token = "0x17001D8F")]
    public int RollbackCount
    {
      [Token(Token = "0x600A158"), Address(RVA = "0x46C7828", Offset = "0x46C7828", VA = "0x46C7828")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001D90")]
    public string BattleUuid
    {
      [Token(Token = "0x600A159"), Address(RVA = "0x46C7830", Offset = "0x46C7830", VA = "0x46C7830")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600A15A")]
    [Address(RVA = "0x46C7838", Offset = "0x46C7838", VA = "0x46C7838")]
    public APIAreaQuestBattleStartResponse()
    {
    }
  }
}
