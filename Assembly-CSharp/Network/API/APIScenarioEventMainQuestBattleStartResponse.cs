// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventMainQuestBattleStartResponse
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
  [Token(Token = "0x2001DE4")]
  [Serializable]
  public class APIScenarioEventMainQuestBattleStartResponse : ICommonApiResult
  {
    [Token(Token = "0x4007FDB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007FDC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerDeckType player_deck;
    [Token(Token = "0x4007FDD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerBattleEnemyDrops enemy_drops;
    [Token(Token = "0x4007FDE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerBattleChestDropType> chest_drops;
    [Token(Token = "0x4007FDF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitLevelUpType> player_unit_level_ups;
    [Token(Token = "0x4007FE0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x4007FE1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string battle_uuid;

    [Token(Token = "0x1700234B")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B0C4"), Address(RVA = "0x1A54870", Offset = "0x1A54870", VA = "0x1A54870", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x1700234C")]
    public PlayerDeckType PlayerDeck
    {
      [Token(Token = "0x600B0C5"), Address(RVA = "0x1A54878", Offset = "0x1A54878", VA = "0x1A54878")] get
      {
        return (PlayerDeckType) null;
      }
    }

    [Token(Token = "0x1700234D")]
    public PlayerBattleEnemyDrops EnemyDrops
    {
      [Token(Token = "0x600B0C6"), Address(RVA = "0x1A54880", Offset = "0x1A54880", VA = "0x1A54880")] get
      {
        return (PlayerBattleEnemyDrops) null;
      }
    }

    [Token(Token = "0x1700234E")]
    public List<PlayerBattleChestDropType> ChestDrops
    {
      [Token(Token = "0x600B0C7"), Address(RVA = "0x1A54888", Offset = "0x1A54888", VA = "0x1A54888")] get
      {
        return (List<PlayerBattleChestDropType>) null;
      }
    }

    [Token(Token = "0x1700234F")]
    public List<PlayerUnitLevelUpType> PlayerUnitLevelUps
    {
      [Token(Token = "0x600B0C8"), Address(RVA = "0x1A54890", Offset = "0x1A54890", VA = "0x1A54890")] get
      {
        return (List<PlayerUnitLevelUpType>) null;
      }
    }

    [Token(Token = "0x17002350")]
    public int RollbackCount
    {
      [Token(Token = "0x600B0C9"), Address(RVA = "0x1A54898", Offset = "0x1A54898", VA = "0x1A54898")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002351")]
    public string BattleUuid
    {
      [Token(Token = "0x600B0CA"), Address(RVA = "0x1A548A0", Offset = "0x1A548A0", VA = "0x1A548A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600B0CB")]
    [Address(RVA = "0x1A548A8", Offset = "0x1A548A8", VA = "0x1A548A8")]
    public APIScenarioEventMainQuestBattleStartResponse()
    {
    }
  }
}
