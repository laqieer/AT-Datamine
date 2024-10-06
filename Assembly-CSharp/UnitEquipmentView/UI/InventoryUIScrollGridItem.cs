// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.InventoryUIScrollGridItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000438")]
  [Serializable]
  public class InventoryUIScrollGridItem : UIScrollGridItem, ItemEasyDataUI.IItemSelectEvent
  {
    [Token(Token = "0x40017A3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ItemEasyDataUI easyDataUI;
    [Token(Token = "0x40017A4")]
    [FieldOffset(Offset = "0x28")]
    private InventoryUIScrollGridItem.IInventoryUIItemEvent eventReceiver;

    [Token(Token = "0x170002BE")]
    public int Index
    {
      [Token(Token = "0x60017E4"), Address(RVA = "0x248F19C", Offset = "0x248F19C", VA = "0x248F19C")] get
      {
        return new int();
      }
      [Token(Token = "0x60017E5"), Address(RVA = "0x248F1A4", Offset = "0x248F1A4", VA = "0x248F1A4")] private set
      {
      }
    }

    [Token(Token = "0x170002BF")]
    public ItemEasyDataUI EasyDataUI
    {
      [Token(Token = "0x60017E6"), Address(RVA = "0x248F1AC", Offset = "0x248F1AC", VA = "0x248F1AC")] get
      {
        return (ItemEasyDataUI) null;
      }
    }

    [Token(Token = "0x60017E7")]
    [Address(RVA = "0x248F1B4", Offset = "0x248F1B4", VA = "0x248F1B4")]
    public void Apply(
      InventoryUIScrollGridItem.IInventoryUIItemEvent eventReceiver,
      int index)
    {
    }

    [Token(Token = "0x60017E8")]
    [Address(RVA = "0x248F1F8", Offset = "0x248F1F8", VA = "0x248F1F8")]
    public void OnDisableItem()
    {
    }

    [Token(Token = "0x60017E9")]
    [Address(RVA = "0x248F210", Offset = "0x248F210", VA = "0x248F210", Slot = "6")]
    private void UnitEquipmentView\u002EUI\u002EItemEasyDataUI\u002EIItemSelectEvent\u002EOnSelect(
      ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x60017EA")]
    [Address(RVA = "0x248F2B4", Offset = "0x248F2B4", VA = "0x248F2B4", Slot = "7")]
    private void UnitEquipmentView\u002EUI\u002EItemEasyDataUI\u002EIItemSelectEvent\u002EOnChangeEquipState(
      ItemEasyDataUI selectItem)
    {
    }

    [Token(Token = "0x60017EB")]
    [Address(RVA = "0x248F2B8", Offset = "0x248F2B8", VA = "0x248F2B8")]
    public InventoryUIScrollGridItem()
    {
    }

    [Token(Token = "0x2000439")]
    public interface IInventoryUIItemEvent
    {
      [Token(Token = "0x60017EC")]
      void OnSelect(InventoryUIScrollGridItem item);
    }
  }
}
