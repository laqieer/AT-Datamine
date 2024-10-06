// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MindEquipmentMedalExchangeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F63")]
  [Serializable]
  public sealed class MindEquipmentMedalExchangeData : IMasterDataEntity
  {
    [Token(Token = "0x4004D2A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004D2B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x4004D2C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int medalExchangeId;
    [Token(Token = "0x4004D2D")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int medalExchangeValue;

    [Token(Token = "0x17000D6A")]
    public int Key
    {
      [Token(Token = "0x6005A84"), Address(RVA = "0x3C3ED30", Offset = "0x3C3ED30", VA = "0x3C3ED30", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005A85")]
    [Address(RVA = "0x3C3ED38", Offset = "0x3C3ED38", VA = "0x3C3ED38", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005A86")]
    [Address(RVA = "0x3C3EF04", Offset = "0x3C3EF04", VA = "0x3C3EF04", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005A87")]
    [Address(RVA = "0x3C3EFA8", Offset = "0x3C3EFA8", VA = "0x3C3EFA8")]
    public MindEquipmentMedalExchangeData()
    {
    }
  }
}
