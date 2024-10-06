// Decompiled with JetBrains decompiler
// Type: TeamOrganization.SlotEquipmentGroupUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007F2")]
  [Serializable]
  public class SlotEquipmentGroupUI
  {
    [Token(Token = "0x400252A")]
    public const string EquipmentSlotPartsAssetBundleName = "ui_page_partylist_partyformation";
    [Token(Token = "0x400252B")]
    public const string EquipmentSlotPartsPrefabName = "EquipmentSlotThumb";
    [Token(Token = "0x400252C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SlotEquipmentUI[] weaponSlots;
    [Token(Token = "0x400252D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SlotEquipmentUI accessorySlot;
    [Token(Token = "0x400252E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SlotEquipmentUI trustSlot;
    [Token(Token = "0x400252F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SlotEquipmentUI mnemnographSlot;

    [Token(Token = "0x170006B6")]
    public SlotEquipmentUI[] WeaponSlots
    {
      [Token(Token = "0x6002D59"), Address(RVA = "0x3A873A8", Offset = "0x3A873A8", VA = "0x3A873A8")] get
      {
        return (SlotEquipmentUI[]) null;
      }
    }

    [Token(Token = "0x170006B7")]
    public SlotEquipmentUI AccessorySlot
    {
      [Token(Token = "0x6002D5A"), Address(RVA = "0x3A873B0", Offset = "0x3A873B0", VA = "0x3A873B0")] get
      {
        return (SlotEquipmentUI) null;
      }
    }

    [Token(Token = "0x170006B8")]
    public SlotEquipmentUI TrustSlot
    {
      [Token(Token = "0x6002D5B"), Address(RVA = "0x3A873B8", Offset = "0x3A873B8", VA = "0x3A873B8")] get
      {
        return (SlotEquipmentUI) null;
      }
    }

    [Token(Token = "0x170006B9")]
    public SlotEquipmentUI MnemnographSlot
    {
      [Token(Token = "0x6002D5C"), Address(RVA = "0x3A873C0", Offset = "0x3A873C0", VA = "0x3A873C0")] get
      {
        return (SlotEquipmentUI) null;
      }
    }

    [Token(Token = "0x6002D5D")]
    [Address(RVA = "0x3A873C8", Offset = "0x3A873C8", VA = "0x3A873C8")]
    public SlotEquipmentGroupUI()
    {
    }
  }
}
