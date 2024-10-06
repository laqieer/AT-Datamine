// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.InventoryUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x200045A")]
  [Serializable]
  public class InventoryUI
  {
    [Token(Token = "0x40017F3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private InventoryUIScrollGridPane inventoryScroll;

    [Token(Token = "0x170002EE")]
    public InventoryUIScrollGridPane Scroll
    {
      [Token(Token = "0x60018AB"), Address(RVA = "0x249170C", Offset = "0x249170C", VA = "0x249170C")] get
      {
        return (InventoryUIScrollGridPane) null;
      }
    }

    [Token(Token = "0x60018AC")]
    [Address(RVA = "0x24915CC", Offset = "0x24915CC", VA = "0x24915CC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60018AD")]
    [Address(RVA = "0x248D28C", Offset = "0x248D28C", VA = "0x248D28C")]
    public void Update(int itemsCount)
    {
    }

    [Token(Token = "0x60018AE")]
    [Address(RVA = "0x2491704", Offset = "0x2491704", VA = "0x2491704")]
    public InventoryUI()
    {
    }
  }
}
