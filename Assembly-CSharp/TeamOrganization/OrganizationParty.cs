// Decompiled with JetBrains decompiler
// Type: TeamOrganization.OrganizationParty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007E2")]
  public class OrganizationParty
  {
    [Token(Token = "0x40024E6")]
    public const int DeckSlotMax = 5;

    [Token(Token = "0x17000698")]
    public OrganizationPartySlot[] SlotData
    {
      [Token(Token = "0x6002C92"), Address(RVA = "0x387F084", Offset = "0x387F084", VA = "0x387F084")] get
      {
        return (OrganizationPartySlot[]) null;
      }
      [Token(Token = "0x6002C93"), Address(RVA = "0x387F08C", Offset = "0x387F08C", VA = "0x387F08C")] set
      {
      }
    }

    [Token(Token = "0x17000699")]
    public int PartyIndex
    {
      [Token(Token = "0x6002C94"), Address(RVA = "0x387F094", Offset = "0x387F094", VA = "0x387F094")] get
      {
        return new int();
      }
      [Token(Token = "0x6002C95"), Address(RVA = "0x387F09C", Offset = "0x387F09C", VA = "0x387F09C")] private set
      {
      }
    }

    [Token(Token = "0x6002C96")]
    [Address(RVA = "0x387F0A4", Offset = "0x387F0A4", VA = "0x387F0A4")]
    public OrganizationParty(DeckSlot[] deckSlots, int index)
    {
    }

    [Token(Token = "0x6002C97")]
    [Address(RVA = "0x387F3C4", Offset = "0x387F3C4", VA = "0x387F3C4")]
    public OrganizationParty(int index)
    {
    }

    [Token(Token = "0x6002C98")]
    [Address(RVA = "0x387F4D0", Offset = "0x387F4D0", VA = "0x387F4D0")]
    public void ChangeUnit(int index, Style style, bool setEquipmentSet)
    {
    }

    [Token(Token = "0x6002C99")]
    [Address(RVA = "0x387F630", Offset = "0x387F630", VA = "0x387F630")]
    public void RemoveUnitAll()
    {
    }

    [Token(Token = "0x6002C9A")]
    [Address(RVA = "0x387F694", Offset = "0x387F694", VA = "0x387F694")]
    public void AllUnitUnEquipment()
    {
    }

    [Token(Token = "0x6002C9B")]
    [Address(RVA = "0x387F888", Offset = "0x387F888", VA = "0x387F888")]
    public void SortParty()
    {
    }

    [Token(Token = "0x6002C9C")]
    [Address(RVA = "0x387F938", Offset = "0x387F938", VA = "0x387F938")]
    private void ChangeSlot(int index1, int index2)
    {
    }

    [Token(Token = "0x6002C9D")]
    [Address(RVA = "0x38800DC", Offset = "0x38800DC", VA = "0x38800DC")]
    public int GetTotalCombatPower(Func<OrganizationPartySlot, bool> condition) => new int();

    [Token(Token = "0x6002C9E")]
    [Address(RVA = "0x38801AC", Offset = "0x38801AC", VA = "0x38801AC")]
    public void Filter(
      Func<OrganizationPartySlot, bool> condition,
      Action<OrganizationPartySlot> filteredAction)
    {
    }

    [Token(Token = "0x6002C9F")]
    [Address(RVA = "0x388040C", Offset = "0x388040C", VA = "0x388040C")]
    public MindEquipmentSkill[] GetAllMindEquipmentSkills() => (MindEquipmentSkill[]) null;

    [Token(Token = "0x6002CA0")]
    [Address(RVA = "0x3880520", Offset = "0x3880520", VA = "0x3880520")]
    public static List<PlayerDeckSlotInfo> CreatePlayerUnitType(OrganizationParty party)
    {
      return (List<PlayerDeckSlotInfo>) null;
    }

    [Token(Token = "0x6002CA1")]
    [Address(RVA = "0x38809B0", Offset = "0x38809B0", VA = "0x38809B0")]
    public void CheckAttention(
      OrganizationPartySlot checkSlot,
      ref PartySlotAttentionData attentionData)
    {
    }
  }
}
