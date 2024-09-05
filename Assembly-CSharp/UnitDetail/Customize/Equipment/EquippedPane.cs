// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.Equipment.EquippedPane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace UnitDetail.Customize.Equipment
{
  [Token(Token = "0x2000501")]
  [Serializable]
  public class EquippedPane : UnitDetailViewBase<UnitDetailInfo>
  {
    [Token(Token = "0x4001ACB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EquipmentCell mainWeapon;
    [Token(Token = "0x4001ACC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private EquipmentCell subWeapon1;
    [Token(Token = "0x4001ACD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private EquipmentCell subWeapon2;
    [Token(Token = "0x4001ACE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private EquipmentCell accessory;
    [Token(Token = "0x4001ACF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private EquipmentCell vision;
    [Token(Token = "0x4001AD0")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private EquipmentCell unitTrust;
    [Token(Token = "0x4001AD1")]
    [FieldOffset(Offset = "0x48")]
    private UnitCustomizeStateHandler stateHandler;

    [Token(Token = "0x6001CB6")]
    [Address(RVA = "0x29F46FC", Offset = "0x29F46FC", VA = "0x29F46FC")]
    public void Initialize(UnitCustomizeStateHandler stateHandler)
    {
    }

    [Token(Token = "0x6001CB7")]
    [Address(RVA = "0x29F4754", Offset = "0x29F4754", VA = "0x29F4754", Slot = "4")]
    protected override void InitializeImpl()
    {
    }

    [Token(Token = "0x6001CB8")]
    [Address(RVA = "0x29F4A54", Offset = "0x29F4A54", VA = "0x29F4A54")]
    private ItemInfoBase GetEquipment(
      StaqData.Equipment equipment,
      OrganizationEquipmentSlot.EquipmentSlotType slotType,
      bool isUnlockd = true)
    {
      return (ItemInfoBase) null;
    }

    [Token(Token = "0x6001CB9")]
    [Address(RVA = "0x29F4C88", Offset = "0x29F4C88", VA = "0x29F4C88", Slot = "5")]
    protected override void UpdateViewImpl()
    {
    }

    [Token(Token = "0x6001CBA")]
    [Address(RVA = "0x29F4C8C", Offset = "0x29F4C8C", VA = "0x29F4C8C")]
    private void OnSelectEquipment(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001CBB")]
    [Address(RVA = "0x29F4D24", Offset = "0x29F4D24", VA = "0x29F4D24")]
    private void OnDetailEquipment(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001CBC")]
    [Address(RVA = "0x29F4CE8", Offset = "0x29F4CE8", VA = "0x29F4CE8")]
    private bool IsUnlock(ItemInfoBase itemInfo) => new bool();

    [Token(Token = "0x6001CBD")]
    [Address(RVA = "0x29F4D80", Offset = "0x29F4D80", VA = "0x29F4D80")]
    public EquippedPane()
    {
    }
  }
}
