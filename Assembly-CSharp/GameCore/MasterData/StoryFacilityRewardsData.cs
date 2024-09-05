// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityRewardsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200122D")]
  [Serializable]
  public sealed class StoryFacilityRewardsData : IMasterDataEntity
  {
    [Token(Token = "0x40056E0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40056E1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int label;
    [Token(Token = "0x40056E2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int ability;
    [Token(Token = "0x40056E3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x40056E4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x40056E5")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000F95")]
    public int Key
    {
      [Token(Token = "0x6006788"), Address(RVA = "0x4D30458", Offset = "0x4D30458", VA = "0x4D30458", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006789")]
    [Address(RVA = "0x4D30460", Offset = "0x4D30460", VA = "0x4D30460", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600678A")]
    [Address(RVA = "0x4D306EC", Offset = "0x4D306EC", VA = "0x4D306EC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600678B")]
    [Address(RVA = "0x4D307B0", Offset = "0x4D307B0", VA = "0x4D307B0")]
    public StoryFacilityRewardsData()
    {
    }
  }
}
