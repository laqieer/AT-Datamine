// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MedalTradeItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001178")]
  [Serializable]
  public sealed class MedalTradeItemData : IMasterDataEntity
  {
    [Token(Token = "0x4005485")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005486")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int PrizeID;
    [Token(Token = "0x4005487")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardTypeID;
    [Token(Token = "0x4005488")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4005489")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardQuantity;

    [Token(Token = "0x17000F36")]
    public int Key
    {
      [Token(Token = "0x6006477"), Address(RVA = "0x4AEFAF4", Offset = "0x4AEFAF4", VA = "0x4AEFAF4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006478")]
    [Address(RVA = "0x4AEFAFC", Offset = "0x4AEFAFC", VA = "0x4AEFAFC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006479")]
    [Address(RVA = "0x4AEFD28", Offset = "0x4AEFD28", VA = "0x4AEFD28", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600647A")]
    [Address(RVA = "0x4AEFDDC", Offset = "0x4AEFDDC", VA = "0x4AEFDDC")]
    public MedalTradeItemData()
    {
    }
  }
}
