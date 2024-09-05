// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.ItemCategory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000445")]
  public struct ItemCategory : IComparable, IEquatable<ItemCategory>
  {
    [Token(Token = "0x40017BE")]
    [FieldOffset(Offset = "0x10")]
    private SpriteContainer debugContainer;

    [Token(Token = "0x170002D6")]
    public int ID
    {
      [Token(Token = "0x6001837"), Address(RVA = "0x2490284", Offset = "0x2490284", VA = "0x2490284")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x6001838"), Address(RVA = "0x249028C", Offset = "0x249028C", VA = "0x249028C")] private set
      {
      }
    }

    [Token(Token = "0x170002D7")]
    public string DebugName
    {
      [Token(Token = "0x6001839"), Address(RVA = "0x2490294", Offset = "0x2490294", VA = "0x2490294")] readonly get
      {
        return (string) null;
      }
      [Token(Token = "0x600183A"), Address(RVA = "0x249029C", Offset = "0x249029C", VA = "0x249029C")] private set
      {
      }
    }

    [Token(Token = "0x600183B")]
    [Address(RVA = "0x248FEF4", Offset = "0x248FEF4", VA = "0x248FEF4")]
    public Sprite RandomSprite() => (Sprite) null;

    [Token(Token = "0x600183C")]
    [Address(RVA = "0x24902A4", Offset = "0x24902A4", VA = "0x24902A4", Slot = "4")]
    private int System\u002EIComparable\u002ECompareTo(object obj) => new int();

    [Token(Token = "0x600183D")]
    [Address(RVA = "0x2490320", Offset = "0x2490320", VA = "0x2490320")]
    public ItemCategory(ItemCategory.Type type, string name, SpriteContainer debugContainer)
    {
    }

    [Token(Token = "0x600183E")]
    [Address(RVA = "0x249032C", Offset = "0x249032C", VA = "0x249032C")]
    public bool Is(ItemCategory.Type type) => new bool();

    [Token(Token = "0x600183F")]
    [Address(RVA = "0x2485164", Offset = "0x2485164", VA = "0x2485164")]
    public static bool operator ==(ItemCategory category1, ItemCategory category2) => new bool();

    [Token(Token = "0x6001840")]
    [Address(RVA = "0x249033C", Offset = "0x249033C", VA = "0x249033C")]
    public static bool operator !=(ItemCategory category1, ItemCategory category2) => new bool();

    [Token(Token = "0x6001841")]
    [Address(RVA = "0x248FFE0", Offset = "0x248FFE0", VA = "0x248FFE0")]
    public static ItemCategory CreateWeapon() => new ItemCategory();

    [Token(Token = "0x6001842")]
    [Address(RVA = "0x24900C4", Offset = "0x24900C4", VA = "0x24900C4")]
    public static ItemCategory CreateAccessory() => new ItemCategory();

    [Token(Token = "0x6001843")]
    [Address(RVA = "0x2490140", Offset = "0x2490140", VA = "0x2490140")]
    public static ItemCategory CreateTool() => new ItemCategory();

    [Token(Token = "0x6001844")]
    [Address(RVA = "0x2490350", Offset = "0x2490350", VA = "0x2490350", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6001845")]
    [Address(RVA = "0x24903C8", Offset = "0x24903C8", VA = "0x24903C8", Slot = "5")]
    public bool Equals(ItemCategory other) => new bool();

    [Token(Token = "0x6001846")]
    [Address(RVA = "0x24903DC", Offset = "0x24903DC", VA = "0x24903DC", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x2000446")]
    public enum Type
    {
      [Token(Token = "0x40017C0")] Weapon,
      [Token(Token = "0x40017C1")] Accessory,
      [Token(Token = "0x40017C2")] Tool,
    }
  }
}
