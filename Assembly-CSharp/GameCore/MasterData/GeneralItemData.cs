// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GeneralItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200105C")]
  [Serializable]
  public sealed class GeneralItemData : IMasterDataEntity
  {
    [Token(Token = "0x4005107")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005108")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005109")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string flavor;
    [Token(Token = "0x400510A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x400510B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x400510C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string image;
    [Token(Token = "0x400510D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x400510E")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000E0F")]
    public int Key
    {
      [Token(Token = "0x6005EF6"), Address(RVA = "0x28C980C", Offset = "0x28C980C", VA = "0x28C980C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005EF7")]
    [Address(RVA = "0x28C9814", Offset = "0x28C9814", VA = "0x28C9814", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005EF8")]
    [Address(RVA = "0x28C9B64", Offset = "0x28C9B64", VA = "0x28C9B64", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E10")]
    public string Name
    {
      [Token(Token = "0x6005EF9"), Address(RVA = "0x28C9C54", Offset = "0x28C9C54", VA = "0x28C9C54")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E11")]
    public string Flavor
    {
      [Token(Token = "0x6005EFA"), Address(RVA = "0x28C9D30", Offset = "0x28C9D30", VA = "0x28C9D30")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005EFB")]
    [Address(RVA = "0x28C9E0C", Offset = "0x28C9E0C", VA = "0x28C9E0C")]
    public GeneralItemData()
    {
    }
  }
}
