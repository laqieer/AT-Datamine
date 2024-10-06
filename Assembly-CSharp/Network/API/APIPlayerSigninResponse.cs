// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerSigninResponse
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
  [Token(Token = "0x2001DAC")]
  [Serializable]
  public class APIPlayerSigninResponse : ICommonApiResult
  {
    [Token(Token = "0x4007E91")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007E92")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerType player;
    [Token(Token = "0x4007E93")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerUnitCharacterType> player_unit_characters;
    [Token(Token = "0x4007E94")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerCommunicationSkillType> player_communication_skills;
    [Token(Token = "0x4007E95")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerUnitSupportType> player_unit_supports;
    [Token(Token = "0x4007E96")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerUnitType> player_units;
    [Token(Token = "0x4007E97")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerGearWeaponType> player_gear_weapons;
    [Token(Token = "0x4007E98")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerGearAccessoryType> player_gear_accessories;
    [Token(Token = "0x4007E99")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerGearMindEquipmentType> player_gear_mind_equipments;
    [Token(Token = "0x4007E9A")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayerStyleMasterBonusType> player_style_master_bonuses;
    [Token(Token = "0x4007E9B")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<PlayerWeaponMasterBonusType> player_weapon_master_bonuses;
    [Token(Token = "0x4007E9C")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private List<PlayerUnitCustomSkillType> player_unit_custom_skills;
    [Token(Token = "0x4007E9D")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private List<PlayerStoryChapterType> player_chapters;
    [Token(Token = "0x4007E9E")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private List<PlayerStoryChapterItemType> player_chapter_items;
    [Token(Token = "0x4007E9F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private List<int> player_story_ability_ids;
    [Token(Token = "0x4007EA0")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private List<PlayerDeckType> player_decks_battle5;
    [Token(Token = "0x4007EA1")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private List<PlayerDeckType> player_decks_battle10;
    [Token(Token = "0x4007EA2")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private List<PlayerDeckType> player_decks_battle15;
    [Token(Token = "0x4007EA3")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private List<PlayerItemsetType> player_item_sets;
    [Token(Token = "0x4007EA4")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private List<PlayerExpendableType> player_expendables;
    [Token(Token = "0x4007EA5")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private List<PlayerExchangeItemType> player_exchanges;
    [Token(Token = "0x4007EA6")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private List<PlayerEpType> player_ep;
    [Token(Token = "0x4007EA7")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private List<PlayerUnitEnhanceType> player_unit_enhances;
    [Token(Token = "0x4007EA8")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private List<PlayerUnitPieceType> player_unit_pieces;
    [Token(Token = "0x4007EA9")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private List<PlayerEquipmentSkillEnhanceItemType> player_equipment_skill_enhances;
    [Token(Token = "0x4007EAA")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private List<PlayerQuestBattleType> player_quests;
    [Token(Token = "0x4007EAB")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private List<PlayerQuestBattleMissionType> player_quest_battle_missions;
    [Token(Token = "0x4007EAC")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private bool is_battling;
    [Token(Token = "0x4007EAD")]
    [FieldOffset(Offset = "0xEC")]
    [SerializeField]
    private int rollback_count;
    [Token(Token = "0x4007EAE")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private ChartAggregation chart;
    [Token(Token = "0x4007EAF")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private PlayerGuildRelationSync guild_relation_sync;
    [Token(Token = "0x4007EB0")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private List<PlayerEmblemType> player_emblems;
    [Token(Token = "0x4007EB1")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private List<int> player_title_ids;
    [Token(Token = "0x4007EB2")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private List<PlayerSoulType> player_souls;
    [Token(Token = "0x4007EB3")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private PlayerProfileChangeType player_profile_change;
    [Token(Token = "0x4007EB4")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private List<PlayerWeaponPieceType> player_weapon_pieces;
    [Token(Token = "0x4007EB5")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private List<PlayerCurrencyItemType> player_currencies;
    [Token(Token = "0x4007EB6")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private List<PlayerGearUnitTrustType> player_gear_unit_trusts;
    [Token(Token = "0x4007EB7")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private PlayerWeaponOptionChangePending player_weapon_option_change_pending;
    [Token(Token = "0x4007EB8")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private List<PlayerUnitReincarnationMemoryType> player_unit_reincarnation_memories;
    [Token(Token = "0x4007EB9")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private List<PlayerMedalType> player_medals;
    [Token(Token = "0x4007EBA")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private List<PlayerGachaTicketType> player_gacha_ticket_items;
    [Token(Token = "0x4007EBB")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private List<PlayerChatStampType> player_chat_stamps;
    [Token(Token = "0x4007EBC")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private List<Network.Param.PlayerChatHistoryPin> player_chat_history_pin;
    [Token(Token = "0x4007EBD")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private List<PlayerChatPhraseType> player_chat_phrases;
    [Token(Token = "0x4007EBE")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private List<PlayerAbilityBoardItemType> player_ability_board_items;
    [Token(Token = "0x4007EBF")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private int suspend_resume_type_id;
    [Token(Token = "0x4007EC0")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    private List<PlayerUnitWarrantyParameterType> player_unit_warranty_parameters;
    [Token(Token = "0x4007EC1")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    private List<PlayerRecoveryItemType> player_recovery_items;
    [Token(Token = "0x4007EC2")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private List<PlayerAccessoryPieceType> player_accessory_pieces;
    [Token(Token = "0x4007EC3")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    private List<PlayerBossChallengeTicketType> player_boss_challenge_tickets;
    [Token(Token = "0x4007EC4")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    private List<PlayerExpeditionRapidTicketType> player_expedition_rapid_tickets;
    [Token(Token = "0x4007EC5")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    private PlayerAccessoriesOptionChangePending player_accessories_option_change_pending;
    [Token(Token = "0x4007EC6")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    private List<LoginBonusInfoType> loginbonus_infos;
    [Token(Token = "0x4007EC7")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    private PlayerHomeSettingType player_home_setting;
    [Token(Token = "0x4007EC8")]
    [FieldOffset(Offset = "0x1C0")]
    [SerializeField]
    private List<OfficialMessageArticleType> official_message_articles;
    [Token(Token = "0x4007EC9")]
    [FieldOffset(Offset = "0x1C8")]
    [SerializeField]
    private List<PlayerGeneralItemType> player_general_items;
    [Token(Token = "0x4007ECA")]
    [FieldOffset(Offset = "0x1D0")]
    [SerializeField]
    private List<PlayerArenaBattleTicketType> player_arena_battle_tickets;
    [Token(Token = "0x4007ECB")]
    [FieldOffset(Offset = "0x1D8")]
    [SerializeField]
    private List<PlayerBoxItemType> player_box_items;
    [Token(Token = "0x4007ECC")]
    [FieldOffset(Offset = "0x1E0")]
    [SerializeField]
    private string next_day_start_at;
    [Token(Token = "0x4007ECD")]
    [FieldOffset(Offset = "0x1E8")]
    [SerializeField]
    private string next_week_start_at;
    [Token(Token = "0x4007ECE")]
    [FieldOffset(Offset = "0x1F0")]
    [SerializeField]
    private bool is_age_registered;
    [Token(Token = "0x4007ECF")]
    [FieldOffset(Offset = "0x1F8")]
    [SerializeField]
    private List<PlayerRewardPassType> reward_pass;
    [Token(Token = "0x4007ED0")]
    [FieldOffset(Offset = "0x200")]
    [SerializeField]
    private List<PlayerScoreAttackRankingRewardType> player_score_attack_ranking_rewards;
    [Token(Token = "0x4007ED1")]
    [FieldOffset(Offset = "0x208")]
    [SerializeField]
    private List<PlayerAreaNodeType> player_area_nodes;

    [Token(Token = "0x17002288")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AF21"), Address(RVA = "0x1A4FAE0", Offset = "0x1A4FAE0", VA = "0x1A4FAE0", Slot = "4")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002289")]
    public PlayerType Player
    {
      [Token(Token = "0x600AF22"), Address(RVA = "0x1A4FAE8", Offset = "0x1A4FAE8", VA = "0x1A4FAE8")] get
      {
        return (PlayerType) null;
      }
    }

    [Token(Token = "0x1700228A")]
    public List<PlayerUnitCharacterType> PlayerUnitCharacters
    {
      [Token(Token = "0x600AF23"), Address(RVA = "0x1A4FAF0", Offset = "0x1A4FAF0", VA = "0x1A4FAF0")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
    }

    [Token(Token = "0x1700228B")]
    public List<PlayerCommunicationSkillType> PlayerCommunicationSkills
    {
      [Token(Token = "0x600AF24"), Address(RVA = "0x1A4FAF8", Offset = "0x1A4FAF8", VA = "0x1A4FAF8")] get
      {
        return (List<PlayerCommunicationSkillType>) null;
      }
    }

    [Token(Token = "0x1700228C")]
    public List<PlayerUnitSupportType> PlayerUnitSupports
    {
      [Token(Token = "0x600AF25"), Address(RVA = "0x1A4FB00", Offset = "0x1A4FB00", VA = "0x1A4FB00")] get
      {
        return (List<PlayerUnitSupportType>) null;
      }
    }

    [Token(Token = "0x1700228D")]
    public List<PlayerUnitType> PlayerUnits
    {
      [Token(Token = "0x600AF26"), Address(RVA = "0x1A4FB08", Offset = "0x1A4FB08", VA = "0x1A4FB08")] get
      {
        return (List<PlayerUnitType>) null;
      }
    }

    [Token(Token = "0x1700228E")]
    public List<PlayerGearWeaponType> PlayerGearWeapons
    {
      [Token(Token = "0x600AF27"), Address(RVA = "0x1A4FB10", Offset = "0x1A4FB10", VA = "0x1A4FB10")] get
      {
        return (List<PlayerGearWeaponType>) null;
      }
    }

    [Token(Token = "0x1700228F")]
    public List<PlayerGearAccessoryType> PlayerGearAccessories
    {
      [Token(Token = "0x600AF28"), Address(RVA = "0x1A4FB18", Offset = "0x1A4FB18", VA = "0x1A4FB18")] get
      {
        return (List<PlayerGearAccessoryType>) null;
      }
    }

    [Token(Token = "0x17002290")]
    public List<PlayerGearMindEquipmentType> PlayerGearMindEquipments
    {
      [Token(Token = "0x600AF29"), Address(RVA = "0x1A4FB20", Offset = "0x1A4FB20", VA = "0x1A4FB20")] get
      {
        return (List<PlayerGearMindEquipmentType>) null;
      }
    }

    [Token(Token = "0x17002291")]
    public List<PlayerStyleMasterBonusType> PlayerStyleMasterBonuses
    {
      [Token(Token = "0x600AF2A"), Address(RVA = "0x1A4FB28", Offset = "0x1A4FB28", VA = "0x1A4FB28")] get
      {
        return (List<PlayerStyleMasterBonusType>) null;
      }
    }

    [Token(Token = "0x17002292")]
    public List<PlayerWeaponMasterBonusType> PlayerWeaponMasterBonuses
    {
      [Token(Token = "0x600AF2B"), Address(RVA = "0x1A4FB30", Offset = "0x1A4FB30", VA = "0x1A4FB30")] get
      {
        return (List<PlayerWeaponMasterBonusType>) null;
      }
    }

    [Token(Token = "0x17002293")]
    public List<PlayerUnitCustomSkillType> PlayerUnitCustomSkills
    {
      [Token(Token = "0x600AF2C"), Address(RVA = "0x1A4FB38", Offset = "0x1A4FB38", VA = "0x1A4FB38")] get
      {
        return (List<PlayerUnitCustomSkillType>) null;
      }
    }

    [Token(Token = "0x17002294")]
    public List<PlayerStoryChapterType> PlayerChapters
    {
      [Token(Token = "0x600AF2D"), Address(RVA = "0x1A4FB40", Offset = "0x1A4FB40", VA = "0x1A4FB40")] get
      {
        return (List<PlayerStoryChapterType>) null;
      }
    }

    [Token(Token = "0x17002295")]
    public List<PlayerStoryChapterItemType> PlayerChapterItems
    {
      [Token(Token = "0x600AF2E"), Address(RVA = "0x1A4FB48", Offset = "0x1A4FB48", VA = "0x1A4FB48")] get
      {
        return (List<PlayerStoryChapterItemType>) null;
      }
    }

    [Token(Token = "0x17002296")]
    public List<int> PlayerStoryAbilityIds
    {
      [Token(Token = "0x600AF2F"), Address(RVA = "0x1A4FB50", Offset = "0x1A4FB50", VA = "0x1A4FB50")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x17002297")]
    public List<PlayerDeckType> PlayerDecksBattle5
    {
      [Token(Token = "0x600AF30"), Address(RVA = "0x1A4FB58", Offset = "0x1A4FB58", VA = "0x1A4FB58")] get
      {
        return (List<PlayerDeckType>) null;
      }
    }

    [Token(Token = "0x17002298")]
    public List<PlayerDeckType> PlayerDecksBattle10
    {
      [Token(Token = "0x600AF31"), Address(RVA = "0x1A4FB60", Offset = "0x1A4FB60", VA = "0x1A4FB60")] get
      {
        return (List<PlayerDeckType>) null;
      }
    }

    [Token(Token = "0x17002299")]
    public List<PlayerDeckType> PlayerDecksBattle15
    {
      [Token(Token = "0x600AF32"), Address(RVA = "0x1A4FB68", Offset = "0x1A4FB68", VA = "0x1A4FB68")] get
      {
        return (List<PlayerDeckType>) null;
      }
    }

    [Token(Token = "0x1700229A")]
    public List<PlayerItemsetType> PlayerItemSets
    {
      [Token(Token = "0x600AF33"), Address(RVA = "0x1A4FB70", Offset = "0x1A4FB70", VA = "0x1A4FB70")] get
      {
        return (List<PlayerItemsetType>) null;
      }
    }

    [Token(Token = "0x1700229B")]
    public List<PlayerExpendableType> PlayerExpendables
    {
      [Token(Token = "0x600AF34"), Address(RVA = "0x1A4FB78", Offset = "0x1A4FB78", VA = "0x1A4FB78")] get
      {
        return (List<PlayerExpendableType>) null;
      }
    }

    [Token(Token = "0x1700229C")]
    public List<PlayerExchangeItemType> PlayerExchanges
    {
      [Token(Token = "0x600AF35"), Address(RVA = "0x1A4FB80", Offset = "0x1A4FB80", VA = "0x1A4FB80")] get
      {
        return (List<PlayerExchangeItemType>) null;
      }
    }

    [Token(Token = "0x1700229D")]
    public List<PlayerEpType> PlayerEp
    {
      [Token(Token = "0x600AF36"), Address(RVA = "0x1A4FB88", Offset = "0x1A4FB88", VA = "0x1A4FB88")] get
      {
        return (List<PlayerEpType>) null;
      }
    }

    [Token(Token = "0x1700229E")]
    public List<PlayerUnitEnhanceType> PlayerUnitEnhances
    {
      [Token(Token = "0x600AF37"), Address(RVA = "0x1A4FB90", Offset = "0x1A4FB90", VA = "0x1A4FB90")] get
      {
        return (List<PlayerUnitEnhanceType>) null;
      }
    }

    [Token(Token = "0x1700229F")]
    public List<PlayerUnitPieceType> PlayerUnitPieces
    {
      [Token(Token = "0x600AF38"), Address(RVA = "0x1A4FB98", Offset = "0x1A4FB98", VA = "0x1A4FB98")] get
      {
        return (List<PlayerUnitPieceType>) null;
      }
    }

    [Token(Token = "0x170022A0")]
    public List<PlayerEquipmentSkillEnhanceItemType> PlayerEquipmentSkillEnhances
    {
      [Token(Token = "0x600AF39"), Address(RVA = "0x1A4FBA0", Offset = "0x1A4FBA0", VA = "0x1A4FBA0")] get
      {
        return (List<PlayerEquipmentSkillEnhanceItemType>) null;
      }
    }

    [Token(Token = "0x170022A1")]
    public List<PlayerQuestBattleType> PlayerQuests
    {
      [Token(Token = "0x600AF3A"), Address(RVA = "0x1A4FBA8", Offset = "0x1A4FBA8", VA = "0x1A4FBA8")] get
      {
        return (List<PlayerQuestBattleType>) null;
      }
    }

    [Token(Token = "0x170022A2")]
    public List<PlayerQuestBattleMissionType> PlayerQuestBattleMissions
    {
      [Token(Token = "0x600AF3B"), Address(RVA = "0x1A4FBB0", Offset = "0x1A4FBB0", VA = "0x1A4FBB0")] get
      {
        return (List<PlayerQuestBattleMissionType>) null;
      }
    }

    [Token(Token = "0x170022A3")]
    public bool IsBattling
    {
      [Token(Token = "0x600AF3C"), Address(RVA = "0x1A4FBB8", Offset = "0x1A4FBB8", VA = "0x1A4FBB8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170022A4")]
    public int RollbackCount
    {
      [Token(Token = "0x600AF3D"), Address(RVA = "0x1A4FBC0", Offset = "0x1A4FBC0", VA = "0x1A4FBC0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170022A5")]
    public ChartAggregation Chart
    {
      [Token(Token = "0x600AF3E"), Address(RVA = "0x1A4FBC8", Offset = "0x1A4FBC8", VA = "0x1A4FBC8")] get
      {
        return (ChartAggregation) null;
      }
    }

    [Token(Token = "0x170022A6")]
    public PlayerGuildRelationSync GuildRelationSync
    {
      [Token(Token = "0x600AF3F"), Address(RVA = "0x1A4FBD0", Offset = "0x1A4FBD0", VA = "0x1A4FBD0")] get
      {
        return (PlayerGuildRelationSync) null;
      }
    }

    [Token(Token = "0x170022A7")]
    public List<PlayerEmblemType> PlayerEmblems
    {
      [Token(Token = "0x600AF40"), Address(RVA = "0x1A4FBD8", Offset = "0x1A4FBD8", VA = "0x1A4FBD8")] get
      {
        return (List<PlayerEmblemType>) null;
      }
    }

    [Token(Token = "0x170022A8")]
    public List<int> PlayerTitleIds
    {
      [Token(Token = "0x600AF41"), Address(RVA = "0x1A4FBE0", Offset = "0x1A4FBE0", VA = "0x1A4FBE0")] get
      {
        return (List<int>) null;
      }
    }

    [Token(Token = "0x170022A9")]
    public List<PlayerSoulType> PlayerSouls
    {
      [Token(Token = "0x600AF42"), Address(RVA = "0x1A4FBE8", Offset = "0x1A4FBE8", VA = "0x1A4FBE8")] get
      {
        return (List<PlayerSoulType>) null;
      }
    }

    [Token(Token = "0x170022AA")]
    public PlayerProfileChangeType PlayerProfileChange
    {
      [Token(Token = "0x600AF43"), Address(RVA = "0x1A4FBF0", Offset = "0x1A4FBF0", VA = "0x1A4FBF0")] get
      {
        return (PlayerProfileChangeType) null;
      }
    }

    [Token(Token = "0x170022AB")]
    public List<PlayerWeaponPieceType> PlayerWeaponPieces
    {
      [Token(Token = "0x600AF44"), Address(RVA = "0x1A4FBF8", Offset = "0x1A4FBF8", VA = "0x1A4FBF8")] get
      {
        return (List<PlayerWeaponPieceType>) null;
      }
    }

    [Token(Token = "0x170022AC")]
    public List<PlayerCurrencyItemType> PlayerCurrencies
    {
      [Token(Token = "0x600AF45"), Address(RVA = "0x1A4FC00", Offset = "0x1A4FC00", VA = "0x1A4FC00")] get
      {
        return (List<PlayerCurrencyItemType>) null;
      }
    }

    [Token(Token = "0x170022AD")]
    public List<PlayerGearUnitTrustType> PlayerGearUnitTrusts
    {
      [Token(Token = "0x600AF46"), Address(RVA = "0x1A4FC08", Offset = "0x1A4FC08", VA = "0x1A4FC08")] get
      {
        return (List<PlayerGearUnitTrustType>) null;
      }
    }

    [Token(Token = "0x170022AE")]
    public PlayerWeaponOptionChangePending PlayerWeaponOptionChangePending
    {
      [Token(Token = "0x600AF47"), Address(RVA = "0x1A4FC10", Offset = "0x1A4FC10", VA = "0x1A4FC10")] get
      {
        return (PlayerWeaponOptionChangePending) null;
      }
    }

    [Token(Token = "0x170022AF")]
    public List<PlayerUnitReincarnationMemoryType> PlayerUnitReincarnationMemories
    {
      [Token(Token = "0x600AF48"), Address(RVA = "0x1A4FC18", Offset = "0x1A4FC18", VA = "0x1A4FC18")] get
      {
        return (List<PlayerUnitReincarnationMemoryType>) null;
      }
    }

    [Token(Token = "0x170022B0")]
    public List<PlayerMedalType> PlayerMedals
    {
      [Token(Token = "0x600AF49"), Address(RVA = "0x1A4FC20", Offset = "0x1A4FC20", VA = "0x1A4FC20")] get
      {
        return (List<PlayerMedalType>) null;
      }
    }

    [Token(Token = "0x170022B1")]
    public List<PlayerGachaTicketType> PlayerGachaTicketItems
    {
      [Token(Token = "0x600AF4A"), Address(RVA = "0x1A4FC28", Offset = "0x1A4FC28", VA = "0x1A4FC28")] get
      {
        return (List<PlayerGachaTicketType>) null;
      }
    }

    [Token(Token = "0x170022B2")]
    public List<PlayerChatStampType> PlayerChatStamps
    {
      [Token(Token = "0x600AF4B"), Address(RVA = "0x1A4FC30", Offset = "0x1A4FC30", VA = "0x1A4FC30")] get
      {
        return (List<PlayerChatStampType>) null;
      }
    }

    [Token(Token = "0x170022B3")]
    public List<Network.Param.PlayerChatHistoryPin> PlayerChatHistoryPin
    {
      [Token(Token = "0x600AF4C"), Address(RVA = "0x1A4FC38", Offset = "0x1A4FC38", VA = "0x1A4FC38")] get
      {
        return (List<Network.Param.PlayerChatHistoryPin>) null;
      }
    }

    [Token(Token = "0x170022B4")]
    public List<PlayerChatPhraseType> PlayerChatPhrases
    {
      [Token(Token = "0x600AF4D"), Address(RVA = "0x1A4FC40", Offset = "0x1A4FC40", VA = "0x1A4FC40")] get
      {
        return (List<PlayerChatPhraseType>) null;
      }
    }

    [Token(Token = "0x170022B5")]
    public List<PlayerAbilityBoardItemType> PlayerAbilityBoardItems
    {
      [Token(Token = "0x600AF4E"), Address(RVA = "0x1A4FC48", Offset = "0x1A4FC48", VA = "0x1A4FC48")] get
      {
        return (List<PlayerAbilityBoardItemType>) null;
      }
    }

    [Token(Token = "0x170022B6")]
    public int SuspendResumeTypeId
    {
      [Token(Token = "0x600AF4F"), Address(RVA = "0x1A4FC50", Offset = "0x1A4FC50", VA = "0x1A4FC50")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170022B7")]
    public List<PlayerUnitWarrantyParameterType> PlayerUnitWarrantyParameters
    {
      [Token(Token = "0x600AF50"), Address(RVA = "0x1A4FC58", Offset = "0x1A4FC58", VA = "0x1A4FC58")] get
      {
        return (List<PlayerUnitWarrantyParameterType>) null;
      }
    }

    [Token(Token = "0x170022B8")]
    public List<PlayerRecoveryItemType> PlayerRecoveryItems
    {
      [Token(Token = "0x600AF51"), Address(RVA = "0x1A4FC60", Offset = "0x1A4FC60", VA = "0x1A4FC60")] get
      {
        return (List<PlayerRecoveryItemType>) null;
      }
    }

    [Token(Token = "0x170022B9")]
    public List<PlayerAccessoryPieceType> PlayerAccessoryPieces
    {
      [Token(Token = "0x600AF52"), Address(RVA = "0x1A4FC68", Offset = "0x1A4FC68", VA = "0x1A4FC68")] get
      {
        return (List<PlayerAccessoryPieceType>) null;
      }
    }

    [Token(Token = "0x170022BA")]
    public List<PlayerBossChallengeTicketType> PlayerBossChallengeTickets
    {
      [Token(Token = "0x600AF53"), Address(RVA = "0x1A4FC70", Offset = "0x1A4FC70", VA = "0x1A4FC70")] get
      {
        return (List<PlayerBossChallengeTicketType>) null;
      }
    }

    [Token(Token = "0x170022BB")]
    public List<PlayerExpeditionRapidTicketType> PlayerExpeditionRapidTickets
    {
      [Token(Token = "0x600AF54"), Address(RVA = "0x1A4FC78", Offset = "0x1A4FC78", VA = "0x1A4FC78")] get
      {
        return (List<PlayerExpeditionRapidTicketType>) null;
      }
    }

    [Token(Token = "0x170022BC")]
    public PlayerAccessoriesOptionChangePending PlayerAccessoriesOptionChangePending
    {
      [Token(Token = "0x600AF55"), Address(RVA = "0x1A4FC80", Offset = "0x1A4FC80", VA = "0x1A4FC80")] get
      {
        return (PlayerAccessoriesOptionChangePending) null;
      }
    }

    [Token(Token = "0x170022BD")]
    public List<LoginBonusInfoType> LoginbonusInfos
    {
      [Token(Token = "0x600AF56"), Address(RVA = "0x1A4FC88", Offset = "0x1A4FC88", VA = "0x1A4FC88")] get
      {
        return (List<LoginBonusInfoType>) null;
      }
    }

    [Token(Token = "0x170022BE")]
    public PlayerHomeSettingType PlayerHomeSetting
    {
      [Token(Token = "0x600AF57"), Address(RVA = "0x1A4FC90", Offset = "0x1A4FC90", VA = "0x1A4FC90")] get
      {
        return (PlayerHomeSettingType) null;
      }
    }

    [Token(Token = "0x170022BF")]
    public List<OfficialMessageArticleType> OfficialMessageArticles
    {
      [Token(Token = "0x600AF58"), Address(RVA = "0x1A4FC98", Offset = "0x1A4FC98", VA = "0x1A4FC98")] get
      {
        return (List<OfficialMessageArticleType>) null;
      }
    }

    [Token(Token = "0x170022C0")]
    public List<PlayerGeneralItemType> PlayerGeneralItems
    {
      [Token(Token = "0x600AF59"), Address(RVA = "0x1A4FCA0", Offset = "0x1A4FCA0", VA = "0x1A4FCA0")] get
      {
        return (List<PlayerGeneralItemType>) null;
      }
    }

    [Token(Token = "0x170022C1")]
    public List<PlayerArenaBattleTicketType> PlayerArenaBattleTickets
    {
      [Token(Token = "0x600AF5A"), Address(RVA = "0x1A4FCA8", Offset = "0x1A4FCA8", VA = "0x1A4FCA8")] get
      {
        return (List<PlayerArenaBattleTicketType>) null;
      }
    }

    [Token(Token = "0x170022C2")]
    public List<PlayerBoxItemType> PlayerBoxItems
    {
      [Token(Token = "0x600AF5B"), Address(RVA = "0x1A4FCB0", Offset = "0x1A4FCB0", VA = "0x1A4FCB0")] get
      {
        return (List<PlayerBoxItemType>) null;
      }
    }

    [Token(Token = "0x170022C3")]
    public string NextDayStartAt
    {
      [Token(Token = "0x600AF5C"), Address(RVA = "0x1A4FCB8", Offset = "0x1A4FCB8", VA = "0x1A4FCB8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170022C4")]
    public string NextWeekStartAt
    {
      [Token(Token = "0x600AF5D"), Address(RVA = "0x1A4FCC0", Offset = "0x1A4FCC0", VA = "0x1A4FCC0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170022C5")]
    public bool IsAgeRegistered
    {
      [Token(Token = "0x600AF5E"), Address(RVA = "0x1A4FCC8", Offset = "0x1A4FCC8", VA = "0x1A4FCC8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170022C6")]
    public List<PlayerRewardPassType> RewardPass
    {
      [Token(Token = "0x600AF5F"), Address(RVA = "0x1A4FCD0", Offset = "0x1A4FCD0", VA = "0x1A4FCD0")] get
      {
        return (List<PlayerRewardPassType>) null;
      }
    }

    [Token(Token = "0x170022C7")]
    public List<PlayerScoreAttackRankingRewardType> PlayerScoreAttackRankingRewards
    {
      [Token(Token = "0x600AF60"), Address(RVA = "0x1A4FCD8", Offset = "0x1A4FCD8", VA = "0x1A4FCD8")] get
      {
        return (List<PlayerScoreAttackRankingRewardType>) null;
      }
    }

    [Token(Token = "0x170022C8")]
    public List<PlayerAreaNodeType> PlayerAreaNodes
    {
      [Token(Token = "0x600AF61"), Address(RVA = "0x1A4FCE0", Offset = "0x1A4FCE0", VA = "0x1A4FCE0")] get
      {
        return (List<PlayerAreaNodeType>) null;
      }
    }

    [Token(Token = "0x600AF62")]
    [Address(RVA = "0x1A4FCE8", Offset = "0x1A4FCE8", VA = "0x1A4FCE8")]
    public APIPlayerSigninResponse()
    {
    }
  }
}
