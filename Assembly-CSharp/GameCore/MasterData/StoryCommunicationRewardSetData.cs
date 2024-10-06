// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationRewardSetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200120D")]
  [Serializable]
  public sealed class StoryCommunicationRewardSetData : IMasterDataEntity
  {
    [Token(Token = "0x400565C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400565D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rewardSetLabel;
    [Token(Token = "0x400565E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardTypeID;
    [Token(Token = "0x400565F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4005660")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardQuantity;

    [Token(Token = "0x17000F83")]
    public int Key
    {
      [Token(Token = "0x60066F3"), Address(RVA = "0x4D2A500", Offset = "0x4D2A500", VA = "0x4D2A500", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60066F4")]
    [Address(RVA = "0x4D2A508", Offset = "0x4D2A508", VA = "0x4D2A508", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60066F5")]
    [Address(RVA = "0x4D2A734", Offset = "0x4D2A734", VA = "0x4D2A734", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000F84")]
    public RewardTypeEnum RewardTypeEnum
    {
      [Token(Token = "0x60066F6"), Address(RVA = "0x4D2A7E8", Offset = "0x4D2A7E8", VA = "0x4D2A7E8")] get
      {
        return new RewardTypeEnum();
      }
    }

    [Token(Token = "0x17000F85")]
    public StaqData.RewardData Reward
    {
      [Token(Token = "0x60066F7"), Address(RVA = "0x4D2A7F0", Offset = "0x4D2A7F0", VA = "0x4D2A7F0")] get
      {
        return (StaqData.RewardData) null;
      }
      [Token(Token = "0x60066F8"), Address(RVA = "0x4D2A7F8", Offset = "0x4D2A7F8", VA = "0x4D2A7F8")] private set
      {
      }
    }

    [Token(Token = "0x60066F9")]
    [Address(RVA = "0x4D2A1BC", Offset = "0x4D2A1BC", VA = "0x4D2A1BC")]
    public void OnLoad()
    {
    }

    [Token(Token = "0x60066FA")]
    [Address(RVA = "0x4D2A800", Offset = "0x4D2A800", VA = "0x4D2A800")]
    public StoryCommunicationRewardSetData()
    {
    }
  }
}
