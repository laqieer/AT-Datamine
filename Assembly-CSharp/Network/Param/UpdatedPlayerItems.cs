// Decompiled with JetBrains decompiler
// Type: Network.Param.UpdatedPlayerItems
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
  [Token(Token = "0x2001B17")]
  [Serializable]
  public class UpdatedPlayerItems
  {
    [Token(Token = "0x400746A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerCurrencyItemType> currency_items;
    [Token(Token = "0x400746B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerEquipmentSkillEnhanceItemType> equipment_skill_enhance_items;
    [Token(Token = "0x400746C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerExchangeItemType> exchange_items;
    [Token(Token = "0x400746D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<PlayerExpendableType> expendable_items;
    [Token(Token = "0x400746E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerSoulType> player_souls;
    [Token(Token = "0x400746F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerStoryChapterItemType> chapter_items;
    [Token(Token = "0x4007470")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerEpType> player_ep;
    [Token(Token = "0x4007471")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private List<PlayerUnitEnhanceType> player_unit_enhances;
    [Token(Token = "0x4007472")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private List<PlayerUnitPieceType> player_unit_pieces;
    [Token(Token = "0x4007473")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private List<PlayerMedalType> player_medals;
    [Token(Token = "0x4007474")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private List<PlayerAbilityBoardItemType> player_ability_board_items;
    [Token(Token = "0x4007475")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private List<PlayerRecoveryItemType> player_recovery_items;
    [Token(Token = "0x4007476")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private List<PlayerWeaponPieceType> player_weapon_pieces;
    [Token(Token = "0x4007477")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private List<PlayerAccessoryPieceType> player_accessory_pieces;
    [Token(Token = "0x4007478")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private List<PlayerGachaTicketType> player_gacha_ticket_items;
    [Token(Token = "0x4007479")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private List<PlayerArenaBattleTicketType> player_arena_battle_tickets;
    [Token(Token = "0x400747A")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private List<PlayerBossChallengeTicketType> player_boss_challenge_tickets;
    [Token(Token = "0x400747B")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private List<PlayerExpeditionRapidTicketType> player_expedition_rapid_tickets;
    [Token(Token = "0x400747C")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private List<PlayerGeneralItemType> player_general_items;
    [Token(Token = "0x400747D")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private List<PlayerBoxItemType> player_box_items;
    [Token(Token = "0x400747E")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private List<PlayerEmblemType> player_emblems;

    [Token(Token = "0x17001CCC")]
    public List<PlayerCurrencyItemType> CurrencyItems
    {
      [Token(Token = "0x6009F1A"), Address(RVA = "0x48F39B4", Offset = "0x48F39B4", VA = "0x48F39B4")] get
      {
        return (List<PlayerCurrencyItemType>) null;
      }
      [Token(Token = "0x6009F1B"), Address(RVA = "0x48F39BC", Offset = "0x48F39BC", VA = "0x48F39BC")] set
      {
      }
    }

    [Token(Token = "0x17001CCD")]
    public List<PlayerEquipmentSkillEnhanceItemType> EquipmentSkillEnhanceItems
    {
      [Token(Token = "0x6009F1C"), Address(RVA = "0x48F39C4", Offset = "0x48F39C4", VA = "0x48F39C4")] get
      {
        return (List<PlayerEquipmentSkillEnhanceItemType>) null;
      }
      [Token(Token = "0x6009F1D"), Address(RVA = "0x48F39CC", Offset = "0x48F39CC", VA = "0x48F39CC")] set
      {
      }
    }

    [Token(Token = "0x17001CCE")]
    public List<PlayerExchangeItemType> ExchangeItems
    {
      [Token(Token = "0x6009F1E"), Address(RVA = "0x48F39D4", Offset = "0x48F39D4", VA = "0x48F39D4")] get
      {
        return (List<PlayerExchangeItemType>) null;
      }
      [Token(Token = "0x6009F1F"), Address(RVA = "0x48F39DC", Offset = "0x48F39DC", VA = "0x48F39DC")] set
      {
      }
    }

    [Token(Token = "0x17001CCF")]
    public List<PlayerExpendableType> ExpendableItems
    {
      [Token(Token = "0x6009F20"), Address(RVA = "0x48F39E4", Offset = "0x48F39E4", VA = "0x48F39E4")] get
      {
        return (List<PlayerExpendableType>) null;
      }
      [Token(Token = "0x6009F21"), Address(RVA = "0x48F39EC", Offset = "0x48F39EC", VA = "0x48F39EC")] set
      {
      }
    }

    [Token(Token = "0x17001CD0")]
    public List<PlayerSoulType> PlayerSouls
    {
      [Token(Token = "0x6009F22"), Address(RVA = "0x48F39F4", Offset = "0x48F39F4", VA = "0x48F39F4")] get
      {
        return (List<PlayerSoulType>) null;
      }
      [Token(Token = "0x6009F23"), Address(RVA = "0x48F39FC", Offset = "0x48F39FC", VA = "0x48F39FC")] set
      {
      }
    }

    [Token(Token = "0x17001CD1")]
    public List<PlayerStoryChapterItemType> ChapterItems
    {
      [Token(Token = "0x6009F24"), Address(RVA = "0x48F3A04", Offset = "0x48F3A04", VA = "0x48F3A04")] get
      {
        return (List<PlayerStoryChapterItemType>) null;
      }
      [Token(Token = "0x6009F25"), Address(RVA = "0x48F3A0C", Offset = "0x48F3A0C", VA = "0x48F3A0C")] set
      {
      }
    }

    [Token(Token = "0x17001CD2")]
    public List<PlayerEpType> PlayerEp
    {
      [Token(Token = "0x6009F26"), Address(RVA = "0x48F3A14", Offset = "0x48F3A14", VA = "0x48F3A14")] get
      {
        return (List<PlayerEpType>) null;
      }
      [Token(Token = "0x6009F27"), Address(RVA = "0x48F3A1C", Offset = "0x48F3A1C", VA = "0x48F3A1C")] set
      {
      }
    }

    [Token(Token = "0x17001CD3")]
    public List<PlayerUnitEnhanceType> PlayerUnitEnhances
    {
      [Token(Token = "0x6009F28"), Address(RVA = "0x48F3A24", Offset = "0x48F3A24", VA = "0x48F3A24")] get
      {
        return (List<PlayerUnitEnhanceType>) null;
      }
      [Token(Token = "0x6009F29"), Address(RVA = "0x48F3A2C", Offset = "0x48F3A2C", VA = "0x48F3A2C")] set
      {
      }
    }

    [Token(Token = "0x17001CD4")]
    public List<PlayerUnitPieceType> PlayerUnitPieces
    {
      [Token(Token = "0x6009F2A"), Address(RVA = "0x48F3A34", Offset = "0x48F3A34", VA = "0x48F3A34")] get
      {
        return (List<PlayerUnitPieceType>) null;
      }
      [Token(Token = "0x6009F2B"), Address(RVA = "0x48F3A3C", Offset = "0x48F3A3C", VA = "0x48F3A3C")] set
      {
      }
    }

    [Token(Token = "0x17001CD5")]
    public List<PlayerMedalType> PlayerMedals
    {
      [Token(Token = "0x6009F2C"), Address(RVA = "0x48F3A44", Offset = "0x48F3A44", VA = "0x48F3A44")] get
      {
        return (List<PlayerMedalType>) null;
      }
      [Token(Token = "0x6009F2D"), Address(RVA = "0x48F3A4C", Offset = "0x48F3A4C", VA = "0x48F3A4C")] set
      {
      }
    }

    [Token(Token = "0x17001CD6")]
    public List<PlayerAbilityBoardItemType> PlayerAbilityBoardItems
    {
      [Token(Token = "0x6009F2E"), Address(RVA = "0x48F3A54", Offset = "0x48F3A54", VA = "0x48F3A54")] get
      {
        return (List<PlayerAbilityBoardItemType>) null;
      }
      [Token(Token = "0x6009F2F"), Address(RVA = "0x48F3A5C", Offset = "0x48F3A5C", VA = "0x48F3A5C")] set
      {
      }
    }

    [Token(Token = "0x17001CD7")]
    public List<PlayerRecoveryItemType> PlayerRecoveryItems
    {
      [Token(Token = "0x6009F30"), Address(RVA = "0x48F3A64", Offset = "0x48F3A64", VA = "0x48F3A64")] get
      {
        return (List<PlayerRecoveryItemType>) null;
      }
      [Token(Token = "0x6009F31"), Address(RVA = "0x48F3A6C", Offset = "0x48F3A6C", VA = "0x48F3A6C")] set
      {
      }
    }

    [Token(Token = "0x17001CD8")]
    public List<PlayerWeaponPieceType> PlayerWeaponPieces
    {
      [Token(Token = "0x6009F32"), Address(RVA = "0x48F3A74", Offset = "0x48F3A74", VA = "0x48F3A74")] get
      {
        return (List<PlayerWeaponPieceType>) null;
      }
      [Token(Token = "0x6009F33"), Address(RVA = "0x48F3A7C", Offset = "0x48F3A7C", VA = "0x48F3A7C")] set
      {
      }
    }

    [Token(Token = "0x17001CD9")]
    public List<PlayerAccessoryPieceType> PlayerAccessoryPieces
    {
      [Token(Token = "0x6009F34"), Address(RVA = "0x48F3A84", Offset = "0x48F3A84", VA = "0x48F3A84")] get
      {
        return (List<PlayerAccessoryPieceType>) null;
      }
      [Token(Token = "0x6009F35"), Address(RVA = "0x48F3A8C", Offset = "0x48F3A8C", VA = "0x48F3A8C")] set
      {
      }
    }

    [Token(Token = "0x17001CDA")]
    public List<PlayerGachaTicketType> PlayerGachaTicketItems
    {
      [Token(Token = "0x6009F36"), Address(RVA = "0x48F3A94", Offset = "0x48F3A94", VA = "0x48F3A94")] get
      {
        return (List<PlayerGachaTicketType>) null;
      }
      [Token(Token = "0x6009F37"), Address(RVA = "0x48F3A9C", Offset = "0x48F3A9C", VA = "0x48F3A9C")] set
      {
      }
    }

    [Token(Token = "0x17001CDB")]
    public List<PlayerArenaBattleTicketType> PlayerArenaBattleTickets
    {
      [Token(Token = "0x6009F38"), Address(RVA = "0x48F3AA4", Offset = "0x48F3AA4", VA = "0x48F3AA4")] get
      {
        return (List<PlayerArenaBattleTicketType>) null;
      }
      [Token(Token = "0x6009F39"), Address(RVA = "0x48F3AAC", Offset = "0x48F3AAC", VA = "0x48F3AAC")] set
      {
      }
    }

    [Token(Token = "0x17001CDC")]
    public List<PlayerBossChallengeTicketType> PlayerBossChallengeTickets
    {
      [Token(Token = "0x6009F3A"), Address(RVA = "0x48F3AB4", Offset = "0x48F3AB4", VA = "0x48F3AB4")] get
      {
        return (List<PlayerBossChallengeTicketType>) null;
      }
      [Token(Token = "0x6009F3B"), Address(RVA = "0x48F3ABC", Offset = "0x48F3ABC", VA = "0x48F3ABC")] set
      {
      }
    }

    [Token(Token = "0x17001CDD")]
    public List<PlayerExpeditionRapidTicketType> PlayerExpeditionRapidTickets
    {
      [Token(Token = "0x6009F3C"), Address(RVA = "0x48F3AC4", Offset = "0x48F3AC4", VA = "0x48F3AC4")] get
      {
        return (List<PlayerExpeditionRapidTicketType>) null;
      }
      [Token(Token = "0x6009F3D"), Address(RVA = "0x48F3ACC", Offset = "0x48F3ACC", VA = "0x48F3ACC")] set
      {
      }
    }

    [Token(Token = "0x17001CDE")]
    public List<PlayerGeneralItemType> PlayerGeneralItems
    {
      [Token(Token = "0x6009F3E"), Address(RVA = "0x48F3AD4", Offset = "0x48F3AD4", VA = "0x48F3AD4")] get
      {
        return (List<PlayerGeneralItemType>) null;
      }
      [Token(Token = "0x6009F3F"), Address(RVA = "0x48F3ADC", Offset = "0x48F3ADC", VA = "0x48F3ADC")] set
      {
      }
    }

    [Token(Token = "0x17001CDF")]
    public List<PlayerBoxItemType> PlayerBoxItems
    {
      [Token(Token = "0x6009F40"), Address(RVA = "0x48F3AE4", Offset = "0x48F3AE4", VA = "0x48F3AE4")] get
      {
        return (List<PlayerBoxItemType>) null;
      }
      [Token(Token = "0x6009F41"), Address(RVA = "0x48F3AEC", Offset = "0x48F3AEC", VA = "0x48F3AEC")] set
      {
      }
    }

    [Token(Token = "0x17001CE0")]
    public List<PlayerEmblemType> PlayerEmblems
    {
      [Token(Token = "0x6009F42"), Address(RVA = "0x48F3AF4", Offset = "0x48F3AF4", VA = "0x48F3AF4")] get
      {
        return (List<PlayerEmblemType>) null;
      }
      [Token(Token = "0x6009F43"), Address(RVA = "0x48F3AFC", Offset = "0x48F3AFC", VA = "0x48F3AFC")] set
      {
      }
    }

    [Token(Token = "0x6009F44")]
    [Address(RVA = "0x48F3B04", Offset = "0x48F3B04", VA = "0x48F3B04")]
    public UpdatedPlayerItems()
    {
    }
  }
}
