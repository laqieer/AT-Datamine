// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExchangeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001054")]
  [Serializable]
  public sealed class ExchangeData : IMasterDataEntity
  {
    [Token(Token = "0x40050DD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40050DE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x40050DF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x40050E0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string image;
    [Token(Token = "0x40050E1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x40050E2")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x40050E3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int reward;
    [Token(Token = "0x40050E4")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int rewardQuantity;
    [Token(Token = "0x40050E5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000E05")]
    public int Key
    {
      [Token(Token = "0x6005ECE"), Address(RVA = "0x28C784C", Offset = "0x28C784C", VA = "0x28C784C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005ECF")]
    [Address(RVA = "0x28C7854", Offset = "0x28C7854", VA = "0x28C7854", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005ED0")]
    [Address(RVA = "0x28C7C04", Offset = "0x28C7C04", VA = "0x28C7C04", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E06")]
    public string Name
    {
      [Token(Token = "0x6005ED1"), Address(RVA = "0x28C7CFC", Offset = "0x28C7CFC", VA = "0x28C7CFC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E07")]
    public string Flavor
    {
      [Token(Token = "0x6005ED2"), Address(RVA = "0x28C7DD8", Offset = "0x28C7DD8", VA = "0x28C7DD8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005ED3")]
    [Address(RVA = "0x28C7EB4", Offset = "0x28C7EB4", VA = "0x28C7EB4")]
    public ExchangeData()
    {
    }
  }
}
