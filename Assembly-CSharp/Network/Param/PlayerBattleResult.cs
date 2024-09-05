// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBattleResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A8F")]
  [Serializable]
  public class PlayerBattleResult
  {
    [Token(Token = "0x40071CD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PlayerQuestBattleType player_quest;
    [Token(Token = "0x40071CE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerQuestBattleMissionType> updated_player_quest_battle_missions;
    [Token(Token = "0x40071CF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerBattleRewardResult reward_result;
    [Token(Token = "0x40071D0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x40071D1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitSupportType> support_value_result_before;
    [Token(Token = "0x40071D2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerUnitSupportType> support_value_result_after;
    [Token(Token = "0x40071D3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerUnitType> before_player_units;
    [Token(Token = "0x40071D4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerUnitType> after_player_units;
    [Token(Token = "0x40071D5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerUnitCharacterType> before_player_unit_characters;
    [Token(Token = "0x40071D6")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayerUnitCharacterType> after_player_unit_characters;
    [Token(Token = "0x40071D7")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<PlayerGearWeaponType> weapons_before;
    [Token(Token = "0x40071D8")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private List<PlayerGearWeaponType> weapons_after;
    [Token(Token = "0x40071D9")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private List<PlayerGearAccessoryType> accessories_before;
    [Token(Token = "0x40071DA")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private List<PlayerGearAccessoryType> accessories_after;
    [Token(Token = "0x40071DB")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private List<PlayerWeaponMasterBonusType> player_weapon_master_bonuses;
    [Token(Token = "0x40071DC")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private int rollback_count;

    [Token(Token = "0x17001A11")]
    public PlayerQuestBattleType PlayerQuest
    {
      [Token(Token = "0x600993A"), Address(RVA = "0x48F07D0", Offset = "0x48F07D0", VA = "0x48F07D0")] get
      {
        return (PlayerQuestBattleType) null;
      }
      [Token(Token = "0x600993B"), Address(RVA = "0x48F07D8", Offset = "0x48F07D8", VA = "0x48F07D8")] set
      {
      }
    }

    [Token(Token = "0x17001A12")]
    public List<PlayerQuestBattleMissionType> UpdatedPlayerQuestBattleMissions
    {
      [Token(Token = "0x600993C"), Address(RVA = "0x48F07E0", Offset = "0x48F07E0", VA = "0x48F07E0")] get
      {
        return (List<PlayerQuestBattleMissionType>) null;
      }
      [Token(Token = "0x600993D"), Address(RVA = "0x48F07E8", Offset = "0x48F07E8", VA = "0x48F07E8")] set
      {
      }
    }

    [Token(Token = "0x17001A13")]
    public PlayerBattleRewardResult RewardResult
    {
      [Token(Token = "0x600993E"), Address(RVA = "0x48F07F0", Offset = "0x48F07F0", VA = "0x48F07F0")] get
      {
        return (PlayerBattleRewardResult) null;
      }
      [Token(Token = "0x600993F"), Address(RVA = "0x48F07F8", Offset = "0x48F07F8", VA = "0x48F07F8")] set
      {
      }
    }

    [Token(Token = "0x17001A14")]
    public PlayerType Player
    {
      [Token(Token = "0x6009940"), Address(RVA = "0x48F0800", Offset = "0x48F0800", VA = "0x48F0800")] get
      {
        return (PlayerType) null;
      }
      [Token(Token = "0x6009941"), Address(RVA = "0x48F0808", Offset = "0x48F0808", VA = "0x48F0808")] set
      {
      }
    }

    [Token(Token = "0x17001A15")]
    public List<PlayerUnitSupportType> SupportValueResultBefore
    {
      [Token(Token = "0x6009942"), Address(RVA = "0x48F0810", Offset = "0x48F0810", VA = "0x48F0810")] get
      {
        return (List<PlayerUnitSupportType>) null;
      }
      [Token(Token = "0x6009943"), Address(RVA = "0x48F0818", Offset = "0x48F0818", VA = "0x48F0818")] set
      {
      }
    }

    [Token(Token = "0x17001A16")]
    public List<PlayerUnitSupportType> SupportValueResultAfter
    {
      [Token(Token = "0x6009944"), Address(RVA = "0x48F0820", Offset = "0x48F0820", VA = "0x48F0820")] get
      {
        return (List<PlayerUnitSupportType>) null;
      }
      [Token(Token = "0x6009945"), Address(RVA = "0x48F0828", Offset = "0x48F0828", VA = "0x48F0828")] set
      {
      }
    }

    [Token(Token = "0x17001A17")]
    public List<PlayerUnitType> BeforePlayerUnits
    {
      [Token(Token = "0x6009946"), Address(RVA = "0x48F0830", Offset = "0x48F0830", VA = "0x48F0830")] get
      {
        return (List<PlayerUnitType>) null;
      }
      [Token(Token = "0x6009947"), Address(RVA = "0x48F0838", Offset = "0x48F0838", VA = "0x48F0838")] set
      {
      }
    }

    [Token(Token = "0x17001A18")]
    public List<PlayerUnitType> AfterPlayerUnits
    {
      [Token(Token = "0x6009948"), Address(RVA = "0x48F0840", Offset = "0x48F0840", VA = "0x48F0840")] get
      {
        return (List<PlayerUnitType>) null;
      }
      [Token(Token = "0x6009949"), Address(RVA = "0x48F0848", Offset = "0x48F0848", VA = "0x48F0848")] set
      {
      }
    }

    [Token(Token = "0x17001A19")]
    public List<PlayerUnitCharacterType> BeforePlayerUnitCharacters
    {
      [Token(Token = "0x600994A"), Address(RVA = "0x48F0850", Offset = "0x48F0850", VA = "0x48F0850")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
      [Token(Token = "0x600994B"), Address(RVA = "0x48F0858", Offset = "0x48F0858", VA = "0x48F0858")] set
      {
      }
    }

    [Token(Token = "0x17001A1A")]
    public List<PlayerUnitCharacterType> AfterPlayerUnitCharacters
    {
      [Token(Token = "0x600994C"), Address(RVA = "0x48F0860", Offset = "0x48F0860", VA = "0x48F0860")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
      [Token(Token = "0x600994D"), Address(RVA = "0x48F0868", Offset = "0x48F0868", VA = "0x48F0868")] set
      {
      }
    }

    [Token(Token = "0x17001A1B")]
    public List<PlayerGearWeaponType> WeaponsBefore
    {
      [Token(Token = "0x600994E"), Address(RVA = "0x48F0870", Offset = "0x48F0870", VA = "0x48F0870")] get
      {
        return (List<PlayerGearWeaponType>) null;
      }
      [Token(Token = "0x600994F"), Address(RVA = "0x48F0878", Offset = "0x48F0878", VA = "0x48F0878")] set
      {
      }
    }

    [Token(Token = "0x17001A1C")]
    public List<PlayerGearWeaponType> WeaponsAfter
    {
      [Token(Token = "0x6009950"), Address(RVA = "0x48F0880", Offset = "0x48F0880", VA = "0x48F0880")] get
      {
        return (List<PlayerGearWeaponType>) null;
      }
      [Token(Token = "0x6009951"), Address(RVA = "0x48F0888", Offset = "0x48F0888", VA = "0x48F0888")] set
      {
      }
    }

    [Token(Token = "0x17001A1D")]
    public List<PlayerGearAccessoryType> AccessoriesBefore
    {
      [Token(Token = "0x6009952"), Address(RVA = "0x48F0890", Offset = "0x48F0890", VA = "0x48F0890")] get
      {
        return (List<PlayerGearAccessoryType>) null;
      }
      [Token(Token = "0x6009953"), Address(RVA = "0x48F0898", Offset = "0x48F0898", VA = "0x48F0898")] set
      {
      }
    }

    [Token(Token = "0x17001A1E")]
    public List<PlayerGearAccessoryType> AccessoriesAfter
    {
      [Token(Token = "0x6009954"), Address(RVA = "0x48F08A0", Offset = "0x48F08A0", VA = "0x48F08A0")] get
      {
        return (List<PlayerGearAccessoryType>) null;
      }
      [Token(Token = "0x6009955"), Address(RVA = "0x48F08A8", Offset = "0x48F08A8", VA = "0x48F08A8")] set
      {
      }
    }

    [Token(Token = "0x17001A1F")]
    public List<PlayerWeaponMasterBonusType> PlayerWeaponMasterBonuses
    {
      [Token(Token = "0x6009956"), Address(RVA = "0x48F08B0", Offset = "0x48F08B0", VA = "0x48F08B0")] get
      {
        return (List<PlayerWeaponMasterBonusType>) null;
      }
      [Token(Token = "0x6009957"), Address(RVA = "0x48F08B8", Offset = "0x48F08B8", VA = "0x48F08B8")] set
      {
      }
    }

    [Token(Token = "0x17001A20")]
    public int RollbackCount
    {
      [Token(Token = "0x6009958"), Address(RVA = "0x48F08C0", Offset = "0x48F08C0", VA = "0x48F08C0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009959"), Address(RVA = "0x48F08C8", Offset = "0x48F08C8", VA = "0x48F08C8")] set
      {
      }
    }

    [Token(Token = "0x600995A")]
    [Address(RVA = "0x48F08D0", Offset = "0x48F08D0", VA = "0x48F08D0")]
    public PlayerBattleResult()
    {
    }
  }
}
