// Decompiled with JetBrains decompiler
// Type: TeamOrganization.PartyView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x2000823")]
  public class PartyView : MonoBehaviour
  {
    [Token(Token = "0x40026AB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private FormationSlotView[] partySlotViews;
    [Token(Token = "0x40026AC")]
    private const int deckSlotMax = 5;

    [Token(Token = "0x170006E7")]
    public OrganizationPartySlot[] SlotData
    {
      [Token(Token = "0x6002EC0"), Address(RVA = "0x3E68828", Offset = "0x3E68828", VA = "0x3E68828")] get
      {
        return (OrganizationPartySlot[]) null;
      }
      [Token(Token = "0x6002EC1"), Address(RVA = "0x3E68830", Offset = "0x3E68830", VA = "0x3E68830")] set
      {
      }
    }

    [Token(Token = "0x6002EC2")]
    [Address(RVA = "0x3E68838", Offset = "0x3E68838", VA = "0x3E68838", Slot = "4")]
    public virtual void Create(FormationSlotView usePrefab)
    {
    }

    [Token(Token = "0x6002EC3")]
    [Address(RVA = "0x3E689AC", Offset = "0x3E689AC", VA = "0x3E689AC", Slot = "5")]
    public virtual void Initialize(
      OrganizationPartySlot[] organizationPartySlots,
      TeamView teamView,
      bool isNeedLp,
      bool isGuildRaid,
      List<string> usedStyleIds,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002EC4")]
    [Address(RVA = "0x3E68A90", Offset = "0x3E68A90", VA = "0x3E68A90")]
    public void UpdateView(
      OrganizationPartySlot organizationPartySlot,
      int index,
      bool isCallSpawnerStartRequest)
    {
    }

    [Token(Token = "0x6002EC5")]
    [Address(RVA = "0x3E68B7C", Offset = "0x3E68B7C", VA = "0x3E68B7C")]
    public void SetStyleSlotAction(
      Action<OrganizationPartySlot, FormationSlotView> onClickUnitSlot)
    {
    }

    [Token(Token = "0x6002EC6")]
    [Address(RVA = "0x3E68C4C", Offset = "0x3E68C4C", VA = "0x3E68C4C")]
    public void SetCustomSkillSlotAction(
      Action<OrganizationPartySlot> onClickCustomSkillSlotButton)
    {
    }

    [Token(Token = "0x6002EC7")]
    [Address(RVA = "0x3E68D24", Offset = "0x3E68D24", VA = "0x3E68D24")]
    public void SetEquipemntSlotAction(
      Action<OrganizationPartySlot, OrganizationEquipmentSlot, FormationSlotEquipmentView> onClickEquipmentSlot = null)
    {
    }

    [Token(Token = "0x6002EC8")]
    [Address(RVA = "0x3E68DFC", Offset = "0x3E68DFC", VA = "0x3E68DFC")]
    public void SetStyleSlotEnchanceAction(
      Action<OrganizationPartySlot> onClickUnitSlotEnchance)
    {
    }

    [Token(Token = "0x6002EC9")]
    [Address(RVA = "0x3E68ECC", Offset = "0x3E68ECC", VA = "0x3E68ECC")]
    public PartyView()
    {
    }
  }
}
