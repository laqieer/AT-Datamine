// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionRapidTicketData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001056")]
  [Serializable]
  public sealed class ExpeditionRapidTicketData : IMasterDataEntity
  {
    [Token(Token = "0x40050E7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40050E8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x40050E9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x40050EA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string image;
    [Token(Token = "0x40050EB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x40050EC")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public bool isSellable;
    [Token(Token = "0x40050ED")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int executionHour;

    [Token(Token = "0x17000E08")]
    public int Key
    {
      [Token(Token = "0x6005ED8"), Address(RVA = "0x28C7FC4", Offset = "0x28C7FC4", VA = "0x28C7FC4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005ED9")]
    [Address(RVA = "0x28C7FCC", Offset = "0x28C7FCC", VA = "0x28C7FCC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005EDA")]
    [Address(RVA = "0x28C82BC", Offset = "0x28C82BC", VA = "0x28C82BC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E09")]
    public string Name
    {
      [Token(Token = "0x6005EDB"), Address(RVA = "0x28C8394", Offset = "0x28C8394", VA = "0x28C8394")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000E0A")]
    public string Flavor
    {
      [Token(Token = "0x6005EDC"), Address(RVA = "0x28C8470", Offset = "0x28C8470", VA = "0x28C8470")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005EDD")]
    [Address(RVA = "0x28C854C", Offset = "0x28C854C", VA = "0x28C854C")]
    public ExpeditionRapidTicketData()
    {
    }
  }
}
