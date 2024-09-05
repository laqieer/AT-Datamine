// Decompiled with JetBrains decompiler
// Type: TeamOrganization.PartySlotEquipmentView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007F4")]
  public class PartySlotEquipmentView : MonoBehaviour
  {
    [Token(Token = "0x4002537")]
    private const string EquipmentSlotPartsAssetBundleName = "ui_page_partylist_partyformation";
    [Token(Token = "0x4002538")]
    private const string EquipmentSlotPartsPrefabName = "EquipmentSlotThumb";
    [Token(Token = "0x4002539")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform[] equipmentWeaponSlotParents;
    [Token(Token = "0x400253A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform equipmentAccessoriesSlotParent;
    [Token(Token = "0x400253B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform equipmentTrustSlotParent;
    [Token(Token = "0x400253C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform equipmentMnemnographSlotParent;
    [Token(Token = "0x400253D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton[] equipmentWeaponSlotButtons;
    [Token(Token = "0x400253E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton equipmentAccessoriesSlotButton;
    [Token(Token = "0x400253F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton equipmentTrustSlotButton;
    [Token(Token = "0x4002540")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton equipmentMnemnographSlotButton;
    [Token(Token = "0x4002541")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton[] equipmentWeaponSlotLockButtons;
    [Token(Token = "0x4002542")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton equipmentAccessoriesSlotLockButton;
    [Token(Token = "0x4002543")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private CommonButton equipmentTrustSlotLockButton;
    [Token(Token = "0x4002544")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private CommonButton equipmentMnemnographSlotLockButton;
    [Token(Token = "0x4002545")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject[] equipmentAttentionIconObjs;
    [Token(Token = "0x4002546")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject[] equipmentUnlockOnObjs;
    [Token(Token = "0x4002547")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject[] equipmentUnlockOffObjs;
    [Token(Token = "0x4002548")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject[] selectObjs;
    [Token(Token = "0x4002549")]
    [FieldOffset(Offset = "0x98")]
    private EquipmentSlotThumb[] weapons;
    [Token(Token = "0x400254A")]
    [FieldOffset(Offset = "0xA0")]
    private EquipmentSlotThumb accessories;
    [Token(Token = "0x400254B")]
    [FieldOffset(Offset = "0xA8")]
    private EquipmentSlotThumb vision;
    [Token(Token = "0x400254C")]
    [FieldOffset(Offset = "0xB0")]
    private EquipmentSlotThumb unitTrust;
    [Token(Token = "0x400254D")]
    [FieldOffset(Offset = "0xB8")]
    private Action<OrganizationPartySlot, OrganizationEquipmentSlot, PartySlotEquipmentView> onClickEquipmentSlot;
    [Token(Token = "0x400254E")]
    [FieldOffset(Offset = "0xC0")]
    private Action<OrganizationPartySlot, OrganizationEquipmentSlot> onLongPressEquipmentSlot;
    [Token(Token = "0x400254F")]
    [FieldOffset(Offset = "0xC8")]
    protected Action<OrganizationPartySlot> onClick;
    [Token(Token = "0x4002550")]
    [FieldOffset(Offset = "0xD0")]
    protected Action<OrganizationPartySlot> onLongPress;
    [Token(Token = "0x4002551")]
    [FieldOffset(Offset = "0xD8")]
    protected OrganizationPartySlot partySlot;
    [Token(Token = "0x4002552")]
    [FieldOffset(Offset = "0xE0")]
    private EquipmentSlotThumb equipmentSlotPrefab;
    [Token(Token = "0x4002553")]
    [FieldOffset(Offset = "0xE8")]
    private Dictionary<int, bool> attentionEquips;
    [Token(Token = "0x4002554")]
    [FieldOffset(Offset = "0xF0")]
    private bool isInitialzed;

    [Token(Token = "0x6002D66")]
    [Address(RVA = "0x3A87410", Offset = "0x3A87410", VA = "0x3A87410")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6002D67")]
    [Address(RVA = "0x3A87430", Offset = "0x3A87430", VA = "0x3A87430")]
    private IEnumerator InitialProcess() => (IEnumerator) null;

    [Token(Token = "0x6002D68")]
    [Address(RVA = "0x3A874C0", Offset = "0x3A874C0", VA = "0x3A874C0")]
    private void SetupOnInitilaled()
    {
    }

    [Token(Token = "0x6002D69")]
    [Address(RVA = "0x3A87634", Offset = "0x3A87634", VA = "0x3A87634")]
    public void UpdateView(OrganizationPartySlot organizationPartySlot)
    {
    }

    [Token(Token = "0x6002D6A")]
    [Address(RVA = "0x3A8753C", Offset = "0x3A8753C", VA = "0x3A8753C")]
    private void ApplyUpdateView()
    {
    }

    [Token(Token = "0x6002D6B")]
    [Address(RVA = "0x3A876D4", Offset = "0x3A876D4", VA = "0x3A876D4")]
    public void UpdateAttentionIcon(PartySlotAttentionData attentionData)
    {
    }

    [Token(Token = "0x6002D6C")]
    [Address(RVA = "0x3A875B8", Offset = "0x3A875B8", VA = "0x3A875B8")]
    public void ApplyUpdateAttentionIcon()
    {
    }

    [Token(Token = "0x6002D6D")]
    [Address(RVA = "0x3A877D8", Offset = "0x3A877D8", VA = "0x3A877D8")]
    private EquipmentSlotThumb CreateEquipmentSlot(
      Transform parent,
      CommonButton button,
      CommonButton lockButton,
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return (EquipmentSlotThumb) null;
    }

    [Token(Token = "0x6002D6E")]
    [Address(RVA = "0x3A8798C", Offset = "0x3A8798C", VA = "0x3A8798C")]
    public void SetEquipmentSlotAction(
      Action<OrganizationPartySlot, OrganizationEquipmentSlot, PartySlotEquipmentView> onClickEquipmentSlot = null)
    {
    }

    [Token(Token = "0x6002D6F")]
    [Address(RVA = "0x3A87994", Offset = "0x3A87994", VA = "0x3A87994")]
    private void UpdateEquipmentView(
      OrganizationEquipmentSlot.EquipmentSlotType slotType,
      EquipmentSlotThumb icon)
    {
    }

    [Token(Token = "0x6002D70")]
    [Address(RVA = "0x3A87B34", Offset = "0x3A87B34", VA = "0x3A87B34")]
    private void OnClickEquipmentSlot(OrganizationEquipmentSlot equipmentSlot)
    {
    }

    [Token(Token = "0x6002D71")]
    [Address(RVA = "0x3A87F74", Offset = "0x3A87F74", VA = "0x3A87F74")]
    private void OnLongPressEquipmentSlot(OrganizationEquipmentSlot equipmentSlot)
    {
    }

    [Token(Token = "0x6002D72")]
    [Address(RVA = "0x3A87AE0", Offset = "0x3A87AE0", VA = "0x3A87AE0")]
    private bool IsUnlock(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return new bool();
    }

    [Token(Token = "0x6002D73")]
    [Address(RVA = "0x3A87C20", Offset = "0x3A87C20", VA = "0x3A87C20")]
    private string GetUnlockMessage(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return (string) null;
    }

    [Token(Token = "0x6002D74")]
    [Address(RVA = "0x3A8805C", Offset = "0x3A8805C", VA = "0x3A8805C")]
    private EquipmentSlotThumb GetEquipmentSlotThumb(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
      return (EquipmentSlotThumb) null;
    }

    [Token(Token = "0x6002D75")]
    [Address(RVA = "0x3A87648", Offset = "0x3A87648", VA = "0x3A87648")]
    private void EquipmentsEach(
      Action<OrganizationEquipmentSlot.EquipmentSlotType> callback)
    {
    }

    [Token(Token = "0x6002D76")]
    [Address(RVA = "0x3A880D4", Offset = "0x3A880D4", VA = "0x3A880D4")]
    public PartySlotEquipmentView()
    {
    }

    [Token(Token = "0x20007F5")]
    public enum WeaponIndex
    {
      [Token(Token = "0x4002556")] MainWeapon,
      [Token(Token = "0x4002557")] SubWeapon1,
      [Token(Token = "0x4002558")] SubWeapon2,
      [Token(Token = "0x4002559")] WeaponMax,
    }
  }
}
