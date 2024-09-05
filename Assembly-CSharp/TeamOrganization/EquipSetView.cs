// Decompiled with JetBrains decompiler
// Type: TeamOrganization.EquipSetView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
using System;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007D8")]
  public class EquipSetView : MonoBehaviour
  {
    [Token(Token = "0x4002493")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PartySlotView partySlotView;
    [Token(Token = "0x4002494")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UnitNodeDotCell unitNodeDot;
    [Token(Token = "0x4002495")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private EquipSetParameterView equipSetParameterView;
    [Token(Token = "0x4002496")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private WeaponProficiencyView weaponProficiencyView;
    [Token(Token = "0x4002497")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private EquipSetSkillView equipSetSkillView;
    [Token(Token = "0x4002498")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private EquipSetTypeIconView typeIconView;
    [Token(Token = "0x4002499")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject statusObj;
    [Token(Token = "0x400249B")]
    [FieldOffset(Offset = "0x58")]
    private IAssetProvider AssetProvider;
    [Token(Token = "0x400249C")]
    [FieldOffset(Offset = "0x60")]
    private OrganizationPartySlot partySlot;
    [Token(Token = "0x400249D")]
    [FieldOffset(Offset = "0x68")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x1700068E")]
    public CoroutineHandler CoroutineHandler
    {
      [Token(Token = "0x6002C52"), Address(RVA = "0x387C87C", Offset = "0x387C87C", VA = "0x387C87C")] get
      {
        return (CoroutineHandler) null;
      }
      [Token(Token = "0x6002C53"), Address(RVA = "0x387C884", Offset = "0x387C884", VA = "0x387C884")] private set
      {
      }
    }

    [Token(Token = "0x1700068F")]
    public Action<OrganizationPartySlot, OrganizationPartySlot> OnUpdateView
    {
      [Token(Token = "0x6002C54"), Address(RVA = "0x387C88C", Offset = "0x387C88C", VA = "0x387C88C")] get
      {
        return (Action<OrganizationPartySlot, OrganizationPartySlot>) null;
      }
      [Token(Token = "0x6002C55"), Address(RVA = "0x387C894", Offset = "0x387C894", VA = "0x387C894")] set
      {
      }
    }

    [Token(Token = "0x6002C56")]
    [Address(RVA = "0x3876228", Offset = "0x3876228", VA = "0x3876228")]
    public void Initialized(
      OrganizationPartySlot organizationPartySlot,
      bool isNeedLp,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002C57")]
    [Address(RVA = "0x387756C", Offset = "0x387756C", VA = "0x387756C")]
    public void CoroutineHandlerRelease()
    {
    }

    [Token(Token = "0x6002C58")]
    [Address(RVA = "0x387C89C", Offset = "0x387C89C", VA = "0x387C89C")]
    private void Update()
    {
    }

    [Token(Token = "0x6002C59")]
    [Address(RVA = "0x3876B10", Offset = "0x3876B10", VA = "0x3876B10")]
    public void UpdateView(
      OrganizationPartySlot organizationPartySlot,
      OrganizationPartySlot checkSlot)
    {
    }

    [Token(Token = "0x6002C5A")]
    [Address(RVA = "0x3876608", Offset = "0x3876608", VA = "0x3876608")]
    public void UpdateButtonView(bool isStatus)
    {
    }

    [Token(Token = "0x6002C5B")]
    [Address(RVA = "0x387C8B0", Offset = "0x387C8B0", VA = "0x387C8B0")]
    public void UpdateButtonView()
    {
    }

    [Token(Token = "0x6002C5C")]
    [Address(RVA = "0x387C958", Offset = "0x387C958", VA = "0x387C958")]
    public void SetEquipemntSlotAction(
      Action<OrganizationPartySlot, OrganizationEquipmentSlot> onClickEquipmentSlot = null)
    {
    }

    [Token(Token = "0x6002C5D")]
    [Address(RVA = "0x387C974", Offset = "0x387C974", VA = "0x387C974")]
    public void SetCustomSkillSlotAction(
      Action<OrganizationPartySlot> onClickCustomSkillSlotButton)
    {
    }

    [Token(Token = "0x6002C5E")]
    [Address(RVA = "0x387C990", Offset = "0x387C990", VA = "0x387C990")]
    public EquipSetView()
    {
    }
  }
}
