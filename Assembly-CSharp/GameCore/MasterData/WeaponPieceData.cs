// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponPieceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001071")]
  [Serializable]
  public sealed class WeaponPieceData : IMasterDataEntity
  {
    [Token(Token = "0x4005150")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005151")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4005152")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x4005153")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string image;
    [Token(Token = "0x4005154")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x4005155")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000E28")]
    public int Key
    {
      [Token(Token = "0x6005F5D"), Address(RVA = "0x28CD410", Offset = "0x28CD410", VA = "0x28CD410", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F5E")]
    [Address(RVA = "0x28CD418", Offset = "0x28CD418", VA = "0x28CD418", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F5F")]
    [Address(RVA = "0x28CD6A8", Offset = "0x28CD6A8", VA = "0x28CD6A8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E29")]
    public string Name
    {
      [Token(Token = "0x6005F60"), Address(RVA = "0x28CD770", Offset = "0x28CD770", VA = "0x28CD770")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E2A")]
    public string Flavor
    {
      [Token(Token = "0x6005F61"), Address(RVA = "0x28CD84C", Offset = "0x28CD84C", VA = "0x28CD84C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005F62")]
    [Address(RVA = "0x28CD928", Offset = "0x28CD928", VA = "0x28CD928")]
    public WeaponPieceData()
    {
    }
  }
}
