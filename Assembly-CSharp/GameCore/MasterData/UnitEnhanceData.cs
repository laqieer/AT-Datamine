// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.UnitEnhanceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001069")]
  [Serializable]
  public sealed class UnitEnhanceData : IMasterDataEntity
  {
    [Token(Token = "0x4005136")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005137")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4005138")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x4005139")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string image;
    [Token(Token = "0x400513A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x400513B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000E1F")]
    public int Key
    {
      [Token(Token = "0x6005F38"), Address(RVA = "0x28CBE80", Offset = "0x28CBE80", VA = "0x28CBE80", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F39")]
    [Address(RVA = "0x28CBE88", Offset = "0x28CBE88", VA = "0x28CBE88", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F3A")]
    [Address(RVA = "0x28CC118", Offset = "0x28CC118", VA = "0x28CC118", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E20")]
    public string Name
    {
      [Token(Token = "0x6005F3B"), Address(RVA = "0x28CC1E0", Offset = "0x28CC1E0", VA = "0x28CC1E0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E21")]
    public string Flavor
    {
      [Token(Token = "0x6005F3C"), Address(RVA = "0x28CC2BC", Offset = "0x28CC2BC", VA = "0x28CC2BC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005F3D")]
    [Address(RVA = "0x28CC398", Offset = "0x28CC398", VA = "0x28CC398")]
    public UnitEnhanceData()
    {
    }
  }
}
