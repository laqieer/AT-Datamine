// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ShopConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001186")]
  [Serializable]
  public sealed class ShopConstData : IMasterDataEntity
  {
    [Token(Token = "0x40054AB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40054AC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int maxPurchaseQuantity;
    [Token(Token = "0x40054AD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int maxSaleCategoryCount;
    [Token(Token = "0x40054AE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int maxSaleQuantity;

    [Token(Token = "0x17000F3E")]
    public int Key
    {
      [Token(Token = "0x60064B8"), Address(RVA = "0x4AF1EBC", Offset = "0x4AF1EBC", VA = "0x4AF1EBC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60064B9")]
    [Address(RVA = "0x4AF1EC4", Offset = "0x4AF1EC4", VA = "0x4AF1EC4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60064BA")]
    [Address(RVA = "0x4AF2090", Offset = "0x4AF2090", VA = "0x4AF2090", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60064BB")]
    [Address(RVA = "0x4AF2134", Offset = "0x4AF2134", VA = "0x4AF2134")]
    public ShopConstData()
    {
    }
  }
}
