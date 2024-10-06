// Decompiled with JetBrains decompiler
// Type: TeamOrganization.TeamView
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
  [Token(Token = "0x2000826")]
  public class TeamView : MonoBehaviour
  {
    [Token(Token = "0x40026C5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PartyView[] partyViews;
    [Token(Token = "0x40026C6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private FormationSlotView partySlotViewPrefab;
    [Token(Token = "0x40026C7")]
    private const int deckSlotMax = 3;
    [Token(Token = "0x40026C8")]
    [FieldOffset(Offset = "0x28")]
    private OrganizationTeam organizationTeam;
    [Token(Token = "0x40026C9")]
    [FieldOffset(Offset = "0x30")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x40026CB")]
    [FieldOffset(Offset = "0x40")]
    public List<Transform> partyNumberIconTransforms;

    [Token(Token = "0x170006EB")]
    public OrganizationParty[] partySlotData
    {
      [Token(Token = "0x6002EDC"), Address(RVA = "0x3E69D1C", Offset = "0x3E69D1C", VA = "0x3E69D1C")] get
      {
        return (OrganizationParty[]) null;
      }
      [Token(Token = "0x6002EDD"), Address(RVA = "0x3E69D24", Offset = "0x3E69D24", VA = "0x3E69D24")] set
      {
      }
    }

    [Token(Token = "0x170006EC")]
    public Action<OrganizationPartySlot[]> OnOpenToWeaponProficiencyPopup
    {
      [Token(Token = "0x6002EDE"), Address(RVA = "0x3E69D2C", Offset = "0x3E69D2C", VA = "0x3E69D2C")] get
      {
        return (Action<OrganizationPartySlot[]>) null;
      }
      [Token(Token = "0x6002EDF"), Address(RVA = "0x3E69D34", Offset = "0x3E69D34", VA = "0x3E69D34")] set
      {
      }
    }

    [Token(Token = "0x6002EE0")]
    [Address(RVA = "0x3E69D3C", Offset = "0x3E69D3C", VA = "0x3E69D3C", Slot = "4")]
    public virtual void Create()
    {
    }

    [Token(Token = "0x6002EE1")]
    [Address(RVA = "0x3E69DA4", Offset = "0x3E69DA4", VA = "0x3E69DA4", Slot = "5")]
    public virtual void Initialize(
      OrganizationTeam team,
      bool isNeedLp,
      bool isGuildRaid,
      List<string> usedStyleIds,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002EE2")]
    [Address(RVA = "0x3E69F9C", Offset = "0x3E69F9C", VA = "0x3E69F9C")]
    public void UpdateView(
      OrganizationParty organizationParty,
      int index,
      bool isCallSpawnerStartRequest)
    {
    }

    [Token(Token = "0x6002EE3")]
    [Address(RVA = "0x3E6A11C", Offset = "0x3E6A11C", VA = "0x3E6A11C")]
    public void SetStyleSlotAction(
      Action<OrganizationPartySlot, FormationSlotView> onClickUnitSlot)
    {
    }

    [Token(Token = "0x6002EE4")]
    [Address(RVA = "0x3E6A180", Offset = "0x3E6A180", VA = "0x3E6A180")]
    public void SetCustomSkillSlotAction(
      Action<OrganizationPartySlot> onClickCustomSkillSlotButton)
    {
    }

    [Token(Token = "0x6002EE5")]
    [Address(RVA = "0x3E6A1E4", Offset = "0x3E6A1E4", VA = "0x3E6A1E4")]
    public void SetEquipemntSlotAction(
      Action<OrganizationPartySlot, OrganizationEquipmentSlot, FormationSlotEquipmentView> onClickEquipmentSlot = null)
    {
    }

    [Token(Token = "0x6002EE6")]
    [Address(RVA = "0x3E6A248", Offset = "0x3E6A248", VA = "0x3E6A248")]
    public void SetStyleSlotEnchanceAction(
      Action<OrganizationPartySlot> onClickUnitSlotEnchance)
    {
    }

    [Token(Token = "0x6002EE7")]
    [Address(RVA = "0x3E6A2AC", Offset = "0x3E6A2AC", VA = "0x3E6A2AC")]
    public TeamView()
    {
    }
  }
}
