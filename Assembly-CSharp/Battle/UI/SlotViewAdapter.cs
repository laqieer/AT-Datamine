// Decompiled with JetBrains decompiler
// Type: Battle.UI.SlotViewAdapter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Unit;
using System;
using TeamOrganization;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023A6")]
  public class SlotViewAdapter : IUnitEquipmentView
  {
    [Token(Token = "0x40097CB")]
    [FieldOffset(Offset = "0x10")]
    protected UnitSlotView slotView;
    [Token(Token = "0x40097CC")]
    [FieldOffset(Offset = "0x18")]
    protected Action onClickStyle;
    [Token(Token = "0x40097CD")]
    [FieldOffset(Offset = "0x20")]
    protected Action<OrganizationEquipmentSlot.EquipmentSlotType> onClickEquipment;

    [Token(Token = "0x600D9ED")]
    [Address(RVA = "0x22D3E14", Offset = "0x22D3E14", VA = "0x22D3E14")]
    public SlotViewAdapter(UnitSlotView slotView, bool isNeedLp, Action action)
    {
    }

    [Token(Token = "0x600D9EE")]
    [Address(RVA = "0x22D40F0", Offset = "0x22D40F0", VA = "0x22D40F0")]
    public void SetCallback(
      Action onClickStyle,
      Action<OrganizationEquipmentSlot.EquipmentSlotType> onClickEquipment)
    {
    }

    [Token(Token = "0x600D9EF")]
    [Address(RVA = "0x22D40F8", Offset = "0x22D40F8", VA = "0x22D40F8", Slot = "4")]
    public void Set(UnitModelBase model)
    {
    }

    [Token(Token = "0x600D9F0")]
    [Address(RVA = "0x22D4568", Offset = "0x22D4568", VA = "0x22D4568")]
    private void SelectStyle()
    {
    }

    [Token(Token = "0x600D9F1")]
    [Address(RVA = "0x22D4584", Offset = "0x22D4584", VA = "0x22D4584")]
    private void SelectEquipment(
      OrganizationEquipmentSlot.EquipmentSlotType slotType)
    {
    }
  }
}
