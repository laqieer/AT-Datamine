// Decompiled with JetBrains decompiler
// Type: TeamOrganization.FormationSlotEquipmentView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200081C")]
  public class FormationSlotEquipmentView : MonoBehaviour
  {
    [Token(Token = "0x4002667")]
    public const string EquipmentSlotPartsAssetBundleName = "ui_common_thumb";
    [Token(Token = "0x4002668")]
    public const string WeaponSlotPartsPrefabName = "Com_EquipThumb";
    [Token(Token = "0x4002669")]
    public const string AccessorieSlotPartsPrefabName = "Com_ShieldThumb_Equip";
    [Token(Token = "0x400266A")]
    public const string MnemnographSlotPartsPrefabName = "Com_MnemnographThumb";
    [Token(Token = "0x400266B")]
    public const string TrustSlotPartsPrefabName = "Com_TrustThumb";
    [Token(Token = "0x400266C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform[] equipmentWeaponSlotParents;
    [Token(Token = "0x400266D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform equipmentAccessoriesSlotParent;
    [Token(Token = "0x400266E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform equipmentTrustSlotParent;
    [Token(Token = "0x400266F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform equipmentMnemnographSlotParent;
    [Token(Token = "0x4002670")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton[] equipmentWeaponSlotButtons;
    [Token(Token = "0x4002671")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton equipmentAccessoriesSlotButton;
    [Token(Token = "0x4002672")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton equipmentTrustSlotButton;
    [Token(Token = "0x4002673")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton equipmentMnemnographSlotButton;
    [Token(Token = "0x4002674")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject[] lockObjs;
    [Token(Token = "0x4002675")]
    [FieldOffset(Offset = "0x60")]
    private Action<OrganizationPartySlot, OrganizationEquipmentSlot, FormationSlotEquipmentView> onClickEquipmentSlot;
    [Token(Token = "0x4002676")]
    [FieldOffset(Offset = "0x68")]
    private Action<OrganizationPartySlot, OrganizationEquipmentSlot> onLongPressEquipmentSlot;
    [Token(Token = "0x4002677")]
    [FieldOffset(Offset = "0x70")]
    protected Action<OrganizationPartySlot> onClick;
    [Token(Token = "0x4002678")]
    [FieldOffset(Offset = "0x78")]
    protected Action<OrganizationPartySlot> onLongPress;
    [Token(Token = "0x4002679")]
    [FieldOffset(Offset = "0x80")]
    protected OrganizationPartySlot partySlot;
    [Token(Token = "0x400267A")]
    [FieldOffset(Offset = "0x88")]
    private FormationSlotEquipmentThumb equipmentSlotPrefab;
    [Token(Token = "0x400267B")]
    [FieldOffset(Offset = "0x90")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400267C")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private FormationSlotEquipmentThumb[] weapons;
    [Token(Token = "0x400267D")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private FormationSlotEquipmentThumb accessories;
    [Token(Token = "0x400267E")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private FormationSlotMnemnographThumb vision;
    [Token(Token = "0x400267F")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private FormationSlotEquipmentThumb unitTrust;

    [Token(Token = "0x6002E88")]
    [Address(RVA = "0x3E663FC", Offset = "0x3E663FC", VA = "0x3E663FC")]
    public void Initialize(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002E89")]
    [Address(RVA = "0x3E66704", Offset = "0x3E66704", VA = "0x3E66704")]
    public void UpdateView(OrganizationPartySlot organizationPartySlot)
    {
    }

    [Token(Token = "0x6002E8A")]
    [Address(RVA = "0x3E664C4", Offset = "0x3E664C4", VA = "0x3E664C4")]
    private void CreateEquipmentSlot(
      FormationSlotEquipmentThumb equipmentSlot,
      CommonButton button,
      CommonButton lockButton,
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
    }

    [Token(Token = "0x6002E8B")]
    [Address(RVA = "0x3E665F0", Offset = "0x3E665F0", VA = "0x3E665F0")]
    private void CreateEquipmentSlot(
      FormationSlotMnemnographThumb equipmentSlot,
      CommonButton button,
      CommonButton lockButton,
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
    }

    [Token(Token = "0x6002E8C")]
    [Address(RVA = "0x3E668D8", Offset = "0x3E668D8", VA = "0x3E668D8")]
    public void SetEquipemntSlotAction(
      Action<OrganizationPartySlot, OrganizationEquipmentSlot, FormationSlotEquipmentView> onClickEquipmentSlot = null)
    {
    }

    [Token(Token = "0x6002E8D")]
    [Address(RVA = "0x3E668E0", Offset = "0x3E668E0", VA = "0x3E668E0")]
    private void UpdateEquipmentView(
      OrganizationEquipmentSlot.EquipmentSlotType slotType,
      IFormationSlotEquipmentThumb icon)
    {
    }

    [Token(Token = "0x6002E8E")]
    [Address(RVA = "0x3E66AC8", Offset = "0x3E66AC8", VA = "0x3E66AC8")]
    private void OnClickEquipmentSlot(OrganizationEquipmentSlot equipmentSlot)
    {
    }

    [Token(Token = "0x6002E8F")]
    [Address(RVA = "0x3E66FB4", Offset = "0x3E66FB4", VA = "0x3E66FB4")]
    private void OnLongPressEquipmentSlot(OrganizationEquipmentSlot equipmentSlot)
    {
    }

    [Token(Token = "0x6002E90")]
    [Address(RVA = "0x3E66A74", Offset = "0x3E66A74", VA = "0x3E66A74")]
    private bool IsUnlock(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return new bool();
    }

    [Token(Token = "0x6002E91")]
    [Address(RVA = "0x3E66C60", Offset = "0x3E66C60", VA = "0x3E66C60")]
    private string GetUnlockMessage(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return (string) null;
    }

    [Token(Token = "0x6002E92")]
    [Address(RVA = "0x3E6709C", Offset = "0x3E6709C", VA = "0x3E6709C")]
    private IFormationSlotEquipmentThumb GetEquipmentSlotThumb(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return (IFormationSlotEquipmentThumb) null;
    }

    [Token(Token = "0x6002E93")]
    [Address(RVA = "0x3E66790", Offset = "0x3E66790", VA = "0x3E66790")]
    private void EquipmentsEach(
      Action<OrganizationEquipmentSlot.EquipmentSlotType> callback)
    {
    }

    [Token(Token = "0x6002E94")]
    [Address(RVA = "0x3E67110", Offset = "0x3E67110", VA = "0x3E67110")]
    public FormationSlotEquipmentView()
    {
    }
  }
}
