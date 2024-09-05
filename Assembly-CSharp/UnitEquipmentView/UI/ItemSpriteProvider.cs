// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.ItemSpriteProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI
{
  [Token(Token = "0x2000456")]
  [Serializable]
  public class ItemSpriteProvider : Singleton<ItemSpriteProvider>
  {
    [Token(Token = "0x40017E6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SpriteContainer weapons;
    [Token(Token = "0x40017E7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SpriteContainer items;

    [Token(Token = "0x170002E3")]
    public SpriteContainer Weapons
    {
      [Token(Token = "0x6001898"), Address(RVA = "0x249146C", Offset = "0x249146C", VA = "0x249146C")] get
      {
        return (SpriteContainer) null;
      }
    }

    [Token(Token = "0x170002E4")]
    public SpriteContainer Items
    {
      [Token(Token = "0x6001899"), Address(RVA = "0x2491474", Offset = "0x2491474", VA = "0x2491474")] get
      {
        return (SpriteContainer) null;
      }
    }

    [Token(Token = "0x600189A")]
    [Address(RVA = "0x249147C", Offset = "0x249147C", VA = "0x249147C")]
    public ItemSpriteProvider()
    {
    }
  }
}
