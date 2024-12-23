﻿// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaDailyRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DEB")]
  [Serializable]
  public sealed class ArenaDailyRewardData : IMasterDataEntity
  {
    [Token(Token = "0x400428B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400428C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int arenaDailyRewardSet;
    [Token(Token = "0x400428D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x400428E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x400428F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000C35")]
    public int Key
    {
      [Token(Token = "0x60054F2"), Address(RVA = "0x3AA9960", Offset = "0x3AA9960", VA = "0x3AA9960", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60054F3")]
    [Address(RVA = "0x3AA9968", Offset = "0x3AA9968", VA = "0x3AA9968", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60054F4")]
    [Address(RVA = "0x3AA9B94", Offset = "0x3AA9B94", VA = "0x3AA9B94", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60054F5")]
    [Address(RVA = "0x3AA9C48", Offset = "0x3AA9C48", VA = "0x3AA9C48")]
    public ArenaDailyRewardData()
    {
    }
  }
}
