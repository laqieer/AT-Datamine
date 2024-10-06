// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.UIReferences
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000458")]
  [Serializable]
  public class UIReferences
  {
    [Token(Token = "0x40017E9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Equipped equipped;
    [Token(Token = "0x40017EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BelongingsItem belongings;
    [Token(Token = "0x40017EB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private InventoryUI inventoryUI;
    [Token(Token = "0x40017EC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ItemSpriteProvider provider;
    [Token(Token = "0x40017ED")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private WeaponPreviewImageProvider previewImage;
    [Token(Token = "0x40017EE")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private AlertUI alertUI;
    [Token(Token = "0x40017EF")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Inventory inventory;
    [Token(Token = "0x40017F0")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private WeaponsEquipChangeUI equipChangeUI;
    [Token(Token = "0x40017F1")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private WeaponsEquipDetailUI equipDetailUI;

    [Token(Token = "0x170002E6")]
    public Equipped Equipped
    {
      [Token(Token = "0x600189D"), Address(RVA = "0x249158C", Offset = "0x249158C", VA = "0x249158C")] get
      {
        return (Equipped) null;
      }
    }

    [Token(Token = "0x170002E7")]
    public BelongingsItem Belongings
    {
      [Token(Token = "0x600189E"), Address(RVA = "0x2491594", Offset = "0x2491594", VA = "0x2491594")] get
      {
        return (BelongingsItem) null;
      }
    }

    [Token(Token = "0x170002E8")]
    public InventoryUI InventoryUI
    {
      [Token(Token = "0x600189F"), Address(RVA = "0x249159C", Offset = "0x249159C", VA = "0x249159C")] get
      {
        return (InventoryUI) null;
      }
    }

    [Token(Token = "0x170002E9")]
    public WeaponsEquipChangeUI EquipChangeUI
    {
      [Token(Token = "0x60018A0"), Address(RVA = "0x24915A4", Offset = "0x24915A4", VA = "0x24915A4")] get
      {
        return (WeaponsEquipChangeUI) null;
      }
    }

    [Token(Token = "0x170002EA")]
    public WeaponsEquipDetailUI EquipDetailUI
    {
      [Token(Token = "0x60018A1"), Address(RVA = "0x24915AC", Offset = "0x24915AC", VA = "0x24915AC")] get
      {
        return (WeaponsEquipDetailUI) null;
      }
    }

    [Token(Token = "0x170002EB")]
    public Inventory Inventory
    {
      [Token(Token = "0x60018A2"), Address(RVA = "0x24915B4", Offset = "0x24915B4", VA = "0x24915B4")] get
      {
        return (Inventory) null;
      }
    }

    [Token(Token = "0x170002EC")]
    public EquipmentAlertUI EquipmentAlertUI
    {
      [Token(Token = "0x60018A3"), Address(RVA = "0x24915BC", Offset = "0x24915BC", VA = "0x24915BC")] get
      {
        return (EquipmentAlertUI) null;
      }
      [Token(Token = "0x60018A4"), Address(RVA = "0x24915C4", Offset = "0x24915C4", VA = "0x24915C4")] private set
      {
      }
    }

    [Token(Token = "0x60018A5")]
    [Address(RVA = "0x248D510", Offset = "0x248D510", VA = "0x248D510")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60018A6")]
    [Address(RVA = "0x248C990", Offset = "0x248C990", VA = "0x248C990")]
    public void OnEnable()
    {
    }

    [Token(Token = "0x60018A7")]
    [Address(RVA = "0x248CA20", Offset = "0x248CA20", VA = "0x248CA20")]
    public void OnDisable()
    {
    }

    [Token(Token = "0x60018A8")]
    [Address(RVA = "0x248D058", Offset = "0x248D058", VA = "0x248D058")]
    public void Update(UIReferences.IProperty property)
    {
    }

    [Token(Token = "0x60018A9")]
    [Address(RVA = "0x24915F8", Offset = "0x24915F8", VA = "0x24915F8")]
    public UIReferences()
    {
    }

    [Token(Token = "0x2000459")]
    public interface IProperty
    {
      [Token(Token = "0x170002ED")]
      IEnumerable<ItemDetailData> BelongingItems { [Token(Token = "0x60018AA")] get; }
    }
  }
}
