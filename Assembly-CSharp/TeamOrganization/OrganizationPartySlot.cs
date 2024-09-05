// Decompiled with JetBrains decompiler
// Type: TeamOrganization.OrganizationPartySlot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007E4")]
  public class OrganizationPartySlot
  {
    [Token(Token = "0x40024F7")]
    private const int CUSTOM_SKILL_MAX = 3;

    [Token(Token = "0x1700069A")]
    public OrganizationPartySlot.SlotType Type
    {
      [Token(Token = "0x6002CA4"), Address(RVA = "0x3880CCC", Offset = "0x3880CCC", VA = "0x3880CCC")] get
      {
        return new OrganizationPartySlot.SlotType();
      }
      [Token(Token = "0x6002CA5"), Address(RVA = "0x3880CD4", Offset = "0x3880CD4", VA = "0x3880CD4")] private set
      {
      }
    }

    [Token(Token = "0x1700069B")]
    public int Index
    {
      [Token(Token = "0x6002CA6"), Address(RVA = "0x3880CDC", Offset = "0x3880CDC", VA = "0x3880CDC")] get
      {
        return new int();
      }
      [Token(Token = "0x6002CA7"), Address(RVA = "0x3880CE4", Offset = "0x3880CE4", VA = "0x3880CE4")] set
      {
      }
    }

    [Token(Token = "0x1700069C")]
    public int PartyIndex
    {
      [Token(Token = "0x6002CA8"), Address(RVA = "0x3880CEC", Offset = "0x3880CEC", VA = "0x3880CEC")] get
      {
        return new int();
      }
      [Token(Token = "0x6002CA9"), Address(RVA = "0x3880CF4", Offset = "0x3880CF4", VA = "0x3880CF4")] set
      {
      }
    }

    [Token(Token = "0x1700069D")]
    public Style StyleData
    {
      [Token(Token = "0x6002CAA"), Address(RVA = "0x3880CFC", Offset = "0x3880CFC", VA = "0x3880CFC")] get
      {
        return (Style) null;
      }
      [Token(Token = "0x6002CAB"), Address(RVA = "0x3880D04", Offset = "0x3880D04", VA = "0x3880D04")] private set
      {
      }
    }

    [Token(Token = "0x1700069E")]
    public StaqData.UniqueID? UniqueID
    {
      [Token(Token = "0x6002CAC"), Address(RVA = "0x3880D0C", Offset = "0x3880D0C", VA = "0x3880D0C")] get
      {
        return new StaqData.UniqueID?();
      }
      [Token(Token = "0x6002CAD"), Address(RVA = "0x3880D18", Offset = "0x3880D18", VA = "0x3880D18")] private set
      {
      }
    }

    [Token(Token = "0x1700069F")]
    public StaqData.UniqueID? EquipmentUniqueId
    {
      [Token(Token = "0x6002CAE"), Address(RVA = "0x3880D20", Offset = "0x3880D20", VA = "0x3880D20")] get
      {
        return new StaqData.UniqueID?();
      }
      [Token(Token = "0x6002CAF"), Address(RVA = "0x3880D2C", Offset = "0x3880D2C", VA = "0x3880D2C")] set
      {
      }
    }

    [Token(Token = "0x170006A0")]
    public StaqData.UniqueID? AccessoriesUniqueId
    {
      [Token(Token = "0x6002CB0"), Address(RVA = "0x3880D34", Offset = "0x3880D34", VA = "0x3880D34")] get
      {
        return new StaqData.UniqueID?();
      }
      [Token(Token = "0x6002CB1"), Address(RVA = "0x3880D40", Offset = "0x3880D40", VA = "0x3880D40")] set
      {
      }
    }

    [Token(Token = "0x170006A1")]
    public StaqData.UniqueID? UnitTrustUniqueId
    {
      [Token(Token = "0x6002CB2"), Address(RVA = "0x3880D48", Offset = "0x3880D48", VA = "0x3880D48")] get
      {
        return new StaqData.UniqueID?();
      }
      [Token(Token = "0x6002CB3"), Address(RVA = "0x3880D54", Offset = "0x3880D54", VA = "0x3880D54")] set
      {
      }
    }

    [Token(Token = "0x170006A2")]
    public StaqData.UniqueID? VisionUniqueId
    {
      [Token(Token = "0x6002CB4"), Address(RVA = "0x3880D5C", Offset = "0x3880D5C", VA = "0x3880D5C")] get
      {
        return new StaqData.UniqueID?();
      }
      [Token(Token = "0x6002CB5"), Address(RVA = "0x3880D68", Offset = "0x3880D68", VA = "0x3880D68")] set
      {
      }
    }

    [Token(Token = "0x170006A3")]
    public StaqData.UniqueID? SubWeaponUnique1Id
    {
      [Token(Token = "0x6002CB6"), Address(RVA = "0x3880D70", Offset = "0x3880D70", VA = "0x3880D70")] get
      {
        return new StaqData.UniqueID?();
      }
      [Token(Token = "0x6002CB7"), Address(RVA = "0x3880D7C", Offset = "0x3880D7C", VA = "0x3880D7C")] private set
      {
      }
    }

    [Token(Token = "0x170006A4")]
    public StaqData.UniqueID? SubWeaponUnique2Id
    {
      [Token(Token = "0x6002CB8"), Address(RVA = "0x3880D84", Offset = "0x3880D84", VA = "0x3880D84")] get
      {
        return new StaqData.UniqueID?();
      }
      [Token(Token = "0x6002CB9"), Address(RVA = "0x3880D90", Offset = "0x3880D90", VA = "0x3880D90")] private set
      {
      }
    }

    [Token(Token = "0x170006A5")]
    public OrganizationEquipmentSlot[] EquipmentSlotData
    {
      [Token(Token = "0x6002CBA"), Address(RVA = "0x3880D98", Offset = "0x3880D98", VA = "0x3880D98")] get
      {
        return (OrganizationEquipmentSlot[]) null;
      }
      [Token(Token = "0x6002CBB"), Address(RVA = "0x3880DA0", Offset = "0x3880DA0", VA = "0x3880DA0")] private set
      {
      }
    }

    [Token(Token = "0x170006A6")]
    public OrganizationCustomSkillSlot[] CustomSkillSlotData
    {
      [Token(Token = "0x6002CBC"), Address(RVA = "0x3880DA8", Offset = "0x3880DA8", VA = "0x3880DA8")] get
      {
        return (OrganizationCustomSkillSlot[]) null;
      }
      [Token(Token = "0x6002CBD"), Address(RVA = "0x3880DB0", Offset = "0x3880DB0", VA = "0x3880DB0")] private set
      {
      }
    }

    [Token(Token = "0x170006A7")]
    public bool IsEmpty
    {
      [Token(Token = "0x6002CBE"), Address(RVA = "0x38752EC", Offset = "0x38752EC", VA = "0x38752EC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6002CBF")]
    [Address(RVA = "0x3880DB8", Offset = "0x3880DB8", VA = "0x3880DB8")]
    public void SetSlotType(OrganizationPartySlot.SlotType slotType)
    {
    }

    [Token(Token = "0x6002CC0")]
    [Address(RVA = "0x387F214", Offset = "0x387F214", VA = "0x387F214")]
    public OrganizationPartySlot(
      DeckSlot deckSlot,
      OrganizationPartySlot.SlotType slotType,
      int index,
      int partyIndex)
    {
    }

    [Token(Token = "0x6002CC1")]
    [Address(RVA = "0x3876080", Offset = "0x3876080", VA = "0x3876080")]
    public OrganizationPartySlot(
      OrganizationPartySlot.SlotType slotType,
      int index,
      int partyIndex)
    {
    }

    [Token(Token = "0x6002CC2")]
    [Address(RVA = "0x3876960", Offset = "0x3876960", VA = "0x3876960")]
    public OrganizationPartySlot(
      OrganizationPartySlot.SlotType slotType,
      int index,
      int partyIndex,
      Style style)
    {
    }

    [Token(Token = "0x6002CC3")]
    [Address(RVA = "0x387FAA8", Offset = "0x387FAA8", VA = "0x387FAA8")]
    public OrganizationPartySlot(OrganizationPartySlot.SlotType slotType)
    {
    }

    [Token(Token = "0x6002CC4")]
    [Address(RVA = "0x3881834", Offset = "0x3881834", VA = "0x3881834")]
    public OrganizationPartySlot(int npcStyleId)
    {
    }

    [Token(Token = "0x6002CC5")]
    [Address(RVA = "0x3880FE8", Offset = "0x3880FE8", VA = "0x3880FE8")]
    private void InitData()
    {
    }

    [Token(Token = "0x6002CC6")]
    [Address(RVA = "0x387FC40", Offset = "0x387FC40", VA = "0x387FC40")]
    public void SetData(OrganizationPartySlot slot)
    {
    }

    [Token(Token = "0x6002CC7")]
    [Address(RVA = "0x38819C8", Offset = "0x38819C8", VA = "0x38819C8")]
    private void SetNpcStyle(int npcId)
    {
    }

    [Token(Token = "0x6002CC8")]
    [Address(RVA = "0x387F574", Offset = "0x387F574", VA = "0x387F574")]
    public void SetStyle(Style style, bool setEquipmentSet = true)
    {
    }

    [Token(Token = "0x6002CC9")]
    [Address(RVA = "0x3880DC0", Offset = "0x3880DC0", VA = "0x3880DC0")]
    public void UpdateStyle(DeckSlot deckSlot)
    {
    }

    [Token(Token = "0x6002CCA")]
    [Address(RVA = "0x3882040", Offset = "0x3882040", VA = "0x3882040")]
    public void UpdateStyle(StaqData.UniqueID styleID)
    {
    }

    [Token(Token = "0x6002CCB")]
    [Address(RVA = "0x38821C0", Offset = "0x38821C0", VA = "0x38821C0")]
    public void UpdateEquipments(
      StaqData.UniqueID mainweapon,
      StaqData.UniqueID subweapon1,
      StaqData.UniqueID subweapon2,
      StaqData.UniqueID accessory,
      StaqData.UniqueID unitTrust,
      StaqData.UniqueID vision,
      bool isForExpendition)
    {
    }

    [Token(Token = "0x6002CCC")]
    [Address(RVA = "0x3881D54", Offset = "0x3881D54", VA = "0x3881D54")]
    private void UpdateSlot(bool isForExpendition = false)
    {
    }

    [Token(Token = "0x6002CCD")]
    [Address(RVA = "0x3881358", Offset = "0x3881358", VA = "0x3881358")]
    public void UpdateStyleEquipSet(Style style)
    {
    }

    [Token(Token = "0x6002CCE")]
    [Address(RVA = "0x38822F8", Offset = "0x38822F8", VA = "0x38822F8")]
    public void UnEquipment(
      OrganizationEquipmentSlot.EquipmentSlotType slotType,
      StaqData.UniqueID itemUniqueID)
    {
    }

    [Token(Token = "0x6002CCF")]
    [Address(RVA = "0x3882528", Offset = "0x3882528", VA = "0x3882528")]
    public void SetEquipment(
      OrganizationEquipmentSlot.EquipmentSlotType slotType,
      Equipment equipment)
    {
    }

    [Token(Token = "0x6002CD0")]
    [Address(RVA = "0x387F6F0", Offset = "0x387F6F0", VA = "0x387F6F0")]
    public void UnEquipmentAll()
    {
    }

    [Token(Token = "0x6002CD1")]
    [Address(RVA = "0x38825D0", Offset = "0x38825D0", VA = "0x38825D0")]
    public bool IsCustomSkillSet(int customSkillId) => new bool();

    [Token(Token = "0x6002CD2")]
    [Address(RVA = "0x3882630", Offset = "0x3882630", VA = "0x3882630")]
    public int GetEquipCharacterSkillCount() => new int();

    [Token(Token = "0x6002CD3")]
    [Address(RVA = "0x3882698", Offset = "0x3882698", VA = "0x3882698")]
    public int GetEquipCharacterSkillCountExceptSelf(int selectItemIndex) => new int();

    [Token(Token = "0x6002CD4")]
    [Address(RVA = "0x3882714", Offset = "0x3882714", VA = "0x3882714")]
    public int GetEquipStratagemSkillCount() => new int();

    [Token(Token = "0x6002CD5")]
    [Address(RVA = "0x388279C", Offset = "0x388279C", VA = "0x388279C")]
    public int GetEquipStratagemSkillCountExceptSelf(int selectItemIndex) => new int();

    [Token(Token = "0x6002CD6")]
    [Address(RVA = "0x3882830", Offset = "0x3882830", VA = "0x3882830")]
    public void UpdateCustomSkills(List<StaqData.UniqueID> customSkillIds)
    {
    }

    [Token(Token = "0x6002CD7")]
    [Address(RVA = "0x386BD68", Offset = "0x386BD68", VA = "0x386BD68")]
    public void SetCustomSkill(int index, CustomSkill customSkill)
    {
    }

    [Token(Token = "0x6002CD8")]
    [Address(RVA = "0x3882974", Offset = "0x3882974", VA = "0x3882974")]
    public void RemoveCustomSkillSlot(int index)
    {
    }

    [Token(Token = "0x6002CD9")]
    [Address(RVA = "0x386BCF8", Offset = "0x386BCF8", VA = "0x386BCF8")]
    public void RemoveCustomSkillSlot(CustomSkill customSkill)
    {
    }

    [Token(Token = "0x6002CDA")]
    [Address(RVA = "0x38829AC", Offset = "0x38829AC", VA = "0x38829AC")]
    public void RefreshCustomSkillSlotSlot()
    {
    }

    [Token(Token = "0x6002CDB")]
    [Address(RVA = "0x3882BAC", Offset = "0x3882BAC", VA = "0x3882BAC")]
    public bool IsUnlock(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return new bool();
    }

    [Token(Token = "0x6002CDC")]
    [Address(RVA = "0x3882BC0", Offset = "0x3882BC0", VA = "0x3882BC0")]
    public int GetEquipmentId(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return new int();
    }

    [Token(Token = "0x6002CDD")]
    [Address(RVA = "0x3882C08", Offset = "0x3882C08", VA = "0x3882C08")]
    public Equipment GetEquipment(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return (Equipment) null;
    }

    [Token(Token = "0x6002CDE")]
    [Address(RVA = "0x3881A44", Offset = "0x3881A44", VA = "0x3881A44")]
    private Equipment GetEquipment(StaqData.UniqueID? uniqueId, bool isForExpendition = false)
    {
      return (Equipment) null;
    }

    [Token(Token = "0x6002CDF")]
    [Address(RVA = "0x387B0EC", Offset = "0x387B0EC", VA = "0x387B0EC")]
    public WeaponSkill[] GetWeaponSkills() => (WeaponSkill[]) null;

    [Token(Token = "0x6002CE0")]
    [Address(RVA = "0x387B288", Offset = "0x387B288", VA = "0x387B288")]
    public AccessorySkill[] GetAccessorySkills() => (AccessorySkill[]) null;

    [Token(Token = "0x6002CE1")]
    [Address(RVA = "0x387B31C", Offset = "0x387B31C", VA = "0x387B31C")]
    public MindEquipmentSkill[] GetMindEquipmentSkills() => (MindEquipmentSkill[]) null;

    [Token(Token = "0x6002CE2")]
    [Address(RVA = "0x387B3B0", Offset = "0x387B3B0", VA = "0x387B3B0")]
    public UnitTrustSkill GetUnitTrustSkills() => (UnitTrustSkill) null;

    [Token(Token = "0x6002CE3")]
    [Address(RVA = "0x3882C40", Offset = "0x3882C40", VA = "0x3882C40")]
    public List<StaqData.UniqueID> GetCustomSkillUniqueIDList() => (List<StaqData.UniqueID>) null;

    [Token(Token = "0x6002CE4")]
    [Address(RVA = "0x387B6C0", Offset = "0x387B6C0", VA = "0x387B6C0")]
    public CustomSkill[] GetCustomSkills() => (CustomSkill[]) null;

    [Token(Token = "0x6002CE5")]
    [Address(RVA = "0x3882D70", Offset = "0x3882D70", VA = "0x3882D70")]
    public int GetSetCustomSkillTotalCost() => new int();

    [Token(Token = "0x6002CE6")]
    [Address(RVA = "0x387F560", Offset = "0x387F560", VA = "0x387F560")]
    public int GetSlotIndex() => new int();

    [Token(Token = "0x6002CE7")]
    [Address(RVA = "0x3882DCC", Offset = "0x3882DCC", VA = "0x3882DCC")]
    public int GetIndexInParty() => new int();

    [Token(Token = "0x6002CE8")]
    [Address(RVA = "0x3882DD8", Offset = "0x3882DD8", VA = "0x3882DD8")]
    public List<StaqData.UniqueID> GetEquipmentUniqueIDList() => (List<StaqData.UniqueID>) null;

    [Token(Token = "0x6002CE9")]
    [Address(RVA = "0x3882F08", Offset = "0x3882F08", VA = "0x3882F08")]
    public Dictionary<StaqData.UniqueID, EquipParameterViewBase.EquipParameterInfo> GetEquipmentUniqueIDAndCharaName(
      OrganizationEquipmentSlot.EquipmentSlotType equipmentSlotType)
    {
      return (Dictionary<StaqData.UniqueID, EquipParameterViewBase.EquipParameterInfo>) null;
    }

    [Token(Token = "0x6002CEA")]
    [Address(RVA = "0x38752FC", Offset = "0x38752FC", VA = "0x38752FC")]
    public List<Equipment> GetEquipmentList() => (List<Equipment>) null;

    [Token(Token = "0x6002CEB")]
    [Address(RVA = "0x3880BA0", Offset = "0x3880BA0", VA = "0x3880BA0")]
    public int GetCombatPower() => new int();

    [Token(Token = "0x6002CEC")]
    [Address(RVA = "0x38830F0", Offset = "0x38830F0", VA = "0x38830F0")]
    public bool WeaponDuplicationCheck() => new bool();

    [Token(Token = "0x6002CED")]
    [Address(RVA = "0x3883214", Offset = "0x3883214", VA = "0x3883214")]
    public void SetEquipmentSlotData()
    {
    }

    [Token(Token = "0x6002CEE")]
    [Address(RVA = "0x388349C", Offset = "0x388349C", VA = "0x388349C")]
    public bool CheckDifference(DeckSlot deckSlot) => new bool();

    [Token(Token = "0x6002CEF")]
    [Address(RVA = "0x3876C7C", Offset = "0x3876C7C", VA = "0x3876C7C")]
    public bool CheckDifference(OrganizationPartySlot checkSlot) => new bool();

    [Token(Token = "0x6002CF0")]
    [Address(RVA = "0x3880684", Offset = "0x3880684", VA = "0x3880684")]
    public PlayerDeckSlotInfo CreatePlayerEditDeckSlotInfo() => (PlayerDeckSlotInfo) null;

    [Token(Token = "0x6002CF1")]
    [Address(RVA = "0x38777E8", Offset = "0x38777E8", VA = "0x38777E8")]
    public PlayerUnitEditEquipmentSetType CreatePlayerUnitEquipmentSetType()
    {
      return (PlayerUnitEditEquipmentSetType) null;
    }

    [Token(Token = "0x6002CF2")]
    [Address(RVA = "0x3880A24", Offset = "0x3880A24", VA = "0x3880A24")]
    public void CheckAttention(
      OrganizationPartySlot checkSlot,
      ref PartySlotAttentionData attentionData)
    {
    }

    [Token(Token = "0x6002CF3")]
    [Address(RVA = "0x3883A04", Offset = "0x3883A04", VA = "0x3883A04")]
    public void CheckAttentionMyWeapon(ref PartySlotAttentionData attentionData)
    {
    }

    [Token(Token = "0x6002CF4")]
    [Address(RVA = "0x3883EB4", Offset = "0x3883EB4", VA = "0x3883EB4")]
    private bool CheckAttentionWeapon(OrganizationEquipmentSlot checkSlot) => new bool();

    [Token(Token = "0x6002CF5")]
    [Address(RVA = "0x3883B8C", Offset = "0x3883B8C", VA = "0x3883B8C")]
    public void CheckEquipAttention(
      OrganizationPartySlot checkSlot,
      ref PartySlotAttentionData attentionData)
    {
    }

    [Token(Token = "0x6002CF6")]
    [Address(RVA = "0x3883D64", Offset = "0x3883D64", VA = "0x3883D64")]
    public void CheckCustomSkillAttention(
      OrganizationPartySlot checkSlot,
      ref PartySlotAttentionData attentionData)
    {
    }

    [Token(Token = "0x20007E5")]
    public enum SlotType
    {
      [Token(Token = "0x40024F9")] Player,
      [Token(Token = "0x40024FA")] Trial,
      [Token(Token = "0x40024FB")] Stay,
      [Token(Token = "0x40024FC")] Guest,
      [Token(Token = "0x40024FD")] Assist,
      [Token(Token = "0x40024FE")] Friend,
      [Token(Token = "0x40024FF")] Guild,
      [Token(Token = "0x4002500")] None,
    }
  }
}
