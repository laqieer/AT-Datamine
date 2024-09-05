// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.PlayerConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010BF")]
  [Serializable]
  public sealed class PlayerConstData : IMasterDataEntity
  {
    [Token(Token = "0x4005247")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005248")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int maxAp;
    [Token(Token = "0x4005249")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int apAutoHealingSec;
    [Token(Token = "0x400524A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int maxDayRecoveryCountItem;
    [Token(Token = "0x400524B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int maxDayRecoveryCountCoin;
    [Token(Token = "0x400524C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int nameChangeCoolTimeDays;

    [Token(Token = "0x17000E6C")]
    public int Key
    {
      [Token(Token = "0x60060D2"), Address(RVA = "0x28DABBC", Offset = "0x28DABBC", VA = "0x28DABBC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60060D3")]
    [Address(RVA = "0x28DABC4", Offset = "0x28DABC4", VA = "0x28DABC4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60060D4")]
    [Address(RVA = "0x28DAE50", Offset = "0x28DAE50", VA = "0x28DAE50", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60060D5")]
    [Address(RVA = "0x28DAF14", Offset = "0x28DAF14", VA = "0x28DAF14")]
    public PlayerConstData()
    {
    }
  }
}
