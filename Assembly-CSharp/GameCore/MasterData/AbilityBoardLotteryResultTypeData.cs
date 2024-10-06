// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardLotteryResultTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200134F")]
  [Serializable]
  public sealed class AbilityBoardLotteryResultTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4005AD6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005AD7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005AD8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int allocationType;

    [Token(Token = "0x1700106A")]
    public int Key
    {
      [Token(Token = "0x6006CD6"), Address(RVA = "0x46F7524", Offset = "0x46F7524", VA = "0x46F7524", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006CD7")]
    [Address(RVA = "0x46F752C", Offset = "0x46F752C", VA = "0x46F752C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006CD8")]
    [Address(RVA = "0x46F7698", Offset = "0x46F7698", VA = "0x46F7698", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006CD9")]
    [Address(RVA = "0x46F7730", Offset = "0x46F7730", VA = "0x46F7730")]
    public AbilityBoardLotteryResultTypeData()
    {
    }
  }
}
