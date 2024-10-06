// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardConsumeAllocationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001332")]
  [Serializable]
  public sealed class AbilityBoardConsumeAllocationData : IMasterDataEntity
  {
    [Token(Token = "0x4005A8F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A90")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int consumeId;
    [Token(Token = "0x4005A91")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardId;
    [Token(Token = "0x4005A92")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int itemId;

    [Token(Token = "0x1700105E")]
    public int Key
    {
      [Token(Token = "0x6006C50"), Address(RVA = "0x46F2618", Offset = "0x46F2618", VA = "0x46F2618", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C51")]
    [Address(RVA = "0x46F2620", Offset = "0x46F2620", VA = "0x46F2620", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006C52")]
    [Address(RVA = "0x46F27EC", Offset = "0x46F27EC", VA = "0x46F27EC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006C53")]
    [Address(RVA = "0x46F2890", Offset = "0x46F2890", VA = "0x46F2890")]
    public AbilityBoardConsumeAllocationData()
    {
    }
  }
}
