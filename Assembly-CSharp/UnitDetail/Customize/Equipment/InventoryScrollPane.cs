// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.Equipment.InventoryScrollPane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UnitDetail.Customize.Equipment
{
  [Token(Token = "0x2000503")]
  public class InventoryScrollPane : UIScrollGridPane
  {
    [Token(Token = "0x4001AD5")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private InventoryScrollCell cellPrefab;
    [Token(Token = "0x4001AD6")]
    [FieldOffset(Offset = "0x90")]
    private IReadOnlyList<ItemInfoBase> inventoryList;
    [Token(Token = "0x4001ADA")]
    [FieldOffset(Offset = "0xB0")]
    private int selectIndex;
    [Token(Token = "0x4001ADB")]
    [FieldOffset(Offset = "0xB8")]
    private InventoryScrollCell selectCell;

    [Token(Token = "0x1700039B")]
    public Action<ItemInfoBase> OnSelectItem
    {
      [Token(Token = "0x6001CC7"), Address(RVA = "0x29F514C", Offset = "0x29F514C", VA = "0x29F514C")] private get
      {
        return (Action<ItemInfoBase>) null;
      }
      [Token(Token = "0x6001CC8"), Address(RVA = "0x29F5154", Offset = "0x29F5154", VA = "0x29F5154")] set
      {
      }
    }

    [Token(Token = "0x1700039C")]
    public Action<ItemInfoBase> OnDetailItem
    {
      [Token(Token = "0x6001CC9"), Address(RVA = "0x29F515C", Offset = "0x29F515C", VA = "0x29F515C")] private get
      {
        return (Action<ItemInfoBase>) null;
      }
      [Token(Token = "0x6001CCA"), Address(RVA = "0x29F5164", Offset = "0x29F5164", VA = "0x29F5164")] set
      {
      }
    }

    [Token(Token = "0x1700039D")]
    public Action<ItemInfoBase> OnConfrimItem
    {
      [Token(Token = "0x6001CCB"), Address(RVA = "0x29F516C", Offset = "0x29F516C", VA = "0x29F516C")] private get
      {
        return (Action<ItemInfoBase>) null;
      }
      [Token(Token = "0x6001CCC"), Address(RVA = "0x29F5174", Offset = "0x29F5174", VA = "0x29F5174")] set
      {
      }
    }

    [Token(Token = "0x1700039E")]
    public bool IsSelectCell
    {
      [Token(Token = "0x6001CCD"), Address(RVA = "0x29F517C", Offset = "0x29F517C", VA = "0x29F517C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6001CCE")]
    [Address(RVA = "0x29F51DC", Offset = "0x29F51DC", VA = "0x29F51DC", Slot = "4")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6001CCF")]
    [Address(RVA = "0x29F5210", Offset = "0x29F5210", VA = "0x29F5210", Slot = "8")]
    protected override void OnEnableItem(UIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x6001CD0")]
    [Address(RVA = "0x29F5218", Offset = "0x29F5218", VA = "0x29F5218")]
    public void AttachData(IReadOnlyList<ItemInfoBase> inventoryList)
    {
    }

    [Token(Token = "0x6001CD1")]
    [Address(RVA = "0x29F52DC", Offset = "0x29F52DC", VA = "0x29F52DC", Slot = "7")]
    protected override void OnModifyItem(UIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x6001CD2")]
    [Address(RVA = "0x29F536C", Offset = "0x29F536C", VA = "0x29F536C")]
    private void OnModifyItem(InventoryScrollCell cell, int index)
    {
    }

    [Token(Token = "0x6001CD3")]
    [Address(RVA = "0x29F50E0", Offset = "0x29F50E0", VA = "0x29F50E0")]
    public void OnDetail(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001CD4")]
    [Address(RVA = "0x29F4FE4", Offset = "0x29F4FE4", VA = "0x29F4FE4")]
    public void OnSelect(ItemInfoBase itemInfo, InventoryScrollCell cell)
    {
    }

    [Token(Token = "0x6001CD5")]
    [Address(RVA = "0x29F5554", Offset = "0x29F5554", VA = "0x29F5554")]
    public void OnConfirm()
    {
    }

    [Token(Token = "0x6001CD6")]
    [Address(RVA = "0x29F5588", Offset = "0x29F5588", VA = "0x29F5588")]
    public ItemInfoBase GetSelectItemInfo() => (ItemInfoBase) null;

    [Token(Token = "0x6001CD7")]
    [Address(RVA = "0x29F560C", Offset = "0x29F560C", VA = "0x29F560C")]
    public InventoryScrollPane()
    {
    }
  }
}
