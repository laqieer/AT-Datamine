// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200103B")]
  [Serializable]
  public sealed class AbilityBoardItemData : IMasterDataEntity
  {
    [Token(Token = "0x4005075")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005076")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005077")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4005078")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x4005079")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string image;
    [Token(Token = "0x400507A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x400507B")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000DE6")]
    public int Key
    {
      [Token(Token = "0x6005E51"), Address(RVA = "0x28C23F4", Offset = "0x28C23F4", VA = "0x28C23F4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E52")]
    [Address(RVA = "0x28C23FC", Offset = "0x28C23FC", VA = "0x28C23FC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E53")]
    [Address(RVA = "0x28C26EC", Offset = "0x28C26EC", VA = "0x28C26EC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DE7")]
    public string Name
    {
      [Token(Token = "0x6005E54"), Address(RVA = "0x28C27C8", Offset = "0x28C27C8", VA = "0x28C27C8")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DE8")]
    public string Flavor
    {
      [Token(Token = "0x6005E55"), Address(RVA = "0x28C28A4", Offset = "0x28C28A4", VA = "0x28C28A4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005E56")]
    [Address(RVA = "0x28C2980", Offset = "0x28C2980", VA = "0x28C2980")]
    public AbilityBoardItemData()
    {
    }
  }
}
