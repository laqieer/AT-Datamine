// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EquipmentSkillEnhanceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001052")]
  [Serializable]
  public sealed class EquipmentSkillEnhanceData : IMasterDataEntity
  {
    [Token(Token = "0x40050D6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40050D7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x40050D8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x40050D9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string image;
    [Token(Token = "0x40050DA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x40050DB")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000E02")]
    public int Key
    {
      [Token(Token = "0x6005EC4"), Address(RVA = "0x28C7224", Offset = "0x28C7224", VA = "0x28C7224", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005EC5")]
    [Address(RVA = "0x28C722C", Offset = "0x28C722C", VA = "0x28C722C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005EC6")]
    [Address(RVA = "0x28C74BC", Offset = "0x28C74BC", VA = "0x28C74BC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E03")]
    public string Name
    {
      [Token(Token = "0x6005EC7"), Address(RVA = "0x28C7584", Offset = "0x28C7584", VA = "0x28C7584")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E04")]
    public string Flavor
    {
      [Token(Token = "0x6005EC8"), Address(RVA = "0x28C7660", Offset = "0x28C7660", VA = "0x28C7660")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005EC9")]
    [Address(RVA = "0x28C773C", Offset = "0x28C773C", VA = "0x28C773C")]
    public EquipmentSkillEnhanceData()
    {
    }
  }
}
