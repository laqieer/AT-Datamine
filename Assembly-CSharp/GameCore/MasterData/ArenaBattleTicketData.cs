// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaBattleTicketData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200103F")]
  [Serializable]
  public sealed class ArenaBattleTicketData : IMasterDataEntity
  {
    [Token(Token = "0x4005082")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005083")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005084")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string flavor;
    [Token(Token = "0x4005085")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4005086")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x4005087")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string image;
    [Token(Token = "0x4005088")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x4005089")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000DEC")]
    public int Key
    {
      [Token(Token = "0x6005E65"), Address(RVA = "0x28C3048", Offset = "0x28C3048", VA = "0x28C3048", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E66")]
    [Address(RVA = "0x28C3050", Offset = "0x28C3050", VA = "0x28C3050", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E67")]
    [Address(RVA = "0x28C33A0", Offset = "0x28C33A0", VA = "0x28C33A0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005E68")]
    [Address(RVA = "0x28C3490", Offset = "0x28C3490", VA = "0x28C3490")]
    public ArenaBattleTicketData()
    {
    }
  }
}
