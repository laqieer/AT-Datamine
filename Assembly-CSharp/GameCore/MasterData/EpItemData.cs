// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EpItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001050")]
  [Serializable]
  public sealed class EpItemData : IMasterDataEntity
  {
    [Token(Token = "0x40050CF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40050D0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x40050D1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x40050D2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string image;
    [Token(Token = "0x40050D3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x40050D4")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000DFF")]
    public int Key
    {
      [Token(Token = "0x6005EBA"), Address(RVA = "0x28C6BFC", Offset = "0x28C6BFC", VA = "0x28C6BFC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005EBB")]
    [Address(RVA = "0x28C6C04", Offset = "0x28C6C04", VA = "0x28C6C04", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005EBC")]
    [Address(RVA = "0x28C6E94", Offset = "0x28C6E94", VA = "0x28C6E94", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E00")]
    public string Name
    {
      [Token(Token = "0x6005EBD"), Address(RVA = "0x28C6F5C", Offset = "0x28C6F5C", VA = "0x28C6F5C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E01")]
    public string Flavor
    {
      [Token(Token = "0x6005EBE"), Address(RVA = "0x28C7038", Offset = "0x28C7038", VA = "0x28C7038")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005EBF")]
    [Address(RVA = "0x28C7114", Offset = "0x28C7114", VA = "0x28C7114")]
    public EpItemData()
    {
    }
  }
}
