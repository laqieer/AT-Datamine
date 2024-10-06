// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PartyStyleManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using QuestPrepare;
using StaqData;
using System;
using System.Collections.Generic;
using TeamOrganization;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003222")]
  [Serializable]
  public class PartyStyleManager
  {
    [Token(Token = "0x400D61E")]
    private const int OneTeamUnitMax = 15;
    [Token(Token = "0x400D61F")]
    private const int OnePartyUnitMax = 5;
    [Token(Token = "0x400D620")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private PrepareDotUnitGroup unitGroup;
    [Token(Token = "0x400D621")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlatoonIconGroup platoonIconGroup;
    [Token(Token = "0x400D622")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UnitItem[] team1;
    [Token(Token = "0x400D623")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UnitItem[] team2;
    [Token(Token = "0x400D624")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UnitItem[] team3;
    [Token(Token = "0x400D625")]
    [FieldOffset(Offset = "0x38")]
    public BattleSortieRestrictionsCheck SortieRestrictionsCheck;
    [Token(Token = "0x400D626")]
    [FieldOffset(Offset = "0x40")]
    public BattleForcedSortieCheck ForcedSortieCheck;
    [Token(Token = "0x400D627")]
    [FieldOffset(Offset = "0x48")]
    private List<OrganizationTeam> editDecks;
    [Token(Token = "0x400D628")]
    [FieldOffset(Offset = "0x50")]
    private int deckIndex;
    [Token(Token = "0x400D62A")]
    [FieldOffset(Offset = "0x60")]
    private QuestInfo questInfo;
    [Token(Token = "0x400D62B")]
    [FieldOffset(Offset = "0x68")]
    private DeckTypeEnum deckType;
    [Token(Token = "0x400D62C")]
    [FieldOffset(Offset = "0x70")]
    private QuestPrepareAssetLoader loader;
    [Token(Token = "0x400D62D")]
    [FieldOffset(Offset = "0x78")]
    private SpriteAtlas elementIconSpriteAtlas;
    [Token(Token = "0x400D62E")]
    [FieldOffset(Offset = "0x80")]
    private int SortieUnitCount;
    [Token(Token = "0x400D62F")]
    [FieldOffset(Offset = "0x88")]
    private Dictionary<int, UnitItem[]> teamMap;
    [Token(Token = "0x400D630")]
    [FieldOffset(Offset = "0x90")]
    private bool isGuildRaid;
    [Token(Token = "0x400D631")]
    [FieldOffset(Offset = "0x98")]
    private List<string> usedStyleIds;

    [Token(Token = "0x17004126")]
    public int CurrentItemSetNo
    {
      [Token(Token = "0x60138D7"), Address(RVA = "0x49C660C", Offset = "0x49C660C", VA = "0x49C660C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004127")]
    public OrganizationTeam CurrentDeck
    {
      [Token(Token = "0x60138D8"), Address(RVA = "0x49C6628", Offset = "0x49C6628", VA = "0x49C6628")] get
      {
        return (OrganizationTeam) null;
      }
    }

    [Token(Token = "0x17004128")]
    public Action<string> OnPlayAlertAction
    {
      [Token(Token = "0x60138D9"), Address(RVA = "0x49C667C", Offset = "0x49C667C", VA = "0x49C667C")] get
      {
        return (Action<string>) null;
      }
      [Token(Token = "0x60138DA"), Address(RVA = "0x49C6684", Offset = "0x49C6684", VA = "0x49C6684")] set
      {
      }
    }

    [Token(Token = "0x17004129")]
    public bool IsNoLpMaxUnit
    {
      [Token(Token = "0x60138DB"), Address(RVA = "0x49C668C", Offset = "0x49C668C", VA = "0x49C668C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60138DC")]
    [Address(RVA = "0x49C6898", Offset = "0x49C6898", VA = "0x49C6898")]
    public void SetDeckIndex(int deckIndex)
    {
    }

    [Token(Token = "0x60138DD")]
    [Address(RVA = "0x49C68A0", Offset = "0x49C68A0", VA = "0x49C68A0")]
    public void Initialize(
      QuestInfo questInfo,
      DeckTypeEnum deckType,
      int lastedDeckIndex,
      bool isGuildRaid,
      List<string> usedStyleIds)
    {
    }

    [Token(Token = "0x60138DE")]
    [Address(RVA = "0x49C6DA0", Offset = "0x49C6DA0", VA = "0x49C6DA0")]
    public void InitializeArena(DeckTypeEnum deckType)
    {
    }

    [Token(Token = "0x60138DF")]
    [Address(RVA = "0x49C7178", Offset = "0x49C7178", VA = "0x49C7178")]
    public int GetMemberLimitNum() => new int();

    [Token(Token = "0x60138E0")]
    [Address(RVA = "0x49C7194", Offset = "0x49C7194", VA = "0x49C7194")]
    public string GetCurrentDeckName() => (string) null;

    [Token(Token = "0x60138E1")]
    [Address(RVA = "0x49C71B0", Offset = "0x49C71B0", VA = "0x49C71B0")]
    public int GetAiTypeID() => new int();

    [Token(Token = "0x60138E2")]
    [Address(RVA = "0x49C71CC", Offset = "0x49C71CC", VA = "0x49C71CC")]
    public int GetTotalCombatPower() => new int();

    [Token(Token = "0x60138E3")]
    [Address(RVA = "0x49C71E8", Offset = "0x49C71E8", VA = "0x49C71E8")]
    public int GetTotalCombatPowerArena() => new int();

    [Token(Token = "0x60138E4")]
    [Address(RVA = "0x49C72BC", Offset = "0x49C72BC", VA = "0x49C72BC")]
    public int GetCurrentDeckIndex() => new int();

    [Token(Token = "0x60138E5")]
    [Address(RVA = "0x49C6D44", Offset = "0x49C6D44", VA = "0x49C6D44")]
    public void InitDeckData()
    {
    }

    [Token(Token = "0x60138E6")]
    [Address(RVA = "0x49C7174", Offset = "0x49C7174", VA = "0x49C7174")]
    public void InitDeckDataArena()
    {
    }

    [Token(Token = "0x60138E7")]
    [Address(RVA = "0x49C764C", Offset = "0x49C764C", VA = "0x49C764C")]
    public MindEquipmentSkill[] GetAllMindEquipmentSkills() => (MindEquipmentSkill[]) null;

    [Token(Token = "0x60138E8")]
    [Address(RVA = "0x49C7B38", Offset = "0x49C7B38", VA = "0x49C7B38")]
    public void CreateUnitItem(QuestPrepareAssetLoader loader = null)
    {
    }

    [Token(Token = "0x60138E9")]
    [Address(RVA = "0x49C90CC", Offset = "0x49C90CC", VA = "0x49C90CC")]
    public void CreateUnitItemArena(QuestPrepareAssetLoader loader = null)
    {
    }

    [Token(Token = "0x60138EA")]
    [Address(RVA = "0x49C82B8", Offset = "0x49C82B8", VA = "0x49C82B8")]
    private void SetActiveTeam()
    {
    }

    [Token(Token = "0x60138EB")]
    [Address(RVA = "0x49C88B0", Offset = "0x49C88B0", VA = "0x49C88B0")]
    private void SetDeactiveTeam()
    {
    }

    [Token(Token = "0x60138EC")]
    [Address(RVA = "0x49C84C0", Offset = "0x49C84C0", VA = "0x49C84C0")]
    public static bool IsDuplicationEquipment(DeckSlot deckSlot) => new bool();

    [Token(Token = "0x60138ED")]
    [Address(RVA = "0x49C9B74", Offset = "0x49C9B74", VA = "0x49C9B74")]
    private static bool IsDuplicationCheck(DeckSlot slot, DeckSlot currentDeckSlot) => new bool();

    [Token(Token = "0x60138EE")]
    [Address(RVA = "0x49C9F34", Offset = "0x49C9F34", VA = "0x49C9F34")]
    private static bool WeaponDuplicationCheck(UniqueID checkId, DeckSlot currentDeckSlot)
    {
      return new bool();
    }

    [Token(Token = "0x60138EF")]
    [Address(RVA = "0x49CA078", Offset = "0x49CA078", VA = "0x49CA078")]
    private bool IsAllDuplicationCheck(OrganizationTeam team) => new bool();

    [Token(Token = "0x60138F0")]
    [Address(RVA = "0x49C6D48", Offset = "0x49C6D48", VA = "0x49C6D48")]
    private void SetForcedSortie()
    {
    }

    [Token(Token = "0x60138F1")]
    [Address(RVA = "0x49CA5E0", Offset = "0x49CA5E0", VA = "0x49CA5E0")]
    private void ResetForcedSortie()
    {
    }

    [Token(Token = "0x60138F2")]
    [Address(RVA = "0x49CA608", Offset = "0x49CA608", VA = "0x49CA608")]
    public bool CheckBattleStart(bool callAlert = true) => new bool();

    [Token(Token = "0x60138F3")]
    [Address(RVA = "0x49C72D8", Offset = "0x49C72D8", VA = "0x49C72D8")]
    protected void InitSortieType()
    {
    }

    [Token(Token = "0x60138F4")]
    [Address(RVA = "0x49C74A0", Offset = "0x49C74A0", VA = "0x49C74A0")]
    protected void InitSortieTypeArena()
    {
    }

    [Token(Token = "0x60138F5")]
    [Address(RVA = "0x49C6A90", Offset = "0x49C6A90", VA = "0x49C6A90")]
    public void CreateDeckList(IReadOnlyList<Deck> deckList)
    {
    }

    [Token(Token = "0x60138F6")]
    [Address(RVA = "0x49C6F44", Offset = "0x49C6F44", VA = "0x49C6F44")]
    public void CreateDeckListArena(IReadOnlyList<Deck> deckList)
    {
    }

    [Token(Token = "0x60138F7")]
    [Address(RVA = "0x49CA968", Offset = "0x49CA968", VA = "0x49CA968")]
    public int[] GetSortieDeckSlots() => (int[]) null;

    [Token(Token = "0x60138F8")]
    [Address(RVA = "0x49CA984", Offset = "0x49CA984", VA = "0x49CA984")]
    public List<string> GetSortieDeckSlotsStringList() => (List<string>) null;

    [Token(Token = "0x60138F9")]
    [Address(RVA = "0x49CA9A0", Offset = "0x49CA9A0", VA = "0x49CA9A0")]
    public List<string> GetUnitIdListWhoNeedsLevelupType() => (List<string>) null;

    [Token(Token = "0x60138FA")]
    [Address(RVA = "0x49CA9BC", Offset = "0x49CA9BC", VA = "0x49CA9BC")]
    public void UpdateParty(QuestPrepareAssetLoader loader)
    {
    }

    [Token(Token = "0x60138FB")]
    [Address(RVA = "0x49CA9EC", Offset = "0x49CA9EC", VA = "0x49CA9EC")]
    public void UpdatePartyArena(QuestPrepareAssetLoader loader)
    {
    }

    [Token(Token = "0x60138FC")]
    [Address(RVA = "0x49CAA0C", Offset = "0x49CAA0C", VA = "0x49CAA0C")]
    public void Delete()
    {
    }

    [Token(Token = "0x60138FD")]
    [Address(RVA = "0x49C6D20", Offset = "0x49C6D20", VA = "0x49C6D20")]
    private bool GetIsAllowMultipleSameCharacters() => new bool();

    [Token(Token = "0x60138FE")]
    [Address(RVA = "0x49CAB64", Offset = "0x49CAB64", VA = "0x49CAB64")]
    public PartyStyleManager()
    {
    }
  }
}
