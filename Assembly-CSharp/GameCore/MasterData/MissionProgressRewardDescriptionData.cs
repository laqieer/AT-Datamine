// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MissionProgressRewardDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200109E")]
  [Serializable]
  public sealed class MissionProgressRewardDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x40051F1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051F2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int missionProgressRewardId;
    [Token(Token = "0x40051F3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardTypeId;
    [Token(Token = "0x40051F4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardId;
    [Token(Token = "0x40051F5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardAmount;

    [Token(Token = "0x17000E57")]
    public int Key
    {
      [Token(Token = "0x6006039"), Address(RVA = "0x28D55A4", Offset = "0x28D55A4", VA = "0x28D55A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600603A")]
    [Address(RVA = "0x28D55AC", Offset = "0x28D55AC", VA = "0x28D55AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600603B")]
    [Address(RVA = "0x28D57D8", Offset = "0x28D57D8", VA = "0x28D57D8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600603C")]
    [Address(RVA = "0x28D588C", Offset = "0x28D588C", VA = "0x28D588C")]
    public MissionProgressRewardDescriptionData()
    {
    }
  }
}
