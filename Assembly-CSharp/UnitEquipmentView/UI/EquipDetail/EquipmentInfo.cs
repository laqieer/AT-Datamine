// Decompiled with JetBrains decompiler
// Type: UnitEquipmentView.UI.EquipDetail.EquipmentInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitEquipmentView.UI.EquipDetail
{
  [Token(Token = "0x2000463")]
  [Serializable]
  public class EquipmentInfo
  {
    [Token(Token = "0x4001810")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Name name;
    [Token(Token = "0x4001811")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemPreview preview;
    [Token(Token = "0x4001812")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Durability durability;
    [Token(Token = "0x4001813")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Rarity rarity;
    [Token(Token = "0x4001814")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Rank rank;
    [Token(Token = "0x4001815")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private StatusSetContainer statusSet;
    [Token(Token = "0x4001816")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Description description;

    [Token(Token = "0x170002F3")]
    public Name Name
    {
      [Token(Token = "0x60018D7"), Address(RVA = "0x249333C", Offset = "0x249333C", VA = "0x249333C")] get
      {
        return (Name) null;
      }
    }

    [Token(Token = "0x170002F4")]
    public ItemPreview ItemPreview
    {
      [Token(Token = "0x60018D8"), Address(RVA = "0x2493344", Offset = "0x2493344", VA = "0x2493344")] get
      {
        return (ItemPreview) null;
      }
    }

    [Token(Token = "0x170002F5")]
    public Rank Rank
    {
      [Token(Token = "0x60018D9"), Address(RVA = "0x249334C", Offset = "0x249334C", VA = "0x249334C")] get
      {
        return (Rank) null;
      }
    }

    [Token(Token = "0x170002F6")]
    public Rarity Rarity
    {
      [Token(Token = "0x60018DA"), Address(RVA = "0x2493354", Offset = "0x2493354", VA = "0x2493354")] get
      {
        return (Rarity) null;
      }
    }

    [Token(Token = "0x170002F7")]
    public Durability Durability
    {
      [Token(Token = "0x60018DB"), Address(RVA = "0x249335C", Offset = "0x249335C", VA = "0x249335C")] get
      {
        return (Durability) null;
      }
    }

    [Token(Token = "0x170002F8")]
    public StatusSetContainer StatusSet
    {
      [Token(Token = "0x60018DC"), Address(RVA = "0x2493364", Offset = "0x2493364", VA = "0x2493364")] get
      {
        return (StatusSetContainer) null;
      }
    }

    [Token(Token = "0x170002F9")]
    public Description Description
    {
      [Token(Token = "0x60018DD"), Address(RVA = "0x249336C", Offset = "0x249336C", VA = "0x249336C")] get
      {
        return (Description) null;
      }
    }

    [Token(Token = "0x60018DE")]
    [Address(RVA = "0x2492718", Offset = "0x2492718", VA = "0x2492718")]
    public void OnOpen()
    {
    }

    [Token(Token = "0x60018DF")]
    [Address(RVA = "0x24927EC", Offset = "0x24927EC", VA = "0x24927EC")]
    public void OnClose()
    {
    }

    [Token(Token = "0x60018E0")]
    [Address(RVA = "0x24933C4", Offset = "0x24933C4", VA = "0x24933C4")]
    public EquipmentInfo()
    {
    }
  }
}
