// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.UnitPieceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200106B")]
  [Serializable]
  public sealed class UnitPieceData : IMasterDataEntity
  {
    [Token(Token = "0x400513D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400513E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x400513F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x4005140")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string image;
    [Token(Token = "0x4005141")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x4005142")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000E22")]
    public int Key
    {
      [Token(Token = "0x6005F42"), Address(RVA = "0x28CC4A8", Offset = "0x28CC4A8", VA = "0x28CC4A8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F43")]
    [Address(RVA = "0x28CC4B0", Offset = "0x28CC4B0", VA = "0x28CC4B0", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F44")]
    [Address(RVA = "0x28CC740", Offset = "0x28CC740", VA = "0x28CC740", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E23")]
    public string Name
    {
      [Token(Token = "0x6005F45"), Address(RVA = "0x28CC808", Offset = "0x28CC808", VA = "0x28CC808")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E24")]
    public string Flavor
    {
      [Token(Token = "0x6005F46"), Address(RVA = "0x28CC8E4", Offset = "0x28CC8E4", VA = "0x28CC8E4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005F47")]
    [Address(RVA = "0x28CC9C0", Offset = "0x28CC9C0", VA = "0x28CC9C0")]
    public UnitPieceData()
    {
    }
  }
}
