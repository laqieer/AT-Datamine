// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpendablesData
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
  [Token(Token = "0x2001058")]
  [Serializable]
  public sealed class ExpendablesData : IMasterDataEntity
  {
    [Token(Token = "0x40050EF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40050F0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40050F1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x40050F2")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x40050F3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string image;
    [Token(Token = "0x40050F4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x40050F5")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public ItemTypeEnum subType;
    [Token(Token = "0x40050F6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int maxUseCnt;
    [Token(Token = "0x40050F7")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int mobileCnt;
    [Token(Token = "0x40050F8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int skill;
    [Token(Token = "0x40050F9")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int skillLevel;
    [Token(Token = "0x40050FA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int range;
    [Token(Token = "0x40050FB")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000E0B")]
    public int Key
    {
      [Token(Token = "0x6005EE3"), Address(RVA = "0x28C86AC", Offset = "0x28C86AC", VA = "0x28C86AC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005EE4")]
    [Address(RVA = "0x28C86B4", Offset = "0x28C86B4", VA = "0x28C86B4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005EE5")]
    [Address(RVA = "0x28C8BE4", Offset = "0x28C8BE4", VA = "0x28C8BE4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005EE6")]
    [Address(RVA = "0x28C8D20", Offset = "0x28C8D20", VA = "0x28C8D20")]
    public ItemListData GetItemListData(ItemUtility.Parameter parameter) => (ItemListData) null;

    [Token(Token = "0x17000E0C")]
    public string Name
    {
      [Token(Token = "0x6005EE7"), Address(RVA = "0x28C8FE0", Offset = "0x28C8FE0", VA = "0x28C8FE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E0D")]
    public string Flavor
    {
      [Token(Token = "0x6005EE8"), Address(RVA = "0x28C8F04", Offset = "0x28C8F04", VA = "0x28C8F04")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005EE9")]
    [Address(RVA = "0x28C90BC", Offset = "0x28C90BC", VA = "0x28C90BC")]
    public ExpendablesData()
    {
    }
  }
}
