// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CurrencyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200104C")]
  [Serializable]
  public sealed class CurrencyData : IMasterDataEntity
  {
    [Token(Token = "0x40050BF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40050C0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x40050C1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x40050C2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string image;
    [Token(Token = "0x40050C3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x40050C4")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000DF8")]
    public int Key
    {
      [Token(Token = "0x6005EA5"), Address(RVA = "0x28C5E2C", Offset = "0x28C5E2C", VA = "0x28C5E2C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005EA6")]
    [Address(RVA = "0x28C5E34", Offset = "0x28C5E34", VA = "0x28C5E34", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005EA7")]
    [Address(RVA = "0x28C60C4", Offset = "0x28C60C4", VA = "0x28C60C4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DF9")]
    public string Name
    {
      [Token(Token = "0x6005EA8"), Address(RVA = "0x28C618C", Offset = "0x28C618C", VA = "0x28C618C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DFA")]
    public string Flavor
    {
      [Token(Token = "0x6005EA9"), Address(RVA = "0x28C6268", Offset = "0x28C6268", VA = "0x28C6268")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005EAA")]
    [Address(RVA = "0x28C6344", Offset = "0x28C6344", VA = "0x28C6344")]
    public CurrencyData()
    {
    }
  }
}
