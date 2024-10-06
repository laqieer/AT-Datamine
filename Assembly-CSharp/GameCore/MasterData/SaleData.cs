// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SaleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E9D")]
  [Serializable]
  public sealed class SaleData : IMasterDataEntity
  {
    [Token(Token = "0x40046A7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40046A8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x40046A9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x40046AA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x40046AB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int reward;
    [Token(Token = "0x40046AC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int rewardQuantity;

    [Token(Token = "0x17000D39")]
    public int Key
    {
      [Token(Token = "0x60058E2"), Address(RVA = "0x3C2E610", Offset = "0x3C2E610", VA = "0x3C2E610", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60058E3")]
    [Address(RVA = "0x3C2E618", Offset = "0x3C2E618", VA = "0x3C2E618", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60058E4")]
    [Address(RVA = "0x3C2E8A4", Offset = "0x3C2E8A4", VA = "0x3C2E8A4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60058E5")]
    [Address(RVA = "0x3C2E968", Offset = "0x3C2E968", VA = "0x3C2E968")]
    public SaleData()
    {
    }
  }
}
