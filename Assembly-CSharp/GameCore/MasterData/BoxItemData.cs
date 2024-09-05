// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BoxItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001047")]
  [Serializable]
  public sealed class BoxItemData : IMasterDataEntity
  {
    [Token(Token = "0x400509B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400509C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400509D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x400509E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x400509F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string image;
    [Token(Token = "0x40050A0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x40050A1")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public bool isSellable;
    [Token(Token = "0x40050A2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public BoxItemOpenTypeEnum boxItemOpenTypeId;
    [Token(Token = "0x40050A3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x40050A4")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public DateTime endAt;

    [Token(Token = "0x17000DF0")]
    public int Key
    {
      [Token(Token = "0x6005E85"), Address(RVA = "0x28C4208", Offset = "0x28C4208", VA = "0x28C4208", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E86")]
    [Address(RVA = "0x28C4210", Offset = "0x28C4210", VA = "0x28C4210", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E87")]
    [Address(RVA = "0x28C4620", Offset = "0x28C4620", VA = "0x28C4620", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DF1")]
    public string Name
    {
      [Token(Token = "0x6005E88"), Address(RVA = "0x28C4784", Offset = "0x28C4784", VA = "0x28C4784")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DF2")]
    public string Flavor
    {
      [Token(Token = "0x6005E89"), Address(RVA = "0x28C4860", Offset = "0x28C4860", VA = "0x28C4860")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DF3")]
    public bool HasExpirationDate
    {
      [Token(Token = "0x6005E8A"), Address(RVA = "0x28C493C", Offset = "0x28C493C", VA = "0x28C493C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000DF4")]
    public bool IsWithinExpirationDate
    {
      [Token(Token = "0x6005E8B"), Address(RVA = "0x28C499C", Offset = "0x28C499C", VA = "0x28C499C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6005E8C")]
    [Address(RVA = "0x28C4A90", Offset = "0x28C4A90", VA = "0x28C4A90")]
    public BoxItemData()
    {
    }
  }
}
