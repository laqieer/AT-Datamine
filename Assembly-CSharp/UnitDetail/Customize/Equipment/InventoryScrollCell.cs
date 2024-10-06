// Decompiled with JetBrains decompiler
// Type: UnitDetail.Customize.Equipment.InventoryScrollCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UnitDetail.Customize.Equipment
{
  [Token(Token = "0x2000502")]
  public class InventoryScrollCell : UIScrollGridItem
  {
    [Token(Token = "0x4001AD2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private EquipmentCell equipmentCell;
    [Token(Token = "0x4001AD3")]
    [FieldOffset(Offset = "0x20")]
    private InventoryScrollPane owner;

    [Token(Token = "0x1700039A")]
    public int Index
    {
      [Token(Token = "0x6001CBE"), Address(RVA = "0x29F4DC8", Offset = "0x29F4DC8", VA = "0x29F4DC8")] get
      {
        return new int();
      }
      [Token(Token = "0x6001CBF"), Address(RVA = "0x29F4DD0", Offset = "0x29F4DD0", VA = "0x29F4DD0")] private set
      {
      }
    }

    [Token(Token = "0x6001CC0")]
    [Address(RVA = "0x29F4DD8", Offset = "0x29F4DD8", VA = "0x29F4DD8", Slot = "4")]
    public override void Initialize(UIScrollGridPane owner)
    {
    }

    [Token(Token = "0x6001CC1")]
    [Address(RVA = "0x29F4F2C", Offset = "0x29F4F2C", VA = "0x29F4F2C")]
    public void Modify(ItemInfoBase info, int index)
    {
    }

    [Token(Token = "0x6001CC2")]
    [Address(RVA = "0x29F4F94", Offset = "0x29F4F94", VA = "0x29F4F94")]
    public void ChangeCellFrame(bool isSelect, bool isEquip)
    {
    }

    [Token(Token = "0x6001CC3")]
    [Address(RVA = "0x29F4FC8", Offset = "0x29F4FC8", VA = "0x29F4FC8")]
    private void OnSelect(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001CC4")]
    [Address(RVA = "0x29F50AC", Offset = "0x29F50AC", VA = "0x29F50AC")]
    private void OnDetail(ItemInfoBase itemInfo)
    {
    }

    [Token(Token = "0x6001CC5")]
    [Address(RVA = "0x29F50FC", Offset = "0x29F50FC", VA = "0x29F50FC")]
    public ItemInfoBase GetItemInfo() => (ItemInfoBase) null;

    [Token(Token = "0x6001CC6")]
    [Address(RVA = "0x29F5144", Offset = "0x29F5144", VA = "0x29F5144")]
    public InventoryScrollCell()
    {
    }
  }
}
