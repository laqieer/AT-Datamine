// Decompiled with JetBrains decompiler
// Type: StaqData.PlayerProfile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using Scenes.OutGame;
using StaqData.Battle;
using StaqData.Infomation;
using System.Collections.Generic;
using TeamOrganization;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200204F")]
  public class PlayerProfile
  {
    [Token(Token = "0x4008981")]
    [FieldOffset(Offset = "0x18")]
    public Player player;
    [Token(Token = "0x4008982")]
    [FieldOffset(Offset = "0x20")]
    public Dictionary<string, Character> characterDic;
    [Token(Token = "0x4008984")]
    [FieldOffset(Offset = "0x30")]
    public Dictionary<string, Style> styleDic;
    [Token(Token = "0x4008985")]
    [FieldOffset(Offset = "0x38")]
    public Dictionary<string, UnitTrust> unitTrustDic;
    [Token(Token = "0x4008986")]
    [FieldOffset(Offset = "0x40")]
    public Dictionary<string, Weapon> weaponDic;
    [Token(Token = "0x4008987")]
    [FieldOffset(Offset = "0x48")]
    public Dictionary<string, Accessory> accessoryDic;
    [Token(Token = "0x4008988")]
    [FieldOffset(Offset = "0x50")]
    public Dictionary<string, MindEquipment> mindEquipmentDic;
    [Token(Token = "0x4008989")]
    [FieldOffset(Offset = "0x58")]
    public Dictionary<string, Expendable> expendableDic;
    [Token(Token = "0x400898A")]
    [FieldOffset(Offset = "0x60")]
    public Dictionary<int, SkillEnhanceItem> skillEnhanceItemDic;
    [Token(Token = "0x400898B")]
    [FieldOffset(Offset = "0x68")]
    public Dictionary<string, CustomSkill> customSkillDic;
    [Token(Token = "0x400898C")]
    [FieldOffset(Offset = "0x70")]
    public Dictionary<int, WeaponPieceItem> WeaponPieceDic;
    [Token(Token = "0x400898D")]
    [FieldOffset(Offset = "0x78")]
    public Dictionary<int, AccessoryPieceItem> AccessoryPieceDic;
    [Token(Token = "0x400898E")]
    [FieldOffset(Offset = "0x80")]
    public Dictionary<int, ExchangeItem> exchangeItemDic;
    [Token(Token = "0x400898F")]
    [FieldOffset(Offset = "0x88")]
    public Dictionary<int, EpItem> epItemDic;
    [Token(Token = "0x4008990")]
    [FieldOffset(Offset = "0x90")]
    public Dictionary<int, CurrencyItem> currencyItemDic;
    [Token(Token = "0x4008991")]
    [FieldOffset(Offset = "0x98")]
    public Dictionary<int, UnitPieceItem> unitPieceItemDic;
    [Token(Token = "0x4008992")]
    [FieldOffset(Offset = "0xA0")]
    public Dictionary<int, Soul> soulDic;
    [Token(Token = "0x4008993")]
    [FieldOffset(Offset = "0xA8")]
    public Dictionary<int, AbilityBoardItem> abilityBoardItemDic;
    [Token(Token = "0x4008994")]
    [FieldOffset(Offset = "0xB0")]
    public Dictionary<int, StyleMasterBonus> styleMasterBonusExpDic;
    [Token(Token = "0x4008995")]
    [FieldOffset(Offset = "0xB8")]
    public Dictionary<int, BoxItem> boxItemDic;
    [Token(Token = "0x4008996")]
    [FieldOffset(Offset = "0xC0")]
    public Dictionary<int, PersonalEmblemItem> personalEmblemItemDic;
    [Token(Token = "0x4008997")]
    [FieldOffset(Offset = "0xC8")]
    public Dictionary<int, WeaponMasterBonus> weaponMasterBonusExpDic;
    [Token(Token = "0x4008998")]
    [FieldOffset(Offset = "0xD0")]
    private List<BattleItemset> battleItemsetList;
    [Token(Token = "0x4008999")]
    [FieldOffset(Offset = "0xD8")]
    private Dictionary<int, UnitEnhance> unitEnhanceItemsetDic;
    [Token(Token = "0x400899A")]
    [FieldOffset(Offset = "0xE0")]
    public Dictionary<int, EnergyRecoveryItem> recoveryItemDic;
    [Token(Token = "0x400899B")]
    [FieldOffset(Offset = "0xE8")]
    public Dictionary<int, GeneralItem> generalItemDic;
    [Token(Token = "0x400899C")]
    [FieldOffset(Offset = "0xF0")]
    private Decks currentDecks;
    [Token(Token = "0x40089A5")]
    [FieldOffset(Offset = "0x138")]
    public Dictionary<string, ReincarnationMemory> ReincarnationMemoryDic;
    [Token(Token = "0x40089AD")]
    [FieldOffset(Offset = "0x178")]
    public Dictionary<int, CommunicationSkill> commuSkillDic;
    [Token(Token = "0x40089AE")]
    [FieldOffset(Offset = "0x180")]
    public Dictionary<int, MedalItem> MedalDic;
    [Token(Token = "0x40089AF")]
    [FieldOffset(Offset = "0x188")]
    public Dictionary<int, PassData> PassDic;
    [Token(Token = "0x40089B6")]
    [FieldOffset(Offset = "0x1C0")]
    public List<PlayerScoreAttackRankingRewardType> PlayerScoreAttackRankingRewards;
    [Token(Token = "0x40089B7")]
    [FieldOffset(Offset = "0x1C8")]
    public Dictionary<int, BossChallengeTicketItem> bossChallengeTicketItemDic;
    [Token(Token = "0x40089B8")]
    [FieldOffset(Offset = "0x1D0")]
    public Dictionary<int, GachaTicketItem> GachaTicketDic;
    [Token(Token = "0x40089BA")]
    [FieldOffset(Offset = "0x1E0")]
    public Dictionary<int, ExpeditionRapidTicketItem> expeditionRapidTicketItemDic;
    [Token(Token = "0x40089BB")]
    [FieldOffset(Offset = "0x1E8")]
    public Dictionary<int, ArenaBattleTicketItem> arenaBattleTicketItemDic;

    [Token(Token = "0x170028E7")]
    public bool IsUpdateHomeParameter
    {
      [Token(Token = "0x600C22A"), Address(RVA = "0x193FEF4", Offset = "0x193FEF4", VA = "0x193FEF4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C22B"), Address(RVA = "0x193FEFC", Offset = "0x193FEFC", VA = "0x193FEFC")] private set
      {
      }
    }

    [Token(Token = "0x170028E8")]
    public bool IsArmouryBadgeState
    {
      [Token(Token = "0x600C22C"), Address(RVA = "0x193FF08", Offset = "0x193FF08", VA = "0x193FF08")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C22D"), Address(RVA = "0x193FF10", Offset = "0x193FF10", VA = "0x193FF10")] private set
      {
      }
    }

    [Token(Token = "0x170028E9")]
    public bool IsStyleBadgeState
    {
      [Token(Token = "0x600C22E"), Address(RVA = "0x193FF1C", Offset = "0x193FF1C", VA = "0x193FF1C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C22F"), Address(RVA = "0x193FF24", Offset = "0x193FF24", VA = "0x193FF24")] private set
      {
      }
    }

    [Token(Token = "0x170028EA")]
    public bool IsWeaponBadgeState
    {
      [Token(Token = "0x600C230"), Address(RVA = "0x193FF30", Offset = "0x193FF30", VA = "0x193FF30")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C231"), Address(RVA = "0x193FF38", Offset = "0x193FF38", VA = "0x193FF38")] private set
      {
      }
    }

    [Token(Token = "0x170028EB")]
    public bool IsAccessoryBadgeState
    {
      [Token(Token = "0x600C232"), Address(RVA = "0x193FF44", Offset = "0x193FF44", VA = "0x193FF44")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C233"), Address(RVA = "0x193FF4C", Offset = "0x193FF4C", VA = "0x193FF4C")] private set
      {
      }
    }

    [Token(Token = "0x170028EC")]
    public bool IsMindEquipmentBadgeState
    {
      [Token(Token = "0x600C234"), Address(RVA = "0x193FF58", Offset = "0x193FF58", VA = "0x193FF58")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C235"), Address(RVA = "0x193FF60", Offset = "0x193FF60", VA = "0x193FF60")] private set
      {
      }
    }

    [Token(Token = "0x170028ED")]
    public bool IsItemBadgeState
    {
      [Token(Token = "0x600C236"), Address(RVA = "0x193FF6C", Offset = "0x193FF6C", VA = "0x193FF6C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C237"), Address(RVA = "0x193FF74", Offset = "0x193FF74", VA = "0x193FF74")] private set
      {
      }
    }

    [Token(Token = "0x600C238")]
    [Address(RVA = "0x193FF80", Offset = "0x193FF80", VA = "0x193FF80")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600C239")]
    [Address(RVA = "0x193FF84", Offset = "0x193FF84", VA = "0x193FF84")]
    public void Apply(PlayerType entity)
    {
    }

    [Token(Token = "0x600C23A")]
    [Address(RVA = "0x19401B4", Offset = "0x19401B4", VA = "0x19401B4")]
    public void ResetShortId()
    {
    }

    [Token(Token = "0x600C23B")]
    [Address(RVA = "0x194027C", Offset = "0x194027C", VA = "0x194027C")]
    public void ApplyPlayerSignin(APIPlayerSigninResponse signinRespons)
    {
    }

    [Token(Token = "0x600C23C")]
    [Address(RVA = "0x1944488", Offset = "0x1944488", VA = "0x1944488")]
    public void ApplyHome()
    {
    }

    [Token(Token = "0x600C23D")]
    [Address(RVA = "0x1944490", Offset = "0x1944490", VA = "0x1944490")]
    public void ApplyOfficialInformationArticle(APIHomeResponse response)
    {
    }

    [Token(Token = "0x600C23E")]
    [Address(RVA = "0x19444D0", Offset = "0x19444D0", VA = "0x19444D0")]
    public void UpdatePlayerUnit(
      List<PlayerUnitType> playerUnitTypes,
      List<PlayerUnitCharacterType> playerCharacterTypes)
    {
    }

    [Token(Token = "0x600C23F")]
    [Address(RVA = "0x1944774", Offset = "0x1944774", VA = "0x1944774")]
    public void UpdatePlayerUnit(
      PlayerUnitType playerUnitType,
      PlayerUnitCharacterType playerUnitCharacterType)
    {
    }

    [Token(Token = "0x600C240")]
    [Address(RVA = "0x19444FC", Offset = "0x19444FC", VA = "0x19444FC")]
    public void UpdatePlayerCharacter(
      List<PlayerUnitCharacterType> playerUnitCharacterTypes)
    {
    }

    [Token(Token = "0x600C241")]
    [Address(RVA = "0x19447A0", Offset = "0x19447A0", VA = "0x19447A0")]
    public void UpdatePlayerCharacter(PlayerUnitCharacterType playerUnitCharacterType)
    {
    }

    [Token(Token = "0x600C242")]
    [Address(RVA = "0x1944D0C", Offset = "0x1944D0C", VA = "0x1944D0C")]
    public void UpdatePlayerSupports(
      IReadOnlyList<PlayerUnitSupportType> playerUnitSupportTypes)
    {
    }

    [Token(Token = "0x600C243")]
    [Address(RVA = "0x1944638", Offset = "0x1944638", VA = "0x1944638")]
    public void UpdatePlayerStyles(List<PlayerUnitType> playerUnitTypes)
    {
    }

    [Token(Token = "0x600C244")]
    [Address(RVA = "0x19448E8", Offset = "0x19448E8", VA = "0x19448E8")]
    public void UpdatePlayerStyle(PlayerUnitType playerUnitType)
    {
    }

    [Token(Token = "0x600C245")]
    [Address(RVA = "0x1944D38", Offset = "0x1944D38", VA = "0x1944D38")]
    public void UpdatePlayerUnitLevelUpType(
      IEnumerable<PlayerUnitLevelUpType> playerUnitLevelUpTypes)
    {
    }

    [Token(Token = "0x600C246")]
    [Address(RVA = "0x1945080", Offset = "0x1945080", VA = "0x1945080")]
    public void CreateArenaDeck(List<PlayerDeckType> playerDecks)
    {
    }

    [Token(Token = "0x600C247")]
    [Address(RVA = "0x19450A8", Offset = "0x19450A8", VA = "0x19450A8")]
    public void ClearPlayerUnitLevelUpType(string playerUnitId)
    {
    }

    [Token(Token = "0x600C248")]
    [Address(RVA = "0x194512C", Offset = "0x194512C", VA = "0x194512C")]
    public List<PlayerUnitLevelUpType> GetPlayerUnitLevelUpType(IEnumerable<string> styleIdList)
    {
      return (List<PlayerUnitLevelUpType>) null;
    }

    [Token(Token = "0x600C249")]
    [Address(RVA = "0x194550C", Offset = "0x194550C", VA = "0x194550C")]
    public void UpdatePlayerWeaponPieceItems(List<PlayerWeaponPieceType> playerWeaponPieceTypes)
    {
    }

    [Token(Token = "0x600C24A")]
    [Address(RVA = "0x1945720", Offset = "0x1945720", VA = "0x1945720")]
    public void UpdatePlayerAccesoryPieceItems(
      List<PlayerAccessoryPieceType> playerAccessoryPieceTypes)
    {
    }

    [Token(Token = "0x600C24B")]
    [Address(RVA = "0x1945648", Offset = "0x1945648", VA = "0x1945648")]
    public void UpdatePlayerWeaponPieceItem(PlayerWeaponPieceType playerWeaponPieceType)
    {
    }

    [Token(Token = "0x600C24C")]
    [Address(RVA = "0x194585C", Offset = "0x194585C", VA = "0x194585C")]
    public void UpdatePlayerAccesoryPieceItem(PlayerAccessoryPieceType playerAccesoryPieceType)
    {
    }

    [Token(Token = "0x600C24D")]
    [Address(RVA = "0x194593C", Offset = "0x194593C", VA = "0x194593C")]
    public void UpdatePlayerUnitCustomSkillTypes(
      List<PlayerUnitCustomSkillType> playerUnitCustomSkillTypes)
    {
    }

    [Token(Token = "0x600C24E")]
    [Address(RVA = "0x1945A78", Offset = "0x1945A78", VA = "0x1945A78")]
    public void UpdatePlayerUnitCustomSkillType(
      PlayerUnitCustomSkillType playerUnitCustomSkillType)
    {
    }

    [Token(Token = "0x600C24F")]
    [Address(RVA = "0x1945B50", Offset = "0x1945B50", VA = "0x1945B50")]
    public void UpdatePlayerExchangeItems(
      List<PlayerExchangeItemType> playerExchangeItemTypes)
    {
    }

    [Token(Token = "0x600C250")]
    [Address(RVA = "0x1945D58", Offset = "0x1945D58", VA = "0x1945D58")]
    public void UpdatePlayerEps(List<PlayerEpType> playerEps)
    {
    }

    [Token(Token = "0x600C251")]
    [Address(RVA = "0x1945C8C", Offset = "0x1945C8C", VA = "0x1945C8C")]
    public void UpdatePlayerExchangeItem(PlayerExchangeItemType playerExchangeItemType)
    {
    }

    [Token(Token = "0x600C252")]
    [Address(RVA = "0x1945E94", Offset = "0x1945E94", VA = "0x1945E94")]
    public void UpdatePlayerEp(PlayerEpType playerEpType)
    {
    }

    [Token(Token = "0x600C253")]
    [Address(RVA = "0x1945F60", Offset = "0x1945F60", VA = "0x1945F60")]
    public void UpdatePlayerCurrencyItems(
      List<PlayerCurrencyItemType> playerCurrencyItemTypes)
    {
    }

    [Token(Token = "0x600C254")]
    [Address(RVA = "0x194609C", Offset = "0x194609C", VA = "0x194609C")]
    public void UpdatePlayerCurrencyItem(PlayerCurrencyItemType playerCurrencyItemType)
    {
    }

    [Token(Token = "0x600C255")]
    [Address(RVA = "0x1946168", Offset = "0x1946168", VA = "0x1946168")]
    public void UpdatePlayerUnitPieceItems(List<PlayerUnitPieceType> playerUnitPieceTypes)
    {
    }

    [Token(Token = "0x600C256")]
    [Address(RVA = "0x19462A4", Offset = "0x19462A4", VA = "0x19462A4")]
    public void UpdatePlayerUnitPieceItem(PlayerUnitPieceType playerUnitPieceType)
    {
    }

    [Token(Token = "0x600C257")]
    [Address(RVA = "0x1946398", Offset = "0x1946398", VA = "0x1946398")]
    public void UpDatePlayerExpendables(List<PlayerExpendableType> playerExpendableTypes)
    {
    }

    [Token(Token = "0x600C258")]
    [Address(RVA = "0x19464D4", Offset = "0x19464D4", VA = "0x19464D4")]
    public void UpDatePlayerExpendable(PlayerExpendableType playerExpendableType)
    {
    }

    [Token(Token = "0x600C259")]
    [Address(RVA = "0x19465A0", Offset = "0x19465A0", VA = "0x19465A0")]
    public void UpdatePlayerSouls(List<PlayerSoulType> playerSoulTypeTypes)
    {
    }

    [Token(Token = "0x600C25A")]
    [Address(RVA = "0x19466DC", Offset = "0x19466DC", VA = "0x19466DC")]
    public void UpdatePlayerSoul(PlayerSoulType playerSoulTypeType)
    {
    }

    [Token(Token = "0x600C25B")]
    [Address(RVA = "0x19467A0", Offset = "0x19467A0", VA = "0x19467A0")]
    public void UpdatePlayerUnitTrusts(
      List<PlayerGearUnitTrustType> playerGearUnitTrustTypes)
    {
    }

    [Token(Token = "0x600C25C")]
    [Address(RVA = "0x19468DC", Offset = "0x19468DC", VA = "0x19468DC")]
    public void UpdatePlayerUnitTrust(PlayerGearUnitTrustType playerGearUnitTrustType)
    {
    }

    [Token(Token = "0x600C25D")]
    [Address(RVA = "0x1946A2C", Offset = "0x1946A2C", VA = "0x1946A2C")]
    public void UpdatePlayerWeapons(List<PlayerGearWeaponType> playerSoulTypeTypes)
    {
    }

    [Token(Token = "0x600C25E")]
    [Address(RVA = "0x1946B68", Offset = "0x1946B68", VA = "0x1946B68")]
    public void UpdatePlayerWeapon(PlayerGearWeaponType playerGearWeaponType)
    {
    }

    [Token(Token = "0x600C25F")]
    [Address(RVA = "0x1946C48", Offset = "0x1946C48", VA = "0x1946C48")]
    public void UpdatePlayerAccessories(
      List<PlayerGearAccessoryType> playerGearAccessoryType)
    {
    }

    [Token(Token = "0x600C260")]
    [Address(RVA = "0x1946D84", Offset = "0x1946D84", VA = "0x1946D84")]
    public void UpdatePlayerAccessory(PlayerGearAccessoryType playerGearAccessoryType)
    {
    }

    [Token(Token = "0x600C261")]
    [Address(RVA = "0x1946E64", Offset = "0x1946E64", VA = "0x1946E64")]
    public void UpdatePlayerMindEquipments(
      List<PlayerGearMindEquipmentType> playerMindEquipmentTypes)
    {
    }

    [Token(Token = "0x600C262")]
    [Address(RVA = "0x1946FA0", Offset = "0x1946FA0", VA = "0x1946FA0")]
    public void UpdatePlayerMindEquipment(
      PlayerGearMindEquipmentType playerMindEquipmentType)
    {
    }

    [Token(Token = "0x600C263")]
    [Address(RVA = "0x1947080", Offset = "0x1947080", VA = "0x1947080")]
    public void UpdatePlayerMindEquipmentDuplicate(
      List<MindEquipmentDuplicateInfoType> mindEquipmentDuplicateInfoTypes)
    {
    }

    [Token(Token = "0x600C264")]
    [Address(RVA = "0x19471BC", Offset = "0x19471BC", VA = "0x19471BC")]
    public void UpdatePlayerMindEquipmentDuplicate(
      MindEquipmentDuplicateInfoType mindEquipmentDuplicateInfoType)
    {
    }

    [Token(Token = "0x600C265")]
    [Address(RVA = "0x1947258", Offset = "0x1947258", VA = "0x1947258")]
    public void UpdateSkillEnhanceItems(
      List<PlayerEquipmentSkillEnhanceItemType> playerEquipmentSkillEnhanceItemTypes)
    {
    }

    [Token(Token = "0x600C266")]
    [Address(RVA = "0x1947394", Offset = "0x1947394", VA = "0x1947394")]
    public void UpdateSkillEnhanceItem(
      PlayerEquipmentSkillEnhanceItemType playerEquipmentSkillEnhanceItemType)
    {
    }

    [Token(Token = "0x600C267")]
    [Address(RVA = "0x1947458", Offset = "0x1947458", VA = "0x1947458")]
    public void UpdatePlayerWeaponSell(List<string> weaponIds)
    {
    }

    [Token(Token = "0x600C268")]
    [Address(RVA = "0x1947604", Offset = "0x1947604", VA = "0x1947604")]
    public void UpdatePlayerAccessorySell(List<string> accessoryIds)
    {
    }

    [Token(Token = "0x600C269")]
    [Address(RVA = "0x19477B0", Offset = "0x19477B0", VA = "0x19477B0")]
    public void UpdateConsumptionUnitEnhance(List<PlayerUnitEnhanceType> playerUnitEnhances)
    {
    }

    [Token(Token = "0x600C26A")]
    [Address(RVA = "0x1947984", Offset = "0x1947984", VA = "0x1947984")]
    public void UpdateUnitEnhance(List<PlayerUnitEnhanceType> playerUnitEnhances)
    {
    }

    [Token(Token = "0x600C26B")]
    [Address(RVA = "0x1947B84", Offset = "0x1947B84", VA = "0x1947B84")]
    public void UpdateReincarnationMemory(
      List<PlayerUnitReincarnationMemoryType> reincarnationMemoryType)
    {
    }

    [Token(Token = "0x600C26C")]
    [Address(RVA = "0x1947DF4", Offset = "0x1947DF4", VA = "0x1947DF4")]
    public void UpdateWeaponMasterBonuses(
      List<PlayerWeaponMasterBonusType> playerWeaponMasterBonusTypes)
    {
    }

    [Token(Token = "0x600C26D")]
    [Address(RVA = "0x1947F30", Offset = "0x1947F30", VA = "0x1947F30")]
    public void UpdateWeaponMasterBonus(
      PlayerWeaponMasterBonusType playerWeaponMasterBonusType)
    {
    }

    [Token(Token = "0x600C26E")]
    [Address(RVA = "0x1947FFC", Offset = "0x1947FFC", VA = "0x1947FFC")]
    public void UpdatePlayerAbilityBoardItem(
      List<PlayerAbilityBoardItemType> playerAbilityBoardItemType)
    {
    }

    [Token(Token = "0x600C26F")]
    [Address(RVA = "0x1948138", Offset = "0x1948138", VA = "0x1948138")]
    public void UpdatePlayerAbilityBoardItem(
      PlayerAbilityBoardItemType playerAbilityBoardItemType)
    {
    }

    [Token(Token = "0x600C270")]
    [Address(RVA = "0x19441DC", Offset = "0x19441DC", VA = "0x19441DC")]
    public void UpdateWarrantyParameters(
      PlayerUnitWarrantyParameterType[] playerUnitWarrantyParameterTypes)
    {
    }

    [Token(Token = "0x600C271")]
    [Address(RVA = "0x194830C", Offset = "0x194830C", VA = "0x194830C")]
    public void UpdatePlayerMedals(List<PlayerMedalType> playerMedalTypes)
    {
    }

    [Token(Token = "0x600C272")]
    [Address(RVA = "0x1948204", Offset = "0x1948204", VA = "0x1948204")]
    public void UpdateWarrantyParameter(
      PlayerUnitWarrantyParameterType playerUnitWarrantyParameterType)
    {
    }

    [Token(Token = "0x600C273")]
    [Address(RVA = "0x1948448", Offset = "0x1948448", VA = "0x1948448")]
    public void UpdatePlayerMedal(PlayerMedalType playerMedalType)
    {
    }

    [Token(Token = "0x600C274")]
    [Address(RVA = "0x1948514", Offset = "0x1948514", VA = "0x1948514")]
    public void UpdatePlayerRecoveryItem(
      List<PlayerRecoveryItemType> playerRecoveryItemTypes)
    {
    }

    [Token(Token = "0x600C275")]
    [Address(RVA = "0x1948650", Offset = "0x1948650", VA = "0x1948650")]
    public void UpdatePlayerRecoveryItem(PlayerRecoveryItemType playerRecoveryItemType)
    {
    }

    [Token(Token = "0x600C276")]
    [Address(RVA = "0x194871C", Offset = "0x194871C", VA = "0x194871C")]
    public void UpdatePlayerCommunicationSkills(
      List<PlayerCommunicationSkillType> playerCommunicationSkillTypes)
    {
    }

    [Token(Token = "0x600C277")]
    [Address(RVA = "0x1948858", Offset = "0x1948858", VA = "0x1948858")]
    public void UpdatePlayerCommunicationSkill(
      PlayerCommunicationSkillType playerCommunicationSkillType)
    {
    }

    [Token(Token = "0x600C278")]
    [Address(RVA = "0x1948924", Offset = "0x1948924", VA = "0x1948924")]
    public void UpdatePlayerGeneralItems(List<PlayerGeneralItemType> playerGeneralItemTypes)
    {
    }

    [Token(Token = "0x600C279")]
    [Address(RVA = "0x1948A60", Offset = "0x1948A60", VA = "0x1948A60")]
    public void UpdatePlayerGeneralItem(PlayerGeneralItemType playerGeneralItemType)
    {
    }

    [Token(Token = "0x600C27A")]
    [Address(RVA = "0x1944248", Offset = "0x1944248", VA = "0x1944248")]
    public void UpdatePassItems(List<PlayerRewardPassType> rewardPassTypes)
    {
    }

    [Token(Token = "0x600C27B")]
    [Address(RVA = "0x1948B2C", Offset = "0x1948B2C", VA = "0x1948B2C")]
    public void UpdatePassItem(PlayerRewardPassType rewardPassType)
    {
    }

    [Token(Token = "0x600C27C")]
    [Address(RVA = "0x1948D54", Offset = "0x1948D54", VA = "0x1948D54")]
    public void UpdatePlayerGachaTickets(List<PlayerGachaTicketType> playerGachaTicketTypes)
    {
    }

    [Token(Token = "0x600C27D")]
    [Address(RVA = "0x1948E90", Offset = "0x1948E90", VA = "0x1948E90")]
    public void UpdatePlayerGachaTicket(PlayerGachaTicketType playerGachaTicketTypes)
    {
    }

    [Token(Token = "0x600C27E")]
    [Address(RVA = "0x1944384", Offset = "0x1944384", VA = "0x1944384")]
    private void ArmouryBadgeStateUpdate(PlayerProfile.BadgeUpdateMode updateMode = PlayerProfile.BadgeUpdateMode.All)
    {
    }

    [Token(Token = "0x600C27F")]
    [Address(RVA = "0x1948F5C", Offset = "0x1948F5C", VA = "0x1948F5C")]
    private bool StyleBadgeStateUpdate() => new bool();

    [Token(Token = "0x600C280")]
    [Address(RVA = "0x19490F0", Offset = "0x19490F0", VA = "0x19490F0")]
    private bool WeaponBadgeStateUpdate() => new bool();

    [Token(Token = "0x600C281")]
    [Address(RVA = "0x194928C", Offset = "0x194928C", VA = "0x194928C")]
    private bool AccessoryBadgeStateUpdate() => new bool();

    [Token(Token = "0x600C282")]
    [Address(RVA = "0x1949428", Offset = "0x1949428", VA = "0x1949428")]
    private bool MindEquipmentBadgeStateUpdate() => new bool();

    [Token(Token = "0x600C283")]
    [Address(RVA = "0x19495C4", Offset = "0x19495C4", VA = "0x19495C4")]
    private bool ItemBadgeStateUpdate() => new bool();

    [Token(Token = "0x600C284")]
    [Address(RVA = "0x194978C", Offset = "0x194978C", VA = "0x194978C")]
    public int GetAmountCanEnhanceStyle() => new int();

    [Token(Token = "0x600C285")]
    [Address(RVA = "0x1949908", Offset = "0x1949908", VA = "0x1949908")]
    public int GetAmountCanEnhanceWeapon() => new int();

    [Token(Token = "0x600C286")]
    [Address(RVA = "0x1949A8C", Offset = "0x1949A8C", VA = "0x1949A8C")]
    public int GetAmountCanEnhanceAccessory() => new int();

    [Token(Token = "0x600C287")]
    [Address(RVA = "0x1949C10", Offset = "0x1949C10", VA = "0x1949C10")]
    public int GetAmountCanEnhanceMindEquipment() => new int();

    [Token(Token = "0x600C288")]
    [Address(RVA = "0x1949D94", Offset = "0x1949D94", VA = "0x1949D94")]
    public bool ExitCanConversionMindEquipment() => new bool();

    [Token(Token = "0x170028EE")]
    public UnitSupportList UnitSupportList
    {
      [Token(Token = "0x600C289"), Address(RVA = "0x1949F28", Offset = "0x1949F28", VA = "0x1949F28")] get
      {
        return (UnitSupportList) null;
      }
      [Token(Token = "0x600C28A"), Address(RVA = "0x1949F30", Offset = "0x1949F30", VA = "0x1949F30")] private set
      {
      }
    }

    [Token(Token = "0x600C28B")]
    [Address(RVA = "0x1949F38", Offset = "0x1949F38", VA = "0x1949F38")]
    public Character GetCharacter(int id) => (Character) null;

    [Token(Token = "0x600C28C")]
    [Address(RVA = "0x194A0BC", Offset = "0x194A0BC", VA = "0x194A0BC")]
    public int SoulAmount(SoulTypeEnum soulType) => new int();

    [Token(Token = "0x600C28D")]
    [Address(RVA = "0x194A140", Offset = "0x194A140", VA = "0x194A140")]
    public int RedSoulAmount() => new int();

    [Token(Token = "0x600C28E")]
    [Address(RVA = "0x194A148", Offset = "0x194A148", VA = "0x194A148")]
    public Style GetStyle(string id) => (Style) null;

    [Token(Token = "0x600C28F")]
    [Address(RVA = "0x194A1B8", Offset = "0x194A1B8", VA = "0x194A1B8")]
    public Style GetStyle(int id) => (Style) null;

    [Token(Token = "0x600C290")]
    [Address(RVA = "0x194A33C", Offset = "0x194A33C", VA = "0x194A33C")]
    public int GetAvatarId() => new int();

    [Token(Token = "0x600C291")]
    [Address(RVA = "0x19449C8", Offset = "0x19449C8", VA = "0x19449C8")]
    public void UpdataStyleWeaponProficiencies(
      int characterId,
      List<PlayerUnitCharacterWeaponProficiencyType> playerUnitCharacterWeaponProficiencyType)
    {
    }

    [Token(Token = "0x600C292")]
    [Address(RVA = "0x1944B58", Offset = "0x1944B58", VA = "0x1944B58")]
    public void UpdataStylePararaData(Character character)
    {
    }

    [Token(Token = "0x600C293")]
    [Address(RVA = "0x194A358", Offset = "0x194A358", VA = "0x194A358")]
    public void UpdatePlayerStyleMasterBonus(
      List<PlayerStyleMasterBonusType> playerStyleMasterBonusTypes)
    {
    }

    [Token(Token = "0x600C294")]
    [Address(RVA = "0x194A494", Offset = "0x194A494", VA = "0x194A494")]
    public void UpdatePlayerStyleMasterBonus(
      PlayerStyleMasterBonusType playerStyleMasterBonusType)
    {
    }

    [Token(Token = "0x600C295")]
    [Address(RVA = "0x194A560", Offset = "0x194A560", VA = "0x194A560")]
    public StyleMasterBonusParameter GetStyleMasterBonusParameter(Style style)
    {
      return (StyleMasterBonusParameter) null;
    }

    [Token(Token = "0x600C296")]
    [Address(RVA = "0x194A738", Offset = "0x194A738", VA = "0x194A738")]
    public CustomSkill GetCharacterSkill(int id) => (CustomSkill) null;

    [Token(Token = "0x170028EF")]
    public IReadOnlyList<BattleItemset> BattleItemsetList
    {
      [Token(Token = "0x600C297"), Address(RVA = "0x194A8CC", Offset = "0x194A8CC", VA = "0x194A8CC")] get
      {
        return (IReadOnlyList<BattleItemset>) null;
      }
    }

    [Token(Token = "0x170028F0")]
    public Dictionary<int, UnitEnhance> UnitEnhanceItemseDic
    {
      [Token(Token = "0x600C298"), Address(RVA = "0x194A8D4", Offset = "0x194A8D4", VA = "0x194A8D4")] get
      {
        return (Dictionary<int, UnitEnhance>) null;
      }
    }

    [Token(Token = "0x170028F1")]
    public Decks Decks
    {
      [Token(Token = "0x600C299"), Address(RVA = "0x194A8DC", Offset = "0x194A8DC", VA = "0x194A8DC")] get
      {
        return (Decks) null;
      }
    }

    [Token(Token = "0x170028F2")]
    public Decks NomalDecks
    {
      [Token(Token = "0x600C29A"), Address(RVA = "0x194A8E4", Offset = "0x194A8E4", VA = "0x194A8E4")] get
      {
        return (Decks) null;
      }
      [Token(Token = "0x600C29B"), Address(RVA = "0x194A8EC", Offset = "0x194A8EC", VA = "0x194A8EC")] private set
      {
      }
    }

    [Token(Token = "0x170028F3")]
    public Decks MediumDecks
    {
      [Token(Token = "0x600C29C"), Address(RVA = "0x194A8F4", Offset = "0x194A8F4", VA = "0x194A8F4")] get
      {
        return (Decks) null;
      }
      [Token(Token = "0x600C29D"), Address(RVA = "0x194A8FC", Offset = "0x194A8FC", VA = "0x194A8FC")] private set
      {
      }
    }

    [Token(Token = "0x170028F4")]
    public Decks LargeDecks
    {
      [Token(Token = "0x600C29E"), Address(RVA = "0x194A904", Offset = "0x194A904", VA = "0x194A904")] get
      {
        return (Decks) null;
      }
      [Token(Token = "0x600C29F"), Address(RVA = "0x194A90C", Offset = "0x194A90C", VA = "0x194A90C")] private set
      {
      }
    }

    [Token(Token = "0x170028F5")]
    public Decks PvPDecks
    {
      [Token(Token = "0x600C2A0"), Address(RVA = "0x194A914", Offset = "0x194A914", VA = "0x194A914")] get
      {
        return (Decks) null;
      }
      [Token(Token = "0x600C2A1"), Address(RVA = "0x194A91C", Offset = "0x194A91C", VA = "0x194A91C")] private set
      {
      }
    }

    [Token(Token = "0x170028F6")]
    public Decks TemplateDecks
    {
      [Token(Token = "0x600C2A2"), Address(RVA = "0x194A924", Offset = "0x194A924", VA = "0x194A924")] get
      {
        return (Decks) null;
      }
      [Token(Token = "0x600C2A3"), Address(RVA = "0x194A92C", Offset = "0x194A92C", VA = "0x194A92C")] private set
      {
      }
    }

    [Token(Token = "0x170028F7")]
    public IReadOnlyCollection<int> PossessedPlayerTitleIDs
    {
      [Token(Token = "0x600C2A4"), Address(RVA = "0x194A934", Offset = "0x194A934", VA = "0x194A934")] get
      {
        return (IReadOnlyCollection<int>) null;
      }
      [Token(Token = "0x600C2A5"), Address(RVA = "0x194A93C", Offset = "0x194A93C", VA = "0x194A93C")] private set
      {
      }
    }

    [Token(Token = "0x170028F8")]
    public QuestBattleInfoCollection QuestBattleInfoCollection
    {
      [Token(Token = "0x600C2A6"), Address(RVA = "0x194A944", Offset = "0x194A944", VA = "0x194A944")] get
      {
        return (QuestBattleInfoCollection) null;
      }
      [Token(Token = "0x600C2A7"), Address(RVA = "0x194A94C", Offset = "0x194A94C", VA = "0x194A94C")] private set
      {
      }
    }

    [Token(Token = "0x170028F9")]
    public List<PlayerMissionProgressType> PlayerMissionProgressTypeList
    {
      [Token(Token = "0x600C2A8"), Address(RVA = "0x194A954", Offset = "0x194A954", VA = "0x194A954")] get
      {
        return (List<PlayerMissionProgressType>) null;
      }
      [Token(Token = "0x600C2A9"), Address(RVA = "0x194A95C", Offset = "0x194A95C", VA = "0x194A95C")] private set
      {
      }
    }

    [Token(Token = "0x170028FA")]
    public List<PlayerChatStampType> PlayerChatStamps
    {
      [Token(Token = "0x600C2AA"), Address(RVA = "0x194A964", Offset = "0x194A964", VA = "0x194A964")] get
      {
        return (List<PlayerChatStampType>) null;
      }
      [Token(Token = "0x600C2AB"), Address(RVA = "0x194A96C", Offset = "0x194A96C", VA = "0x194A96C")] private set
      {
      }
    }

    [Token(Token = "0x170028FB")]
    public List<Network.Param.PlayerChatPhraseType> PlayerChatPhraseType
    {
      [Token(Token = "0x600C2AC"), Address(RVA = "0x194A974", Offset = "0x194A974", VA = "0x194A974")] get
      {
        return (List<Network.Param.PlayerChatPhraseType>) null;
      }
      [Token(Token = "0x600C2AD"), Address(RVA = "0x194A97C", Offset = "0x194A97C", VA = "0x194A97C")] private set
      {
      }
    }

    [Token(Token = "0x170028FC")]
    public List<Network.Param.PlayerChatHistoryPin> PlayerChatHistoryPin
    {
      [Token(Token = "0x600C2AE"), Address(RVA = "0x194A984", Offset = "0x194A984", VA = "0x194A984")] get
      {
        return (List<Network.Param.PlayerChatHistoryPin>) null;
      }
      [Token(Token = "0x600C2AF"), Address(RVA = "0x194A98C", Offset = "0x194A98C", VA = "0x194A98C")] private set
      {
      }
    }

    [Token(Token = "0x170028FD")]
    public Dictionary<string, WarrantyParameter> WarrantyParameterDic
    {
      [Token(Token = "0x600C2B0"), Address(RVA = "0x194A994", Offset = "0x194A994", VA = "0x194A994")] get
      {
        return (Dictionary<string, WarrantyParameter>) null;
      }
      [Token(Token = "0x600C2B1"), Address(RVA = "0x194A99C", Offset = "0x194A99C", VA = "0x194A99C")] private set
      {
      }
    }

    [Token(Token = "0x170028FE")]
    public SuspendResumeData SuspendResume
    {
      [Token(Token = "0x600C2B2"), Address(RVA = "0x194A9A4", Offset = "0x194A9A4", VA = "0x194A9A4")] get
      {
        return (SuspendResumeData) null;
      }
      [Token(Token = "0x600C2B3"), Address(RVA = "0x194A9AC", Offset = "0x194A9AC", VA = "0x194A9AC")] private set
      {
      }
    }

    [Token(Token = "0x170028FF")]
    public int SuspendResumeTypeId
    {
      [Token(Token = "0x600C2B4"), Address(RVA = "0x194A9B4", Offset = "0x194A9B4", VA = "0x194A9B4")] get
      {
        return new int();
      }
      [Token(Token = "0x600C2B5"), Address(RVA = "0x194A9BC", Offset = "0x194A9BC", VA = "0x194A9BC")] private set
      {
      }
    }

    [Token(Token = "0x17002900")]
    public ChapterItemInfo ChapterItemInfo
    {
      [Token(Token = "0x600C2B6"), Address(RVA = "0x194A9C4", Offset = "0x194A9C4", VA = "0x194A9C4")] get
      {
        return (ChapterItemInfo) null;
      }
    }

    [Token(Token = "0x600C2B7")]
    [Address(RVA = "0x194A9CC", Offset = "0x194A9CC", VA = "0x194A9CC")]
    public List<CommunicationSkill> GetCommuSkillByCharacterId(int characterId)
    {
      return (List<CommunicationSkill>) null;
    }

    [Token(Token = "0x17002901")]
    public LoginBonusInfoHolder LoginBonusInfoHolder
    {
      [Token(Token = "0x600C2B8"), Address(RVA = "0x194AAE8", Offset = "0x194AAE8", VA = "0x194AAE8")] get
      {
        return (LoginBonusInfoHolder) null;
      }
      [Token(Token = "0x600C2B9"), Address(RVA = "0x194AAF0", Offset = "0x194AAF0", VA = "0x194AAF0")] private set
      {
      }
    }

    [Token(Token = "0x17002902")]
    public IntroChapterInfoManager IntroChapterInfoManager
    {
      [Token(Token = "0x600C2BA"), Address(RVA = "0x194AAF8", Offset = "0x194AAF8", VA = "0x194AAF8")] get
      {
        return (IntroChapterInfoManager) null;
      }
      [Token(Token = "0x600C2BB"), Address(RVA = "0x194AB00", Offset = "0x194AB00", VA = "0x194AB00")] private set
      {
      }
    }

    [Token(Token = "0x17002903")]
    public HomeCharacterSettings HomeCharacterSettings
    {
      [Token(Token = "0x600C2BC"), Address(RVA = "0x194AB08", Offset = "0x194AB08", VA = "0x194AB08")] get
      {
        return (HomeCharacterSettings) null;
      }
      [Token(Token = "0x600C2BD"), Address(RVA = "0x194AB10", Offset = "0x194AB10", VA = "0x194AB10")] private set
      {
      }
    }

    [Token(Token = "0x17002904")]
    public OfficialInformationNewArticle OfficialInformationNewArticle
    {
      [Token(Token = "0x600C2BE"), Address(RVA = "0x194AB18", Offset = "0x194AB18", VA = "0x194AB18")] get
      {
        return (OfficialInformationNewArticle) null;
      }
      [Token(Token = "0x600C2BF"), Address(RVA = "0x194AB20", Offset = "0x194AB20", VA = "0x194AB20")] private set
      {
      }
    }

    [Token(Token = "0x17002905")]
    public List<OfficialInformationArticleType> OfficialInformationArticle
    {
      [Token(Token = "0x600C2C0"), Address(RVA = "0x194AB28", Offset = "0x194AB28", VA = "0x194AB28")] get
      {
        return (List<OfficialInformationArticleType>) null;
      }
      [Token(Token = "0x600C2C1"), Address(RVA = "0x194AB30", Offset = "0x194AB30", VA = "0x194AB30")] private set
      {
      }
    }

    [Token(Token = "0x17002906")]
    public OfficialMessageArticle OfficialMessageArticle
    {
      [Token(Token = "0x600C2C2"), Address(RVA = "0x194AB38", Offset = "0x194AB38", VA = "0x194AB38")] get
      {
        return (OfficialMessageArticle) null;
      }
      [Token(Token = "0x600C2C3"), Address(RVA = "0x194AB40", Offset = "0x194AB40", VA = "0x194AB40")] private set
      {
      }
    }

    [Token(Token = "0x17002907")]
    public int BattleRollbackCount
    {
      [Token(Token = "0x600C2C4"), Address(RVA = "0x194AB48", Offset = "0x194AB48", VA = "0x194AB48")] get
      {
        return new int();
      }
      [Token(Token = "0x600C2C5"), Address(RVA = "0x194AB50", Offset = "0x194AB50", VA = "0x194AB50")] private set
      {
      }
    }

    [Token(Token = "0x600C2C6")]
    [Address(RVA = "0x194AB58", Offset = "0x194AB58", VA = "0x194AB58")]
    public void UpdateBattleRollbackCount(PlayerBattleResult playerBattleResult)
    {
    }

    [Token(Token = "0x600C2C7")]
    [Address(RVA = "0x194AB74", Offset = "0x194AB74", VA = "0x194AB74")]
    public void UpdateBattleRollbackCount(APIBattleRetreatResponse battleRetreatResponse)
    {
    }

    [Token(Token = "0x600C2C8")]
    [Address(RVA = "0x194AB90", Offset = "0x194AB90", VA = "0x194AB90")]
    public void UpdatePlayerBossChallengeTicketItems(
      List<PlayerBossChallengeTicketType> playerBossChallengeTicketTypes)
    {
    }

    [Token(Token = "0x600C2C9")]
    [Address(RVA = "0x194ACCC", Offset = "0x194ACCC", VA = "0x194ACCC")]
    public void UpdatePlayerBossChallengeTicketItem(
      PlayerBossChallengeTicketType playerBossChallengeTicketType)
    {
    }

    [Token(Token = "0x600C2CA")]
    [Address(RVA = "0x194AD98", Offset = "0x194AD98", VA = "0x194AD98")]
    public void UpdatePlayerExpeditionRapidTicketItems(
      List<PlayerExpeditionRapidTicketType> playerExpeditionRapidTicketTypes)
    {
    }

    [Token(Token = "0x600C2CB")]
    [Address(RVA = "0x194AED4", Offset = "0x194AED4", VA = "0x194AED4")]
    public void UpdatePlayerExpeditionRapidTicketItem(
      PlayerExpeditionRapidTicketType playerExpeditionRapidTicketType)
    {
    }

    [Token(Token = "0x600C2CC")]
    [Address(RVA = "0x194AFA0", Offset = "0x194AFA0", VA = "0x194AFA0")]
    public int CountPlayerExpeditionRapidTicket(int hour) => new int();

    [Token(Token = "0x600C2CD")]
    [Address(RVA = "0x194B1A4", Offset = "0x194B1A4", VA = "0x194B1A4")]
    public string GetPlayerExpeditionRapidTicketNane(int hour) => (string) null;

    [Token(Token = "0x600C2CE")]
    [Address(RVA = "0x194B378", Offset = "0x194B378", VA = "0x194B378")]
    public void ChangeCurrentDecks(OrganizationTeam.TeamSizeType teamSize)
    {
    }

    [Token(Token = "0x600C2CF")]
    [Address(RVA = "0x194B3A8", Offset = "0x194B3A8", VA = "0x194B3A8")]
    public void ChangeCurrentDecks(DeckTypeEnum deckType)
    {
    }

    [Token(Token = "0x600C2D0")]
    [Address(RVA = "0x194B3E0", Offset = "0x194B3E0", VA = "0x194B3E0")]
    public void UpdatePlayerArenaBattleTicketItems(
      List<PlayerArenaBattleTicketType> playerArenaBattleTicketTypes)
    {
    }

    [Token(Token = "0x600C2D1")]
    [Address(RVA = "0x194B51C", Offset = "0x194B51C", VA = "0x194B51C")]
    public void UpdatePlayerArenaBattleTicketItem(
      PlayerArenaBattleTicketType playerArenaBattleTicketType)
    {
    }

    [Token(Token = "0x600C2D2")]
    [Address(RVA = "0x194B5A4", Offset = "0x194B5A4", VA = "0x194B5A4")]
    public ArenaBattleTicketItem GetArenaBattleTicketItem(int id) => (ArenaBattleTicketItem) null;

    [Token(Token = "0x600C2D3")]
    [Address(RVA = "0x194B61C", Offset = "0x194B61C", VA = "0x194B61C")]
    public bool IsSetWeapon(UniqueID uniqueID) => new bool();

    [Token(Token = "0x600C2D4")]
    [Address(RVA = "0x194B688", Offset = "0x194B688", VA = "0x194B688")]
    public bool IsSetEquipment(UniqueID uniqueID) => new bool();

    [Token(Token = "0x600C2D5")]
    [Address(RVA = "0x194B6F4", Offset = "0x194B6F4", VA = "0x194B6F4")]
    public bool NowEquippedBattleItemSetList(UniqueID uniqueID) => new bool();

    [Token(Token = "0x600C2D6")]
    [Address(RVA = "0x194BB98", Offset = "0x194BB98", VA = "0x194BB98")]
    public void ApplyDeckData(PlayerDeckType deck)
    {
    }

    [Token(Token = "0x600C2D7")]
    [Address(RVA = "0x194BC10", Offset = "0x194BC10", VA = "0x194BC10")]
    public void ApplyItemSetData(PlayerItemsetType itemSet)
    {
    }

    [Token(Token = "0x600C2D8")]
    [Address(RVA = "0x194BD00", Offset = "0x194BD00", VA = "0x194BD00")]
    public void UpdatePlayerName(string playerName)
    {
    }

    [Token(Token = "0x600C2D9")]
    [Address(RVA = "0x194BD1C", Offset = "0x194BD1C", VA = "0x194BD1C")]
    public void UpdatePlayerEmblem(int emblemId)
    {
    }

    [Token(Token = "0x600C2DA")]
    [Address(RVA = "0x194BD38", Offset = "0x194BD38", VA = "0x194BD38")]
    public void UpdateComment(string comment)
    {
    }

    [Token(Token = "0x600C2DB")]
    [Address(RVA = "0x194BD54", Offset = "0x194BD54", VA = "0x194BD54")]
    public void UpdatePlayerChatPhraseType(List<Network.Param.PlayerChatPhraseType> list)
    {
    }

    [Token(Token = "0x600C2DC")]
    [Address(RVA = "0x194BF60", Offset = "0x194BF60", VA = "0x194BF60")]
    public string GetPlayerChatPhraseText(int slot) => (string) null;

    [Token(Token = "0x600C2DD")]
    [Address(RVA = "0x194C0D4", Offset = "0x194C0D4", VA = "0x194C0D4")]
    public void UpdatePlayerChatHistoryPin(List<Network.Param.PlayerChatHistoryPin> list)
    {
    }

    [Token(Token = "0x600C2DE")]
    [Address(RVA = "0x194C0DC", Offset = "0x194C0DC", VA = "0x194C0DC")]
    public void UpdatePlayerMissionProgressTypeList(List<PlayerMissionProgressType> list)
    {
    }

    [Token(Token = "0x600C2DF")]
    [Address(RVA = "0x194C0E4", Offset = "0x194C0E4", VA = "0x194C0E4")]
    public void AddOrUpdatePlayerMissionProgressTypeList(List<PlayerMissionProgressType> diff)
    {
    }

    [Token(Token = "0x600C2E0")]
    [Address(RVA = "0x194C3EC", Offset = "0x194C3EC", VA = "0x194C3EC")]
    public Dictionary<int, List<ItemListData>> GetSaleItemList()
    {
      return (Dictionary<int, List<ItemListData>>) null;
    }

    [Token(Token = "0x600C2E1")]
    [Address(RVA = "0x194D6E0", Offset = "0x194D6E0", VA = "0x194D6E0")]
    public void ApplyArenaOpponentPlayer(EnemyArenaRankingDetailType arenaEnemyDetail)
    {
    }

    [Token(Token = "0x600C2E2")]
    [Address(RVA = "0x194E870", Offset = "0x194E870", VA = "0x194E870")]
    public void ApplyBattleSkip(PlayerBattleSkipResult result)
    {
    }

    [Token(Token = "0x600C2E3")]
    [Address(RVA = "0x194E8FC", Offset = "0x194E8FC", VA = "0x194E8FC")]
    public void UpdatePlayerEmblems(List<PlayerEmblemType> playerEmblemTypes)
    {
    }

    [Token(Token = "0x600C2E4")]
    [Address(RVA = "0x194EA38", Offset = "0x194EA38", VA = "0x194EA38")]
    public void UpdatePlayerEmblemItem(PlayerEmblemType playerEmblemType)
    {
    }

    [Token(Token = "0x600C2E5")]
    [Address(RVA = "0x194EAFC", Offset = "0x194EAFC", VA = "0x194EAFC")]
    public void UpdatePlayerBoxItemTypes(List<PlayerBoxItemType> playerBoxItemTypes)
    {
    }

    [Token(Token = "0x600C2E6")]
    [Address(RVA = "0x194EC44", Offset = "0x194EC44", VA = "0x194EC44")]
    public void UpdatePlayerBoxItemType(PlayerBoxItemType playerBoxItemType)
    {
    }

    [Token(Token = "0x600C2E7")]
    [Address(RVA = "0x194ED10", Offset = "0x194ED10", VA = "0x194ED10")]
    public void CreateDebugData()
    {
    }

    [Token(Token = "0x600C2E8")]
    [Address(RVA = "0x194ED14", Offset = "0x194ED14", VA = "0x194ED14")]
    public PlayerProfile()
    {
    }

    [Token(Token = "0x2002050")]
    private enum BadgeUpdateMode
    {
      [Token(Token = "0x40089BD")] All,
      [Token(Token = "0x40089BE")] Style,
      [Token(Token = "0x40089BF")] Weapon,
      [Token(Token = "0x40089C0")] Accessory,
      [Token(Token = "0x40089C1")] MindEquipment,
      [Token(Token = "0x40089C2")] Item,
    }
  }
}
