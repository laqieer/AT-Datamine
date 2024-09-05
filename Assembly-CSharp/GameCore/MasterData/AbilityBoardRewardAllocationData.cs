// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardRewardAllocationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001356")]
  [Serializable]
  public sealed class AbilityBoardRewardAllocationData : IMasterDataEntity
  {
    [Token(Token = "0x4005AE1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005AE2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rewardGroupId;
    [Token(Token = "0x4005AE3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int typeId;
    [Token(Token = "0x4005AE4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardId;
    [Token(Token = "0x4005AE5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;
    [Token(Token = "0x4005AE6")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int iconId;

    [Token(Token = "0x1700106D")]
    public int Key
    {
      [Token(Token = "0x6006CF5"), Address(RVA = "0x46F83D4", Offset = "0x46F83D4", VA = "0x46F83D4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006CF6")]
    [Address(RVA = "0x46F83DC", Offset = "0x46F83DC", VA = "0x46F83DC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006CF7")]
    [Address(RVA = "0x46F8668", Offset = "0x46F8668", VA = "0x46F8668", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006CF8")]
    [Address(RVA = "0x46F872C", Offset = "0x46F872C", VA = "0x46F872C")]
    public AbilityBoardRewardAllocationData()
    {
    }
  }
}
