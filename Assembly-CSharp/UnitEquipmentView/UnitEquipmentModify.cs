// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UnitEquipmentModify
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnitEquipmentView.State;
using UnitEquipmentView.UI;
using UnitView.UI.Test;

#nullable disable
namespace UnitEquipmentView
{
  [Token(Token = "0x200042A")]
  public class UnitEquipmentModify : 
    BelongingsItem.IBelongingsItemEvent,
    UnitEquipmentView.UI.Equipped.IEquippedItemEvent,
    ItemEasyDataUI.IItemSelectLongTapEvent
  {
    [Token(Token = "0x4001788")]
    [FieldOffset(Offset = "0x40")]
    private StateHandler subStateHandler;
    [Token(Token = "0x4001789")]
    [FieldOffset(Offset = "0x48")]
    private UIReferences uiReferences;

    [Token(Token = "0x170002AE")]
    public InventoryUI InventoryUI
    {
      [Token(Token = "0x600177E"), Address(RVA = "0x248C598", Offset = "0x248C598", VA = "0x248C598")] get
      {
        return (InventoryUI) null;
      }
    }

    [Token(Token = "0x170002AF")]
    public UnitEquipmentView.UI.Inventory InventoryAnimation
    {
      [Token(Token = "0x600177F"), Address(RVA = "0x248C5B4", Offset = "0x248C5B4", VA = "0x248C5B4")] get
      {
        return (UnitEquipmentView.UI.Inventory) null;
      }
    }

    [Token(Token = "0x170002B0")]
    public BelongingsItem BelongingsItem
    {
      [Token(Token = "0x6001780"), Address(RVA = "0x248C5D0", Offset = "0x248C5D0", VA = "0x248C5D0")] get
      {
        return (BelongingsItem) null;
      }
    }

    [Token(Token = "0x170002B1")]
    public UnitEquipmentView.UI.Equipped EquippedItems
    {
      [Token(Token = "0x6001781"), Address(RVA = "0x248C5EC", Offset = "0x248C5EC", VA = "0x248C5EC")] get
      {
        return (UnitEquipmentView.UI.Equipped) null;
      }
    }

    [Token(Token = "0x170002B2")]
    public EquipmentAlertUI EquipmentAlert
    {
      [Token(Token = "0x6001782"), Address(RVA = "0x248C608", Offset = "0x248C608", VA = "0x248C608")] get
      {
        return (EquipmentAlertUI) null;
      }
    }

    [Token(Token = "0x170002B3")]
    public WeaponsEquipChangeUI EquipChangeUI
    {
      [Token(Token = "0x6001783"), Address(RVA = "0x248C624", Offset = "0x248C624", VA = "0x248C624")] get
      {
        return (WeaponsEquipChangeUI) null;
      }
    }

    [Token(Token = "0x170002B4")]
    public WeaponsEquipDetailUI EquipDetailUI
    {
      [Token(Token = "0x6001784"), Address(RVA = "0x248C640", Offset = "0x248C640", VA = "0x248C640")] get
      {
        return (WeaponsEquipDetailUI) null;
      }
    }

    [Token(Token = "0x170002B5")]
    public bool IsLockedPanelChange
    {
      [Token(Token = "0x6001785"), Address(RVA = "0x248C65C", Offset = "0x248C65C", VA = "0x248C65C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170002B6")]
    public UnitInfo CurrentUnit
    {
      [Token(Token = "0x6001786"), Address(RVA = "0x248C6A8", Offset = "0x248C6A8", VA = "0x248C6A8")] get
      {
        return (UnitInfo) null;
      }
      [Token(Token = "0x6001787"), Address(RVA = "0x248C6B0", Offset = "0x248C6B0", VA = "0x248C6B0")] private set
      {
      }
    }

    [Token(Token = "0x170002B7")]
    public SelectInfo SelectInfo
    {
      [Token(Token = "0x6001788"), Address(RVA = "0x248C6B8", Offset = "0x248C6B8", VA = "0x248C6B8")] get
      {
        return (SelectInfo) null;
      }
    }

    [Token(Token = "0x170002B8")]
    public InventoryItems InventoryItems
    {
      [Token(Token = "0x6001789"), Address(RVA = "0x248C6C0", Offset = "0x248C6C0", VA = "0x248C6C0")] get
      {
        return (InventoryItems) null;
      }
    }

    [Token(Token = "0x170002B9")]
    public SelectInfo.ItemFrameType SelectTypeEquipped
    {
      [Token(Token = "0x600178A"), Address(RVA = "0x248C6C8", Offset = "0x248C6C8", VA = "0x248C6C8")] get
      {
        return (SelectInfo.ItemFrameType) null;
      }
    }

    [Token(Token = "0x170002BA")]
    public SelectInfo.ItemFrameType SelectTypeBelong
    {
      [Token(Token = "0x600178B"), Address(RVA = "0x248C6D0", Offset = "0x248C6D0", VA = "0x248C6D0")] get
      {
        return (SelectInfo.ItemFrameType) null;
      }
    }

    [Token(Token = "0x170002BB")]
    public SelectInfo.ItemFrameType SelectTypeInventory
    {
      [Token(Token = "0x600178C"), Address(RVA = "0x248C6D8", Offset = "0x248C6D8", VA = "0x248C6D8")] get
      {
        return (SelectInfo.ItemFrameType) null;
      }
    }

    [Token(Token = "0x170002BC")]
    private SubState currentSubState
    {
      [Token(Token = "0x600178D"), Address(RVA = "0x248C68C", Offset = "0x248C68C", VA = "0x248C68C")] get
      {
        return (SubState) null;
      }
    }

    [Token(Token = "0x600178E")]
    [Address(RVA = "0x248C6E0", Offset = "0x248C6E0", VA = "0x248C6E0")]
    public UnitEquipmentModify(UnitEquipmentViewMonobehaviour entity)
    {
    }

    [Token(Token = "0x600178F")]
    [Address(RVA = "0x248C960", Offset = "0x248C960", VA = "0x248C960")]
    public void Enter()
    {
    }

    [Token(Token = "0x6001790")]
    [Address(RVA = "0x248C9CC", Offset = "0x248C9CC", VA = "0x248C9CC")]
    public void Exit()
    {
    }

    [Token(Token = "0x6001791")]
    [Address(RVA = "0x248CAA8", Offset = "0x248CAA8", VA = "0x248CAA8")]
    public void SetUnit(UnitInfo unit)
    {
    }

    [Token(Token = "0x6001792")]
    [Address(RVA = "0x248CB78", Offset = "0x248CB78", VA = "0x248CB78")]
    public void ChangeUnit(UnitInfo unit)
    {
    }

    [Token(Token = "0x6001793")]
    [Address(RVA = "0x248C9B0", Offset = "0x248C9B0", VA = "0x248C9B0")]
    public void ChangeSubState(StateHandler.SubStateIndex subState)
    {
    }

    [Token(Token = "0x6001794")]
    [Address(RVA = "0x248CBB4", Offset = "0x248CBB4", VA = "0x248CBB4")]
    public void Back()
    {
    }

    [Token(Token = "0x6001795")]
    [Address(RVA = "0x248CBE4", Offset = "0x248CBE4", VA = "0x248CBE4")]
    public void Reset()
    {
    }

    [Token(Token = "0x6001796")]
    [Address(RVA = "0x248CC20", Offset = "0x248CC20", VA = "0x248CC20")]
    public void Exchange()
    {
    }

    [Token(Token = "0x6001797")]
    [Address(RVA = "0x248CD58", Offset = "0x248CD58", VA = "0x248CD58")]
    private void ItemMove(
      ItemEasyDataUI addItem,
      ItemEasyDataUI removeItem,
      SelectInfo.ItemFrameType destinationFrameType)
    {
    }

    [Token(Token = "0x6001798")]
    [Address(RVA = "0x248CE64", Offset = "0x248CE64", VA = "0x248CE64")]
    private void ItemMove(
      List<ItemDetailData> list,
      ItemDetailData addItem,
      ItemDetailData removeItem)
    {
    }

    [Token(Token = "0x6001799")]
    [Address(RVA = "0x248CFBC", Offset = "0x248CFBC", VA = "0x248CFBC")]
    public void RemoveSelectedItem()
    {
    }

    [Token(Token = "0x600179A")]
    [Address(RVA = "0x248CAB0", Offset = "0x248CAB0", VA = "0x248CAB0")]
    public void Update()
    {
    }

    [Token(Token = "0x600179B")]
    [Address(RVA = "0x248D13C", Offset = "0x248D13C", VA = "0x248D13C")]
    private int Comparison(ItemDetailData item1, ItemDetailData item2) => new int();

    [Token(Token = "0x600179C")]
    [Address(RVA = "0x248D21C", Offset = "0x248D21C", VA = "0x248D21C")]
    public void FilteringInventory(Func<ItemDetailData, bool> predicate)
    {
    }

    [Token(Token = "0x600179D")]
    [Address(RVA = "0x248CBE8", Offset = "0x248CBE8", VA = "0x248CBE8")]
    public void UpdateInventory()
    {
    }

    [Token(Token = "0x600179E")]
    [Address(RVA = "0x248D258", Offset = "0x248D258", VA = "0x248D258")]
    private void OnUpdateInventory()
    {
    }

    [Token(Token = "0x600179F")]
    [Address(RVA = "0x248D2C4", Offset = "0x248D2C4", VA = "0x248D2C4", Slot = "4")]
    private void UnitEquipmentView\u002EUI\u002EBelongingsItem\u002EIBelongingsItemEvent\u002EOnSelect(
      ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x60017A0")]
    [Address(RVA = "0x248D2FC", Offset = "0x248D2FC", VA = "0x248D2FC", Slot = "5")]
    private void UnitEquipmentView\u002EUI\u002EBelongingsItem\u002EIBelongingsItemEvent\u002EOnEquip(
      ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x60017A1")]
    [Address(RVA = "0x248D334", Offset = "0x248D334", VA = "0x248D334")]
    public void Equip(ItemEasyDataUI itemUI, ItemDetailData item)
    {
    }

    [Token(Token = "0x60017A2")]
    [Address(RVA = "0x248D3E0", Offset = "0x248D3E0", VA = "0x248D3E0")]
    public void UnEquip(ItemEasyDataUI itemUI, ItemDetailData item)
    {
    }

    [Token(Token = "0x60017A3")]
    [Address(RVA = "0x248D480", Offset = "0x248D480", VA = "0x248D480", Slot = "6")]
    private void UnitEquipmentView\u002EUI\u002EEquipped\u002EIEquippedItemEvent\u002EOnSelect(
      ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x60017A4")]
    [Address(RVA = "0x248D4B8", Offset = "0x248D4B8", VA = "0x248D4B8", Slot = "7")]
    private void UnitEquipmentView\u002EUI\u002EItemEasyDataUI\u002EIItemSelectLongTapEvent\u002EOnLongTap(
      ItemEasyDataUI selectItem)
    {
    }
  }
}
