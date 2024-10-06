// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GachaTicketData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200105A")]
  [Serializable]
  public sealed class GachaTicketData : IMasterDataEntity
  {
    [Token(Token = "0x40050FC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40050FD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40050FE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string ruby;
    [Token(Token = "0x40050FF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string flavor;
    [Token(Token = "0x4005100")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string flavorRuby;
    [Token(Token = "0x4005101")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4005102")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x4005103")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public string image;
    [Token(Token = "0x4005104")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x4005105")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000E0E")]
    public int Key
    {
      [Token(Token = "0x6005EEE"), Address(RVA = "0x28C91CC", Offset = "0x28C91CC", VA = "0x28C91CC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005EEF")]
    [Address(RVA = "0x28C91D4", Offset = "0x28C91D4", VA = "0x28C91D4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005EF0")]
    [Address(RVA = "0x28C95E4", Offset = "0x28C95E4", VA = "0x28C95E4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005EF1")]
    [Address(RVA = "0x28C96FC", Offset = "0x28C96FC", VA = "0x28C96FC")]
    public GachaTicketData()
    {
    }
  }
}
