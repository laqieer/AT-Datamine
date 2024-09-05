// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010A2")]
  [Serializable]
  public sealed class MissionRewardData : IMasterDataEntity
  {
    [Token(Token = "0x40051FC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051FD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int missionId;
    [Token(Token = "0x40051FE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardTypeId;
    [Token(Token = "0x40051FF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardId;
    [Token(Token = "0x4005200")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardAmount;

    [Token(Token = "0x17000E59")]
    public int Key
    {
      [Token(Token = "0x600604B"), Address(RVA = "0x28D6048", Offset = "0x28D6048", VA = "0x28D6048", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600604C")]
    [Address(RVA = "0x28D6050", Offset = "0x28D6050", VA = "0x28D6050", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600604D")]
    [Address(RVA = "0x28D627C", Offset = "0x28D627C", VA = "0x28D627C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600604E")]
    [Address(RVA = "0x28D6330", Offset = "0x28D6330", VA = "0x28D6330")]
    public MissionRewardData()
    {
    }
  }
}
