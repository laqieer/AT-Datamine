// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ChapterItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame;
using StaqData;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200104A")]
  [Serializable]
  public sealed class ChapterItemData : IMasterDataEntity
  {
    [Token(Token = "0x40050AB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40050AC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x40050AD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x40050AE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string image;
    [Token(Token = "0x40050AF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x40050B0")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int priority;
    [Token(Token = "0x40050B1")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int value;
    [Token(Token = "0x40050B2")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int cost;
    [Token(Token = "0x40050B3")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int chapter;
    [Token(Token = "0x40050B4")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public bool Important;
    [Token(Token = "0x40050B5")]
    [FieldOffset(Offset = "0x3D")]
    [SerializeField]
    public bool reset;
    [Token(Token = "0x40050B6")]
    [FieldOffset(Offset = "0x3E")]
    [SerializeField]
    public bool isSellable;
    [Token(Token = "0x40050B7")]
    [FieldOffset(Offset = "0x3F")]
    [SerializeField]
    public bool removable;
    [Token(Token = "0x40050B8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int bookEffect;
    [Token(Token = "0x40050B9")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int facilityBuffEffect;
    [Token(Token = "0x40050BA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int usableFacilityTag;
    [Token(Token = "0x40050BB")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int communicationItemPreferenceTypeID;
    [Token(Token = "0x40050BC")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int communicationItemPreferenceMatchAddValue;
    [Token(Token = "0x40050BD")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int communicationItemNormalAddValue;

    [Token(Token = "0x17000DF5")]
    public int Key
    {
      [Token(Token = "0x6005E9A"), Address(RVA = "0x28C5060", Offset = "0x28C5060", VA = "0x28C5060", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E9B")]
    [Address(RVA = "0x28C5068", Offset = "0x28C5068", VA = "0x28C5068", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E9C")]
    [Address(RVA = "0x28C57E4", Offset = "0x28C57E4", VA = "0x28C57E4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005E9D")]
    [Address(RVA = "0x28C597C", Offset = "0x28C597C", VA = "0x28C597C")]
    public ItemListData GetItemListData(ItemUtility.Parameter parameter) => (ItemListData) null;

    [Token(Token = "0x17000DF6")]
    public string Name
    {
      [Token(Token = "0x6005E9E"), Address(RVA = "0x28C5B64", Offset = "0x28C5B64", VA = "0x28C5B64")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DF7")]
    public string Flavor
    {
      [Token(Token = "0x6005E9F"), Address(RVA = "0x28C5C40", Offset = "0x28C5C40", VA = "0x28C5C40")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005EA0")]
    [Address(RVA = "0x28C5D1C", Offset = "0x28C5D1C", VA = "0x28C5D1C")]
    public ChapterItemData()
    {
    }
  }
}
