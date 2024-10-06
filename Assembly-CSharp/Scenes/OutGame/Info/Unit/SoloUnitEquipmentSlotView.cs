// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Unit.SoloUnitEquipmentSlotView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Equipment.UI;
using Scenes.OutGame.Info.Style.UI;
using StaqData;
using System;
using TeamOrganization;

#nullable disable
namespace Scenes.OutGame.Info.Unit
{
  [Token(Token = "0x2003547")]
  public class SoloUnitEquipmentSlotView : PartySlotViewAdapter
  {
    [Token(Token = "0x400E7B0")]
    [FieldOffset(Offset = "0x28")]
    private Action closeAction;
    [Token(Token = "0x400E7B1")]
    [FieldOffset(Offset = "0x30")]
    private Action backAction;
    [Token(Token = "0x400E7B2")]
    [FieldOffset(Offset = "0x38")]
    private StylePopup stylePopup;
    [Token(Token = "0x400E7B3")]
    [FieldOffset(Offset = "0x40")]
    private OrganizationPartySlot selectStyle;
    [Token(Token = "0x400E7B4")]
    [FieldOffset(Offset = "0x48")]
    private EquipmentPopup equipmentPopup;
    [Token(Token = "0x400E7B5")]
    [FieldOffset(Offset = "0x50")]
    private OrganizationEquipmentSlot selectEquip;

    [Token(Token = "0x6014E6F")]
    [Address(RVA = "0x1B49A60", Offset = "0x1B49A60", VA = "0x1B49A60")]
    public SoloUnitEquipmentSlotView(PartySlotView partySlotView, bool isNeedLp)
    {
    }

    [Token(Token = "0x6014E70")]
    [Address(RVA = "0x1B49A6C", Offset = "0x1B49A6C", VA = "0x1B49A6C")]
    public void SetCloseAction(Action action)
    {
    }

    [Token(Token = "0x6014E71")]
    [Address(RVA = "0x1B49A74", Offset = "0x1B49A74", VA = "0x1B49A74")]
    public void SetBackAction(Action action)
    {
    }

    [Token(Token = "0x6014E72")]
    [Address(RVA = "0x1B49A7C", Offset = "0x1B49A7C", VA = "0x1B49A7C", Slot = "5")]
    protected override void SelectStyle(OrganizationPartySlot partySlot)
    {
    }

    [Token(Token = "0x6014E73")]
    [Address(RVA = "0x1B49B34", Offset = "0x1B49B34", VA = "0x1B49B34")]
    private Action CreateStyleEnhanceAction(UniqueID uniqueID) => (Action) null;

    [Token(Token = "0x6014E74")]
    [Address(RVA = "0x1B49EE0", Offset = "0x1B49EE0", VA = "0x1B49EE0", Slot = "6")]
    protected override void SelectEquipment(
      OrganizationPartySlot _,
      OrganizationEquipmentSlot equipmentSlot)
    {
    }

    [Token(Token = "0x6014E75")]
    [Address(RVA = "0x1B49F28", Offset = "0x1B49F28", VA = "0x1B49F28")]
    private void OpenEquipDetail(OrganizationEquipmentSlot equipmentSlot)
    {
    }

    [Token(Token = "0x6014E76")]
    [Address(RVA = "0x1B4A0A4", Offset = "0x1B4A0A4", VA = "0x1B4A0A4")]
    private Action CreateWeaponReinforceAction(UniqueID uniqueID) => (Action) null;

    [Token(Token = "0x6014E77")]
    [Address(RVA = "0x1B4A398", Offset = "0x1B4A398", VA = "0x1B4A398")]
    private Action CreateAccessoryReinforceAction(UniqueID uniqueID) => (Action) null;

    [Token(Token = "0x6014E78")]
    [Address(RVA = "0x1B4A68C", Offset = "0x1B4A68C", VA = "0x1B4A68C")]
    private Action CreateMindEquipmentReinforceAction(UniqueID uniqueID) => (Action) null;
  }
}
