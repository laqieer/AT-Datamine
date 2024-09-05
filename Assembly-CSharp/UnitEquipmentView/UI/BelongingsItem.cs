// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.BelongingsItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnitView;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x200042C")]
  [Serializable]
  public class BelongingsItem : ItemEasyDataUI.IItemSelectEvent
  {
    [Token(Token = "0x400178B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform root;
    [Token(Token = "0x400178C")]
    [FieldOffset(Offset = "0x18")]
    private List<ItemEasyDataUI> easyDataUIs;
    [Token(Token = "0x400178D")]
    [FieldOffset(Offset = "0x20")]
    private BelongingsItem.IBelongingsItemEvent eventReceiver;

    [Token(Token = "0x60017A8")]
    [Address(RVA = "0x248D5B8", Offset = "0x248D5B8", VA = "0x248D5B8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60017A9")]
    [Address(RVA = "0x248D660", Offset = "0x248D660", VA = "0x248D660")]
    private void CreateItems()
    {
    }

    [Token(Token = "0x60017AA")]
    [Address(RVA = "0x248C880", Offset = "0x248C880", VA = "0x248C880")]
    public void RegisterLongTapEvent(ItemEasyDataUI.IItemSelectLongTapEvent receiver)
    {
    }

    [Token(Token = "0x60017AB")]
    [Address(RVA = "0x248D884", Offset = "0x248D884", VA = "0x248D884")]
    public void EventEnable()
    {
    }

    [Token(Token = "0x60017AC")]
    [Address(RVA = "0x248D984", Offset = "0x248D984", VA = "0x248D984")]
    public void EventDisable()
    {
    }

    [Token(Token = "0x60017AD")]
    [Address(RVA = "0x248DA84", Offset = "0x248DA84", VA = "0x248DA84")]
    public void SetReceiver(BelongingsItem.IBelongingsItemEvent eventReceiver)
    {
    }

    [Token(Token = "0x60017AE")]
    [Address(RVA = "0x248DA8C", Offset = "0x248DA8C", VA = "0x248DA8C")]
    public void Reset()
    {
    }

    [Token(Token = "0x60017AF")]
    [Address(RVA = "0x248DB8C", Offset = "0x248DB8C", VA = "0x248DB8C")]
    public void Filtering(ItemDetailData equippedItem)
    {
    }

    [Token(Token = "0x60017B0")]
    [Address(RVA = "0x248DC80", Offset = "0x248DC80", VA = "0x248DC80")]
    private void FilterringByCategory(ItemDetailData equippedItem, ItemEasyDataUI easyDataUI)
    {
    }

    [Token(Token = "0x60017B1")]
    [Address(RVA = "0x248DD48", Offset = "0x248DD48", VA = "0x248DD48")]
    public void UIApply()
    {
    }

    [Token(Token = "0x60017B2")]
    [Address(RVA = "0x248DE48", Offset = "0x248DE48", VA = "0x248DE48")]
    public void Set(IEnumerable<ItemDetailData> datas)
    {
    }

    [Token(Token = "0x60017B3")]
    [Address(RVA = "0x248E4EC", Offset = "0x248E4EC", VA = "0x248E4EC")]
    public void ResetWithoutContent()
    {
    }

    [Token(Token = "0x60017B4")]
    [Address(RVA = "0x248E5EC", Offset = "0x248E5EC", VA = "0x248E5EC")]
    public void Equipped(Equipment equipment)
    {
    }

    [Token(Token = "0x60017B5")]
    [Address(RVA = "0x248E6D0", Offset = "0x248E6D0", VA = "0x248E6D0")]
    public void DisableUIs()
    {
    }

    [Token(Token = "0x60017B6")]
    [Address(RVA = "0x248E7D0", Offset = "0x248E7D0", VA = "0x248E7D0", Slot = "4")]
    private void UnitEquipmentView\u002EUI\u002EItemEasyDataUI\u002EIItemSelectEvent\u002EOnSelect(
      ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x60017B7")]
    [Address(RVA = "0x248E878", Offset = "0x248E878", VA = "0x248E878", Slot = "5")]
    private void UnitEquipmentView\u002EUI\u002EItemEasyDataUI\u002EIItemSelectEvent\u002EOnChangeEquipState(
      ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x60017B8")]
    [Address(RVA = "0x248E924", Offset = "0x248E924", VA = "0x248E924")]
    public BelongingsItem()
    {
    }

    [Token(Token = "0x200042D")]
    public interface IBelongingsItemEvent
    {
      [Token(Token = "0x60017BA")]
      void OnSelect(ItemEasyDataUI selectItem);

      [Token(Token = "0x60017BB")]
      void OnEquip(ItemEasyDataUI selectItem);
    }
  }
}
