// Decompiled with JetBrains decompiler
// Type: TeamOrganization.OrganizationTeam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007E6")]
  public class OrganizationTeam
  {
    [Token(Token = "0x4002501")]
    private const int partySlotMax = 3;

    [Token(Token = "0x170006A8")]
    public int Idx
    {
      [Token(Token = "0x6002CF8"), Address(RVA = "0x3A81C6C", Offset = "0x3A81C6C", VA = "0x3A81C6C")] get
      {
        return new int();
      }
      [Token(Token = "0x6002CF9"), Address(RVA = "0x3A81C74", Offset = "0x3A81C74", VA = "0x3A81C74")] private set
      {
      }
    }

    [Token(Token = "0x170006A9")]
    public string Name
    {
      [Token(Token = "0x6002CFA"), Address(RVA = "0x3A81C7C", Offset = "0x3A81C7C", VA = "0x3A81C7C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6002CFB"), Address(RVA = "0x3A81C84", Offset = "0x3A81C84", VA = "0x3A81C84")] set
      {
      }
    }

    [Token(Token = "0x170006AA")]
    public int AiTypeID
    {
      [Token(Token = "0x6002CFC"), Address(RVA = "0x3A81C8C", Offset = "0x3A81C8C", VA = "0x3A81C8C")] get
      {
        return new int();
      }
      [Token(Token = "0x6002CFD"), Address(RVA = "0x3A81C94", Offset = "0x3A81C94", VA = "0x3A81C94")] set
      {
      }
    }

    [Token(Token = "0x170006AB")]
    public int ItemSetID
    {
      [Token(Token = "0x6002CFE"), Address(RVA = "0x3A81C9C", Offset = "0x3A81C9C", VA = "0x3A81C9C")] get
      {
        return new int();
      }
      [Token(Token = "0x6002CFF"), Address(RVA = "0x3A81CA4", Offset = "0x3A81CA4", VA = "0x3A81CA4")] set
      {
      }
    }

    [Token(Token = "0x170006AC")]
    public bool IsItemSetSetting
    {
      [Token(Token = "0x6002D00"), Address(RVA = "0x3A81CAC", Offset = "0x3A81CAC", VA = "0x3A81CAC")] get
      {
        return new bool();
      }
      [Token(Token = "0x6002D01"), Address(RVA = "0x3A81CB4", Offset = "0x3A81CB4", VA = "0x3A81CB4")] set
      {
      }
    }

    [Token(Token = "0x170006AD")]
    public OrganizationParty[] PartyData
    {
      [Token(Token = "0x6002D02"), Address(RVA = "0x3A81CC0", Offset = "0x3A81CC0", VA = "0x3A81CC0")] get
      {
        return (OrganizationParty[]) null;
      }
      [Token(Token = "0x6002D03"), Address(RVA = "0x3A81CC8", Offset = "0x3A81CC8", VA = "0x3A81CC8")] set
      {
      }
    }

    [Token(Token = "0x170006AE")]
    public OrganizationTeam.TeamSizeType SizeType
    {
      [Token(Token = "0x6002D04"), Address(RVA = "0x3A81CD0", Offset = "0x3A81CD0", VA = "0x3A81CD0")] get
      {
        return new OrganizationTeam.TeamSizeType();
      }
      [Token(Token = "0x6002D05"), Address(RVA = "0x3A81CD8", Offset = "0x3A81CD8", VA = "0x3A81CD8")] private set
      {
      }
    }

    [Token(Token = "0x170006AF")]
    public DeckTypeEnum DeckType
    {
      [Token(Token = "0x6002D06"), Address(RVA = "0x3A81CE0", Offset = "0x3A81CE0", VA = "0x3A81CE0")] get
      {
        return new DeckTypeEnum();
      }
      [Token(Token = "0x6002D07"), Address(RVA = "0x3A81CE8", Offset = "0x3A81CE8", VA = "0x3A81CE8")] private set
      {
      }
    }

    [Token(Token = "0x6002D08")]
    [Address(RVA = "0x3A81CF0", Offset = "0x3A81CF0", VA = "0x3A81CF0")]
    public OrganizationTeam(Deck deck, bool isTemplate = false)
    {
    }

    [Token(Token = "0x6002D09")]
    [Address(RVA = "0x3A833AC", Offset = "0x3A833AC", VA = "0x3A833AC")]
    public OrganizationTeam(
      int idx,
      string name,
      int aiTypeID,
      int itemSetID,
      bool isItemSetSetting,
      bool isTemplate,
      OrganizationTeam.TeamSizeType sizeType)
    {
    }

    [Token(Token = "0x6002D0A")]
    [Address(RVA = "0x3A835D4", Offset = "0x3A835D4", VA = "0x3A835D4")]
    public void ChangeDeckName(string newName)
    {
    }

    [Token(Token = "0x6002D0B")]
    [Address(RVA = "0x3A835DC", Offset = "0x3A835DC", VA = "0x3A835DC")]
    public void ChangeDeckIndex(int index)
    {
    }

    [Token(Token = "0x6002D0C")]
    [Address(RVA = "0x3A835E4", Offset = "0x3A835E4", VA = "0x3A835E4")]
    public void ChangeUnit(int index, Style style, bool setEquipmentSet = true)
    {
    }

    [Token(Token = "0x6002D0D")]
    [Address(RVA = "0x3A83A4C", Offset = "0x3A83A4C", VA = "0x3A83A4C")]
    public void SortPartyAll()
    {
    }

    [Token(Token = "0x6002D0E")]
    [Address(RVA = "0x3A83AAC", Offset = "0x3A83AAC", VA = "0x3A83AAC")]
    public void RemoveUnitAll()
    {
    }

    [Token(Token = "0x6002D0F")]
    [Address(RVA = "0x3A83B0C", Offset = "0x3A83B0C", VA = "0x3A83B0C")]
    public void AllUnitUnEquipment()
    {
    }

    [Token(Token = "0x6002D10")]
    [Address(RVA = "0x3A83B6C", Offset = "0x3A83B6C", VA = "0x3A83B6C")]
    public void OverrideTemplate(int partyIndex, int templateID)
    {
    }

    [Token(Token = "0x6002D11")]
    [Address(RVA = "0x3A83764", Offset = "0x3A83764", VA = "0x3A83764")]
    public void ChangeSlot(int index1, int index2)
    {
    }

    [Token(Token = "0x6002D12")]
    [Address(RVA = "0x3A83F74", Offset = "0x3A83F74", VA = "0x3A83F74")]
    public OrganizationPartySlot GetOrganizationPartySlot(int partyIndex)
    {
      return (OrganizationPartySlot) null;
    }

    [Token(Token = "0x6002D13")]
    [Address(RVA = "0x3A84038", Offset = "0x3A84038", VA = "0x3A84038")]
    public int GetTotalCombatPower() => new int();

    [Token(Token = "0x6002D14")]
    [Address(RVA = "0x3A84184", Offset = "0x3A84184", VA = "0x3A84184")]
    public bool IsDeckEmpty() => new bool();

    [Token(Token = "0x6002D15")]
    [Address(RVA = "0x3A84238", Offset = "0x3A84238", VA = "0x3A84238")]
    public bool IsDeckFull() => new bool();

    [Token(Token = "0x6002D16")]
    [Address(RVA = "0x3A842EC", Offset = "0x3A842EC", VA = "0x3A842EC")]
    public bool IsDeckParty1Empty() => new bool();

    [Token(Token = "0x6002D17")]
    [Address(RVA = "0x3A84374", Offset = "0x3A84374", VA = "0x3A84374")]
    public bool IsLostUnit(bool isViewLp, int questUnitNum) => new bool();

    [Token(Token = "0x6002D18")]
    [Address(RVA = "0x3A844C8", Offset = "0x3A844C8", VA = "0x3A844C8")]
    public bool IsAlreadyDispatched(bool isGuildRaid, List<string> usedStyleIds, int questUnitNum)
    {
      return new bool();
    }

    [Token(Token = "0x6002D19")]
    [Address(RVA = "0x3A84648", Offset = "0x3A84648", VA = "0x3A84648")]
    public List<int> GetDeckSetStyleIdList() => (List<int>) null;

    [Token(Token = "0x6002D1A")]
    [Address(RVA = "0x3A847CC", Offset = "0x3A847CC", VA = "0x3A847CC")]
    public List<UniqueID> GetDeckSetEquipUniqueID() => (List<UniqueID>) null;

    [Token(Token = "0x6002D1B")]
    [Address(RVA = "0x3A8490C", Offset = "0x3A8490C", VA = "0x3A8490C")]
    public List<UniqueID> GetDeckSetCustomSkillUniqueID() => (List<UniqueID>) null;

    [Token(Token = "0x6002D1C")]
    [Address(RVA = "0x3A84A4C", Offset = "0x3A84A4C", VA = "0x3A84A4C")]
    public MindEquipmentSkill[] GetAllMindEquipmentSkills() => (MindEquipmentSkill[]) null;

    [Token(Token = "0x6002D1D")]
    [Address(RVA = "0x3A84B4C", Offset = "0x3A84B4C", VA = "0x3A84B4C")]
    public Dictionary<UniqueID, List<EquipParameterViewBase.EquipParameterInfo>> GetDeckSetEquipmentUniqueIdAndCharaName(
      OrganizationEquipmentSlot.EquipmentSlotType equipmentSlotType)
    {
      return (Dictionary<UniqueID, List<EquipParameterViewBase.EquipParameterInfo>>) null;
    }

    [Token(Token = "0x6002D1E")]
    [Address(RVA = "0x3A84FDC", Offset = "0x3A84FDC", VA = "0x3A84FDC")]
    public int GetMemberSetNum(int length = 0) => new int();

    [Token(Token = "0x6002D1F")]
    [Address(RVA = "0x3A85198", Offset = "0x3A85198", VA = "0x3A85198")]
    private List<int> GetNotEmptySlotNumberList() => (List<int>) null;

    [Token(Token = "0x6002D20")]
    [Address(RVA = "0x3A85320", Offset = "0x3A85320", VA = "0x3A85320")]
    public int GetPrevPartySlot(int index) => new int();

    [Token(Token = "0x6002D21")]
    [Address(RVA = "0x3A853B8", Offset = "0x3A853B8", VA = "0x3A853B8")]
    public int GetNextPartySlot(int index) => new int();

    [Token(Token = "0x6002D22")]
    [Address(RVA = "0x3A85464", Offset = "0x3A85464", VA = "0x3A85464")]
    public bool CheckDifference(Deck deck) => new bool();

    [Token(Token = "0x6002D23")]
    [Address(RVA = "0x3A856E8", Offset = "0x3A856E8", VA = "0x3A856E8")]
    public bool IsDuplicationCheck(OrganizationPartySlot slot, bool isAllowMultipleSameCharacters)
    {
      return new bool();
    }

    [Token(Token = "0x6002D24")]
    [Address(RVA = "0x3A85818", Offset = "0x3A85818", VA = "0x3A85818")]
    public PartySlotAttentionData CheckSlotAttention(OrganizationPartySlot checkSlot)
    {
      return (PartySlotAttentionData) null;
    }

    [Token(Token = "0x6002D25")]
    [Address(RVA = "0x3A83388", Offset = "0x3A83388", VA = "0x3A83388")]
    private OrganizationTeam.TeamSizeType GetTeamSizeType(DeckTypeEnum deckType)
    {
      return new OrganizationTeam.TeamSizeType();
    }

    [Token(Token = "0x6002D26")]
    [Address(RVA = "0x3A859DC", Offset = "0x3A859DC", VA = "0x3A859DC")]
    public static PlayerDeckType CreatePlayerDeckTypeArena(
      OrganizationTeam team,
      DeckTypeEnum deckType,
      int deckNo)
    {
      return (PlayerDeckType) null;
    }

    [Token(Token = "0x6002D27")]
    [Address(RVA = "0x3A85AEC", Offset = "0x3A85AEC", VA = "0x3A85AEC")]
    private static List<PlayerDeckSlotInfo> CreateSlotInfoList(OrganizationPartySlot[] deck)
    {
      return (List<PlayerDeckSlotInfo>) null;
    }

    [Token(Token = "0x6002D28")]
    [Address(RVA = "0x3A85C08", Offset = "0x3A85C08", VA = "0x3A85C08")]
    private static PlayerDeckSlotInfo CreateSlotInfo(OrganizationPartySlot slot, int index)
    {
      return (PlayerDeckSlotInfo) null;
    }

    [Token(Token = "0x6002D29")]
    [Address(RVA = "0x3A85FD0", Offset = "0x3A85FD0", VA = "0x3A85FD0")]
    public static APIDeckEditRequest CreateDeckEditRequest(OrganizationTeam team)
    {
      return (APIDeckEditRequest) null;
    }

    [Token(Token = "0x20007E7")]
    public enum TeamSizeType
    {
      [Token(Token = "0x400250B")] Nomal = 1,
      [Token(Token = "0x400250C")] Medium = 2,
      [Token(Token = "0x400250D")] Large = 3,
    }
  }
}
