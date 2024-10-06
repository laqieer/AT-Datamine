// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BoxItemContentsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001045")]
  [Serializable]
  public sealed class BoxItemContentsData : IMasterDataEntity
  {
    [Token(Token = "0x4005094")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005095")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int boxId;
    [Token(Token = "0x4005096")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x4005097")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int reward;
    [Token(Token = "0x4005098")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardQuantity;
    [Token(Token = "0x4005099")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int lotteryWeight;

    [Token(Token = "0x17000DEF")]
    public int Key
    {
      [Token(Token = "0x6005E7D"), Address(RVA = "0x28C3DA0", Offset = "0x28C3DA0", VA = "0x28C3DA0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E7E")]
    [Address(RVA = "0x28C3DA8", Offset = "0x28C3DA8", VA = "0x28C3DA8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E7F")]
    [Address(RVA = "0x28C4034", Offset = "0x28C4034", VA = "0x28C4034", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005E80")]
    [Address(RVA = "0x28C40F8", Offset = "0x28C40F8", VA = "0x28C40F8")]
    public BoxItemContentsData()
    {
    }
  }
}
