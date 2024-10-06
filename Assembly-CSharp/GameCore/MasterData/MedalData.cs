// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MedalData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001061")]
  [Serializable]
  public sealed class MedalData : IMasterDataEntity
  {
    [Token(Token = "0x4005119")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400511A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400511B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x400511C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x400511D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string image;
    [Token(Token = "0x400511E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x400511F")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public bool isSellable;
    [Token(Token = "0x4005120")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public MedalTypeEnum medalType;

    [Token(Token = "0x17000E17")]
    public int Key
    {
      [Token(Token = "0x6005F14"), Address(RVA = "0x28CA7F4", Offset = "0x28CA7F4", VA = "0x28CA7F4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005F15")]
    [Address(RVA = "0x28CA7FC", Offset = "0x28CA7FC", VA = "0x28CA7FC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005F16")]
    [Address(RVA = "0x28CAB4C", Offset = "0x28CAB4C", VA = "0x28CAB4C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E18")]
    public string Name
    {
      [Token(Token = "0x6005F17"), Address(RVA = "0x28CAC38", Offset = "0x28CAC38", VA = "0x28CAC38")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E19")]
    public string Flavor
    {
      [Token(Token = "0x6005F18"), Address(RVA = "0x28CAD14", Offset = "0x28CAD14", VA = "0x28CAD14")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005F19")]
    [Address(RVA = "0x28CADF0", Offset = "0x28CADF0", VA = "0x28CADF0")]
    public MedalData()
    {
    }
  }
}
