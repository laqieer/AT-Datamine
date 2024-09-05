// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardLotteryResultTypeAllocationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200134D")]
  [Serializable]
  public sealed class AbilityBoardLotteryResultTypeAllocationData : IMasterDataEntity
  {
    [Token(Token = "0x4005AD2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005AD3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int lotteryResult;
    [Token(Token = "0x4005AD4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int relatedId;
    [Token(Token = "0x4005AD5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int parameter;

    [Token(Token = "0x17001069")]
    public int Key
    {
      [Token(Token = "0x6006CCE"), Address(RVA = "0x46F719C", Offset = "0x46F719C", VA = "0x46F719C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006CCF")]
    [Address(RVA = "0x46F71A4", Offset = "0x46F71A4", VA = "0x46F71A4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006CD0")]
    [Address(RVA = "0x46F7370", Offset = "0x46F7370", VA = "0x46F7370", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006CD1")]
    [Address(RVA = "0x46F7414", Offset = "0x46F7414", VA = "0x46F7414")]
    public AbilityBoardLotteryResultTypeAllocationData()
    {
    }
  }
}
